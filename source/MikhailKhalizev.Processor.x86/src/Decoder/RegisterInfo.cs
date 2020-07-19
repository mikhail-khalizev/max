using System;
using System.Collections.Generic;
using System.Linq;
using SharpDisasm.Udis86;

namespace MikhailKhalizev.Processor.x86.Decoder
{
    public class RegisterInfo : IEquatable<RegisterInfo>
    {
        private static readonly Dictionary<ud_type, RegisterInfo> RegisterByType;
        private static readonly HashSet<string> AllRegNames;


        static RegisterInfo()
        {
            var regs = new List<RegisterInfo>();

            regs.Add(Empty);
            var index = Empty.Index;

            regs.Add(new RegisterInfo(ud_type.UD_R_AL, ++index, 0b0001, 8) { IsGeneralPurpose = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_AH, index, 0b0010, 8) { IsGeneralPurpose = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_AX, index, 0b0011, 16) { IsGeneralPurpose = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_EAX, index, 0b1111, 32) { IsGeneralPurpose = true });

            regs.Add(new RegisterInfo(ud_type.UD_R_BL, ++index, 0b0001, 8) { IsGeneralPurpose = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_BH, index, 0b0010, 8) { IsGeneralPurpose = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_BX, index, 0b0011, 16) { IsGeneralPurpose = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_EBX, index, 0b1111, 32) { IsGeneralPurpose = true });

            regs.Add(new RegisterInfo(ud_type.UD_R_CL, ++index, 0b0001, 8) { IsGeneralPurpose = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_CH, index, 0b0010, 8) { IsGeneralPurpose = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_CX, index, 0b0011, 16) { IsGeneralPurpose = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_ECX, index, 0b1111, 32) { IsGeneralPurpose = true });

            regs.Add(new RegisterInfo(ud_type.UD_R_DL, ++index, 0b0001, 8) { IsGeneralPurpose = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_DH, index, 0b0010, 8) { IsGeneralPurpose = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_DX, index, 0b0011, 16) { IsGeneralPurpose = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_EDX, index, 0b1111, 32) { IsGeneralPurpose = true });

            regs.Add(new RegisterInfo(ud_type.UD_R_BPL, ++index, 0b0001, 8) { IsGeneralPurpose = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_BP, index, 0b0011, 16) { IsGeneralPurpose = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_EBP, index, 0b1111, 32) { IsGeneralPurpose = true });

            regs.Add(new RegisterInfo(ud_type.UD_R_SPL, ++index, 0b0001, 8) { IsGeneralPurpose = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_SP, index, 0b0011, 16) { IsGeneralPurpose = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_ESP, index, 0b1111, 32) { IsGeneralPurpose = true });

            regs.Add(new RegisterInfo(ud_type.UD_R_SIL, ++index, 0b0001, 8) { IsGeneralPurpose = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_SI, index, 0b0011, 16) { IsGeneralPurpose = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_ESI, index, 0b1111, 32) { IsGeneralPurpose = true });

            regs.Add(new RegisterInfo(ud_type.UD_R_DIL, ++index, 0b0001, 8) { IsGeneralPurpose = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_DI, index, 0b0011, 16) { IsGeneralPurpose = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_EDI, index, 0b1111, 32) { IsGeneralPurpose = true });

            regs.Add(new RegisterInfo(ud_type.UD_R_CS, ++index, 0b0011, 16) { IsSegment = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_SS, ++index, 0b0011, 16) { IsSegment = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_DS, ++index, 0b0011, 16) { IsSegment = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_ES, ++index, 0b0011, 16) { IsSegment = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_GS, ++index, 0b0011, 16) { IsSegment = true });
            regs.Add(new RegisterInfo(ud_type.UD_R_FS, ++index, 0b0011, 16) { IsSegment = true });

            regs.Add(new RegisterInfo(ud_type.UD_R_CR0, ++index, 0b1111, 32));
            regs.Add(new RegisterInfo(ud_type.UD_R_CR2, ++index, 0b1111, 32));
            regs.Add(new RegisterInfo(ud_type.UD_R_CR3, ++index, 0b1111, 32));

            RegisterByType = regs.ToDictionary(x => x.UdType, x => x);

            AllRegNames = Enum.GetValues(typeof(ud_type))
                .Cast<ud_type>()
                .Select(x => x.ToString())
                .Where(x => x.StartsWith("UD_R_"))
                .Select(x => x.Substring("UD_R_".Length).ToLowerInvariant())
                .ToHashSet();
        }
        
        // TODO Remove size argument.
        private RegisterInfo(ud_type udType, int index, int byteMask, int lengthInBits)
        {
            UdType = udType;
            Index = index;
            ByteMask = byteMask;
            LengthInBits = lengthInBits;


            var checkLengthInBits = 0;
            var m = byteMask;
            var bitMaskAdd = 0xff;
            while (m != 0)
            {
                if ((m & 1) != 0)
                {
                    checkLengthInBits += 8;
                    BitMask |= bitMaskAdd;
                }
                else
                    BitOffset += 8;

                m = m >> 1;
                bitMaskAdd <<= 8;
            }

            if (lengthInBits != checkLengthInBits)
                throw new InvalidOperationException("Incorrect size");


            if (udType == ud_type.UD_NONE)
                Name = "none";
            else
            {
                var name = udType.ToString();
                if (!name.StartsWith("UD_R_"))
                    throw new InvalidOperationException($"Invalid {nameof(udType)}: {udType}");
                name = name.Substring("UD_R_".Length).ToLowerInvariant();

                Name = name;
            }
        }

        public static RegisterInfo Empty { get; } = new RegisterInfo(ud_type.UD_NONE, 0, 0, 0);
        
        public static IReadOnlyCollection<RegisterInfo> Registers => RegisterByType.Values;

        public static RegisterInfo GetRegister(ud_type udType)
        {
            return RegisterByType[udType];
        }

        public static bool Intersects(RegisterInfo ra, RegisterInfo rb)
        {
            if (ra == Empty || rb == Empty)
                return false;

            return ra.Index == rb.Index && (ra.ByteMask & rb.ByteMask) != 0;
        }

        public static bool HasRegister(string name)
        {
            return AllRegNames.Contains(name.ToLowerInvariant());
        }
        
        public static implicit operator RegisterInfo(ud_type value) => GetRegister(value);


        public string Name { get; }
        public ud_type UdType { get; }
        public int Index { get; }
        public int ByteMask { get; }
        public int BitMask { get; }
        public int BitOffset { get; }
        public int LengthInBits { get; }

        public bool IsGeneralPurpose { get; private set; }
        public bool IsSegment { get; private set; }

        /// <inheritdoc />
        public override string ToString()
        {
            return Name; // syn.ud_reg_tab[UdType - ud_type.UD_R_AL];
        }
        
        #region IEquatable
        
        /// <inheritdoc />
        public bool Equals(RegisterInfo other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Index == other.Index && ByteMask == other.ByteMask;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((RegisterInfo) obj);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return (Index * 397) ^ ByteMask;
            }
        }

        public static bool operator ==(RegisterInfo left, RegisterInfo right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RegisterInfo left, RegisterInfo right)
        {
            return !Equals(left, right);
        }

        #endregion
    }
}