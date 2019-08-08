using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9a0d87f8-18d6-426a-ba59-70089f12a07f")]
        public void Method_1012_5981()
        {
            ii(0x1012_5981, 6); mov(edx, memd_a32[ds, 0x101c_586c]);    /* mov edx, [0x101c586c] */
            ii(0x1012_5987, 5); mov(eax, memd_a32[ds, 0x101c_5870]);    /* mov eax, [0x101c5870] */
            ii(0x1012_598c, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1012_598e, 2); cmp(edx, memd_a32[ds, eax]);            /* cmp edx, [eax] */
            ii(0x1012_5990, 6); if(jzd_func(0x1012_5bcc, 0x236)) return; /* jz 0x10125bcc */
            ii(0x1012_5996, 5); mov(eax, memd_a32[ds, 0x101c_5870]);    /* mov eax, [0x101c5870] */
            ii(0x1012_599b, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1012_599d, 5); mov(eax, memd_a32[ds, 0x101c_5870]);    /* mov eax, [0x101c5870] */
            ii(0x1012_59a2, 2); inc(memd_a32[ds, eax]);                 /* inc dword [eax] */
            ii(0x1012_59a4, 5); mov(eax, memd_a32[ds, 0x101c_5980]);    /* mov eax, [0x101c5980] */
            ii(0x1012_59a9, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_59ab, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1012_59ad, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x1012_59b0, 5); mov(eax, memd_a32[ds, 0x101c_5870]);    /* mov eax, [0x101c5870] */
            ii(0x1012_59b5, 6); cmp(memd_a32[ds, eax], 0x400);          /* cmp dword [eax], 0x400 */
            ii(0x1012_59bb, 2); if(jnzd(0x1012_59c8, 0xb)) goto l_0x1012_59c8; /* jnz 0x101259c8 */
            ii(0x1012_59bd, 5); mov(eax, memd_a32[ds, 0x101c_5870]);    /* mov eax, [0x101c5870] */
            ii(0x1012_59c2, 6); mov(memd_a32[ds, eax], 0);              /* mov dword [eax], 0x0 */
        l_0x1012_59c8:
            ii(0x1012_59c8, 5); mov(al, memb_a32[ds, 0x101c_5631]);     /* mov al, [0x101c5631] */
            ii(0x1012_59cd, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1012_59d0, 5); if(jmpd_func(0x1012_5bac, 0x1d7)) return; /* jmp 0x10125bac */
        }
    }
}
