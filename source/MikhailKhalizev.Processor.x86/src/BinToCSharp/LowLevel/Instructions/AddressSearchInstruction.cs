using System;
using System.Collections.Generic;
using System.Linq;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel
{
    public class AddressSearchInstruction : IInstruction
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
        public InstructionMetadata Metadata => _metadata ??= new InstructionMetadata();
        private InstructionMetadata _metadata;


        public AddressSearchInstruction(Address address)
        {
            Begin = address;
            End = address;
        }

        /// <inheritdoc />
        public IEnumerable<string> GetLowLevelCode()
        {
            return Enumerable.Empty<string>();
        }
    }
}