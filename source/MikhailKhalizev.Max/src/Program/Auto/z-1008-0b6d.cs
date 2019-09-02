using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_0b6d-953a9515")]
        public void Method_1008_0b6d()
        {
            ii(0x1008_0b6d, 5); push(0x50);                             /* push 0x50 */
            ii(0x1008_0b72, 5); call(Definitions.sys_check_available_stack_size, 0xe_51db); /* call 0x10165d52 */
            ii(0x1008_0b77, 1); push(ebx);                              /* push ebx */
            ii(0x1008_0b78, 1); push(ecx);                              /* push ecx */
            ii(0x1008_0b79, 1); push(edx);                              /* push edx */
            ii(0x1008_0b7a, 1); push(esi);                              /* push esi */
            ii(0x1008_0b7b, 1); push(edi);                              /* push edi */
            ii(0x1008_0b7c, 1); push(ebp);                              /* push ebp */
            ii(0x1008_0b7d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_0b7f, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x1008_0b85, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_0b88, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_0b8b, 3); mov(eax, memd[ds, eax + 27]);           /* mov eax, [eax+0x1b] */
            ii(0x1008_0b8e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_0b91, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_0b93, 2); if(jle(0x1008_0b9b, 6)) goto l_0x1008_0b9b; /* jle 0x10080b9b */
            ii(0x1008_0b95, 4); mov(memb[ss, ebp - 12], 1);             /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_0b99, 2); jmp(0x1008_0b9f, 4); goto l_0x1008_0b9f; /* jmp 0x10080b9f */
        l_0x1008_0b9b:
            ii(0x1008_0b9b, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
        l_0x1008_0b9f:
            ii(0x1008_0b9f, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x1008_0ba2, 3); mov(memb[ss, ebp - 20], al);            /* mov [ebp-0x14], al */
            ii(0x1008_0ba5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_0ba8, 3); mov(eax, memd[ds, eax + 29]);           /* mov eax, [eax+0x1d] */
            ii(0x1008_0bab, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_0bae, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_0bb0, 2); if(jle(0x1008_0bb8, 6)) goto l_0x1008_0bb8; /* jle 0x10080bb8 */
            ii(0x1008_0bb2, 4); mov(memb[ss, ebp - 16], 1);             /* mov byte [ebp-0x10], 0x1 */
            ii(0x1008_0bb6, 2); jmp(0x1008_0bbc, 4); goto l_0x1008_0bbc; /* jmp 0x10080bbc */
        l_0x1008_0bb8:
            ii(0x1008_0bb8, 4); mov(memb[ss, ebp - 16], 0);             /* mov byte [ebp-0x10], 0x0 */
        l_0x1008_0bbc:
            ii(0x1008_0bbc, 3); mov(al, memb[ss, ebp - 16]);            /* mov al, [ebp-0x10] */
            ii(0x1008_0bbf, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x1008_0bc2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_0bc5, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_0bc8, 5); call(0x1007_6338, -0xa895);             /* call 0x10076338 */
            ii(0x1008_0bcd, 3); lea(ebx, memd[ss, ebp - 28]);           /* lea ebx, [ebp-0x1c] */
            ii(0x1008_0bd0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_0bd2, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_0bd4, 5); call(0x1007_64b8, -0xa721);             /* call 0x100764b8 */
            ii(0x1008_0bd9, 2); jmp(0x1008_0be3, 8); goto l_0x1008_0be3; /* jmp 0x10080be3 */
        l_0x1008_0bdb:
            ii(0x1008_0bdb, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1008_0bde, 5); call(0x1007_6bf8, -0x9feb);             /* call 0x10076bf8 */
        l_0x1008_0be3:
            ii(0x1008_0be3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_0be5, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1008_0be8, 5); call(0x1013_ad71, 0xb_a184);            /* call 0x1013ad71 */
            ii(0x1008_0bed, 2); test(al, al);                           /* test al, al */
            ii(0x1008_0bef, 2); if(jz(0x1008_0c0c, 0x1b)) goto l_0x1008_0c0c; /* jz 0x10080c0c */
            ii(0x1008_0bf1, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1008_0bf4, 5); call(0x1007_63a0, -0xa859);             /* call 0x100763a0 */
            ii(0x1008_0bf9, 5); cmp(memw[ds, eax + 8], 0x38);           /* cmp word [eax+0x8], 0x38 */
            ii(0x1008_0bfe, 2); if(jnz(0x1008_0c06, 6)) goto l_0x1008_0c06; /* jnz 0x10080c06 */
            ii(0x1008_0c00, 4); mov(memb[ss, ebp - 20], 1);             /* mov byte [ebp-0x14], 0x1 */
            ii(0x1008_0c04, 2); jmp(0x1008_0c0a, 4); goto l_0x1008_0c0a; /* jmp 0x10080c0a */
        l_0x1008_0c06:
            ii(0x1008_0c06, 4); mov(memb[ss, ebp - 8], 1);              /* mov byte [ebp-0x8], 0x1 */
        l_0x1008_0c0a:
            ii(0x1008_0c0a, 2); jmp(0x1008_0bdb, -0x31); goto l_0x1008_0bdb; /* jmp 0x10080bdb */
        l_0x1008_0c0c:
            ii(0x1008_0c0c, 4); cmp(memb[ss, ebp - 20], 0);             /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1008_0c10, 2); if(jz(0x1008_0c1c, 0xa)) goto l_0x1008_0c1c; /* jz 0x10080c1c */
            ii(0x1008_0c12, 4); cmp(memb[ss, ebp - 8], 0);              /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1008_0c16, 6); if(jnz(0x1008_0cc5, 0xa9)) goto l_0x1008_0cc5; /* jnz 0x10080cc5 */
        l_0x1008_0c1c:
            ii(0x1008_0c1c, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x1008_0c21, 5); call(Definitions.sys_new, 0xe_51da);    /* call 0x10165e00 */
            ii(0x1008_0c26, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1008_0c29, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1008_0c2c, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x1008_0c2f, 4); cmp(memd[ss, ebp - 36], 0);             /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1008_0c33, 2); if(jz(0x1008_0c58, 0x23)) goto l_0x1008_0c58; /* jz 0x10080c58 */
            ii(0x1008_0c35, 3); lea(edx, memd[ss, ebp - 40]);           /* lea edx, [ebp-0x28] */
            ii(0x1008_0c38, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_0c3b, 5); call(0x100a_2d3d, 0x2_20fd);            /* call 0x100a2d3d */
            ii(0x1008_0c40, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_0c42, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_0c45, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1008_0c48, 5); call(Definitions.my_ctor_c12, 0x2_541f); /* call 0x100a606c */
            ii(0x1008_0c4d, 3); mov(memd[ss, ebp - 44], eax);           /* mov [ebp-0x2c], eax */
            ii(0x1008_0c50, 3); mov(eax, memd[ss, ebp - 44]);           /* mov eax, [ebp-0x2c] */
            ii(0x1008_0c53, 3); mov(memd[ss, ebp - 48], eax);           /* mov [ebp-0x30], eax */
            ii(0x1008_0c56, 2); jmp(0x1008_0c5e, 6); goto l_0x1008_0c5e; /* jmp 0x10080c5e */
        l_0x1008_0c58:
            ii(0x1008_0c58, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x1008_0c5b, 3); mov(memd[ss, ebp - 48], eax);           /* mov [ebp-0x30], eax */
        l_0x1008_0c5e:
            ii(0x1008_0c5e, 3); mov(edx, memd[ss, ebp - 48]);           /* mov edx, [ebp-0x30] */
            ii(0x1008_0c61, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x1008_0c64, 5); call(0x1008_a914, 0x9cab);              /* call 0x1008a914 */
            ii(0x1008_0c69, 4); cmp(memb[ss, ebp - 20], 0);             /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1008_0c6d, 2); if(jnz(0x1008_0c88, 0x19)) goto l_0x1008_0c88; /* jnz 0x10080c88 */
            ii(0x1008_0c6f, 5); mov(edx, 0x38);                         /* mov edx, 0x38 */
            ii(0x1008_0c74, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x1008_0c77, 5); call(0x1008_a7dc, 0x9b60);              /* call 0x1008a7dc */
            ii(0x1008_0c7c, 5); call(0x100a_63bc, 0x2_573b);            /* call 0x100a63bc */
            ii(0x1008_0c81, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_0c84, 4); inc(memw[ds, eax + 29]);                /* inc word [eax+0x1d] */
        l_0x1008_0c88:
            ii(0x1008_0c88, 4); cmp(memb[ss, ebp - 8], 0);              /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1008_0c8c, 2); if(jnz(0x1008_0ca7, 0x19)) goto l_0x1008_0ca7; /* jnz 0x10080ca7 */
            ii(0x1008_0c8e, 5); mov(edx, 0x4a);                         /* mov edx, 0x4a */
            ii(0x1008_0c93, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x1008_0c96, 5); call(0x1008_a7dc, 0x9b41);              /* call 0x1008a7dc */
            ii(0x1008_0c9b, 5); call(0x100a_63bc, 0x2_571c);            /* call 0x100a63bc */
            ii(0x1008_0ca0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_0ca3, 4); inc(memw[ds, eax + 31]);                /* inc word [eax+0x1f] */
        l_0x1008_0ca7:
            ii(0x1008_0ca7, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x1008_0caa, 5); call(0x1008_a838, 0x9b89);              /* call 0x1008a838 */
            ii(0x1008_0caf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_0cb1, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_0cb6, 5); call(0x100a_4d50, 0x2_4095);            /* call 0x100a4d50 */
            ii(0x1008_0cbb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_0cbd, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x1008_0cc0, 5); call(0x1008_8cbc, 0x7ff7);              /* call 0x10088cbc */
        l_0x1008_0cc5:
            ii(0x1008_0cc5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_0cc8, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1008_0ccb, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1008_0cce, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1008_0cd1, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1008_0cd4, 3); call_abs(memd[ds, edx + 60]);           /* call dword [edx+0x3c] */
            ii(0x1008_0cd7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_0cd9, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1008_0cdc, 5); call(0x1007_5f6c, -0xad75);             /* call 0x10075f6c */
            ii(0x1008_0ce1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_0ce3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_0ce4, 1); pop(edi);                               /* pop edi */
            ii(0x1008_0ce5, 1); pop(esi);                               /* pop esi */
            ii(0x1008_0ce6, 1); pop(edx);                               /* pop edx */
            ii(0x1008_0ce7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_0ce8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_0ce9, 1); ret();                                  /* ret */
        }
    }
}
