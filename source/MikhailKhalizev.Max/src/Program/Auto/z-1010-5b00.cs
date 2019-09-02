using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_5b00-27216d28")]
        public void Method_1010_5b00()
        {
            ii(0x1010_5b00, 5); push(0x4b0);                            /* push 0x4b0 */
            ii(0x1010_5b05, 5); call(Definitions.sys_check_available_stack_size, 0x6_0248); /* call 0x10165d52 */
            ii(0x1010_5b0a, 1); push(ecx);                              /* push ecx */
            ii(0x1010_5b0b, 1); push(esi);                              /* push esi */
            ii(0x1010_5b0c, 1); push(edi);                              /* push edi */
            ii(0x1010_5b0d, 1); push(ebp);                              /* push ebp */
            ii(0x1010_5b0e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_5b10, 6); sub(esp, 0x494);                        /* sub esp, 0x494 */
            ii(0x1010_5b16, 3); mov(memb[ss, ebp - 12], al);            /* mov [ebp-0xc], al */
            ii(0x1010_5b19, 3); mov(memb[ss, ebp - 8], dl);             /* mov [ebp-0x8], dl */
            ii(0x1010_5b1c, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x1010_5b1f, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1010_5b22, 5); call(0x100e_ad24, -0x1_ae03);           /* call 0x100ead24 */
            ii(0x1010_5b27, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x1010_5b2c, 5); call(0x1012_0d94, 0x1_b263);            /* call 0x10120d94 */
            ii(0x1010_5b31, 2); push(0x10);                             /* push 0x10 */
            ii(0x1010_5b33, 2); push(0);                                /* push 0x0 */
            ii(0x1010_5b35, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x1010_5b3a, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1010_5b3f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_5b41, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_5b43, 5); call(/* sys */ 0x1016_6764, 0x6_0c1c);  /* call 0x10166764 */
            ii(0x1010_5b48, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1010_5b4b, 5); call(0x100e_a903, -0x1_b24d);           /* call 0x100ea903 */
        l_0x1010_5b50:
            ii(0x1010_5b50, 5); call(/* sys */ 0x1016_b208, 0x6_56b3);  /* call 0x1016b208 */
            ii(0x1010_5b55, 3); cmp(eax, 0x1b);                         /* cmp eax, 0x1b */
            ii(0x1010_5b58, 6); if(jz(0x1010_5c90, 0x132)) goto l_0x1010_5c90; /* jz 0x10105c90 */
            ii(0x1010_5b5e, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1010_5b61, 5); call(0x100e_a933, -0x1_b233);           /* call 0x100ea933 */
            ii(0x1010_5b66, 2); test(al, al);                           /* test al, al */
            ii(0x1010_5b68, 6); if(jz(0x1010_5c13, 0xa5)) goto l_0x1010_5c13; /* jz 0x10105c13 */
            ii(0x1010_5b6e, 4); test(memb[ss, ebp - 20], 0x20);         /* test byte [ebp-0x14], 0x20 */
            ii(0x1010_5b72, 6); if(jnz(0x1010_5c90, 0x118)) goto l_0x1010_5c90; /* jnz 0x10105c90 */
            ii(0x1010_5b78, 4); test(memb[ss, ebp - 20], 0x10);         /* test byte [ebp-0x14], 0x10 */
            ii(0x1010_5b7c, 6); if(jz(0x1010_5c13, 0x91)) goto l_0x1010_5c13; /* jz 0x10105c13 */
            ii(0x1010_5b82, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x1010_5b87, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1010_5b8c, 5); call(0x1013_dc59, 0x3_80c8);            /* call 0x1013dc59 */
            ii(0x1010_5b91, 4); cmp(memb[ss, ebp - 12], 9);             /* cmp byte [ebp-0xc], 0x9 */
            ii(0x1010_5b95, 2); if(jnz(0x1010_5bac, 0x15)) goto l_0x1010_5bac; /* jnz 0x10105bac */
            ii(0x1010_5b97, 4); movsx(edx, memw[ss, ebp - 17]);         /* movsx edx, word [ebp-0x11] */
            ii(0x1010_5b9b, 4); movsx(eax, memw[ss, ebp - 19]);         /* movsx eax, word [ebp-0x13] */
            ii(0x1010_5b9f, 5); call(0x1010_59e9, -0x1bb);              /* call 0x101059e9 */
            ii(0x1010_5ba4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_5ba6, 6); if(jnz(0x1010_5c90, 0xe4)) goto l_0x1010_5c90; /* jnz 0x10105c90 */
        l_0x1010_5bac:
            ii(0x1010_5bac, 4); or(memb[ss, ebp - 28], 1);              /* or byte [ebp-0x1c], 0x1 */
            ii(0x1010_5bb0, 4); movsx(eax, memb[ss, ebp - 8]);          /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_5bb4, 1); push(eax);                              /* push eax */
            ii(0x1010_5bb5, 4); movsx(ecx, memw[ss, ebp - 17]);         /* movsx ecx, word [ebp-0x11] */
            ii(0x1010_5bb9, 4); movsx(ebx, memw[ss, ebp - 19]);         /* movsx ebx, word [ebp-0x13] */
            ii(0x1010_5bbd, 4); movsx(edx, memb[ss, ebp - 12]);         /* movsx edx, byte [ebp-0xc] */
            ii(0x1010_5bc1, 6); lea(eax, memd[ss, ebp - 1168]);         /* lea eax, [ebp-0x490] */
            ii(0x1010_5bc7, 5); call(0x1010_491c, -0x12b0);             /* call 0x1010491c */
            ii(0x1010_5bcc, 6); mov(memd[ss, ebp - 1172], eax);         /* mov [ebp-0x494], eax */
            ii(0x1010_5bd2, 4); and(memb[ss, ebp - 28], -2 /* 0xfe */); /* and byte [ebp-0x1c], 0xfe */
            ii(0x1010_5bd6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_5bd8, 3); mov(dl, memb[ss, ebp - 4]);             /* mov dl, [ebp-0x4] */
            ii(0x1010_5bdb, 6); lea(eax, memd[ss, ebp - 1168]);         /* lea eax, [ebp-0x490] */
            ii(0x1010_5be1, 5); call(0x1010_58f2, -0x2f4);              /* call 0x101058f2 */
            ii(0x1010_5be6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_5be8, 2); if(jnz(0x1010_5bfc, 0x12)) goto l_0x1010_5bfc; /* jnz 0x10105bfc */
            ii(0x1010_5bea, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_5bec, 6); lea(eax, memd[ss, ebp - 1168]);         /* lea eax, [ebp-0x490] */
            ii(0x1010_5bf2, 5); call(0x1010_4d4d, -0xeaa);              /* call 0x10104d4d */
            ii(0x1010_5bf7, 5); jmp(0x1010_5c90, 0x94); goto l_0x1010_5c90; /* jmp 0x10105c90 */
        l_0x1010_5bfc:
            ii(0x1010_5bfc, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x1010_5c01, 5); call(0x1012_0d94, 0x1_b18e);            /* call 0x10120d94 */
            ii(0x1010_5c06, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_5c08, 6); lea(eax, memd[ss, ebp - 1168]);         /* lea eax, [ebp-0x490] */
            ii(0x1010_5c0e, 5); call(0x1010_4d4d, -0xec6);              /* call 0x10104d4d */
        l_0x1010_5c13:
            ii(0x1010_5c13, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_5c15, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1010_5c18, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_5c1a, 6); if(jnz(0x1010_5c8b, 0x6b)) goto l_0x1010_5c8b; /* jnz 0x10105c8b */
            ii(0x1010_5c20, 4); cmp(memb[ss, ebp - 8], 0x26);           /* cmp byte [ebp-0x8], 0x26 */
            ii(0x1010_5c24, 2); if(jnz(0x1010_5c34, 0xe)) goto l_0x1010_5c34; /* jnz 0x10105c34 */
            ii(0x1010_5c26, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_5c28, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1010_5c2d, 5); call(0x1010_0e32, -0x4e00);             /* call 0x10100e32 */
            ii(0x1010_5c32, 2); jmp(0x1010_5c8b, 0x57); goto l_0x1010_5c8b; /* jmp 0x10105c8b */
        l_0x1010_5c34:
            ii(0x1010_5c34, 7); cmp(memb[ds, 0x101c_391e], 8);          /* cmp byte [0x101c391e], 0x8 */
            ii(0x1010_5c3b, 2); if(jz(0x1010_5c46, 9)) goto l_0x1010_5c46; /* jz 0x10105c46 */
            ii(0x1010_5c3d, 7); cmp(memb[ds, 0x101c_391e], 9);          /* cmp byte [0x101c391e], 0x9 */
            ii(0x1010_5c44, 2); if(jnz(0x1010_5c51, 0xb)) goto l_0x1010_5c51; /* jnz 0x10105c51 */
        l_0x1010_5c46:
            ii(0x1010_5c46, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_5c48, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_5c4a, 5); call(0x1010_0e32, -0x4e1d);             /* call 0x10100e32 */
            ii(0x1010_5c4f, 2); jmp(0x1010_5c8b, 0x3a); goto l_0x1010_5c8b; /* jmp 0x10105c8b */
        l_0x1010_5c51:
            ii(0x1010_5c51, 7); cmp(memb[ds, 0x101c_5630], 0);          /* cmp byte [0x101c5630], 0x0 */
            ii(0x1010_5c58, 2); if(jz(0x1010_5c6a, 0x10)) goto l_0x1010_5c6a; /* jz 0x10105c6a */
            ii(0x1010_5c5a, 5); call(0x1012_ac94, 0x2_5035);            /* call 0x1012ac94 */
            ii(0x1010_5c5f, 7); cmp(memb[ds, 0x101c_5630], 2);          /* cmp byte [0x101c5630], 0x2 */
            ii(0x1010_5c66, 2); if(jz(0x1010_5c90, 0x28)) goto l_0x1010_5c90; /* jz 0x10105c90 */
            ii(0x1010_5c68, 2); jmp(0x1010_5c8b, 0x21); goto l_0x1010_5c8b; /* jmp 0x10105c8b */
        l_0x1010_5c6a:
            ii(0x1010_5c6a, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1010_5c71, 2); if(jz(0x1010_5c8b, 0x18)) goto l_0x1010_5c8b; /* jz 0x10105c8b */
            ii(0x1010_5c73, 5); call(0x100e_42e4, -0x2_1994);           /* call 0x100e42e4 */
            ii(0x1010_5c78, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_5c7d, 5); call(0x1012_8835, 0x2_2bb3);            /* call 0x10128835 */
            ii(0x1010_5c82, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_5c84, 2); if(jz(0x1010_5c8b, 5)) goto l_0x1010_5c8b; /* jz 0x10105c8b */
            ii(0x1010_5c86, 5); call(0x1016_2cb8, 0x5_d02d);            /* call 0x10162cb8 */
        l_0x1010_5c8b:
            ii(0x1010_5c8b, 5); jmp(0x1010_5b50, -0x140); goto l_0x1010_5b50; /* jmp 0x10105b50 */
        l_0x1010_5c90:
            ii(0x1010_5c90, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1010_5c93, 5); call(/* sys */ 0x1016_6990, 0x6_0cf8);  /* call 0x10166990 */
            ii(0x1010_5c98, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1010_5c9d, 5); call(0x1012_0d94, 0x1_b0f2);            /* call 0x10120d94 */
            ii(0x1010_5ca2, 5); call(0x100e_a903, -0x1_b3a4);           /* call 0x100ea903 */
            ii(0x1010_5ca7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_5ca9, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_5caa, 1); pop(edi);                               /* pop edi */
            ii(0x1010_5cab, 1); pop(esi);                               /* pop esi */
            ii(0x1010_5cac, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_5cad, 1); ret();                                  /* ret */
        }
    }
}
