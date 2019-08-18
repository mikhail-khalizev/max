using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_187b-cde636f0")]
        public void Method_100b_187b()
        {
            ii(0x100b_187b, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100b_1880, 5); calld(Definitions.sys_check_available_stack_size, 0xb_44cd); /* call 0x10165d52 */
            ii(0x100b_1885, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_1886, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_1887, 1); pushd(esi);                             /* push esi */
            ii(0x100b_1888, 1); pushd(edi);                             /* push edi */
            ii(0x100b_1889, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_188a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_188c, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_1892, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_1895, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_1898, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_189b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_189e, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_18a1, 5); calld(0x100b_7c14, 0x636e);             /* call 0x100b7c14 */
            ii(0x100b_18a6, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_18a9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_18ac, 5); calld(0x100b_7d68, 0x64b7);             /* call 0x100b7d68 */
            ii(0x100b_18b1, 5); calld(0x1015_2783, 0xa_0ecd);           /* call 0x10152783 */
            ii(0x100b_18b6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_18b8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_18bb, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_18be, 5); calld(0x1013_ad11, 0x8_944e);           /* call 0x1013ad11 */
            ii(0x100b_18c3, 2); test(al, al);                           /* test al, al */
            ii(0x100b_18c5, 2); if(jzd(0x100b_18d5, 0xe)) goto l_0x100b_18d5; /* jz 0x100b18d5 */
            ii(0x100b_18c7, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_18ca, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_18cd, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_18d0, 5); calld(0x100b_7cfc, 0x6427);             /* call 0x100b7cfc */
        l_0x100b_18d5:
            ii(0x100b_18d5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_18d7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_18da, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_18dd, 5); calld(0x1013_ad11, 0x8_942f);           /* call 0x1013ad11 */
            ii(0x100b_18e2, 2); test(al, al);                           /* test al, al */
            ii(0x100b_18e4, 2); if(jnzd(0x100b_190b, 0x25)) goto l_0x100b_190b; /* jnz 0x100b190b */
            ii(0x100b_18e6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_18e9, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_18ec, 5); calld(0x1007_65d0, -0x3_b321);          /* call 0x100765d0 */
            ii(0x100b_18f1, 5); calld(0x100a_b50c, -0x63ea);            /* call 0x100ab50c */
            ii(0x100b_18f6, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100b_18fb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_18fe, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_1901, 5); calld(0x1007_65d0, -0x3_b336);          /* call 0x100765d0 */
            ii(0x100b_1906, 5); calld(0x100a_297d, -0xef8e);            /* call 0x100a297d */
        l_0x100b_190b:
            ii(0x100b_190b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_190d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_190e, 1); popd(edi);                              /* pop edi */
            ii(0x100b_190f, 1); popd(esi);                              /* pop esi */
            ii(0x100b_1910, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_1911, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_1912, 1); retd(); return;                         /* ret */
        }
    }
}
