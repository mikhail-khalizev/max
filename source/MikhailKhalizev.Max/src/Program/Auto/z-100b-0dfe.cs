using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_0dfe-64566adb")]
        public void Method_100b_0dfe()
        {
            ii(0x100b_0dfe, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_0e03, 5); calld(Definitions.sys_check_available_stack_size, 0xb_4f4a); /* call 0x10165d52 */
            ii(0x100b_0e08, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_0e09, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_0e0a, 1); pushd(edx);                             /* push edx */
            ii(0x100b_0e0b, 1); pushd(esi);                             /* push esi */
            ii(0x100b_0e0c, 1); pushd(edi);                             /* push edi */
            ii(0x100b_0e0d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_0e0e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_0e10, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_0e16, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_0e19, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_0e1c, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_0e1f, 5); calld(0x1013_a794, 0x8_9970);           /* call 0x1013a794 */
            ii(0x100b_0e24, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x100b_0e27, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_0e2a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_0e2d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_0e2f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_0e30, 1); popd(edi);                              /* pop edi */
            ii(0x100b_0e31, 1); popd(esi);                              /* pop esi */
            ii(0x100b_0e32, 1); popd(edx);                              /* pop edx */
            ii(0x100b_0e33, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_0e34, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_0e35, 1); retd(); return;                         /* ret */
        }
    }
}
