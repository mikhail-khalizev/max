using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_c163-49b453a")]
        public void Method_100a_c163()
        {
            ii(0x100a_c163, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_c168, 5); calld(Definitions.sys_check_available_stack_size, 0xb_9be5); /* call 0x10165d52 */
            ii(0x100a_c16d, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_c16e, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_c16f, 1); pushd(esi);                             /* push esi */
            ii(0x100a_c170, 1); pushd(edi);                             /* push edi */
            ii(0x100a_c171, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_c172, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_c174, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_c17a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_c17d, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100a_c180, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_c183, 4); mov(memb_a32[ds, edx + 0x1e], 0x1);     /* mov byte [edx+0x1e], 0x1 */
            ii(0x100a_c187, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100a_c18a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_c18d, 3); mov(memb_a32[ds, edx + 0x1f], al);      /* mov [edx+0x1f], al */
            ii(0x100a_c190, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_c192, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_c193, 1); popd(edi);                              /* pop edi */
            ii(0x100a_c194, 1); popd(esi);                              /* pop esi */
            ii(0x100a_c195, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_c196, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_c197, 1); retd(); return;                         /* ret */
        }
    }
}
