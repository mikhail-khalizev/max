using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b0b59148-784f-44dc-bfee-e7c6f52a2fa8")]
        public void Method_100b_3ace()
        {
            ii(0x100b_3ace, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_3ad3, 5); calld(Definitions.sys_check_available_stack_size, 0xb_227a); /* call 0x10165d52 */
            ii(0x100b_3ad8, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_3ad9, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_3ada, 1); pushd(edx);                             /* push edx */
            ii(0x100b_3adb, 1); pushd(esi);                             /* push esi */
            ii(0x100b_3adc, 1); pushd(edi);                             /* push edi */
            ii(0x100b_3add, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_3ade, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_3ae0, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_3ae6, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_3ae9, 7); mov(memd_a32[ss, ebp - 0x8], 0x4);      /* mov dword [ebp-0x8], 0x4 */
            ii(0x100b_3af0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_3af3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_3af5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_3af6, 1); popd(edi);                              /* pop edi */
            ii(0x100b_3af7, 1); popd(esi);                              /* pop esi */
            ii(0x100b_3af8, 1); popd(edx);                              /* pop edx */
            ii(0x100b_3af9, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_3afa, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_3afb, 1); retd(); return;                         /* ret */
        }
    }
}
