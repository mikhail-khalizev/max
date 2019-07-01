using System.Collections.Generic;
using System.Linq;

namespace MikhailKhalizev.Processor.x86.InstructionDecode
{
    public static class Meta
    {
        // 1. CS segment override (use with any branch instruction is reserved).
        // 2. Branch hints: Branch not taken (used only with Jcc instructions).
        public static byte PrefixCs => 0x2e;
        // 1. DS segment override prefix (use with any branch instruction is reserved).
        // 2. Branch taken (used only with Jcc instructions).
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


        private static Dictionary<byte, int> Prefixes { get; }
        
        static Meta()
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

            Prefixes = prefixGroups
                .SelectMany((prefixes, group) => prefixes.Select(prefix => new {prefix, group}))
                .ToDictionary(x => x.prefix, x => x.group);

            // ? rex - u.dis_mode == 64 && (last & 0xF0) == 0x40
        }

        public static bool IsPrefix(byte prefix) => Prefixes.ContainsKey(prefix);

        public static int GetPrefixGroup(byte prefix) => Prefixes[prefix];
    }
}