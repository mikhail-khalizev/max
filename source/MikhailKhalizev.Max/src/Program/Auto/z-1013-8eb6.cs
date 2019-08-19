using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_8eb6-d203cbe5")]
        public void Method_1013_8eb6()
        {
            ii(0x1013_8eb6, 5); pushd(0x1d0);                           /* push 0x1d0 */
            ii(0x1013_8ebb, 5); calld(Definitions.sys_check_available_stack_size, 0x2_ce92); /* call 0x10165d52 */
            ii(0x1013_8ec0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_8ec1, 1); pushd(esi);                             /* push esi */
            ii(0x1013_8ec2, 1); pushd(edi);                             /* push edi */
            ii(0x1013_8ec3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_8ec4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_8ec6, 6); sub(esp, 0x1ac);                        /* sub esp, 0x1ac */
            ii(0x1013_8ecc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_8ecf, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1013_8ed2, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1013_8ed5, 4); or(memb_a32[ss, ebp - 0x14], 0x1);      /* or byte [ebp-0x14], 0x1 */
            ii(0x1013_8ed9, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_8edc, 5); calld(0x1013_b8e1, 0x2a00);             /* call 0x1013b8e1 */
            ii(0x1013_8ee1, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1013_8ee4, 4); and(memb_a32[ss, ebp - 0x14], -0x2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x1013_8ee8, 7); mov(memd_a32[ss, ebp - 0x2c], 0);       /* mov dword [ebp-0x2c], 0x0 */
            ii(0x1013_8eef, 5); mov(ecx, 0x19);                         /* mov ecx, 0x19 */
            ii(0x1013_8ef4, 6); lea(edi, ebp - 0x90);                   /* lea edi, [ebp-0x90] */
            ii(0x1013_8efa, 5); mov(esi, 0x101b_d47c);                  /* mov esi, 0x101bd47c */
            ii(0x1013_8eff, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1013_8f01, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_8f05, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_8f08, 6); pushd(memd_a32[ds, eax + 0x101b_d42c]); /* push dword [eax+0x101bd42c] */
            ii(0x1013_8f0e, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_8f12, 1); pushd(eax);                             /* push eax */
            ii(0x1013_8f13, 5); mov(eax, StringDefinitions.SaveIS3);    /* mov eax, 0x101ac87f */
            ii(0x1013_8f18, 1); pushd(eax);                             /* push eax */
            ii(0x1013_8f19, 6); lea(eax, ebp - 0xa0);                   /* lea eax, [ebp-0xa0] */
            ii(0x1013_8f1f, 1); pushd(eax);                             /* push eax */
            ii(0x1013_8f20, 5); calld(Definitions.sys_sprintf, 0x2_cfdc); /* call 0x10165f01 */
            ii(0x1013_8f25, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1013_8f28, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_8f2c, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1013_8f2f, 2); if(jzd(0x1013_8f3a, 0x9)) goto l_0x1013_8f3a; /* jz 0x10138f3a */
            ii(0x1013_8f31, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_8f35, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1013_8f38, 2); if(jnzd(0x1013_8f3c, 0x2)) goto l_0x1013_8f3c; /* jnz 0x10138f3c */
        l_0x1013_8f3a:
            ii(0x1013_8f3a, 2); jmpd(0x1013_8f45, 0x9); goto l_0x1013_8f45; /* jmp 0x10138f45 */
        l_0x1013_8f3c:
            ii(0x1013_8f3c, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_8f40, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1013_8f43, 2); if(jnzd(0x1013_8f47, 0x2)) goto l_0x1013_8f47; /* jnz 0x10138f47 */
        l_0x1013_8f45:
            ii(0x1013_8f45, 2); jmpd(0x1013_8f50, 0x9); goto l_0x1013_8f50; /* jmp 0x10138f50 */
        l_0x1013_8f47:
            ii(0x1013_8f47, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_8f4b, 3); cmp(eax, 0x9);                          /* cmp eax, 0x9 */
            ii(0x1013_8f4e, 2); if(jnzd(0x1013_8f52, 0x2)) goto l_0x1013_8f52; /* jnz 0x10138f52 */
        l_0x1013_8f50:
            ii(0x1013_8f50, 2); jmpd(0x1013_8f5b, 0x9); goto l_0x1013_8f5b; /* jmp 0x10138f5b */
        l_0x1013_8f52:
            ii(0x1013_8f52, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_8f56, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x1013_8f59, 2); if(jnzd(0x1013_8f5d, 0x2)) goto l_0x1013_8f5d; /* jnz 0x10138f5d */
        l_0x1013_8f5b:
            ii(0x1013_8f5b, 2); jmpd(0x1013_8f6d, 0x10); goto l_0x1013_8f6d; /* jmp 0x10138f6d */
        l_0x1013_8f5d:
            ii(0x1013_8f5d, 5); mov(edx, 0x101c_3d70);                  /* mov edx, 0x101c3d70 */
            ii(0x1013_8f62, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1013_8f68, 5); calld(Definitions.sys_strcpy, 0x2_cf62); /* call 0x10165ecf */
        l_0x1013_8f6d:
            ii(0x1013_8f6d, 6); lea(edx, ebp - 0xa0);                   /* lea edx, [ebp-0xa0] */
            ii(0x1013_8f73, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1013_8f79, 5); calld(Definitions.sys_strcat, 0x2_cfb3); /* call 0x10165f31 */
            ii(0x1013_8f7e, 6); lea(edx, ebp - 0x90);                   /* lea edx, [ebp-0x90] */
            ii(0x1013_8f84, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_8f87, 5); calld(0x1013_b9e0, 0x2a54);             /* call 0x1013b9e0 */
            ii(0x1013_8f8c, 2); test(al, al);                           /* test al, al */
            ii(0x1013_8f8e, 2); if(jnzd(0x1013_8fa9, 0x19)) goto l_0x1013_8fa9; /* jnz 0x10138fa9 */
            ii(0x1013_8f90, 10); mov(memd_a32[ss, ebp - 0xa4], 0);      /* mov dword [ebp-0xa4], 0x0 */
            ii(0x1013_8f9a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_8f9c, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_8f9f, 5); calld(0x1013_b997, 0x29f3);             /* call 0x1013b997 */
            ii(0x1013_8fa4, 5); jmpd(0x1013_9ad1, 0xb28); goto l_0x1013_9ad1; /* jmp 0x10139ad1 */
        l_0x1013_8fa9:
            ii(0x1013_8fa9, 5); mov(ebx, 0xb0);                         /* mov ebx, 0xb0 */
            ii(0x1013_8fae, 6); lea(edx, ebp - 0x154);                  /* lea edx, [ebp-0x154] */
            ii(0x1013_8fb4, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_8fb7, 5); calld(0x1013_ba86, 0x2aca);             /* call 0x1013ba86 */
            ii(0x1013_8fbc, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1013_8fc0, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1013_8fc4, 6); lea(eax, ebp - 0x154);                  /* lea eax, [ebp-0x154] */
            ii(0x1013_8fca, 5); calld(0x1013_8d74, -0x25b);             /* call 0x10138d74 */
            ii(0x1013_8fcf, 7); movsx(eax, memw_a32[ss, ebp - 0x154]);  /* movsx eax, word [ebp-0x154] */
            ii(0x1013_8fd6, 3); cmp(eax, 0x46);                         /* cmp eax, 0x46 */
            ii(0x1013_8fd9, 2); if(jzd(0x1013_9018, 0x3d)) goto l_0x1013_9018; /* jz 0x10139018 */
            ii(0x1013_8fdb, 5); calld(0x100c_aa00, -0x6_e5e0);          /* call 0x100caa00 */
            ii(0x1013_8fe0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_8fe5, 1); pushd(eax);                             /* push eax */
            ii(0x1013_8fe6, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1013_8feb, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1013_8ff0, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1013_8ff5, 5); mov(eax, StringDefinitions.WrongSaveVersionCanTLoad); /* mov eax, 0x101ac889 */
            ii(0x1013_8ffa, 5); calld(0x1011_5d23, -0x2_32dc);          /* call 0x10115d23 */
            ii(0x1013_8fff, 10); mov(memd_a32[ss, ebp - 0xa4], 0);      /* mov dword [ebp-0xa4], 0x0 */
            ii(0x1013_9009, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_900b, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_900e, 5); calld(0x1013_b997, 0x2984);             /* call 0x1013b997 */
            ii(0x1013_9013, 5); jmpd(0x1013_9ad1, 0xab9); goto l_0x1013_9ad1; /* jmp 0x10139ad1 */
        l_0x1013_9018:
            ii(0x1013_9018, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1013_901f, 2); if(jnzd(0x1013_9064, 0x43)) goto l_0x1013_9064; /* jnz 0x10139064 */
            ii(0x1013_9021, 10); mov(memd_a32[ss, ebp - 0x158], 0x4);   /* mov dword [ebp-0x158], 0x4 */
        l_0x1013_902b:
            ii(0x1013_902b, 6); dec(memd_a32[ss, ebp - 0x158]);         /* dec dword [ebp-0x158] */
            ii(0x1013_9031, 8); cmp(memw_a32[ss, ebp - 0x158], -0x1 /* 0xff */); /* cmp word [ebp-0x158], 0xffff */
            ii(0x1013_9039, 2); if(jzd(0x1013_9064, 0x29)) goto l_0x1013_9064; /* jz 0x10139064 */
            ii(0x1013_903b, 7); movsx(eax, memw_a32[ss, ebp - 0x158]);  /* movsx eax, word [ebp-0x158] */
            ii(0x1013_9042, 3); imul(eax, eax, 0x1e);                   /* imul eax, eax, 0x1e */
            ii(0x1013_9045, 6); lea(ebx, ebp - 0x130);                  /* lea ebx, [ebp-0x130] */
            ii(0x1013_904b, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1013_904d, 6); mov(al, memb_a32[ss, ebp - 0x158]);     /* mov al, [ebp-0x158] */
            ii(0x1013_9053, 2); add(al, 0x63);                          /* add al, 0x63 */
            ii(0x1013_9055, 3); movsx(edx, al);                         /* movsx edx, al */
            ii(0x1013_9058, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1013_905d, 5); calld(0x1010_6205, -0x3_2e5d);          /* call 0x10106205 */
            ii(0x1013_9062, 2); jmpd(0x1013_902b, -0x39); goto l_0x1013_902b; /* jmp 0x1013902b */
        l_0x1013_9064:
            ii(0x1013_9064, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_9066, 6); mov(al, memb_a32[ss, ebp - 0x133]);     /* mov al, [ebp-0x133] */
            ii(0x1013_906c, 5); calld(0x1013_51c1, -0x3eb0);            /* call 0x101351c1 */
            ii(0x1013_9071, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_9073, 6); mov(dl, memb_a32[ss, ebp - 0x152]);     /* mov dl, [ebp-0x152] */
            ii(0x1013_9079, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x1013_907e, 5); calld(0x100c_aafc, -0x6_e587);          /* call 0x100caafc */
            ii(0x1013_9083, 6); mov(eax, memd_a32[ss, ebp - 0x132]);    /* mov eax, [ebp-0x132] */
            ii(0x1013_9089, 6); mov(memw_a32[ds, 0x101c_3982], ax);     /* mov [0x101c3982], ax */
            ii(0x1013_908f, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1013_9094, 5); calld(0x1007_5fdc, -0xc_30bd);          /* call 0x10075fdc */
            ii(0x1013_9099, 6); mov(memb_a32[ss, ebp - 0xaa], al);      /* mov [ebp-0xaa], al */
            ii(0x1013_909f, 5); mov(eax, 0x46);                         /* mov eax, 0x46 */
            ii(0x1013_90a4, 5); calld(0x1007_5fdc, -0xc_30cd);          /* call 0x10075fdc */
            ii(0x1013_90a9, 7); mov(memw_a32[ss, ebp - 0xa9], ax);      /* mov [ebp-0xa9], ax */
            ii(0x1013_90b0, 5); mov(eax, 0x47);                         /* mov eax, 0x47 */
            ii(0x1013_90b5, 5); calld(0x1007_5fdc, -0xc_30de);          /* call 0x10075fdc */
            ii(0x1013_90ba, 7); mov(memw_a32[ss, ebp - 0xa7], ax);      /* mov [ebp-0xa7], ax */
            ii(0x1013_90c1, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x1013_90c6, 5); calld(0x1007_5fdc, -0xc_30ef);          /* call 0x10075fdc */
            ii(0x1013_90cb, 6); mov(memb_a32[ss, ebp - 0xa5], al);      /* mov [ebp-0xa5], al */
            ii(0x1013_90d1, 5); mov(eax, 0x48);                         /* mov eax, 0x48 */
            ii(0x1013_90d6, 5); calld(0x1007_5fdc, -0xc_30ff);          /* call 0x10075fdc */
            ii(0x1013_90db, 6); mov(memd_a32[ss, ebp - 0x15c], eax);    /* mov [ebp-0x15c], eax */
            ii(0x1013_90e1, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1013_90e6, 5); calld(0x1007_5fdc, -0xc_310f);          /* call 0x10075fdc */
            ii(0x1013_90eb, 6); mov(memd_a32[ss, ebp - 0x160], eax);    /* mov [ebp-0x160], eax */
            ii(0x1013_90f1, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1013_90f6, 5); calld(0x1007_5fdc, -0xc_311f);          /* call 0x10075fdc */
            ii(0x1013_90fb, 6); mov(memd_a32[ss, ebp - 0x164], eax);    /* mov [ebp-0x164], eax */
            ii(0x1013_9101, 5); mov(eax, 0x4f);                         /* mov eax, 0x4f */
            ii(0x1013_9106, 5); calld(0x1007_5fdc, -0xc_312f);          /* call 0x10075fdc */
            ii(0x1013_910b, 6); mov(memd_a32[ss, ebp - 0x168], eax);    /* mov [ebp-0x168], eax */
            ii(0x1013_9111, 5); mov(eax, 0x50);                         /* mov eax, 0x50 */
            ii(0x1013_9116, 5); calld(0x1007_5fdc, -0xc_313f);          /* call 0x10075fdc */
            ii(0x1013_911b, 6); mov(memd_a32[ss, ebp - 0x16c], eax);    /* mov [ebp-0x16c], eax */
            ii(0x1013_9121, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1013_9123, 3); mov(cl, memb_a32[ss, ebp - 0x4]);       /* mov cl, [ebp-0x4] */
            ii(0x1013_9126, 5); mov(ebx, 0x44);                         /* mov ebx, 0x44 */
            ii(0x1013_912b, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1013_912e, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1013_9133, 5); calld(0x1010_63f3, -0x3_2d45);          /* call 0x101063f3 */
            ii(0x1013_9138, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_913c, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1013_913f, 2); if(jzd(0x1013_914a, 0x9)) goto l_0x1013_914a; /* jz 0x1013914a */
            ii(0x1013_9141, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_9145, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1013_9148, 2); if(jnzd(0x1013_914c, 0x2)) goto l_0x1013_914c; /* jnz 0x1013914c */
        l_0x1013_914a:
            ii(0x1013_914a, 2); jmpd(0x1013_9155, 0x9); goto l_0x1013_9155; /* jmp 0x10139155 */
        l_0x1013_914c:
            ii(0x1013_914c, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_9150, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1013_9153, 2); if(jnzd(0x1013_9157, 0x2)) goto l_0x1013_9157; /* jnz 0x10139157 */
        l_0x1013_9155:
            ii(0x1013_9155, 2); jmpd(0x1013_9164, 0xd); goto l_0x1013_9164; /* jmp 0x10139164 */
        l_0x1013_9157:
            ii(0x1013_9157, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_915b, 3); cmp(eax, 0x9);                          /* cmp eax, 0x9 */
            ii(0x1013_915e, 6); if(jnzd(0x1013_91ff, 0x9b)) goto l_0x1013_91ff; /* jnz 0x101391ff */
        l_0x1013_9164:
            ii(0x1013_9164, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_9166, 6); mov(dl, memb_a32[ss, ebp - 0xaa]);      /* mov dl, [ebp-0xaa] */
            ii(0x1013_916c, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1013_9171, 5); calld(0x100c_aafc, -0x6_e67a);          /* call 0x100caafc */
            ii(0x1013_9176, 7); movsx(edx, memw_a32[ss, ebp - 0xa9]);   /* movsx edx, word [ebp-0xa9] */
            ii(0x1013_917d, 5); mov(eax, 0x46);                         /* mov eax, 0x46 */
            ii(0x1013_9182, 5); calld(0x100c_aafc, -0x6_e68b);          /* call 0x100caafc */
            ii(0x1013_9187, 7); movsx(edx, memw_a32[ss, ebp - 0xa7]);   /* movsx edx, word [ebp-0xa7] */
            ii(0x1013_918e, 5); mov(eax, 0x47);                         /* mov eax, 0x47 */
            ii(0x1013_9193, 5); calld(0x100c_aafc, -0x6_e69c);          /* call 0x100caafc */
            ii(0x1013_9198, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_919a, 6); mov(dl, memb_a32[ss, ebp - 0xa5]);      /* mov dl, [ebp-0xa5] */
            ii(0x1013_91a0, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x1013_91a5, 5); calld(0x100c_aafc, -0x6_e6ae);          /* call 0x100caafc */
            ii(0x1013_91aa, 7); movsx(edx, memw_a32[ss, ebp - 0x15c]);  /* movsx edx, word [ebp-0x15c] */
            ii(0x1013_91b1, 5); mov(eax, 0x48);                         /* mov eax, 0x48 */
            ii(0x1013_91b6, 5); calld(0x100c_aafc, -0x6_e6bf);          /* call 0x100caafc */
            ii(0x1013_91bb, 7); movsx(edx, memw_a32[ss, ebp - 0x160]);  /* movsx edx, word [ebp-0x160] */
            ii(0x1013_91c2, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1013_91c7, 5); calld(0x100c_aafc, -0x6_e6d0);          /* call 0x100caafc */
            ii(0x1013_91cc, 7); movsx(edx, memw_a32[ss, ebp - 0x164]);  /* movsx edx, word [ebp-0x164] */
            ii(0x1013_91d3, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1013_91d8, 5); calld(0x100c_aafc, -0x6_e6e1);          /* call 0x100caafc */
            ii(0x1013_91dd, 7); movsx(edx, memw_a32[ss, ebp - 0x168]);  /* movsx edx, word [ebp-0x168] */
            ii(0x1013_91e4, 5); mov(eax, 0x4f);                         /* mov eax, 0x4f */
            ii(0x1013_91e9, 5); calld(0x100c_aafc, -0x6_e6f2);          /* call 0x100caafc */
            ii(0x1013_91ee, 7); movsx(edx, memw_a32[ss, ebp - 0x16c]);  /* movsx edx, word [ebp-0x16c] */
            ii(0x1013_91f5, 5); mov(eax, 0x50);                         /* mov eax, 0x50 */
            ii(0x1013_91fa, 5); calld(0x100c_aafc, -0x6_e703);          /* call 0x100caafc */
        l_0x1013_91ff:
            ii(0x1013_91ff, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x1013_9204, 5); calld(0x1007_5fdc, -0xc_322d);          /* call 0x10075fdc */
            ii(0x1013_9209, 5); mov(memb_a32[ds, 0x101c_37c9], al);     /* mov [0x101c37c9], al */
            ii(0x1013_920e, 6); mov(ebx, memd_a32[ds, 0x101c_8170]);    /* mov ebx, [0x101c8170] */
            ii(0x1013_9214, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1013_9217, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x1013_921c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_921f, 3); imul(ebx, eax);                         /* imul ebx, eax */
            ii(0x1013_9222, 6); mov(edx, memd_a32[ds, 0x101c_9454]);    /* mov edx, [0x101c9454] */
            ii(0x1013_9228, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_922b, 5); calld(0x1013_ba86, 0x2856);             /* call 0x1013ba86 */
            ii(0x1013_9230, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x1013_9236, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_9239, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x1013_923e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_9241, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1013_9244, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_9246, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_9248, 6); mov(edx, memd_a32[ds, 0x101c_811c]);    /* mov edx, [0x101c811c] */
            ii(0x1013_924e, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_9251, 5); calld(0x1013_ba86, 0x2830);             /* call 0x1013ba86 */
            ii(0x1013_9256, 5); calld(0x1013_6316, -0x2f45);            /* call 0x10136316 */
            ii(0x1013_925b, 10); mov(memd_a32[ss, ebp - 0x170], 0);     /* mov dword [ebp-0x170], 0x0 */
            ii(0x1013_9265, 2); jmpd(0x1013_9273, 0xc); goto l_0x1013_9273; /* jmp 0x10139273 */
        l_0x1013_9267:
            ii(0x1013_9267, 6); mov(eax, memd_a32[ss, ebp - 0x170]);    /* mov eax, [ebp-0x170] */
            ii(0x1013_926d, 6); inc(memd_a32[ss, ebp - 0x170]);         /* inc dword [ebp-0x170] */
        l_0x1013_9273:
            ii(0x1013_9273, 7); movsx(eax, memw_a32[ss, ebp - 0x170]);  /* movsx eax, word [ebp-0x170] */
            ii(0x1013_927a, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1013_927d, 6); if(jged(0x1013_9522, 0x29f)) goto l_0x1013_9522; /* jge 0x10139522 */
            ii(0x1013_9283, 7); movsx(eax, memw_a32[ss, ebp - 0x170]);  /* movsx eax, word [ebp-0x170] */
            ii(0x1013_928a, 6); imul(edx, eax, 0x247);                  /* imul edx, eax, 0x247 */
            ii(0x1013_9290, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x1013_9295, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_9297, 6); mov(memd_a32[ss, ebp - 0x174], eax);    /* mov [ebp-0x174], eax */
            ii(0x1013_929d, 5); mov(ebx, 0x28);                         /* mov ebx, 0x28 */
            ii(0x1013_92a2, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_92a8, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_92ab, 5); calld(0x1013_ba86, 0x27d6);             /* call 0x1013ba86 */
            ii(0x1013_92b0, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_92b6, 3); add(edx, 0x28);                         /* add edx, 0x28 */
            ii(0x1013_92b9, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_92bc, 5); calld(0x1013_bb46, 0x2885);             /* call 0x1013bb46 */
            ii(0x1013_92c1, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_92c7, 3); add(edx, 0x29);                         /* add edx, 0x29 */
            ii(0x1013_92ca, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_92cd, 5); calld(0x1013_bb46, 0x2874);             /* call 0x1013bb46 */
            ii(0x1013_92d2, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_92d8, 6); add(edx, 0x87);                         /* add edx, 0x87 */
            ii(0x1013_92de, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_92e1, 5); calld(0x1013_bb46, 0x2860);             /* call 0x1013bb46 */
            ii(0x1013_92e6, 5); mov(ebx, 0x60);                         /* mov ebx, 0x60 */
            ii(0x1013_92eb, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_92f1, 6); add(edx, 0x88);                         /* add edx, 0x88 */
            ii(0x1013_92f7, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_92fa, 5); calld(0x1013_ba86, 0x2787);             /* call 0x1013ba86 */
            ii(0x1013_92ff, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_9305, 6); add(edx, 0xe8);                         /* add edx, 0xe8 */
            ii(0x1013_930b, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_930e, 5); calld(0x1010_6a64, -0x3_28af);          /* call 0x10106a64 */
            ii(0x1013_9313, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_9319, 6); add(edx, 0xec);                         /* add edx, 0xec */
            ii(0x1013_931f, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_9322, 5); calld(0x1013_bb7b, 0x2854);             /* call 0x1013bb7b */
            ii(0x1013_9327, 5); mov(ebx, 0x5d);                         /* mov ebx, 0x5d */
            ii(0x1013_932c, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_9332, 3); add(edx, 0x2a);                         /* add edx, 0x2a */
            ii(0x1013_9335, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_9338, 5); calld(0x1013_ba86, 0x2749);             /* call 0x1013ba86 */
            ii(0x1013_933d, 5); mov(ebx, 0xc);                          /* mov ebx, 0xc */
            ii(0x1013_9342, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_9348, 6); add(edx, 0xee);                         /* add edx, 0xee */
            ii(0x1013_934e, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_9351, 5); calld(0x1013_ba86, 0x2730);             /* call 0x1013ba86 */
            ii(0x1013_9356, 5); mov(ebx, 0x64);                         /* mov ebx, 0x64 */
            ii(0x1013_935b, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_9361, 6); add(edx, 0x11d);                        /* add edx, 0x11d */
            ii(0x1013_9367, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_936a, 5); calld(0x1013_ba86, 0x2717);             /* call 0x1013ba86 */
            ii(0x1013_936f, 7); movsx(eax, memw_a32[ss, ebp - 0x170]);  /* movsx eax, word [ebp-0x170] */
            ii(0x1013_9376, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_9378, 6); lea(edx, ebp - 0x17c);                  /* lea edx, [ebp-0x17c] */
            ii(0x1013_937e, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_9380, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_9383, 5); calld(0x1013_bbb0, 0x2828);             /* call 0x1013bbb0 */
            ii(0x1013_9388, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_938e, 6); add(edx, 0x102);                        /* add edx, 0x102 */
            ii(0x1013_9394, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_9397, 5); calld(0x1013_bb7b, 0x27df);             /* call 0x1013bb7b */
            ii(0x1013_939c, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_93a2, 6); add(edx, 0x104);                        /* add edx, 0x104 */
            ii(0x1013_93a8, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_93ab, 5); calld(0x1013_bb7b, 0x27cb);             /* call 0x1013bb7b */
            ii(0x1013_93b0, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_93b6, 6); add(edx, 0x106);                        /* add edx, 0x106 */
            ii(0x1013_93bc, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_93bf, 5); calld(0x1013_bb7b, 0x27b7);             /* call 0x1013bb7b */
            ii(0x1013_93c4, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_93ca, 6); add(edx, 0x108);                        /* add edx, 0x108 */
            ii(0x1013_93d0, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_93d3, 5); calld(0x1013_bb11, 0x2739);             /* call 0x1013bb11 */
            ii(0x1013_93d8, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_93de, 6); add(edx, 0x109);                        /* add edx, 0x109 */
            ii(0x1013_93e4, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_93e7, 5); calld(0x1013_bb11, 0x2725);             /* call 0x1013bb11 */
            ii(0x1013_93ec, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_93f2, 6); add(edx, 0x10a);                        /* add edx, 0x10a */
            ii(0x1013_93f8, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_93fb, 5); calld(0x1013_bb11, 0x2711);             /* call 0x1013bb11 */
            ii(0x1013_9400, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_9406, 6); add(edx, 0x10b);                        /* add edx, 0x10b */
            ii(0x1013_940c, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_940f, 5); calld(0x1013_bb11, 0x26fd);             /* call 0x1013bb11 */
            ii(0x1013_9414, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_941a, 6); add(edx, 0x10c);                        /* add edx, 0x10c */
            ii(0x1013_9420, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_9423, 5); calld(0x1013_bb11, 0x26e9);             /* call 0x1013bb11 */
            ii(0x1013_9428, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_942e, 6); add(edx, 0x10d);                        /* add edx, 0x10d */
            ii(0x1013_9434, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_9437, 5); calld(0x1013_bb11, 0x26d5);             /* call 0x1013bb11 */
            ii(0x1013_943c, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_9442, 6); add(edx, 0x112);                        /* add edx, 0x112 */
            ii(0x1013_9448, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_944b, 5); calld(0x1013_bb11, 0x26c1);             /* call 0x1013bb11 */
            ii(0x1013_9450, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_9456, 6); add(edx, 0x10e);                        /* add edx, 0x10e */
            ii(0x1013_945c, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_945f, 5); calld(0x1013_bb11, 0x26ad);             /* call 0x1013bb11 */
            ii(0x1013_9464, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_946a, 6); add(edx, 0x10f);                        /* add edx, 0x10f */
            ii(0x1013_9470, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_9473, 5); calld(0x1013_bb11, 0x2699);             /* call 0x1013bb11 */
            ii(0x1013_9478, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_947e, 6); add(edx, 0x110);                        /* add edx, 0x110 */
            ii(0x1013_9484, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_9487, 5); calld(0x1013_bb11, 0x2685);             /* call 0x1013bb11 */
            ii(0x1013_948c, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_9492, 6); add(edx, 0x111);                        /* add edx, 0x111 */
            ii(0x1013_9498, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_949b, 5); calld(0x1013_bb11, 0x2671);             /* call 0x1013bb11 */
            ii(0x1013_94a0, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_94a6, 6); add(edx, 0x113);                        /* add edx, 0x113 */
            ii(0x1013_94ac, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_94af, 5); calld(0x1013_bb7b, 0x26c7);             /* call 0x1013bb7b */
            ii(0x1013_94b4, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_94ba, 6); add(edx, 0x115);                        /* add edx, 0x115 */
            ii(0x1013_94c0, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_94c3, 5); calld(0x1013_bb7b, 0x26b3);             /* call 0x1013bb7b */
            ii(0x1013_94c8, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_94ce, 6); add(edx, 0x117);                        /* add edx, 0x117 */
            ii(0x1013_94d4, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_94d7, 5); calld(0x1013_bb7b, 0x269f);             /* call 0x1013bb7b */
            ii(0x1013_94dc, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_94e2, 6); add(edx, 0x119);                        /* add edx, 0x119 */
            ii(0x1013_94e8, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_94eb, 5); calld(0x1013_bb7b, 0x268b);             /* call 0x1013bb7b */
            ii(0x1013_94f0, 5); mov(ebx, 0xba);                         /* mov ebx, 0xba */
            ii(0x1013_94f5, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_94fb, 6); add(edx, 0x181);                        /* add edx, 0x181 */
            ii(0x1013_9501, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_9504, 5); calld(0x1013_ba86, 0x257d);             /* call 0x1013ba86 */
            ii(0x1013_9509, 6); mov(edx, memd_a32[ss, ebp - 0x174]);    /* mov edx, [ebp-0x174] */
            ii(0x1013_950f, 6); add(edx, 0x11b);                        /* add edx, 0x11b */
            ii(0x1013_9515, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_9518, 5); calld(0x1013_bb7b, 0x265e);             /* call 0x1013bb7b */
            ii(0x1013_951d, 5); jmpd(0x1013_9267, -0x2bb); goto l_0x1013_9267; /* jmp 0x10139267 */
        l_0x1013_9522:
            ii(0x1013_9522, 5); mov(edx, 0x101c_37c8);                  /* mov edx, 0x101c37c8 */
            ii(0x1013_9527, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_952a, 5); calld(0x1013_bb11, 0x25e2);             /* call 0x1013bb11 */
            ii(0x1013_952f, 5); mov(edx, 0x101c_37da);                  /* mov edx, 0x101c37da */
            ii(0x1013_9534, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_9537, 5); calld(0x1013_bb11, 0x25d5);             /* call 0x1013bb11 */
            ii(0x1013_953c, 5); mov(edx, 0x101c_37dc);                  /* mov edx, 0x101c37dc */
            ii(0x1013_9541, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_9544, 5); calld(0x1010_6a64, -0x3_2ae5);          /* call 0x10106a64 */
            ii(0x1013_9549, 6); lea(edx, ebp - 0x170);                  /* lea edx, [ebp-0x170] */
            ii(0x1013_954f, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_9552, 5); calld(0x1013_bb7b, 0x2624);             /* call 0x1013bb7b */
            ii(0x1013_9557, 6); mov(al, memb_a32[ss, ebp - 0x170]);     /* mov al, [ebp-0x170] */
            ii(0x1013_955d, 5); mov(memb_a32[ds, 0x101c_391f], al);     /* mov [0x101c391f], al */
            ii(0x1013_9562, 5); mov(edx, 0x101c_3964);                  /* mov edx, 0x101c3964 */
            ii(0x1013_9567, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_956a, 5); calld(0x1013_bb7b, 0x260c);             /* call 0x1013bb7b */
            ii(0x1013_956f, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1013_9574, 5); mov(ebx, 0x51);                         /* mov ebx, 0x51 */
            ii(0x1013_9579, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1013_957c, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1013_9581, 5); calld(0x1010_63f3, -0x3_3193);          /* call 0x101063f3 */
            ii(0x1013_9586, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1013_9589, 5); mov(eax, 0x101c_61b4);                  /* mov eax, 0x101c61b4 */
            ii(0x1013_958e, 5); calld(0x100d_f600, -0x5_9f93);          /* call 0x100df600 */
            ii(0x1013_9593, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1013_9596, 5); mov(eax, 0x101c_64b0);                  /* mov eax, 0x101c64b0 */
            ii(0x1013_959b, 5); calld(0x100d_f600, -0x5_9fa0);          /* call 0x100df600 */
            ii(0x1013_95a0, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1013_95a3, 5); mov(eax, 0x101c_67ac);                  /* mov eax, 0x101c67ac */
            ii(0x1013_95a8, 5); calld(0x100d_f600, -0x5_9fad);          /* call 0x100df600 */
            ii(0x1013_95ad, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1013_95b0, 5); mov(eax, 0x101c_6aa8);                  /* mov eax, 0x101c6aa8 */
            ii(0x1013_95b5, 5); calld(0x100d_f600, -0x5_9fba);          /* call 0x100df600 */
            ii(0x1013_95ba, 5); calld(0x1015_aa72, 0x2_14b3);           /* call 0x1015aa72 */
            ii(0x1013_95bf, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1013_95c2, 5); mov(eax, 0x101c_8178);                  /* mov eax, 0x101c8178 */
            ii(0x1013_95c7, 5); calld(0x1010_2cbf, -0x3_690d);          /* call 0x10102cbf */
            ii(0x1013_95cc, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1013_95cf, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1013_95d4, 5); calld(0x1010_2cbf, -0x3_691a);          /* call 0x10102cbf */
            ii(0x1013_95d9, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1013_95dc, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1013_95e1, 5); calld(0x1010_2cbf, -0x3_6927);          /* call 0x10102cbf */
            ii(0x1013_95e6, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1013_95e9, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x1013_95ee, 5); calld(0x1010_2cbf, -0x3_6934);          /* call 0x10102cbf */
            ii(0x1013_95f3, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1013_95f6, 5); mov(eax, 0x101c_8190);                  /* mov eax, 0x101c8190 */
            ii(0x1013_95fb, 5); calld(0x1010_2cbf, -0x3_6941);          /* call 0x10102cbf */
            ii(0x1013_9600, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1013_9603, 5); mov(eax, 0x101c_39c0);                  /* mov eax, 0x101c39c0 */
            ii(0x1013_9608, 5); calld(0x1010_40b6, -0x3_5557);          /* call 0x101040b6 */
            ii(0x1013_960d, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1013_9610, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1013_9615, 5); calld(0x1010_385f, -0x3_5dbb);          /* call 0x1010385f */
            ii(0x1013_961a, 10); mov(memd_a32[ds, 0x101c_a562], 0x101c_61b4); /* mov dword [0x101ca562], 0x101c61b4 */
            ii(0x1013_9624, 10); mov(memd_a32[ds, 0x101c_a7a9], 0x101c_64b0); /* mov dword [0x101ca7a9], 0x101c64b0 */
            ii(0x1013_962e, 10); mov(memd_a32[ds, 0x101c_a9f0], 0x101c_67ac); /* mov dword [0x101ca9f0], 0x101c67ac */
            ii(0x1013_9638, 10); mov(memd_a32[ds, 0x101c_ac37], 0x101c_6aa8); /* mov dword [0x101cac37], 0x101c6aa8 */
            ii(0x1013_9642, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1013_9646, 9); mov(memw_a32[ss, ebp - 0x158], 0);      /* mov word [ebp-0x158], 0x0 */
            ii(0x1013_964f, 2); jmpd(0x1013_965e, 0xd); goto l_0x1013_965e; /* jmp 0x1013965e */
        l_0x1013_9651:
            ii(0x1013_9651, 6); mov(eax, memd_a32[ss, ebp - 0x158]);    /* mov eax, [ebp-0x158] */
            ii(0x1013_9657, 7); inc(memw_a32[ss, ebp - 0x158]);         /* inc word [ebp-0x158] */
        l_0x1013_965e:
            ii(0x1013_965e, 7); movsx(eax, memw_a32[ss, ebp - 0x158]);  /* movsx eax, word [ebp-0x158] */
            ii(0x1013_9665, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1013_9668, 6); if(jged(0x1013_999c, 0x32e)) goto l_0x1013_999c; /* jge 0x1013999c */
            ii(0x1013_966e, 7); movsx(eax, memw_a32[ss, ebp - 0x158]);  /* movsx eax, word [ebp-0x158] */
            ii(0x1013_9675, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_967b, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x1013_9680, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_9682, 6); mov(memd_a32[ss, ebp - 0x180], edx);    /* mov [ebp-0x180], edx */
            ii(0x1013_9688, 6); mov(eax, memd_a32[ss, ebp - 0x180]);    /* mov eax, [ebp-0x180] */
            ii(0x1013_968e, 3); mov(al, memb_a32[ds, eax + 0x28]);      /* mov al, [eax+0x28] */
            ii(0x1013_9691, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_9696, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_9698, 6); if(jzd(0x1013_996b, 0x2cd)) goto l_0x1013_996b; /* jz 0x1013996b */
            ii(0x1013_969e, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1013_96a5, 2); if(jzd(0x1013_971f, 0x78)) goto l_0x1013_971f; /* jz 0x1013971f */
            ii(0x1013_96a7, 7); movsx(eax, memw_a32[ss, ebp - 0x158]);  /* movsx eax, word [ebp-0x158] */
            ii(0x1013_96ae, 6); mov(eax, memd_a32[ds, eax + 0x101b_873d]); /* mov eax, [eax+0x101b873d] */
            ii(0x1013_96b4, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1013_96b7, 5); calld(0x1007_5fdc, -0xc_36e0);          /* call 0x10075fdc */
            ii(0x1013_96bc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_96be, 6); mov(eax, memd_a32[ss, ebp - 0x180]);    /* mov eax, [ebp-0x180] */
            ii(0x1013_96c4, 3); mov(memb_a32[ds, eax + 0x28], dl);      /* mov [eax+0x28], dl */
            ii(0x1013_96c7, 6); mov(eax, memd_a32[ss, ebp - 0x180]);    /* mov eax, [ebp-0x180] */
            ii(0x1013_96cd, 3); mov(al, memb_a32[ds, eax + 0x28]);      /* mov al, [eax+0x28] */
            ii(0x1013_96d0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_96d5, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1013_96d8, 2); if(jnzd(0x1013_971a, 0x40)) goto l_0x1013_971a; /* jnz 0x1013971a */
            ii(0x1013_96da, 6); mov(al, memb_a32[ss, ebp - 0x158]);     /* mov al, [ebp-0x158] */
            ii(0x1013_96e0, 5); mov(memb_a32[ds, 0x101c_37da], al);     /* mov [0x101c37da], al */
            ii(0x1013_96e5, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x1013_96ea, 6); lea(ebx, ebp - 0x1a0);                  /* lea ebx, [ebp-0x1a0] */
            ii(0x1013_96f0, 6); mov(al, memb_a32[ss, ebp - 0x158]);     /* mov al, [ebp-0x158] */
            ii(0x1013_96f6, 2); add(al, 0x63);                          /* add al, 0x63 */
            ii(0x1013_96f8, 3); movsx(edx, al);                         /* movsx edx, al */
            ii(0x1013_96fb, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1013_9700, 5); calld(0x1010_6281, -0x3_3484);          /* call 0x10106281 */
            ii(0x1013_9705, 6); lea(ebx, ebp - 0x1a0);                  /* lea ebx, [ebp-0x1a0] */
            ii(0x1013_970b, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x1013_9710, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1013_9715, 5); calld(0x1010_6205, -0x3_3515);          /* call 0x10106205 */
        l_0x1013_971a:
            ii(0x1013_971a, 5); jmpd(0x1013_983b, 0x11c); goto l_0x1013_983b; /* jmp 0x1013983b */
        l_0x1013_971f:
            ii(0x1013_971f, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_9723, 3); cmp(eax, 0x9);                          /* cmp eax, 0x9 */
            ii(0x1013_9726, 2); if(jnzd(0x1013_9777, 0x4f)) goto l_0x1013_9777; /* jnz 0x10139777 */
            ii(0x1013_9728, 7); movsx(eax, memw_a32[ss, ebp - 0x158]);  /* movsx eax, word [ebp-0x158] */
            ii(0x1013_972f, 6); mov(eax, memd_a32[ds, eax + 0x101b_873d]); /* mov eax, [eax+0x101b873d] */
            ii(0x1013_9735, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1013_9738, 5); calld(0x1007_5fdc, -0xc_3761);          /* call 0x10075fdc */
            ii(0x1013_973d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_973f, 6); mov(eax, memd_a32[ss, ebp - 0x180]);    /* mov eax, [ebp-0x180] */
            ii(0x1013_9745, 3); mov(memb_a32[ds, eax + 0x28], dl);      /* mov [eax+0x28], dl */
            ii(0x1013_9748, 4); cmp(memb_a32[ss, ebp - 0x10], 0);       /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1013_974c, 2); if(jzd(0x1013_9761, 0x13)) goto l_0x1013_9761; /* jz 0x10139761 */
            ii(0x1013_974e, 6); mov(eax, memd_a32[ss, ebp - 0x180]);    /* mov eax, [ebp-0x180] */
            ii(0x1013_9754, 3); mov(al, memb_a32[ds, eax + 0x28]);      /* mov al, [eax+0x28] */
            ii(0x1013_9757, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_975c, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1013_975f, 2); if(jzd(0x1013_9763, 0x2)) goto l_0x1013_9763; /* jz 0x10139763 */
        l_0x1013_9761:
            ii(0x1013_9761, 2); jmpd(0x1013_9772, 0xf); goto l_0x1013_9772; /* jmp 0x10139772 */
        l_0x1013_9763:
            ii(0x1013_9763, 6); mov(al, memb_a32[ss, ebp - 0x158]);     /* mov al, [ebp-0x158] */
            ii(0x1013_9769, 5); mov(memb_a32[ds, 0x101c_37da], al);     /* mov [0x101c37da], al */
            ii(0x1013_976e, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
        l_0x1013_9772:
            ii(0x1013_9772, 5); jmpd(0x1013_983b, 0xc4); goto l_0x1013_983b; /* jmp 0x1013983b */
        l_0x1013_9777:
            ii(0x1013_9777, 6); mov(eax, memd_a32[ss, ebp - 0x180]);    /* mov eax, [ebp-0x180] */
            ii(0x1013_977d, 3); mov(al, memb_a32[ds, eax + 0x28]);      /* mov al, [eax+0x28] */
            ii(0x1013_9780, 6); mov(memb_a32[ss, ebp - 0x1a4], al);     /* mov [ebp-0x1a4], al */
            ii(0x1013_9786, 5); jmpd(0x1013_9803, 0x78); goto l_0x1013_9803; /* jmp 0x10139803 */
        l_0x1013_978b:
            ii(0x1013_978b, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_978f, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1013_9792, 2); if(jzd(0x1013_97c9, 0x35)) goto l_0x1013_97c9; /* jz 0x101397c9 */
            ii(0x1013_9794, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x1013_9799, 6); lea(ebx, ebp - 0x1a0);                  /* lea ebx, [ebp-0x1a0] */
            ii(0x1013_979f, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x1013_97a4, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1013_97a9, 5); calld(0x1010_6281, -0x3_352d);          /* call 0x10106281 */
            ii(0x1013_97ae, 6); lea(ebx, ebp - 0x1a0);                  /* lea ebx, [ebp-0x1a0] */
            ii(0x1013_97b4, 6); mov(al, memb_a32[ss, ebp - 0x158]);     /* mov al, [ebp-0x158] */
            ii(0x1013_97ba, 2); add(al, 0x63);                          /* add al, 0x63 */
            ii(0x1013_97bc, 3); movsx(edx, al);                         /* movsx edx, al */
            ii(0x1013_97bf, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1013_97c4, 5); calld(0x1010_6205, -0x3_35c4);          /* call 0x10106205 */
        l_0x1013_97c9:
            ii(0x1013_97c9, 5); jmpd(0x1013_983b, 0x6d); goto l_0x1013_983b; /* jmp 0x1013983b */
        l_0x1013_97ce:
            ii(0x1013_97ce, 7); movsx(eax, memw_a32[ss, ebp - 0x158]);  /* movsx eax, word [ebp-0x158] */
            ii(0x1013_97d5, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_97d8, 6); mov(ebx, memd_a32[ds, eax + 0x101b_b444]); /* mov ebx, [eax+0x101bb444] */
            ii(0x1013_97de, 6); mov(al, memb_a32[ss, ebp - 0x158]);     /* mov al, [ebp-0x158] */
            ii(0x1013_97e4, 2); add(al, 0x63);                          /* add al, 0x63 */
            ii(0x1013_97e6, 3); movsx(edx, al);                         /* movsx edx, al */
            ii(0x1013_97e9, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1013_97ee, 5); calld(0x1010_6205, -0x3_35ee);          /* call 0x10106205 */
            ii(0x1013_97f3, 2); jmpd(0x1013_983b, 0x46); goto l_0x1013_983b; /* jmp 0x1013983b */
        l_0x1013_97f5:
            ii(0x1013_97f5, 6); mov(eax, memd_a32[ss, ebp - 0x180]);    /* mov eax, [ebp-0x180] */
            ii(0x1013_97fb, 4); mov(memb_a32[ds, eax + 0x28], 0x1);     /* mov byte [eax+0x28], 0x1 */
            ii(0x1013_97ff, 2); jmpd(0x1013_983b, 0x3a); goto l_0x1013_983b; /* jmp 0x1013983b */
        l_0x1013_9801:
            ii(0x1013_9801, 2); jmpd(0x1013_983b, 0x38); goto l_0x1013_983b; /* jmp 0x1013983b */
        l_0x1013_9803:
            ii(0x1013_9803, 6); mov(al, memb_a32[ss, ebp - 0x1a4]);     /* mov al, [ebp-0x1a4] */
            ii(0x1013_9809, 6); mov(memb_a32[ss, ebp - 0x1a8], al);     /* mov [ebp-0x1a8], al */
            ii(0x1013_980f, 7); cmp(memb_a32[ss, ebp - 0x1a8], 0x2);    /* cmp byte [ebp-0x1a8], 0x2 */
            ii(0x1013_9816, 2); if(jbd(0x1013_982c, 0x14)) goto l_0x1013_982c; /* jb 0x1013982c */
            ii(0x1013_9818, 7); cmp(memb_a32[ss, ebp - 0x1a8], 0x2);    /* cmp byte [ebp-0x1a8], 0x2 */
            ii(0x1013_981f, 2); if(jbed(0x1013_97ce, -0x53)) goto l_0x1013_97ce; /* jbe 0x101397ce */
            ii(0x1013_9821, 7); cmp(memb_a32[ss, ebp - 0x1a8], 0x3);    /* cmp byte [ebp-0x1a8], 0x3 */
            ii(0x1013_9828, 2); if(jzd(0x1013_97f5, -0x35)) goto l_0x1013_97f5; /* jz 0x101397f5 */
            ii(0x1013_982a, 2); jmpd(0x1013_9801, -0x2b); goto l_0x1013_9801; /* jmp 0x10139801 */
        l_0x1013_982c:
            ii(0x1013_982c, 7); cmp(memb_a32[ss, ebp - 0x1a8], 0x1);    /* cmp byte [ebp-0x1a8], 0x1 */
            ii(0x1013_9833, 6); if(jzd(0x1013_978b, -0xae)) goto l_0x1013_978b; /* jz 0x1013978b */
            ii(0x1013_9839, 2); jmpd(0x1013_9801, -0x3a); goto l_0x1013_9801; /* jmp 0x10139801 */
        l_0x1013_983b:
            ii(0x1013_983b, 7); movsx(eax, memw_a32[ss, ebp - 0x158]);  /* movsx eax, word [ebp-0x158] */
            ii(0x1013_9842, 5); calld(0x1013_61f9, -0x364e);            /* call 0x101361f9 */
            ii(0x1013_9847, 6); mov(eax, memd_a32[ss, ebp - 0x180]);    /* mov eax, [ebp-0x180] */
            ii(0x1013_984d, 3); mov(al, memb_a32[ds, eax + 0x28]);      /* mov al, [eax+0x28] */
            ii(0x1013_9850, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_9855, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_9857, 6); if(jnzd(0x1013_991e, 0xc1)) goto l_0x1013_991e; /* jnz 0x1013991e */
            ii(0x1013_985d, 5); mov(eax, 0x3100);                       /* mov eax, 0x3100 */
            ii(0x1013_9862, 5); calld(Definitions.sys_new_arr, 0x2_c7a9); /* call 0x10166010 */
            ii(0x1013_9867, 6); mov(memd_a32[ss, ebp - 0x1ac], eax);    /* mov [ebp-0x1ac], eax */
            ii(0x1013_986d, 5); mov(ebx, 0x3100);                       /* mov ebx, 0x3100 */
            ii(0x1013_9872, 6); mov(edx, memd_a32[ss, ebp - 0x1ac]);    /* mov edx, [ebp-0x1ac] */
            ii(0x1013_9878, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_987b, 5); calld(0x1013_ba86, 0x2206);             /* call 0x1013ba86 */
            ii(0x1013_9880, 5); mov(ebx, 0x3100);                       /* mov ebx, 0x3100 */
            ii(0x1013_9885, 6); mov(edx, memd_a32[ss, ebp - 0x1ac]);    /* mov edx, [ebp-0x1ac] */
            ii(0x1013_988b, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_988e, 5); calld(0x1013_ba86, 0x21f3);             /* call 0x1013ba86 */
            ii(0x1013_9893, 5); mov(ebx, 0x3100);                       /* mov ebx, 0x3100 */
            ii(0x1013_9898, 6); mov(edx, memd_a32[ss, ebp - 0x1ac]);    /* mov edx, [ebp-0x1ac] */
            ii(0x1013_989e, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_98a1, 5); calld(0x1013_ba86, 0x21e0);             /* call 0x1013ba86 */
            ii(0x1013_98a6, 6); mov(eax, memd_a32[ss, ebp - 0x1ac]);    /* mov eax, [ebp-0x1ac] */
            ii(0x1013_98ac, 5); calld(Definitions.sys_delete, 0x2_c6b3); /* call 0x10165f64 */
            ii(0x1013_98b1, 7); movsx(edx, memw_a32[ss, ebp - 0x158]);  /* movsx edx, word [ebp-0x158] */
            ii(0x1013_98b8, 5); mov(eax, 0x101c_8178);                  /* mov eax, 0x101c8178 */
            ii(0x1013_98bd, 5); calld(0x1013_8e39, -0xa89);             /* call 0x10138e39 */
            ii(0x1013_98c2, 7); movsx(edx, memw_a32[ss, ebp - 0x158]);  /* movsx edx, word [ebp-0x158] */
            ii(0x1013_98c9, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1013_98ce, 5); calld(0x1013_8e39, -0xa9a);             /* call 0x10138e39 */
            ii(0x1013_98d3, 7); movsx(edx, memw_a32[ss, ebp - 0x158]);  /* movsx edx, word [ebp-0x158] */
            ii(0x1013_98da, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1013_98df, 5); calld(0x1013_8e39, -0xaab);             /* call 0x10138e39 */
            ii(0x1013_98e4, 7); movsx(edx, memw_a32[ss, ebp - 0x158]);  /* movsx edx, word [ebp-0x158] */
            ii(0x1013_98eb, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x1013_98f0, 5); calld(0x1013_8e39, -0xabc);             /* call 0x10138e39 */
            ii(0x1013_98f5, 7); movsx(edx, memw_a32[ss, ebp - 0x158]);  /* movsx edx, word [ebp-0x158] */
            ii(0x1013_98fc, 5); mov(eax, 0x101c_8190);                  /* mov eax, 0x101c8190 */
            ii(0x1013_9901, 5); calld(0x1013_8e39, -0xacd);             /* call 0x10138e39 */
            ii(0x1013_9906, 6); mov(eax, memd_a32[ss, ebp - 0x158]);    /* mov eax, [ebp-0x158] */
            ii(0x1013_990c, 7); cmp(ax, memw_a32[ds, 0x101c_8168]);     /* cmp ax, [0x101c8168] */
            ii(0x1013_9913, 2); if(jnzd(0x1013_991c, 0x7)) goto l_0x1013_991c; /* jnz 0x1013991c */
            ii(0x1013_9915, 7); inc(memw_a32[ds, 0x101c_8168]);         /* inc word [0x101c8168] */
        l_0x1013_991c:
            ii(0x1013_991c, 2); jmpd(0x1013_9969, 0x4b); goto l_0x1013_9969; /* jmp 0x10139969 */
        l_0x1013_991e:
            ii(0x1013_991e, 5); mov(ebx, 0x3100);                       /* mov ebx, 0x3100 */
            ii(0x1013_9923, 6); mov(eax, memd_a32[ss, ebp - 0x180]);    /* mov eax, [ebp-0x180] */
            ii(0x1013_9929, 6); mov(edx, memd_a32[ds, eax + 0x23b]);    /* mov edx, [eax+0x23b] */
            ii(0x1013_992f, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_9932, 5); calld(0x1013_ba86, 0x214f);             /* call 0x1013ba86 */
            ii(0x1013_9937, 5); mov(ebx, 0x3100);                       /* mov ebx, 0x3100 */
            ii(0x1013_993c, 6); mov(eax, memd_a32[ss, ebp - 0x180]);    /* mov eax, [ebp-0x180] */
            ii(0x1013_9942, 6); mov(edx, memd_a32[ds, eax + 0x23f]);    /* mov edx, [eax+0x23f] */
            ii(0x1013_9948, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_994b, 5); calld(0x1013_ba86, 0x2136);             /* call 0x1013ba86 */
            ii(0x1013_9950, 5); mov(ebx, 0x3100);                       /* mov ebx, 0x3100 */
            ii(0x1013_9955, 6); mov(eax, memd_a32[ss, ebp - 0x180]);    /* mov eax, [ebp-0x180] */
            ii(0x1013_995b, 6); mov(edx, memd_a32[ds, eax + 0x243]);    /* mov edx, [eax+0x243] */
            ii(0x1013_9961, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_9964, 5); calld(0x1013_ba86, 0x211d);             /* call 0x1013ba86 */
        l_0x1013_9969:
            ii(0x1013_9969, 2); jmpd(0x1013_9977, 0xc); goto l_0x1013_9977; /* jmp 0x10139977 */
        l_0x1013_996b:
            ii(0x1013_996b, 7); movsx(eax, memw_a32[ss, ebp - 0x158]);  /* movsx eax, word [ebp-0x158] */
            ii(0x1013_9972, 5); calld(0x1013_61f9, -0x377e);            /* call 0x101361f9 */
        l_0x1013_9977:
            ii(0x1013_9977, 6); mov(eax, memd_a32[ss, ebp - 0x180]);    /* mov eax, [ebp-0x180] */
            ii(0x1013_997d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_997f, 3); mov(dl, memb_a32[ds, eax + 0x28]);      /* mov dl, [eax+0x28] */
            ii(0x1013_9982, 7); movsx(eax, memw_a32[ss, ebp - 0x158]);  /* movsx eax, word [ebp-0x158] */
            ii(0x1013_9989, 6); mov(eax, memd_a32[ds, eax + 0x101b_873d]); /* mov eax, [eax+0x101b873d] */
            ii(0x1013_998f, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1013_9992, 5); calld(0x100c_aafc, -0x6_ee9b);          /* call 0x100caafc */
            ii(0x1013_9997, 5); jmpd(0x1013_9651, -0x34b); goto l_0x1013_9651; /* jmp 0x10139651 */
        l_0x1013_999c:
            ii(0x1013_999c, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1013_99a1, 5); calld(0x1013_61f9, -0x37ad);            /* call 0x101361f9 */
            ii(0x1013_99a6, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_99a9, 5); calld(0x1011_797d, -0x2_2031);          /* call 0x1011797d */
            ii(0x1013_99ae, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_99b2, 3); cmp(eax, 0x9);                          /* cmp eax, 0x9 */
            ii(0x1013_99b5, 2); if(jnzd(0x1013_99be, 0x7)) goto l_0x1013_99be; /* jnz 0x101399be */
            ii(0x1013_99b7, 5); calld(0x100a_8ae1, -0x9_0edb);          /* call 0x100a8ae1 */
            ii(0x1013_99bc, 2); jmpd(0x1013_99c6, 0x8); goto l_0x1013_99c6; /* jmp 0x101399c6 */
        l_0x1013_99be:
            ii(0x1013_99be, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_99c1, 5); calld(0x100a_9c33, -0x8_fd93);          /* call 0x100a9c33 */
        l_0x1013_99c6:
            ii(0x1013_99c6, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_99c9, 5); calld(0x1013_ba3c, 0x206e);             /* call 0x1013ba3c */
            ii(0x1013_99ce, 5); calld(0x100f_f5c1, -0x3_a412);          /* call 0x100ff5c1 */
            ii(0x1013_99d3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_99d5, 5); mov(al, memb_a32[ds, 0x101c_3920]);     /* mov al, [0x101c3920] */
            ii(0x1013_99da, 5); calld(0x1007_1cca, -0xc_7d15);          /* call 0x10071cca */
            ii(0x1013_99df, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_99e1, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x1013_99e6, 5); calld(0x1007_6630, -0xc_33bb);          /* call 0x10076630 */
            ii(0x1013_99eb, 9); mov(memw_a32[ss, ebp - 0x170], 0);      /* mov word [ebp-0x170], 0x0 */
            ii(0x1013_99f4, 2); jmpd(0x1013_9a03, 0xd); goto l_0x1013_9a03; /* jmp 0x10139a03 */
        l_0x1013_99f6:
            ii(0x1013_99f6, 6); mov(eax, memd_a32[ss, ebp - 0x170]);    /* mov eax, [ebp-0x170] */
            ii(0x1013_99fc, 7); inc(memw_a32[ss, ebp - 0x170]);         /* inc word [ebp-0x170] */
        l_0x1013_9a03:
            ii(0x1013_9a03, 7); movsx(eax, memw_a32[ss, ebp - 0x170]);  /* movsx eax, word [ebp-0x170] */
            ii(0x1013_9a0a, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1013_9a0d, 6); if(jged(0x1013_9a94, 0x81)) goto l_0x1013_9a94; /* jge 0x10139a94 */
            ii(0x1013_9a13, 7); movsx(eax, memw_a32[ss, ebp - 0x170]);  /* movsx eax, word [ebp-0x170] */
            ii(0x1013_9a1a, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_9a1c, 8); mov(ax, memw_a32[ds, eax + ebp - 0x17c]); /* mov ax, [eax+ebp-0x17c] */
            ii(0x1013_9a24, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1013_9a29, 5); cmp(eax, 0xffff);                       /* cmp eax, 0xffff */
            ii(0x1013_9a2e, 2); if(jzd(0x1013_9a6f, 0x3f)) goto l_0x1013_9a6f; /* jz 0x10139a6f */
            ii(0x1013_9a30, 7); movsx(eax, memw_a32[ss, ebp - 0x170]);  /* movsx eax, word [ebp-0x170] */
            ii(0x1013_9a37, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_9a39, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_9a3b, 8); mov(dx, memw_a32[ds, eax + ebp - 0x17c]); /* mov dx, [eax+ebp-0x17c] */
            ii(0x1013_9a43, 5); mov(eax, 0x101c_39c0);                  /* mov eax, 0x101c39c0 */
            ii(0x1013_9a48, 5); calld(0x1010_3eba, -0x3_5b93);          /* call 0x10103eba */
            ii(0x1013_9a4d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_9a4f, 7); movsx(ebx, memw_a32[ss, ebp - 0x170]);  /* movsx ebx, word [ebp-0x170] */
            ii(0x1013_9a56, 6); imul(ebx, ebx, 0x247);                  /* imul ebx, ebx, 0x247 */
            ii(0x1013_9a5c, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x1013_9a61, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1013_9a63, 5); add(eax, 0xfe);                         /* add eax, 0xfe */
            ii(0x1013_9a68, 5); calld(0x1007_6630, -0xc_343d);          /* call 0x10076630 */
            ii(0x1013_9a6d, 2); jmpd(0x1013_9a8f, 0x20); goto l_0x1013_9a8f; /* jmp 0x10139a8f */
        l_0x1013_9a6f:
            ii(0x1013_9a6f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_9a71, 7); movsx(eax, memw_a32[ss, ebp - 0x170]);  /* movsx eax, word [ebp-0x170] */
            ii(0x1013_9a78, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_9a7e, 5); mov(ebx, 0x101c_a468);                  /* mov ebx, 0x101ca468 */
            ii(0x1013_9a83, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1013_9a85, 5); add(eax, 0xfe);                         /* add eax, 0xfe */
            ii(0x1013_9a8a, 5); calld(0x1007_6630, -0xc_345f);          /* call 0x10076630 */
        l_0x1013_9a8f:
            ii(0x1013_9a8f, 5); jmpd(0x1013_99f6, -0x9e); goto l_0x1013_99f6; /* jmp 0x101399f6 */
        l_0x1013_9a94:
            ii(0x1013_9a94, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_9a96, 6); mov(al, memb_a32[ss, ebp - 0x152]);     /* mov al, [ebp-0x152] */
            ii(0x1013_9a9c, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1013_9a9f, 2); if(jzd(0x1013_9aaa, 0x9)) goto l_0x1013_9aaa; /* jz 0x10139aaa */
            ii(0x1013_9aa1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_9aa4, 6); mov(memw_a32[ds, 0x101c_7120], ax);     /* mov [0x101c7120], ax */
        l_0x1013_9aaa:
            ii(0x1013_9aaa, 7); mov(memb_a32[ds, 0x101c_70f8], 0);      /* mov byte [0x101c70f8], 0x0 */
            ii(0x1013_9ab1, 10); mov(memd_a32[ss, ebp - 0xa4], 0x1);    /* mov dword [ebp-0xa4], 0x1 */
            ii(0x1013_9abb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_9abd, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1013_9ac0, 5); calld(0x1013_b997, 0x1ed2);             /* call 0x1013b997 */
            ii(0x1013_9ac5, 2); jmpd(0x1013_9ad1, 0xa); goto l_0x1013_9ad1; /* jmp 0x10139ad1 */
        //  ii(0x1013_9ac7, 10); Недостижимый код.
        l_0x1013_9ad1:
            ii(0x1013_9ad1, 6); mov(eax, memd_a32[ss, ebp - 0xa4]);     /* mov eax, [ebp-0xa4] */
            ii(0x1013_9ad7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_9ad9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_9ada, 1); popd(edi);                              /* pop edi */
            ii(0x1013_9adb, 1); popd(esi);                              /* pop esi */
            ii(0x1013_9adc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_9add, 1); retd(); return;                         /* ret */
        }
    }
}
