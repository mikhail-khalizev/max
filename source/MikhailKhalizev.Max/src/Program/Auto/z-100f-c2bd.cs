using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_c2bd-2adfa9c")]
        public void Method_100f_c2bd()
        {
            ii(0x100f_c2bd, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100f_c2c2, 5); calld(Definitions.sys_check_available_stack_size, 0x6_9a8b); /* call 0x10165d52 */
            ii(0x100f_c2c7, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_c2c8, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_c2c9, 1); pushd(edx);                             /* push edx */
            ii(0x100f_c2ca, 1); pushd(esi);                             /* push esi */
            ii(0x100f_c2cb, 1); pushd(edi);                             /* push edi */
            ii(0x100f_c2cc, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_c2cd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_c2cf, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100f_c2d5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_c2d8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_c2db, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_c2de, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_c2e1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_c2e3, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_c2e4, 1); popd(edi);                              /* pop edi */
            ii(0x100f_c2e5, 1); popd(esi);                              /* pop esi */
            ii(0x100f_c2e6, 1); popd(edx);                              /* pop edx */
            ii(0x100f_c2e7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_c2e8, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_c2e9, 1); retd(); return;                         /* ret */
        }
    }
}
