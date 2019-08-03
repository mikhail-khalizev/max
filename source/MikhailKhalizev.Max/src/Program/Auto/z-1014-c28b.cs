using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ee0c1534-eae6-442c-bda4-8f7cd3ccccc3")]
        public void Method_1014_c28b()
        {
            ii(0x1014_c28b, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1014_c290, 5); calld(Definitions.sys_check_available_stack_size, 0x19abd); /* call 0x10165d52 */
            ii(0x1014_c295, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_c296, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_c297, 1); pushd(edx);                             /* push edx */
            ii(0x1014_c298, 1); pushd(esi);                             /* push esi */
            ii(0x1014_c299, 1); pushd(edi);                             /* push edi */
            ii(0x1014_c29a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_c29b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_c29d, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1014_c2a3, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_c2a6, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_c2a9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c2ac, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_c2af, 5); calld(0x1007_6884, -0xd5a30);           /* call 0x10076884 */
            ii(0x1014_c2b4, 5); calld(0x1016_4285, 0x17fcc);            /* call 0x10164285 */
            ii(0x1014_c2b9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_c2bb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c2be, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_c2c1, 5); calld(0x100a_b2a8, -0xa101e);           /* call 0x100ab2a8 */
            ii(0x1014_c2c6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c2c9, 5); calld(0x1014_c0bb, -0x213);             /* call 0x1014c0bb */
            ii(0x1014_c2ce, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_c2d1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c2d4, 4); or(memb_a32[ds, eax + 0x6a], 0x4);      /* or byte [eax+0x6a], 0x4 */
            ii(0x1014_c2d8, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_c2dc, 6); if(jzd(0x1014_c394, 0xb2)) goto l_0x1014_c394; /* jz 0x1014c394 */
            ii(0x1014_c2e2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_c2e5, 5); calld(0x1007_6204, -0xd60e6);           /* call 0x10076204 */
            ii(0x1014_c2ea, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x1014_c2ed, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_c2ef, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_c2f1, 5); calld(0x1007_6954, -0xd59a2);           /* call 0x10076954 */
            ii(0x1014_c2f6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_c2f9, 5); calld(0x1014_bf44, -0x3ba);             /* call 0x1014bf44 */
        l_0x1014_c2fe:
            ii(0x1014_c2fe, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c301, 5); calld(0x1014_c0bb, -0x24b);             /* call 0x1014c0bb */
            ii(0x1014_c306, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_c309, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_c30d, 2); if(jzd(0x1014_c377, 0x68)) goto l_0x1014_c377; /* jz 0x1014c377 */
            ii(0x1014_c30f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c312, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1014_c315, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_c317, 1); cwde();                                 /* cwde */
            ii(0x1014_c318, 5); calld(0x1014_892b, -0x39f2);            /* call 0x1014892b */
            ii(0x1014_c31d, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x1014_c320, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_c322, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_c324, 5); calld(0x1007_6954, -0xd59d5);           /* call 0x10076954 */
            ii(0x1014_c329, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x1014_c32c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c32f, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_c332, 5); calld(0x1015_5344, 0x900d);             /* call 0x10155344 */
            ii(0x1014_c337, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_c33a, 5); calld(0x1014_bf44, -0x3fb);             /* call 0x1014bf44 */
            ii(0x1014_c33f, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_c342, 5); calld(0x1007_68e0, -0xd5a67);           /* call 0x100768e0 */
            ii(0x1014_c347, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1014_c34a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_c34c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_c34e, 5); calld(0x1014_b9c9, -0x98a);             /* call 0x1014b9c9 */
            ii(0x1014_c353, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_c356, 5); calld(0x1007_68e0, -0xd5a7b);           /* call 0x100768e0 */
            ii(0x1014_c35b, 5); calld(0x1007_35ac, -0xd8db4);           /* call 0x100735ac */
            ii(0x1014_c360, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_c362, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c365, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_c368, 5); calld(0x100a_b2a8, -0xa10c5);           /* call 0x100ab2a8 */
            ii(0x1014_c36d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_c36f, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_c372, 5); calld(0x1007_5eac, -0xd64cb);           /* call 0x10075eac */
        l_0x1014_c377:
            ii(0x1014_c377, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_c37b, 2); if(jnzd(0x1014_c2fe, -0x7f)) goto l_0x1014_c2fe; /* jnz 0x1014c2fe */
            ii(0x1014_c37d, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_c380, 5); calld(0x1007_68e0, -0xd5aa5);           /* call 0x100768e0 */
            ii(0x1014_c385, 5); calld(0x1007_35ac, -0xd8dde);           /* call 0x100735ac */
            ii(0x1014_c38a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_c38c, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_c38f, 5); calld(0x1007_5eac, -0xd64e8);           /* call 0x10075eac */
        l_0x1014_c394:
            ii(0x1014_c394, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1014_c399, 5); calld(0x1007_6338, -0xd6066);           /* call 0x10076338 */
            ii(0x1014_c39e, 3); lea(ebx, ebp - 0x8);                    /* lea ebx, [ebp-0x8] */
            ii(0x1014_c3a1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_c3a3, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_c3a5, 5); calld(0x1007_64b8, -0xd5ef2);           /* call 0x100764b8 */
        l_0x1014_c3aa:
            ii(0x1014_c3aa, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_c3ac, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_c3af, 5); calld(0x1013_ad71, -0x11643);           /* call 0x1013ad71 */
            ii(0x1014_c3b4, 2); test(al, al);                           /* test al, al */
            ii(0x1014_c3b6, 2); if(jzd(0x1014_c3ce, 0x16)) goto l_0x1014_c3ce; /* jz 0x1014c3ce */
            ii(0x1014_c3b8, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_c3bb, 5); calld(0x1007_63a0, -0xd6020);           /* call 0x100763a0 */
            ii(0x1014_c3c0, 4); and(memb_a32[ds, eax + 0x6a], -0x5 /* 0xfb */); /* and byte [eax+0x6a], 0xfb */
            ii(0x1014_c3c4, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_c3c7, 5); calld(0x1007_6bf8, -0xd57d4);           /* call 0x10076bf8 */
            ii(0x1014_c3cc, 2); jmpd(0x1014_c3aa, -0x24); goto l_0x1014_c3aa; /* jmp 0x1014c3aa */
        l_0x1014_c3ce:
            ii(0x1014_c3ce, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_c3d0, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_c3d3, 5); calld(0x1007_5f6c, -0xd646c);           /* call 0x10075f6c */
            ii(0x1014_c3d8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_c3da, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_c3db, 1); popd(edi);                              /* pop edi */
            ii(0x1014_c3dc, 1); popd(esi);                              /* pop esi */
            ii(0x1014_c3dd, 1); popd(edx);                              /* pop edx */
            ii(0x1014_c3de, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_c3df, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_c3e0, 1); retd(); return;                         /* ret */
        }
    }
}