using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_6bee-48f081a3")]
        public void Method_1011_6bee()
        {
            ii(0x1011_6bee, 5); push(0x84);                             /* push 0x84 */
            ii(0x1011_6bf3, 5); call(Definitions.sys_check_available_stack_size, 0x4_f15a); /* call 0x10165d52 */
            ii(0x1011_6bf8, 1); push(ecx);                              /* push ecx */
            ii(0x1011_6bf9, 1); push(esi);                              /* push esi */
            ii(0x1011_6bfa, 1); push(edi);                              /* push edi */
            ii(0x1011_6bfb, 1); push(ebp);                              /* push ebp */
            ii(0x1011_6bfc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_6bfe, 6); sub(esp, 0x58);                         /* sub esp, 0x58 */
            ii(0x1011_6c04, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1011_6c07, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1011_6c0a, 3); mov(memb[ss, ebp - 0x4], bl);           /* mov [ebp-0x4], bl */
            ii(0x1011_6c0d, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1011_6c11, 2); if(jz(0x1011_6c19, 0x6)) goto l_0x1011_6c19; /* jz 0x10116c19 */
            ii(0x1011_6c13, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1011_6c17, 2); jmp(0x1011_6c1d, 0x4); goto l_0x1011_6c1d; /* jmp 0x10116c1d */
        l_0x1011_6c19:
            ii(0x1011_6c19, 4); mov(memb[ss, ebp - 0x10], 0x26);        /* mov byte [ebp-0x10], 0x26 */
        l_0x1011_6c1d:
            ii(0x1011_6c1d, 3); mov(ebx, memd[ss, ebp - 0x13]);         /* mov ebx, [ebp-0x13] */
            ii(0x1011_6c20, 3); sar(ebx, 0x18);                         /* sar ebx, 0x18 */
            ii(0x1011_6c23, 5); mov(edx, 0x6e6);                        /* mov edx, 0x6e6 */
            ii(0x1011_6c28, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_6c2b, 5); call(0x100d_68a3, -0x4_038d);           /* call 0x100d68a3 */
            ii(0x1011_6c30, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1011_6c33, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1011_6c36, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_6c39, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_6c3c, 7); mov(memd[ds, eax + 0x13], 0x101b_673c); /* mov dword [eax+0x13], 0x101b673c */
            ii(0x1011_6c43, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1011_6c48, 5); call(0x1012_0d94, 0xa147);              /* call 0x10120d94 */
            ii(0x1011_6c4d, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1011_6c52, 5); call(/* sys */ 0x1016_a24c, 0x5_35f5);  /* call 0x1016a24c */
            ii(0x1011_6c57, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1011_6c5c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_6c5f, 5); call(0x100e_f318, -0x2_794c);           /* call 0x100ef318 */
            ii(0x1011_6c64, 5); call(0x100d_6124, -0x4_0b45);           /* call 0x100d6124 */
            ii(0x1011_6c69, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_6c6b, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_6c6d, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_6c70, 5); call(0x100d_6adf, -0x4_0196);           /* call 0x100d6adf */
            ii(0x1011_6c75, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1011_6c78, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x1011_6c7b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_6c7e, 5); call(0x100d_6a11, -0x4_0272);           /* call 0x100d6a11 */
            ii(0x1011_6c83, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1011_6c88, 5); call(Definitions.sys_new, 0x4_f173);    /* call 0x10165e00 */
            ii(0x1011_6c8d, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_6c90, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_6c93, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_6c96, 4); cmp(memd[ss, ebp - 0x1c], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1011_6c9a, 2); if(jz(0x1011_6cc4, 0x28)) goto l_0x1011_6cc4; /* jz 0x10116cc4 */
            ii(0x1011_6c9c, 5); mov(eax, 0xc1);                         /* mov eax, 0xc1 */
            ii(0x1011_6ca1, 1); push(eax);                              /* push eax */
            ii(0x1011_6ca2, 5); mov(ecx, 0x9b);                         /* mov ecx, 0x9b */
            ii(0x1011_6ca7, 5); mov(ebx, 0x159);                        /* mov ebx, 0x159 */
            ii(0x1011_6cac, 5); mov(edx, 0x158);                        /* mov edx, 0x158 */
            ii(0x1011_6cb1, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_6cb4, 5); call(Definitions.my_ctor_c17, -0x4_88aa); /* call 0x100ce40f */
            ii(0x1011_6cb9, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1011_6cbc, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1011_6cbf, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1011_6cc2, 2); jmp(0x1011_6cca, 0x6); goto l_0x1011_6cca; /* jmp 0x10116cca */
        l_0x1011_6cc4:
            ii(0x1011_6cc4, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1011_6cc7, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
        l_0x1011_6cca:
            ii(0x1011_6cca, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1011_6ccd, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1011_6cd0, 3); mov(memd[ds, edx + 0x33], eax);         /* mov [edx+0x33], eax */
            ii(0x1011_6cd3, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1011_6cd8, 5); call(Definitions.sys_new, 0x4_f123);    /* call 0x10165e00 */
            ii(0x1011_6cdd, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1011_6ce0, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1011_6ce3, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1011_6ce6, 4); cmp(memd[ss, ebp - 0x2c], 0);           /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x1011_6cea, 2); if(jz(0x1011_6d14, 0x28)) goto l_0x1011_6d14; /* jz 0x10116d14 */
            ii(0x1011_6cec, 5); mov(eax, 0xc1);                         /* mov eax, 0xc1 */
            ii(0x1011_6cf1, 1); push(eax);                              /* push eax */
            ii(0x1011_6cf2, 5); mov(ecx, 0x55);                         /* mov ecx, 0x55 */
            ii(0x1011_6cf7, 5); mov(ebx, 0x14f);                        /* mov ebx, 0x14f */
            ii(0x1011_6cfc, 5); mov(edx, 0x14e);                        /* mov edx, 0x14e */
            ii(0x1011_6d01, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1011_6d04, 5); call(Definitions.my_ctor_c17, -0x4_88fa); /* call 0x100ce40f */
            ii(0x1011_6d09, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1011_6d0c, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1011_6d0f, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1011_6d12, 2); jmp(0x1011_6d1a, 0x6); goto l_0x1011_6d1a; /* jmp 0x10116d1a */
        l_0x1011_6d14:
            ii(0x1011_6d14, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1011_6d17, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
        l_0x1011_6d1a:
            ii(0x1011_6d1a, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1011_6d1d, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1011_6d20, 3); mov(memd[ds, edx + 0x37], eax);         /* mov [edx+0x37], eax */
            ii(0x1011_6d23, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1011_6d26, 5); call(0x100d_5224, -0x4_1b07);           /* call 0x100d5224 */
            ii(0x1011_6d2b, 1); push(eax);                              /* push eax */
            ii(0x1011_6d2c, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1011_6d2f, 5); call(0x100d_5250, -0x4_1ae4);           /* call 0x100d5250 */
            ii(0x1011_6d34, 1); push(eax);                              /* push eax */
            ii(0x1011_6d35, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1011_6d38, 5); call(0x100d_527c, -0x4_1ac1);           /* call 0x100d527c */
            ii(0x1011_6d3d, 1); push(eax);                              /* push eax */
            ii(0x1011_6d3e, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1011_6d41, 5); call(0x100d_52a8, -0x4_1a9e);           /* call 0x100d52a8 */
            ii(0x1011_6d46, 1); push(eax);                              /* push eax */
            ii(0x1011_6d47, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1011_6d4c, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1011_6d51, 5); mov(edx, StringDefinitions.Ok4);        /* mov edx, 0x101a7b13 */
            ii(0x1011_6d56, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_6d59, 3); mov(eax, memd[ds, eax + 0x33]);         /* mov eax, [eax+0x33] */
            ii(0x1011_6d5c, 5); call(0x100c_ef64, -0x4_7dfd);           /* call 0x100cef64 */
            ii(0x1011_6d61, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1011_6d64, 5); call(0x100d_5224, -0x4_1b45);           /* call 0x100d5224 */
            ii(0x1011_6d69, 1); push(eax);                              /* push eax */
            ii(0x1011_6d6a, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1011_6d6d, 5); call(0x100d_5250, -0x4_1b22);           /* call 0x100d5250 */
            ii(0x1011_6d72, 1); push(eax);                              /* push eax */
            ii(0x1011_6d73, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x1011_6d76, 5); call(0x100d_527c, -0x4_1aff);           /* call 0x100d527c */
            ii(0x1011_6d7b, 1); push(eax);                              /* push eax */
            ii(0x1011_6d7c, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1011_6d7f, 5); call(0x100d_52a8, -0x4_1adc);           /* call 0x100d52a8 */
            ii(0x1011_6d84, 1); push(eax);                              /* push eax */
            ii(0x1011_6d85, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1011_6d8a, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1011_6d8f, 5); mov(edx, StringDefinitions.Cancel6);    /* mov edx, 0x101a7b16 */
            ii(0x1011_6d94, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_6d97, 3); mov(eax, memd[ds, eax + 0x37]);         /* mov eax, [eax+0x37] */
            ii(0x1011_6d9a, 5); call(0x100c_ef64, -0x4_7e3b);           /* call 0x100cef64 */
            ii(0x1011_6d9f, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1011_6da4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_6da7, 3); mov(eax, memd[ds, eax + 0x33]);         /* mov eax, [eax+0x33] */
            ii(0x1011_6daa, 5); call(0x100d_5134, -0x4_1c7b);           /* call 0x100d5134 */
            ii(0x1011_6daf, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x1011_6db4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_6db7, 3); mov(eax, memd[ds, eax + 0x37]);         /* mov eax, [eax+0x37] */
            ii(0x1011_6dba, 5); call(0x100d_5134, -0x4_1c8b);           /* call 0x100d5134 */
            ii(0x1011_6dbf, 5); mov(edx, 0x700d);                       /* mov edx, 0x700d */
            ii(0x1011_6dc4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_6dc7, 3); mov(eax, memd[ds, eax + 0x33]);         /* mov eax, [eax+0x33] */
            ii(0x1011_6dca, 5); call(0x100d_5164, -0x4_1c6b);           /* call 0x100d5164 */
            ii(0x1011_6dcf, 5); mov(edx, 0x701b);                       /* mov edx, 0x701b */
            ii(0x1011_6dd4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_6dd7, 3); mov(eax, memd[ds, eax + 0x37]);         /* mov eax, [eax+0x37] */
            ii(0x1011_6dda, 5); call(0x100d_5164, -0x4_1c7b);           /* call 0x100d5164 */
            ii(0x1011_6ddf, 5); mov(edx, 0x4e6);                        /* mov edx, 0x4e6 */
            ii(0x1011_6de4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_6de7, 3); mov(eax, memd[ds, eax + 0x33]);         /* mov eax, [eax+0x33] */
            ii(0x1011_6dea, 5); call(0x100d_50d4, -0x4_1d1b);           /* call 0x100d50d4 */
            ii(0x1011_6def, 5); mov(edx, 0x4e4);                        /* mov edx, 0x4e4 */
            ii(0x1011_6df4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_6df7, 3); mov(eax, memd[ds, eax + 0x37]);         /* mov eax, [eax+0x37] */
            ii(0x1011_6dfa, 5); call(0x100d_50d4, -0x4_1d2b);           /* call 0x100d50d4 */
            ii(0x1011_6dff, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1011_6e02, 3); mov(edx, memd[ds, edx + 0x29]);         /* mov edx, [edx+0x29] */
            ii(0x1011_6e05, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_6e08, 3); mov(eax, memd[ds, eax + 0x33]);         /* mov eax, [eax+0x33] */
            ii(0x1011_6e0b, 5); call(0x100c_f85c, -0x4_75b4);           /* call 0x100cf85c */
            ii(0x1011_6e10, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_6e13, 3); mov(edx, memd[ds, eax + 0x29]);         /* mov edx, [eax+0x29] */
            ii(0x1011_6e16, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_6e19, 3); mov(eax, memd[ds, eax + 0x37]);         /* mov eax, [eax+0x37] */
            ii(0x1011_6e1c, 5); call(0x100c_f85c, -0x4_75c5);           /* call 0x100cf85c */
            ii(0x1011_6e21, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1011_6e26, 1); push(eax);                              /* push eax */
            ii(0x1011_6e27, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1011_6e2c, 1); push(eax);                              /* push eax */
            ii(0x1011_6e2d, 5); push(0x1_00ff);                         /* push 0x100ff */
            ii(0x1011_6e32, 5); mov(eax, 0xaf);                         /* mov eax, 0xaf */
            ii(0x1011_6e37, 1); push(eax);                              /* push eax */
            ii(0x1011_6e38, 5); mov(eax, 0x109);                        /* mov eax, 0x109 */
            ii(0x1011_6e3d, 1); push(eax);                              /* push eax */
            ii(0x1011_6e3e, 5); mov(eax, 0xe);                          /* mov eax, 0xe */
            ii(0x1011_6e43, 1); push(eax);                              /* push eax */
            ii(0x1011_6e44, 5); mov(ecx, 0x14);                         /* mov ecx, 0x14 */
            ii(0x1011_6e49, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1011_6e4c, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1011_6e4f, 3); mov(edx, memd[ds, edx + 0x25]);         /* mov edx, [edx+0x25] */
            ii(0x1011_6e52, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_6e55, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_6e58, 3); mov(eax, memd[ds, eax + 0x2d]);         /* mov eax, [eax+0x2d] */
            ii(0x1011_6e5b, 5); call(0x100e_9ae5, -0x2_d37b);           /* call 0x100e9ae5 */
            ii(0x1011_6e60, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1011_6e63, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x1011_6e66, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_6e69, 3); mov(eax, memd[ds, eax + 0x29]);         /* mov eax, [eax+0x29] */
            ii(0x1011_6e6c, 5); call(Definitions.sys_display_draw_1, 0x5_0637); /* call 0x101674a8 */
            ii(0x1011_6e71, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_6e74, 3); mov(memd[ss, ebp - 0x58], eax);         /* mov [ebp-0x58], eax */
            ii(0x1011_6e77, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x1011_6e7a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_6e7c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_6e7d, 1); pop(edi);                               /* pop edi */
            ii(0x1011_6e7e, 1); pop(esi);                               /* pop esi */
            ii(0x1011_6e7f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_6e80, 1); ret();                                  /* ret */
        }
    }
}
