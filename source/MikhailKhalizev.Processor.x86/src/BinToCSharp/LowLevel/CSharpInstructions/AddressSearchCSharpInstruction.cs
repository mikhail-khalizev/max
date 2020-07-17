using System;
using System.Collections.Generic;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel
{
    public class AddressSearchCSharpInstruction : ICSharpInstruction
    {
        /// <inheritdoc />
        public Address Begin { get; set; }

        /// <inheritdoc />
        public Address End
        {
            get => Begin;
            set => Begin = value;
        }

        /// <inheritdoc />
        public bool HasLabel
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool IsJmpOrJcc => throw new NotImplementedException();

        /// <inheritdoc />
        public bool IsLoopOrLoopcc => throw new NotImplementedException();

        /// <inheritdoc />
        public bool IsRet => throw new NotImplementedException();

        /// <inheritdoc />
        public bool IsJmp => throw new NotImplementedException();

        /// <inheritdoc />
        public bool IsLocalBranch
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public AddressSearchCSharpInstruction(Address address)
        {
            Begin = address;
            End = address;
        }

        /// <inheritdoc />
        public IEnumerable<string> GetCode(bool isLastInstructionInMethod)
        {
            throw new NotImplementedException();
        }
    }
}