using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("484e6728-7480-46dc-bdfc-eb8559f7942c")]
        public void Method_100c_89a6()
        {
            ii(0x100c_89a6, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_89ab, 5); calld(Definitions.sys_check_available_stack_size, 0x9_d3a2); /* call 0x10165d52 */
            ii(0x100c_89b0, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_89b1, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_89b2, 1); pushd(edx);                             /* push edx */
            ii(0x100c_89b3, 1); pushd(esi);                             /* push esi */
            ii(0x100c_89b4, 1); pushd(edi);                             /* push edi */
            ii(0x100c_89b5, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_89b6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_89b8, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_89be, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_89c1, 4); mov(memb_a32[ss, ebp - 0x8], 0x16);     /* mov byte [ebp-0x8], 0x16 */
            ii(0x100c_89c5, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100c_89c8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_89ca, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_89cb, 1); popd(edi);                              /* pop edi */
            ii(0x100c_89cc, 1); popd(esi);                              /* pop esi */
            ii(0x100c_89cd, 1); popd(edx);                              /* pop edx */
            ii(0x100c_89ce, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_89cf, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_89d0, 1); retd(); return;                         /* ret */
        }
    }
}
