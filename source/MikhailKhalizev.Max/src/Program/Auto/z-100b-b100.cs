using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_b100-1f32d924")]
        public void Method_100b_b100()
        {
            ii(0x100b_b100, 5); push(0x34);                             /* push 0x34 */
            ii(0x100b_b105, 5); call(Definitions.sys_check_available_stack_size, 0xa_ac48); /* call 0x10165d52 */
            ii(0x100b_b10a, 1); push(ebx);                              /* push ebx */
            ii(0x100b_b10b, 1); push(ecx);                              /* push ecx */
            ii(0x100b_b10c, 1); push(edx);                              /* push edx */
            ii(0x100b_b10d, 1); push(esi);                              /* push esi */
            ii(0x100b_b10e, 1); push(edi);                              /* push edi */
            ii(0x100b_b10f, 1); push(ebp);                              /* push ebp */
            ii(0x100b_b110, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_b112, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100b_b118, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_b11b, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x100b_b11f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_b122, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100b_b125, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100b_b12b, 7); mov(ax, memw[ds, eax + 0x101c_a4f4]);   /* mov ax, [eax+0x101ca4f4] */
            ii(0x100b_b132, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_b135, 7); mov(memd[ss, ebp - 0xc], 0x1);          /* mov dword [ebp-0xc], 0x1 */
            ii(0x100b_b13c, 2); jmp(0x100b_b144, 0x6); goto l_0x100b_b144; /* jmp 0x100bb144 */
        l_0x100b_b13e:
            ii(0x100b_b13e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_b141, 3); inc(memd[ss, ebp - 0xc]);               /* inc dword [ebp-0xc] */
        l_0x100b_b144:
            ii(0x100b_b144, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100b_b148, 3); cmp(eax, 0x6);                          /* cmp eax, 0x6 */
            ii(0x100b_b14b, 6); if(jg(0x100b_b1eb, 0x9a)) goto l_0x100b_b1eb; /* jg 0x100bb1eb */
            ii(0x100b_b151, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_b154, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100b_b157, 6); imul(edx, eax, 0x247);                  /* imul edx, eax, 0x247 */
            ii(0x100b_b15d, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100b_b161, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x100b_b164, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_b166, 7); mov(ax, memw[ds, eax + 0x101c_a4f4]);   /* mov ax, [eax+0x101ca4f4] */
            ii(0x100b_b16d, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100b_b170, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100b_b174, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100b_b177, 2); if(jnz(0x100b_b187, 0xe)) goto l_0x100b_b187; /* jnz 0x100bb187 */
            ii(0x100b_b179, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100b_b17c, 2); cwd();                                  /* cwd */
            ii(0x100b_b17e, 3); sub(ax, dx);                            /* sub ax, dx */
            ii(0x100b_b181, 3); sar(ax, 0x1);                           /* sar ax, 1 */
            ii(0x100b_b184, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
        l_0x100b_b187:
            ii(0x100b_b187, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100b_b18b, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100b_b18e, 2); if(jnz(0x100b_b1c5, 0x35)) goto l_0x100b_b1c5; /* jnz 0x100bb1c5 */
            ii(0x100b_b190, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_b193, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100b_b196, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x100b_b19c, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100b_b1a0, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x100b_b1a3, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_b1a5, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100b_b1aa, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_b1ac, 6); mov(eax, memd[ds, eax + 0x101c_a4f0]);  /* mov eax, [eax+0x101ca4f0] */
            ii(0x100b_b1b2, 2); div(ebx);                               /* div ebx */
            ii(0x100b_b1b4, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100b_b1b9, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100b_b1bb, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100b_b1bf, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100b_b1c2, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
        l_0x100b_b1c5:
            ii(0x100b_b1c5, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100b_b1c9, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x100b_b1cc, 2); if(jnz(0x100b_b1d1, 0x3)) goto l_0x100b_b1d1; /* jnz 0x100bb1d1 */
            ii(0x100b_b1ce, 3); shl(memd[ss, ebp - 0x14], 0x1);         /* shl dword [ebp-0x14], 1 */
        l_0x100b_b1d1:
            ii(0x100b_b1d1, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100b_b1d4, 4); cmp(ax, memw[ss, ebp - 0x10]);          /* cmp ax, [ebp-0x10] */
            ii(0x100b_b1d8, 2); if(jge(0x100b_b1e6, 0xc)) goto l_0x100b_b1e6; /* jge 0x100bb1e6 */
            ii(0x100b_b1da, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x100b_b1dd, 3); mov(memb[ss, ebp - 0x8], al);           /* mov [ebp-0x8], al */
            ii(0x100b_b1e0, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100b_b1e3, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x100b_b1e6:
            ii(0x100b_b1e6, 5); jmp(0x100b_b13e, -0xad); goto l_0x100b_b13e; /* jmp 0x100bb13e */
        l_0x100b_b1eb:
            ii(0x100b_b1eb, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100b_b1f0, 5); call(0x1007_6338, -0x4_4ebd);           /* call 0x10076338 */
            ii(0x100b_b1f5, 3); lea(ebx, memd[ss, ebp - 0x18]);         /* lea ebx, [ebp-0x18] */
            ii(0x100b_b1f8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_b1fa, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_b1fc, 5); call(0x1007_64b8, -0x4_4d49);           /* call 0x100764b8 */
            ii(0x100b_b201, 2); jmp(0x100b_b20b, 0x8); goto l_0x100b_b20b; /* jmp 0x100bb20b */
        l_0x100b_b203:
            ii(0x100b_b203, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_b206, 5); call(0x1007_6bf8, -0x4_4613);           /* call 0x10076bf8 */
        l_0x100b_b20b:
            ii(0x100b_b20b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_b20d, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_b210, 5); call(0x1013_ad71, 0x7_fb5c);            /* call 0x1013ad71 */
            ii(0x100b_b215, 2); test(al, al);                           /* test al, al */
            ii(0x100b_b217, 6); if(jz(0x100b_b2c8, 0xab)) goto l_0x100b_b2c8; /* jz 0x100bb2c8 */
            ii(0x100b_b21d, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_b220, 5); call(0x1007_63a0, -0x4_4e85);           /* call 0x100763a0 */
            ii(0x100b_b225, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_b227, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x100b_b22a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_b22d, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100b_b230, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_b232, 2); if(jnz(0x100b_b243, 0xf)) goto l_0x100b_b243; /* jnz 0x100bb243 */
            ii(0x100b_b234, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_b237, 5); call(0x1007_63a0, -0x4_4e9c);           /* call 0x100763a0 */
            ii(0x100b_b23c, 5); cmp(memw[ds, eax + 0x8], 0x1d);         /* cmp word [eax+0x8], 0x1d */
            ii(0x100b_b241, 2); if(jz(0x100b_b245, 0x2)) goto l_0x100b_b245; /* jz 0x100bb245 */
        l_0x100b_b243:
            ii(0x100b_b243, 2); jmp(0x100b_b253, 0xe); goto l_0x100b_b253; /* jmp 0x100bb253 */
        l_0x100b_b245:
            ii(0x100b_b245, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_b248, 5); call(0x1007_63a0, -0x4_4ead);           /* call 0x100763a0 */
            ii(0x100b_b24d, 4); cmp(memb[ds, eax + 0x3d], 0x7);         /* cmp byte [eax+0x3d], 0x7 */
            ii(0x100b_b251, 2); if(jz(0x100b_b255, 0x2)) goto l_0x100b_b255; /* jz 0x100bb255 */
        l_0x100b_b253:
            ii(0x100b_b253, 2); jmp(0x100b_b263, 0xe); goto l_0x100b_b263; /* jmp 0x100bb263 */
        l_0x100b_b255:
            ii(0x100b_b255, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_b258, 5); call(0x1007_63a0, -0x4_4ebd);           /* call 0x100763a0 */
            ii(0x100b_b25d, 4); cmp(memb[ds, eax + 0x3e], 0);           /* cmp byte [eax+0x3e], 0x0 */
            ii(0x100b_b261, 2); if(jnz(0x100b_b265, 0x2)) goto l_0x100b_b265; /* jnz 0x100bb265 */
        l_0x100b_b263:
            ii(0x100b_b263, 2); jmp(0x100b_b275, 0x10); goto l_0x100b_b275; /* jmp 0x100bb275 */
        l_0x100b_b265:
            ii(0x100b_b265, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_b268, 5); call(0x1007_63a0, -0x4_4ecd);           /* call 0x100763a0 */
            ii(0x100b_b26d, 3); mov(al, memb[ds, eax + 0x5d]);          /* mov al, [eax+0x5d] */
            ii(0x100b_b270, 3); cmp(al, memb[ss, ebp - 0x8]);           /* cmp al, [ebp-0x8] */
            ii(0x100b_b273, 2); if(jnz(0x100b_b277, 0x2)) goto l_0x100b_b277; /* jnz 0x100bb277 */
        l_0x100b_b275:
            ii(0x100b_b275, 2); jmp(0x100b_b2c3, 0x4c); goto l_0x100b_b2c3; /* jmp 0x100bb2c3 */
        l_0x100b_b277:
            ii(0x100b_b277, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x100b_b27c, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_b27f, 5); call(0x1007_63a0, -0x4_4ee4);           /* call 0x100763a0 */
            ii(0x100b_b284, 3); mov(edx, memd[ds, eax + 0x5a]);         /* mov edx, [eax+0x5a] */
            ii(0x100b_b287, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x100b_b28a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_b28d, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100b_b290, 5); call(0x1013_322d, 0x7_7f98);            /* call 0x1013322d */
            ii(0x100b_b295, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_b298, 5); call(0x1007_63a0, -0x4_4efd);           /* call 0x100763a0 */
            ii(0x100b_b29d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_b29f, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x100b_b2a2, 3); mov(memb[ds, edx + 0x5d], al);          /* mov [edx+0x5d], al */
            ii(0x100b_b2a5, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100b_b2aa, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_b2ad, 5); call(0x1007_63a0, -0x4_4f12);           /* call 0x100763a0 */
            ii(0x100b_b2b2, 3); mov(edx, memd[ds, eax + 0x5a]);         /* mov edx, [eax+0x5a] */
            ii(0x100b_b2b5, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x100b_b2b8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_b2bb, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100b_b2be, 5); call(0x1013_322d, 0x7_7f6a);            /* call 0x1013322d */
        l_0x100b_b2c3:
            ii(0x100b_b2c3, 5); jmp(0x100b_b203, -0xc5); goto l_0x100b_b203; /* jmp 0x100bb203 */
        l_0x100b_b2c8:
            ii(0x100b_b2c8, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x100b_b2cf, 2); if(jz(0x100b_b2dc, 0xb)) goto l_0x100b_b2dc; /* jz 0x100bb2dc */
            ii(0x100b_b2d1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_b2d4, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100b_b2d7, 5); call(0x1012_894c, 0x6_d670);            /* call 0x1012894c */
        l_0x100b_b2dc:
            ii(0x100b_b2dc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_b2de, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_b2e1, 5); call(0x1007_5f6c, -0x4_537a);           /* call 0x10075f6c */
            ii(0x100b_b2e6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_b2e8, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_b2e9, 1); pop(edi);                               /* pop edi */
            ii(0x100b_b2ea, 1); pop(esi);                               /* pop esi */
            ii(0x100b_b2eb, 1); pop(edx);                               /* pop edx */
            ii(0x100b_b2ec, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_b2ed, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_b2ee, 1); ret();                                  /* ret */
        }
    }
}
