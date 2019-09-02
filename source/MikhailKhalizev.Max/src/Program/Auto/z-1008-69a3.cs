using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_69a3-31ac8363")]
        public void Method_1008_69a3()
        {
            ii(0x1008_69a3, 5); push(0x60);                             /* push 0x60 */
            ii(0x1008_69a8, 5); call(Definitions.sys_check_available_stack_size, 0xd_f3a5); /* call 0x10165d52 */
            ii(0x1008_69ad, 1); push(ebx);                              /* push ebx */
            ii(0x1008_69ae, 1); push(ecx);                              /* push ecx */
            ii(0x1008_69af, 1); push(edx);                              /* push edx */
            ii(0x1008_69b0, 1); push(esi);                              /* push esi */
            ii(0x1008_69b1, 1); push(edi);                              /* push edi */
            ii(0x1008_69b2, 1); push(ebp);                              /* push ebp */
            ii(0x1008_69b3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_69b5, 6); sub(esp, 0x44);                         /* sub esp, 0x44 */
            ii(0x1008_69bb, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_69be, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_69c1, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_69c4, 5); call(0x1008_9d08, 0x333f);              /* call 0x10089d08 */
            ii(0x1008_69c9, 3); lea(ebx, memd[ss, ebp - 0x18]);         /* lea ebx, [ebp-0x18] */
            ii(0x1008_69cc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_69ce, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_69d0, 5); call(0x1008_9be4, 0x320f);              /* call 0x10089be4 */
            ii(0x1008_69d5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_69d8, 4); or(memb[ds, eax + 0x3a], 0x40);         /* or byte [eax+0x3a], 0x40 */
            ii(0x1008_69dc, 3); lea(edx, memd[ss, ebp - 0x20]);         /* lea edx, [ebp-0x20] */
            ii(0x1008_69df, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_69e2, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1008_69e5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_69e8, 5); call(0x1007_8137, -0xe8b6);             /* call 0x10078137 */
            ii(0x1008_69ed, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_69f0, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1008_69f3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_69f6, 6); imul(edx, eax, 0xc5);                   /* imul edx, eax, 0xc5 */
            ii(0x1008_69fc, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x1008_6a01, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_6a03, 5); call(0x1008_a094, 0x368c);              /* call 0x1008a094 */
            ii(0x1008_6a08, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_6a0b, 2); jmp(0x1008_6a15, 8); goto l_0x1008_6a15; /* jmp 0x10086a15 */
        l_0x1008_6a0d:
            ii(0x1008_6a0d, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_6a10, 5); call(0x1007_6bf8, -0xfe1d);             /* call 0x10076bf8 */
        l_0x1008_6a15:
            ii(0x1008_6a15, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_6a17, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_6a1a, 5); call(0x1013_ad71, 0xb_4352);            /* call 0x1013ad71 */
            ii(0x1008_6a1f, 2); test(al, al);                           /* test al, al */
            ii(0x1008_6a21, 2); if(jz(0x1008_6a39, 0x16)) goto l_0x1008_6a39; /* jz 0x10086a39 */
            ii(0x1008_6a23, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_6a25, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_6a28, 5); call(0x1008_9acc, 0x309f);              /* call 0x10089acc */
            ii(0x1008_6a2d, 5); call(0x1008_9f38, 0x3506);              /* call 0x10089f38 */
            ii(0x1008_6a32, 5); call(0x100b_8e30, 0x3_23f9);            /* call 0x100b8e30 */
            ii(0x1008_6a37, 2); jmp(0x1008_6a0d, -0x2c); goto l_0x1008_6a0d; /* jmp 0x10086a0d */
        l_0x1008_6a39:
            ii(0x1008_6a39, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_6a3c, 6); mov(memw[ds, eax + 0xd], 0x1f00);       /* mov word [eax+0xd], 0x1f00 */
            ii(0x1008_6a42, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_6a45, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x1008_6a48, 5); call(0x1008_9d08, 0x32bb);              /* call 0x10089d08 */
            ii(0x1008_6a4d, 3); lea(ebx, memd[ss, ebp - 0x18]);         /* lea ebx, [ebp-0x18] */
            ii(0x1008_6a50, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_6a52, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_6a54, 5); call(0x1008_9b68, 0x310f);              /* call 0x10089b68 */
            ii(0x1008_6a59, 2); jmp(0x1008_6a63, 8); goto l_0x1008_6a63; /* jmp 0x10086a63 */
        l_0x1008_6a5b:
            ii(0x1008_6a5b, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_6a5e, 5); call(0x1007_6bf8, -0xfe6b);             /* call 0x10076bf8 */
        l_0x1008_6a63:
            ii(0x1008_6a63, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_6a65, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_6a68, 5); call(0x1013_ad71, 0xb_4304);            /* call 0x1013ad71 */
            ii(0x1008_6a6d, 2); test(al, al);                           /* test al, al */
            ii(0x1008_6a6f, 6); if(jz(0x1008_6b9d, 0x128)) goto l_0x1008_6b9d; /* jz 0x10086b9d */
            ii(0x1008_6a75, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_6a78, 5); call(0x1008_9acc, 0x304f);              /* call 0x10089acc */
            ii(0x1008_6a7d, 5); call(0x1008_9f70, 0x34ee);              /* call 0x10089f70 */
            ii(0x1008_6a82, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1008_6a85, 4); cmp(memd[ss, ebp - 0x24], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1008_6a89, 6); if(jz(0x1008_6b98, 0x109)) goto l_0x1008_6b98; /* jz 0x10086b98 */
            ii(0x1008_6a8f, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_6a93, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1008_6a96, 4); test(memb[ds, eax + 0x12], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x1008_6a9a, 2); if(jnz(0x1008_6aaa, 0xe)) goto l_0x1008_6aaa; /* jnz 0x10086aaa */
            ii(0x1008_6a9c, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1008_6a9f, 5); cmp(memw[ds, eax + 8], 0x31);           /* cmp word [eax+0x8], 0x31 */
            ii(0x1008_6aa4, 6); if(jnz(0x1008_6b2e, 0x84)) goto l_0x1008_6b2e; /* jnz 0x10086b2e */
        l_0x1008_6aaa:
            ii(0x1008_6aaa, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1008_6aad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_6aaf, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1008_6ab2, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1008_6ab6, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_6ab8, 2); if(jnz(0x1008_6ac0, 6)) goto l_0x1008_6ac0; /* jnz 0x10086ac0 */
            ii(0x1008_6aba, 4); mov(memb[ss, ebp - 0x28], 1);           /* mov byte [ebp-0x28], 0x1 */
            ii(0x1008_6abe, 2); jmp(0x1008_6ac4, 4); goto l_0x1008_6ac4; /* jmp 0x10086ac4 */
        l_0x1008_6ac0:
            ii(0x1008_6ac0, 4); mov(memb[ss, ebp - 0x28], 0);           /* mov byte [ebp-0x28], 0x0 */
        l_0x1008_6ac4:
            ii(0x1008_6ac4, 3); mov(al, memb[ss, ebp - 0x28]);          /* mov al, [ebp-0x28] */
            ii(0x1008_6ac7, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x1008_6aca, 4); cmp(memb[ss, ebp - 8], 0);              /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1008_6ace, 2); if(jz(0x1008_6ae0, 0x10)) goto l_0x1008_6ae0; /* jz 0x10086ae0 */
            ii(0x1008_6ad0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_6ad3, 3); mov(eax, memd[ds, eax + 0xb]);          /* mov eax, [eax+0xb] */
            ii(0x1008_6ad6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_6ad9, 5); cmp(eax, 0x1700);                       /* cmp eax, 0x1700 */
            ii(0x1008_6ade, 2); if(jg(0x1008_6ae2, 2)) goto l_0x1008_6ae2; /* jg 0x10086ae2 */
        l_0x1008_6ae0:
            ii(0x1008_6ae0, 2); jmp(0x1008_6af8, 0x16); goto l_0x1008_6af8; /* jmp 0x10086af8 */
        l_0x1008_6ae2:
            ii(0x1008_6ae2, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1008_6ae5, 5); cmp(memw[ds, eax + 8], 0x1e);           /* cmp word [eax+0x8], 0x1e */
            ii(0x1008_6aea, 2); if(jz(0x1008_6af6, 0xa)) goto l_0x1008_6af6; /* jz 0x10086af6 */
            ii(0x1008_6aec, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1008_6aef, 5); cmp(memw[ds, eax + 8], 0x28);           /* cmp word [eax+0x8], 0x28 */
            ii(0x1008_6af4, 2); if(jnz(0x1008_6af8, 2)) goto l_0x1008_6af8; /* jnz 0x10086af8 */
        l_0x1008_6af6:
            ii(0x1008_6af6, 2); jmp(0x1008_6afa, 2); goto l_0x1008_6afa; /* jmp 0x10086afa */
        l_0x1008_6af8:
            ii(0x1008_6af8, 2); jmp(0x1008_6b21, 0x27); goto l_0x1008_6b21; /* jmp 0x10086b21 */
        l_0x1008_6afa:
            ii(0x1008_6afa, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_6afd, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1008_6b00, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_6b03, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1008_6b09, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1008_6b0d, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x1008_6b13, 6); mov(edx, memd[ds, edx + 0x101c_a550]);  /* mov edx, [edx+0x101ca550] */
            ii(0x1008_6b19, 6); cmp(edx, memd[ds, eax + 0x101c_a550]);  /* cmp edx, [eax+0x101ca550] */
            ii(0x1008_6b1f, 2); if(jg(0x1008_6b23, 2)) goto l_0x1008_6b23; /* jg 0x10086b23 */
        l_0x1008_6b21:
            ii(0x1008_6b21, 2); jmp(0x1008_6b2c, 9); goto l_0x1008_6b2c; /* jmp 0x10086b2c */
        l_0x1008_6b23:
            ii(0x1008_6b23, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_6b26, 6); mov(memw[ds, eax + 0xd], 0x1700);       /* mov word [eax+0xd], 0x1700 */
        l_0x1008_6b2c:
            ii(0x1008_6b2c, 2); jmp(0x1008_6b69, 0x3b); goto l_0x1008_6b69; /* jmp 0x10086b69 */
        l_0x1008_6b2e:
            ii(0x1008_6b2e, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1008_6b31, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1008_6b34, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_6b39, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x1008_6b3c, 2); if(jnz(0x1008_6b44, 6)) goto l_0x1008_6b44; /* jnz 0x10086b44 */
            ii(0x1008_6b3e, 4); mov(memb[ss, ebp - 8], 1);              /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_6b42, 2); jmp(0x1008_6b69, 0x25); goto l_0x1008_6b69; /* jmp 0x10086b69 */
        l_0x1008_6b44:
            ii(0x1008_6b44, 3); lea(ebx, memd[ss, ebp - 0x20]);         /* lea ebx, [ebp-0x20] */
            ii(0x1008_6b47, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_6b4a, 3); mov(edx, memd[ds, eax + 7]);            /* mov edx, [eax+0x7] */
            ii(0x1008_6b4d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_6b50, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1008_6b53, 5); call(0x1007_76f3, -0xf465);             /* call 0x100776f3 */
            ii(0x1008_6b58, 2); test(al, al);                           /* test al, al */
            ii(0x1008_6b5a, 2); if(jz(0x1008_6b69, 0xd)) goto l_0x1008_6b69; /* jz 0x10086b69 */
            ii(0x1008_6b5c, 4); mov(memb[ss, ebp - 8], 1);              /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_6b60, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_6b63, 6); mov(memw[ds, eax + 0xd], 0x1000);       /* mov word [eax+0xd], 0x1000 */
        l_0x1008_6b69:
            ii(0x1008_6b69, 4); cmp(memb[ss, ebp - 8], 0);              /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1008_6b6d, 2); if(jz(0x1008_6b86, 0x17)) goto l_0x1008_6b86; /* jz 0x10086b86 */
            ii(0x1008_6b6f, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_6b72, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_6b75, 5); call(0x1008_9acc, 0x2f52);              /* call 0x10089acc */
            ii(0x1008_6b7a, 5); call(0x1008_9f38, 0x33b9);              /* call 0x10089f38 */
            ii(0x1008_6b7f, 5); call(0x100b_8e30, 0x3_22ac);            /* call 0x100b8e30 */
            ii(0x1008_6b84, 2); jmp(0x1008_6b98, 0x12); goto l_0x1008_6b98; /* jmp 0x10086b98 */
        l_0x1008_6b86:
            ii(0x1008_6b86, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_6b89, 5); call(0x1008_9b00, 0x2f72);              /* call 0x10089b00 */
            ii(0x1008_6b8e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_6b90, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_6b93, 5); call(0x1008_6950, -0x248);              /* call 0x10086950 */
        l_0x1008_6b98:
            ii(0x1008_6b98, 5); jmp(0x1008_6a5b, -0x142); goto l_0x1008_6a5b; /* jmp 0x10086a5b */
        l_0x1008_6b9d:
            ii(0x1008_6b9d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_6ba0, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_6ba3, 5); call(0x1008_9d08, 0x3160);              /* call 0x10089d08 */
            ii(0x1008_6ba8, 3); lea(ebx, memd[ss, ebp - 0x18]);         /* lea ebx, [ebp-0x18] */
            ii(0x1008_6bab, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_6bad, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_6baf, 5); call(0x1008_9b68, 0x2fb4);              /* call 0x10089b68 */
            ii(0x1008_6bb4, 2); jmp(0x1008_6bbe, 8); goto l_0x1008_6bbe; /* jmp 0x10086bbe */
        l_0x1008_6bb6:
            ii(0x1008_6bb6, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_6bb9, 5); call(0x1007_6bf8, -0xffc6);             /* call 0x10076bf8 */
        l_0x1008_6bbe:
            ii(0x1008_6bbe, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_6bc0, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_6bc3, 5); call(0x1013_ad71, 0xb_41a9);            /* call 0x1013ad71 */
            ii(0x1008_6bc8, 2); test(al, al);                           /* test al, al */
            ii(0x1008_6bca, 2); if(jz(0x1008_6c1b, 0x4f)) goto l_0x1008_6c1b; /* jz 0x10086c1b */
            ii(0x1008_6bcc, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_6bcf, 5); call(0x1008_9acc, 0x2ef8);              /* call 0x10089acc */
            ii(0x1008_6bd4, 5); call(0x1008_9f38, 0x335f);              /* call 0x10089f38 */
            ii(0x1008_6bd9, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1008_6bdc, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1008_6bdf, 5); call(0x100b_8dfb, 0x3_2217);            /* call 0x100b8dfb */
            ii(0x1008_6be4, 3); cmp(eax, memd[ss, ebp - 4]);            /* cmp eax, [ebp-0x4] */
            ii(0x1008_6be7, 2); if(jz(0x1008_6bf8, 0xf)) goto l_0x1008_6bf8; /* jz 0x10086bf8 */
            ii(0x1008_6be9, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x1008_6bec, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_6bef, 5); call(0x1008_685e, -0x396);              /* call 0x1008685e */
            ii(0x1008_6bf4, 2); test(al, al);                           /* test al, al */
            ii(0x1008_6bf6, 2); if(jz(0x1008_6bfa, 2)) goto l_0x1008_6bfa; /* jz 0x10086bfa */
        l_0x1008_6bf8:
            ii(0x1008_6bf8, 2); jmp(0x1008_6c0e, 0x14); goto l_0x1008_6c0e; /* jmp 0x10086c0e */
        l_0x1008_6bfa:
            ii(0x1008_6bfa, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_6bfd, 5); call(0x1008_9b00, 0x2efe);              /* call 0x10089b00 */
            ii(0x1008_6c02, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_6c04, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_6c07, 5); call(0x1008_6950, -0x2bc);              /* call 0x10086950 */
            ii(0x1008_6c0c, 2); jmp(0x1008_6c19, 0xb); goto l_0x1008_6c19; /* jmp 0x10086c19 */
        l_0x1008_6c0e:
            ii(0x1008_6c0e, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_6c11, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1008_6c14, 5); call(0x100b_8e30, 0x3_2217);            /* call 0x100b8e30 */
        l_0x1008_6c19:
            ii(0x1008_6c19, 2); jmp(0x1008_6bb6, -0x65); goto l_0x1008_6bb6; /* jmp 0x10086bb6 */
        l_0x1008_6c1b:
            ii(0x1008_6c1b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_6c1e, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1008_6c21, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_6c24, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x1008_6c2a, 5); mov(edx, 0x101c_31c4);                  /* mov edx, 0x101c31c4 */
            ii(0x1008_6c2f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_6c31, 5); call(0x100b_a098, 0x3_3462);            /* call 0x100ba098 */
            ii(0x1008_6c36, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_6c38, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6c3b, 5); call(0x1008_a1a4, 0x3564);              /* call 0x1008a1a4 */
            ii(0x1008_6c40, 2); jmp(0x1008_6c4a, 8); goto l_0x1008_6c4a; /* jmp 0x10086c4a */
        l_0x1008_6c42:
            ii(0x1008_6c42, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6c45, 5); call(0x1007_6bf8, -0x1_0052);           /* call 0x10076bf8 */
        l_0x1008_6c4a:
            ii(0x1008_6c4a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_6c4c, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6c4f, 5); call(0x1013_ad71, 0xb_411d);            /* call 0x1013ad71 */
            ii(0x1008_6c54, 2); test(al, al);                           /* test al, al */
            ii(0x1008_6c56, 6); if(jz(0x1008_6dd9, 0x17d)) goto l_0x1008_6dd9; /* jz 0x10086dd9 */
            ii(0x1008_6c5c, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6c5f, 5); call(0x1008_a0f8, 0x3494);              /* call 0x1008a0f8 */
            ii(0x1008_6c64, 5); call(0x1008_a370, 0x3707);              /* call 0x1008a370 */
            ii(0x1008_6c69, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1008_6c6c, 4); cmp(memd[ss, ebp - 0x24], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1008_6c70, 2); if(jz(0x1008_6c82, 0x10)) goto l_0x1008_6c82; /* jz 0x10086c82 */
            ii(0x1008_6c72, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1008_6c75, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_6c77, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1008_6c7a, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1008_6c7e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_6c80, 2); if(jz(0x1008_6c84, 2)) goto l_0x1008_6c84; /* jz 0x10086c84 */
        l_0x1008_6c82:
            ii(0x1008_6c82, 2); jmp(0x1008_6c96, 0x12); goto l_0x1008_6c96; /* jmp 0x10086c96 */
        l_0x1008_6c84:
            ii(0x1008_6c84, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6c87, 5); call(0x1008_a0f8, 0x346c);              /* call 0x1008a0f8 */
            ii(0x1008_6c8c, 5); call(0x100b_8dfb, 0x3_216a);            /* call 0x100b8dfb */
            ii(0x1008_6c91, 3); cmp(eax, memd[ss, ebp - 4]);            /* cmp eax, [ebp-0x4] */
            ii(0x1008_6c94, 2); if(jnz(0x1008_6c98, 2)) goto l_0x1008_6c98; /* jnz 0x10086c98 */
        l_0x1008_6c96:
            ii(0x1008_6c96, 2); jmp(0x1008_6cae, 0x16); goto l_0x1008_6cae; /* jmp 0x10086cae */
        l_0x1008_6c98:
            ii(0x1008_6c98, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6c9b, 5); call(0x1008_a12c, 0x348c);              /* call 0x1008a12c */
            ii(0x1008_6ca0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_6ca2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_6ca5, 5); call(0x1008_685e, -0x44c);              /* call 0x1008685e */
            ii(0x1008_6caa, 2); test(al, al);                           /* test al, al */
            ii(0x1008_6cac, 2); if(jnz(0x1008_6cb3, 5)) goto l_0x1008_6cb3; /* jnz 0x10086cb3 */
        l_0x1008_6cae:
            ii(0x1008_6cae, 5); jmp(0x1008_6dd4, 0x121); goto l_0x1008_6dd4; /* jmp 0x10086dd4 */
        l_0x1008_6cb3:
            ii(0x1008_6cb3, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6cb6, 5); call(0x1008_a0f8, 0x343d);              /* call 0x1008a0f8 */
            ii(0x1008_6cbb, 5); call(0x100b_8dfb, 0x3_213b);            /* call 0x100b8dfb */
            ii(0x1008_6cc0, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1008_6cc3, 4); cmp(memd[ss, ebp - 0x2c], 0);           /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x1008_6cc7, 6); if(jnz(0x1008_6d65, 0x98)) goto l_0x1008_6d65; /* jnz 0x10086d65 */
            ii(0x1008_6ccd, 5); mov(eax, 0x32);                         /* mov eax, 0x32 */
            ii(0x1008_6cd2, 5); call(Definitions.sys_new, 0xd_f129);    /* call 0x10165e00 */
            ii(0x1008_6cd7, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1008_6cda, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1008_6cdd, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1008_6ce0, 4); cmp(memd[ss, ebp - 0x34], 0);           /* cmp dword [ebp-0x34], 0x0 */
            ii(0x1008_6ce4, 2); if(jz(0x1008_6d0f, 0x29)) goto l_0x1008_6d0f; /* jz 0x10086d0f */
            ii(0x1008_6ce6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_6ce9, 3); mov(ecx, memd[ds, eax + 0xb]);          /* mov ecx, [eax+0xb] */
            ii(0x1008_6cec, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1008_6cef, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6cf2, 5); call(0x1008_a12c, 0x3435);              /* call 0x1008a12c */
            ii(0x1008_6cf7, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_6cf9, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_6cfc, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1008_6cff, 5); call(Definitions.my_ctor_c1, -0xc129);  /* call 0x1007abdb */
            ii(0x1008_6d04, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x1008_6d07, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1008_6d0a, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1008_6d0d, 2); jmp(0x1008_6d15, 6); goto l_0x1008_6d15; /* jmp 0x10086d15 */
        l_0x1008_6d0f:
            ii(0x1008_6d0f, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1008_6d12, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
        l_0x1008_6d15:
            ii(0x1008_6d15, 3); mov(edx, memd[ss, ebp - 0x3c]);         /* mov edx, [ebp-0x3c] */
            ii(0x1008_6d18, 3); lea(eax, memd[ss, ebp - 0x40]);         /* lea eax, [ebp-0x40] */
            ii(0x1008_6d1b, 5); call(0x1008_9eb4, 0x3194);              /* call 0x10089eb4 */
            ii(0x1008_6d20, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_6d23, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6d26, 5); call(0x1008_a0f8, 0x33cd);              /* call 0x1008a0f8 */
            ii(0x1008_6d2b, 5); call(0x100b_8e30, 0x3_2100);            /* call 0x100b8e30 */
            ii(0x1008_6d30, 3); lea(eax, memd[ss, ebp - 0x40]);         /* lea eax, [ebp-0x40] */
            ii(0x1008_6d33, 5); call(0x1008_9dd8, 0x30a0);              /* call 0x10089dd8 */
            ii(0x1008_6d38, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_6d3a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_6d3d, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_6d40, 5); call(0x1008_9cd8, 0x2f93);              /* call 0x10089cd8 */
            ii(0x1008_6d45, 3); lea(eax, memd[ss, ebp - 0x40]);         /* lea eax, [ebp-0x40] */
            ii(0x1008_6d48, 5); call(0x1008_9dd8, 0x308b);              /* call 0x10089dd8 */
            ii(0x1008_6d4d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_6d4f, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_6d54, 5); call(0x100a_4d50, 0x1_dff7);            /* call 0x100a4d50 */
            ii(0x1008_6d59, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_6d5b, 3); lea(eax, memd[ss, ebp - 0x40]);         /* lea eax, [ebp-0x40] */
            ii(0x1008_6d5e, 5); call(0x1008_8fc4, 0x2261);              /* call 0x10088fc4 */
            ii(0x1008_6d63, 2); jmp(0x1008_6dd4, 0x6f); goto l_0x1008_6dd4; /* jmp 0x10086dd4 */
        l_0x1008_6d65:
            ii(0x1008_6d65, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1008_6d68, 5); call(0x1008_98f8, 0x2b8b);              /* call 0x100898f8 */
            ii(0x1008_6d6d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_6d6f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_6d72, 3); cmp(edx, memd[ds, eax + 0x3a]);         /* cmp edx, [eax+0x3a] */
            ii(0x1008_6d75, 2); if(jnz(0x1008_6d9e, 0x27)) goto l_0x1008_6d9e; /* jnz 0x10086d9e */
            ii(0x1008_6d77, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1008_6d7a, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x1008_6d7d, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1008_6d80, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1008_6d83, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1008_6d86, 3); call_abs(memd[ds, edx + 0x14]);         /* call dword [edx+0x14] */
            ii(0x1008_6d89, 1); cwde();                                 /* cwde */
            ii(0x1008_6d8a, 5); and(eax, 0xff00);                       /* and eax, 0xff00 */
            ii(0x1008_6d8f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_6d91, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_6d94, 3); mov(eax, memd[ds, eax + 0xb]);          /* mov eax, [eax+0xb] */
            ii(0x1008_6d97, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_6d9a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_6d9c, 2); if(jz(0x1008_6da0, 2)) goto l_0x1008_6da0; /* jz 0x10086da0 */
        l_0x1008_6d9e:
            ii(0x1008_6d9e, 2); jmp(0x1008_6dd4, 0x34); goto l_0x1008_6dd4; /* jmp 0x10086dd4 */
        l_0x1008_6da0:
            ii(0x1008_6da0, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_6da3, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1008_6da6, 5); call(0x1008_3476, -0x3935);             /* call 0x10083476 */
            ii(0x1008_6dab, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_6dae, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_6db1, 5); call(0x1013_a6f4, 0xb_393e);            /* call 0x1013a6f4 */
            ii(0x1008_6db6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_6db9, 5); call(0x1008_21dd, -0x4be1);             /* call 0x100821dd */
            ii(0x1008_6dbe, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_6dc0, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6dc3, 5); call(0x1008_8e4c, 0x2084);              /* call 0x10088e4c */
            ii(0x1008_6dc8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_6dca, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_6dcd, 5); call(0x1008_9044, 0x2272);              /* call 0x10089044 */
            ii(0x1008_6dd2, 2); jmp(0x1008_6e34, 0x60); goto l_0x1008_6e34; /* jmp 0x10086e34 */
        l_0x1008_6dd4:
            ii(0x1008_6dd4, 5); jmp(0x1008_6c42, -0x197); goto l_0x1008_6c42; /* jmp 0x10086c42 */
        l_0x1008_6dd9:
            ii(0x1008_6dd9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_6ddc, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_6ddf, 5); call(0x1008_9d08, 0x2f24);              /* call 0x10089d08 */
            ii(0x1008_6de4, 3); lea(ebx, memd[ss, ebp - 0x18]);         /* lea ebx, [ebp-0x18] */
            ii(0x1008_6de7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_6de9, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_6deb, 5); call(0x1008_9b68, 0x2d78);              /* call 0x10089b68 */
            ii(0x1008_6df0, 2); jmp(0x1008_6dfa, 8); goto l_0x1008_6dfa; /* jmp 0x10086dfa */
        l_0x1008_6df2:
            ii(0x1008_6df2, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_6df5, 5); call(0x1007_6bf8, -0x1_0202);           /* call 0x10076bf8 */
        l_0x1008_6dfa:
            ii(0x1008_6dfa, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_6dfc, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_6dff, 5); call(0x1013_ad71, 0xb_3f6d);            /* call 0x1013ad71 */
            ii(0x1008_6e04, 2); test(al, al);                           /* test al, al */
            ii(0x1008_6e06, 2); if(jz(0x1008_6e20, 0x18)) goto l_0x1008_6e20; /* jz 0x10086e20 */
            ii(0x1008_6e08, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_6e0b, 3); mov(edx, memd[ds, eax + 0xb]);          /* mov edx, [eax+0xb] */
            ii(0x1008_6e0e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_6e11, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_6e14, 5); call(0x1008_9acc, 0x2cb3);              /* call 0x10089acc */
            ii(0x1008_6e19, 5); call(0x1008_ac94, 0x3e76);              /* call 0x1008ac94 */
            ii(0x1008_6e1e, 2); jmp(0x1008_6df2, -0x2e); goto l_0x1008_6df2; /* jmp 0x10086df2 */
        l_0x1008_6e20:
            ii(0x1008_6e20, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_6e22, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6e25, 5); call(0x1008_8e4c, 0x2022);              /* call 0x10088e4c */
            ii(0x1008_6e2a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_6e2c, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_6e2f, 5); call(0x1008_9044, 0x2210);              /* call 0x10089044 */
        l_0x1008_6e34:
            ii(0x1008_6e34, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_6e36, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_6e37, 1); pop(edi);                               /* pop edi */
            ii(0x1008_6e38, 1); pop(esi);                               /* pop esi */
            ii(0x1008_6e39, 1); pop(edx);                               /* pop edx */
            ii(0x1008_6e3a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_6e3b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_6e3c, 1); ret();                                  /* ret */
        }
    }
}
