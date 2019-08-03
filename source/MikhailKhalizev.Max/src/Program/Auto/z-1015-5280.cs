using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7d8954c3-0d15-40e4-8272-b78fe043f74a")]
        public void Method_1015_5280()
        {
            ii(0x1015_5280, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_5285, 5); calld(Definitions.sys_check_available_stack_size, 0x10ac8); /* call 0x10165d52 */
            ii(0x1015_528a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_528b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_528c, 1); pushd(esi);                             /* push esi */
            ii(0x1015_528d, 1); pushd(edi);                             /* push edi */
            ii(0x1015_528e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_528f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_5291, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_5297, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_529a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_529d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_52a0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_52a3, 5); calld(0x1013_acc5, -0x1a5e3);           /* call 0x1013acc5 */
            ii(0x1015_52a8, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_52ab, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_52ae, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_52b0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_52b1, 1); popd(edi);                              /* pop edi */
            ii(0x1015_52b2, 1); popd(esi);                              /* pop esi */
            ii(0x1015_52b3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_52b4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_52b5, 1); retd(); return;                         /* ret */
        }
    }
}
