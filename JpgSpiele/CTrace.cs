using System;
using System.Diagnostics; // für Process und ProcessModule
using System.IO; //für Path-Klasse
using System.Reflection;
using System.Runtime.InteropServices;
using System.ComponentModel;

using System.Security.AccessControl;
using System.Security;
using System.Text;
using ICSharpCode.SharpZipLib.Zip;
using System.Threading;
using System.Threading.Tasks;




namespace JpgSpiele
{
    /// <summary>
    /// 
    /// </summary>
	public enum ZeitZyklen:int
	{
            /// <summary>
            ///
            /// </summary>
			TRACE_TIME_MONTH = 1,
            /// <summary>
            ///
            /// </summary>
			TRACE_TIME_DAY = 2,
            /// <summary>
            /// 
            /// </summary>
			TRACE_TIME_HOUR = 3,
            /// <summary>
            /// 
            /// </summary>
			TRACE_TIME_MINUTE = 4,
            TRACE_TIME_SECOND = 5,
	}
    public delegate void ExclusiveWriteDelegate(StreamWriter writer,object state);

	/// <summary>
	/// Traceklasse 
	/// dient dem Austracen in eine zu definierende Datei mit einem bestimmbaren Zeitzyklus
	/// </summary>
	
	public class CTrace
	{
        #region Variablen
        /// <summary>
        /// 
        /// </summary>
        protected int m_nZyklus;
        /// <summary>
        /// 
        /// </summary>
        protected bool m_blnTraceActive;
        /// <summary>
        /// 
        /// </summary>
        protected bool m_blnWriteline;
        /// <summary>
        /// 
        /// </summary>
        protected string m_strFile;
        /// <summary>
        /// 
        /// </summary>
        protected DirectoryInfo m_LogDir;
        /// <summary>
        /// 
        /// </summary>
        protected string m_strFilename;



        /// <summary>
        /// 
        /// </summary>
        protected ZeitZyklen m_Zyklus;


        /// <summary>
        /// 
        /// </summary>
        protected TextWriterTraceListener m_TraceFileWriter;
        private TextWriterTraceListener m_TraceListner = null;

        private Stream m_FileStream = null;
        private StreamWriter m_Writer = null;
        private DateTime m_dtStreamCreationTime = DateTime.MinValue;

        private int m_nMinumDiskSpace = 300;
        private bool m_blnNotifyedNotEnougDiskSpace = false;
        private ReaderWriterLockSlim m_Locker = new ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion);
        private bool m_blnKeepFileOpen = true;
        private bool m_blnZipFiles = false;

        private ExclusiveWriteDelegate m_delPrivateWriteText = null;
        
        #endregion


        #region Properties
        #region KeepFileOpen
        /// <summary>
        /// Gets or sets a value indicating whether [keep file open].
        /// </summary>
        /// <value><c>true</c> if [keep file open]; otherwise, <c>false</c>.</value>
        [DefaultValue(true)]
        public bool KeepFileOpen
        {
            get { return (this.m_blnKeepFileOpen); }
            set { this.m_blnKeepFileOpen = value; }
        }
          #endregion 

        /// <summary>
        /// true : schreiben in die Ausgabedatei aktivieren
        /// </summary>
        public bool Activate
        {
            get
            {
                return m_blnTraceActive;
            }
            set
            {
                m_blnTraceActive = value;
            }
        }
        /// <summary>
        /// true : aktiviert die Ausgabe in die Datei mit Writeln, sonst Write
        /// </summary>
        public bool Writeline
        {
            get
            {
                return m_blnWriteline;
            }
            set
            {
                m_blnWriteline = value;
            }
        }

        #region MinumDiskSpace
        /// <summary>
        /// Gets or sets the minum disk space in MB.
        /// </summary>
        /// <value>The minum disk space.</value>
        [DefaultValue(300)]
        public int MinumDiskSpace
        {
            get { return (this.m_nMinumDiskSpace); }
            set { this.m_nMinumDiskSpace = value; }
        }
        #endregion 

        public string FileNameLong { get { return m_strFile; }}

        #region Filename
        /// <summary>
        /// Gets or sets the filename.
        /// </summary>
        /// <value>The filename.</value>
        public string Filename
        {
            get { return (this.m_strFilename); }
            set
            {
                if (value.Length > 30)
                    Debug.Assert(false, "Trace-FileName ist zu lang... (" + value + ")");
                this.m_strFilename = value;
                CloseStreams();
            }
        }
        #endregion


        #region Zyklus
        /// <summary>
        /// Gets or sets the zyklus.
        /// </summary>
        /// <value>The zyklus.</value>
        public ZeitZyklen Zyklus
        {
            get { return (this.m_Zyklus); }
            set { this.m_Zyklus = value; }
        }

        public string ApplicationName
        {
            get
            {
                if (System.Windows.Forms.Application.ProductName.Trim().Length > 0)
                {
                    return System.Windows.Forms.Application.ProductName;
                }
                else
                {
                    FileInfo fi = new FileInfo(Assembly.GetExecutingAssembly().CodeBase);
                    return fi.Name.Substring(0, fi.Name.Length - fi.Extension.Length);
                }
            }
            set { }
            //Do nothing
        }
        #endregion

        #region ZipFiles
        
        /// <summary>
        /// True: Zipt eine vollendete Logdatei am Ende des Zyklus
        /// </summary>
        public bool ZipFiles
        {
            get { return m_blnZipFiles; }
            set { m_blnZipFiles = value; }
        }
        #endregion

        #endregion

		/// <summary>
		/// Konstruktor : Name der Datei, Pfad der Datei, Zyklus des Ringspeichers
		/// </summary>
        public CTrace(string strFilename, string strFilepath, ZeitZyklen nZyklus)
        {
            m_delPrivateWriteText = new ExclusiveWriteDelegate(PrivateWriteText);
            m_blnTraceActive = true;
            m_blnWriteline = true;

            if (strFilepath.Length == 0)
            {
                // Default Log Verzeichnis setzen
                strFilepath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\";
            }
            else if (!strFilepath.EndsWith(@"\"))
                strFilepath += @"\";
            m_strFilename = strFilename;
            m_LogDir = new DirectoryInfo(strFilepath);

          /*  if (!Security.CheckAccessRights(m_LogDir,
                FileSystemRights.Write |
                FileSystemRights.AppendData |
                FileSystemRights.CreateFiles))
            {
                HandleMissingDirectoryAccess();
            }
            else { }*/
            try
            {
                if (!m_LogDir.Exists)
                    m_LogDir.Create();
            }
            catch (Exception e)
            {
                Console.WriteLine("Faild to create Logdir {0}: {1}", m_LogDir, e.Message);
            }
            m_Zyklus = nZyklus;
            
        }


        public void Trace( string strArgument, params Object[] Formate)
        {
            Trace(true, strArgument, Formate);
        }

		/// <summary>   
		/// Tracen : Ausgabestring, Formatiererliste
		/// </summary>
		public void Trace(bool blnTimeString, string strArgument,params Object []Formate)
		{
			string strTrace = string.Empty;
			//System.Diagnostics.Trace.AutoFlush = false;

			//löschen und leeren des Listeners - Objectes, damit das Ringspeicherprinzip greifen kann
            if (blnTimeString)
            {
                DateTime date = DateTime.Now;
                strTrace = string.Format("{0:dd.MM.yy HH:mm:ss}", date);
                strTrace += string.Format(".{0:000} ", date.Millisecond);
            }
            else { }

            strTrace += String.Format(strArgument, Formate);
            ExclusiveWrite(m_delPrivateWriteText,strTrace);
		}
        

        private void PrivateWriteText(StreamWriter writer, object state)
        {
            if (m_blnWriteline)
                m_Writer.WriteLine(state as string);
            else
                m_Writer.Write(state as string);
        }

        

        public void ExclusiveWrite(ExclusiveWriteDelegate del, object state)
        {
            if (m_blnTraceActive)
            {
                m_Locker.EnterWriteLock();
                {
                    try
                    {
                        CheckStream();

                        if (EnoughDiskSpace())
                        {
                            m_blnNotifyedNotEnougDiskSpace = false;
                        
                            del.Invoke(m_Writer, state);

                            m_Writer.Flush();
                            m_FileStream.Flush();
                        }
                        else
                        {
                            if (!m_blnNotifyedNotEnougDiskSpace)
                            {
                                m_blnNotifyedNotEnougDiskSpace = true;
                                DateTime date = DateTime.Now;
                                string strTrace = string.Format("{0:dd.MM.yy HH:mm:ss}", date);
                                strTrace += string.Format(".{0:000} Free diskspace under-run the minimum of {1} mb to trace. Tracing will be deaktivated until the free diskspace exceeds the {1} mb limit.", date.Millisecond, MinumDiskSpace);
                                m_Writer.WriteLine();
                                m_Writer.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                                m_Writer.WriteLine(strTrace);
                                m_Writer.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                                m_Writer.WriteLine();
                                m_Writer.Flush();
                                m_FileStream.Flush();
                                CloseStreams();
                            }
                            else
                            {
                                //Already notifyed...
                            }
                        }

                        if (!KeepFileOpen)
                        {
                            CloseStreams();
                        }
                        else { }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Fehler beim Tracen: {0}", ex.ToString());

                        CloseStreams();
                    }
                }
                m_Locker.ExitWriteLock();
            }
            else
            {
                try
                {
                    if (m_TraceListner == null)
                        m_TraceListner = new TextWriterTraceListener(System.Console.Out);
                    if (!Debug.Listeners.Contains(m_TraceListner))
                        Debug.Listeners.Add(m_TraceListner);

                    /*
                    if (m_blnWriteline)
                        Debug.WriteLine(strTrace);
                    else
                        Debug.Write(strTrace);*/
                }
                catch
                {
                }

            }
        }

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern bool GetDiskFreeSpaceEx(string lpDirectoryName,
           out ulong lpFreeBytesAvailable,
           out ulong lpTotalNumberOfBytes,
           out ulong lpTotalNumberOfFreeBytes);

        /// <summary>
        /// Ermittlet ob auf der HDD noch ausreichend Platz vorhanden ist.
        /// </summary>
        /// <returns></returns>
        private bool EnoughDiskSpace()
        {
            ulong lFreeBytes;
            ulong lFreeAvailBytes;
            ulong lTotalBytes;

            GetDiskFreeSpaceEx(m_LogDir.Root.FullName, out lFreeAvailBytes, out lTotalBytes, out lFreeBytes);

            return lFreeAvailBytes / 1024d / 1024d > MinumDiskSpace;
        }

        private void CloseStreams()
        {
            if (m_Writer != null)
            {
                try
                {
                    m_Writer.Close();
                    m_Writer.Dispose();
                }
                catch { }
                m_Writer = null;
            }
            else { }
            if (m_FileStream != null)
            {
                try
                {
                    m_FileStream.Close();
                    m_FileStream.Dispose();
                }
                catch { }
                m_FileStream = null;
            }
            else { }

        }
        private bool m_blnUsingLocalAppDataFolder = false;
        private void HandleMissingDirectoryAccess()
        {
            m_blnUsingLocalAppDataFolder =  true;
            //Kein Schreibrecht auf den Ordner!
            string strNewDir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "inray Industriesoftware");
            strNewDir = Path.Combine(strNewDir, ApplicationName);
            strNewDir = Path.Combine(strNewDir, "Logfiles");
            Console.WriteLine("No acces to logdir {0}, using {1}", m_LogDir, strNewDir);
            m_LogDir = new DirectoryInfo(strNewDir);

            try
            {
                if (!m_LogDir.Exists)
                    m_LogDir.Create();
            }
            catch (Exception e)
            {
                Console.WriteLine("Faild to create Logdir {0}: {1}", m_LogDir, e.Message);
            }
        }
		/// <summary>
		/// erstellt den Filename und überprüft den Ringspeicher
		/// </summary>
		private void CheckStream()
		{
			string strAkt = "";
			DateTime dtNow = DateTime.Now;
            bool blnRecreate = m_Writer == null || m_FileStream == null;
			switch(m_Zyklus)
			{
				case ZeitZyklen.TRACE_TIME_MONTH:
					//strAkt = DateTime.Now.ToString("MM");
                    if (blnRecreate ||
                        m_dtStreamCreationTime.Date.AddMonths(1) 
                        <= dtNow)
                    {
                        strAkt = dtNow.ToString("MM");
                        blnRecreate = true;
                    }
                    else
                    {
                    }
					break;

				case ZeitZyklen.TRACE_TIME_DAY:
					//strAkt = DateTime.Now.ToString("dd");
                    if (blnRecreate ||
                        m_dtStreamCreationTime.Date.AddDays(1) 
                        <= dtNow)
                    {
                        blnRecreate = true;
                        strAkt = dtNow.ToString("dd");
                    }
                    else
                    {
                    }
					break;

				case ZeitZyklen.TRACE_TIME_HOUR:
					//strAkt = DateTime.Now.ToString("HH");
                    if (blnRecreate ||
                        m_dtStreamCreationTime.AddMinutes(m_dtStreamCreationTime.Minute * -1).AddHours(1) 
                        <= dtNow)
                    {
                        strAkt = dtNow.ToString("HH");
                        blnRecreate = true;
                    }
                    else
                    {
                    }
					break;

				case ZeitZyklen.TRACE_TIME_MINUTE:
					//strAkt = DateTime.Now.ToString("mm");
                    if (blnRecreate ||
                        m_dtStreamCreationTime.AddSeconds(m_dtStreamCreationTime.Second * -1).AddMinutes(1) 
                        <= dtNow)
                    {
                        strAkt = dtNow.ToString("mm");
                        blnRecreate = true;
                    }
                    else
                    {
                    }
					break;

                case ZeitZyklen.TRACE_TIME_SECOND:
                    //strAkt = DateTime.Now.ToString("mm");
                    if (blnRecreate ||
                        m_dtStreamCreationTime.AddMilliseconds(m_dtStreamCreationTime.Millisecond * -1).AddSeconds(1)
                        <= dtNow)
                    {
                        strAkt = dtNow.ToString("ss");
                        blnRecreate = true;
                    }
                    else
                    {
                    }
                    break;
				default:
                    throw new InvalidProgramException("Unknown ZeitZyklen " + m_Zyklus.ToString());
			}

            if (blnRecreate )
            {
                CloseStreams();
                

                if (m_blnZipFiles && !string.IsNullOrEmpty(m_strFile))
                {
                     string strTempFile = m_strFile.Replace(".txt", "") + "_temp.txt";
                    File.Move(m_strFile, strTempFile);

                    ZipLogFile(m_strFile, strTempFile);
                }
                else
                {
                    //Keine Zipfile-Behandlung
                }
                
                m_strFile =Path.Combine(m_LogDir.FullName , m_strFilename +"_" +strAkt +".txt");
                FileInfo[] files = null;

                if(m_blnZipFiles)
                    files = new FileInfo[]{ new FileInfo(m_strFile),new FileInfo(m_strFile.Replace(".txt",".zip"))};
                else
                    files = new FileInfo[] { new FileInfo(m_strFile)};

                FileInfo file = m_blnZipFiles ? new FileInfo(m_strFile.Replace(".txt",".zip")) : new FileInfo(m_strFile);
                m_dtStreamCreationTime = dtNow;
                try
                {
                    if (file.Exists)
                    {
                        DateTime dt = file.LastWriteTime;
                        //Überprüfen ob die Datei gelöscht werden muss
                        switch (m_Zyklus)
                        {
                            case ZeitZyklen.TRACE_TIME_MONTH:
                                if (dt.AddMonths(1) < dtNow)
                                    for (int i = 0; i < files.Length; ++i)
                                        files[i].Delete();
                                break;

                            case ZeitZyklen.TRACE_TIME_DAY:
                                if (dt.AddDays(1) < dtNow)
                                    for (int i = 0; i < files.Length; ++i)
                                        files[i].Delete();
                                break;

                            case ZeitZyklen.TRACE_TIME_HOUR:
                                if (dt.AddHours(1) < dtNow)
                                    for (int i = 0; i < files.Length; ++i)
                                        files[i].Delete();
                                break;

                            case ZeitZyklen.TRACE_TIME_MINUTE:
                                if (dt.AddMinutes(1) < dtNow)
                                    for (int i = 0; i < files.Length; ++i)
                                        files[i].Delete();
                                break;
                            case ZeitZyklen.TRACE_TIME_SECOND:
                                if (dt.AddSeconds(1) < dtNow)
                                    for (int i = 0; i < files.Length; ++i)
                                        files[i].Delete();
                                break;
                            default:
                                break;
                        }
                    }
                    else { }
                }
                catch { }

                file = new FileInfo(m_strFile);

                try
                {
                    m_FileStream = file.Open(FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                    //new FileStream(
                    m_Writer = new StreamWriter(m_FileStream);
                }
                catch (UnauthorizedAccessException)
                {
                    if (!m_blnUsingLocalAppDataFolder)
                    {
                        HandleMissingDirectoryAccess();
                        CheckStream();
                    }
                    else
                    {
                        //Ist schon lokal storage...
                    }
                }
            }
            else
            {
            }
            
		}

        private async void ZipLogFile(string strFileName, string strTempFileName)
        {
            await ZipLogFileAsync(strFileName, strTempFileName);
        }

        private async Task ZipLogFileAsync(string strFileName, string strTempFileName)
        {

            string strZipPath = strFileName.Replace(".txt", ".zip");
            try
            {
                //Alte Datei wird gezipt, bevor die neue erstellt wird. Alte Textfile wird gelöscht
                if (File.Exists(strTempFileName))
                {
                    using (ZipFile zip = ZipFile.Create(strZipPath))
                    {
                        zip.NameTransform = new ZipNameTransform(m_LogDir.FullName);
                        zip.BeginUpdate();
                        zip.Add(strTempFileName, strFileName);
                        zip.CommitUpdate();
                    }

                    File.Delete(strTempFileName);
                }
            }
            catch (Exception ex)
            {
                //TODO: Error
            }

            await Task.Delay(1);
        }

	}
}
