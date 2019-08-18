using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_5164-280d8cf6")]
        public void Method_100d_5164()
        {
            ii(0x100d_5164, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100d_5169, 5); calld(Definitions.sys_check_available_stack_size, 0x9_0be4); /* call 0x10165d52 */
            ii(0x100d_516e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_516f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_5170, 1); pushd(esi);                             /* push esi */
            ii(0x100d_5171, 1); pushd(edi);                             /* push edi */
            ii(0x100d_5172, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_5173, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_5175, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_517b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_517e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_5181, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_5184, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_5187, 3); mov(memd_a32[ds, edx + 0x1c], eax);     /* mov [edx+0x1c], eax */
            ii(0x100d_518a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_518c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_518d, 1); popd(edi);                              /* pop edi */
            ii(0x100d_518e, 1); popd(esi);                              /* pop esi */
            ii(0x100d_518f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_5190, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_5191, 1); retd(); return;                         /* ret */
        }
    }
}
