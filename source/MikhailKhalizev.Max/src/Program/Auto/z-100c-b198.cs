using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b198-bb7bbc0f")]
        public void Method_100c_b198()
        {
            ii(0x100c_b198, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100c_b19d, 5); calld(Definitions.sys_check_available_stack_size, 0x9_abb0); /* call 0x10165d52 */
            ii(0x100c_b1a2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b1a3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b1a4, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b1a5, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b1a6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b1a7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b1a9, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100c_b1af, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b1b2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_b1b5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_b1b8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b1bb, 5); calld(0x1007_6d14, -0x5_44ac);          /* call 0x10076d14 */
            ii(0x100c_b1c0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b1c3, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100c_b1c6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_b1c9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b1cc, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_b1cf, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_b1d2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b1d4, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b1d5, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b1d6, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b1d7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b1d8, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b1d9, 1); retd();                                 /* ret */
        }
    }
}
