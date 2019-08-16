using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1e1820be-fedd-4f1c-8ec2-f5aaf988d4dd")]
        public void Method_1014_579c()
        {
            ii(0x1014_579c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_57a1, 5); calld(Definitions.sys_check_available_stack_size, 0x2_05ac); /* call 0x10165d52 */
            ii(0x1014_57a6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_57a7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_57a8, 1); pushd(esi);                             /* push esi */
            ii(0x1014_57a9, 1); pushd(edi);                             /* push edi */
            ii(0x1014_57aa, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_57ab, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_57ad, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_57b3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_57b6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_57b9, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1014_57bd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_57c0, 5); calld(0x1013_b399, -0xa42c);            /* call 0x1013b399 */
            ii(0x1014_57c5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_57c8, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_57cb, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_57ce, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_57d1, 7); mov(memd_a32[ds, eax + 0xa], 0x101b_7200); /* mov dword [eax+0xa], 0x101b7200 */
            ii(0x1014_57d8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_57db, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_57de, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_57e1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_57e3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_57e4, 1); popd(edi);                              /* pop edi */
            ii(0x1014_57e5, 1); popd(esi);                              /* pop esi */
            ii(0x1014_57e6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_57e7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_57e8, 1); retd(); return;                         /* ret */
        }
    }
}