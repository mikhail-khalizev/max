using System.Collections.Generic;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel
{
    public class ProxyInstruction : IInstruction
    {
        public IInstruction IcSharpInstructionImplementation { get; }

        public ProxyInstruction(IInstruction icSharpInstructionImplementation)
        {
            IcSharpInstructionImplementation = icSharpInstructionImplementation;
        }
        

        /// <inheritdoc />
        public virtual Address Begin
        {
            get => IcSharpInstructionImplementation.Begin;
        }

        /// <inheritdoc />
        public virtual Address End
        {
            get => IcSharpInstructionImplementation.End;
        }

        /// <inheritdoc />
        public InstructionMetadata Metadata => IcSharpInstructionImplementation.Metadata;


        /// <inheritdoc />
        public virtual bool IsJmpOrJcc => IcSharpInstructionImplementation.IsJmpOrJcc;

        /// <inheritdoc />
        public virtual bool IsRet => IcSharpInstructionImplementation.IsRet;

        /// <inheritdoc />
        public virtual bool IsJmp => IcSharpInstructionImplementation.IsJmp;


        /// <inheritdoc />
        public virtual IEnumerable<string> GetCode(bool isLastInstructionInMethod)
        {
            return IcSharpInstructionImplementation.GetCode(isLastInstructionInMethod);
        }
    }
}