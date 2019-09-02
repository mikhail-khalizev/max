using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_1bf2-4a1bac00")]
        public void Method_100b_1bf2()
        {
            ii(0x100b_1bf2, 5); push(0x54);                             /* push 0x54 */
            ii(0x100b_1bf7, 5); call(Definitions.sys_check_available_stack_size, 0xb_4156); /* call 0x10165d52 */
            ii(0x100b_1bfc, 1); push(ecx);                              /* push ecx */
            ii(0x100b_1bfd, 1); push(esi);                              /* push esi */
            ii(0x100b_1bfe, 1); push(edi);                              /* push edi */
            ii(0x100b_1bff, 1); push(ebp);                              /* push ebp */
            ii(0x100b_1c00, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_1c02, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x100b_1c08, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_1c0b, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100b_1c0e, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x100b_1c11, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_1c14, 5); call(0x1015_26ac, 0xa_0a93);            /* call 0x101526ac */
            ii(0x100b_1c19, 3); lea(ebx, memd[ss, ebp - 0x18]);         /* lea ebx, [ebp-0x18] */
            ii(0x100b_1c1c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_1c1e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_1c20, 5); call(0x1008_a5f0, -0x2_7635);           /* call 0x1008a5f0 */
            ii(0x100b_1c25, 3); lea(edx, memd[ss, ebp - 0x24]);         /* lea edx, [ebp-0x24] */
            ii(0x100b_1c28, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_1c2b, 5); call(0x1008_a520, -0x2_7710);           /* call 0x1008a520 */
            ii(0x100b_1c30, 5); call(0x100b_7da0, 0x616b);              /* call 0x100b7da0 */
            ii(0x100b_1c35, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_1c38, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x100b_1c3b, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_1c3e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_1c41, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x100b_1c44, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_1c47, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100b_1c4a, 5); call(0x1007_6aac, -0x3_b1a3);           /* call 0x10076aac */
            ii(0x100b_1c4f, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x100b_1c53, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_1c55, 2); if(jge(0x100b_1c6a, 0x13)) goto l_0x100b_1c6a; /* jge 0x100b1c6a */
            ii(0x100b_1c57, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100b_1c5b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1c5d, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_1c60, 5); call(0x1008_8d4c, -0x2_8f19);           /* call 0x10088d4c */
            ii(0x100b_1c65, 5); jmp(0x100b_1dff, 0x195); goto l_0x100b_1dff; /* jmp 0x100b1dff */
        l_0x100b_1c6a:
            ii(0x100b_1c6a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_1c6d, 5); cmp(memw[ds, eax + 8], 0x41);           /* cmp word [eax+0x8], 0x41 */
            ii(0x100b_1c72, 2); if(jnz(0x100b_1c7e, 0xa)) goto l_0x100b_1c7e; /* jnz 0x100b1c7e */
            ii(0x100b_1c74, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_1c77, 5); cmp(memw[ds, eax + 8], 0x43);           /* cmp word [eax+0x8], 0x43 */
            ii(0x100b_1c7c, 2); if(jnz(0x100b_1c80, 2)) goto l_0x100b_1c80; /* jnz 0x100b1c80 */
        l_0x100b_1c7e:
            ii(0x100b_1c7e, 2); jmp(0x100b_1c8a, 0xa); goto l_0x100b_1c8a; /* jmp 0x100b1c8a */
        l_0x100b_1c80:
            ii(0x100b_1c80, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_1c83, 5); cmp(memw[ds, eax + 8], 0x42);           /* cmp word [eax+0x8], 0x42 */
            ii(0x100b_1c88, 2); if(jnz(0x100b_1c8c, 2)) goto l_0x100b_1c8c; /* jnz 0x100b1c8c */
        l_0x100b_1c8a:
            ii(0x100b_1c8a, 2); jmp(0x100b_1c9f, 0x13); goto l_0x100b_1c9f; /* jmp 0x100b1c9f */
        l_0x100b_1c8c:
            ii(0x100b_1c8c, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100b_1c90, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1c92, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_1c95, 5); call(0x1008_8d4c, -0x2_8f4e);           /* call 0x10088d4c */
            ii(0x100b_1c9a, 5); jmp(0x100b_1dff, 0x160); goto l_0x100b_1dff; /* jmp 0x100b1dff */
        l_0x100b_1c9f:
            ii(0x100b_1c9f, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100b_1ca2, 4); cmp(ax, memw[ss, ebp - 0x24]);          /* cmp ax, [ebp-0x24] */
            ii(0x100b_1ca6, 2); if(jnz(0x100b_1cb1, 9)) goto l_0x100b_1cb1; /* jnz 0x100b1cb1 */
            ii(0x100b_1ca8, 3); mov(eax, memd[ss, ebp - 0x1e]);         /* mov eax, [ebp-0x1e] */
            ii(0x100b_1cab, 4); cmp(ax, memw[ss, ebp - 0x22]);          /* cmp ax, [ebp-0x22] */
            ii(0x100b_1caf, 2); if(jz(0x100b_1cb3, 2)) goto l_0x100b_1cb3; /* jz 0x100b1cb3 */
        l_0x100b_1cb1:
            ii(0x100b_1cb1, 2); jmp(0x100b_1cc6, 0x13); goto l_0x100b_1cc6; /* jmp 0x100b1cc6 */
        l_0x100b_1cb3:
            ii(0x100b_1cb3, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100b_1cb7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1cb9, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_1cbc, 5); call(0x1008_8d4c, -0x2_8f75);           /* call 0x10088d4c */
            ii(0x100b_1cc1, 5); jmp(0x100b_1dff, 0x139); goto l_0x100b_1dff; /* jmp 0x100b1dff */
        l_0x100b_1cc6:
            ii(0x100b_1cc6, 3); lea(edx, memd[ss, ebp - 0x20]);         /* lea edx, [ebp-0x20] */
            ii(0x100b_1cc9, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x100b_1ccc, 5); call(0x1007_5e64, -0x3_be6d);           /* call 0x10075e64 */
            ii(0x100b_1cd1, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x100b_1cd4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_1cd6, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_1cd8, 5); call(0x1011_ff4c, 0x6_e26f);            /* call 0x1011ff4c */
            ii(0x100b_1cdd, 2); test(al, al);                           /* test al, al */
            ii(0x100b_1cdf, 2); if(jnz(0x100b_1cf4, 0x13)) goto l_0x100b_1cf4; /* jnz 0x100b1cf4 */
            ii(0x100b_1ce1, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100b_1ce5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1ce7, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_1cea, 5); call(0x1008_8d4c, -0x2_8fa3);           /* call 0x10088d4c */
            ii(0x100b_1cef, 5); jmp(0x100b_1dff, 0x10b); goto l_0x100b_1dff; /* jmp 0x100b1dff */
        l_0x100b_1cf4:
            ii(0x100b_1cf4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_1cf7, 5); cmp(memw[ds, eax + 8], 0x4e);           /* cmp word [eax+0x8], 0x4e */
            ii(0x100b_1cfc, 2); if(jnz(0x100b_1d27, 0x29)) goto l_0x100b_1d27; /* jnz 0x100b1d27 */
            ii(0x100b_1cfe, 3); lea(edx, memd[ss, ebp - 0x24]);         /* lea edx, [ebp-0x24] */
            ii(0x100b_1d01, 3); lea(eax, memd[ss, ebp - 0x28]);         /* lea eax, [ebp-0x28] */
            ii(0x100b_1d04, 5); call(0x1007_5e64, -0x3_bea5);           /* call 0x10075e64 */
            ii(0x100b_1d09, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x100b_1d0c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_1d0e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_1d10, 5); call(0x1011_ff4c, 0x6_e237);            /* call 0x1011ff4c */
            ii(0x100b_1d15, 3); mov(memb[ss, ebp - 0x10], al);          /* mov [ebp-0x10], al */
            ii(0x100b_1d18, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1d1a, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_1d1d, 5); call(0x1008_8d4c, -0x2_8fd6);           /* call 0x10088d4c */
            ii(0x100b_1d22, 5); jmp(0x100b_1dff, 0xd8); goto l_0x100b_1dff; /* jmp 0x100b1dff */
        l_0x100b_1d27:
            ii(0x100b_1d27, 6); mov(edx, memd[ds, 0x101c_8172]);        /* mov edx, [0x101c8172] */
            ii(0x100b_1d2d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_1d30, 4); movsx(eax, memw[ss, ebp - 0x22]);       /* movsx eax, word [ebp-0x22] */
            ii(0x100b_1d34, 3); add(eax, 2);                            /* add eax, 0x2 */
            ii(0x100b_1d37, 5); call(Definitions.my_min, -0x2_85b8);    /* call 0x10089784 */
            ii(0x100b_1d3c, 1); cwde();                                 /* cwde */
            ii(0x100b_1d3d, 1); push(eax);                              /* push eax */
            ii(0x100b_1d3e, 6); mov(edx, memd[ds, 0x101c_8170]);        /* mov edx, [0x101c8170] */
            ii(0x100b_1d44, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_1d47, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x100b_1d4b, 3); add(eax, 2);                            /* add eax, 0x2 */
            ii(0x100b_1d4e, 5); call(Definitions.my_min, -0x2_85cf);    /* call 0x10089784 */
            ii(0x100b_1d53, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100b_1d56, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1d58, 4); movsx(eax, memw[ss, ebp - 0x22]);       /* movsx eax, word [ebp-0x22] */
            ii(0x100b_1d5c, 1); dec(eax);                               /* dec eax */
            ii(0x100b_1d5d, 5); call(0x1007_6e7c, -0x3_aee6);           /* call 0x10076e7c */
            ii(0x100b_1d62, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100b_1d65, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1d67, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x100b_1d6b, 1); dec(eax);                               /* dec eax */
            ii(0x100b_1d6c, 5); call(0x1007_6e7c, -0x3_aef5);           /* call 0x10076e7c */
            ii(0x100b_1d71, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_1d74, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x100b_1d77, 5); call(0x1008_b148, -0x2_6c34);           /* call 0x1008b148 */
            ii(0x100b_1d7c, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_1d7f, 5); call(Definitions.my_ctor_0x101b_4184, -0x3_b294); /* call 0x10076af0 */
            ii(0x100b_1d84, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x100b_1d87, 4); mov(memw[ss, ebp - 0x14], ax);          /* mov [ebp-0x14], ax */
            ii(0x100b_1d8b, 2); jmp(0x100b_1d94, 7); goto l_0x100b_1d94; /* jmp 0x100b1d94 */
        l_0x100b_1d8d:
            ii(0x100b_1d8d, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100b_1d90, 4); inc(memw[ss, ebp - 0x14]);              /* inc word [ebp-0x14] */
        l_0x100b_1d94:
            ii(0x100b_1d94, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100b_1d98, 3); cmp(eax, memd[ss, ebp - 0x30]);         /* cmp eax, [ebp-0x30] */
            ii(0x100b_1d9b, 2); if(jge(0x100b_1de5, 0x48)) goto l_0x100b_1de5; /* jge 0x100b1de5 */
            ii(0x100b_1d9d, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100b_1da0, 4); mov(memw[ss, ebp - 0x12], ax);          /* mov [ebp-0x12], ax */
            ii(0x100b_1da4, 2); jmp(0x100b_1dad, 7); goto l_0x100b_1dad; /* jmp 0x100b1dad */
        l_0x100b_1da6:
            ii(0x100b_1da6, 3); mov(eax, memd[ss, ebp - 0x12]);         /* mov eax, [ebp-0x12] */
            ii(0x100b_1da9, 4); inc(memw[ss, ebp - 0x12]);              /* inc word [ebp-0x12] */
        l_0x100b_1dad:
            ii(0x100b_1dad, 4); movsx(eax, memw[ss, ebp - 0x12]);       /* movsx eax, word [ebp-0x12] */
            ii(0x100b_1db1, 3); cmp(eax, memd[ss, ebp - 0x2c]);         /* cmp eax, [ebp-0x2c] */
            ii(0x100b_1db4, 2); if(jge(0x100b_1de3, 0x2d)) goto l_0x100b_1de3; /* jge 0x100b1de3 */
            ii(0x100b_1db6, 3); lea(edx, memd[ss, ebp - 0x14]);         /* lea edx, [ebp-0x14] */
            ii(0x100b_1db9, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x100b_1dbc, 5); call(0x1007_5e64, -0x3_bf5d);           /* call 0x10075e64 */
            ii(0x100b_1dc1, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x100b_1dc4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_1dc6, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_1dc8, 5); call(0x1011_ff4c, 0x6_e17f);            /* call 0x1011ff4c */
            ii(0x100b_1dcd, 2); test(al, al);                           /* test al, al */
            ii(0x100b_1dcf, 2); if(jz(0x100b_1de1, 0x10)) goto l_0x100b_1de1; /* jz 0x100b1de1 */
            ii(0x100b_1dd1, 4); mov(memb[ss, ebp - 0x10], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x100b_1dd5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1dd7, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_1dda, 5); call(0x1008_8d4c, -0x2_9093);           /* call 0x10088d4c */
            ii(0x100b_1ddf, 2); jmp(0x100b_1dff, 0x1e); goto l_0x100b_1dff; /* jmp 0x100b1dff */
        l_0x100b_1de1:
            ii(0x100b_1de1, 2); jmp(0x100b_1da6, -0x3d); goto l_0x100b_1da6; /* jmp 0x100b1da6 */
        l_0x100b_1de3:
            ii(0x100b_1de3, 2); jmp(0x100b_1d8d, -0x58); goto l_0x100b_1d8d; /* jmp 0x100b1d8d */
        l_0x100b_1de5:
            ii(0x100b_1de5, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100b_1de9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1deb, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100b_1dee, 5); call(0x1008_8d4c, -0x2_90a7);           /* call 0x10088d4c */
            ii(0x100b_1df3, 2); jmp(0x100b_1dff, 0xa); goto l_0x100b_1dff; /* jmp 0x100b1dff */
        //  ii(0x100b_1df5, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100b_1df7, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
        //  ii(0x100b_1dfa, 5); call(0x1008_8d4c, -0x2_90b3);           /* call 0x10088d4c */
        l_0x100b_1dff:
            ii(0x100b_1dff, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x100b_1e02, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_1e04, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_1e05, 1); pop(edi);                               /* pop edi */
            ii(0x100b_1e06, 1); pop(esi);                               /* pop esi */
            ii(0x100b_1e07, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_1e08, 1); ret();                                  /* ret */
        }
    }
}
