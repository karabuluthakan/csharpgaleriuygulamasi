using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GaleriUygulamasi.Utilities
{
    public static class UtilityManager
    {
        static string[] dosyaTipleri = { "excel", "sheet", "pdf", "word", "presentation", "powerpoint", "octet-stream", "image", "text", "audio", "video" };
        static string[] dosyaIconlar = { "fa fa-file-excel-o", "fa fa-file-excel-o", "fa fa-file-pdf-o", "fa fa-file-word-o", "fa fa-file-powerpoint-o",
                                  "fa fa-file-powerpoint-o","fa fa-file-archive-o","fa fa-image","fa fa-file-text" ,"fa fa-music","fa fa-play"};
        static string[] dosyaClasses = { "bgGreen", "bgGreen", "bgDarkOrange", "bgBlue", "bgOrange", "bgOrange", "bgPurple", "bgLightBlue", "bgGreey", "bgDarkRed", "bgDarkRed" };
        public static byte[] ByteBirlestir(byte[] arrayA, byte[] arrayB)
        {
            byte[] outputBytes = new byte[arrayA.Length + arrayB.Length];
            Buffer.BlockCopy(arrayA, 0, outputBytes, 0, arrayA.Length);
            Buffer.BlockCopy(arrayB, 0, outputBytes, arrayA.Length, arrayB.Length);
            return outputBytes;
        }


        public static string setIcon(string contentType)
        {
            for (int i = 0; i < dosyaTipleri.Length; i++)
            {
                if (contentType.Contains(dosyaTipleri[i]))
                    return dosyaIconlar[i];
            }
            return "fa fa-file-o";
        }
        public static string BytesToString(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }

        public static string setClass(string contentType)
        {
            for (int i = 0; i < dosyaTipleri.Length; i++)
            {
                if (contentType.Contains(dosyaTipleri[i]))
                    return dosyaClasses[i];
            }
            return "bgGreey";
        }
    }
}