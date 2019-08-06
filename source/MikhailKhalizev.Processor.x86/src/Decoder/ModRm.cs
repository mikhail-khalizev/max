namespace MikhailKhalizev.Processor.x86.Decoder
{
    public class ModRm
    {
        public int RM { get; }
        public int RegOrOpcode { get; }
        public int Mod { get; }
        public int Source { get; }

        public ModRm(int source)
        {
            Source = source;
            RM = source & 0b0111;
            RegOrOpcode = (source >> 3) & 0b0111;
            Mod = source >> 6;

            // Mod + RM - 32 possible values (5 bit) - eight registers and 24 addressing modes.
        }
    }
}