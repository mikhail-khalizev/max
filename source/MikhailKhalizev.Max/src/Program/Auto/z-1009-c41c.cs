using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c41c-10705259")]
        public void Method_1009_c41c()
        {
            ii(0x1009_c41c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_c421, 5); calld(Definitions.sys_check_available_stack_size, 0xc_992c); /* call 0x10165d52 */
            ii(0x1009_c426, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_c427, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_c428, 1); pushd(edx);                             /* push edx */
            ii(0x1009_c429, 1); pushd(esi);                             /* push esi */
            ii(0x1009_c42a, 1); pushd(edi);                             /* push edi */
            ii(0x1009_c42b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_c42c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c42e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_c434, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_c437, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_c43a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_c43c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c43f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c442, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c444, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_c445, 1); popd(edi);                              /* pop edi */
            ii(0x1009_c446, 1); popd(esi);                              /* pop esi */
            ii(0x1009_c447, 1); popd(edx);                              /* pop edx */
            ii(0x1009_c448, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_c449, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_c44a, 1); retd();                                 /* ret */
        }
    }
}
