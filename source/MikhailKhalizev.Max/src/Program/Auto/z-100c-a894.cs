using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0fef7e7e-3ef1-4bce-b9c8-3fe88cbedb94")]
        public void Method_100c_a894()
        {
            ii(0x100c_a894, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_a899, 5); calld(Definitions.sys_check_available_stack_size, 0x9_b4b4); /* call 0x10165d52 */
            ii(0x100c_a89e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_a89f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_a8a0, 1); pushd(esi);                             /* push esi */
            ii(0x100c_a8a1, 1); pushd(edi);                             /* push edi */
            ii(0x100c_a8a2, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_a8a3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a8a5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_a8ab, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_a8ae, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_a8b1, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_a8b4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_a8b7, 5); calld(0x1013_ac7d, 0x7_03c1);           /* call 0x1013ac7d */
            ii(0x100c_a8bc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_a8bf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_a8c2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a8c4, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_a8c5, 1); popd(edi);                              /* pop edi */
            ii(0x100c_a8c6, 1); popd(esi);                              /* pop esi */
            ii(0x100c_a8c7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_a8c8, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_a8c9, 1); retd(); return;                         /* ret */
        }
    }
}
