using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b627d064-85b4-4540-80af-a90b3771507a")]
        public void Method_1008_c7f0()
        {
            ii(0x1008_c7f0, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1008_c7f5, 5); calld(Definitions.sys_check_available_stack_size, 0xd_9558); /* call 0x10165d52 */
            ii(0x1008_c7fa, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_c7fb, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_c7fc, 1); pushd(edx);                             /* push edx */
            ii(0x1008_c7fd, 1); pushd(esi);                             /* push esi */
            ii(0x1008_c7fe, 1); pushd(edi);                             /* push edi */
            ii(0x1008_c7ff, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_c800, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_c802, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1008_c808, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_c80b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_c80d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c810, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_c813, 5); calld(0x1013_ad71, 0xa_e559);           /* call 0x1013ad71 */
            ii(0x1008_c818, 2); test(al, al);                           /* test al, al */
            ii(0x1008_c81a, 2); if(jzd(0x1008_c83c, 0x20)) goto l_0x1008_c83c; /* jz 0x1008c83c */
            ii(0x1008_c81c, 5); calld(0x1008_a79c, -0x2085);            /* call 0x1008a79c */
            ii(0x1008_c821, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_c823, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1008_c825, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c828, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_c82b, 5); calld(0x1007_65d0, -0x1_6260);          /* call 0x100765d0 */
            ii(0x1008_c830, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_c832, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_c837, 5); calld(0x100a_53ac, 0x1_8b70);           /* call 0x100a53ac */
        l_0x1008_c83c:
            ii(0x1008_c83c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_c83e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c841, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_c844, 5); calld(0x1007_6630, -0x1_6219);          /* call 0x10076630 */
            ii(0x1008_c849, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_c84b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c84e, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_c851, 5); calld(0x1008_afe4, -0x1872);            /* call 0x1008afe4 */
            ii(0x1008_c856, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_c859, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_c85e, 5); calld(0x100a_5e27, 0x1_95c4);           /* call 0x100a5e27 */
            ii(0x1008_c863, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_c865, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_c866, 1); popd(edi);                              /* pop edi */
            ii(0x1008_c867, 1); popd(esi);                              /* pop esi */
            ii(0x1008_c868, 1); popd(edx);                              /* pop edx */
            ii(0x1008_c869, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_c86a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_c86b, 1); retd(); return;                         /* ret */
        }
    }
}
