using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("871ddbb9-c8d8-498b-8cb1-0eda3c16c753")]
        public void Method_100e_c7b5()
        {
            ii(0x100e_c7b5, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x100e_c7ba, 5); calld(Definitions.sys_check_available_stack_size, 0x7_9593); /* call 0x10165d52 */
            ii(0x100e_c7bf, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_c7c0, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_c7c1, 1); pushd(esi);                             /* push esi */
            ii(0x100e_c7c2, 1); pushd(edi);                             /* push edi */
            ii(0x100e_c7c3, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_c7c4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_c7c6, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100e_c7cc, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_c7cf, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_c7d2, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100e_c7d7, 5); calld(0x1007_6338, -0x7_64a4);          /* call 0x10076338 */
            ii(0x100e_c7dc, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x100e_c7df, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_c7e1, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_c7e3, 5); calld(0x1007_64b8, -0x7_6330);          /* call 0x100764b8 */
            ii(0x100e_c7e8, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100e_c7ef, 2); jmpd(0x100e_c7f9, 0x8); goto l_0x100e_c7f9; /* jmp 0x100ec7f9 */
        l_0x100e_c7f1:
            ii(0x100e_c7f1, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c7f4, 5); calld(0x1007_6bf8, -0x7_5c01);          /* call 0x10076bf8 */
        l_0x100e_c7f9:
            ii(0x100e_c7f9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_c7fb, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c7fe, 5); calld(0x1013_ad71, 0x4_e56e);           /* call 0x1013ad71 */
            ii(0x100e_c803, 2); test(al, al);                           /* test al, al */
            ii(0x100e_c805, 6); if(jzd(0x100e_c8b0, 0xa5)) goto l_0x100e_c8b0; /* jz 0x100ec8b0 */
            ii(0x100e_c80b, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c80e, 5); calld(0x1007_63a0, -0x7_6473);          /* call 0x100763a0 */
            ii(0x100e_c813, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_c815, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100e_c818, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_c81c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_c81e, 2); if(jnzd(0x100e_c82f, 0xf)) goto l_0x100e_c82f; /* jnz 0x100ec82f */
            ii(0x100e_c820, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c823, 5); calld(0x1007_63a0, -0x7_6488);          /* call 0x100763a0 */
            ii(0x100e_c828, 5); cmp(memw_a32[ds, eax + 0x8], 0x28);     /* cmp word [eax+0x8], 0x28 */
            ii(0x100e_c82d, 2); if(jzd(0x100e_c831, 0x2)) goto l_0x100e_c831; /* jz 0x100ec831 */
        l_0x100e_c82f:
            ii(0x100e_c82f, 2); jmpd(0x100e_c83f, 0xe); goto l_0x100e_c83f; /* jmp 0x100ec83f */
        l_0x100e_c831:
            ii(0x100e_c831, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c834, 5); calld(0x1007_63a0, -0x7_6499);          /* call 0x100763a0 */
            ii(0x100e_c839, 4); cmp(memb_a32[ds, eax + 0x3d], 0x7);     /* cmp byte [eax+0x3d], 0x7 */
            ii(0x100e_c83d, 2); if(jzd(0x100e_c844, 0x5)) goto l_0x100e_c844; /* jz 0x100ec844 */
        l_0x100e_c83f:
            ii(0x100e_c83f, 5); jmpd(0x100e_c8ab, 0x67); goto l_0x100e_c8ab; /* jmp 0x100ec8ab */
        l_0x100e_c844:
            ii(0x100e_c844, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_c847, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_c84a, 2); jmpd(0x100e_c884, 0x38); goto l_0x100e_c884; /* jmp 0x100ec884 */
        l_0x100e_c84c:
            ii(0x100e_c84c, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c84f, 5); calld(0x1007_63a0, -0x7_64b4);          /* call 0x100763a0 */
            ii(0x100e_c854, 3); mov(al, memb_a32[ds, eax + 0x47]);      /* mov al, [eax+0x47] */
            ii(0x100e_c857, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100e_c859, 3); add(memd_a32[ss, ebp - 0x10], eax);     /* add [ebp-0x10], eax */
            ii(0x100e_c85c, 2); jmpd(0x100e_c8ab, 0x4d); goto l_0x100e_c8ab; /* jmp 0x100ec8ab */
        l_0x100e_c85e:
            ii(0x100e_c85e, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c861, 5); calld(0x1007_63a0, -0x7_64c6);          /* call 0x100763a0 */
            ii(0x100e_c866, 3); mov(al, memb_a32[ds, eax + 0x48]);      /* mov al, [eax+0x48] */
            ii(0x100e_c869, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100e_c86b, 3); add(memd_a32[ss, ebp - 0x10], eax);     /* add [ebp-0x10], eax */
            ii(0x100e_c86e, 2); jmpd(0x100e_c8ab, 0x3b); goto l_0x100e_c8ab; /* jmp 0x100ec8ab */
        l_0x100e_c870:
            ii(0x100e_c870, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c873, 5); calld(0x1007_63a0, -0x7_64d8);          /* call 0x100763a0 */
            ii(0x100e_c878, 3); mov(al, memb_a32[ds, eax + 0x49]);      /* mov al, [eax+0x49] */
            ii(0x100e_c87b, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100e_c87d, 3); add(memd_a32[ss, ebp - 0x10], eax);     /* add [ebp-0x10], eax */
            ii(0x100e_c880, 2); jmpd(0x100e_c8ab, 0x29); goto l_0x100e_c8ab; /* jmp 0x100ec8ab */
        l_0x100e_c882:
            ii(0x100e_c882, 2); jmpd(0x100e_c8ab, 0x27); goto l_0x100e_c8ab; /* jmp 0x100ec8ab */
        l_0x100e_c884:
            ii(0x100e_c884, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_c887, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100e_c88a, 5); cmp(memw_a32[ss, ebp - 0x18], 0x40);    /* cmp word [ebp-0x18], 0x40 */
            ii(0x100e_c88f, 2); if(jbd(0x100e_c8a2, 0x11)) goto l_0x100e_c8a2; /* jb 0x100ec8a2 */
            ii(0x100e_c891, 5); cmp(memw_a32[ss, ebp - 0x18], 0x40);    /* cmp word [ebp-0x18], 0x40 */
            ii(0x100e_c896, 2); if(jbed(0x100e_c870, -0x28)) goto l_0x100e_c870; /* jbe 0x100ec870 */
            ii(0x100e_c898, 6); cmp(memw_a32[ss, ebp - 0x18], 0x80);    /* cmp word [ebp-0x18], 0x80 */
            ii(0x100e_c89e, 2); if(jzd(0x100e_c84c, -0x54)) goto l_0x100e_c84c; /* jz 0x100ec84c */
            ii(0x100e_c8a0, 2); jmpd(0x100e_c882, -0x20); goto l_0x100e_c882; /* jmp 0x100ec882 */
        l_0x100e_c8a2:
            ii(0x100e_c8a2, 5); cmp(memw_a32[ss, ebp - 0x18], 0x20);    /* cmp word [ebp-0x18], 0x20 */
            ii(0x100e_c8a7, 2); if(jzd(0x100e_c85e, -0x4b)) goto l_0x100e_c85e; /* jz 0x100ec85e */
            ii(0x100e_c8a9, 2); jmpd(0x100e_c882, -0x29); goto l_0x100e_c882; /* jmp 0x100ec882 */
        l_0x100e_c8ab:
            ii(0x100e_c8ab, 5); jmpd(0x100e_c7f1, -0xbf); goto l_0x100e_c7f1; /* jmp 0x100ec7f1 */
        l_0x100e_c8b0:
            ii(0x100e_c8b0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_c8b3, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100e_c8b6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_c8b8, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_c8bb, 5); calld(0x1007_5f6c, -0x7_6954);          /* call 0x10075f6c */
            ii(0x100e_c8c0, 2); jmpd(0x100e_c8cc, 0xa); goto l_0x100e_c8cc; /* jmp 0x100ec8cc */
        //    ii(0x100e_c8c2, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x100e_c8c4, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
        //    ii(0x100e_c8c7, 5); calld(0x1007_5f6c, -0x7_6960);          /* call 0x10075f6c */
        l_0x100e_c8cc:
            ii(0x100e_c8cc, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_c8cf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_c8d1, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_c8d2, 1); popd(edi);                              /* pop edi */
            ii(0x100e_c8d3, 1); popd(esi);                              /* pop esi */
            ii(0x100e_c8d4, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_c8d5, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_c8d6, 1); retd(); return;                         /* ret */
        }
    }
}
