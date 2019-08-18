using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_29fa-c16d8524")]
        public void Method_100b_29fa()
        {
            ii(0x100b_29fa, 5); pushd(0x7c);                            /* push 0x7c */
            ii(0x100b_29ff, 5); calld(Definitions.sys_check_available_stack_size, 0xb_334e); /* call 0x10165d52 */
            ii(0x100b_2a04, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_2a05, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_2a06, 1); pushd(esi);                             /* push esi */
            ii(0x100b_2a07, 1); pushd(edi);                             /* push edi */
            ii(0x100b_2a08, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_2a09, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_2a0b, 6); sub(esp, 0x58);                         /* sub esp, 0x58 */
            ii(0x100b_2a11, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_2a14, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_2a17, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_2a1a, 3); add(edx, 0x15);                         /* add edx, 0x15 */
            ii(0x100b_2a1d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_2a20, 5); calld(0x1008_b4b4, -0x2_7571);          /* call 0x1008b4b4 */
            ii(0x100b_2a25, 2); test(al, al);                           /* test al, al */
            ii(0x100b_2a27, 2); if(jzd(0x100b_2a32, 0x9)) goto l_0x100b_2a32; /* jz 0x100b2a32 */
            ii(0x100b_2a29, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_2a2d, 5); jmpd(0x100b_2df0, 0x3be); goto l_0x100b_2df0; /* jmp 0x100b2df0 */
        l_0x100b_2a32:
            ii(0x100b_2a32, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_2a35, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_2a38, 5); calld(0x1015_2a52, 0xa_0015);           /* call 0x10152a52 */
            ii(0x100b_2a3d, 2); test(al, al);                           /* test al, al */
            ii(0x100b_2a3f, 2); if(jnzd(0x100b_2a4a, 0x9)) goto l_0x100b_2a4a; /* jnz 0x100b2a4a */
            ii(0x100b_2a41, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_2a45, 5); jmpd(0x100b_2df0, 0x3a6); goto l_0x100b_2df0; /* jmp 0x100b2df0 */
        l_0x100b_2a4a:
            ii(0x100b_2a4a, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100b_2a4f, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_2a52, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2a55, 5); calld(0x100a_3671, -0xf3e9);            /* call 0x100a3671 */
            ii(0x100b_2a5a, 2); test(al, al);                           /* test al, al */
            ii(0x100b_2a5c, 2); if(jzd(0x100b_2a67, 0x9)) goto l_0x100b_2a67; /* jz 0x100b2a67 */
            ii(0x100b_2a5e, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100b_2a62, 5); jmpd(0x100b_2df0, 0x389); goto l_0x100b_2df0; /* jmp 0x100b2df0 */
        l_0x100b_2a67:
            ii(0x100b_2a67, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2a6a, 5); calld(0x100b_1e09, -0xc66);             /* call 0x100b1e09 */
            ii(0x100b_2a6f, 2); test(al, al);                           /* test al, al */
            ii(0x100b_2a71, 2); if(jnzd(0x100b_2a7c, 0x9)) goto l_0x100b_2a7c; /* jnz 0x100b2a7c */
            ii(0x100b_2a73, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_2a77, 5); jmpd(0x100b_2df0, 0x374); goto l_0x100b_2df0; /* jmp 0x100b2df0 */
        l_0x100b_2a7c:
            ii(0x100b_2a7c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2a7f, 5); cmp(memw_a32[ds, eax + 0x13], 0x4e);    /* cmp word [eax+0x13], 0x4e */
            ii(0x100b_2a84, 2); if(jnzd(0x100b_2a8f, 0x9)) goto l_0x100b_2a8f; /* jnz 0x100b2a8f */
            ii(0x100b_2a86, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100b_2a8d, 2); jmpd(0x100b_2a96, 0x7); goto l_0x100b_2a96; /* jmp 0x100b2a96 */
        l_0x100b_2a8f:
            ii(0x100b_2a8f, 7); mov(memd_a32[ss, ebp - 0x10], 0x3);     /* mov dword [ebp-0x10], 0x3 */
        l_0x100b_2a96:
            ii(0x100b_2a96, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2a99, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_2a9c, 5); calld(0x1008_a520, -0x2_8581);          /* call 0x1008a520 */
            ii(0x100b_2aa1, 5); calld(0x100b_7d68, 0x52c2);             /* call 0x100b7d68 */
            ii(0x100b_2aa6, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100b_2aaa, 6); if(jzd(0x100b_2c9b, 0x1eb)) goto l_0x100b_2c9b; /* jz 0x100b2c9b */
            ii(0x100b_2ab0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2ab3, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_2ab6, 5); calld(0x1008_a520, -0x2_859b);          /* call 0x1008a520 */
            ii(0x100b_2abb, 5); calld(0x100b_7d68, 0x52a8);             /* call 0x100b7d68 */
            ii(0x100b_2ac0, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x100b_2ac3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_2ac5, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_2ac7, 5); calld(0x1007_66ac, -0x3_c420);          /* call 0x100766ac */
            ii(0x100b_2acc, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100b_2acf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2ad2, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_2ad5, 5); calld(0x1008_a520, -0x2_85ba);          /* call 0x1008a520 */
            ii(0x100b_2ada, 5); calld(0x100a_ca34, -0x60ab);            /* call 0x100aca34 */
            ii(0x100b_2adf, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_2ae2, 5); calld(Definitions.my_ctor_0x101b_4184, -0x3_bff7); /* call 0x10076af0 */
            ii(0x100b_2ae7, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_2aea, 5); calld(0x1007_65d0, -0x3_c51f);          /* call 0x100765d0 */
            ii(0x100b_2aef, 5); calld(0x100a_2edb, -0xfc19);            /* call 0x100a2edb */
            ii(0x100b_2af4, 2); test(al, al);                           /* test al, al */
            ii(0x100b_2af6, 2); if(jnzd(0x100b_2b0b, 0x13)) goto l_0x100b_2b0b; /* jnz 0x100b2b0b */
            ii(0x100b_2af8, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_2afc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_2afe, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_2b01, 5); calld(0x1007_5f2c, -0x3_cbda);          /* call 0x10075f2c */
            ii(0x100b_2b06, 5); jmpd(0x100b_2df0, 0x2e5); goto l_0x100b_2df0; /* jmp 0x100b2df0 */
        l_0x100b_2b0b:
            ii(0x100b_2b0b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_2b0e, 5); calld(0x1008_abbc, -0x2_7f57);          /* call 0x1008abbc */
            ii(0x100b_2b13, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_2b15, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2b18, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_2b1b, 5); calld(0x1008_abbc, -0x2_7f64);          /* call 0x1008abbc */
            ii(0x100b_2b20, 5); calld(0x100a_601a, -0xcb0b);            /* call 0x100a601a */
            ii(0x100b_2b25, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x100b_2b29, 2); if(jgd(0x100b_2b58, 0x2d)) goto l_0x100b_2b58; /* jg 0x100b2b58 */
            ii(0x100b_2b2b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2b2e, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_2b31, 5); calld(0x1008_a520, -0x2_8616);          /* call 0x1008a520 */
            ii(0x100b_2b36, 5); calld(0x100b_7d68, 0x522d);             /* call 0x100b7d68 */
            ii(0x100b_2b3b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_2b3d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2b40, 5); calld(0x100b_2444, -0x701);             /* call 0x100b2444 */
            ii(0x100b_2b45, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100b_2b49, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_2b4b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_2b4e, 5); calld(0x1007_5f2c, -0x3_cc27);          /* call 0x10075f2c */
            ii(0x100b_2b53, 5); jmpd(0x100b_2df0, 0x298); goto l_0x100b_2df0; /* jmp 0x100b2df0 */
        l_0x100b_2b58:
            ii(0x100b_2b58, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2b5b, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_2b5e, 5); calld(0x1007_6574, -0x3_c5ef);          /* call 0x10076574 */
            ii(0x100b_2b63, 5); cmp(memw_a32[ds, eax + 0x8], 0x4e);     /* cmp word [eax+0x8], 0x4e */
            ii(0x100b_2b68, 2); if(jzd(0x100b_2b7c, 0x12)) goto l_0x100b_2b7c; /* jz 0x100b2b7c */
            ii(0x100b_2b6a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2b6d, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_2b70, 5); calld(0x1007_6574, -0x3_c601);          /* call 0x10076574 */
            ii(0x100b_2b75, 5); cmp(memw_a32[ds, eax + 0x8], 0x41);     /* cmp word [eax+0x8], 0x41 */
            ii(0x100b_2b7a, 2); if(jnzd(0x100b_2b9c, 0x20)) goto l_0x100b_2b9c; /* jnz 0x100b2b9c */
        l_0x100b_2b7c:
            ii(0x100b_2b7c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_2b7f, 5); calld(0x1007_6574, -0x3_c610);          /* call 0x10076574 */
            ii(0x100b_2b84, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x100b_2b88, 4); mov(memw_a32[ss, ebp - 0x18], ax);      /* mov [ebp-0x18], ax */
            ii(0x100b_2b8c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_2b8f, 5); calld(0x1007_6574, -0x3_c620);          /* call 0x10076574 */
            ii(0x100b_2b94, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x100b_2b98, 4); mov(memw_a32[ss, ebp - 0x16], ax);      /* mov [ebp-0x16], ax */
        l_0x100b_2b9c:
            ii(0x100b_2b9c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2b9f, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_2ba2, 5); calld(0x1007_6574, -0x3_c633);          /* call 0x10076574 */
            ii(0x100b_2ba7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_2ba9, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100b_2bac, 4); sub(ax, memw_a32[ds, edx + 0x1a]);      /* sub ax, [edx+0x1a] */
            ii(0x100b_2bb0, 4); mov(memw_a32[ss, ebp - 0x1c], ax);      /* mov [ebp-0x1c], ax */
            ii(0x100b_2bb4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2bb7, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_2bba, 5); calld(0x1007_6574, -0x3_c64b);          /* call 0x10076574 */
            ii(0x100b_2bbf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_2bc1, 3); mov(eax, memd_a32[ss, ebp - 0x16]);     /* mov eax, [ebp-0x16] */
            ii(0x100b_2bc4, 4); sub(ax, memw_a32[ds, edx + 0x1c]);      /* sub ax, [edx+0x1c] */
            ii(0x100b_2bc8, 4); mov(memw_a32[ss, ebp - 0x1a], ax);      /* mov [ebp-0x1a], ax */
            ii(0x100b_2bcc, 4); movsx(edx, memw_a32[ss, ebp - 0x1a]);   /* movsx edx, word [ebp-0x1a] */
            ii(0x100b_2bd0, 4); movsx(eax, memw_a32[ss, ebp - 0x1a]);   /* movsx eax, word [ebp-0x1a] */
            ii(0x100b_2bd4, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100b_2bd7, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x100b_2bd9, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100b_2bdd, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100b_2be1, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100b_2be4, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x100b_2be6, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100b_2bea, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x100b_2bec, 2); if(jgd(0x100b_2c01, 0x13)) goto l_0x100b_2c01; /* jg 0x100b2c01 */
            ii(0x100b_2bee, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_2bf2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_2bf4, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_2bf7, 5); calld(0x1007_5f2c, -0x3_ccd0);          /* call 0x10075f2c */
            ii(0x100b_2bfc, 5); jmpd(0x100b_2df0, 0x1ef); goto l_0x100b_2df0; /* jmp 0x100b2df0 */
        l_0x100b_2c01:
            ii(0x100b_2c01, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x100b_2c06, 5); calld(Definitions.sys_new, 0xb_31f5);   /* call 0x10165e00 */
            ii(0x100b_2c0b, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100b_2c0e, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100b_2c11, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100b_2c14, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x100b_2c18, 2); if(jzd(0x100b_2c59, 0x3f)) goto l_0x100b_2c59; /* jz 0x100b2c59 */
            ii(0x100b_2c1a, 5); mov(eax, 0x100b_2dfb);                  /* mov eax, 0x100b2dfb */
            ii(0x100b_2c1f, 1); pushd(eax);                             /* push eax */
            ii(0x100b_2c20, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100b_2c23, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_2c26, 5); calld(0x1007_5e64, -0x3_cdc7);          /* call 0x10075e64 */
            ii(0x100b_2c2b, 1); pushd(eax);                             /* push eax */
            ii(0x100b_2c2c, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x100b_2c31, 1); pushd(eax);                             /* push eax */
            ii(0x100b_2c32, 4); movsx(ecx, memw_a32[ss, ebp - 0x10]);   /* movsx ecx, word [ebp-0x10] */
            ii(0x100b_2c36, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100b_2c39, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2c3c, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_2c3f, 5); calld(0x1007_65d0, -0x3_c674);          /* call 0x100765d0 */
            ii(0x100b_2c44, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_2c46, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100b_2c49, 5); calld(0x100a_c220, -0x6a2e);            /* call 0x100ac220 */
            ii(0x100b_2c4e, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100b_2c51, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100b_2c54, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100b_2c57, 2); jmpd(0x100b_2c5f, 0x6); goto l_0x100b_2c5f; /* jmp 0x100b2c5f */
        l_0x100b_2c59:
            ii(0x100b_2c59, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100b_2c5c, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
        l_0x100b_2c5f:
            ii(0x100b_2c5f, 3); mov(edx, memd_a32[ss, ebp - 0x30]);     /* mov edx, [ebp-0x30] */
            ii(0x100b_2c62, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x100b_2c65, 5); calld(0x1008_b060, -0x2_7c0a);          /* call 0x1008b060 */
            ii(0x100b_2c6a, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x100b_2c6d, 5); calld(0x1008_af84, -0x2_7cee);          /* call 0x1008af84 */
            ii(0x100b_2c72, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_2c74, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_2c79, 5); calld(0x100a_4d50, -0xdf2e);            /* call 0x100a4d50 */
            ii(0x100b_2c7e, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100b_2c82, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_2c84, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x100b_2c87, 5); calld(0x1008_8b7c, -0x2_a110);          /* call 0x10088b7c */
            ii(0x100b_2c8c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_2c8e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_2c91, 5); calld(0x1007_5f2c, -0x3_cd6a);          /* call 0x10075f2c */
            ii(0x100b_2c96, 5); jmpd(0x100b_2df0, 0x155); goto l_0x100b_2df0; /* jmp 0x100b2df0 */
        l_0x100b_2c9b:
            ii(0x100b_2c9b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_2c9e, 3); mov(eax, memd_a32[ds, eax + 0x50]);     /* mov eax, [eax+0x50] */
            ii(0x100b_2ca1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_2ca4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_2ca6, 2); if(jled(0x100b_2cbe, 0x16)) goto l_0x100b_2cbe; /* jle 0x100b2cbe */
            ii(0x100b_2ca8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2cab, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_2cae, 5); calld(0x1008_a520, -0x2_8793);          /* call 0x1008a520 */
            ii(0x100b_2cb3, 5); calld(0x100b_7d68, 0x50b0);             /* call 0x100b7d68 */
            ii(0x100b_2cb8, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100b_2cbc, 2); if(jzd(0x100b_2cc3, 0x5)) goto l_0x100b_2cc3; /* jz 0x100b2cc3 */
        l_0x100b_2cbe:
            ii(0x100b_2cbe, 5); jmpd(0x100b_2dec, 0x129); goto l_0x100b_2dec; /* jmp 0x100b2dec */
        l_0x100b_2cc3:
            ii(0x100b_2cc3, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x100b_2cc6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2cc9, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_2ccc, 5); calld(0x1008_a520, -0x2_87b1);          /* call 0x1008a520 */
            ii(0x100b_2cd1, 5); calld(0x100b_7da0, 0x50ca);             /* call 0x100b7da0 */
            ii(0x100b_2cd6, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_2cd9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_2cdb, 2); if(jged(0x100b_2ce6, 0x9)) goto l_0x100b_2ce6; /* jge 0x100b2ce6 */
            ii(0x100b_2cdd, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_2ce1, 5); jmpd(0x100b_2df0, 0x10a); goto l_0x100b_2df0; /* jmp 0x100b2df0 */
        l_0x100b_2ce6:
            ii(0x100b_2ce6, 3); lea(edx, ebp - 0x3c);                   /* lea edx, [ebp-0x3c] */
            ii(0x100b_2ce9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2cec, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_2cef, 5); calld(0x1008_a520, -0x2_87d4);          /* call 0x1008a520 */
            ii(0x100b_2cf4, 5); calld(0x100b_7da0, 0x50a7);             /* call 0x100b7da0 */
            ii(0x100b_2cf9, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100b_2cfb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2cfe, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_2d01, 5); calld(0x1007_6574, -0x3_c792);          /* call 0x10076574 */
            ii(0x100b_2d06, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100b_2d09, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_2d0c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2d0f, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_2d12, 5); calld(0x1007_6574, -0x3_c7a3);          /* call 0x10076574 */
            ii(0x100b_2d17, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100b_2d1a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_2d1d, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100b_2d20, 5); calld(0x1007_6aac, -0x3_c279);          /* call 0x10076aac */
            ii(0x100b_2d25, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x100b_2d27, 5); calld(0x100a_5fca, -0xcd62);            /* call 0x100a5fca */
            ii(0x100b_2d2c, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x100b_2d30, 2); if(jgd(0x100b_2d55, 0x23)) goto l_0x100b_2d55; /* jg 0x100b2d55 */
            ii(0x100b_2d32, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2d35, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_2d38, 5); calld(0x1008_a520, -0x2_881d);          /* call 0x1008a520 */
            ii(0x100b_2d3d, 5); calld(0x100b_7d68, 0x5026);             /* call 0x100b7d68 */
            ii(0x100b_2d42, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_2d44, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2d47, 5); calld(0x100b_277f, -0x5cd);             /* call 0x100b277f */
            ii(0x100b_2d4c, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100b_2d50, 5); jmpd(0x100b_2df0, 0x9b); goto l_0x100b_2df0; /* jmp 0x100b2df0 */
        l_0x100b_2d55:
            ii(0x100b_2d55, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x100b_2d5a, 5); calld(Definitions.sys_new, 0xb_30a1);   /* call 0x10165e00 */
            ii(0x100b_2d5f, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100b_2d62, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x100b_2d65, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x100b_2d68, 4); cmp(memd_a32[ss, ebp - 0x48], 0);       /* cmp dword [ebp-0x48], 0x0 */
            ii(0x100b_2d6c, 2); if(jzd(0x100b_2db7, 0x49)) goto l_0x100b_2db7; /* jz 0x100b2db7 */
            ii(0x100b_2d6e, 5); mov(eax, 0x100b_2e78);                  /* mov eax, 0x100b2e78 */
            ii(0x100b_2d73, 1); pushd(eax);                             /* push eax */
            ii(0x100b_2d74, 3); lea(edx, ebp - 0x4c);                   /* lea edx, [ebp-0x4c] */
            ii(0x100b_2d77, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2d7a, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_2d7d, 5); calld(0x1008_a520, -0x2_8862);          /* call 0x1008a520 */
            ii(0x100b_2d82, 5); calld(0x100b_7da0, 0x5019);             /* call 0x100b7da0 */
            ii(0x100b_2d87, 1); pushd(eax);                             /* push eax */
            ii(0x100b_2d88, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x100b_2d8d, 1); pushd(eax);                             /* push eax */
            ii(0x100b_2d8e, 4); movsx(ecx, memw_a32[ss, ebp - 0x10]);   /* movsx ecx, word [ebp-0x10] */
            ii(0x100b_2d92, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100b_2d95, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2d98, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_2d9b, 5); calld(0x1007_65d0, -0x3_c7d0);          /* call 0x100765d0 */
            ii(0x100b_2da0, 3); mov(esi, memd_a32[ss, ebp - 0x44]);     /* mov esi, [ebp-0x44] */
            ii(0x100b_2da3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_2da5, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100b_2da7, 5); calld(0x100a_c220, -0x6b8c);            /* call 0x100ac220 */
            ii(0x100b_2dac, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x100b_2daf, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x100b_2db2, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x100b_2db5, 2); jmpd(0x100b_2dbd, 0x6); goto l_0x100b_2dbd; /* jmp 0x100b2dbd */
        l_0x100b_2db7:
            ii(0x100b_2db7, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100b_2dba, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
        l_0x100b_2dbd:
            ii(0x100b_2dbd, 3); mov(edx, memd_a32[ss, ebp - 0x54]);     /* mov edx, [ebp-0x54] */
            ii(0x100b_2dc0, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x100b_2dc3, 5); calld(0x1008_b060, -0x2_7d68);          /* call 0x1008b060 */
            ii(0x100b_2dc8, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x100b_2dcb, 5); calld(0x1008_af84, -0x2_7e4c);          /* call 0x1008af84 */
            ii(0x100b_2dd0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_2dd2, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_2dd7, 5); calld(0x100a_4d50, -0xe08c);            /* call 0x100a4d50 */
            ii(0x100b_2ddc, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100b_2de0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_2de2, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x100b_2de5, 5); calld(0x1008_8b7c, -0x2_a26e);          /* call 0x10088b7c */
            ii(0x100b_2dea, 2); jmpd(0x100b_2df0, 0x4); goto l_0x100b_2df0; /* jmp 0x100b2df0 */
        l_0x100b_2dec:
            ii(0x100b_2dec, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x100b_2df0:
            ii(0x100b_2df0, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100b_2df3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_2df5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_2df6, 1); popd(edi);                              /* pop edi */
            ii(0x100b_2df7, 1); popd(esi);                              /* pop esi */
            ii(0x100b_2df8, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_2df9, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_2dfa, 1); retd(); return;                         /* ret */
        }
    }
}
