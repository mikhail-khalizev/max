using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c0a5971a-fc68-4f9d-bac3-22fd71c7a2c1")]
        public void Method_100e_873c()
        {
            ii(0x100e_873c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_8741, 5); calld(Definitions.sys_check_available_stack_size, 0x7d60c); /* call 0x10165d52 */
            ii(0x100e_8746, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_8747, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_8748, 1); pushd(edx);                             /* push edx */
            ii(0x100e_8749, 1); pushd(esi);                             /* push esi */
            ii(0x100e_874a, 1); pushd(edi);                             /* push edi */
            ii(0x100e_874b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_874c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_874e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_8754, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_8757, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_875a, 4); mov(ax, memw_a32[ds, eax + 0x10]);      /* mov ax, [eax+0x10] */
            ii(0x100e_875e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_8761, 4); sub(ax, memw_a32[ds, edx + 0x8]);       /* sub ax, [edx+0x8] */
            ii(0x100e_8765, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_8768, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_876b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_876d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_876e, 1); popd(edi);                              /* pop edi */
            ii(0x100e_876f, 1); popd(esi);                              /* pop esi */
            ii(0x100e_8770, 1); popd(edx);                              /* pop edx */
            ii(0x100e_8771, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_8772, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_8773, 1); retd(); return;                         /* ret */
        }
    }
}
