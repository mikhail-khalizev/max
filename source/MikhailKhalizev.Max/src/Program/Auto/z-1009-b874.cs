using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_b874-84894c68")]
        public void Method_1009_b874()
        {
            ii(0x1009_b874, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_b879, 5); calld(Definitions.sys_check_available_stack_size, 0xc_a4d4); /* call 0x10165d52 */
            ii(0x1009_b87e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_b87f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_b880, 1); pushd(esi);                             /* push esi */
            ii(0x1009_b881, 1); pushd(edi);                             /* push edi */
            ii(0x1009_b882, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_b883, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_b885, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_b88b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_b88e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_b891, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_b893, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_b896, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x1009_b899, 5); calld(0x1007_5f2c, -0x2_5972);          /* call 0x10075f2c */
            ii(0x1009_b89e, 3); sub(eax, 0x1b);                         /* sub eax, 0x1b */
            ii(0x1009_b8a1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_b8a4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_b8a6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_b8a9, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_b8ac, 5); calld(0x1007_5f2c, -0x2_5985);          /* call 0x10075f2c */
            ii(0x1009_b8b1, 3); sub(eax, 0x17);                         /* sub eax, 0x17 */
            ii(0x1009_b8b4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_b8b7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_b8b9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_b8bc, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_b8bf, 5); calld(0x1007_5f2c, -0x2_5998);          /* call 0x10075f2c */
            ii(0x1009_b8c4, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1009_b8c7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_b8ca, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1009_b8cf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_b8d2, 5); calld(0x100a_284c, 0x6f75);             /* call 0x100a284c */
            ii(0x1009_b8d7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_b8da, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_b8dd, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_b8e0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_b8e3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_b8e5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_b8e6, 1); popd(edi);                              /* pop edi */
            ii(0x1009_b8e7, 1); popd(esi);                              /* pop esi */
            ii(0x1009_b8e8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_b8e9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_b8ea, 1); retd(); return;                         /* ret */
        }
    }
}
