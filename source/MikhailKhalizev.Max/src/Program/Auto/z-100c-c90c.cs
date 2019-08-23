using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_c90c-748d86")]
        public void Method_100c_c90c()
        {
            ii(0x100c_c90c, 5); push(0x54);                             /* push 0x54 */
            ii(0x100c_c911, 5); call(Definitions.sys_check_available_stack_size, 0x9_943c); /* call 0x10165d52 */
            ii(0x100c_c916, 1); push(ebx);                              /* push ebx */
            ii(0x100c_c917, 1); push(ecx);                              /* push ecx */
            ii(0x100c_c918, 1); push(edx);                              /* push edx */
            ii(0x100c_c919, 1); push(esi);                              /* push esi */
            ii(0x100c_c91a, 1); push(edi);                              /* push edi */
            ii(0x100c_c91b, 1); push(ebp);                              /* push ebp */
            ii(0x100c_c91c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_c91e, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x100c_c924, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_c927, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_c92a, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c92d, 5); call(0x1007_6574, -0x5_63be);           /* call 0x10076574 */
            ii(0x100c_c932, 5); call(0x1015_26ac, 0x8_5d75);            /* call 0x101526ac */
            ii(0x100c_c937, 3); cmp(eax, memd[ss, ebp - 0x4]);          /* cmp eax, [ebp-0x4] */
            ii(0x100c_c93a, 2); if(jz(0x100c_c94f, 0x13)) goto l_0x100c_c94f; /* jz 0x100cc94f */
            ii(0x100c_c93c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_c93f, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c942, 5); call(0x1007_6574, -0x5_63d3);           /* call 0x10076574 */
            ii(0x100c_c947, 6); test(memw[ds, eax + 0x12], 0x1c0);      /* test word [eax+0x12], 0x1c0 */
            ii(0x100c_c94d, 2); if(jnz(0x100c_c951, 0x2)) goto l_0x100c_c951; /* jnz 0x100cc951 */
        l_0x100c_c94f:
            ii(0x100c_c94f, 2); jmp(0x100c_c956, 0x5); goto l_0x100c_c956; /* jmp 0x100cc956 */
        l_0x100c_c951:
            ii(0x100c_c951, 5); jmp(0x100c_cab7, 0x161); goto l_0x100c_cab7; /* jmp 0x100ccab7 */
        l_0x100c_c956:
            ii(0x100c_c956, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_c958, 5); mov(al, memb[ds, 0x101c_37c9]);         /* mov al, [0x101c37c9] */
            ii(0x100c_c95d, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100c_c960, 6); if(jz(0x100c_cab7, 0x151)) goto l_0x100c_cab7; /* jz 0x100ccab7 */
            ii(0x100c_c966, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_c968, 5); mov(al, memb[ds, 0x101c_37c9]);         /* mov al, [0x101c37c9] */
            ii(0x100c_c96d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_c96f, 2); if(jnz(0x100c_c986, 0x15)) goto l_0x100c_c986; /* jnz 0x100cc986 */
            ii(0x100c_c971, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_c974, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x100c_c977, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_c97a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c97c, 6); mov(dl, memb[ds, 0x101c_37c8]);         /* mov dl, [0x101c37c8] */
            ii(0x100c_c982, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_c984, 2); if(jnz(0x100c_c988, 0x2)) goto l_0x100c_c988; /* jnz 0x100cc988 */
        l_0x100c_c986:
            ii(0x100c_c986, 2); jmp(0x100c_c98d, 0x5); goto l_0x100c_c98d; /* jmp 0x100cc98d */
        l_0x100c_c988:
            ii(0x100c_c988, 5); jmp(0x100c_cab7, 0x12a); goto l_0x100c_cab7; /* jmp 0x100ccab7 */
        l_0x100c_c98d:
            ii(0x100c_c98d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_c990, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c993, 5); call(0x1007_6574, -0x5_6424);           /* call 0x10076574 */
            ii(0x100c_c998, 4); test(memb[ds, eax + 0x13], 0x2);        /* test byte [eax+0x13], 0x2 */
            ii(0x100c_c99c, 2); if(jz(0x100c_c9da, 0x3c)) goto l_0x100c_c9da; /* jz 0x100cc9da */
            ii(0x100c_c99e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_c9a1, 5); call(0x1007_20b1, -0x5_a8f5);           /* call 0x100720b1 */
            ii(0x100c_c9a6, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100c_c9a9, 5); call(0x1007_20b1, -0x5_a8fd);           /* call 0x100720b1 */
            ii(0x100c_c9ae, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x100c_c9b1, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100c_c9b4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_c9b7, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c9ba, 5); call(0x1007_6574, -0x5_644b);           /* call 0x10076574 */
            ii(0x100c_c9bf, 5); call(0x1007_6204, -0x5_67c0);           /* call 0x10076204 */
            ii(0x100c_c9c4, 5); call(0x1014_3616, 0x7_6c4d);            /* call 0x10143616 */
            ii(0x100c_c9c9, 4); movsx(eax, memw[ss, ebp - 0x12]);       /* movsx eax, word [ebp-0x12] */
            ii(0x100c_c9cd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_c9cf, 6); if(jz(0x100c_cab7, 0xe2)) goto l_0x100c_cab7; /* jz 0x100ccab7 */
            ii(0x100c_c9d5, 5); jmp(0x100c_ca8e, 0xb4); goto l_0x100c_ca8e; /* jmp 0x100cca8e */
        l_0x100c_c9da:
            ii(0x100c_c9da, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_c9dd, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c9e0, 5); call(0x1007_6574, -0x5_6471);           /* call 0x10076574 */
            ii(0x100c_c9e5, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x100c_c9e8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_c9eb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_c9ed, 6); if(jg(0x100c_ca8e, 0x9b)) goto l_0x100c_ca8e; /* jg 0x100cca8e */
            ii(0x100c_c9f3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_c9f6, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c9f9, 5); call(0x1007_6574, -0x5_648a);           /* call 0x10076574 */
            ii(0x100c_c9fe, 5); call(0x1015_26ac, 0x8_5ca9);            /* call 0x101526ac */
            ii(0x100c_ca03, 3); cmp(eax, memd[ss, ebp - 0x4]);          /* cmp eax, [ebp-0x4] */
            ii(0x100c_ca06, 6); if(jnz(0x100c_ca8c, 0x80)) goto l_0x100c_ca8c; /* jnz 0x100cca8c */
            ii(0x100c_ca0c, 5); mov(eax, 0x21);                         /* mov eax, 0x21 */
            ii(0x100c_ca11, 5); call(Definitions.sys_new, 0x9_93ea);    /* call 0x10165e00 */
            ii(0x100c_ca16, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100c_ca19, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100c_ca1c, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100c_ca1f, 4); cmp(memd[ss, ebp - 0x28], 0);           /* cmp dword [ebp-0x28], 0x0 */
            ii(0x100c_ca23, 2); if(jz(0x100c_ca5d, 0x38)) goto l_0x100c_ca5d; /* jz 0x100cca5d */
            ii(0x100c_ca25, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_ca28, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100c_ca2b, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100c_ca2e, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x100c_ca31, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100c_ca34, 3); call_abs(memd[ds, edx + 0x74]);         /* call dword [edx+0x74] */
            ii(0x100c_ca37, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100c_ca3a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_ca3d, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_ca40, 5); call(0x1007_65d0, -0x5_6475);           /* call 0x100765d0 */
            ii(0x100c_ca45, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_ca47, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_ca4a, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100c_ca4d, 5); call(0x1008_bd0b, -0x4_0d47);           /* call 0x1008bd0b */
            ii(0x100c_ca52, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100c_ca55, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_ca58, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x100c_ca5b, 2); jmp(0x100c_ca63, 0x6); goto l_0x100c_ca63; /* jmp 0x100cca63 */
        l_0x100c_ca5d:
            ii(0x100c_ca5d, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100c_ca60, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
        l_0x100c_ca63:
            ii(0x100c_ca63, 3); mov(edx, memd[ss, ebp - 0x34]);         /* mov edx, [ebp-0x34] */
            ii(0x100c_ca66, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100c_ca69, 5); call(0x1008_b060, -0x4_1a0e);           /* call 0x1008b060 */
            ii(0x100c_ca6e, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100c_ca71, 5); call(0x1008_af84, -0x4_1af2);           /* call 0x1008af84 */
            ii(0x100c_ca76, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_ca78, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100c_ca7d, 5); call(0x100a_4d50, -0x2_7d32);           /* call 0x100a4d50 */
            ii(0x100c_ca82, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_ca84, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100c_ca87, 5); call(0x1008_8b7c, -0x4_3f10);           /* call 0x10088b7c */
        l_0x100c_ca8c:
            ii(0x100c_ca8c, 2); jmp(0x100c_cab7, 0x29); goto l_0x100c_cab7; /* jmp 0x100ccab7 */
        l_0x100c_ca8e:
            ii(0x100c_ca8e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_ca91, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_ca94, 5); call(0x1007_65d0, -0x5_64c9);           /* call 0x100765d0 */
            ii(0x100c_ca99, 5); call(0x100a_2edb, -0x2_9bc3);           /* call 0x100a2edb */
            ii(0x100c_ca9e, 2); test(al, al);                           /* test al, al */
            ii(0x100c_caa0, 2); if(jz(0x100c_cab7, 0x15)) goto l_0x100c_cab7; /* jz 0x100ccab7 */
            ii(0x100c_caa2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_caa5, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_caa8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_caab, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x100c_caae, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_cab1, 6); call_abs(memd[ds, edx + 0x80]);         /* call dword [edx+0x80] */
        l_0x100c_cab7:
            ii(0x100c_cab7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_cab9, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_caba, 1); pop(edi);                               /* pop edi */
            ii(0x100c_cabb, 1); pop(esi);                               /* pop esi */
            ii(0x100c_cabc, 1); pop(edx);                               /* pop edx */
            ii(0x100c_cabd, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_cabe, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_cabf, 1); ret();                                  /* ret */
        }
    }
}
