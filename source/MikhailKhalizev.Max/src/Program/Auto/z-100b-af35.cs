using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a31ae8d1-82b1-44b0-b596-a40c17afbbaf")]
        public void Method_100b_af35()
        {
            ii(0x100b_af35, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x100b_af3a, 5); calld(Definitions.sys_check_available_stack_size, 0xa_ae13); /* call 0x10165d52 */
            ii(0x100b_af3f, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_af40, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_af41, 1); pushd(esi);                             /* push esi */
            ii(0x100b_af42, 1); pushd(edi);                             /* push edi */
            ii(0x100b_af43, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_af44, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_af46, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100b_af4c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_af4f, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_af52, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_af55, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100b_af58, 5); calld(0x1007_6b90, -0x4_43cd);          /* call 0x10076b90 */
            ii(0x100b_af5d, 1); cwde();                                 /* cwde */
            ii(0x100b_af5e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_af60, 2); if(jnzd(0x100b_af99, 0x37)) goto l_0x100b_af99; /* jnz 0x100baf99 */
            ii(0x100b_af62, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x100b_af68, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_af6b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100b_af6d, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100b_af70, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100b_af72, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100b_af74, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_af77, 4); mov(memw_a32[ds, edx + 0x77], ax);      /* mov [edx+0x77], ax */
            ii(0x100b_af7b, 6); mov(edx, memd_a32[ds, 0x101c_8172]);    /* mov edx, [0x101c8172] */
            ii(0x100b_af81, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_af84, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100b_af86, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100b_af89, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100b_af8b, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100b_af8d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_af90, 4); mov(memw_a32[ds, edx + 0x79], ax);      /* mov [edx+0x79], ax */
            ii(0x100b_af94, 5); jmpd(0x100b_b08f, 0xf6); goto l_0x100b_b08f; /* jmp 0x100bb08f */
        l_0x100b_af99:
            ii(0x100b_af99, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100b_afa0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_afa3, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100b_afa6, 5); calld(0x100c_b000, 0x1_0055);           /* call 0x100cb000 */
            ii(0x100b_afab, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x100b_afae, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_afb0, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_afb2, 5); calld(0x1008_a1a4, -0x3_0e13);          /* call 0x1008a1a4 */
            ii(0x100b_afb7, 2); jmpd(0x100b_afc1, 0x8); goto l_0x100b_afc1; /* jmp 0x100bafc1 */
        l_0x100b_afb9:
            ii(0x100b_afb9, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_afbc, 5); calld(0x1007_6bf8, -0x4_43c9);          /* call 0x10076bf8 */
        l_0x100b_afc1:
            ii(0x100b_afc1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_afc3, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_afc6, 5); calld(0x1013_ad71, 0x7_fda6);           /* call 0x1013ad71 */
            ii(0x100b_afcb, 2); test(al, al);                           /* test al, al */
            ii(0x100b_afcd, 6); if(jzd(0x100b_b06d, 0x9a)) goto l_0x100b_b06d; /* jz 0x100bb06d */
            ii(0x100b_afd3, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_afd6, 5); calld(0x1008_a0f8, -0x3_0ee3);          /* call 0x1008a0f8 */
            ii(0x100b_afdb, 5); calld(0x1008_a370, -0x3_0c70);          /* call 0x1008a370 */
            ii(0x100b_afe0, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100b_afe3, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100b_afe7, 2); if(jzd(0x100b_aff3, 0xa)) goto l_0x100b_aff3; /* jz 0x100baff3 */
            ii(0x100b_afe9, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100b_afec, 5); cmp(memw_a32[ds, eax + 0x8], 0x28);     /* cmp word [eax+0x8], 0x28 */
            ii(0x100b_aff1, 2); if(jnzd(0x100b_aff5, 0x2)) goto l_0x100b_aff5; /* jnz 0x100baff5 */
        l_0x100b_aff3:
            ii(0x100b_aff3, 2); jmpd(0x100b_b004, 0xf); goto l_0x100b_b004; /* jmp 0x100bb004 */
        l_0x100b_aff5:
            ii(0x100b_aff5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_aff8, 5); calld(0x1008_a370, -0x3_0c8d);          /* call 0x1008a370 */
            ii(0x100b_affd, 5); cmp(memw_a32[ds, eax + 0x8], 0x28);     /* cmp word [eax+0x8], 0x28 */
            ii(0x100b_b002, 2); if(jzd(0x100b_b068, 0x64)) goto l_0x100b_b068; /* jz 0x100bb068 */
        l_0x100b_b004:
            ii(0x100b_b004, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100b_b007, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_b00a, 5); calld(0x1008_a0f8, -0x3_0f17);          /* call 0x1008a0f8 */
            ii(0x100b_b00f, 5); calld(0x100b_8e63, -0x21b1);            /* call 0x100b8e63 */
            ii(0x100b_b014, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_b016, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_b019, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_b01c, 5); calld(0x1007_5e64, -0x4_51bd);          /* call 0x10075e64 */
            ii(0x100b_b021, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100b_b023, 5); calld(0x100a_5fca, -0x1_505e);          /* call 0x100a5fca */
            ii(0x100b_b028, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100b_b02b, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100b_b02f, 2); if(jzd(0x100b_b04c, 0x1b)) goto l_0x100b_b04c; /* jz 0x100bb04c */
            ii(0x100b_b031, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100b_b034, 5); cmp(memw_a32[ds, eax + 0x8], 0x28);     /* cmp word [eax+0x8], 0x28 */
            ii(0x100b_b039, 2); if(jnzd(0x100b_b04a, 0xf)) goto l_0x100b_b04a; /* jnz 0x100bb04a */
            ii(0x100b_b03b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_b03e, 5); calld(0x1008_a370, -0x3_0cd3);          /* call 0x1008a370 */
            ii(0x100b_b043, 5); cmp(memw_a32[ds, eax + 0x8], 0x28);     /* cmp word [eax+0x8], 0x28 */
            ii(0x100b_b048, 2); if(jnzd(0x100b_b04c, 0x2)) goto l_0x100b_b04c; /* jnz 0x100bb04c */
        l_0x100b_b04a:
            ii(0x100b_b04a, 2); jmpd(0x100b_b04e, 0x2); goto l_0x100b_b04e; /* jmp 0x100bb04e */
        l_0x100b_b04c:
            ii(0x100b_b04c, 2); jmpd(0x100b_b057, 0x9); goto l_0x100b_b057; /* jmp 0x100bb057 */
        l_0x100b_b04e:
            ii(0x100b_b04e, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100b_b051, 4); cmp(ax, memw_a32[ss, ebp - 0x24]);      /* cmp ax, [ebp-0x24] */
            ii(0x100b_b055, 2); if(jged(0x100b_b068, 0x11)) goto l_0x100b_b068; /* jge 0x100bb068 */
        l_0x100b_b057:
            ii(0x100b_b057, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_b05a, 5); calld(0x1008_a12c, -0x3_0f33);          /* call 0x1008a12c */
            ii(0x100b_b05f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_b062, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100b_b065, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
        l_0x100b_b068:
            ii(0x100b_b068, 5); jmpd(0x100b_afb9, -0xb4); goto l_0x100b_afb9; /* jmp 0x100bafb9 */
        l_0x100b_b06d:
            ii(0x100b_b06d, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100b_b070, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_b073, 5); calld(0x100b_8e63, -0x2215);            /* call 0x100b8e63 */
            ii(0x100b_b078, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_b07a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_b07d, 3); add(eax, 0x77);                         /* add eax, 0x77 */
            ii(0x100b_b080, 5); calld(0x1008_8b44, -0x3_2541);          /* call 0x10088b44 */
            ii(0x100b_b085, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_b087, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_b08a, 5); calld(0x1008_8e4c, -0x3_2243);          /* call 0x10088e4c */
        l_0x100b_b08f:
            ii(0x100b_b08f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_b091, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_b092, 1); popd(edi);                              /* pop edi */
            ii(0x100b_b093, 1); popd(esi);                              /* pop esi */
            ii(0x100b_b094, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_b095, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_b096, 1); retd(); return;                         /* ret */
        }
    }
}
