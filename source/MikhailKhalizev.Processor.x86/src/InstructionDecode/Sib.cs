namespace MikhailKhalizev.Processor.x86.InstructionDecode
{
    public class Sib
    {
        public int Base { get; }
        public int Index { get; }
        public int Scale { get; }
        public int Source { get; }

        public Sib(int source)
        {
            Source = source;
            Base = source & 0b0111;
            Index = (source >> 3) & 0b0111;
            Scale = source >> 6;
        }
    }
}