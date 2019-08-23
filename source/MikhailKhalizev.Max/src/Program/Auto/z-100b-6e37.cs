using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_6e37-c8bda587")]
        public void Method_100b_6e37()
        {
            ii(0x100b_6e37, 5); push(0x5c);                             /* push 0x5c */
            ii(0x100b_6e3c, 5); call(Definitions.sys_check_available_stack_size, 0xa_ef11); /* call 0x10165d52 */
            ii(0x100b_6e41, 1); push(ecx);                              /* push ecx */
            ii(0x100b_6e42, 1); push(esi);                              /* push esi */
            ii(0x100b_6e43, 1); push(edi);                              /* push edi */
            ii(0x100b_6e44, 1); push(ebp);                              /* push ebp */
            ii(0x100b_6e45, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_6e47, 6); sub(esp, 0x48);                         /* sub esp, 0x48 */
            ii(0x100b_6e4d, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_6e50, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100b_6e53, 3); mov(memb[ss, ebp - 0x4], bl);           /* mov [ebp-0x4], bl */
            ii(0x100b_6e56, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100b_6e5a, 6); if(jnz(0x100b_7062, 0x202)) goto l_0x100b_7062; /* jnz 0x100b7062 */
            ii(0x100b_6e60, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_6e63, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x100b_6e66, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_6e69, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_6e6b, 2); if(jle(0x100b_6e7c, 0xf)) goto l_0x100b_6e7c; /* jle 0x100b6e7c */
            ii(0x100b_6e6d, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100b_6e70, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_6e73, 5); call(0x1015_2a52, 0x9_bbda);            /* call 0x10152a52 */
            ii(0x100b_6e78, 2); test(al, al);                           /* test al, al */
            ii(0x100b_6e7a, 2); if(jnz(0x100b_6e81, 0x5)) goto l_0x100b_6e81; /* jnz 0x100b6e81 */
        l_0x100b_6e7c:
            ii(0x100b_6e7c, 5); jmp(0x100b_7051, 0x1d0); goto l_0x100b_7051; /* jmp 0x100b7051 */
        l_0x100b_6e81:
            ii(0x100b_6e81, 4); or(memb[ss, ebp - 0x10], 0x1);          /* or byte [ebp-0x10], 0x1 */
            ii(0x100b_6e85, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_6e88, 5); call(0x1007_64fc, -0x4_0991);           /* call 0x100764fc */
            ii(0x100b_6e8d, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100b_6e90, 4); and(memb[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x100b_6e94, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x100b_6e97, 5); call(Definitions.my_ctor_0x101b_4184, -0x4_03ac); /* call 0x10076af0 */
            ii(0x100b_6e9c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_6e9f, 5); cmp(memw[ds, eax + 0x8], 0x4e);         /* cmp word [eax+0x8], 0x4e */
            ii(0x100b_6ea4, 2); if(jnz(0x100b_6eaf, 0x9)) goto l_0x100b_6eaf; /* jnz 0x100b6eaf */
            ii(0x100b_6ea6, 7); mov(memd[ss, ebp - 0x20], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x100b_6ead, 2); jmp(0x100b_6eb6, 0x7); goto l_0x100b_6eb6; /* jmp 0x100b6eb6 */
        l_0x100b_6eaf:
            ii(0x100b_6eaf, 7); mov(memd[ss, ebp - 0x20], 0x3);         /* mov dword [ebp-0x20], 0x3 */
        l_0x100b_6eb6:
            ii(0x100b_6eb6, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100b_6ebb, 5); call(0x1007_6338, -0x4_0b88);           /* call 0x10076338 */
            ii(0x100b_6ec0, 3); lea(ebx, memd[ss, ebp - 0x14]);         /* lea ebx, [ebp-0x14] */
            ii(0x100b_6ec3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_6ec5, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_6ec7, 5); call(0x1007_643c, -0x4_0a90);           /* call 0x1007643c */
            ii(0x100b_6ecc, 2); jmp(0x100b_6ed6, 0x8); goto l_0x100b_6ed6; /* jmp 0x100b6ed6 */
        l_0x100b_6ece:
            ii(0x100b_6ece, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_6ed1, 5); call(0x1007_6bf8, -0x4_02de);           /* call 0x10076bf8 */
        l_0x100b_6ed6:
            ii(0x100b_6ed6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_6ed8, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_6edb, 5); call(0x1013_ad71, 0x8_3e91);            /* call 0x1013ad71 */
            ii(0x100b_6ee0, 2); test(al, al);                           /* test al, al */
            ii(0x100b_6ee2, 6); if(jz(0x100b_7047, 0x15f)) goto l_0x100b_7047; /* jz 0x100b7047 */
            ii(0x100b_6ee8, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_6eeb, 5); call(0x1007_63a0, -0x4_0b50);           /* call 0x100763a0 */
            ii(0x100b_6ef0, 4); cmp(memb[ds, eax + 0x3d], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100b_6ef4, 2); if(jnz(0x100b_6f08, 0x12)) goto l_0x100b_6f08; /* jnz 0x100b6f08 */
            ii(0x100b_6ef6, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_6ef9, 5); call(0x1007_63a0, -0x4_0b5e);           /* call 0x100763a0 */
            ii(0x100b_6efe, 5); call(0x1007_611c, -0x4_0de7);           /* call 0x1007611c */
            ii(0x100b_6f03, 3); cmp(eax, memd[ss, ebp - 0x8]);          /* cmp eax, [ebp-0x8] */
            ii(0x100b_6f06, 2); if(jz(0x100b_6f0d, 0x5)) goto l_0x100b_6f0d; /* jz 0x100b6f0d */
        l_0x100b_6f08:
            ii(0x100b_6f08, 5); jmp(0x100b_7042, 0x135); goto l_0x100b_7042; /* jmp 0x100b7042 */
        l_0x100b_6f0d:
            ii(0x100b_6f0d, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_6f10, 5); call(0x1007_63a0, -0x4_0b75);           /* call 0x100763a0 */
            ii(0x100b_6f15, 5); call(0x1015_26ac, 0x9_b792);            /* call 0x101526ac */
            ii(0x100b_6f1a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_6f1c, 2); if(jz(0x100b_6f3e, 0x20)) goto l_0x100b_6f3e; /* jz 0x100b6f3e */
            ii(0x100b_6f1e, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_6f21, 5); call(0x1007_63a0, -0x4_0b86);           /* call 0x100763a0 */
            ii(0x100b_6f26, 5); call(0x1015_26ac, 0x9_b781);            /* call 0x101526ac */
            ii(0x100b_6f2b, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100b_6f2e, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100b_6f31, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x100b_6f34, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100b_6f37, 3); call_abs(memd[ds, edx + 0x20]);         /* call dword [edx+0x20] */
            ii(0x100b_6f3a, 2); cmp(al, 0x17);                          /* cmp al, 0x17 */
            ii(0x100b_6f3c, 2); if(jz(0x100b_6f8c, 0x4e)) goto l_0x100b_6f8c; /* jz 0x100b6f8c */
        l_0x100b_6f3e:
            ii(0x100b_6f3e, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x100b_6f43, 5); call(Definitions.sys_new, 0xa_eeb8);    /* call 0x10165e00 */
            ii(0x100b_6f48, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100b_6f4b, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100b_6f4e, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100b_6f51, 4); cmp(memd[ss, ebp - 0x2c], 0);           /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x100b_6f55, 2); if(jz(0x100b_6f79, 0x22)) goto l_0x100b_6f79; /* jz 0x100b6f79 */
            ii(0x100b_6f57, 5); mov(ebx, 0x100b_0ebb);                  /* mov ebx, 0x100b0ebb */
            ii(0x100b_6f5c, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_6f5f, 5); call(0x1007_63d4, -0x4_0b90);           /* call 0x100763d4 */
            ii(0x100b_6f64, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_6f66, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100b_6f69, 5); call(0x100a_c45d, -0xab11);             /* call 0x100ac45d */
            ii(0x100b_6f6e, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100b_6f71, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100b_6f74, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x100b_6f77, 2); jmp(0x100b_6f7f, 0x6); goto l_0x100b_6f7f; /* jmp 0x100b6f7f */
        l_0x100b_6f79:
            ii(0x100b_6f79, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100b_6f7c, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
        l_0x100b_6f7f:
            ii(0x100b_6f7f, 3); mov(edx, memd[ss, ebp - 0x34]);         /* mov edx, [ebp-0x34] */
            ii(0x100b_6f82, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_6f87, 5); call(0x100a_4d50, -0x1_223c);           /* call 0x100a4d50 */
        l_0x100b_6f8c:
            ii(0x100b_6f8c, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_6f8f, 5); call(0x1007_63a0, -0x4_0bf4);           /* call 0x100763a0 */
            ii(0x100b_6f94, 5); call(0x1015_26ac, 0x9_b713);            /* call 0x101526ac */
            ii(0x100b_6f99, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x100b_6f9c, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x100b_6f9f, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x100b_6fa2, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x100b_6fa5, 3); call_abs(memd[ds, edx + 0x20]);         /* call dword [edx+0x20] */
            ii(0x100b_6fa8, 2); cmp(al, 0x17);                          /* cmp al, 0x17 */
            ii(0x100b_6faa, 2); if(jnz(0x100b_6fb5, 0x9)) goto l_0x100b_6fb5; /* jnz 0x100b6fb5 */
            ii(0x100b_6fac, 7); mov(memd[ss, ebp - 0x3c], 0);           /* mov dword [ebp-0x3c], 0x0 */
            ii(0x100b_6fb3, 2); jmp(0x100b_6fce, 0x19); goto l_0x100b_6fce; /* jmp 0x100b6fce */
        l_0x100b_6fb5:
            ii(0x100b_6fb5, 5); mov(ecx, 0x1162);                       /* mov ecx, 0x1162 */
            ii(0x100b_6fba, 5); mov(ebx, StringDefinitions.AiMoveCpp13); /* mov ebx, 0x101a11c7 */
            ii(0x100b_6fbf, 5); mov(edx, StringDefinitions.ClientGettaskGettypeEqualTaskMove2); /* mov edx, 0x101a11d3 */
            ii(0x100b_6fc4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_6fc6, 5); call(Definitions.sys_assert, 0xa_edc7); /* call 0x10165d92 */
            ii(0x100b_6fcb, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
        l_0x100b_6fce:
            ii(0x100b_6fce, 3); lea(edx, memd[ss, ebp - 0x40]);         /* lea edx, [ebp-0x40] */
            ii(0x100b_6fd1, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_6fd4, 5); call(0x1007_63a0, -0x4_0c39);           /* call 0x100763a0 */
            ii(0x100b_6fd9, 5); call(0x1015_26ac, 0x9_b6ce);            /* call 0x101526ac */
            ii(0x100b_6fde, 5); call(0x100b_7da0, 0xdbd);               /* call 0x100b7da0 */
            ii(0x100b_6fe3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_6fe5, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x100b_6fe8, 5); call(0x1008_8b44, -0x2_e4a9);           /* call 0x10088b44 */
            ii(0x100b_6fed, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100b_6ff1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_6ff3, 2); if(jl(0x100b_7012, 0x1d)) goto l_0x100b_7012; /* jl 0x100b7012 */
            ii(0x100b_6ff5, 3); lea(edx, memd[ss, ebp - 0x1c]);         /* lea edx, [ebp-0x1c] */
            ii(0x100b_6ff8, 3); lea(eax, memd[ss, ebp - 0x44]);         /* lea eax, [ebp-0x44] */
            ii(0x100b_6ffb, 5); call(0x1007_5e64, -0x4_119c);           /* call 0x10075e64 */
            ii(0x100b_7000, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x100b_7003, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_7005, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_7007, 5); call(0x1007_0ca1, -0x4_636b);           /* call 0x10070ca1 */
            ii(0x100b_700c, 4); cmp(ax, memw[ss, ebp - 0x20]);          /* cmp ax, [ebp-0x20] */
            ii(0x100b_7010, 2); if(jle(0x100b_7014, 0x2)) goto l_0x100b_7014; /* jle 0x100b7014 */
        l_0x100b_7012:
            ii(0x100b_7012, 2); jmp(0x100b_7042, 0x2e); goto l_0x100b_7042; /* jmp 0x100b7042 */
        l_0x100b_7014:
            ii(0x100b_7014, 3); lea(edx, memd[ss, ebp - 0x1c]);         /* lea edx, [ebp-0x1c] */
            ii(0x100b_7017, 3); lea(eax, memd[ss, ebp - 0x48]);         /* lea eax, [ebp-0x48] */
            ii(0x100b_701a, 5); call(0x1007_5e64, -0x4_11bb);           /* call 0x10075e64 */
            ii(0x100b_701f, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100b_7021, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_7024, 5); call(0x1007_63d4, -0x4_0c55);           /* call 0x100763d4 */
            ii(0x100b_7029, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_702b, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_702e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_7031, 5); call(0x100b_670a, -0x92c);              /* call 0x100b670a */
            ii(0x100b_7036, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_7038, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_703b, 5); call(0x1007_5f6c, -0x4_10d4);           /* call 0x10075f6c */
            ii(0x100b_7040, 2); jmp(0x100b_7062, 0x20); goto l_0x100b_7062; /* jmp 0x100b7062 */
        l_0x100b_7042:
            ii(0x100b_7042, 5); jmp(0x100b_6ece, -0x179); goto l_0x100b_6ece; /* jmp 0x100b6ece */
        l_0x100b_7047:
            ii(0x100b_7047, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_7049, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_704c, 5); call(0x1007_5f6c, -0x4_10e5);           /* call 0x10075f6c */
        l_0x100b_7051:
            ii(0x100b_7051, 5); call(0x1008_b0e4, -0x2_bf72);           /* call 0x1008b0e4 */
            ii(0x100b_7056, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_7058, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100b_705a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_705d, 5); call(0x100a_297d, -0x1_46e5);           /* call 0x100a297d */
        l_0x100b_7062:
            ii(0x100b_7062, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7064, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_7065, 1); pop(edi);                               /* pop edi */
            ii(0x100b_7066, 1); pop(esi);                               /* pop esi */
            ii(0x100b_7067, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_7068, 1); ret();                                  /* ret */
        }
    }
}
