namespace MikhailKhalizev.Max.Configuration
{
    public class ConfigurationDto
    {
        public MaxDto Max { get; set; } = new MaxDto();
        public DosDto Dos { get; set; } = new DosDto();
        public Processor.x86.BinToCSharp.ConfigurationDto BinToCSharp { get; set; } = new Processor.x86.BinToCSharp.ConfigurationDto();
    }
}