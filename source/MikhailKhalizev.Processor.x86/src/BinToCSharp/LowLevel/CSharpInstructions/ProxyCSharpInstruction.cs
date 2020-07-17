using System.Collections.Generic;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel
{
    public class ProxyCSharpInstruction : ICSharpInstruction
    {
        public ICSharpInstruction IcSharpInstructionImplementation { get; }

        public ProxyCSharpInstruction(ICSharpInstruction icSharpInstructionImplementation)
        {
            IcSharpInstructionImplementation = icSharpInstructionImplementation;
        }

        /// <inheritdoc />
        public virtual Address End
        {
            get => IcSharpInstructionImplementation.End;
            set => IcSharpInstructionImplementation.End = value;
        }

        /// <inheritdoc />
        public virtual bool HasLabel
        {
            get => IcSharpInstructionImplementation.HasLabel;
            set => IcSharpInstructionImplementation.HasLabel = value;
        }

        /// <inheritdoc />
        public virtual bool IsJmpOrJcc => IcSharpInstructionImplementation.IsJmpOrJcc;

        /// <inheritdoc />
        public virtual bool IsLoopOrLoopcc => IcSharpInstructionImplementation.IsLoopOrLoopcc;

        /// <inheritdoc />
        public virtual bool IsRet => IcSharpInstructionImplementation.IsRet;

        /// <inheritdoc />
        public virtual bool IsJmp => IcSharpInstructionImplementation.IsJmp;

        /// <inheritdoc />
        public virtual bool IsLocalBranch
        {
            get => IcSharpInstructionImplementation.IsLocalBranch;
            set => IcSharpInstructionImplementation.IsLocalBranch = value;
        }

        /// <inheritdoc />
        public virtual IEnumerable<string> GetCode(bool isLastInstructionInMethod)
        {
            return IcSharpInstructionImplementation.GetCode(isLastInstructionInMethod);
        }

        /// <inheritdoc />
        public virtual Address Begin
        {
            get => IcSharpInstructionImplementation.Begin;
            set => IcSharpInstructionImplementation.Begin = value;
        }
    }
}