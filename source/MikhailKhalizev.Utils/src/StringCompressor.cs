using System.IO;
using System.IO.Compression;

namespace MikhailKhalizev.Utils
{
    public static class StringCompressor
    {
        /// <summary>
        /// Compresses the string.
        /// </summary>
        /// <param name="str">The str.</param>
        public static byte[] CompressStringByGZip(string str)
        {
            using (var ms = new MemoryStream())
            {
                using (var cs = new GZipStream(ms, CompressionMode.Compress, true))
                using (var w = new StreamWriter(cs))
                    w.Write(str);

                return ms.ToArray();
            }
        }

        /// <summary>
        /// Decompresses the string.
        /// </summary>
        /// <param name="data">The compressed str.</param>
        public static string DecompressStringByGZip(byte[] data)
        {
            using (var ms = new MemoryStream(data, false))
            using (var cs = new GZipStream(ms, CompressionMode.Decompress))
            using (var r = new StreamReader(cs))
                return r.ReadToEnd();
        }
    }
}