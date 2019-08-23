using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_e8e4-659a2d7d")]
        public void /* sys */ Method_1018_e8e4()
        {
            ii(0x1018_e8e4, 3); dec(memd[ss, ebp - 0x14]);              /* dec dword [ebp-0x14] */
            ii(0x1018_e8e7, 2); if(js(0x1018_e90f, 0x26)) goto l_0x1018_e90f; /* js 0x1018e90f */
            ii(0x1018_e8e9, 3); mov(ebx, memd[ss, ebp + 0x8]);          /* mov ebx, [ebp+0x8] */
            ii(0x1018_e8ec, 2); mov(al, memb[ds, ebx]);                 /* mov al, [ebx] */
            ii(0x1018_e8ee, 1); inc(ebx);                               /* inc ebx */
            ii(0x1018_e8ef, 3); mov(memd[ss, ebp + 0x8], ebx);          /* mov [ebp+0x8], ebx */
            ii(0x1018_e8f2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_e8f4, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1018_e8f6, 3); shr(bl, 0x4);                           /* shr bl, 0x4 */
            ii(0x1018_e8f9, 3); and(eax, 0xf);                          /* and eax, 0xf */
            ii(0x1018_e8fc, 5); push(/* sys */ 0x1018_e8e4);            /* push 0x1018e8e4 */
            ii(0x1018_e901, 7); push(memd[ds, ebx * 4 + 0x101b_f910]);  /* push dword [ebx*4+0x101bf910] */
            ii(0x1018_e908, 7); if(jmp_abs(memd[ds, eax * 4 + 0x101b_f910])) return; /* jmp dword [eax*4+0x101bf910] */
        l_0x1018_e90f:
            ii(0x1018_e90f, 3); add(edi, memd[ss, ebp - 0x8]);          /* add edi, [ebp-0x8] */
            ii(0x1018_e912, 3); dec(memd[ss, ebp + 0x1c]);              /* dec dword [ebp+0x1c] */
            ii(0x1018_e915, 2); if(jnz_func(0x1018_e8dc, -0x3b)) return; /* jnz 0x1018e8dc */
            ii(0x1018_e917, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_e918, 1); pop(edi);                               /* pop edi */
            ii(0x1018_e919, 1); pop(esi);                               /* pop esi */
            ii(0x1018_e91a, 1); leave();                                /* leave */
            ii(0x1018_e91b, 1); ret();                                  /* ret */
        }
    }
}
