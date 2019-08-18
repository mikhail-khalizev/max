using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2dccad04-0654-45ef-a50b-bfab965fe6e1")]
        public void Method_1011_e50b()
        {
            ii(0x1011_e50b, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1011_e510, 5); calld(Definitions.sys_check_available_stack_size, 0x4_783d); /* call 0x10165d52 */
            ii(0x1011_e515, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_e516, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_e517, 1); pushd(esi);                             /* push esi */
            ii(0x1011_e518, 1); pushd(edi);                             /* push edi */
            ii(0x1011_e519, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_e51a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_e51c, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1011_e522, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_e525, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_e528, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_e52b, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1011_e52e, 5); calld(0x1012_0894, 0x2361);             /* call 0x10120894 */
            ii(0x1011_e533, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x1011_e536, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_e538, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1011_e53a, 5); calld(0x1012_0748, 0x2209);             /* call 0x10120748 */
            ii(0x1011_e53f, 2); jmpd(0x1011_e549, 0x8); goto l_0x1011_e549; /* jmp 0x1011e549 */
        l_0x1011_e541:
            ii(0x1011_e541, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1011_e544, 5); calld(0x1007_6bf8, -0xa_7951);          /* call 0x10076bf8 */
        l_0x1011_e549:
            ii(0x1011_e549, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e54b, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1011_e54e, 5); calld(0x1013_ad71, 0x1_c81e);           /* call 0x1013ad71 */
            ii(0x1011_e553, 2); test(al, al);                           /* test al, al */
            ii(0x1011_e555, 2); if(jzd(0x1011_e597, 0x40)) goto l_0x1011_e597; /* jz 0x1011e597 */
            ii(0x1011_e557, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1011_e55a, 5); calld(0x1012_066c, 0x210d);             /* call 0x1012066c */
            ii(0x1011_e55f, 5); calld(Definitions.my__get_unit, -0x6_6548); /* call 0x100b801c */
            ii(0x1011_e564, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1011_e567, 2); if(jnzd(0x1011_e595, 0x2c)) goto l_0x1011_e595; /* jnz 0x1011e595 */
            ii(0x1011_e569, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1011_e56c, 5); calld(0x1012_066c, 0x20fb);             /* call 0x1012066c */
            ii(0x1011_e571, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_e574, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_e577, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1011_e57a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_e57d, 3); calld_abs(memd_a32[ds, edx + 0x8]);     /* call dword [edx+0x8] */
            ii(0x1011_e580, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1011_e583, 5); calld(0x1012_06d4, 0x214c);             /* call 0x101206d4 */
            ii(0x1011_e588, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_e58a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_e58d, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1011_e590, 5); calld(0x1012_0804, 0x226f);             /* call 0x10120804 */
        l_0x1011_e595:
            ii(0x1011_e595, 2); jmpd(0x1011_e541, -0x56); goto l_0x1011_e541; /* jmp 0x1011e541 */
        l_0x1011_e597:
            ii(0x1011_e597, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e599, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_e59c, 5); calld(0x1013_ad71, 0x1_c7d0);           /* call 0x1013ad71 */
            ii(0x1011_e5a1, 2); test(al, al);                           /* test al, al */
            ii(0x1011_e5a3, 2); if(jzd(0x1011_e5b7, 0x12)) goto l_0x1011_e5b7; /* jz 0x1011e5b7 */
            ii(0x1011_e5a5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_e5a8, 5); calld(0x100b_7f18, -0x6_6695);          /* call 0x100b7f18 */
            ii(0x1011_e5ad, 5); calld(Definitions.my__get_unit, -0x6_6596); /* call 0x100b801c */
            ii(0x1011_e5b2, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1011_e5b5, 2); if(jzd(0x1011_e5b9, 0x2)) goto l_0x1011_e5b9; /* jz 0x1011e5b9 */
        l_0x1011_e5b7:
            ii(0x1011_e5b7, 2); jmpd(0x1011_e5cd, 0x14); goto l_0x1011_e5cd; /* jmp 0x1011e5cd */
        l_0x1011_e5b9:
            ii(0x1011_e5b9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_e5bc, 5); calld(0x100b_7f74, -0x6_664d);          /* call 0x100b7f74 */
            ii(0x1011_e5c1, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_e5c4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_e5c6, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1011_e5c8, 5); calld(0x1011_e41a, -0x1b3);             /* call 0x1011e41a */
        l_0x1011_e5cd:
            ii(0x1011_e5cd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_e5cf, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1011_e5d2, 5); calld(0x1012_0464, 0x1e8d);             /* call 0x10120464 */
            ii(0x1011_e5d7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_e5d9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_e5da, 1); popd(edi);                              /* pop edi */
            ii(0x1011_e5db, 1); popd(esi);                              /* pop esi */
            ii(0x1011_e5dc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_e5dd, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_e5de, 1); retd(); return;                         /* ret */
        }
    }
}
