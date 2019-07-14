using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max
{
    public class ConfigurationDto
    {
        public MaxDto Max { get; set; } = new MaxDto();
        public Processor.x86.BinToCSharp.ConfigurationDto BinToCode { get; set; } = new Processor.x86.BinToCSharp.ConfigurationDto();
    }
}