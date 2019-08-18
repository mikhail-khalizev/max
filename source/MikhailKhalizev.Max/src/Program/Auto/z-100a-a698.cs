using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a698-53e302d3")]
        public void Method_100a_a698()
        {
            ii(0x100a_a698, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_a69d, 5); calld(Definitions.sys_check_available_stack_size, 0xb_b6b0); /* call 0x10165d52 */
            ii(0x100a_a6a2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_a6a3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_a6a4, 1); pushd(esi);                             /* push esi */
            ii(0x100a_a6a5, 1); pushd(edi);                             /* push edi */
            ii(0x100a_a6a6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_a6a7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a6a9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_a6af, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a6b2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_a6b5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_a6b7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a6ba, 3); add(eax, 0x48);                         /* add eax, 0x48 */
            ii(0x100a_a6bd, 5); calld(0x1008_8b04, -0x2_1bbe);          /* call 0x10088b04 */
            ii(0x100a_a6c2, 3); sub(eax, 0x48);                         /* sub eax, 0x48 */
            ii(0x100a_a6c5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a6c8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_a6ca, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a6cd, 3); add(eax, 0x44);                         /* add eax, 0x44 */
            ii(0x100a_a6d0, 5); calld(0x1007_5f2c, -0x3_47a9);          /* call 0x10075f2c */
            ii(0x100a_a6d5, 3); sub(eax, 0x44);                         /* sub eax, 0x44 */
            ii(0x100a_a6d8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a6db, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_a6dd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a6e0, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100a_a6e3, 5); calld(0x1007_5eac, -0x3_483c);          /* call 0x10075eac */
            ii(0x100a_a6e8, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x100a_a6eb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a6ee, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a6f1, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_a6f4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_a6f7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a6f9, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_a6fa, 1); popd(edi);                              /* pop edi */
            ii(0x100a_a6fb, 1); popd(esi);                              /* pop esi */
            ii(0x100a_a6fc, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_a6fd, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_a6fe, 1); retd(); return;                         /* ret */
        }
    }
}
