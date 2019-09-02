using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_3e05-8502d496")]
        public void Method_100e_3e05()
        {
            ii(0x100e_3e05, 5); push(0xa8);                             /* push 0xa8 */
            ii(0x100e_3e0a, 5); call(Definitions.sys_check_available_stack_size, 0x8_1f43); /* call 0x10165d52 */
            ii(0x100e_3e0f, 1); push(ebx);                              /* push ebx */
            ii(0x100e_3e10, 1); push(ecx);                              /* push ecx */
            ii(0x100e_3e11, 1); push(esi);                              /* push esi */
            ii(0x100e_3e12, 1); push(edi);                              /* push edi */
            ii(0x100e_3e13, 1); push(ebp);                              /* push ebp */
            ii(0x100e_3e14, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_3e16, 6); sub(esp, 0x78);                         /* sub esp, 0x78 */
            ii(0x100e_3e1c, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_3e1f, 3); mov(memb[ss, ebp - 4], dl);             /* mov [ebp-0x4], dl */
            ii(0x100e_3e22, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_3e25, 5); call(0x1007_20b1, -0x7_1d79);           /* call 0x100720b1 */
            ii(0x100e_3e2a, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100e_3e2d, 5); call(0x1007_20b1, -0x7_1d81);           /* call 0x100720b1 */
            ii(0x100e_3e32, 3); lea(edx, memd[ss, ebp - 0x3c]);         /* lea edx, [ebp-0x3c] */
            ii(0x100e_3e35, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_3e38, 5); call(0x100d_6a11, -0xd42c);             /* call 0x100d6a11 */
            ii(0x100e_3e3d, 3); lea(ebx, memd[ss, ebp - 0x20]);         /* lea ebx, [ebp-0x20] */
            ii(0x100e_3e40, 3); lea(edx, memd[ss, ebp - 0x14]);         /* lea edx, [ebp-0x14] */
            ii(0x100e_3e43, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_3e46, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_3e49, 5); call(0x1007_6574, -0x6_d8da);           /* call 0x10076574 */
            ii(0x100e_3e4e, 5); call(0x1007_6204, -0x6_dc4f);           /* call 0x10076204 */
            ii(0x100e_3e53, 5); call(0x1014_3616, 0x5_f7be);            /* call 0x10143616 */
            ii(0x100e_3e58, 3); lea(edx, memd[ss, ebp - 0x3c]);         /* lea edx, [ebp-0x3c] */
            ii(0x100e_3e5b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_3e5e, 3); mov(eax, memd[ds, eax + 0x44]);         /* mov eax, [eax+0x44] */
            ii(0x100e_3e61, 5); call(0x100d_7f6c, -0xbefa);             /* call 0x100d7f6c */
            ii(0x100e_3e66, 3); lea(edx, memd[ss, ebp - 0x3c]);         /* lea edx, [ebp-0x3c] */
            ii(0x100e_3e69, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_3e6c, 3); mov(eax, memd[ds, eax + 0x48]);         /* mov eax, [eax+0x48] */
            ii(0x100e_3e6f, 5); call(0x100d_7f6c, -0xbf08);             /* call 0x100d7f6c */
            ii(0x100e_3e74, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_3e77, 3); mov(eax, memd[ds, eax + 0x44]);         /* mov eax, [eax+0x44] */
            ii(0x100e_3e7a, 5); call(0x100d_4f24, -0xef5b);             /* call 0x100d4f24 */
            ii(0x100e_3e7f, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x100e_3e82, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_3e85, 3); mov(eax, memd[ds, eax + 0x28]);         /* mov eax, [eax+0x28] */
            ii(0x100e_3e88, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_3e8b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_3e8d, 2); if(jnz(0x100e_3e98, 9)) goto l_0x100e_3e98; /* jnz 0x100e3e98 */
            ii(0x100e_3e8f, 7); mov(memd[ss, ebp - 0x40], 0);           /* mov dword [ebp-0x40], 0x0 */
            ii(0x100e_3e96, 2); jmp(0x100e_3eb6, 0x1e); goto l_0x100e_3eb6; /* jmp 0x100e3eb6 */
        l_0x100e_3e98:
            ii(0x100e_3e98, 4); movsx(eax, memw[ss, ebp - 0x12]);       /* movsx eax, word [ebp-0x12] */
            ii(0x100e_3e9c, 4); movsx(edx, memw[ss, ebp - 0x40]);       /* movsx edx, word [ebp-0x40] */
            ii(0x100e_3ea0, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100e_3ea3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_3ea6, 3); mov(ebx, memd[ds, eax + 0x28]);         /* mov ebx, [eax+0x28] */
            ii(0x100e_3ea9, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100e_3eac, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_3eae, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_3eb1, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100e_3eb3, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
        l_0x100e_3eb6:
            ii(0x100e_3eb6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_3eb9, 3); mov(eax, memd[ds, eax + 0x44]);         /* mov eax, [eax+0x44] */
            ii(0x100e_3ebc, 5); call(0x100d_4ebc, -0xf005);             /* call 0x100d4ebc */
            ii(0x100e_3ec1, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_3ec4, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x100e_3ec8, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100e_3ecb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_3ece, 3); mov(eax, memd[ds, eax + 0x44]);         /* mov eax, [eax+0x44] */
            ii(0x100e_3ed1, 5); call(0x100d_4ef0, -0xefe6);             /* call 0x100d4ef0 */
            ii(0x100e_3ed6, 1); cwde();                                 /* cwde */
            ii(0x100e_3ed7, 3); add(eax, memd[ss, ebp - 0x26]);         /* add eax, [ebp-0x26] */
            ii(0x100e_3eda, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_3edc, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x100e_3edf, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_3ee2, 3); mov(eax, memd[ds, eax + 0x44]);         /* mov eax, [eax+0x44] */
            ii(0x100e_3ee5, 5); call(0x100d_4f24, -0xefc6);             /* call 0x100d4f24 */
            ii(0x100e_3eea, 1); cwde();                                 /* cwde */
            ii(0x100e_3eeb, 4); movsx(edx, memw[ss, ebp - 0x40]);       /* movsx edx, word [ebp-0x40] */
            ii(0x100e_3eef, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_3ef1, 4); movsx(edx, memw[ss, ebp - 0x2c]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x100e_3ef5, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100e_3ef8, 3); add(memd[ss, ebp - 0x44], eax);         /* add [ebp-0x44], eax */
            ii(0x100e_3efb, 5); mov(eax, 0x221);                        /* mov eax, 0x221 */
            ii(0x100e_3f00, 1); push(eax);                              /* push eax */
            ii(0x100e_3f01, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_3f04, 3); mov(eax, memd[ds, eax + 0x44]);         /* mov eax, [eax+0x44] */
            ii(0x100e_3f07, 5); call(0x100d_4f58, -0xefb4);             /* call 0x100d4f58 */
            ii(0x100e_3f0c, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_3f0f, 4); movsx(ebx, memw[ss, ebp - 0x40]);       /* movsx ebx, word [ebp-0x40] */
            ii(0x100e_3f13, 4); movsx(edx, memw[ss, ebp - 0x2c]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x100e_3f17, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x100e_3f1a, 5); call(0x100d_701e, -0xcf01);             /* call 0x100d701e */
            ii(0x100e_3f1f, 5); mov(eax, 5);                            /* mov eax, 0x5 */
            ii(0x100e_3f24, 5); call(/* sys */ 0x1016_a24c, 0x8_6323);  /* call 0x1016a24c */
            ii(0x100e_3f29, 4); movsx(eax, memw[ss, ebp - 0x12]);       /* movsx eax, word [ebp-0x12] */
            ii(0x100e_3f2d, 1); push(eax);                              /* push eax */
            ii(0x100e_3f2e, 5); mov(eax, StringDefinitions.I17);        /* mov eax, 0x101a1c58 */
            ii(0x100e_3f33, 1); push(eax);                              /* push eax */
            ii(0x100e_3f34, 3); lea(eax, memd[ss, ebp - 0x78]);         /* lea eax, [ebp-0x78] */
            ii(0x100e_3f37, 1); push(eax);                              /* push eax */
            ii(0x100e_3f38, 5); call(Definitions.sys_sprintf, 0x8_1fc4); /* call 0x10165f01 */
            ii(0x100e_3f3d, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100e_3f40, 5); call(0x100d_531c, -0xec29);             /* call 0x100d531c */
            ii(0x100e_3f45, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_3f4a, 1); push(eax);                              /* push eax */
            ii(0x100e_3f4b, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100e_3f50, 1); push(eax);                              /* push eax */
            ii(0x100e_3f51, 5); push(0xa2);                             /* push 0xa2 */
            ii(0x100e_3f56, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_3f59, 3); mov(eax, memd[ds, eax + 0x48]);         /* mov eax, [eax+0x48] */
            ii(0x100e_3f5c, 5); call(0x100d_4f24, -0xf03d);             /* call 0x100d4f24 */
            ii(0x100e_3f61, 1); cwde();                                 /* cwde */
            ii(0x100e_3f62, 1); push(eax);                              /* push eax */
            ii(0x100e_3f63, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_3f66, 3); mov(eax, memd[ds, eax + 0x48]);         /* mov eax, [eax+0x48] */
            ii(0x100e_3f69, 5); call(0x100d_4f58, -0xf016);             /* call 0x100d4f58 */
            ii(0x100e_3f6e, 1); cwde();                                 /* cwde */
            ii(0x100e_3f6f, 1); push(eax);                              /* push eax */
            ii(0x100e_3f70, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_3f73, 3); mov(eax, memd[ds, eax + 0x48]);         /* mov eax, [eax+0x48] */
            ii(0x100e_3f76, 5); call(0x100d_4ebc, -0xf0bf);             /* call 0x100d4ebc */
            ii(0x100e_3f7b, 1); cwde();                                 /* cwde */
            ii(0x100e_3f7c, 1); push(eax);                              /* push eax */
            ii(0x100e_3f7d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_3f80, 3); mov(eax, memd[ds, eax + 0x48]);         /* mov eax, [eax+0x48] */
            ii(0x100e_3f83, 5); call(0x100d_4ef0, -0xf098);             /* call 0x100d4ef0 */
            ii(0x100e_3f88, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_3f8b, 3); lea(ebx, memd[ss, ebp - 0x78]);         /* lea ebx, [ebp-0x78] */
            ii(0x100e_3f8e, 4); movsx(edx, memw[ss, ebp - 0x2c]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x100e_3f92, 3); mov(eax, memd[ss, ebp - 0x26]);         /* mov eax, [ebp-0x26] */
            ii(0x100e_3f95, 5); call(0x100e_9ae5, 0x5b4b);              /* call 0x100e9ae5 */
            ii(0x100e_3f9a, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100e_3f9e, 2); if(jz(0x100e_3fbc, 0x1c)) goto l_0x100e_3fbc; /* jz 0x100e3fbc */
            ii(0x100e_3fa0, 3); mov(edx, memd[ss, ebp - 0x2a]);         /* mov edx, [ebp-0x2a] */
            ii(0x100e_3fa3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_3fa6, 3); mov(eax, memd[ds, eax + 0x44]);         /* mov eax, [eax+0x44] */
            ii(0x100e_3fa9, 5); call(0x100d_820d, -0xbda1);             /* call 0x100d820d */
            ii(0x100e_3fae, 3); mov(edx, memd[ss, ebp - 0x2a]);         /* mov edx, [ebp-0x2a] */
            ii(0x100e_3fb1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_3fb4, 3); mov(eax, memd[ds, eax + 0x48]);         /* mov eax, [eax+0x48] */
            ii(0x100e_3fb7, 5); call(0x100d_820d, -0xbdaf);             /* call 0x100d820d */
        l_0x100e_3fbc:
            ii(0x100e_3fbc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_3fbe, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_3fbf, 1); pop(edi);                               /* pop edi */
            ii(0x100e_3fc0, 1); pop(esi);                               /* pop esi */
            ii(0x100e_3fc1, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_3fc2, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_3fc3, 1); ret();                                  /* ret */
        }
    }
}
