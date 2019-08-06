namespace MikhailKhalizev.Processor.x86.BinToCSharp.Plugin
{
    public abstract class PluginBase
    {
        protected PluginBase(Engine engine)
        {
            Engine = engine;
        }

        public Engine Engine { get; }
    }
}