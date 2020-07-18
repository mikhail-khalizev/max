namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel.Plugin
{
    public abstract class PluginBase
    {
        protected PluginBase(LowLevelEngine engine)
        {
            Engine = engine;
        }

        public LowLevelEngine Engine { get; }
    }
}