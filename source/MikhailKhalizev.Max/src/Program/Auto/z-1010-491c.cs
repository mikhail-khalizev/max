using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_491c-f4c90092")]
        public void Method_1010_491c()
        {
            ii(0x1010_491c, 5); pushd(0x9c);                            /* push 0x9c */
            ii(0x1010_4921, 5); calld(Definitions.sys_check_available_stack_size, 0x6_142c); /* call 0x10165d52 */
            ii(0x1010_4926, 1); pushd(esi);                             /* push esi */
            ii(0x1010_4927, 1); pushd(edi);                             /* push edi */
            ii(0x1010_4928, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_4929, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_492b, 6); sub(esp, 0x7c);                         /* sub esp, 0x7c */
            ii(0x1010_4931, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_4934, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1010_4937, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1010_493a, 3); mov(memd_a32[ss, ebp - 0xc], ecx);      /* mov [ebp-0xc], ecx */
            ii(0x1010_493d, 4); movsx(ebx, memb_a32[ss, ebp + 0x10]);   /* movsx ebx, byte [ebp+0x10] */
            ii(0x1010_4941, 5); mov(edx, 0x6e6);                        /* mov edx, 0x6e6 */
            ii(0x1010_4946, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4949, 5); calld(0x100d_68a3, -0x2_e0ab);          /* call 0x100d68a3 */
            ii(0x1010_494e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_4951, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1010_4954, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1010_4957, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_495a, 7); mov(memd_a32[ds, eax + 0x13], 0x101b_64a4); /* mov dword [eax+0x13], 0x101b64a4 */
            ii(0x1010_4961, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1010_4964, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1010_4967, 6); mov(memb_a32[ds, edx + 0x457], al);     /* mov [edx+0x457], al */
            ii(0x1010_496d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4970, 6); mov(memw_a32[ds, eax + 0x45], 0);       /* mov word [eax+0x45], 0x0 */
            ii(0x1010_4976, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4979, 7); mov(memd_a32[ds, eax + 0x33], 0);       /* mov dword [eax+0x33], 0x0 */
            ii(0x1010_4980, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4983, 7); mov(memd_a32[ds, eax + 0x37], 0);       /* mov dword [eax+0x37], 0x0 */
            ii(0x1010_498a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_498d, 7); mov(memd_a32[ds, eax + 0x3b], 0);       /* mov dword [eax+0x3b], 0x0 */
            ii(0x1010_4994, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4997, 7); mov(memd_a32[ds, eax + 0x3f], 0);       /* mov dword [eax+0x3f], 0x0 */
            ii(0x1010_499e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_49a1, 10); mov(memd_a32[ds, eax + 0x46c], 0);     /* mov dword [eax+0x46c], 0x0 */
            ii(0x1010_49ab, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_49ae, 9); mov(memw_a32[ds, eax + 0x46a], 0);      /* mov word [eax+0x46a], 0x0 */
            ii(0x1010_49b7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_49ba, 9); mov(memw_a32[ds, eax + 0x468], 0);      /* mov word [eax+0x468], 0x0 */
            ii(0x1010_49c3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_49c6, 10); mov(memd_a32[ds, eax + 0x462], 0);     /* mov dword [eax+0x462], 0x0 */
            ii(0x1010_49d0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_49d3, 4); mov(memb_a32[ds, eax + 0x31], 0);       /* mov byte [eax+0x31], 0x0 */
            ii(0x1010_49d7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_49da, 4); mov(memb_a32[ds, eax + 0x32], 0);       /* mov byte [eax+0x32], 0x0 */
            ii(0x1010_49de, 3); mov(al, memb_a32[ss, ebp + 0x10]);      /* mov al, [ebp+0x10] */
            ii(0x1010_49e1, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1010_49e4, 6); mov(memb_a32[ds, edx + 0x458], al);     /* mov [edx+0x458], al */
            ii(0x1010_49ea, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_49ed, 7); mov(memb_a32[ds, eax + 0x470], 0);      /* mov byte [eax+0x470], 0x0 */
            ii(0x1010_49f4, 4); mov(memb_a32[ss, ebp - 0x18], 0);       /* mov byte [ebp-0x18], 0x0 */
            ii(0x1010_49f8, 5); mov(eax, 0x765);                        /* mov eax, 0x765 */
            ii(0x1010_49fd, 5); calld(0x1013_433e, 0x2_f93c);           /* call 0x1013433e */
            ii(0x1010_4a02, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_4a04, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4a07, 6); mov(memd_a32[ds, eax + 0x45d], edx);    /* mov [eax+0x45d], edx */
            ii(0x1010_4a0d, 5); mov(eax, 0x765);                        /* mov eax, 0x765 */
            ii(0x1010_4a12, 5); calld(0x1013_43b3, 0x2_f99c);           /* call 0x101343b3 */
            ii(0x1010_4a17, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_4a19, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4a1c, 6); mov(memd_a32[ds, eax + 0x459], edx);    /* mov [eax+0x459], edx */
            ii(0x1010_4a22, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4a25, 7); cmp(memd_a32[ds, eax + 0x459], 0);      /* cmp dword [eax+0x459], 0x0 */
            ii(0x1010_4a2c, 2); if(jzd(0x1010_4a6a, 0x3c)) goto l_0x1010_4a6a; /* jz 0x10104a6a */
            ii(0x1010_4a2e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4a31, 5); calld(0x1010_4fac, 0x576);              /* call 0x10104fac */
            ii(0x1010_4a36, 2); test(al, al);                           /* test al, al */
            ii(0x1010_4a38, 2); if(jzd(0x1010_4a6a, 0x30)) goto l_0x1010_4a6a; /* jz 0x10104a6a */
            ii(0x1010_4a3a, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1010_4a3d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_4a40, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4a43, 5); calld(0x1010_50a2, 0x65a);              /* call 0x101050a2 */
            ii(0x1010_4a48, 2); test(al, al);                           /* test al, al */
            ii(0x1010_4a4a, 2); if(jzd(0x1010_4a6a, 0x1e)) goto l_0x1010_4a6a; /* jz 0x10104a6a */
            ii(0x1010_4a4c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4a4f, 5); calld(0x1010_5150, 0x6fc);              /* call 0x10105150 */
            ii(0x1010_4a54, 2); test(al, al);                           /* test al, al */
            ii(0x1010_4a56, 2); if(jzd(0x1010_4a5e, 0x6)) goto l_0x1010_4a5e; /* jz 0x10104a5e */
            ii(0x1010_4a58, 4); mov(memb_a32[ss, ebp - 0x18], 0x1);     /* mov byte [ebp-0x18], 0x1 */
            ii(0x1010_4a5c, 2); jmpd(0x1010_4a6a, 0xc); goto l_0x1010_4a6a; /* jmp 0x10104a6a */
        l_0x1010_4a5e:
            ii(0x1010_4a5e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4a61, 4); mov(memb_a32[ds, eax + 0x31], 0x1);     /* mov byte [eax+0x31], 0x1 */
            ii(0x1010_4a65, 5); jmpd(0x1010_4d3c, 0x2d2); goto l_0x1010_4d3c; /* jmp 0x10104d3c */
        l_0x1010_4a6a:
            ii(0x1010_4a6a, 4); cmp(memb_a32[ss, ebp - 0x18], 0);       /* cmp byte [ebp-0x18], 0x0 */
            ii(0x1010_4a6e, 2); if(jnzd(0x1010_4a83, 0x13)) goto l_0x1010_4a83; /* jnz 0x10104a83 */
            ii(0x1010_4a70, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4a73, 4); mov(memb_a32[ds, eax + 0x32], 0x1);     /* mov byte [eax+0x32], 0x1 */
            ii(0x1010_4a77, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4a7a, 4); mov(memb_a32[ds, eax + 0x31], 0x1);     /* mov byte [eax+0x31], 0x1 */
            ii(0x1010_4a7e, 5); jmpd(0x1010_4d3c, 0x2b9); goto l_0x1010_4d3c; /* jmp 0x10104d3c */
        l_0x1010_4a83:
            ii(0x1010_4a83, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_4a88, 5); calld(0x1012_0d94, 0x1_c307);           /* call 0x10120d94 */
            ii(0x1010_4a8d, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1010_4a92, 5); calld(/* sys */ 0x1016_a24c, 0x6_57b5); /* call 0x1016a24c */
            ii(0x1010_4a97, 5); calld(0x100d_6124, -0x2_e978);          /* call 0x100d6124 */
            ii(0x1010_4a9c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_4a9e, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1010_4aa0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4aa3, 5); calld(0x100d_6adf, -0x2_dfc9);          /* call 0x100d6adf */
            ii(0x1010_4aa8, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1010_4aab, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x1010_4aae, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4ab1, 5); calld(0x100d_6a11, -0x2_e0a5);          /* call 0x100d6a11 */
            ii(0x1010_4ab6, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1010_4abb, 5); calld(Definitions.sys_new, 0x6_1340);   /* call 0x10165e00 */
            ii(0x1010_4ac0, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1010_4ac3, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_4ac6, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1010_4ac9, 4); cmp(memd_a32[ss, ebp - 0x20], 0);       /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1010_4acd, 2); if(jzd(0x1010_4af9, 0x2a)) goto l_0x1010_4af9; /* jz 0x10104af9 */
            ii(0x1010_4acf, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4ad2, 3); mov(eax, memd_a32[ds, eax + 0x21]);     /* mov eax, [eax+0x21] */
            ii(0x1010_4ad5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_4ad8, 1); pushd(eax);                             /* push eax */
            ii(0x1010_4ad9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4adc, 3); mov(ecx, memd_a32[ds, eax + 0x1d]);     /* mov ecx, [eax+0x1d] */
            ii(0x1010_4adf, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1010_4ae2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_4ae4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_4ae6, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_4ae9, 5); calld(0x100d_7bdc, -0x2_cf12);          /* call 0x100d7bdc */
            ii(0x1010_4aee, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1010_4af1, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1010_4af4, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1010_4af7, 2); jmpd(0x1010_4aff, 0x6); goto l_0x1010_4aff; /* jmp 0x10104aff */
        l_0x1010_4af9:
            ii(0x1010_4af9, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1010_4afc, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x1010_4aff:
            ii(0x1010_4aff, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1010_4b02, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1010_4b05, 6); mov(memd_a32[ds, edx + 0x462], eax);    /* mov [edx+0x462], eax */
            ii(0x1010_4b0b, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1010_4b0e, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x1010_4b11, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4b14, 6); mov(eax, memd_a32[ds, eax + 0x462]);    /* mov eax, [eax+0x462] */
            ii(0x1010_4b1a, 5); calld(0x100d_7d74, -0x2_cdab);          /* call 0x100d7d74 */
            ii(0x1010_4b1f, 4); cmp(memb_a32[ss, ebp - 0x4], 0x9);      /* cmp byte [ebp-0x4], 0x9 */
            ii(0x1010_4b23, 6); if(jnzd(0x1010_4c4a, 0x121)) goto l_0x1010_4c4a; /* jnz 0x10104c4a */
            ii(0x1010_4b29, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1010_4b2e, 5); calld(Definitions.sys_new, 0x6_12cd);   /* call 0x10165e00 */
            ii(0x1010_4b33, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1010_4b36, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1010_4b39, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1010_4b3c, 4); cmp(memd_a32[ss, ebp - 0x30], 0);       /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1010_4b40, 2); if(jzd(0x1010_4b6a, 0x28)) goto l_0x1010_4b6a; /* jz 0x10104b6a */
            ii(0x1010_4b42, 5); mov(eax, 0xc1);                         /* mov eax, 0xc1 */
            ii(0x1010_4b47, 1); pushd(eax);                             /* push eax */
            ii(0x1010_4b48, 5); mov(ecx, 0x55);                         /* mov ecx, 0x55 */
            ii(0x1010_4b4d, 5); mov(ebx, 0x159);                        /* mov ebx, 0x159 */
            ii(0x1010_4b52, 5); mov(edx, 0x158);                        /* mov edx, 0x158 */
            ii(0x1010_4b57, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1010_4b5a, 5); calld(Definitions.my_ctor_c17, -0x3_6750); /* call 0x100ce40f */
            ii(0x1010_4b5f, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1010_4b62, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1010_4b65, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1010_4b68, 2); jmpd(0x1010_4b70, 0x6); goto l_0x1010_4b70; /* jmp 0x10104b70 */
        l_0x1010_4b6a:
            ii(0x1010_4b6a, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1010_4b6d, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
        l_0x1010_4b70:
            ii(0x1010_4b70, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1010_4b73, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1010_4b76, 3); mov(memd_a32[ds, edx + 0x33], eax);     /* mov [edx+0x33], eax */
            ii(0x1010_4b79, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1010_4b7e, 5); calld(Definitions.sys_new, 0x6_127d);   /* call 0x10165e00 */
            ii(0x1010_4b83, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1010_4b86, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1010_4b89, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1010_4b8c, 4); cmp(memd_a32[ss, ebp - 0x40], 0);       /* cmp dword [ebp-0x40], 0x0 */
            ii(0x1010_4b90, 2); if(jzd(0x1010_4bba, 0x28)) goto l_0x1010_4bba; /* jz 0x10104bba */
            ii(0x1010_4b92, 5); mov(eax, 0xc1);                         /* mov eax, 0xc1 */
            ii(0x1010_4b97, 1); pushd(eax);                             /* push eax */
            ii(0x1010_4b98, 5); mov(ecx, 0x9b);                         /* mov ecx, 0x9b */
            ii(0x1010_4b9d, 5); mov(ebx, 0x159);                        /* mov ebx, 0x159 */
            ii(0x1010_4ba2, 5); mov(edx, 0x158);                        /* mov edx, 0x158 */
            ii(0x1010_4ba7, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1010_4baa, 5); calld(Definitions.my_ctor_c17, -0x3_67a0); /* call 0x100ce40f */
            ii(0x1010_4baf, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1010_4bb2, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1010_4bb5, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1010_4bb8, 2); jmpd(0x1010_4bc0, 0x6); goto l_0x1010_4bc0; /* jmp 0x10104bc0 */
        l_0x1010_4bba:
            ii(0x1010_4bba, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1010_4bbd, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
        l_0x1010_4bc0:
            ii(0x1010_4bc0, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1010_4bc3, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1010_4bc6, 3); mov(memd_a32[ds, edx + 0x37], eax);     /* mov [edx+0x37], eax */
            ii(0x1010_4bc9, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1010_4bcc, 5); calld(0x100d_5224, -0x2_f9ad);          /* call 0x100d5224 */
            ii(0x1010_4bd1, 1); pushd(eax);                             /* push eax */
            ii(0x1010_4bd2, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x1010_4bd5, 5); calld(0x100d_5250, -0x2_f98a);          /* call 0x100d5250 */
            ii(0x1010_4bda, 1); pushd(eax);                             /* push eax */
            ii(0x1010_4bdb, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1010_4bde, 5); calld(0x100d_527c, -0x2_f967);          /* call 0x100d527c */
            ii(0x1010_4be3, 1); pushd(eax);                             /* push eax */
            ii(0x1010_4be4, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x1010_4be7, 5); calld(0x100d_52a8, -0x2_f944);          /* call 0x100d52a8 */
            ii(0x1010_4bec, 1); pushd(eax);                             /* push eax */
            ii(0x1010_4bed, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1010_4bf2, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1010_4bf7, 5); mov(edx, StringDefinitions.Keys);       /* mov edx, 0x101a32e0 */
            ii(0x1010_4bfc, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4bff, 3); mov(eax, memd_a32[ds, eax + 0x37]);     /* mov eax, [eax+0x37] */
            ii(0x1010_4c02, 5); calld(0x100c_ef64, -0x3_5ca3);          /* call 0x100cef64 */
            ii(0x1010_4c07, 5); mov(edx, 0x3e8);                        /* mov edx, 0x3e8 */
            ii(0x1010_4c0c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4c0f, 3); mov(eax, memd_a32[ds, eax + 0x37]);     /* mov eax, [eax+0x37] */
            ii(0x1010_4c12, 5); calld(0x100d_5134, -0x2_fae3);          /* call 0x100d5134 */
            ii(0x1010_4c17, 5); mov(edx, 0x3e8);                        /* mov edx, 0x3e8 */
            ii(0x1010_4c1c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4c1f, 3); mov(eax, memd_a32[ds, eax + 0x37]);     /* mov eax, [eax+0x37] */
            ii(0x1010_4c22, 5); calld(0x100d_5164, -0x2_fac3);          /* call 0x100d5164 */
            ii(0x1010_4c27, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1010_4c2c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4c2f, 3); mov(eax, memd_a32[ds, eax + 0x37]);     /* mov eax, [eax+0x37] */
            ii(0x1010_4c32, 5); calld(0x100d_5194, -0x2_faa3);          /* call 0x100d5194 */
            ii(0x1010_4c37, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4c3a, 3); mov(edx, memd_a32[ds, eax + 0x29]);     /* mov edx, [eax+0x29] */
            ii(0x1010_4c3d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4c40, 3); mov(eax, memd_a32[ds, eax + 0x37]);     /* mov eax, [eax+0x37] */
            ii(0x1010_4c43, 5); calld(0x100c_f85c, -0x3_53ec);          /* call 0x100cf85c */
            ii(0x1010_4c48, 2); jmpd(0x1010_4c9a, 0x50); goto l_0x1010_4c9a; /* jmp 0x10104c9a */
        l_0x1010_4c4a:
            ii(0x1010_4c4a, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1010_4c4f, 5); calld(Definitions.sys_new, 0x6_11ac);   /* call 0x10165e00 */
            ii(0x1010_4c54, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x1010_4c57, 3); mov(eax, memd_a32[ss, ebp - 0x5c]);     /* mov eax, [ebp-0x5c] */
            ii(0x1010_4c5a, 3); mov(memd_a32[ss, ebp - 0x60], eax);     /* mov [ebp-0x60], eax */
            ii(0x1010_4c5d, 4); cmp(memd_a32[ss, ebp - 0x60], 0);       /* cmp dword [ebp-0x60], 0x0 */
            ii(0x1010_4c61, 2); if(jzd(0x1010_4c8b, 0x28)) goto l_0x1010_4c8b; /* jz 0x10104c8b */
            ii(0x1010_4c63, 5); mov(eax, 0xc1);                         /* mov eax, 0xc1 */
            ii(0x1010_4c68, 1); pushd(eax);                             /* push eax */
            ii(0x1010_4c69, 5); mov(ecx, 0x78);                         /* mov ecx, 0x78 */
            ii(0x1010_4c6e, 5); mov(ebx, 0x159);                        /* mov ebx, 0x159 */
            ii(0x1010_4c73, 5); mov(edx, 0x158);                        /* mov edx, 0x158 */
            ii(0x1010_4c78, 3); mov(eax, memd_a32[ss, ebp - 0x5c]);     /* mov eax, [ebp-0x5c] */
            ii(0x1010_4c7b, 5); calld(Definitions.my_ctor_c17, -0x3_6871); /* call 0x100ce40f */
            ii(0x1010_4c80, 3); mov(memd_a32[ss, ebp - 0x64], eax);     /* mov [ebp-0x64], eax */
            ii(0x1010_4c83, 3); mov(eax, memd_a32[ss, ebp - 0x64]);     /* mov eax, [ebp-0x64] */
            ii(0x1010_4c86, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
            ii(0x1010_4c89, 2); jmpd(0x1010_4c91, 0x6); goto l_0x1010_4c91; /* jmp 0x10104c91 */
        l_0x1010_4c8b:
            ii(0x1010_4c8b, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x1010_4c8e, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
        l_0x1010_4c91:
            ii(0x1010_4c91, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x1010_4c94, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1010_4c97, 3); mov(memd_a32[ds, edx + 0x33], eax);     /* mov [edx+0x33], eax */
        l_0x1010_4c9a:
            ii(0x1010_4c9a, 3); lea(eax, ebp - 0x6c);                   /* lea eax, [ebp-0x6c] */
            ii(0x1010_4c9d, 5); calld(0x100d_5224, -0x2_fa7e);          /* call 0x100d5224 */
            ii(0x1010_4ca2, 1); pushd(eax);                             /* push eax */
            ii(0x1010_4ca3, 3); lea(eax, ebp - 0x70);                   /* lea eax, [ebp-0x70] */
            ii(0x1010_4ca6, 5); calld(0x100d_5250, -0x2_fa5b);          /* call 0x100d5250 */
            ii(0x1010_4cab, 1); pushd(eax);                             /* push eax */
            ii(0x1010_4cac, 3); lea(eax, ebp - 0x74);                   /* lea eax, [ebp-0x74] */
            ii(0x1010_4caf, 5); calld(0x100d_527c, -0x2_fa38);          /* call 0x100d527c */
            ii(0x1010_4cb4, 1); pushd(eax);                             /* push eax */
            ii(0x1010_4cb5, 3); lea(eax, ebp - 0x78);                   /* lea eax, [ebp-0x78] */
            ii(0x1010_4cb8, 5); calld(0x100d_52a8, -0x2_fa15);          /* call 0x100d52a8 */
            ii(0x1010_4cbd, 1); pushd(eax);                             /* push eax */
            ii(0x1010_4cbe, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1010_4cc3, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1010_4cc8, 5); mov(edx, StringDefinitions.Done3);      /* mov edx, 0x101a32e5 */
            ii(0x1010_4ccd, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4cd0, 3); mov(eax, memd_a32[ds, eax + 0x33]);     /* mov eax, [eax+0x33] */
            ii(0x1010_4cd3, 5); calld(0x100c_ef64, -0x3_5d74);          /* call 0x100cef64 */
            ii(0x1010_4cd8, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1010_4cdd, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4ce0, 3); mov(eax, memd_a32[ds, eax + 0x33]);     /* mov eax, [eax+0x33] */
            ii(0x1010_4ce3, 5); calld(0x100d_5134, -0x2_fbb4);          /* call 0x100d5134 */
            ii(0x1010_4ce8, 5); mov(edx, 0x7000);                       /* mov edx, 0x7000 */
            ii(0x1010_4ced, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4cf0, 3); mov(eax, memd_a32[ds, eax + 0x33]);     /* mov eax, [eax+0x33] */
            ii(0x1010_4cf3, 5); calld(0x100d_5164, -0x2_fb94);          /* call 0x100d5164 */
            ii(0x1010_4cf8, 5); mov(edx, 0x4e6);                        /* mov edx, 0x4e6 */
            ii(0x1010_4cfd, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4d00, 3); mov(eax, memd_a32[ds, eax + 0x33]);     /* mov eax, [eax+0x33] */
            ii(0x1010_4d03, 5); calld(0x100d_50d4, -0x2_fc34);          /* call 0x100d50d4 */
            ii(0x1010_4d08, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1010_4d0b, 3); mov(edx, memd_a32[ds, edx + 0x29]);     /* mov edx, [edx+0x29] */
            ii(0x1010_4d0e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4d11, 3); mov(eax, memd_a32[ds, eax + 0x33]);     /* mov eax, [eax+0x33] */
            ii(0x1010_4d14, 5); calld(0x100c_f85c, -0x3_54bd);          /* call 0x100cf85c */
            ii(0x1010_4d19, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4d1c, 6); mov(memw_a32[ds, eax + 0x43], 0);       /* mov word [eax+0x43], 0x0 */
            ii(0x1010_4d22, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1010_4d25, 3); mov(edx, memd_a32[ds, edx + 0x41]);     /* mov edx, [edx+0x41] */
            ii(0x1010_4d28, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_4d2b, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1010_4d2e, 3); add(edx, memd_a32[ss, ebp - 0x10]);     /* add edx, [ebp-0x10] */
            ii(0x1010_4d31, 3); mov(edx, memd_a32[ds, edx + 0x47]);     /* mov edx, [edx+0x47] */
            ii(0x1010_4d34, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4d37, 5); calld(0x1010_53e9, 0x6ad);              /* call 0x101053e9 */
        l_0x1010_4d3c:
            ii(0x1010_4d3c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_4d3f, 3); mov(memd_a32[ss, ebp - 0x7c], eax);     /* mov [ebp-0x7c], eax */
            ii(0x1010_4d42, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x1010_4d45, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_4d47, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_4d48, 1); popd(edi);                              /* pop edi */
            ii(0x1010_4d49, 1); popd(esi);                              /* pop esi */
            ii(0x1010_4d4a, 3); retd(0x4);                              /* ret 0x4 */
        }
    }
}
