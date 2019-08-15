using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("77114c5e-b3f5-434c-b424-f2e3e9dc0709")]
        public void Method_1007_c800()
        {
            ii(0x1007_c800, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_c805, 5); calld(Definitions.sys_check_available_stack_size, 0xe_9548); /* call 0x10165d52 */
            ii(0x1007_c80a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_c80b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_c80c, 1); pushd(edx);                             /* push edx */
            ii(0x1007_c80d, 1); pushd(esi);                             /* push esi */
            ii(0x1007_c80e, 1); pushd(edi);                             /* push edi */
            ii(0x1007_c80f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_c810, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_c812, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_c818, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_c81b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_c81d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_c820, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_c823, 5); calld(0x1013_ad71, 0xb_e549);           /* call 0x1013ad71 */
            ii(0x1007_c828, 2); test(al, al);                           /* test al, al */
            ii(0x1007_c82a, 6); if(jzd(0x1007_c8f5, 0xc5)) goto l_0x1007_c8f5; /* jz 0x1007c8f5 */
            ii(0x1007_c830, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_c833, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x1007_c836, 5); calld(0x1007_6338, -0x6503);            /* call 0x10076338 */
            ii(0x1007_c83b, 3); lea(ebx, ebp - 0x8);                    /* lea ebx, [ebp-0x8] */
            ii(0x1007_c83e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_c840, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_c842, 5); calld(0x1007_64b8, -0x638f);            /* call 0x100764b8 */
            ii(0x1007_c847, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_c849, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_c84c, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_c84f, 5); calld(0x1008_a2b4, 0xda60);             /* call 0x1008a2b4 */
            ii(0x1007_c854, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_c856, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_c859, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1007_c85c, 5); calld(0x1013_ad71, 0xb_e510);           /* call 0x1013ad71 */
            ii(0x1007_c861, 2); test(al, al);                           /* test al, al */
            ii(0x1007_c863, 2); if(jzd(0x1007_c882, 0x1d)) goto l_0x1007_c882; /* jz 0x1007c882 */
            ii(0x1007_c865, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_c868, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1007_c86b, 5); calld(0x1008_af28, 0xe6b8);             /* call 0x1008af28 */
            ii(0x1007_c870, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_c873, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_c876, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1007_c879, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_c87c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_c87f, 3); calld_abs(memd_a32[ds, ebx + 0x38]);    /* call dword [ebx+0x38] */
        l_0x1007_c882:
            ii(0x1007_c882, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_c884, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_c887, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1007_c88a, 5); calld(0x1008_afe4, 0xe755);             /* call 0x1008afe4 */
            ii(0x1007_c88f, 2); jmpd(0x1007_c899, 0x8); goto l_0x1007_c899; /* jmp 0x1007c899 */
        l_0x1007_c891:
            ii(0x1007_c891, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1007_c894, 5); calld(0x1007_6bf8, -0x5ca1);            /* call 0x10076bf8 */
        l_0x1007_c899:
            ii(0x1007_c899, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_c89b, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1007_c89e, 5); calld(0x1013_ad71, 0xb_e4ce);           /* call 0x1013ad71 */
            ii(0x1007_c8a3, 2); test(al, al);                           /* test al, al */
            ii(0x1007_c8a5, 2); if(jzd(0x1007_c8c6, 0x1f)) goto l_0x1007_c8c6; /* jz 0x1007c8c6 */
            ii(0x1007_c8a7, 5); calld(0x1008_a79c, 0xdef0);             /* call 0x1008a79c */
            ii(0x1007_c8ac, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_c8ae, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1007_c8b0, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1007_c8b3, 5); calld(0x1007_63d4, -0x64e4);            /* call 0x100763d4 */
            ii(0x1007_c8b8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_c8ba, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_c8bf, 5); calld(0x100a_53ac, 0x2_8ae8);           /* call 0x100a53ac */
            ii(0x1007_c8c4, 2); jmpd(0x1007_c891, -0x35); goto l_0x1007_c891; /* jmp 0x1007c891 */
        l_0x1007_c8c6:
            ii(0x1007_c8c6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_c8c8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_c8cb, 3); add(eax, 0x29);                         /* add eax, 0x29 */
            ii(0x1007_c8ce, 5); calld(0x1007_6630, -0x62a3);            /* call 0x10076630 */
            ii(0x1007_c8d3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_c8d6, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x1007_c8d9, 5); calld(0x1013_a6f4, 0xb_de16);           /* call 0x1013a6f4 */
            ii(0x1007_c8de, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_c8e1, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_c8e6, 5); calld(0x100a_5e27, 0x2_953c);           /* call 0x100a5e27 */
            ii(0x1007_c8eb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_c8ed, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1007_c8f0, 5); calld(0x1007_5f6c, -0x6989);            /* call 0x10075f6c */
        l_0x1007_c8f5:
            ii(0x1007_c8f5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_c8f7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_c8f8, 1); popd(edi);                              /* pop edi */
            ii(0x1007_c8f9, 1); popd(esi);                              /* pop esi */
            ii(0x1007_c8fa, 1); popd(edx);                              /* pop edx */
            ii(0x1007_c8fb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_c8fc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_c8fd, 1); retd(); return;                         /* ret */
        }
    }
}
