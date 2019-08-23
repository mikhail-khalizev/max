using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_8b00-f59035e0")]
        public void Method_100d_8b00()
        {
            ii(0x100d_8b00, 5); push(0x48);                             /* push 0x48 */
            ii(0x100d_8b05, 5); call(Definitions.sys_check_available_stack_size, 0x8_d248); /* call 0x10165d52 */
            ii(0x100d_8b0a, 1); push(ebx);                              /* push ebx */
            ii(0x100d_8b0b, 1); push(ecx);                              /* push ecx */
            ii(0x100d_8b0c, 1); push(esi);                              /* push esi */
            ii(0x100d_8b0d, 1); push(edi);                              /* push edi */
            ii(0x100d_8b0e, 1); push(ebp);                              /* push ebp */
            ii(0x100d_8b0f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_8b11, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x100d_8b17, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_8b1a, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_8b1d, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100d_8b21, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100d_8b24, 6); mov(eax, memd[ds, eax + 0x101c_81c0]);  /* mov eax, [eax+0x101c81c0] */
            ii(0x100d_8b2a, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_8b2d, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100d_8b31, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100d_8b34, 6); mov(eax, memd[ds, eax + 0x101c_81c0]);  /* mov eax, [eax+0x101c81c0] */
            ii(0x100d_8b3a, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_8b3d, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_8b40, 6); and(edx, 0x100);                        /* and edx, 0x100 */
            ii(0x100d_8b46, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_8b49, 5); and(eax, 0x100);                        /* and eax, 0x100 */
            ii(0x100d_8b4e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100d_8b50, 2); if(jz(0x100d_8b70, 0x1e)) goto l_0x100d_8b70; /* jz 0x100d8b70 */
            ii(0x100d_8b52, 7); test(memd[ss, ebp - 0x10], 0x100);      /* test dword [ebp-0x10], 0x100 */
            ii(0x100d_8b59, 2); if(jnz(0x100d_8b61, 0x6)) goto l_0x100d_8b61; /* jnz 0x100d8b61 */
            ii(0x100d_8b5b, 4); mov(memb[ss, ebp - 0x18], 0x1);         /* mov byte [ebp-0x18], 0x1 */
            ii(0x100d_8b5f, 2); jmp(0x100d_8b65, 0x4); goto l_0x100d_8b65; /* jmp 0x100d8b65 */
        l_0x100d_8b61:
            ii(0x100d_8b61, 4); mov(memb[ss, ebp - 0x18], 0);           /* mov byte [ebp-0x18], 0x0 */
        l_0x100d_8b65:
            ii(0x100d_8b65, 3); mov(al, memb[ss, ebp - 0x18]);          /* mov al, [ebp-0x18] */
            ii(0x100d_8b68, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x100d_8b6b, 5); jmp(0x100d_8d2a, 0x1ba); goto l_0x100d_8d2a; /* jmp 0x100d8d2a */
        l_0x100d_8b70:
            ii(0x100d_8b70, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_8b73, 6); and(edx, 0x80);                         /* and edx, 0x80 */
            ii(0x100d_8b79, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_8b7c, 5); and(eax, 0x80);                         /* and eax, 0x80 */
            ii(0x100d_8b81, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100d_8b83, 2); if(jz(0x100d_8ba3, 0x1e)) goto l_0x100d_8ba3; /* jz 0x100d8ba3 */
            ii(0x100d_8b85, 7); test(memd[ss, ebp - 0x10], 0x80);       /* test dword [ebp-0x10], 0x80 */
            ii(0x100d_8b8c, 2); if(jnz(0x100d_8b94, 0x6)) goto l_0x100d_8b94; /* jnz 0x100d8b94 */
            ii(0x100d_8b8e, 4); mov(memb[ss, ebp - 0x1c], 0x1);         /* mov byte [ebp-0x1c], 0x1 */
            ii(0x100d_8b92, 2); jmp(0x100d_8b98, 0x4); goto l_0x100d_8b98; /* jmp 0x100d8b98 */
        l_0x100d_8b94:
            ii(0x100d_8b94, 4); mov(memb[ss, ebp - 0x1c], 0);           /* mov byte [ebp-0x1c], 0x0 */
        l_0x100d_8b98:
            ii(0x100d_8b98, 3); mov(al, memb[ss, ebp - 0x1c]);          /* mov al, [ebp-0x1c] */
            ii(0x100d_8b9b, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x100d_8b9e, 5); jmp(0x100d_8d2a, 0x187); goto l_0x100d_8d2a; /* jmp 0x100d8d2a */
        l_0x100d_8ba3:
            ii(0x100d_8ba3, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_8ba6, 3); and(edx, 0x40);                         /* and edx, 0x40 */
            ii(0x100d_8ba9, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_8bac, 3); and(eax, 0x40);                         /* and eax, 0x40 */
            ii(0x100d_8baf, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100d_8bb1, 2); if(jz(0x100d_8bd1, 0x1e)) goto l_0x100d_8bd1; /* jz 0x100d8bd1 */
            ii(0x100d_8bb3, 7); test(memd[ss, ebp - 0x10], 0x40);       /* test dword [ebp-0x10], 0x40 */
            ii(0x100d_8bba, 2); if(jnz(0x100d_8bc2, 0x6)) goto l_0x100d_8bc2; /* jnz 0x100d8bc2 */
            ii(0x100d_8bbc, 4); mov(memb[ss, ebp - 0x20], 0x1);         /* mov byte [ebp-0x20], 0x1 */
            ii(0x100d_8bc0, 2); jmp(0x100d_8bc6, 0x4); goto l_0x100d_8bc6; /* jmp 0x100d8bc6 */
        l_0x100d_8bc2:
            ii(0x100d_8bc2, 4); mov(memb[ss, ebp - 0x20], 0);           /* mov byte [ebp-0x20], 0x0 */
        l_0x100d_8bc6:
            ii(0x100d_8bc6, 3); mov(al, memb[ss, ebp - 0x20]);          /* mov al, [ebp-0x20] */
            ii(0x100d_8bc9, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x100d_8bcc, 5); jmp(0x100d_8d2a, 0x159); goto l_0x100d_8d2a; /* jmp 0x100d8d2a */
        l_0x100d_8bd1:
            ii(0x100d_8bd1, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100d_8bd5, 5); mov(eax, memd[ds, 0x101c_a562]);        /* mov eax, [0x101ca562] */
            ii(0x100d_8bda, 5); call(0x100c_b6b0, -0xd52f);             /* call 0x100cb6b0 */
            ii(0x100d_8bdf, 3); lea(ebx, ebp - 0x24);                   /* lea ebx, [ebp-0x24] */
            ii(0x100d_8be2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_8be4, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100d_8be6, 5); call(0x1007_6800, -0x6_23eb);           /* call 0x10076800 */
            ii(0x100d_8beb, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100d_8bef, 5); mov(eax, memd[ds, 0x101c_a562]);        /* mov eax, [0x101ca562] */
            ii(0x100d_8bf4, 5); call(0x100c_b6b0, -0xd549);             /* call 0x100cb6b0 */
            ii(0x100d_8bf9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_8bfb, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100d_8bfe, 5); call(0x1007_6800, -0x6_2403);           /* call 0x10076800 */
            ii(0x100d_8c03, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100d_8c06, 5); call(0x1007_6730, -0x6_24db);           /* call 0x10076730 */
            ii(0x100d_8c0b, 3); mov(eax, memd[ds, eax + 0xc]);          /* mov eax, [eax+0xc] */
            ii(0x100d_8c0e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_8c11, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_8c13, 2); if(jle(0x100d_8c27, 0x12)) goto l_0x100d_8c27; /* jle 0x100d8c27 */
            ii(0x100d_8c15, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100d_8c18, 5); call(0x1007_6730, -0x6_24ed);           /* call 0x10076730 */
            ii(0x100d_8c1d, 3); mov(eax, memd[ds, eax + 0xc]);          /* mov eax, [eax+0xc] */
            ii(0x100d_8c20, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_8c23, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_8c25, 2); if(jz(0x100d_8c29, 0x2)) goto l_0x100d_8c29; /* jz 0x100d8c29 */
        l_0x100d_8c27:
            ii(0x100d_8c27, 2); jmp(0x100d_8c46, 0x1d); goto l_0x100d_8c46; /* jmp 0x100d8c46 */
        l_0x100d_8c29:
            ii(0x100d_8c29, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100d_8c2d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_8c2f, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100d_8c32, 5); call(0x1007_5eec, -0x6_2d4b);           /* call 0x10075eec */
            ii(0x100d_8c37, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_8c39, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100d_8c3c, 5); call(0x1007_5eec, -0x6_2d55);           /* call 0x10075eec */
            ii(0x100d_8c41, 5); jmp(0x100d_8d2a, 0xe4); goto l_0x100d_8d2a; /* jmp 0x100d8d2a */
        l_0x100d_8c46:
            ii(0x100d_8c46, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100d_8c49, 5); call(0x1007_6730, -0x6_251e);           /* call 0x10076730 */
            ii(0x100d_8c4e, 3); mov(eax, memd[ds, eax + 0xc]);          /* mov eax, [eax+0xc] */
            ii(0x100d_8c51, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_8c54, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_8c56, 2); if(jnz(0x100d_8c6a, 0x12)) goto l_0x100d_8c6a; /* jnz 0x100d8c6a */
            ii(0x100d_8c58, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100d_8c5b, 5); call(0x1007_6730, -0x6_2530);           /* call 0x10076730 */
            ii(0x100d_8c60, 3); mov(eax, memd[ds, eax + 0xc]);          /* mov eax, [eax+0xc] */
            ii(0x100d_8c63, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_8c66, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_8c68, 2); if(jg(0x100d_8c6c, 0x2)) goto l_0x100d_8c6c; /* jg 0x100d8c6c */
        l_0x100d_8c6a:
            ii(0x100d_8c6a, 2); jmp(0x100d_8c89, 0x1d); goto l_0x100d_8c89; /* jmp 0x100d8c89 */
        l_0x100d_8c6c:
            ii(0x100d_8c6c, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x100d_8c70, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_8c72, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100d_8c75, 5); call(0x1007_5eec, -0x6_2d8e);           /* call 0x10075eec */
            ii(0x100d_8c7a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_8c7c, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100d_8c7f, 5); call(0x1007_5eec, -0x6_2d98);           /* call 0x10075eec */
            ii(0x100d_8c84, 5); jmp(0x100d_8d2a, 0xa1); goto l_0x100d_8d2a; /* jmp 0x100d8d2a */
        l_0x100d_8c89:
            ii(0x100d_8c89, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100d_8c8c, 5); call(0x1007_6730, -0x6_2561);           /* call 0x10076730 */
            ii(0x100d_8c91, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_8c93, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100d_8c96, 5); call(0x1007_6730, -0x6_256b);           /* call 0x10076730 */
            ii(0x100d_8c9b, 4); mov(dx, memw[ds, edx + 0x8]);           /* mov dx, [edx+0x8] */
            ii(0x100d_8c9f, 4); cmp(dx, memw[ds, eax + 0x8]);           /* cmp dx, [eax+0x8] */
            ii(0x100d_8ca3, 2); if(jz(0x100d_8ce7, 0x42)) goto l_0x100d_8ce7; /* jz 0x100d8ce7 */
            ii(0x100d_8ca5, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100d_8ca8, 5); call(0x1007_6730, -0x6_257d);           /* call 0x10076730 */
            ii(0x100d_8cad, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_8caf, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100d_8cb2, 5); call(0x1007_6730, -0x6_2587);           /* call 0x10076730 */
            ii(0x100d_8cb7, 4); mov(dx, memw[ds, edx + 0x8]);           /* mov dx, [edx+0x8] */
            ii(0x100d_8cbb, 4); cmp(dx, memw[ds, eax + 0x8]);           /* cmp dx, [eax+0x8] */
            ii(0x100d_8cbf, 2); if(jle(0x100d_8cc7, 0x6)) goto l_0x100d_8cc7; /* jle 0x100d8cc7 */
            ii(0x100d_8cc1, 4); mov(memb[ss, ebp - 0x2c], 0x1);         /* mov byte [ebp-0x2c], 0x1 */
            ii(0x100d_8cc5, 2); jmp(0x100d_8ccb, 0x4); goto l_0x100d_8ccb; /* jmp 0x100d8ccb */
        l_0x100d_8cc7:
            ii(0x100d_8cc7, 4); mov(memb[ss, ebp - 0x2c], 0);           /* mov byte [ebp-0x2c], 0x0 */
        l_0x100d_8ccb:
            ii(0x100d_8ccb, 3); mov(al, memb[ss, ebp - 0x2c]);          /* mov al, [ebp-0x2c] */
            ii(0x100d_8cce, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x100d_8cd1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_8cd3, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100d_8cd6, 5); call(0x1007_5eec, -0x6_2def);           /* call 0x10075eec */
            ii(0x100d_8cdb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_8cdd, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100d_8ce0, 5); call(0x1007_5eec, -0x6_2df9);           /* call 0x10075eec */
            ii(0x100d_8ce5, 2); jmp(0x100d_8d2a, 0x43); goto l_0x100d_8d2a; /* jmp 0x100d8d2a */
        l_0x100d_8ce7:
            ii(0x100d_8ce7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_8cea, 4); cmp(ax, memw[ss, ebp - 0x4]);           /* cmp ax, [ebp-0x4] */
            ii(0x100d_8cee, 2); if(jle(0x100d_8cf6, 0x6)) goto l_0x100d_8cf6; /* jle 0x100d8cf6 */
            ii(0x100d_8cf0, 4); mov(memb[ss, ebp - 0x30], 0x1);         /* mov byte [ebp-0x30], 0x1 */
            ii(0x100d_8cf4, 2); jmp(0x100d_8cfa, 0x4); goto l_0x100d_8cfa; /* jmp 0x100d8cfa */
        l_0x100d_8cf6:
            ii(0x100d_8cf6, 4); mov(memb[ss, ebp - 0x30], 0);           /* mov byte [ebp-0x30], 0x0 */
        l_0x100d_8cfa:
            ii(0x100d_8cfa, 3); mov(al, memb[ss, ebp - 0x30]);          /* mov al, [ebp-0x30] */
            ii(0x100d_8cfd, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x100d_8d00, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_8d02, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100d_8d05, 5); call(0x1007_5eec, -0x6_2e1e);           /* call 0x10075eec */
            ii(0x100d_8d0a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_8d0c, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100d_8d0f, 5); call(0x1007_5eec, -0x6_2e28);           /* call 0x10075eec */
            ii(0x100d_8d14, 2); jmp(0x100d_8d2a, 0x14); goto l_0x100d_8d2a; /* jmp 0x100d8d2a */
        //  ii(0x100d_8d16, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100d_8d18, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
        //  ii(0x100d_8d1b, 5); call(0x1007_5eec, -0x6_2e34);           /* call 0x10075eec */
        //  ii(0x100d_8d20, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100d_8d22, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
        //  ii(0x100d_8d25, 5); call(0x1007_5eec, -0x6_2e3e);           /* call 0x10075eec */
        l_0x100d_8d2a:
            ii(0x100d_8d2a, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x100d_8d2d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_8d2f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_8d30, 1); pop(edi);                               /* pop edi */
            ii(0x100d_8d31, 1); pop(esi);                               /* pop esi */
            ii(0x100d_8d32, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_8d33, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_8d34, 1); ret();                                  /* ret */
        }
    }
}
