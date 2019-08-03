using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8cc6d170-4c64-4f45-a920-62488a3929fd")]
        public void Method_100a_b168()
        {
            ii(0x100a_b168, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_b16d, 5); calld(Definitions.sys_check_available_stack_size, 0xbabe0); /* call 0x10165d52 */
            ii(0x100a_b172, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_b173, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_b174, 1); pushd(esi);                             /* push esi */
            ii(0x100a_b175, 1); pushd(edi);                             /* push edi */
            ii(0x100a_b176, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_b177, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b179, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_b17f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_b182, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100a_b185, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100a_b188, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_b18b, 3); mov(memb_a32[ds, edx + 0x6], al);       /* mov [edx+0x6], al */
            ii(0x100a_b18e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b190, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_b191, 1); popd(edi);                              /* pop edi */
            ii(0x100a_b192, 1); popd(esi);                              /* pop esi */
            ii(0x100a_b193, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_b194, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_b195, 1); retd(); return;                         /* ret */
        }
    }
}
