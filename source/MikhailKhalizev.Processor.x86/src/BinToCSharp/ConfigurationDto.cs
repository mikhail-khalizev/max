﻿namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    public class ConfigurationDto
    {
        public string SettingsDirectory { get; set; }
        public string MethodInfosFile => "methods.json";


        public string MetadataOutput { get; set; }
        public string CodeOutput { get; set; }

        public string Namespace { get; set; }
        public string ClassName { get; set; }
    }
}