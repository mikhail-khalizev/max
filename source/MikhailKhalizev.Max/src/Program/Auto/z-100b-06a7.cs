using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("090864a6-2b73-40e6-a482-a98e4ec09c97")]
        public void Method_100b_06a7()
        {
            ii(0x100b_06a7, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_06ac, 5); calld(Definitions.sys_check_available_stack_size, 0xb_56a1); /* call 0x10165d52 */
            ii(0x100b_06b1, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_06b2, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_06b3, 1); pushd(esi);                             /* push esi */
            ii(0x100b_06b4, 1); pushd(edi);                             /* push edi */
            ii(0x100b_06b5, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_06b6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_06b8, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_06be, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_06c1, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_06c4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_06c7, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_06ca, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_06cd, 5); calld(0x100b_06da, 0x8);                /* call 0x100b06da */
            ii(0x100b_06d2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_06d4, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_06d5, 1); popd(edi);                              /* pop edi */
            ii(0x100b_06d6, 1); popd(esi);                              /* pop esi */
            ii(0x100b_06d7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_06d8, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_06d9, 1); retd(); return;                         /* ret */
        }
    }
}
