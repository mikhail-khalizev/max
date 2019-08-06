using System.Collections.Generic;
using System.Linq;

namespace MikhailKhalizev.Processor.x86.Decoder.Metadata
{
    public static class PrefixMetadata
    {
        // 1. CS segment override (use with any branch instruction is reserved).
        // 2. Branch hints: Branch not taken (used only with Jcc instructions).
        public static byte PrefixCs => 0x2e;
        // 1. DS segment override prefix (use with any branch instruction is reserved).
        // 2. Branch hints: Branch taken (used only with Jcc instructions).
        public static byte PrefixDs => 0x3e;
        public static byte PrefixSs => 0x36;
        public static byte PrefixEs => 0x26;
        public static byte PrefixFs => 0x64;
        public static byte PrefixGs => 0x65;
        public static byte PrefixLock => 0xf0;

        // REP or REPE/REPZ (F3H is also used as a mandatory prefix for POPCNT, LZCNT and ADOX instructions.).
        public static byte PrefixRep => 0xf3;
        // 1. REPNE/REPNZ (F2H is also used as a mandatory prefix for some instructions).
        // 2. BND prefix is encoded using F2H if the following conditions are true (see doc).
        public static byte PrefixRepne => 0xf2;

        // Operand-size override (also used as a mandatory prefix for some instructions)
        public static byte PrefixOperandSizeOverride => 0x66;
        public static byte PrefixAddressSizeOverride => 0x67;

        public static byte PrefixVex2Byte => 0xc5;
        public static byte PrefixVex3Byte => 0xc4;


        public static IReadOnlyDictionary<byte, int> GroupIdByPrefix => _groupIdByPrefix;
        private static readonly Dictionary<byte, int> _groupIdByPrefix;

        static PrefixMetadata()
        {
            var prefixGroups = new[]
            {
                new[]
                {
                    PrefixLock,
                    PrefixRepne,
                    PrefixRep
                },
                new[]
                {
                    PrefixCs,
                    PrefixSs,
                    PrefixDs,
                    PrefixEs,
                    PrefixFs,
                    PrefixGs
                },
                new[]
                {
                    PrefixOperandSizeOverride
                },
                new[]
                {
                    PrefixAddressSizeOverride
                }
            };

            _groupIdByPrefix = prefixGroups
                .SelectMany((prefixes, groupIndex) => prefixes.Select(prefix => new { prefix, groupIndex }))
                .ToDictionary(x => x.prefix, x => x.groupIndex);
        }

        public static bool IsPrefix(byte prefix) => _groupIdByPrefix.ContainsKey(prefix);

        public static int GetPrefixGroup(byte prefix) => _groupIdByPrefix[prefix];
    }
}