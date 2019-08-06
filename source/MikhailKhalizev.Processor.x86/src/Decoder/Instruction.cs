using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using MikhailKhalizev.Processor.x86.Decoder.Metadata;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.Decoder
{
    public class Instruction
    {
        /// <summary>
        /// Код инструкции.
        /// </summary>
        public IReadOnlyList<byte> Bytes => _pushBack == 0 ? _read : _read.GetRange(0, Length);
        private ImmutableList<byte> _read = ImmutableList<byte>.Empty;

        public int ReadLength => _read.Count;

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

        public string Reason { get; private set; }

        /// <summary>
        /// Длина инструкции (до 15 байт)
        /// </summary>
        public int Length => _read.Count - _pushBack;

        // max - 4 bytes.
        public IReadOnlyList<byte> Prefixes => _read.GetRange(0, _prefixLength);
        private int _prefixLength;

        public bool HasPrefixOperandSizeOverride { get; private set; }
        
        public bool HasPrefixAddressSizeOverride { get; private set; }
        
        public bool HasRex { get; private set; }
        public byte Rex { get; private set; }
        public bool RexW { get; private set; }
        public bool RexR { get; private set; }
        public bool RexX { get; private set; }
        public bool RexB { get; private set; }

        // input source. remove in future - use read by byte.
        private Func<byte> _readByte;
        private int _pushBack;

        //// max - 3 bytes.
        //public ArraySegment<byte> Opcode { get; }

        //[CanBeNull]
        //public ModRM ModRM { get; }

        //[CanBeNull]
        //public Sib Sib { get; }

        //public int Displacement { get; }

        //public int ImmediateInt { get; }

        //public uint ImmediateUInt { get; }


        public static Instruction Decode(Func<byte> readByte, int mode) => new Instruction(readByte, mode);
        public static Instruction Decode(ArraySegment<byte> source, int mode)
        {
            var pos = 0;
            Func<byte> readByte = () => source[pos++];
            return Decode(readByte, mode);
        }

        private Instruction(Func<byte> readByte, int mode)
        {
            _readByte = readByte;
            Mode = mode;

            Reason = DecodeInternal();
            IsInvalid = Reason != null;

            if (_pushBack != 0)
                throw new InvalidOperationException("Logic error in algorithm");
        }

        private byte ReadByte()
        {
            if (_pushBack != 0)
            {
                var b = _read[_read.Count - _pushBack];
                _pushBack--;
                return b;
            }
            else
            {
                var b = _readByte();
                _read = _read.Add(b);
                return b;
            }
        }
        
        private void PushByteBack()
        {
            _pushBack++;
        }

        private string DecodeInternal()
        {
            ReadStdPrefixes();

            if (Reason != null)
                return Reason;
            
            ReadRexPrefix();

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
            
            return Reason;
        }

        private void ReadStdPrefixes()
        {
            var groups = new byte[PrefixMetadata.GroupIdByPrefix.Count];

            while (true)
            {
                var b = ReadByte();
                if (!PrefixMetadata.IsPrefix(b))
                {
                    PushByteBack();
                    break;
                }
                _prefixLength++;

                var groupId = PrefixMetadata.GetPrefixGroup(b);
                var prevPrefix = groups[groupId];
                if (prevPrefix == 0)
                {
                    groups[groupId] = b;
                }
                else
                {
                    Reason = $"Prefix group repeated: ({prevPrefix:x2}, {b:x2}).";
                    return;
                }
            }
        }

        private void ReadRexPrefix()
        {
            // Determine Rex prefix.

            var b = ReadByte();
            if (Mode == 64 && (b | 0x0f) == 0b0100_1111)
            {
                HasRex = true;
                Rex = b;

                RexW = BinaryHelper.IsSet(Rex, 3);
                RexR = BinaryHelper.IsSet(Rex, 2);
                RexX = BinaryHelper.IsSet(Rex, 1);
                RexB = BinaryHelper.IsSet(Rex, 0);
            }
            else
                PushByteBack();
        }
    }
}
