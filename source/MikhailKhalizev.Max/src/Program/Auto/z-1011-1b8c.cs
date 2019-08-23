using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_1b8c-b232b60e")]
        public void Method_1011_1b8c()
        {
            ii(0x1011_1b8c, 5); push(0x110);                            /* push 0x110 */
            ii(0x1011_1b91, 5); call(Definitions.sys_check_available_stack_size, 0x5_41bc); /* call 0x10165d52 */
            ii(0x1011_1b96, 1); push(ebx);                              /* push ebx */
            ii(0x1011_1b97, 1); push(ecx);                              /* push ecx */
            ii(0x1011_1b98, 1); push(edx);                              /* push edx */
            ii(0x1011_1b99, 1); push(esi);                              /* push esi */
            ii(0x1011_1b9a, 1); push(edi);                              /* push edi */
            ii(0x1011_1b9b, 1); push(ebp);                              /* push ebp */
            ii(0x1011_1b9c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_1b9e, 6); sub(esp, 0xe4);                         /* sub esp, 0xe4 */
            ii(0x1011_1ba4, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_1ba7, 6); push(memd[ds, 0x101b_d440]);            /* push dword [0x101bd440] */
            ii(0x1011_1bad, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1011_1bb1, 1); push(eax);                              /* push eax */
            ii(0x1011_1bb2, 5); mov(eax, StringDefinitions.SaveIS2);    /* mov eax, 0x101a4707 */
            ii(0x1011_1bb7, 1); push(eax);                              /* push eax */
            ii(0x1011_1bb8, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1011_1bbb, 1); push(eax);                              /* push eax */
            ii(0x1011_1bbc, 5); call(Definitions.sys_sprintf, 0x5_4340); /* call 0x10165f01 */
            ii(0x1011_1bc1, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1011_1bc4, 5); mov(edx, StringDefinitions.Rb6);        /* mov edx, 0x101a4711 */
            ii(0x1011_1bc9, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1011_1bcc, 5); call(Definitions.my_fopen, -0x2_27b2);  /* call 0x100ef41f */
            ii(0x1011_1bd1, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1011_1bd4, 4); cmp(memd[ss, ebp - 0x34], 0);           /* cmp dword [ebp-0x34], 0x0 */
            ii(0x1011_1bd8, 2); if(jnz(0x1011_1be6, 0xc)) goto l_0x1011_1be6; /* jnz 0x10111be6 */
            ii(0x1011_1bda, 7); mov(memd[ss, ebp - 0x38], 0);           /* mov dword [ebp-0x38], 0x0 */
            ii(0x1011_1be1, 5); jmp(0x1011_1df4, 0x20e); goto l_0x1011_1df4; /* jmp 0x10111df4 */
        l_0x1011_1be6:
            ii(0x1011_1be6, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1011_1be9, 5); call(Definitions.sys_fclose, 0x6_047b); /* call 0x10172069 */
            ii(0x1011_1bee, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1011_1bf3, 5); call(0x1007_5fdc, -0x9_bc1c);           /* call 0x10075fdc */
            ii(0x1011_1bf8, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_1bfb, 5); mov(eax, 0x46);                         /* mov eax, 0x46 */
            ii(0x1011_1c00, 5); call(0x1007_5fdc, -0x9_bc29);           /* call 0x10075fdc */
            ii(0x1011_1c05, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_1c08, 5); mov(eax, 0x47);                         /* mov eax, 0x47 */
            ii(0x1011_1c0d, 5); call(0x1007_5fdc, -0x9_bc36);           /* call 0x10075fdc */
            ii(0x1011_1c12, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_1c15, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x1011_1c1a, 5); call(0x1007_5fdc, -0x9_bc43);           /* call 0x10075fdc */
            ii(0x1011_1c1f, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1011_1c22, 5); mov(eax, 0x48);                         /* mov eax, 0x48 */
            ii(0x1011_1c27, 5); call(0x1007_5fdc, -0x9_bc50);           /* call 0x10075fdc */
            ii(0x1011_1c2c, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_1c2f, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1011_1c34, 5); call(0x1007_5fdc, -0x9_bc5d);           /* call 0x10075fdc */
            ii(0x1011_1c39, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_1c3c, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1011_1c41, 5); call(0x1007_5fdc, -0x9_bc6a);           /* call 0x10075fdc */
            ii(0x1011_1c46, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1011_1c49, 5); mov(eax, 0x4f);                         /* mov eax, 0x4f */
            ii(0x1011_1c4e, 5); call(0x1007_5fdc, -0x9_bc77);           /* call 0x10075fdc */
            ii(0x1011_1c53, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x1011_1c56, 5); mov(eax, 0x50);                         /* mov eax, 0x50 */
            ii(0x1011_1c5b, 5); call(0x1007_5fdc, -0x9_bc84);           /* call 0x10075fdc */
            ii(0x1011_1c60, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x1011_1c63, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x1011_1c68, 3); lea(ebx, ebp - 0x64);                   /* lea ebx, [ebp-0x64] */
            ii(0x1011_1c6b, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x1011_1c70, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1011_1c75, 5); call(0x1010_6281, -0xb9f9);             /* call 0x10106281 */
            ii(0x1011_1c7a, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x1011_1c7f, 6); lea(ebx, ebp - 0x84);                   /* lea ebx, [ebp-0x84] */
            ii(0x1011_1c85, 5); mov(edx, 0x63);                         /* mov edx, 0x63 */
            ii(0x1011_1c8a, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1011_1c8f, 5); call(0x1010_6281, -0xba13);             /* call 0x10106281 */
            ii(0x1011_1c94, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x1011_1c99, 6); lea(ebx, ebp - 0xa4);                   /* lea ebx, [ebp-0xa4] */
            ii(0x1011_1c9f, 5); mov(edx, 0x64);                         /* mov edx, 0x64 */
            ii(0x1011_1ca4, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1011_1ca9, 5); call(0x1010_6281, -0xba2d);             /* call 0x10106281 */
            ii(0x1011_1cae, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x1011_1cb3, 6); lea(ebx, ebp - 0xc4);                   /* lea ebx, [ebp-0xc4] */
            ii(0x1011_1cb9, 5); mov(edx, 0x65);                         /* mov edx, 0x65 */
            ii(0x1011_1cbe, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1011_1cc3, 5); call(0x1010_6281, -0xba47);             /* call 0x10106281 */
            ii(0x1011_1cc8, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x1011_1ccd, 6); lea(ebx, ebp - 0xe4);                   /* lea ebx, [ebp-0xe4] */
            ii(0x1011_1cd3, 5); mov(edx, 0x66);                         /* mov edx, 0x66 */
            ii(0x1011_1cd8, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1011_1cdd, 5); call(0x1010_6281, -0xba61);             /* call 0x10106281 */
            ii(0x1011_1ce2, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1011_1ce6, 5); mov(eax, 0x3d);                         /* mov eax, 0x3d */
            ii(0x1011_1ceb, 5); call(0x100c_aafc, -0x4_71f4);           /* call 0x100caafc */
            ii(0x1011_1cf0, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x1011_1cf5, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x1011_1cfa, 5); call(0x100c_aafc, -0x4_7203);           /* call 0x100caafc */
            ii(0x1011_1cff, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1011_1d04, 5); call(0x100f_f0ba, -0x1_2c4f);           /* call 0x100ff0ba */
            ii(0x1011_1d09, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1011_1d0d, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1011_1d12, 5); call(0x100c_aafc, -0x4_721b);           /* call 0x100caafc */
            ii(0x1011_1d17, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1011_1d1b, 5); mov(eax, 0x46);                         /* mov eax, 0x46 */
            ii(0x1011_1d20, 5); call(0x100c_aafc, -0x4_7229);           /* call 0x100caafc */
            ii(0x1011_1d25, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1011_1d29, 5); mov(eax, 0x47);                         /* mov eax, 0x47 */
            ii(0x1011_1d2e, 5); call(0x100c_aafc, -0x4_7237);           /* call 0x100caafc */
            ii(0x1011_1d33, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1011_1d37, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x1011_1d3c, 5); call(0x100c_aafc, -0x4_7245);           /* call 0x100caafc */
            ii(0x1011_1d41, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1011_1d45, 5); mov(eax, 0x48);                         /* mov eax, 0x48 */
            ii(0x1011_1d4a, 5); call(0x100c_aafc, -0x4_7253);           /* call 0x100caafc */
            ii(0x1011_1d4f, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1011_1d53, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1011_1d58, 5); call(0x100c_aafc, -0x4_7261);           /* call 0x100caafc */
            ii(0x1011_1d5d, 4); movsx(edx, memw[ss, ebp - 0x3c]);       /* movsx edx, word [ebp-0x3c] */
            ii(0x1011_1d61, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1011_1d66, 5); call(0x100c_aafc, -0x4_726f);           /* call 0x100caafc */
            ii(0x1011_1d6b, 4); movsx(edx, memw[ss, ebp - 0x40]);       /* movsx edx, word [ebp-0x40] */
            ii(0x1011_1d6f, 5); mov(eax, 0x4f);                         /* mov eax, 0x4f */
            ii(0x1011_1d74, 5); call(0x100c_aafc, -0x4_727d);           /* call 0x100caafc */
            ii(0x1011_1d79, 4); movsx(edx, memw[ss, ebp - 0x44]);       /* movsx edx, word [ebp-0x44] */
            ii(0x1011_1d7d, 5); mov(eax, 0x50);                         /* mov eax, 0x50 */
            ii(0x1011_1d82, 5); call(0x100c_aafc, -0x4_728b);           /* call 0x100caafc */
            ii(0x1011_1d87, 3); lea(ebx, ebp - 0x64);                   /* lea ebx, [ebp-0x64] */
            ii(0x1011_1d8a, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x1011_1d8f, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1011_1d94, 5); call(0x1010_6205, -0xbb94);             /* call 0x10106205 */
            ii(0x1011_1d99, 6); lea(ebx, ebp - 0x84);                   /* lea ebx, [ebp-0x84] */
            ii(0x1011_1d9f, 5); mov(edx, 0x63);                         /* mov edx, 0x63 */
            ii(0x1011_1da4, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1011_1da9, 5); call(0x1010_6205, -0xbba9);             /* call 0x10106205 */
            ii(0x1011_1dae, 6); lea(ebx, ebp - 0xa4);                   /* lea ebx, [ebp-0xa4] */
            ii(0x1011_1db4, 5); mov(edx, 0x64);                         /* mov edx, 0x64 */
            ii(0x1011_1db9, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1011_1dbe, 5); call(0x1010_6205, -0xbbbe);             /* call 0x10106205 */
            ii(0x1011_1dc3, 6); lea(ebx, ebp - 0xc4);                   /* lea ebx, [ebp-0xc4] */
            ii(0x1011_1dc9, 5); mov(edx, 0x65);                         /* mov edx, 0x65 */
            ii(0x1011_1dce, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1011_1dd3, 5); call(0x1010_6205, -0xbbd3);             /* call 0x10106205 */
            ii(0x1011_1dd8, 6); lea(ebx, ebp - 0xe4);                   /* lea ebx, [ebp-0xe4] */
            ii(0x1011_1dde, 5); mov(edx, 0x66);                         /* mov edx, 0x66 */
            ii(0x1011_1de3, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1011_1de8, 5); call(0x1010_6205, -0xbbe8);             /* call 0x10106205 */
            ii(0x1011_1ded, 7); mov(memd[ss, ebp - 0x38], 0x1);         /* mov dword [ebp-0x38], 0x1 */
        l_0x1011_1df4:
            ii(0x1011_1df4, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1011_1df7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_1df9, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_1dfa, 1); pop(edi);                               /* pop edi */
            ii(0x1011_1dfb, 1); pop(esi);                               /* pop esi */
            ii(0x1011_1dfc, 1); pop(edx);                               /* pop edx */
            ii(0x1011_1dfd, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_1dfe, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_1dff, 1); ret();                                  /* ret */
        }
    }
}
