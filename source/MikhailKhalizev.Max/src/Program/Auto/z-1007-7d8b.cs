using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_7d8b-1e34e1a8")]
        public void Method_1007_7d8b()
        {
            ii(0x1007_7d8b, 5); push(0x38);                             /* push 0x38 */
            ii(0x1007_7d90, 5); call(Definitions.sys_check_available_stack_size, 0xe_dfbd); /* call 0x10165d52 */
            ii(0x1007_7d95, 1); push(esi);                              /* push esi */
            ii(0x1007_7d96, 1); push(edi);                              /* push edi */
            ii(0x1007_7d97, 1); push(ebp);                              /* push ebp */
            ii(0x1007_7d98, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_7d9a, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1007_7da0, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_7da3, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1007_7da6, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1007_7da9, 3); mov(memb[ss, ebp - 0x4], cl);           /* mov [ebp-0x4], cl */
            ii(0x1007_7dac, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_7daf, 5); call(0x1007_6338, -0x1a7c);             /* call 0x10076338 */
            ii(0x1007_7db4, 3); lea(ebx, memd[ss, ebp - 0x18]);         /* lea ebx, [ebp-0x18] */
            ii(0x1007_7db7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_7db9, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_7dbb, 5); call(0x1007_64b8, -0x1908);             /* call 0x100764b8 */
            ii(0x1007_7dc0, 4); mov(memb[ss, ebp - 0x1c], 0);           /* mov byte [ebp-0x1c], 0x0 */
            ii(0x1007_7dc4, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1007_7dc8, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_7dcb, 5); call(0x1007_6074, -0x1d5c);             /* call 0x10076074 */
            ii(0x1007_7dd0, 2); test(al, al);                           /* test al, al */
            ii(0x1007_7dd2, 2); if(jz(0x1007_7df1, 0x1d)) goto l_0x1007_7df1; /* jz 0x10077df1 */
            ii(0x1007_7dd4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_7dd6, 5); mov(al, memb[ds, 0x101c_37c9]);         /* mov al, [0x101c37c9] */
            ii(0x1007_7ddb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_7ddd, 2); if(jnz(0x1007_7def, 0x10)) goto l_0x1007_7def; /* jnz 0x10077def */
            ii(0x1007_7ddf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_7de1, 6); mov(dl, memb[ds, 0x101c_37c8]);         /* mov dl, [0x101c37c8] */
            ii(0x1007_7de7, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1007_7deb, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_7ded, 2); if(jnz(0x1007_7df1, 0x2)) goto l_0x1007_7df1; /* jnz 0x10077df1 */
        l_0x1007_7def:
            ii(0x1007_7def, 2); jmp(0x1007_7e04, 0x13); goto l_0x1007_7e04; /* jmp 0x10077e04 */
        l_0x1007_7df1:
            ii(0x1007_7df1, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1007_7df5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_7df7, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_7dfa, 5); call(0x1007_5f6c, -0x1e93);             /* call 0x10075f6c */
            ii(0x1007_7dff, 5); jmp(0x1007_7f7d, 0x179); goto l_0x1007_7f7d; /* jmp 0x10077f7d */
        l_0x1007_7e04:
            ii(0x1007_7e04, 2); jmp(0x1007_7e0e, 0x8); goto l_0x1007_7e0e; /* jmp 0x10077e0e */
        l_0x1007_7e06:
            ii(0x1007_7e06, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_7e09, 5); call(0x1007_6bf8, -0x1216);             /* call 0x10076bf8 */
        l_0x1007_7e0e:
            ii(0x1007_7e0e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_7e10, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_7e13, 5); call(0x1013_ad71, 0xc_2f59);            /* call 0x1013ad71 */
            ii(0x1007_7e18, 2); test(al, al);                           /* test al, al */
            ii(0x1007_7e1a, 6); if(jz(0x1007_7f61, 0x141)) goto l_0x1007_7f61; /* jz 0x10077f61 */
            ii(0x1007_7e20, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_7e23, 5); call(0x1007_63a0, -0x1a88);             /* call 0x100763a0 */
            ii(0x1007_7e28, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_7e2a, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1007_7e2d, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1007_7e31, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_7e33, 2); if(jnz(0x1007_7e43, 0xe)) goto l_0x1007_7e43; /* jnz 0x10077e43 */
            ii(0x1007_7e35, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_7e38, 5); call(0x1007_63a0, -0x1a9d);             /* call 0x100763a0 */
            ii(0x1007_7e3d, 4); cmp(memb[ds, eax + 0x50], 0);           /* cmp byte [eax+0x50], 0x0 */
            ii(0x1007_7e41, 2); if(jnz(0x1007_7e45, 0x2)) goto l_0x1007_7e45; /* jnz 0x10077e45 */
        l_0x1007_7e43:
            ii(0x1007_7e43, 2); jmp(0x1007_7e56, 0x11); goto l_0x1007_7e56; /* jmp 0x10077e56 */
        l_0x1007_7e45:
            ii(0x1007_7e45, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_7e48, 5); call(0x1007_63d4, -0x1a79);             /* call 0x100763d4 */
            ii(0x1007_7e4d, 5); call(0x100a_2edb, 0x2_b089);            /* call 0x100a2edb */
            ii(0x1007_7e52, 2); test(al, al);                           /* test al, al */
            ii(0x1007_7e54, 2); if(jnz(0x1007_7e58, 0x2)) goto l_0x1007_7e58; /* jnz 0x10077e58 */
        l_0x1007_7e56:
            ii(0x1007_7e56, 2); jmp(0x1007_7e6c, 0x14); goto l_0x1007_7e6c; /* jmp 0x10077e6c */
        l_0x1007_7e58:
            ii(0x1007_7e58, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1007_7e5b, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_7e5e, 5); call(0x1007_63d4, -0x1a8f);             /* call 0x100763d4 */
            ii(0x1007_7e63, 5); call(0x1007_7c9d, -0x1cb);              /* call 0x10077c9d */
            ii(0x1007_7e68, 2); test(al, al);                           /* test al, al */
            ii(0x1007_7e6a, 2); if(jnz(0x1007_7e71, 0x5)) goto l_0x1007_7e71; /* jnz 0x10077e71 */
        l_0x1007_7e6c:
            ii(0x1007_7e6c, 5); jmp(0x1007_7f5c, 0xeb); goto l_0x1007_7f5c; /* jmp 0x10077f5c */
        l_0x1007_7e71:
            ii(0x1007_7e71, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_7e74, 5); cmp(memw[ds, eax + 0x8], 0x29);         /* cmp word [eax+0x8], 0x29 */
            ii(0x1007_7e79, 2); if(jz(0x1007_7e85, 0xa)) goto l_0x1007_7e85; /* jz 0x10077e85 */
            ii(0x1007_7e7b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_7e7e, 5); cmp(memw[ds, eax + 0x8], 0x2a);         /* cmp word [eax+0x8], 0x2a */
            ii(0x1007_7e83, 2); if(jnz(0x1007_7e9c, 0x17)) goto l_0x1007_7e9c; /* jnz 0x10077e9c */
        l_0x1007_7e85:
            ii(0x1007_7e85, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_7e88, 5); call(0x1007_63a0, -0x1aed);             /* call 0x100763a0 */
            ii(0x1007_7e8d, 5); call(0x1007_623c, -0x1c56);             /* call 0x1007623c */
            ii(0x1007_7e92, 3); mov(eax, memd[ds, eax + 0x1b]);         /* mov eax, [eax+0x1b] */
            ii(0x1007_7e95, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_7e98, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_7e9a, 2); if(jle(0x1007_7e9e, 0x2)) goto l_0x1007_7e9e; /* jle 0x10077e9e */
        l_0x1007_7e9c:
            ii(0x1007_7e9c, 2); jmp(0x1007_7eba, 0x1c); goto l_0x1007_7eba; /* jmp 0x10077eba */
        l_0x1007_7e9e:
            ii(0x1007_7e9e, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_7ea1, 5); call(0x1007_63a0, -0x1b06);             /* call 0x100763a0 */
            ii(0x1007_7ea6, 5); call(0x1007_623c, -0x1c6f);             /* call 0x1007623c */
            ii(0x1007_7eab, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1007_7eae, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_7eb1, 3); cmp(eax, 0x6);                          /* cmp eax, 0x6 */
            ii(0x1007_7eb4, 6); if(jge(0x1007_7f5c, 0xa2)) goto l_0x1007_7f5c; /* jge 0x10077f5c */
        l_0x1007_7eba:
            ii(0x1007_7eba, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_7ebd, 5); call(0x1007_63a0, -0x1b22);             /* call 0x100763a0 */
            ii(0x1007_7ec2, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1007_7ec5, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1007_7ec8, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_7ecb, 5); call(0x1007_63a0, -0x1b30);             /* call 0x100763a0 */
            ii(0x1007_7ed0, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1007_7ed3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_7ed6, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1007_7ed9, 5); call(0x1007_6aac, -0x1432);             /* call 0x10076aac */
            ii(0x1007_7ede, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_7ee1, 5); call(0x1007_63a0, -0x1b46);             /* call 0x100763a0 */
            ii(0x1007_7ee6, 5); call(0x1007_623c, -0x1caf);             /* call 0x1007623c */
            ii(0x1007_7eeb, 4); cmp(memb[ds, eax + 0x16], 0);           /* cmp byte [eax+0x16], 0x0 */
            ii(0x1007_7eef, 2); if(jz(0x1007_7f00, 0xf)) goto l_0x1007_7f00; /* jz 0x10077f00 */
            ii(0x1007_7ef1, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1007_7ef6, 5); call(0x1007_5fdc, -0x1f1f);             /* call 0x10075fdc */
            ii(0x1007_7efb, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1007_7efe, 2); if(jge(0x1007_7f48, 0x48)) goto l_0x1007_7f48; /* jge 0x10077f48 */
        l_0x1007_7f00:
            ii(0x1007_7f00, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_7f03, 5); call(0x1007_63a0, -0x1b68);             /* call 0x100763a0 */
            ii(0x1007_7f08, 4); movzx(edi, memb[ds, eax + 0x4d]);       /* movzx edi, byte [eax+0x4d] */
            ii(0x1007_7f0c, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1007_7f11, 1); push(eax);                              /* push eax */
            ii(0x1007_7f12, 4); movsx(ecx, memb[ss, ebp - 0x4]);        /* movsx ecx, byte [ebp-0x4] */
            ii(0x1007_7f16, 3); lea(edx, memd[ss, ebp - 0x20]);         /* lea edx, [ebp-0x20] */
            ii(0x1007_7f19, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_7f1c, 5); call(0x1007_5e64, -0x20bd);             /* call 0x10075e64 */
            ii(0x1007_7f21, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1007_7f23, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_7f26, 5); call(0x1007_63d4, -0x1b57);             /* call 0x100763d4 */
            ii(0x1007_7f2b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_7f2d, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1007_7f31, 6); imul(esi, eax, 0xc5);                   /* imul esi, eax, 0xc5 */
            ii(0x1007_7f37, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x1007_7f3c, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1007_7f3e, 5); call(0x100c_20df, 0x4_a19c);            /* call 0x100c20df */
            ii(0x1007_7f43, 1); cwde();                                 /* cwde */
            ii(0x1007_7f44, 2); cmp(eax, edi);                          /* cmp eax, edi */
            ii(0x1007_7f46, 2); if(jge(0x1007_7f5c, 0x14)) goto l_0x1007_7f5c; /* jge 0x10077f5c */
        l_0x1007_7f48:
            ii(0x1007_7f48, 4); mov(memb[ss, ebp - 0x1c], 0x1);         /* mov byte [ebp-0x1c], 0x1 */
            ii(0x1007_7f4c, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1007_7f4f, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_7f52, 5); call(0x1007_63d4, -0x1b83);             /* call 0x100763d4 */
            ii(0x1007_7f57, 5); call(0x1007_7913, -0x649);              /* call 0x10077913 */
        l_0x1007_7f5c:
            ii(0x1007_7f5c, 5); jmp(0x1007_7e06, -0x15b); goto l_0x1007_7e06; /* jmp 0x10077e06 */
        l_0x1007_7f61:
            ii(0x1007_7f61, 3); mov(al, memb[ss, ebp - 0x1c]);          /* mov al, [ebp-0x1c] */
            ii(0x1007_7f64, 3); mov(memb[ss, ebp - 0x14], al);          /* mov [ebp-0x14], al */
            ii(0x1007_7f67, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_7f69, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_7f6c, 5); call(0x1007_5f6c, -0x2005);             /* call 0x10075f6c */
            ii(0x1007_7f71, 2); jmp(0x1007_7f7d, 0xa); goto l_0x1007_7f7d; /* jmp 0x10077f7d */
        //  ii(0x1007_7f73, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1007_7f75, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
        //  ii(0x1007_7f78, 5); call(0x1007_5f6c, -0x2011);             /* call 0x10075f6c */
        l_0x1007_7f7d:
            ii(0x1007_7f7d, 3); mov(al, memb[ss, ebp - 0x14]);          /* mov al, [ebp-0x14] */
            ii(0x1007_7f80, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_7f82, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_7f83, 1); pop(edi);                               /* pop edi */
            ii(0x1007_7f84, 1); pop(esi);                               /* pop esi */
            ii(0x1007_7f85, 1); ret();                                  /* ret */
        }
    }
}
