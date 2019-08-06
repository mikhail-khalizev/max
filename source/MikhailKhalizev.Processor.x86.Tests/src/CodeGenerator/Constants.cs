using MikhailKhalizev.Processor.x86.Decoder.Dto;

namespace MikhailKhalizev.Processor.x86.Tests.CodeGenerator
{
    public class Constants
    {
        public const string MnemonicCodeCsFileName = @"..\..\..\..\MikhailKhalizev.Processor.x86\src\InstructionDecode\MnemonicCode.cs";
        public const string DecodeJsonFileName = @"..\..\..\..\MikhailKhalizev.Processor.x86\resources\decode.json";

        public const string DecodeFelixcloutierJsonFileName = @"decode-felixcloutier.json";
        public const string AsposePageJsonFileName = @"Aspose\Json\page-{0}.json";
        public const string BookmarksJsonFileName = "bookmarks.json";
        public const string SplitPdfFileName = @"Pdf\page-{0}.pdf";

        public const string DocumentFolder = @"C:\Users\micky\YandexDisk\Документы\Технологии\x86\intel";
        public const string DocumentName = InstructionDto.DocumentationFile;

        public const string AsposeAppSid = "9fa9e638-7858-4022-ba7f-9a99edbdeeac";
        public const string AsposeAppKey = "74b609b2f5238cdf432afdb73e8201d3";
    }
}