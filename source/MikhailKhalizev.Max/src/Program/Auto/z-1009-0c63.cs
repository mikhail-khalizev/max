using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c3e96b96-ecb5-41e1-866a-c2678b1bde8b")]
        public void Method_1009_0c63()
        {
            ii(0x1009_0c63, 5); pushd(0x58);                            /* push 0x58 */
            ii(0x1009_0c68, 5); calld(Definitions.sys_check_available_stack_size, 0xd_50e5); /* call 0x10165d52 */
            ii(0x1009_0c6d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_0c6e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_0c6f, 1); pushd(esi);                             /* push esi */
            ii(0x1009_0c70, 1); pushd(edi);                             /* push edi */
            ii(0x1009_0c71, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_0c72, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_0c74, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x1009_0c7a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_0c7d, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_0c80, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_0c83, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_0c86, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_0c89, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1009_0c8f, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1009_0c95, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1009_0c98, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_0c9b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_0c9e, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_0ca1, 5); calld(0x1007_6338, -0x1_a96e);          /* call 0x10076338 */
            ii(0x1009_0ca6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_0ca8, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_0cab, 5); calld(0x1007_64b8, -0x1_a7f8);          /* call 0x100764b8 */
            ii(0x1009_0cb0, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_0cb4, 2); jmpd(0x1009_0cbe, 0x8); goto l_0x1009_0cbe; /* jmp 0x10090cbe */
        l_0x1009_0cb6:
            ii(0x1009_0cb6, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_0cb9, 5); calld(0x1007_6bf8, -0x1_a0c6);          /* call 0x10076bf8 */
        l_0x1009_0cbe:
            ii(0x1009_0cbe, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_0cc0, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_0cc3, 5); calld(0x1013_ad71, 0xa_a0a9);           /* call 0x1013ad71 */
            ii(0x1009_0cc8, 2); test(al, al);                           /* test al, al */
            ii(0x1009_0cca, 6); if(jzd(0x1009_0d4c, 0x7c)) goto l_0x1009_0d4c; /* jz 0x10090d4c */
            ii(0x1009_0cd0, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_0cd3, 5); calld(0x1007_63a0, -0x1_a938);          /* call 0x100763a0 */
            ii(0x1009_0cd8, 5); cmp(memw_a32[ds, eax + 0x8], 0x21);     /* cmp word [eax+0x8], 0x21 */
            ii(0x1009_0cdd, 2); if(jzd(0x1009_0cee, 0xf)) goto l_0x1009_0cee; /* jz 0x10090cee */
            ii(0x1009_0cdf, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_0ce2, 5); calld(0x1007_63a0, -0x1_a947);          /* call 0x100763a0 */
            ii(0x1009_0ce7, 5); cmp(memw_a32[ds, eax + 0x8], 0x27);     /* cmp word [eax+0x8], 0x27 */
            ii(0x1009_0cec, 2); if(jnzd(0x1009_0cf0, 0x2)) goto l_0x1009_0cf0; /* jnz 0x10090cf0 */
        l_0x1009_0cee:
            ii(0x1009_0cee, 2); jmpd(0x1009_0d47, 0x57); goto l_0x1009_0d47; /* jmp 0x10090d47 */
        l_0x1009_0cf0:
            ii(0x1009_0cf0, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x1009_0cf3, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_0cf6, 5); calld(0x1007_63a0, -0x1_a95b);          /* call 0x100763a0 */
            ii(0x1009_0cfb, 5); calld(0x1015_2532, 0xc_1832);           /* call 0x10152532 */
            ii(0x1009_0d00, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_0d02, 1); pushd(eax);                             /* push eax */
            ii(0x1009_0d03, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1009_0d06, 5); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1009_0d0b, 1); cwde();                                 /* cwde */
            ii(0x1009_0d0c, 1); pushd(eax);                             /* push eax */
            ii(0x1009_0d0d, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1009_0d10, 5); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1009_0d15, 1); cwde();                                 /* cwde */
            ii(0x1009_0d16, 1); pushd(eax);                             /* push eax */
            ii(0x1009_0d17, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1009_0d1a, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x1009_0d1d, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1009_0d20, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1009_0d23, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x1009_0d26, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_0d29, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_0d2c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_0d2f, 5); calld(0x1009_0aaa, -0x28a);             /* call 0x10090aaa */
            ii(0x1009_0d34, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_0d37, 5); calld(0x1007_63a0, -0x1_a99c);          /* call 0x100763a0 */
            ii(0x1009_0d3c, 5); cmp(memw_a32[ds, eax + 0x8], 0x28);     /* cmp word [eax+0x8], 0x28 */
            ii(0x1009_0d41, 2); if(jnzd(0x1009_0d47, 0x4)) goto l_0x1009_0d47; /* jnz 0x10090d47 */
            ii(0x1009_0d43, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
        l_0x1009_0d47:
            ii(0x1009_0d47, 5); jmpd(0x1009_0cb6, -0x96); goto l_0x1009_0cb6; /* jmp 0x10090cb6 */
        l_0x1009_0d4c:
            ii(0x1009_0d4c, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1009_0d53, 2); jmpd(0x1009_0d5b, 0x6); goto l_0x1009_0d5b; /* jmp 0x10090d5b */
        l_0x1009_0d55:
            ii(0x1009_0d55, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_0d58, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x1009_0d5b:
            ii(0x1009_0d5b, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_0d5e, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1009_0d65, 6); if(jged(0x1009_0e42, 0xd7)) goto l_0x1009_0e42; /* jge 0x10090e42 */
            ii(0x1009_0d6b, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1009_0d6f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_0d72, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1009_0d75, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_0d77, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1009_0d7a, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1009_0d81, 2); jmpd(0x1009_0d89, 0x6); goto l_0x1009_0d89; /* jmp 0x10090d89 */
        l_0x1009_0d83:
            ii(0x1009_0d83, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_0d86, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x1009_0d89:
            ii(0x1009_0d89, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_0d8c, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1009_0d93, 6); if(jged(0x1009_0e3d, 0xa4)) goto l_0x1009_0e3d; /* jge 0x10090e3d */
            ii(0x1009_0d99, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_0d9c, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1009_0d9f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_0da1, 2); if(jzd(0x1009_0db9, 0x16)) goto l_0x1009_0db9; /* jz 0x10090db9 */
            ii(0x1009_0da3, 4); cmp(memb_a32[ss, ebp - 0xc], 0);        /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1009_0da7, 2); if(jnzd(0x1009_0db4, 0xb)) goto l_0x1009_0db4; /* jnz 0x10090db4 */
            ii(0x1009_0da9, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_0dac, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1009_0daf, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1009_0db2, 2); if(jnzd(0x1009_0db9, 0x5)) goto l_0x1009_0db9; /* jnz 0x10090db9 */
        l_0x1009_0db4:
            ii(0x1009_0db4, 5); jmpd(0x1009_0e31, 0x78); goto l_0x1009_0e31; /* jmp 0x10090e31 */
        l_0x1009_0db9:
            ii(0x1009_0db9, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1009_0dbd, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1009_0dc2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_0dc5, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1009_0dc8, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1009_0dcc, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_0dce, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_0dd0, 6); mov(edx, memd_a32[ds, 0x101c_811c]);    /* mov edx, [0x101c811c] */
            ii(0x1009_0dd6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_0dd8, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1009_0ddb, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_0dde, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1009_0de2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_0de4, 4); mov(ax, memw_a32[ss, ebp - 0x10]);      /* mov ax, [ebp-0x10] */
            ii(0x1009_0de8, 2); test(edx, eax);                         /* test edx, eax */
            ii(0x1009_0dea, 2); if(jzd(0x1009_0dfa, 0xe)) goto l_0x1009_0dfa; /* jz 0x10090dfa */
            ii(0x1009_0dec, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_0def, 5); and(eax, 0x1f);                         /* and eax, 0x1f */
            ii(0x1009_0df4, 4); cmp(ax, 0x8);                           /* cmp ax, 0x8 */
            ii(0x1009_0df8, 2); if(jged(0x1009_0dfc, 0x2)) goto l_0x1009_0dfc; /* jge 0x10090dfc */
        l_0x1009_0dfa:
            ii(0x1009_0dfa, 2); jmpd(0x1009_0e29, 0x2d); goto l_0x1009_0e29; /* jmp 0x10090e29 */
        l_0x1009_0dfc:
            ii(0x1009_0dfc, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1009_0e01, 1); pushd(eax);                             /* push eax */
            ii(0x1009_0e02, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_0e05, 1); inc(eax);                               /* inc eax */
            ii(0x1009_0e06, 1); cwde();                                 /* cwde */
            ii(0x1009_0e07, 1); pushd(eax);                             /* push eax */
            ii(0x1009_0e08, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_0e0b, 1); inc(eax);                               /* inc eax */
            ii(0x1009_0e0c, 1); cwde();                                 /* cwde */
            ii(0x1009_0e0d, 1); pushd(eax);                             /* push eax */
            ii(0x1009_0e0e, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_0e11, 1); dec(eax);                               /* dec eax */
            ii(0x1009_0e12, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1009_0e15, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_0e18, 1); dec(eax);                               /* dec eax */
            ii(0x1009_0e19, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_0e1c, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_0e1f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_0e22, 5); calld(0x1009_0aaa, -0x37d);             /* call 0x10090aaa */
            ii(0x1009_0e27, 2); jmpd(0x1009_0e31, 0x8); goto l_0x1009_0e31; /* jmp 0x10090e31 */
        l_0x1009_0e29:
            ii(0x1009_0e29, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_0e2c, 5); mov(memw_a32[ds, eax], 0x4);            /* mov word [eax], 0x4 */
        l_0x1009_0e31:
            ii(0x1009_0e31, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_0e34, 4); add(memd_a32[ss, ebp - 0x20], 0x2);     /* add dword [ebp-0x20], 0x2 */
            ii(0x1009_0e38, 5); jmpd(0x1009_0d83, -0xba); goto l_0x1009_0d83; /* jmp 0x10090d83 */
        l_0x1009_0e3d:
            ii(0x1009_0e3d, 5); jmpd(0x1009_0d55, -0xed); goto l_0x1009_0d55; /* jmp 0x10090d55 */
        l_0x1009_0e42:
            ii(0x1009_0e42, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_0e44, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_0e47, 5); calld(0x1007_5f6c, -0x1_aee0);          /* call 0x10075f6c */
            ii(0x1009_0e4c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_0e4e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_0e4f, 1); popd(edi);                              /* pop edi */
            ii(0x1009_0e50, 1); popd(esi);                              /* pop esi */
            ii(0x1009_0e51, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_0e52, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_0e53, 1); retd(); return;                         /* ret */
        }
    }
}
