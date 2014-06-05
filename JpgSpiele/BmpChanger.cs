using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JpgSpiele
{
    static class BmpChanger
    {
      
        #region Gray

        public static Bitmap BmpToGrey(Bitmap bmpBefore)
        {
            Bitmap bmpRet = (Bitmap)bmpBefore.Clone();

            for (int x = 0; x < bmpBefore.Width; x++)
            {
                for (int y = 0; y < bmpBefore.Height; y++)
                {
                    Color colOrig = bmpBefore.GetPixel(x, y);
                    int nAv = (colOrig.R + colOrig.G + colOrig.B) / 3;
                    Color colNew = Color.FromArgb(nAv, nAv, nAv);
                    bmpRet.SetPixel(x, y, colNew);
                }
            }

            return bmpRet;

        } 
        #endregion

        #region Color - Advanced
        internal static Bitmap BmpToColor(Bitmap m_bmpOriginal, int RMin, int RMax, int GMin, int GMax, int BMin, int BMax)
        {
            Bitmap bmpRet = (Bitmap)m_bmpOriginal.Clone();

            for (int x = 0; x < m_bmpOriginal.Width; x++)
            {
                for (int y = 0; y < m_bmpOriginal.Height; y++)
                {
                    Color colOrig = m_bmpOriginal.GetPixel(x, y);
                    int nAv = (colOrig.R + colOrig.G + colOrig.B) / 3;

                    int nR = PercentualNewColor(RMin, RMax, colOrig.R);
                    int nG = PercentualNewColor(GMin, GMax, colOrig.G);
                    int nB = PercentualNewColor(BMin, BMax, colOrig.B);

                    Color colNew = Color.FromArgb(nR, nG, nB);
                    bmpRet.SetPixel(x, y, colNew);
                }
            }

            return bmpRet;
        }

        private static int PercentualNewColor(int Min, int Max, int Orig)
        {
            int nRet = 0;
            double dblDelta = (double)(Max - Min);
            if (dblDelta > 0)
            {
                double dbl1 = dblDelta / 100;
                double dbl2 = (Orig / 2.55);
                nRet = (int)Math.Round(((double)Min) + dbl1 * dbl2);

            }
            return nRet;
        } 
        #endregion

        #region Main-Colorfiltering
        internal static Bitmap BmpToMainColorExtrem(Bitmap m_bmpOriginal)
        {
            Bitmap bmpRet = (Bitmap)m_bmpOriginal.Clone();

            for (int x = 0; x < m_bmpOriginal.Width; x++)
            {
                for (int y = 0; y < m_bmpOriginal.Height; y++)
                {
                    Color colOrig = m_bmpOriginal.GetPixel(x, y);

                    int nR = 0;
                    int nG = 0;
                    int nB = 0;
                    /*if ((colOrig.R == colOrig.G) && (colOrig.R == colOrig.G))
                    {
                        nR = 255;
                        nG = 255;
                        nB = 255;
                    }
                    else if (colOrig.R == colOrig.G)
                    {
                        nR = 255;
                        nG = 255;
                    }
                    else if (colOrig.R == colOrig.B)
                    {
                        nR = 255;
                        nB= 255;
                    }
                    else if (colOrig.G == colOrig.B)
                    {
                        nG = 255;
                        nB = 255;
                    }
                    else*/
                    if ((colOrig.R > colOrig.G) && (colOrig.R > colOrig.G))
                    {
                        nR = 255;
                    }
                    else if (colOrig.G > colOrig.B)
                    {
                        nG = 255;
                    }
                    else
                    {
                        nB = 255;
                    }


                    Color colNew = Color.FromArgb(nR, nG, nB);
                    bmpRet.SetPixel(x, y, colNew);
                }
            }

            return bmpRet;

        }

        internal static Bitmap BmpToMainColor(Bitmap m_bmpOriginal)
        {
            Bitmap bmpRet = (Bitmap)m_bmpOriginal.Clone();

            for (int x = 0; x < m_bmpOriginal.Width; x++)
            {
                for (int y = 0; y < m_bmpOriginal.Height; y++)
                {
                    Color colOrig = m_bmpOriginal.GetPixel(x, y);

                    int nR = 0;
                    int nG = 0;
                    int nB = 0;
                    if ((colOrig.R > colOrig.G) && (colOrig.R > colOrig.G))
                    {
                        nR = colOrig.R;
                    }
                    else if (colOrig.G > colOrig.B)
                    {
                        nG = colOrig.G;
                    }
                    else
                    {
                        nB = colOrig.B;
                    }


                    Color colNew = Color.FromArgb(nR, nG, nB);
                    bmpRet.SetPixel(x, y, colNew);
                }
            }

            return bmpRet;

        }

        
        #endregion

        #region Black&White
        public static Bitmap BmpToBlackWhite(Bitmap bmpBefore, int nLimit)
        {
            Bitmap bmpRet = (Bitmap)bmpBefore.Clone();

            for (int x = 0; x < bmpBefore.Width; x++)
            {
                for (int y = 0; y < bmpBefore.Height; y++)
                {
                    Color colOrig = bmpBefore.GetPixel(x, y);
                    int nAv = (colOrig.R + colOrig.G + colOrig.B) / 3;
                    nAv = nAv >= nLimit ? 255 : 0;
                    Color colNew = Color.FromArgb(nAv, nAv, nAv);
                    bmpRet.SetPixel(x, y, colNew);
                }
            }

            return bmpRet;
        } 
        #endregion

        #region Complenent

        public static Bitmap BmpToComplement(Bitmap bmpBefore)
        {
            Bitmap bmpRet = (Bitmap)bmpBefore.Clone();

            for (int x = 0; x < bmpBefore.Width; x++)
            {
                for (int y = 0; y < bmpBefore.Height; y++)
                {
                    Color colOrig = bmpBefore.GetPixel(x, y);

                    Color colNew = Color.FromArgb(255 - colOrig.R, 255 - colOrig.G, 255 - colOrig.B);
                    bmpRet.SetPixel(x, y, colNew);
                }
            }

            return bmpRet;
        } 
        #endregion

        #region Histogramm-Data
        public static int[][] GetHistoData(Bitmap bmpOriginal)
        {
            int[][] nArRet = null;
            if (bmpOriginal != null)
            {

                nArRet = new int[4][];
                int nPxCount = bmpOriginal.Width * bmpOriginal.Height;
                nArRet[0] = new int[256];
                nArRet[1] = new int[256];
                nArRet[2] = new int[256];
                nArRet[3] = new int[256];
                int nCounter = 0;
                for (int x = 0; x < bmpOriginal.Width; x++)
                {
                    for (int y = 0; y < bmpOriginal.Height; y++)
                    {
                        Color colOrig = bmpOriginal.GetPixel(x, y);
                        int nAv = (colOrig.R + colOrig.G + colOrig.B) / 3;
                        nArRet[0][colOrig.R]++;
                        nArRet[1][colOrig.G]++;
                        nArRet[2][colOrig.B]++;
                        nArRet[3][nAv]++;
                        nCounter++;
                    }
                }

            }
            return nArRet;
        }
        
        #endregion

        #region Low- and HighPassFiltering

        /// <summary>
        /// Low- and Highpassfilter
        /// </summary>
        /// <param name="bmpOriginal"></param>Image
        /// <param name="nValueForOut"></param>
        /// <param name="nValueForIn"></param>
        /// <param name="nValueForMiddle"></param>
        /// <returns>Cloned and filtered image</returns>
        public static Image DoPassFilter(Bitmap bmpOriginal, int nValueForOut, int nValueForIn, int nValueForMiddle)
        {
            Bitmap bmpRet = (Bitmap)bmpOriginal.Clone();
            for (int x = 0; x < bmpOriginal.Width; x++)
            {
                for (int y = 0; y < bmpOriginal.Height; y++)
                {
                    int[] nNew = GetNeighbourAverage(bmpOriginal, x, y, bmpOriginal.Width, bmpOriginal.Height, nValueForIn, nValueForOut, nValueForMiddle);
                    Color colNew = Color.FromArgb(nNew[0], nNew[1], nNew[2]);
                    bmpRet.SetPixel(x, y, colNew);
                }
            }
            return bmpRet;
        }

        /// <summary>
        /// Calculating the average of all neighboured pixels for one coordinate. 
        /// </summary>
        /// <param name="bmp"></param>
        /// <param name="nX"></param>
        /// <param name="nY"></param>
        /// <param name="nXMax"></param>
        /// <param name="nYMax"></param>
        /// <param name="nValueForOut"></param>
        /// <param name="nValueForIn"></param>
        /// <param name="nValueForMiddle"></param>
        /// <returns></returns>
        private static int[] GetNeighbourAverage(Bitmap bmp, int nX, int nY, int nXMax, int nYMax, int nValueForOut, int nValueForIn, int nValueForMiddle)
        {
            int[] nRet = new int[4];
            int nValidFields = 0;
            int nFullValuesRed = 0;
            int nFullValuesGreen = 0;
            int nFullValuesBlue = 0;
            int nFullValuesGray = 0;

            for (int nXAdd = -1; nXAdd <= 1; nXAdd++)
            {
                for (int nYAdd = -1; nYAdd <= 1; nYAdd++)
                {
                    int nCurX = nX + nXAdd;
                    int nCurY = nY + nYAdd;


                    if ((nCurX > 0) && (nCurX < nXMax) && (nCurY > 0) && (nCurY < nYMax))
                    {
                        Color col = bmp.GetPixel(nCurX, nCurY);
                        int nAv = (col.R + col.G + col.B) / 3;

                        if ((nCurX == nX) && (nCurY == nY))
                        {//Middle
                            if (nValueForMiddle != 0)
                            {
                                nFullValuesRed += nValueForMiddle * col.R;
                                nFullValuesGreen += nValueForMiddle * col.G;
                                nFullValuesBlue += nValueForMiddle * col.B;
                                nFullValuesGray += nValueForMiddle * nAv;
                                nValidFields += nValueForMiddle;
                            }
                        }
                        else if ((nCurX == nX) || (nCurY == nY))
                        {//In
                            if (nValueForIn != 0)
                            {
                                nFullValuesRed += nValueForIn * col.R;
                                nFullValuesGreen += nValueForIn * col.G;
                                nFullValuesBlue += nValueForIn * col.B;
                                nFullValuesGray += nValueForIn * nAv;
                                nValidFields += nValueForIn;
                            }
                        }
                        else
                        {//Out
                            if (nValueForOut != 0)
                            {
                                nFullValuesRed += nValueForOut * col.R;
                                nFullValuesGreen += nValueForOut * col.G;
                                nFullValuesBlue += nValueForOut * col.B;
                                nFullValuesGray += nValueForOut * nAv;
                                nValidFields += nValueForOut;
                            }
                        }
                    }
                    else
                    { /*inexistent point */}
                }
            }

            if (nValidFields > 0)
            {
                nRet[0] = nFullValuesRed / nValidFields;
                nRet[1] = nFullValuesGreen / nValidFields;
                nRet[2] = nFullValuesBlue / nValidFields;
                nRet[3] = nFullValuesGray / nValidFields;
                nRet[0] = nRet[0] < 0 ? 0 : nRet[0] > 255 ? 255 : nRet[0];
                nRet[1] = nRet[1] < 0 ? 0 : nRet[1] > 255 ? 255 : nRet[1];
                nRet[2] = nRet[2] < 0 ? 0 : nRet[2] > 255 ? 255 : nRet[2];
                nRet[3] = nRet[3] < 0 ? 0 : nRet[3] > 255 ? 255 : nRet[3];
            }
            else
            {
                Color col = bmp.GetPixel(nX, nY);
                int nAv = (col.R + col.G + col.B) / 3;
                nRet[0] = col.R;
                nRet[1] = col.G;
                nRet[2] = col.B;
                nRet[3] = nAv;
            }
            return nRet;
        } 
        #endregion
    }
}
