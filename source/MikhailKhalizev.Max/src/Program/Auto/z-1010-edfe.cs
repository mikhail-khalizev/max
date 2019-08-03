using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0244430b-0436-4695-9918-8f4e0722fe01")]
        public void Method_1010_edfe()
        {
            ii(0x1010_edfe, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_ee03, 5); calld(Definitions.sys_check_available_stack_size, 0x56f4a); /* call 0x10165d52 */
            ii(0x1010_ee08, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_ee09, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_ee0a, 1); pushd(edx);                             /* push edx */
            ii(0x1010_ee0b, 1); pushd(esi);                             /* push esi */
            ii(0x1010_ee0c, 1); pushd(edi);                             /* push edi */
            ii(0x1010_ee0d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_ee0e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_ee10, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_ee16, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_ee19, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ee1c, 1); pushd(eax);                             /* push eax */
            ii(0x1010_ee1d, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_ee1f, 5); mov(ebx, 0xae);                         /* mov ebx, 0xae */
            ii(0x1010_ee24, 5); mov(edx, 0x190);                        /* mov edx, 0x190 */
            ii(0x1010_ee29, 5); mov(eax, 0x22e);                        /* mov eax, 0x22e */
            ii(0x1010_ee2e, 5); calld(0x100e_8ef1, -0x25f42);           /* call 0x100e8ef1 */
            ii(0x1010_ee33, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_ee35, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_ee36, 1); popd(edi);                              /* pop edi */
            ii(0x1010_ee37, 1); popd(esi);                              /* pop esi */
            ii(0x1010_ee38, 1); popd(edx);                              /* pop edx */
            ii(0x1010_ee39, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_ee3a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_ee3b, 1); retd(); return;                         /* ret */
        }
    }
}
