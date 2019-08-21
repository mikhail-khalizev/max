using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_2339-632f0971")]
        public void Method_1016_2339()
        {
            ii(0x1016_2339, 5); mov(eax, StringDefinitions.Exploding3); /* mov eax, 0x101b2962 */
            ii(0x1016_233e, 5); calld(0x100a_8b4a, -0xb_97f9);          /* call 0x100a8b4a */
            ii(0x1016_2343, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2346, 3); mov(al, memb_a32[ds, eax + 0x3e]);      /* mov al, [eax+0x3e] */
            ii(0x1016_2349, 3); mov(memb_a32[ss, ebp - 0x3c], al);      /* mov [ebp-0x3c], al */
            ii(0x1016_234c, 2); jmpd(0x1016_2395, 0x47); goto l_0x1016_2395; /* jmp 0x10162395 */
        l_0x1016_234e:
            ii(0x1016_234e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2351, 4); mov(memb_a32[ds, eax + 0x4d], 0);       /* mov byte [eax+0x4d], 0x0 */
            ii(0x1016_2355, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2358, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_235a, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1016_235d, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x1016_2363, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2366, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1016_2369, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_236c, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1016_236e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_2370, 7); inc(memw_a32[ds, eax + 0x101c_a5e9]);   /* inc word [eax+0x101ca5e9] */
            ii(0x1016_2377, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_237a, 5); calld(0x1016_15c9, -0xdb6);             /* call 0x101615c9 */
        l_0x1016_237f:
            ii(0x1016_237f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2382, 5); calld(0x1016_0ec3, -0x14c4);            /* call 0x10160ec3 */
            ii(0x1016_2387, 2); jmpd(0x1016_23b7, 0x2e); goto l_0x1016_23b7; /* jmp 0x101623b7 */
        l_0x1016_2389:
            ii(0x1016_2389, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_238c, 5); calld(0x1016_11db, -0x11b6);            /* call 0x101611db */
            ii(0x1016_2391, 2); jmpd(0x1016_23b7, 0x24); goto l_0x1016_23b7; /* jmp 0x101623b7 */
        l_0x1016_2393:
            ii(0x1016_2393, 2); jmpd(0x1016_23b7, 0x22); goto l_0x1016_23b7; /* jmp 0x101623b7 */
        l_0x1016_2395:
            ii(0x1016_2395, 3); mov(al, memb_a32[ss, ebp - 0x3c]);      /* mov al, [ebp-0x3c] */
            ii(0x1016_2398, 3); mov(memb_a32[ss, ebp - 0x40], al);      /* mov [ebp-0x40], al */
            ii(0x1016_239b, 4); cmp(memb_a32[ss, ebp - 0x40], 0xe);     /* cmp byte [ebp-0x40], 0xe */
            ii(0x1016_239f, 2); if(jbd(0x1016_23af, 0xe)) goto l_0x1016_23af; /* jb 0x101623af */
            ii(0x1016_23a1, 4); cmp(memb_a32[ss, ebp - 0x40], 0xe);     /* cmp byte [ebp-0x40], 0xe */
            ii(0x1016_23a5, 2); if(jbed(0x1016_2389, -0x1e)) goto l_0x1016_2389; /* jbe 0x10162389 */
            ii(0x1016_23a7, 4); cmp(memb_a32[ss, ebp - 0x40], 0x1b);    /* cmp byte [ebp-0x40], 0x1b */
            ii(0x1016_23ab, 2); if(jzd(0x1016_234e, -0x5f)) goto l_0x1016_234e; /* jz 0x1016234e */
            ii(0x1016_23ad, 2); jmpd(0x1016_2393, -0x1c); goto l_0x1016_2393; /* jmp 0x10162393 */
        l_0x1016_23af:
            ii(0x1016_23af, 4); cmp(memb_a32[ss, ebp - 0x40], 0);       /* cmp byte [ebp-0x40], 0x0 */
            ii(0x1016_23b3, 2); if(jzd(0x1016_237f, -0x36)) goto l_0x1016_237f; /* jz 0x1016237f */
            ii(0x1016_23b5, 2); jmpd(0x1016_2393, -0x24); goto l_0x1016_2393; /* jmp 0x10162393 */
        l_0x1016_23b7:
            ii(0x1016_23b7, 5); if(jmpd_func(0x1016_29a7, 0x5eb)) return; /* jmp 0x101629a7 */
        }
    }
}
