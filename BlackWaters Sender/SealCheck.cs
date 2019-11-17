using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace TrinitySeal
{
    internal class SealCheck
    {
        public static bool isValidDLL;

        public static void HashChecks()
        {
            if (CalculateMD5("Newtonsoft.Json.dll") != "4df6c8781e70c3a4912b5be796e6d337" ||
                CalculateMD5(typeof(Seal).Assembly.Location) != "0788cb32d5eb03916c701e0d18e25a74")
            {
                MessageBox.Show("Hash check failed! Exiting...", "TrinitySeal", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Process.GetCurrentProcess().Kill();
            }
            else
            {
                isValidDLL = true;
            }
        }

        private static string CalculateMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }
    }
}