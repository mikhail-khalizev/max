namespace MikhailKhalizev.Processor.x86.BinToCSharp.Plugin
{
    public class Switch : PluginBase
    {
        /// <inheritdoc />
        public Switch(Engine engine)
            : base(engine)
        {
            Engine.InstructionDecoded += EngineOnInstructionDecoded;
        }

        private void EngineOnInstructionDecoded(object sender, Instruction cmd)
        { }
    }
}