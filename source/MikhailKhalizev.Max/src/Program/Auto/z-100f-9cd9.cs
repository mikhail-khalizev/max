using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_9cd9-5db90229")]
        public void Method_100f_9cd9()
        {
            ii(0x100f_9cd9, 6); mov(ax, memw[ds, 0x101c_38cc]);         /* mov ax, [0x101c38cc] */
            ii(0x100f_9cdf, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x100f_9ce2, 3); sub(ax, memw[ds, edx]);                 /* sub ax, [edx] */
            ii(0x100f_9ce5, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x100f_9ce8, 6); mov(ax, memw[ds, 0x101c_38d0]);         /* mov ax, [0x101c38d0] */
            ii(0x100f_9cee, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x100f_9cf1, 4); sub(ax, memw[ds, edx + 0x4]);           /* sub ax, [edx+0x4] */
            ii(0x100f_9cf5, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100f_9cf8, 6); mov(ebx, memd[ds, 0x101c_8170]);        /* mov ebx, [0x101c8170] */
            ii(0x100f_9cfe, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_9d01, 1); dec(ebx);                               /* dec ebx */
            ii(0x100f_9d02, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_9d04, 4); movsx(eax, memw[ss, ebp - 0x48]);       /* movsx eax, word [ebp-0x48] */
            ii(0x100f_9d08, 5); call(0x1007_6e7c, -0x8_2e91);           /* call 0x10076e7c */
            ii(0x100f_9d0d, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100f_9d0f, 5); call(Definitions.my_min, -0x7_0590);    /* call 0x10089784 */
            ii(0x100f_9d14, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x100f_9d17, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x100f_9d1c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_9d1f, 3); lea(ebx, eax - 0x1);                    /* lea ebx, [eax-0x1] */
            ii(0x100f_9d22, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_9d24, 4); movsx(eax, memw[ss, ebp - 0x4c]);       /* movsx eax, word [ebp-0x4c] */
            ii(0x100f_9d28, 5); call(0x1007_6e7c, -0x8_2eb1);           /* call 0x10076e7c */
            ii(0x100f_9d2d, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100f_9d2f, 5); call(Definitions.my_min, -0x7_05b0);    /* call 0x10089784 */
            ii(0x100f_9d34, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100f_9d37, 7); cmp(memb[ds, 0x101c_37d0], 0);          /* cmp byte [0x101c37d0], 0x0 */
            ii(0x100f_9d3e, 2); if(jz(0x100f_9d6a, 0x2a)) goto l_0x100f_9d6a; /* jz 0x100f9d6a */
            ii(0x100f_9d40, 4); movsx(eax, memw[ss, ebp - 0x48]);       /* movsx eax, word [ebp-0x48] */
            ii(0x100f_9d44, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100f_9d46, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_9d48, 5); mov(eax, memd[ds, 0x101c_38e4]);        /* mov eax, [0x101c38e4] */
            ii(0x100f_9d4d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_9d50, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_9d52, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x100f_9d55, 4); movsx(eax, memw[ss, ebp - 0x4c]);       /* movsx eax, word [ebp-0x4c] */
            ii(0x100f_9d59, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100f_9d5b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_9d5d, 5); mov(eax, memd[ds, 0x101c_38e6]);        /* mov eax, [0x101c38e6] */
            ii(0x100f_9d62, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_9d65, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_9d67, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
        l_0x100f_9d6a:
            ii(0x100f_9d6a, 7); test(memb[ds, 0x101c_38d4], 0x11);      /* test byte [0x101c38d4], 0x11 */
            ii(0x100f_9d71, 2); if(jz(0x100f_9d93, 0x20)) goto l_0x100f_9d93; /* jz 0x100f9d93 */
            ii(0x100f_9d73, 5); call(0x1010_2acc, 0x8d54);              /* call 0x10102acc */
            ii(0x100f_9d78, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_9d7a, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x100f_9d7c, 4); movsx(ebx, memw[ss, ebp - 0x4c]);       /* movsx ebx, word [ebp-0x4c] */
            ii(0x100f_9d80, 4); movsx(edx, memw[ss, ebp - 0x48]);       /* movsx edx, word [ebp-0x48] */
            ii(0x100f_9d84, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_9d89, 5); call(0x1010_1620, 0x7892);              /* call 0x10101620 */
            ii(0x100f_9d8e, 5); jmp(0x100f_9e10, 0x7d); goto l_0x100f_9e10; /* jmp 0x100f9e10 */
        l_0x100f_9d93:
            ii(0x100f_9d93, 7); test(memb[ds, 0x101c_38d4], 0x20);      /* test byte [0x101c38d4], 0x20 */
            ii(0x100f_9d9a, 6); if(jz(0x100f_9e10, 0x70)) goto l_0x100f_9e10; /* jz 0x100f9e10 */
            ii(0x100f_9da0, 4); movsx(edx, memw[ss, ebp - 0x4c]);       /* movsx edx, word [ebp-0x4c] */
            ii(0x100f_9da4, 4); movsx(eax, memw[ss, ebp - 0x48]);       /* movsx eax, word [ebp-0x48] */
            ii(0x100f_9da8, 5); call(0x100f_7fb2, -0x1dfb);             /* call 0x100f7fb2 */
            ii(0x100f_9dad, 3); mov(memb[ss, ebp - 0x50], al);          /* mov [ebp-0x50], al */
            ii(0x100f_9db0, 4); cmp(memb[ss, ebp - 0x50], 0x14);        /* cmp byte [ebp-0x50], 0x14 */
            ii(0x100f_9db4, 2); if(jz(0x100f_9dbc, 0x6)) goto l_0x100f_9dbc; /* jz 0x100f9dbc */
            ii(0x100f_9db6, 4); cmp(memb[ss, ebp - 0x50], 0x16);        /* cmp byte [ebp-0x50], 0x16 */
            ii(0x100f_9dba, 2); if(jnz(0x100f_9e10, 0x54)) goto l_0x100f_9e10; /* jnz 0x100f9e10 */
        l_0x100f_9dbc:
            ii(0x100f_9dbc, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_9dc1, 5); call(0x1007_6574, -0x8_3852);           /* call 0x10076574 */
            ii(0x100f_9dc6, 4); cmp(memb[ds, eax + 0x3e], 0x1f);        /* cmp byte [eax+0x3e], 0x1f */
            ii(0x100f_9dca, 2); if(jz(0x100f_9e10, 0x44)) goto l_0x100f_9e10; /* jz 0x100f9e10 */
            ii(0x100f_9dcc, 4); movsx(eax, memw[ss, ebp - 0x4c]);       /* movsx eax, word [ebp-0x4c] */
            ii(0x100f_9dd0, 3); mov(memd[ss, ebp - 0x54], eax);         /* mov [ebp-0x54], eax */
            ii(0x100f_9dd3, 3); push(memd[ss, ebp - 0x54]);             /* push dword [ebp-0x54] */
            ii(0x100f_9dd6, 4); movsx(eax, memw[ss, ebp - 0x48]);       /* movsx eax, word [ebp-0x48] */
            ii(0x100f_9dda, 3); mov(memd[ss, ebp - 0x58], eax);         /* mov [ebp-0x58], eax */
            ii(0x100f_9ddd, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_9de2, 5); call(0x1007_65d0, -0x8_3817);           /* call 0x100765d0 */
            ii(0x100f_9de7, 3); mov(memd[ss, ebp - 0x5c], eax);         /* mov [ebp-0x5c], eax */
            ii(0x100f_9dea, 4); cmp(memb[ss, ebp - 0x50], 0x14);        /* cmp byte [ebp-0x50], 0x14 */
            ii(0x100f_9dee, 2); if(jnz(0x100f_9df6, 0x6)) goto l_0x100f_9df6; /* jnz 0x100f9df6 */
            ii(0x100f_9df0, 4); mov(memb[ss, ebp - 0x60], 0);           /* mov byte [ebp-0x60], 0x0 */
            ii(0x100f_9df4, 2); jmp(0x100f_9dfa, 0x4); goto l_0x100f_9dfa; /* jmp 0x100f9dfa */
        l_0x100f_9df6:
            ii(0x100f_9df6, 4); mov(memb[ss, ebp - 0x60], 0x1c);        /* mov byte [ebp-0x60], 0x1c */
        l_0x100f_9dfa:
            ii(0x100f_9dfa, 3); mov(edx, memd[ss, ebp - 0x63]);         /* mov edx, [ebp-0x63] */
            ii(0x100f_9dfd, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x100f_9e00, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100f_9e05, 3); mov(ecx, memd[ss, ebp - 0x58]);         /* mov ecx, [ebp-0x58] */
            ii(0x100f_9e08, 3); mov(ebx, memd[ss, ebp - 0x5c]);         /* mov ebx, [ebp-0x5c] */
            ii(0x100f_9e0b, 5); call(0x100f_79d4, -0x243c);             /* call 0x100f79d4 */
        l_0x100f_9e10:
            ii(0x100f_9e10, 5); if(jmp_func(0x100f_a7df, 0x9ca)) return; /* jmp 0x100fa7df */
        }
    }
}
