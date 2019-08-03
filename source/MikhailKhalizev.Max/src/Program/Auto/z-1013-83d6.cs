using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a35ec277-4c4d-4b8e-9ee2-cae2d1d0316f")]
        public void Method_1013_83d6()
        {
            ii(0x1013_83d6, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1013_83db, 5); calld(Definitions.sys_check_available_stack_size, 0x2d972); /* call 0x10165d52 */
            ii(0x1013_83e0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_83e1, 1); pushd(esi);                             /* push esi */
            ii(0x1013_83e2, 1); pushd(edi);                             /* push edi */
            ii(0x1013_83e3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_83e4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_83e6, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1013_83ec, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_83ef, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1013_83f2, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1013_83f5, 5); mov(eax, 0x4ff);                        /* mov eax, 0x4ff */
            ii(0x1013_83fa, 5); calld(0x1013_82da, -0x125);             /* call 0x101382da */
            ii(0x1013_83ff, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_8401, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_8406, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_840a, 3); imul(eax, eax, 0x53);                   /* imul eax, eax, 0x53 */
            ii(0x1013_840d, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1013_8410, 3); mov(eax, memd_a32[ds, eax + 0x1c]);     /* mov eax, [eax+0x1c] */
            ii(0x1013_8413, 5); calld(/* sys */ 0x1016_98f4, 0x314dc);  /* call 0x101698f4 */
            ii(0x1013_8418, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x1013_841b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1013_841e, 5); calld(/* sys */ 0x1016_b244, 0x32e21);  /* call 0x1016b244 */
            ii(0x1013_8423, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1013_8427, 2); if(jzd(0x1013_8438, 0xf)) goto l_0x1013_8438; /* jz 0x10138438 */
            ii(0x1013_8429, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_842d, 3); imul(eax, eax, 0x53);                   /* imul eax, eax, 0x53 */
            ii(0x1013_8430, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1013_8433, 5); calld(0x1013_6df4, -0x1644);            /* call 0x10136df4 */
        l_0x1013_8438:
            ii(0x1013_8438, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_843a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_843b, 1); popd(edi);                              /* pop edi */
            ii(0x1013_843c, 1); popd(esi);                              /* pop esi */
            ii(0x1013_843d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_843e, 1); retd(); return;                         /* ret */
        }
    }
}
