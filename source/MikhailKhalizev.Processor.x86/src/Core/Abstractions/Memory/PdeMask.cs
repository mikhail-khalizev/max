namespace MikhailKhalizev.Processor.x86.Abstractions.Memory
{
    public static class PdeMask
    {
        public const uint none = 0;

        public const uint p = 1 << 0;
        public const uint rw = 1 << 1;
        public const uint us = 1 << 2;
        public const uint pwt = 1 << 3;
        public const uint pcd = 1 << 4;
        public const uint a = 1 << 5;
        public const uint ps = 1 << 7;
    };
}