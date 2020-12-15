namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel
{
    public class InstructionMetadata
    {
        /// <summary>
        /// Возвращает или задает признак того, что инструкция имеет метку на которую может осуществляться переход.
        /// </summary>
        public bool HasLabel { get; set; }

        /// <summary>
        /// Возвращает или задает признак того, что переход осуществляется внутрь метода, к которому относится инструкция.
        /// </summary>
        public bool IsLocalBranch { get; set; }

        /// <summary>
        /// Возвращает или задает признак того, что инструкция является возвратам из подпрограммы.
        /// </summary>
        public bool IsRet { get; set; }

        /// <summary>
        /// Возвращает или задает признак того, что инструкция является безусловным переходом.
        /// </summary>
        public bool IsJmp { get; set; }

        public bool IsJmpOrRet => IsJmp || IsRet;

        /// <summary>
        /// Возвращает или задает признак того, что инструкция является последней в методе.
        /// </summary>
        public bool IsLastInstructionInMethod { get; set; }
    }
}