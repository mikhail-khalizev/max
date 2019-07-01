using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;

namespace MikhailKhalizev.Utils
{
    public class Misc
    {
        public static string CompressedSerializeToBase64<T>(T obj)
        {
            var formatter = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                using (var cs = new GZipStream(ms, CompressionMode.Compress, true))
                    formatter.Serialize(cs, obj);
                ms.Position = 0;
                return Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
            }
        }

        public static T CompressedDeserializeFromBase64<T>(string obj)
        {
            var gzip = Convert.FromBase64String(obj);

            var formatter = new BinaryFormatter();
            using (var ms = new MemoryStream(gzip, false))
            using (var cs = new GZipStream(ms, CompressionMode.Decompress, true))
                return (T)formatter.Deserialize(cs);
        }

        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            var temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        /// <summary>
        /// Gets the name of the current method without namespace.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string GetCurrentMethodName()
        {
            var st = new StackTrace();
            var sf = st.GetFrame(1);

            return sf.GetMethod().Name;
        }

        /// <summary>
        /// Gets the full name of the current method with namespace.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string GetCurrentMethodFullName()
        {
            var st = new StackTrace();
            var sf = st.GetFrame(1);

            return $"{sf.GetMethod().ReflectedType.FullName}.{sf.GetMethod().Name}";
        }

        public static T DeepCopy<T>(T other)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                formatter.Serialize(ms, other);
                ms.Position = 0;
                return (T)formatter.Deserialize(ms);
            }
        }
    }
}
