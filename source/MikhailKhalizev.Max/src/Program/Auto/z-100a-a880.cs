using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a880-3936b511")]
        public void Method_100a_a880()
        {
            ii(0x100a_a880, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_a885, 5); calld(Definitions.sys_check_available_stack_size, 0xb_b4c8); /* call 0x10165d52 */
            ii(0x100a_a88a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_a88b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_a88c, 1); pushd(esi);                             /* push esi */
            ii(0x100a_a88d, 1); pushd(edi);                             /* push edi */
            ii(0x100a_a88e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_a88f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a891, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_a897, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a89a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_a89d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_a8a0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a8a3, 5); calld(0x1013_ac03, 0x9_035b);           /* call 0x1013ac03 */
            ii(0x100a_a8a8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a8ab, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_a8ae, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_a8b1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a8b4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_a8b7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_a8ba, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a8bc, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_a8bd, 1); popd(edi);                              /* pop edi */
            ii(0x100a_a8be, 1); popd(esi);                              /* pop esi */
            ii(0x100a_a8bf, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_a8c0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_a8c1, 1); retd(); return;                         /* ret */
        }
    }
}
