using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c755223a-cdf5-49f3-b95d-d8bb6ef9a086")]
        public void Method_1014_710b()
        {
            ii(0x1014_710b, 5); pushd(0x48);                            /* push 0x48 */
            ii(0x1014_7110, 5); calld(Definitions.sys_check_available_stack_size, 0x1_ec3d); /* call 0x10165d52 */
            ii(0x1014_7115, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_7116, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_7117, 1); pushd(esi);                             /* push esi */
            ii(0x1014_7118, 1); pushd(edi);                             /* push edi */
            ii(0x1014_7119, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_711a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_711c, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1014_7122, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_7125, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_7128, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1014_712c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_712f, 5); calld(Definitions.my_string_ctor, -0x564c); /* call 0x10141ae8 */
            ii(0x1014_7134, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_7137, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1014_713b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_713e, 5); calld(0x1014_68e2, -0x861);             /* call 0x101468e2 */
            ii(0x1014_7143, 2); test(al, al);                           /* test al, al */
            ii(0x1014_7145, 2); if(jnzd(0x1014_7160, 0x19)) goto l_0x1014_7160; /* jnz 0x10147160 */
            ii(0x1014_7147, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_7149, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_714c, 5); calld(0x1014_7f44, 0xdf3);              /* call 0x10147f44 */
            ii(0x1014_7151, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_7153, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_7156, 5); calld(Definitions.my_string_dtor, -0x5631); /* call 0x10141b2a */
            ii(0x1014_715b, 5); jmpd(0x1014_72e7, 0x187); goto l_0x1014_72e7; /* jmp 0x101472e7 */
        l_0x1014_7160:
            ii(0x1014_7160, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7163, 4); cmp(memd_a32[ds, eax + 0x1c], 0x7d);    /* cmp dword [eax+0x1c], 0x7d */
            ii(0x1014_7167, 2); if(jzd(0x1014_7172, 0x9)) goto l_0x1014_7172; /* jz 0x10147172 */
            ii(0x1014_7169, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_716c, 4); cmp(memd_a32[ds, eax + 0x1c], 0x3e);    /* cmp dword [eax+0x1c], 0x3e */
            ii(0x1014_7170, 2); if(jnzd(0x1014_718b, 0x19)) goto l_0x1014_718b; /* jnz 0x1014718b */
        l_0x1014_7172:
            ii(0x1014_7172, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_7174, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_7177, 5); calld(0x1014_7f44, 0xdc8);              /* call 0x10147f44 */
            ii(0x1014_717c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_717e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_7181, 5); calld(Definitions.my_string_dtor, -0x565c); /* call 0x10141b2a */
            ii(0x1014_7186, 5); jmpd(0x1014_72e7, 0x15c); goto l_0x1014_72e7; /* jmp 0x101472e7 */
        l_0x1014_718b:
            ii(0x1014_718b, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x1014_718e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7191, 5); calld(0x1014_6b38, -0x65e);             /* call 0x10146b38 */
            ii(0x1014_7196, 2); test(al, al);                           /* test al, al */
            ii(0x1014_7198, 2); if(jnzd(0x1014_71b3, 0x19)) goto l_0x1014_71b3; /* jnz 0x101471b3 */
            ii(0x1014_719a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_719c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_719f, 5); calld(0x1014_7f44, 0xda0);              /* call 0x10147f44 */
            ii(0x1014_71a4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_71a6, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_71a9, 5); calld(Definitions.my_string_dtor, -0x5684); /* call 0x10141b2a */
            ii(0x1014_71ae, 5); jmpd(0x1014_72e7, 0x134); goto l_0x1014_72e7; /* jmp 0x101472e7 */
        l_0x1014_71b3:
            ii(0x1014_71b3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_71b6, 5); calld(0x1014_68e2, -0x8d9);             /* call 0x101468e2 */
            ii(0x1014_71bb, 2); test(al, al);                           /* test al, al */
            ii(0x1014_71bd, 2); if(jnzd(0x1014_71d8, 0x19)) goto l_0x1014_71d8; /* jnz 0x101471d8 */
            ii(0x1014_71bf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_71c1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_71c4, 5); calld(0x1014_7f44, 0xd7b);              /* call 0x10147f44 */
            ii(0x1014_71c9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_71cb, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_71ce, 5); calld(Definitions.my_string_dtor, -0x56a9); /* call 0x10141b2a */
            ii(0x1014_71d3, 5); jmpd(0x1014_72e7, 0x10f); goto l_0x1014_72e7; /* jmp 0x101472e7 */
        l_0x1014_71d8:
            ii(0x1014_71d8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_71db, 3); mov(eax, memd_a32[ds, eax + 0x1c]);     /* mov eax, [eax+0x1c] */
            ii(0x1014_71de, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1014_71e1, 5); jmpd(0x1014_7295, 0xaf); goto l_0x1014_7295; /* jmp 0x10147295 */
        l_0x1014_71e6:
            ii(0x1014_71e6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_71e9, 5); calld(0x1014_6722, -0xacc);             /* call 0x10146722 */
            ii(0x1014_71ee, 5); mov(eax, 0x28);                         /* mov eax, 0x28 */
            ii(0x1014_71f3, 5); calld(Definitions.sys_new, 0x1_ec08);   /* call 0x10165e00 */
            ii(0x1014_71f8, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1014_71fb, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1014_71fe, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1014_7201, 4); cmp(memd_a32[ss, ebp - 0x20], 0);       /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1014_7205, 2); if(jzd(0x1014_722c, 0x25)) goto l_0x1014_722c; /* jz 0x1014722c */
            ii(0x1014_7207, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_720a, 1); pushd(eax);                             /* push eax */
            ii(0x1014_720b, 5); mov(ecx, 0x7d);                         /* mov ecx, 0x7d */
            ii(0x1014_7210, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_7213, 3); add(ebx, 0x12);                         /* add ebx, 0x12 */
            ii(0x1014_7216, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x1014_7219, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1014_721c, 5); calld(0x1014_5a6b, -0x17b6);            /* call 0x10145a6b */
            ii(0x1014_7221, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1014_7224, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1014_7227, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1014_722a, 2); jmpd(0x1014_7232, 0x6); goto l_0x1014_7232; /* jmp 0x10147232 */
        l_0x1014_722c:
            ii(0x1014_722c, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1014_722f, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x1014_7232:
            ii(0x1014_7232, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x1014_7235, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_7238, 5); calld(0x1014_7f44, 0xd07);              /* call 0x10147f44 */
            ii(0x1014_723d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_723f, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_7242, 5); calld(Definitions.my_string_dtor, -0x571d); /* call 0x10141b2a */
            ii(0x1014_7247, 5); jmpd(0x1014_72e7, 0x9b); goto l_0x1014_72e7; /* jmp 0x101472e7 */
        l_0x1014_724c:
            ii(0x1014_724c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_724f, 5); calld(0x1014_6722, -0xb32);             /* call 0x10146722 */
            ii(0x1014_7254, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x1014_7257, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_725a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_725d, 5); calld(0x1014_6bd7, -0x68b);             /* call 0x10146bd7 */
            ii(0x1014_7262, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_7264, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_7267, 5); calld(Definitions.my_string_dtor, -0x5742); /* call 0x10141b2a */
            ii(0x1014_726c, 5); jmpd(0x1014_72e7, 0x76); goto l_0x1014_72e7; /* jmp 0x101472e7 */
        l_0x1014_7271:
            ii(0x1014_7271, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7274, 5); calld(0x1014_6722, -0xb57);             /* call 0x10146722 */
            ii(0x1014_7279, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x1014_727c, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_727f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7282, 5); calld(0x1014_6ead, -0x3da);             /* call 0x10146ead */
            ii(0x1014_7287, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_7289, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_728c, 5); calld(Definitions.my_string_dtor, -0x5767); /* call 0x10141b2a */
            ii(0x1014_7291, 2); jmpd(0x1014_72e7, 0x54); goto l_0x1014_72e7; /* jmp 0x101472e7 */
        l_0x1014_7293:
            ii(0x1014_7293, 2); jmpd(0x1014_72b5, 0x20); goto l_0x1014_72b5; /* jmp 0x101472b5 */
        l_0x1014_7295:
            ii(0x1014_7295, 4); cmp(memd_a32[ss, ebp - 0x18], 0x3d);    /* cmp dword [ebp-0x18], 0x3d */
            ii(0x1014_7299, 2); if(jbd(0x1014_72ad, 0x12)) goto l_0x1014_72ad; /* jb 0x101472ad */
            ii(0x1014_729b, 4); cmp(memd_a32[ss, ebp - 0x18], 0x3d);    /* cmp dword [ebp-0x18], 0x3d */
            ii(0x1014_729f, 2); if(jbed(0x1014_724c, -0x55)) goto l_0x1014_724c; /* jbe 0x1014724c */
            ii(0x1014_72a1, 4); cmp(memd_a32[ss, ebp - 0x18], 0x7b);    /* cmp dword [ebp-0x18], 0x7b */
            ii(0x1014_72a5, 6); if(jzd(0x1014_71e6, -0xc5)) goto l_0x1014_71e6; /* jz 0x101471e6 */
            ii(0x1014_72ab, 2); jmpd(0x1014_7293, -0x1a); goto l_0x1014_7293; /* jmp 0x10147293 */
        l_0x1014_72ad:
            ii(0x1014_72ad, 4); cmp(memd_a32[ss, ebp - 0x18], 0x3c);    /* cmp dword [ebp-0x18], 0x3c */
            ii(0x1014_72b1, 2); if(jzd(0x1014_7271, -0x42)) goto l_0x1014_7271; /* jz 0x10147271 */
            ii(0x1014_72b3, 2); jmpd(0x1014_7293, -0x22); goto l_0x1014_7293; /* jmp 0x10147293 */
        l_0x1014_72b5:
            ii(0x1014_72b5, 5); mov(eax, StringDefinitions.ExpectingOrLess); /* mov eax, 0x101ad103 */
            ii(0x1014_72ba, 1); pushd(eax);                             /* push eax */
            ii(0x1014_72bb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_72be, 1); pushd(eax);                             /* push eax */
            ii(0x1014_72bf, 5); calld(0x1014_69b5, -0x90f);             /* call 0x101469b5 */
            ii(0x1014_72c4, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1014_72c7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_72c9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_72cc, 5); calld(0x1014_7f44, 0xc73);              /* call 0x10147f44 */
            ii(0x1014_72d1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_72d3, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_72d6, 5); calld(Definitions.my_string_dtor, -0x57b1); /* call 0x10141b2a */
            ii(0x1014_72db, 2); jmpd(0x1014_72e7, 0xa); goto l_0x1014_72e7; /* jmp 0x101472e7 */
        //    ii(0x1014_72dd, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1014_72df, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
        //    ii(0x1014_72e2, 5); calld(Definitions.my_string_dtor, -0x57bd); /* call 0x10141b2a */
        l_0x1014_72e7:
            ii(0x1014_72e7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_72ea, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_72ec, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_72ed, 1); popd(edi);                              /* pop edi */
            ii(0x1014_72ee, 1); popd(esi);                              /* pop esi */
            ii(0x1014_72ef, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_72f0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_72f1, 1); retd(); return;                         /* ret */
        }
    }
}
