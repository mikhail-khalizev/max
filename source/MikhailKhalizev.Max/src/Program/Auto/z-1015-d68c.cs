using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("84ac6221-0268-40f8-9f65-3c9bd595c208")]
        public void Method_1015_d68c()
        {
            ii(0x1015_d68c, 5); pushd(0x60);                            /* push 0x60 */
            ii(0x1015_d691, 5); calld(Definitions.sys_check_available_stack_size, 0x86bc); /* call 0x10165d52 */
            ii(0x1015_d696, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_d697, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_d698, 1); pushd(esi);                             /* push esi */
            ii(0x1015_d699, 1); pushd(edi);                             /* push edi */
            ii(0x1015_d69a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_d69b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_d69d, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1015_d6a3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_d6a6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_d6a9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d6ac, 4); cmp(memb_a32[ds, eax + 0x50], 0);       /* cmp byte [eax+0x50], 0x0 */
            ii(0x1015_d6b0, 2); if(jzd(0x1015_d6bb, 0x9)) goto l_0x1015_d6bb; /* jz 0x1015d6bb */
            ii(0x1015_d6b2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d6b5, 4); cmp(memb_a32[ds, eax + 0x59], 0);       /* cmp byte [eax+0x59], 0x0 */
            ii(0x1015_d6b9, 2); if(jzd(0x1015_d6bd, 0x2)) goto l_0x1015_d6bd; /* jz 0x1015d6bd */
        l_0x1015_d6bb:
            ii(0x1015_d6bb, 2); jmpd(0x1015_d6e9, 0x2c); goto l_0x1015_d6e9; /* jmp 0x1015d6e9 */
        l_0x1015_d6bd:
            ii(0x1015_d6bd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d6c0, 5); calld(0x1007_623c, -0xe_7489);          /* call 0x1007623c */
            ii(0x1015_d6c5, 3); mov(ecx, memd_a32[ds, eax + 0x10]);     /* mov ecx, [eax+0x10] */
            ii(0x1015_d6c8, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1015_d6cb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_d6ce, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x1015_d6d1, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_d6d4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_d6d7, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1015_d6da, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_d6dd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d6e0, 5); calld(0x1007_0d68, -0xe_c97d);          /* call 0x10070d68 */
            ii(0x1015_d6e5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_d6e7, 2); if(jnzd(0x1015_d6eb, 0x2)) goto l_0x1015_d6eb; /* jnz 0x1015d6eb */
        l_0x1015_d6e9:
            ii(0x1015_d6e9, 2); jmpd(0x1015_d6fa, 0xf); goto l_0x1015_d6fa; /* jmp 0x1015d6fa */
        l_0x1015_d6eb:
            ii(0x1015_d6eb, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_d6ee, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d6f1, 5); calld(0x1007_4bde, -0xe_8b18);          /* call 0x10074bde */
            ii(0x1015_d6f6, 2); test(al, al);                           /* test al, al */
            ii(0x1015_d6f8, 2); if(jnzd(0x1015_d6fc, 0x2)) goto l_0x1015_d6fc; /* jnz 0x1015d6fc */
        l_0x1015_d6fa:
            ii(0x1015_d6fa, 2); jmpd(0x1015_d70b, 0xf); goto l_0x1015_d70b; /* jmp 0x1015d70b */
        l_0x1015_d6fc:
            ii(0x1015_d6fc, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_d6ff, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d702, 5); calld(0x1015_d2ce, -0x439);             /* call 0x1015d2ce */
            ii(0x1015_d707, 2); test(al, al);                           /* test al, al */
            ii(0x1015_d709, 2); if(jnzd(0x1015_d710, 0x5)) goto l_0x1015_d710; /* jnz 0x1015d710 */
        l_0x1015_d70b:
            ii(0x1015_d70b, 5); jmpd(0x1015_d86a, 0x15a); goto l_0x1015_d86a; /* jmp 0x1015d86a */
        l_0x1015_d710:
            ii(0x1015_d710, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_d713, 4); mov(dx, memw_a32[ds, eax + 0x1a]);      /* mov dx, [eax+0x1a] */
            ii(0x1015_d717, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d71a, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x1015_d71e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_d721, 4); mov(dx, memw_a32[ds, eax + 0x1c]);      /* mov dx, [eax+0x1c] */
            ii(0x1015_d725, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d728, 4); mov(memw_a32[ds, eax + 0x43], dx);      /* mov [eax+0x43], dx */
            ii(0x1015_d72c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d72f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_d731, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1015_d734, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_d736, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1015_d73b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_d73d, 6); if(jnzd(0x1015_d804, 0xc1)) goto l_0x1015_d804; /* jnz 0x1015d804 */
            ii(0x1015_d743, 3); lea(edi, ebp - 0x18);                   /* lea edi, [ebp-0x18] */
            ii(0x1015_d746, 5); mov(esi, 0x101b_dd78);                  /* mov esi, 0x101bdd78 */
            ii(0x1015_d74b, 1); movsd_a32();                            /* movsd */
            ii(0x1015_d74c, 1); movsd_a32();                            /* movsd */
            ii(0x1015_d74d, 1); movsd_a32();                            /* movsd */
            ii(0x1015_d74e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_d751, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1015_d754, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_d757, 3); imul(edx, eax, 0x33);                   /* imul edx, eax, 0x33 */
            ii(0x1015_d75a, 5); mov(eax, 0x101c_81c0);                  /* mov eax, 0x101c81c0 */
            ii(0x1015_d75f, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1015_d761, 3); mov(memd_a32[ss, ebp - 0x1c], edx);     /* mov [ebp-0x1c], edx */
            ii(0x1015_d764, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1015_d767, 3); mov(ebx, memd_a32[ds, ebx + 0x1a]);     /* mov ebx, [ebx+0x1a] */
            ii(0x1015_d76a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_d76d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1015_d770, 3); mov(edx, memd_a32[ds, edx + 0x18]);     /* mov edx, [edx+0x18] */
            ii(0x1015_d773, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_d776, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_d779, 5); calld(0x1007_6aac, -0xe_6cd2);          /* call 0x10076aac */
            ii(0x1015_d77e, 2); mov(ecx, memd_a32[ds, eax]);            /* mov ecx, [eax] */
            ii(0x1015_d780, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1015_d783, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_d785, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_d788, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1015_d78b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_d78e, 1); inc(eax);                               /* inc eax */
            ii(0x1015_d78f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_d790, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_d793, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1015_d796, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_d799, 1); inc(eax);                               /* inc eax */
            ii(0x1015_d79a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_d79b, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1015_d79e, 3); pushd(memd_a32[ds, eax + 0x17]);        /* push dword [eax+0x17] */
            ii(0x1015_d7a1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d7a4, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1015_d7a7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_d7aa, 1); inc(eax);                               /* inc eax */
            ii(0x1015_d7ab, 1); pushd(eax);                             /* push eax */
            ii(0x1015_d7ac, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d7af, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1015_d7b2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_d7b5, 1); inc(eax);                               /* inc eax */
            ii(0x1015_d7b6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_d7b7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d7ba, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1015_d7bd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_d7c0, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1015_d7c3, 6); pushd(memd_a32[ds, eax + 0x101c_81d7]); /* push dword [eax+0x101c81d7] */
            ii(0x1015_d7c9, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1015_d7cc, 3); mov(eax, memd_a32[ds, eax + 0x13]);     /* mov eax, [eax+0x13] */
            ii(0x1015_d7cf, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1015_d7d2, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1015_d7d5, 4); pushd(memd_a32[ds, eax + ebp - 0x18]);  /* push dword [eax+ebp-0x18] */
            ii(0x1015_d7d9, 5); mov(eax, 0x96);                         /* mov eax, 0x96 */
            ii(0x1015_d7de, 1); pushd(eax);                             /* push eax */
            ii(0x1015_d7df, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_d7e2, 5); calld(Definitions.my_string_ctor, -0x1_bcff); /* call 0x10141ae8 */
            ii(0x1015_d7e7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_d7e8, 5); calld(0x1014_2037, -0x1_b7b6);          /* call 0x10142037 */
            ii(0x1015_d7ed, 3); add(esp, 0x24);                         /* add esp, 0x24 */
            ii(0x1015_d7f0, 5); calld(Definitions.my_strobj_c_str_v2, -0xd_402d); /* call 0x100897c8 */
            ii(0x1015_d7f5, 5); calld(0x1011_5b60, -0x4_7c9a);          /* call 0x10115b60 */
            ii(0x1015_d7fa, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_d7fc, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_d7ff, 5); calld(Definitions.my_string_dtor, -0x1_bcda); /* call 0x10141b2a */
        l_0x1015_d804:
            ii(0x1015_d804, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_d806, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x1015_d80b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d80e, 5); calld(0x1016_3053, 0x5840);             /* call 0x10163053 */
            ii(0x1015_d813, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d816, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_d818, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1015_d81b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_d81d, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1015_d822, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_d824, 2); if(jnzd(0x1015_d837, 0x11)) goto l_0x1015_d837; /* jnz 0x1015d837 */
            ii(0x1015_d826, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_d82b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d82e, 5); calld(0x1008_b4b4, -0xd_237f);          /* call 0x1008b4b4 */
            ii(0x1015_d833, 2); test(al, al);                           /* test al, al */
            ii(0x1015_d835, 2); if(jnzd(0x1015_d839, 0x2)) goto l_0x1015_d839; /* jnz 0x1015d839 */
        l_0x1015_d837:
            ii(0x1015_d837, 2); jmpd(0x1015_d846, 0xd); goto l_0x1015_d846; /* jmp 0x1015d846 */
        l_0x1015_d839:
            ii(0x1015_d839, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d83c, 5); calld(0x1010_1103, -0x5_c73e);          /* call 0x10101103 */
            ii(0x1015_d841, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1015_d844, 2); if(jzd(0x1015_d848, 0x2)) goto l_0x1015_d848; /* jz 0x1015d848 */
        l_0x1015_d846:
            ii(0x1015_d846, 2); jmpd(0x1015_d864, 0x1c); goto l_0x1015_d864; /* jmp 0x1015d864 */
        l_0x1015_d848:
            ii(0x1015_d848, 5); calld(0x100d_5470, -0x8_83dd);          /* call 0x100d5470 */
            ii(0x1015_d84d, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1015_d850, 5); mov(ebx, 0x409);                        /* mov ebx, 0x409 */
            ii(0x1015_d855, 5); mov(edx, 0x406);                        /* mov edx, 0x406 */
            ii(0x1015_d85a, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1015_d85f, 5); calld(0x1013_daea, -0x1_fd7a);          /* call 0x1013daea */
        l_0x1015_d864:
            ii(0x1015_d864, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_d868, 2); jmpd(0x1015_d86e, 0x4); goto l_0x1015_d86e; /* jmp 0x1015d86e */
        l_0x1015_d86a:
            ii(0x1015_d86a, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1015_d86e:
            ii(0x1015_d86e, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1015_d871, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_d873, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_d874, 1); popd(edi);                              /* pop edi */
            ii(0x1015_d875, 1); popd(esi);                              /* pop esi */
            ii(0x1015_d876, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_d877, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_d878, 1); retd(); return;                         /* ret */
        }
    }
}
