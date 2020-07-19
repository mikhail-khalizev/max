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
        public virtual Address Begin => IcSharpInstructionImplementation.Begin;

        /// <inheritdoc />
        public virtual Address End => IcSharpInstructionImplementation.End;

        /// <inheritdoc />
        public InstructionMetadata Metadata => IcSharpInstructionImplementation.Metadata;


        /// <inheritdoc />
        public virtual IEnumerable<string> GetLowLevelCode()
        {
            return IcSharpInstructionImplementation.GetLowLevelCode();
        }
    }
}