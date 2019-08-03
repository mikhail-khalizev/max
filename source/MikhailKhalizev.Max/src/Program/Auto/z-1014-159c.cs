using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("614ccd0f-6df7-42c1-92ab-c1c41f46c6da")]
        public void Method_1014_159c()
        {
            ii(0x1014_159c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_15a1, 5); calld(Definitions.sys_check_available_stack_size, 0x247ac); /* call 0x10165d52 */
            ii(0x1014_15a6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_15a7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_15a8, 1); pushd(esi);                             /* push esi */
            ii(0x1014_15a9, 1); pushd(edi);                             /* push edi */
            ii(0x1014_15aa, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_15ab, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_15ad, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_15b3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_15b6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_15b9, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1014_15bd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_15c0, 5); calld(0x1014_15d4, 0xf);                /* call 0x101415d4 */
            ii(0x1014_15c5, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_15c8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_15cb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_15cd, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_15ce, 1); popd(edi);                              /* pop edi */
            ii(0x1014_15cf, 1); popd(esi);                              /* pop esi */
            ii(0x1014_15d0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_15d1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_15d2, 1); retd(); return;                         /* ret */
        }
    }
}
