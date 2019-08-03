using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6d04a4f7-553d-4754-988e-00e91dfd90a8")]
        public void Method_100a_b3b0()
        {
            ii(0x100a_b3b0, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_b3b5, 5); calld(Definitions.sys_check_available_stack_size, 0xba998); /* call 0x10165d52 */
            ii(0x100a_b3ba, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_b3bb, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_b3bc, 1); pushd(esi);                             /* push esi */
            ii(0x100a_b3bd, 1); pushd(edi);                             /* push edi */
            ii(0x100a_b3be, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_b3bf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b3c1, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_b3c7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_b3ca, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_b3cd, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_b3d0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_b3d3, 5); calld(0x1013_abc3, 0x8f7eb);            /* call 0x1013abc3 */
            ii(0x100a_b3d8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_b3db, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_b3de, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_b3e1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_b3e4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_b3e7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_b3ea, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b3ec, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_b3ed, 1); popd(edi);                              /* pop edi */
            ii(0x100a_b3ee, 1); popd(esi);                              /* pop esi */
            ii(0x100a_b3ef, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_b3f0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_b3f1, 1); retd(); return;                         /* ret */
        }
    }
}
