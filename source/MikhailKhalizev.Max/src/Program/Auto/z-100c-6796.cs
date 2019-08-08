using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b24c561f-54e6-476d-ad32-38c8f10e8427")]
        public void Method_100c_6796()
        {
        l_0x100c_6796:
            ii(0x100c_6796, 2); if(jmpd_func(0x100c_67d1, 0x39)) return; /* jmp 0x100c67d1 */
            ii(0x100c_6798, 3); sub(ah, memb_a32[ds, edi + 0xc]);       /* sub ah, [edi+0xc] */
            ii(0x100c_679b, 3); adc(memb_a32[ds, esi + 0x67], cl);      /* adc [esi+0x67], cl */
            ii(0x100c_679e, 2); or(al, 0x10);                           /* or al, 0x10 */
            ii(0x100c_67a0, 2); if(jbd_func(0x100c_6809, 0x67)) return; /* jb 0x100c6809 */
            ii(0x100c_67a2, 2); or(al, 0x10);                           /* or al, 0x10 */
            ii(0x100c_67a4, 1); xchg(esi, eax);                         /* xchg esi, eax */
            ii(0x100c_67a5, 3); or(al, 0x10);                           /* a16 or al, 0x10 */
            ii(0x100c_67a8, 1); xchg(esi, eax);                         /* xchg esi, eax */
            ii(0x100c_67a9, 3); or(al, 0x10);                           /* a16 or al, 0x10 */
            ii(0x100c_67ac, 1); xchg(esi, eax);                         /* xchg esi, eax */
            ii(0x100c_67ad, 3); or(al, 0x10);                           /* a16 or al, 0x10 */
            ii(0x100c_67b0, 3); sub(ah, memb_a32[ds, edi + 0xc]);       /* sub ah, [edi+0xc] */
            ii(0x100c_67b3, 6); adc(memb_a32[ds, edx + 0x22c_e045], cl); /* adc [edx+0x22ce045], cl */
            ii(0x100c_67b9, 3); mov(memb_a32[ss, ebp - 0x24], al);      /* mov [ebp-0x24], al */
            ii(0x100c_67bc, 4); cmp(memb_a32[ss, ebp - 0x24], 0x6);     /* cmp byte [ebp-0x24], 0x6 */
            ii(0x100c_67c0, 2); if(jad(0x100c_6796, -0x2c)) goto l_0x100c_6796; /* ja 0x100c6796 */
            ii(0x100c_67c2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_67c4, 3); mov(al, memb_a32[ss, ebp - 0x24]);      /* mov al, [ebp-0x24] */
            ii(0x100c_67c7, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_67ca, 7); if(jmpd_abs(memd_a32[cs, eax + 0x100c_6798])) return; /* jmp dword [cs:eax+0x100c6798] */
        }
    }
}
