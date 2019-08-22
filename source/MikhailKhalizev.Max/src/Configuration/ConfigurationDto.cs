using MikhailKhalizev.Processor.x86.Configuration;

namespace MikhailKhalizev.Max.Configuration
{
    public class ConfigurationDto
    {
        public MaxDto Max { get; set; } = new MaxDto();
        public DosDto Dos { get; set; } = new DosDto();
        public ProcessorDto Processor { get; set; } = new ProcessorDto();
        public BinToCSharpDto BinToCSharp { get; set; } = new BinToCSharpDto();
    }
}