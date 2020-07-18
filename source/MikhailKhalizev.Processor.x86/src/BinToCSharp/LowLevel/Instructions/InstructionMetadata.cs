namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel
{
    public class InstructionMetadata
    {
        /// <summary>
        /// ¬озвращает или задает признак того, что инструкци€ имеет метку на которую может осуществл€тьс€ переход.
        /// </summary>
        public bool HasLabel { get; set; }

        /// <summary>
        /// ¬озвращает или задает признак того, что переход осуществл€етс€ внутрь метода, к которому относитс€ инструкци€.
        /// </summary>
        public bool IsLocalBranch { get; set; }

        /// <summary>
        /// ¬озвращает или задает признак того, что инструкци€ €вл€етс€ возвратам из подпрограммы.
        /// </summary>
        public bool IsRet { get; set; }

        /// <summary>
        /// ¬озвращает или задает признак того, что инструкци€ €вл€етс€ безусловным переходом.
        /// </summary>
        public bool IsJmp { get; set; }

        public bool IsJmpOrRet => IsJmp || IsRet;

        /// <summary>
        /// ¬озвращает или задает признак того, что инструкци€ €вл€етс€ последней в методе.
        /// </summary>
        public bool IsLastInstructionInMethod {get; set; }
    }
}