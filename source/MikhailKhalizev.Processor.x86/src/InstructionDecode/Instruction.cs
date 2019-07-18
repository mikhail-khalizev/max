using System;
using System.Linq;
using MikhailKhalizev.Utils;

namespace MikhailKhalizev.Processor.x86.InstructionDecode
{
    public class Instruction
    {
        public ArraySegment<byte> Source { get; }

        /// <summary>
        /// Режим процессора: 16, 32, 64.
        /// </summary>
        public int Mode { get; }
        
        /// <summary>
        /// Эффективный размер адреса (с учетом префикса).
        /// </summary>
        public int EffectiveAddressSize { get; private set; }

        /// <summary>
        /// Эффективный размер операнда (с учетом префикса).
        /// </summary>
        public int EffectiveOperandSize { get; private set; }


        public bool IsInvalid { get; }

        public string Reason { get; }

        /// <summary>
        /// Длина инструкции (до 15 байт)
        /// </summary>
        public int Length { get; private set; }


        // max - 4 bytes.
        public ArraySegment<byte> Prefixes { get; private set; }

        public bool HasPrefixOperandSizeOverride { get; private set; }
        
        public bool HasPrefixAddressSizeOverride { get; private set; }
        
        public bool HasRex { get; private set; }
        public byte Rex { get; private set; }
        public bool RexW { get; private set; }
        public bool RexR { get; private set; }
        public bool RexX { get; private set; }
        public bool RexB { get; private set; }



        //// max - 3 bytes.
        //public ArraySegment<byte> Opcode { get; }
        
        //[CanBeNull]
        //public ModRM ModRM { get; }

        //[CanBeNull]
        //public Sib Sib { get; }

        //public int Displacement { get; }

        //public int ImmediateInt { get; }

        //public uint ImmediateUInt { get; }


        public Instruction Decode(ArraySegment<byte> source, int mode) => new Instruction(source, mode);

        private Instruction(ArraySegment<byte> source, int mode)
        {
            Mode = mode;
            Source = source;
            Length = 0;

            Reason = DecodeInternal();
            IsInvalid = Reason != null;
        }

        private string DecodeInternal()
        {
            Prefixes = Source.Slice(0, Source.TakeWhile(PrefixMetadata.IsPrefix).Count());
            Length += Prefixes.Count;
            var left = Source.Slice(Length);

            var allGroups = Prefixes.Select(PrefixMetadata.GetPrefixGroup).ToList();
            var distinctGroup = allGroups.Distinct().ToList();
            if (allGroups.Count != distinctGroup.Count)
                return $"Prefix group repeated: ({string.Join(", ", allGroups)}).";

            // Determine Rex prefix.
            if (Mode == 64 && (left[0] | 0x0f) == 0b0100_1111)
            {
                HasRex = true;
                Rex = left[0];
                Length++;
                left = left.Slice(1);
                
                RexW = BinaryHelper.IsSet(Rex, 3);
                RexR = BinaryHelper.IsSet(Rex, 2);
                RexX = BinaryHelper.IsSet(Rex, 1);
                RexB = BinaryHelper.IsSet(Rex, 0);
            }
            
            HasPrefixOperandSizeOverride = Prefixes.Contains(PrefixMetadata.PrefixOperandSizeOverride);
            HasPrefixAddressSizeOverride = Prefixes.Contains(PrefixMetadata.PrefixAddressSizeOverride);

            // Table 3-3. Effective Operand- and Address-Size Attributes
            // Table 3-4. Effective Operand- and Address-Size Attributes in 64-Bit Mode

            switch (Mode)
            {
                case 16:
                    EffectiveOperandSize = HasPrefixOperandSizeOverride ? 32 : 16;
                    EffectiveAddressSize = HasPrefixAddressSizeOverride ? 32 : 16;
                    break;
                case 32:
                    EffectiveOperandSize = HasPrefixOperandSizeOverride ? 16 : 32;
                    EffectiveAddressSize = HasPrefixAddressSizeOverride ? 16 : 32;
                    break;
                case 64:
                    if (RexW)
                    {
                        EffectiveOperandSize = 64;

                        // NOTE. For non-byte operations: if a 66H prefix is used with prefix (REX.W = 1), 66H is ignored.
                        // HasPrefixOperandSizeOverride = false;
                    }
                    else
                        EffectiveOperandSize = HasPrefixOperandSizeOverride ? 16 : 32;

                    EffectiveAddressSize = HasPrefixAddressSizeOverride ? 32 : 64;
                    break;
            }
            
            return null;
        }
    }
}
