using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8922d72b-5db8-4e7c-a31c-41137582b568")]
        public void Method_1009_c5dc()
        {
            ii(0x1009_c5dc, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1009_c5e1, 5); calld(Definitions.sys_check_available_stack_size, 0xc_976c); /* call 0x10165d52 */
            ii(0x1009_c5e6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_c5e7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_c5e8, 1); pushd(esi);                             /* push esi */
            ii(0x1009_c5e9, 1); pushd(edi);                             /* push edi */
            ii(0x1009_c5ea, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_c5eb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c5ed, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1009_c5f3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c5f6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_c5f9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_c5fc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c5ff, 5); calld(0x1007_6d14, -0x2_58f0);          /* call 0x10076d14 */
            ii(0x1009_c604, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c607, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_c60a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_c60d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c610, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_c613, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_c616, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c618, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_c619, 1); popd(edi);                              /* pop edi */
            ii(0x1009_c61a, 1); popd(esi);                              /* pop esi */
            ii(0x1009_c61b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_c61c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_c61d, 1); retd(); return;                         /* ret */
        }
    }
}
