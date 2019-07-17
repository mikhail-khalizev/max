using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace MikhailKhalizev.Utils
{
    public static class HexHelper
    {
        private static Regex _hexReg;
        public static Regex HexReg => _hexReg ?? (_hexReg = new Regex("0x[0-9a-fA-F_]+"));

        public static bool HasHexPrefix(this string hex) => hex?.StartsWith("0x") == true;

        public static string WithHexPrefix(this string hex) => HasHexPrefix(hex) ? hex : "0x" + hex;
        public static string WithoutHexPrefix(this string hex) => HasHexPrefix(hex) ? hex.Substring(2) : hex;

        public static string RemoveGroupSeparatorInAllHexInText(string str)
        {
            return HexReg.Replace(str, m => m.Value.Replace("_", ""));
        }

        public static byte ToUInt8(string str) =>
            HasHexPrefix(str)
                ? byte.Parse(str.WithoutHexPrefix().Replace("_", ""), NumberStyles.HexNumber)
                : byte.Parse(str.Replace("_", ""));

        public static uint ToUInt32(string str) =>
            HasHexPrefix(str)
                ? uint.Parse(str.WithoutHexPrefix().Replace("_", ""), NumberStyles.HexNumber)
                : uint.Parse(str.Replace("_", ""));

        public static int ToInt32(string str) => (int) ToUInt32(str);

        public static byte[] ToBytes(string hex, Func<Options, Options> setupOptions = null)
        {
            if (string.IsNullOrEmpty(hex))
                return Array.Empty<byte>();

            var options = setupOptions?.Invoke(Options.Default) ?? Options.Default;
            hex = hex.WithoutHexPrefix().Replace(options.GroupSeparator, "");

            var ret = new byte[(hex.Length + 1) / 2];

            var offset = hex.Length % 2;
            if (offset == 1)
                ret[0] = byte.Parse(hex.Substring(0, 1), NumberStyles.HexNumber);

            for (var i = offset; i < ret.Length; i++)
                ret[i] = byte.Parse(hex.Substring(i * 2 - offset, 2), NumberStyles.HexNumber);

            return ret;
        }


        public static string ToString(int val, Func<Options, Options> setupOptions = null)
        {
            return ToString(BitConverter.GetBytes(val), setupOptions.Append(o => o.SetIsNumeric()));
        }

        public static string ToString(uint val, Func<Options, Options> setupOptions = null)
        {
            return ToString(BitConverter.GetBytes(val), setupOptions.Append(o => o.SetIsNumeric()));
        }

        public static string ToString(long val, Func<Options, Options> setupOptions = null)
        {
            return ToString(BitConverter.GetBytes(val), setupOptions.Append(o => o.SetIsNumeric()));
        }

        public static string ToString(ulong val, Func<Options, Options> setupOptions = null)
        {
            return ToString(BitConverter.GetBytes(val), setupOptions.Append(o => o.SetIsNumeric()));
        }

        public static string ToString(IEnumerable<byte> bytes, Func<Options, Options> setupOptions = null)
        {
            var options = setupOptions?.Invoke(Options.Default) ?? Options.Default;

            var hexPrefix = options.AddHexPrefix ? "0x" : "";

            var needReverse = options.IsNumeric &&
                (BitConverter.IsLittleEndian && options.LittleEndian ||
                    !BitConverter.IsLittleEndian && !options.LittleEndian);
            var resultBytes = needReverse ? bytes.Reverse() : bytes;

            BitArray checksum = null;
            if (options.ChecksumEnable)
            {
                byte[] hash;
                using (var alg = MD5.Create())
                {
                    if (options.ChecksumPurpose == null)
                        hash = alg.ComputeHash(resultBytes.ToArray());
                    else
                        hash = alg.ComputeHash(
                            Encoding.UTF8.GetBytes(options.ChecksumPurpose + "-")
                                .Concat(resultBytes)
                                .ToArray());
                }

                checksum = new BitArray(hash);
            }

            var chars = resultBytes
                .Select(x => $"{x:x2}")
                .SelectMany(x => x)
                .Select((c, i) =>
                {
                    if (checksum == null)
                        return c;

                    if (checksum[i % checksum.Length])
                        return char.ToUpper(c);
                    return c;
                })
                .SkipWhile(x => options.TrimZero && x == '0')
                .ToArray();

            if (options.TrimZero && chars.Length == 0)
                return "0";

            if (options.GroupSize <= 0)
                return hexPrefix + new string(chars);

            var offset = options.GroupSize + 1 - chars.Length % options.GroupSize;

            return
                hexPrefix +
                string.Concat(chars
                    .SelectMany((c, i) =>
                    {
                        var num = i + offset;

                        if (i != chars.Length - 1 && num % options.GroupSize == 0)
                            return $"{c}" + options.GroupSeparator;
                        return $"{c}";
                    }));
        }


        private static Func<Options, Options> Append(
            this Func<Options, Options> setupOptions,
            Func<Options, Options> appendSetup)
        {
            if (setupOptions == null)
                return appendSetup;

            return o =>
            {
                o = setupOptions(o);
                o = appendSetup(o);
                return o;
            };
        }

        public class Options
        {
            public static Options Default { get; } = new Options();

            public int GroupSize { get; private set; }
            public string GroupSeparator { get; private set; } = "_";
            public bool TrimZero { get; private set; }
            public bool ChecksumEnable { get; private set; }
            public string ChecksumPurpose { get; private set; }
            public bool AddHexPrefix { get; private set; } = true;

            // used only when IsNumeric true.
            public bool LittleEndian { get; private set; } = true;
            public bool IsNumeric { get; private set; }

            public Options SetGroupSize(int groupSize)
            {
                var o = Clone();
                o.GroupSize = groupSize;
                return o;
            }

            public Options SetGroupSeparator(string groupSeparator)
            {
                var o = Clone();
                o.GroupSeparator = groupSeparator;
                return o;
            }

            public Options SetTrimZero(bool trimZero = true)
            {
                var o = Clone();
                o.TrimZero = trimZero;
                return o;
            }

            public Options SetAddHexPrefix(bool addHexPrefix)
            {
                var o = Clone();
                o.AddHexPrefix = addHexPrefix;
                return o;
            }

            public Options RemoveHexPrefix()
            {
                var o = Clone();
                o.AddHexPrefix = false;
                return o;
            }

            public Options AddChecksum(string purpose = null)
            {
                var o = Clone();
                o.ChecksumEnable = true;
                o.ChecksumPurpose = purpose;
                return o;
            }

            public Options SetLittleEndian(bool littleEndian = true)
            {
                var o = Clone();
                o.LittleEndian = littleEndian;
                return o;
            }

            public Options SetBigEndian(bool bigEndian = true)
            {
                var o = Clone();
                o.LittleEndian = !bigEndian;
                return o;
            }

            public Options SetIsNumeric(bool isNumeric = true)
            {
                var o = Clone();
                o.IsNumeric = isNumeric;
                return o;
            }

            public Options Clone() => (Options) MemberwiseClone();
        }
    }
}