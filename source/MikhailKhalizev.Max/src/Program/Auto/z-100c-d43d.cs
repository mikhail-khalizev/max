using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_d43d-6bec56b8")]
        public void Method_100c_d43d()
        {
            ii(0x100c_d43d, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_d442, 5); calld(Definitions.sys_check_available_stack_size, 0x9_890b); /* call 0x10165d52 */
            ii(0x100c_d447, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_d448, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_d449, 1); pushd(edx);                             /* push edx */
            ii(0x100c_d44a, 1); pushd(esi);                             /* push esi */
            ii(0x100c_d44b, 1); pushd(edi);                             /* push edi */
            ii(0x100c_d44c, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_d44d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_d44f, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100c_d455, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_d458, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_d45a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_d45b, 1); popd(edi);                              /* pop edi */
            ii(0x100c_d45c, 1); popd(esi);                              /* pop esi */
            ii(0x100c_d45d, 1); popd(edx);                              /* pop edx */
            ii(0x100c_d45e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_d45f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_d460, 1); retd(); return;                         /* ret */
        }
    }
}
