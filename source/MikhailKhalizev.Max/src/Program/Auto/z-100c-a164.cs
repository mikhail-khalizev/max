using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("274f465b-20a2-403d-9973-3a141acca93d")]
        public void Method_100c_a164()
        {
            ii(0x100c_a164, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_a169, 5); calld(Definitions.sys_check_available_stack_size, 0x9_bbe4); /* call 0x10165d52 */
            ii(0x100c_a16e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_a16f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_a170, 1); pushd(esi);                             /* push esi */
            ii(0x100c_a171, 1); pushd(edi);                             /* push edi */
            ii(0x100c_a172, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_a173, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a175, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_a17b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_a17e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_a181, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100c_a186, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_a189, 5); calld(0x1013_ab27, 0x7_0999);           /* call 0x1013ab27 */
            ii(0x100c_a18e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_a191, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_a194, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_a197, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_a19a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a19c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_a19d, 1); popd(edi);                              /* pop edi */
            ii(0x100c_a19e, 1); popd(esi);                              /* pop esi */
            ii(0x100c_a19f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_a1a0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_a1a1, 1); retd(); return;                         /* ret */
        }
    }
}
