namespace MikhailKhalizev.Processor.x86.Configuration
{
    public class BinToCSharpDto
    {
        public string SettingsDirectory { get; set; }
        public string MethodsInfoFile => "methods.json";
        public string MethodsRuntimeInfoFile => "methods.runtime.json";
        
        public string MetadataOutput { get; set; }
        public string CodeOutput { get; set; }

        public string Namespace { get; set; } = "{Namespace}";
        public string RawProgramClassName { get; set; } = "{RawProgramClassName}";
        public string StringDefinitionsClassName { get; set; } = "{StringDefinitionsClassName}";

        public int LimitDecodeSize { get; set; } = int.MaxValue;
    }
}