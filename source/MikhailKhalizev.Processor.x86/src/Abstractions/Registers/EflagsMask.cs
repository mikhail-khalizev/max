namespace MikhailKhalizev.Processor.x86.Abstractions.Registers
{
    public static class EflagsMask
    {
        public const uint none = 0;
        public const uint reserved = 0xffc0802a;

        public const uint cf = 1 << 0;
        public const uint pf = 1 << 2;
        public const uint af = 1 << 4;
        public const uint zf = 1 << 6;
        public const uint sf = 1 << 7;
        public const uint tf = 1 << 8;
        public const uint @if = 1 << 9;
        public const uint df = 1 << 10;
        public const uint of = 1 << 11;
        public const uint iopl = 3 << 12;
        public const uint nt = 1 << 14;
        public const uint rf = 1 << 16;
        public const uint vm = 1 << 17;
        public const uint ac = 1 << 18;
        public const uint vif = 1 << 19;
        public const uint vip = 1 << 20;
        public const uint id = 1 << 21;
    }
}