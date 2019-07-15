using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpDisasm.Udis86;

namespace MikhailKhalizev.Processor.x86.InstructionDecode
{
    public class Register
    {
        public string Name { get; }
        public ud_type UdType { get; }
        public int Index { get; }
        public int ByteMask { get; }

        public Register(ud_type udType, int index, int byteMask)
        {
            UdType = udType;
            Index = index;
            ByteMask = byteMask;

            var name = UdType.ToString();
            if (!name.StartsWith("UD_R_"))
                throw new InvalidOperationException($"Invalid {nameof(udType)}: {udType}");
            name = name.Substring("UD_R_".Length).ToLowerInvariant();

            Name = name;
        }

        public static IReadOnlyCollection<Register> Registers => _registerByType.Values;
        private static readonly Dictionary<ud_type, Register> _registerByType;

        static Register()
        {
            var regs = new List<Register>();

            var index = 0;

            regs.Add(new Register(ud_type.UD_R_AL, ++index, 0b0001));
            regs.Add(new Register(ud_type.UD_R_AH, index, 0b0010));
            regs.Add(new Register(ud_type.UD_R_AX, index, 0b0011));
            regs.Add(new Register(ud_type.UD_R_EAX, index, 0b1111));

            regs.Add(new Register(ud_type.UD_R_BL, ++index, 0b0001));
            regs.Add(new Register(ud_type.UD_R_BH, index, 0b0010));
            regs.Add(new Register(ud_type.UD_R_BX, index, 0b0011));
            regs.Add(new Register(ud_type.UD_R_EBX, index, 0b1111));

            regs.Add(new Register(ud_type.UD_R_CL, ++index, 0b0001));
            regs.Add(new Register(ud_type.UD_R_CH, index, 0b0010));
            regs.Add(new Register(ud_type.UD_R_CX, index, 0b0011));
            regs.Add(new Register(ud_type.UD_R_ECX, index, 0b1111));

            regs.Add(new Register(ud_type.UD_R_DL, ++index, 0b0001));
            regs.Add(new Register(ud_type.UD_R_DH, index, 0b0010));
            regs.Add(new Register(ud_type.UD_R_DX, index, 0b0011));
            regs.Add(new Register(ud_type.UD_R_EDX, index, 0b1111));

            regs.Add(new Register(ud_type.UD_R_BPL, ++index, 0b0001));
            regs.Add(new Register(ud_type.UD_R_BP, index, 0b0011));
            regs.Add(new Register(ud_type.UD_R_EBP, index, 0b1111));

            regs.Add(new Register(ud_type.UD_R_SPL, ++index, 0b0001));
            regs.Add(new Register(ud_type.UD_R_SP, index, 0b0011));
            regs.Add(new Register(ud_type.UD_R_ESP, index, 0b1111));

            regs.Add(new Register(ud_type.UD_R_SIL, ++index, 0b0001));
            regs.Add(new Register(ud_type.UD_R_SI, index, 0b0011));
            regs.Add(new Register(ud_type.UD_R_ESI, index, 0b1111));

            regs.Add(new Register(ud_type.UD_R_DIL, ++index, 0b0001));
            regs.Add(new Register(ud_type.UD_R_DI, index, 0b0011));
            regs.Add(new Register(ud_type.UD_R_EDI, index, 0b1111));

            regs.Add(new Register(ud_type.UD_R_CS, ++index, 0b0011));
            regs.Add(new Register(ud_type.UD_R_SS, ++index, 0b0011));
            regs.Add(new Register(ud_type.UD_R_DS, ++index, 0b0011));
            regs.Add(new Register(ud_type.UD_R_ES, ++index, 0b0011));
            regs.Add(new Register(ud_type.UD_R_GS, ++index, 0b0011));
            regs.Add(new Register(ud_type.UD_R_FS, ++index, 0b0011));

            regs.Add(new Register(ud_type.UD_R_CR0, ++index, 0b1111));
            regs.Add(new Register(ud_type.UD_R_CR2, ++index, 0b1111));
            regs.Add(new Register(ud_type.UD_R_CR3, ++index, 0b1111));

            _registerByType = regs.ToDictionary(x => x.UdType, x => x);
        }

        public static Register GetRegister(ud_type udType) => _registerByType[udType];

        public static bool Intersects(ud_type a, ud_type b)
        {
            if (a == ud_type.UD_NONE || b == ud_type.UD_NONE)
                return false;

            var ra = GetRegister(a);
            var rb = GetRegister(b);

            return ra.Index == rb.Index && (ra.ByteMask & rb.ByteMask) != 0;
        }
    }
}
