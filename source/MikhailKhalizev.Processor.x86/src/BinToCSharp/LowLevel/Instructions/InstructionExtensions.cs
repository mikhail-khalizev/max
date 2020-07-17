namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel
{
    public static class InstructionExtensions
    {
        public static string GetInstructionInfoStringStatic(bool withRightPadding, Address begin, Address end)
        {
            var str = $"ii({begin}, {end - begin});";

            if (withRightPadding)
                str += "  ";

            return str;
        }

        public static string GetInstructionInfoString(this IInstruction cmd)
        {
            return GetInstructionInfoStringStatic(true, cmd.Begin, cmd.End);
        }
    }
}