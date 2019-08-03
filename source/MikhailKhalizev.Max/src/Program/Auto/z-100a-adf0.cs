using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f3c0348e-45bc-4dc1-81bd-1a80d1fc71c0")]
        public void Method_100a_adf0()
        {
            ii(0x100a_adf0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_adf5, 5); calld(Definitions.sys_check_available_stack_size, 0xbaf58); /* call 0x10165d52 */
            ii(0x100a_adfa, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_adfb, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_adfc, 1); pushd(edx);                             /* push edx */
            ii(0x100a_adfd, 1); pushd(esi);                             /* push esi */
            ii(0x100a_adfe, 1); pushd(edi);                             /* push edi */
            ii(0x100a_adff, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_ae00, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_ae02, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_ae08, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_ae0b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ae0e, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100a_ae10, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_ae13, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_ae16, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_ae18, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_ae19, 1); popd(edi);                              /* pop edi */
            ii(0x100a_ae1a, 1); popd(esi);                              /* pop esi */
            ii(0x100a_ae1b, 1); popd(edx);                              /* pop edx */
            ii(0x100a_ae1c, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_ae1d, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_ae1e, 1); retd(); return;                         /* ret */
        }
    }
}
