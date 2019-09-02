using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_7b80-6b1d6ae8")]
        public void /* sys */ Method_1016_7b80()
        {
            ii(0x1016_7b80, 1); push(ebx);                              /* push ebx */
            ii(0x1016_7b81, 1); push(ecx);                              /* push ecx */
            ii(0x1016_7b82, 1); push(edx);                              /* push edx */
            ii(0x1016_7b83, 1); push(esi);                              /* push esi */
            ii(0x1016_7b84, 1); push(edi);                              /* push edi */
            ii(0x1016_7b85, 1); push(ebp);                              /* push ebp */
            ii(0x1016_7b86, 3); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1016_7b89, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_7b8b, 5); call(/* sys */ 0x1016_7dac, 0x21c);     /* call 0x10167dac */
            ii(0x1016_7b90, 6); mov(edi, memd[ds, 0x101b_ddbc]);        /* mov edi, [0x101bddbc] */
            ii(0x1016_7b96, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_7b98, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1016_7b9a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_7b9c, 2); xor(ebp, ebp);                          /* xor ebp, ebp */
            ii(0x1016_7b9e, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1016_7ba0, 6); if(jz(0x1016_7d10, 0x16a)) goto l_0x1016_7d10; /* jz 0x10167d10 */
            ii(0x1016_7ba6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_7ba8, 6); if(jz(0x1016_7d10, 0x162)) goto l_0x1016_7d10; /* jz 0x10167d10 */
            ii(0x1016_7bae, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_7bb0, 2); mov(edi, esp);                          /* mov edi, esp */
            ii(0x1016_7bb2, 5); call(/* sys */ 0x1016_72d4, -0x8e3);    /* call 0x101672d4 */
            ii(0x1016_7bb7, 3); lea(esi, memd[ds, esi + 8]);            /* lea esi, [esi+0x8] */
            ii(0x1016_7bba, 1); movsd();                                /* movsd */
            ii(0x1016_7bbb, 1); movsd();                                /* movsd */
            ii(0x1016_7bbc, 1); movsd();                                /* movsd */
            ii(0x1016_7bbd, 1); movsd();                                /* movsd */
            ii(0x1016_7bbe, 5); call(/* sys */ 0x1016_b390, 0x37cd);    /* call 0x1016b390 */
            ii(0x1016_7bc3, 5); call(/* sys */ 0x1018_63bc, 0x1_e7f4);  /* call 0x101863bc */
            ii(0x1016_7bc8, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x1016_7bcb, 2); if(jz(0x1016_7bd2, 5)) goto l_0x1016_7bd2; /* jz 0x10167bd2 */
            ii(0x1016_7bcd, 5); call(/* sys */ 0x1016_be9c, 0x42ca);    /* call 0x1016be9c */
        l_0x1016_7bd2:
            ii(0x1016_7bd2, 3); lea(eax, memd[ds, ecx + 8]);            /* lea eax, [ecx+0x8] */
            ii(0x1016_7bd5, 4); mov(memd[ss, esp + 24], eax);           /* mov [esp+0x18], eax */
        l_0x1016_7bd9:
            ii(0x1016_7bd9, 5); call(/* sys */ 0x1016_c348, 0x476a);    /* call 0x1016c348 */
            ii(0x1016_7bde, 2); test(al, 0x30);                         /* test al, 0x30 */
            ii(0x1016_7be0, 6); if(jnz(0x1016_7cf7, 0x111)) goto l_0x1016_7cf7; /* jnz 0x10167cf7 */
            ii(0x1016_7be6, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_7be8, 2); if(jnz(0x1016_7bee, 4)) goto l_0x1016_7bee; /* jnz 0x10167bee */
            ii(0x1016_7bea, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1016_7bec, 2); if(jz(0x1016_7c58, 0x6a)) goto l_0x1016_7c58; /* jz 0x10167c58 */
        l_0x1016_7bee:
            ii(0x1016_7bee, 3); mov(eax, memd[ds, ecx + 8]);            /* mov eax, [ecx+0x8] */
            ii(0x1016_7bf1, 3); mov(edx, memd[ds, ecx + 12]);           /* mov edx, [ecx+0xc] */
            ii(0x1016_7bf4, 3); mov(esi, memd[ds, ecx + 16]);           /* mov esi, [ecx+0x10] */
            ii(0x1016_7bf7, 3); mov(edi, memd[ds, ecx + 20]);           /* mov edi, [ecx+0x14] */
            ii(0x1016_7bfa, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1016_7bfc, 2); add(edx, ebp);                          /* add edx, ebp */
            ii(0x1016_7bfe, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1016_7c00, 3); mov(memd[ds, ecx + 8], eax);            /* mov [ecx+0x8], eax */
            ii(0x1016_7c03, 2); add(edi, ebp);                          /* add edi, ebp */
            ii(0x1016_7c05, 3); mov(memd[ds, ecx + 12], edx);           /* mov [ecx+0xc], edx */
            ii(0x1016_7c08, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_7c0a, 3); mov(memd[ds, ecx + 16], esi);           /* mov [ecx+0x10], esi */
            ii(0x1016_7c0d, 4); mov(edx, memd[ss, esp + 24]);           /* mov edx, [esp+0x18] */
            ii(0x1016_7c11, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_7c13, 3); mov(memd[ds, ecx + 20], edi);           /* mov [ecx+0x14], edi */
            ii(0x1016_7c16, 5); call(/* sys */ 0x1016_7500, -0x71b);    /* call 0x10167500 */
            ii(0x1016_7c1b, 4); mov(edx, memd[ss, esp + 24]);           /* mov edx, [esp+0x18] */
            ii(0x1016_7c1f, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1016_7c21, 5); call(/* sys */ 0x1018_5dd0, 0x1_e1aa);  /* call 0x10185dd0 */
            ii(0x1016_7c26, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_7c28, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_7c2a, 2); if(jz(0x1016_7c4f, 0x23)) goto l_0x1016_7c4f; /* jz 0x10167c4f */
        l_0x1016_7c2c:
            ii(0x1016_7c2c, 6); mov(ebp, memd[ds, 0x101b_ddbc]);        /* mov ebp, [0x101bddbc] */
            ii(0x1016_7c32, 3); mov(edi, memd[ds, esi + 16]);           /* mov edi, [esi+0x10] */
            ii(0x1016_7c35, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1016_7c37, 2); if(jz(0x1016_7c42, 9)) goto l_0x1016_7c42; /* jz 0x10167c42 */
            ii(0x1016_7c39, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_7c3b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_7c3d, 5); call(/* sys */ 0x1016_7d38, 0xf6);      /* call 0x10167d38 */
        l_0x1016_7c42:
            ii(0x1016_7c42, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_7c44, 5); call(/* sys */ 0x1018_5f28, 0x1_e2df);  /* call 0x10185f28 */
            ii(0x1016_7c49, 2); mov(esi, edi);                          /* mov esi, edi */
            ii(0x1016_7c4b, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1016_7c4d, 2); if(jnz(0x1016_7c2c, -0x23)) goto l_0x1016_7c2c; /* jnz 0x10167c2c */
        l_0x1016_7c4f:
            ii(0x1016_7c4f, 2); mov(edi, esp);                          /* mov edi, esp */
            ii(0x1016_7c51, 3); lea(esi, memd[ds, ecx + 8]);            /* lea esi, [ecx+0x8] */
            ii(0x1016_7c54, 1); movsd();                                /* movsd */
            ii(0x1016_7c55, 1); movsd();                                /* movsd */
            ii(0x1016_7c56, 1); movsd();                                /* movsd */
            ii(0x1016_7c57, 1); movsd();                                /* movsd */
        l_0x1016_7c58:
            ii(0x1016_7c58, 4); lea(edx, memd[ss, esp + 16]);           /* lea edx, [esp+0x10] */
            ii(0x1016_7c5c, 4); lea(eax, memd[ss, esp + 20]);           /* lea eax, [esp+0x14] */
            ii(0x1016_7c60, 5); call(/* sys */ 0x1016_c298, 0x4633);    /* call 0x1016c298 */
            ii(0x1016_7c65, 5); call(/* sys */ 0x1016_b390, 0x3726);    /* call 0x1016b390 */
            ii(0x1016_7c6a, 5); call(/* sys */ 0x1018_63bc, 0x1_e74d);  /* call 0x101863bc */
            ii(0x1016_7c6f, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x1016_7c72, 2); if(jz(0x1016_7c79, 5)) goto l_0x1016_7c79; /* jz 0x10167c79 */
            ii(0x1016_7c74, 5); call(/* sys */ 0x1016_be9c, 0x4223);    /* call 0x1016be9c */
        l_0x1016_7c79:
            ii(0x1016_7c79, 4); mov(ebx, memd[ss, esp + 20]);           /* mov ebx, [esp+0x14] */
            ii(0x1016_7c7d, 4); lea(edx, memd[ss, esp + 16]);           /* lea edx, [esp+0x10] */
            ii(0x1016_7c81, 4); lea(eax, memd[ss, esp + 20]);           /* lea eax, [esp+0x14] */
            ii(0x1016_7c85, 4); mov(ebp, memd[ss, esp + 16]);           /* mov ebp, [esp+0x10] */
            ii(0x1016_7c89, 5); call(/* sys */ 0x1016_c298, 0x460a);    /* call 0x1016c298 */
            ii(0x1016_7c8e, 4); mov(eax, memd[ss, esp + 20]);           /* mov eax, [esp+0x14] */
            ii(0x1016_7c92, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1016_7c94, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_7c96, 4); mov(eax, memd[ss, esp + 16]);           /* mov eax, [esp+0x10] */
            ii(0x1016_7c9a, 2); sub(eax, ebp);                          /* sub eax, ebp */
            ii(0x1016_7c9c, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1016_7c9e, 3); mov(eax, memd[ds, ecx + 8]);            /* mov eax, [ecx+0x8] */
            ii(0x1016_7ca1, 6); mov(edx, memd[ds, 0x1020_88e0]);        /* mov edx, [0x102088e0] */
            ii(0x1016_7ca7, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1016_7ca9, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1016_7cab, 2); if(jge(0x1016_7cb2, 5)) goto l_0x1016_7cb2; /* jge 0x10167cb2 */
            ii(0x1016_7cad, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1016_7caf, 3); sub(ebx, memd[ds, ecx + 8]);            /* sub ebx, [ecx+0x8] */
        l_0x1016_7cb2:
            ii(0x1016_7cb2, 3); mov(eax, memd[ds, ecx + 16]);           /* mov eax, [ecx+0x10] */
            ii(0x1016_7cb5, 6); mov(edi, memd[ds, 0x1020_88e8]);        /* mov edi, [0x102088e8] */
            ii(0x1016_7cbb, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1016_7cbd, 2); cmp(eax, edi);                          /* cmp eax, edi */
            ii(0x1016_7cbf, 2); if(jle(0x1016_7cc6, 5)) goto l_0x1016_7cc6; /* jle 0x10167cc6 */
            ii(0x1016_7cc1, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1016_7cc3, 3); sub(ebx, memd[ds, ecx + 16]);           /* sub ebx, [ecx+0x10] */
        l_0x1016_7cc6:
            ii(0x1016_7cc6, 3); mov(eax, memd[ds, ecx + 12]);           /* mov eax, [ecx+0xc] */
            ii(0x1016_7cc9, 6); mov(edx, memd[ds, 0x1020_88e4]);        /* mov edx, [0x102088e4] */
            ii(0x1016_7ccf, 2); add(eax, ebp);                          /* add eax, ebp */
            ii(0x1016_7cd1, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1016_7cd3, 2); if(jge(0x1016_7cda, 5)) goto l_0x1016_7cda; /* jge 0x10167cda */
            ii(0x1016_7cd5, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1016_7cd7, 3); sub(ebp, memd[ds, ecx + 12]);           /* sub ebp, [ecx+0xc] */
        l_0x1016_7cda:
            ii(0x1016_7cda, 3); mov(eax, memd[ds, ecx + 20]);           /* mov eax, [ecx+0x14] */
            ii(0x1016_7cdd, 6); mov(edi, memd[ds, 0x1020_88ec]);        /* mov edi, [0x102088ec] */
            ii(0x1016_7ce3, 2); add(eax, ebp);                          /* add eax, ebp */
            ii(0x1016_7ce5, 2); cmp(eax, edi);                          /* cmp eax, edi */
            ii(0x1016_7ce7, 6); if(jle(0x1016_7bd9, -0x114)) goto l_0x1016_7bd9; /* jle 0x10167bd9 */
            ii(0x1016_7ced, 2); mov(ebp, edi);                          /* mov ebp, edi */
            ii(0x1016_7cef, 3); sub(ebp, memd[ds, ecx + 20]);           /* sub ebp, [ecx+0x14] */
            ii(0x1016_7cf2, 5); jmp(0x1016_7bd9, -0x11e); goto l_0x1016_7bd9; /* jmp 0x10167bd9 */
        l_0x1016_7cf7:
            ii(0x1016_7cf7, 4); test(memb[ds, ecx + 5], 1);             /* test byte [ecx+0x5], 0x1 */
            ii(0x1016_7cfb, 2); if(jz(0x1016_7d10, 0x13)) goto l_0x1016_7d10; /* jz 0x10167d10 */
            ii(0x1016_7cfd, 4); test(memb[ds, ecx + 8], 3);             /* test byte [ecx+0x8], 0x3 */
            ii(0x1016_7d01, 2); if(jz(0x1016_7d10, 0xd)) goto l_0x1016_7d10; /* jz 0x10167d10 */
            ii(0x1016_7d03, 3); mov(ebx, memd[ds, ecx + 12]);           /* mov ebx, [ecx+0xc] */
            ii(0x1016_7d06, 3); mov(edx, memd[ds, ecx + 8]);            /* mov edx, [ecx+0x8] */
            ii(0x1016_7d09, 2); mov(eax, memd[ds, ecx]);                /* mov eax, [ecx] */
            ii(0x1016_7d0b, 5); call(/* sys */ 0x1016_73c8, -0x948);    /* call 0x101673c8 */
        l_0x1016_7d10:
            ii(0x1016_7d10, 3); add(esp, 0x1c);                         /* add esp, 0x1c */
            ii(0x1016_7d13, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_7d14, 1); pop(edi);                               /* pop edi */
            ii(0x1016_7d15, 1); pop(esi);                               /* pop esi */
            ii(0x1016_7d16, 1); pop(edx);                               /* pop edx */
            ii(0x1016_7d17, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_7d18, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_7d19, 1); ret();                                  /* ret */
        }
    }
}
