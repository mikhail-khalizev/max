using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d62f665f-ed14-4949-b2ba-5357aefcd294")]
        public void Method_1009_6e02()
        {
            ii(0x1009_6e02, 5); pushd(0x134);                           /* push 0x134 */
            ii(0x1009_6e07, 5); calld(Definitions.sys_check_available_stack_size, 0xc_ef46); /* call 0x10165d52 */
            ii(0x1009_6e0c, 1); pushd(esi);                             /* push esi */
            ii(0x1009_6e0d, 1); pushd(edi);                             /* push edi */
            ii(0x1009_6e0e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_6e0f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_6e11, 6); sub(esp, 0x11c);                        /* sub esp, 0x11c */
            ii(0x1009_6e17, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_6e1a, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1009_6e1d, 3); mov(memd_a32[ss, ebp - 0xc], ebx);      /* mov [ebp-0xc], ebx */
            ii(0x1009_6e20, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1009_6e23, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_6e26, 5); calld(Definitions.my_ctor_0x101b_4184, -0x2_033b); /* call 0x10076af0 */
            ii(0x1009_6e2b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_6e2d, 1); pushd(eax);                             /* push eax */
            ii(0x1009_6e2e, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1009_6e30, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_6e32, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_6e34, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1009_6e37, 5); calld(0x1008_b148, -0xbcf4);            /* call 0x1008b148 */
            ii(0x1009_6e3c, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1009_6e40, 5); calld(0x100c_dec2, 0x3_707d);           /* call 0x100cdec2 */
            ii(0x1009_6e45, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_6e47, 2); if(jnzd(0x1009_6e52, 0x9)) goto l_0x1009_6e52; /* jnz 0x10096e52 */
            ii(0x1009_6e49, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_6e4d, 5); jmpd(0x1009_71cf, 0x37d); goto l_0x1009_71cf; /* jmp 0x100971cf */
        l_0x1009_6e52:
            ii(0x1009_6e52, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1009_6e56, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_6e59, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_6e5c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_6e5f, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1009_6e65, 5); mov(ebx, 0x101c_a468);                  /* mov ebx, 0x101ca468 */
            ii(0x1009_6e6a, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1009_6e6c, 5); calld(0x100d_fd2c, 0x4_8ebb);           /* call 0x100dfd2c */
            ii(0x1009_6e71, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_6e73, 5); calld(0x100a_314c, 0xc2d4);             /* call 0x100a314c */
            ii(0x1009_6e78, 4); cmp(ax, memw_a32[ds, edx + 0x8]);       /* cmp ax, [edx+0x8] */
            ii(0x1009_6e7c, 2); if(jged(0x1009_6e87, 0x9)) goto l_0x1009_6e87; /* jge 0x10096e87 */
            ii(0x1009_6e7e, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_6e82, 5); jmpd(0x1009_71cf, 0x348); goto l_0x1009_71cf; /* jmp 0x100971cf */
        l_0x1009_6e87:
            ii(0x1009_6e87, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_6e8a, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_6e8d, 5); calld(0x1009_c6c8, 0x5836);             /* call 0x1009c6c8 */
            ii(0x1009_6e92, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_6e94, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_6e97, 5); calld(0x1009_c5dc, 0x5740);             /* call 0x1009c5dc */
            ii(0x1009_6e9c, 5); mov(ebx, 0xba);                         /* mov ebx, 0xba */
            ii(0x1009_6ea1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_6ea3, 6); lea(eax, ebp - 0xf8);                   /* lea eax, [ebp-0xf8] */
            ii(0x1009_6ea9, 5); calld(Definitions.sys_memset, 0xc_ef32); /* call 0x10165de0 */
            ii(0x1009_6eae, 2); jmpd(0x1009_6eb8, 0x8); goto l_0x1009_6eb8; /* jmp 0x10096eb8 */
        l_0x1009_6eb0:
            ii(0x1009_6eb0, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_6eb3, 5); calld(0x1007_6bf8, -0x2_02c0);          /* call 0x10076bf8 */
        l_0x1009_6eb8:
            ii(0x1009_6eb8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_6eba, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_6ebd, 5); calld(0x1013_ad71, 0xa_3eaf);           /* call 0x1013ad71 */
            ii(0x1009_6ec2, 2); test(al, al);                           /* test al, al */
            ii(0x1009_6ec4, 2); if(jzd(0x1009_6efd, 0x37)) goto l_0x1009_6efd; /* jz 0x10096efd */
            ii(0x1009_6ec6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_6ec9, 5); add(eax, 0xfa);                         /* add eax, 0xfa */
            ii(0x1009_6ece, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_6ed1, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_6ed4, 5); calld(0x1009_c4f8, 0x561f);             /* call 0x1009c4f8 */
            ii(0x1009_6ed9, 5); calld(0x100a_2bc4, 0xbce6);             /* call 0x100a2bc4 */
            ii(0x1009_6ede, 1); cwde();                                 /* cwde */
            ii(0x1009_6edf, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_6ee1, 2); if(jgd(0x1009_6efb, 0x18)) goto l_0x1009_6efb; /* jg 0x10096efb */
            ii(0x1009_6ee3, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_6ee6, 5); calld(0x1009_c4f8, 0x560d);             /* call 0x1009c4f8 */
            ii(0x1009_6eeb, 5); calld(0x1009_c4c4, 0x55d4);             /* call 0x1009c4c4 */
            ii(0x1009_6ef0, 1); cwde();                                 /* cwde */
            ii(0x1009_6ef1, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_6ef3, 8); inc(memw_a32[ds, eax + ebp - 0xf8]);    /* inc word [eax+ebp-0xf8] */
        l_0x1009_6efb:
            ii(0x1009_6efb, 2); jmpd(0x1009_6eb0, -0x4d); goto l_0x1009_6eb0; /* jmp 0x10096eb0 */
        l_0x1009_6efd:
            ii(0x1009_6efd, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1009_6f02, 5); calld(0x1007_6338, -0x2_0bcf);          /* call 0x10076338 */
            ii(0x1009_6f07, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_6f09, 6); lea(eax, ebp - 0xfc);                   /* lea eax, [ebp-0xfc] */
            ii(0x1009_6f0f, 5); calld(0x1007_64b8, -0x2_0a5c);          /* call 0x100764b8 */
            ii(0x1009_6f14, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1009_6f18, 5); calld(0x100c_defa, 0x3_6fdd);           /* call 0x100cdefa */
            ii(0x1009_6f1d, 6); mov(memd_a32[ss, ebp - 0x100], eax);    /* mov [ebp-0x100], eax */
            ii(0x1009_6f23, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x1009_6f2a, 7); mov(memd_a32[ss, ebp - 0x24], 0);       /* mov dword [ebp-0x24], 0x0 */
            ii(0x1009_6f31, 7); movsx(edx, memw_a32[ss, ebp - 0x100]);  /* movsx edx, word [ebp-0x100] */
            ii(0x1009_6f38, 6); lea(eax, ebp - 0x104);                  /* lea eax, [ebp-0x104] */
            ii(0x1009_6f3e, 5); calld(0x100c_df95, 0x3_7052);           /* call 0x100cdf95 */
            ii(0x1009_6f43, 2); jmpd(0x1009_6f50, 0xb); goto l_0x1009_6f50; /* jmp 0x10096f50 */
        l_0x1009_6f45:
            ii(0x1009_6f45, 6); lea(eax, ebp - 0xfc);                   /* lea eax, [ebp-0xfc] */
            ii(0x1009_6f4b, 5); calld(0x1007_6bf8, -0x2_0358);          /* call 0x10076bf8 */
        l_0x1009_6f50:
            ii(0x1009_6f50, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_6f52, 6); lea(eax, ebp - 0xfc);                   /* lea eax, [ebp-0xfc] */
            ii(0x1009_6f58, 5); calld(0x1013_ad71, 0xa_3e14);           /* call 0x1013ad71 */
            ii(0x1009_6f5d, 2); test(al, al);                           /* test al, al */
            ii(0x1009_6f5f, 2); if(jzd(0x1009_6fa0, 0x3f)) goto l_0x1009_6fa0; /* jz 0x10096fa0 */
            ii(0x1009_6f61, 6); lea(eax, ebp - 0xfc);                   /* lea eax, [ebp-0xfc] */
            ii(0x1009_6f67, 5); calld(0x1007_63a0, -0x2_0bcc);          /* call 0x100763a0 */
            ii(0x1009_6f6c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_6f6e, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1009_6f71, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_6f74, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_6f77, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_6f7a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_6f7c, 2); if(jnzd(0x1009_6f96, 0x18)) goto l_0x1009_6f96; /* jnz 0x10096f96 */
            ii(0x1009_6f7e, 6); lea(eax, ebp - 0xfc);                   /* lea eax, [ebp-0xfc] */
            ii(0x1009_6f84, 5); calld(0x1007_63a0, -0x2_0be9);          /* call 0x100763a0 */
            ii(0x1009_6f89, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1009_6f8d, 7); cmp(ax, memw_a32[ss, ebp - 0x100]);     /* cmp ax, [ebp-0x100] */
            ii(0x1009_6f94, 2); if(jzd(0x1009_6f98, 0x2)) goto l_0x1009_6f98; /* jz 0x10096f98 */
        l_0x1009_6f96:
            ii(0x1009_6f96, 2); jmpd(0x1009_6f9e, 0x6); goto l_0x1009_6f9e; /* jmp 0x10096f9e */
        l_0x1009_6f98:
            ii(0x1009_6f98, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_6f9b, 3); inc(memd_a32[ss, ebp - 0x20]);          /* inc dword [ebp-0x20] */
        l_0x1009_6f9e:
            ii(0x1009_6f9e, 2); jmpd(0x1009_6f45, -0x5b); goto l_0x1009_6f45; /* jmp 0x10096f45 */
        l_0x1009_6fa0:
            ii(0x1009_6fa0, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1009_6fa7, 2); jmpd(0x1009_6faf, 0x6); goto l_0x1009_6faf; /* jmp 0x10096faf */
        l_0x1009_6fa9:
            ii(0x1009_6fa9, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_6fac, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
        l_0x1009_6faf:
            ii(0x1009_6faf, 6); lea(eax, ebp - 0x104);                  /* lea eax, [ebp-0x104] */
            ii(0x1009_6fb5, 5); calld(Definitions.my_2_get_count, -0xbc52); /* call 0x1008b368 */
            ii(0x1009_6fba, 4); cmp(ax, memw_a32[ss, ebp - 0x1c]);      /* cmp ax, [ebp-0x1c] */
            ii(0x1009_6fbe, 2); if(jled(0x1009_6fe1, 0x21)) goto l_0x1009_6fe1; /* jle 0x10096fe1 */
            ii(0x1009_6fc0, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1009_6fc4, 6); lea(eax, ebp - 0x104);                  /* lea eax, [ebp-0x104] */
            ii(0x1009_6fca, 5); calld(0x1008_b228, -0xbda7);            /* call 0x1008b228 */
            ii(0x1009_6fcf, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1009_6fd2, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_6fd4, 8); mov(ax, memw_a32[ds, eax + ebp - 0xf8]); /* mov ax, [eax+ebp-0xf8] */
            ii(0x1009_6fdc, 3); add(memd_a32[ss, ebp - 0x24], eax);     /* add [ebp-0x24], eax */
            ii(0x1009_6fdf, 2); jmpd(0x1009_6fa9, -0x38); goto l_0x1009_6fa9; /* jmp 0x10096fa9 */
        l_0x1009_6fe1:
            ii(0x1009_6fe1, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1009_6fe5, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_6fe7, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1009_6feb, 1); inc(eax);                               /* inc eax */
            ii(0x1009_6fec, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1009_6fee, 2); if(jgd(0x1009_701d, 0x2d)) goto l_0x1009_701d; /* jg 0x1009701d */
            ii(0x1009_6ff0, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_6ff4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_6ff6, 6); lea(eax, ebp - 0x104);                  /* lea eax, [ebp-0x104] */
            ii(0x1009_6ffc, 5); calld(0x1008_8b04, -0xe4fd);            /* call 0x10088b04 */
            ii(0x1009_7001, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_7003, 6); lea(eax, ebp - 0xfc);                   /* lea eax, [ebp-0xfc] */
            ii(0x1009_7009, 5); calld(0x1007_5f6c, -0x2_10a2);          /* call 0x10075f6c */
            ii(0x1009_700e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_7010, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_7013, 5); calld(0x1009_ba6c, 0x4a54);             /* call 0x1009ba6c */
            ii(0x1009_7018, 5); jmpd(0x1009_71cf, 0x1b2); goto l_0x1009_71cf; /* jmp 0x100971cf */
        l_0x1009_701d:
            ii(0x1009_701d, 5); cmp(memw_a32[ss, ebp - 0x8], 0x5);      /* cmp word [ebp-0x8], 0x5 */
            ii(0x1009_7022, 2); if(jnzd(0x1009_7036, 0x12)) goto l_0x1009_7036; /* jnz 0x10097036 */
            ii(0x1009_7024, 3); lea(ebx, ebp - 0x28);                   /* lea ebx, [ebp-0x28] */
            ii(0x1009_7027, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_7029, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_702c, 5); calld(0x1009_6a12, -0x61f);             /* call 0x10096a12 */
            ii(0x1009_7031, 3); mov(memb_a32[ss, ebp - 0x18], al);      /* mov [ebp-0x18], al */
            ii(0x1009_7034, 2); jmpd(0x1009_7090, 0x5a); goto l_0x1009_7090; /* jmp 0x10097090 */
        l_0x1009_7036:
            ii(0x1009_7036, 5); cmp(memw_a32[ss, ebp - 0x8], 0x22);     /* cmp word [ebp-0x8], 0x22 */
            ii(0x1009_703b, 2); if(jzd(0x1009_7044, 0x7)) goto l_0x1009_7044; /* jz 0x10097044 */
            ii(0x1009_703d, 5); cmp(memw_a32[ss, ebp - 0x8], 0x25);     /* cmp word [ebp-0x8], 0x25 */
            ii(0x1009_7042, 2); if(jnzd(0x1009_7046, 0x2)) goto l_0x1009_7046; /* jnz 0x10097046 */
        l_0x1009_7044:
            ii(0x1009_7044, 2); jmpd(0x1009_704d, 0x7); goto l_0x1009_704d; /* jmp 0x1009704d */
        l_0x1009_7046:
            ii(0x1009_7046, 5); cmp(memw_a32[ss, ebp - 0x8], 0x24);     /* cmp word [ebp-0x8], 0x24 */
            ii(0x1009_704b, 2); if(jnzd(0x1009_704f, 0x2)) goto l_0x1009_704f; /* jnz 0x1009704f */
        l_0x1009_704d:
            ii(0x1009_704d, 2); jmpd(0x1009_7056, 0x7); goto l_0x1009_7056; /* jmp 0x10097056 */
        l_0x1009_704f:
            ii(0x1009_704f, 5); cmp(memw_a32[ss, ebp - 0x8], 0x23);     /* cmp word [ebp-0x8], 0x23 */
            ii(0x1009_7054, 2); if(jnzd(0x1009_7077, 0x21)) goto l_0x1009_7077; /* jnz 0x10097077 */
        l_0x1009_7056:
            ii(0x1009_7056, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1009_705a, 1); pushd(eax);                             /* push eax */
            ii(0x1009_705b, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1009_7060, 1); pushd(eax);                             /* push eax */
            ii(0x1009_7061, 3); lea(ecx, ebp - 0x28);                   /* lea ecx, [ebp-0x28] */
            ii(0x1009_7064, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_7066, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1009_706a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_706d, 5); calld(0x1009_5f0a, -0x1168);            /* call 0x10095f0a */
            ii(0x1009_7072, 3); mov(memb_a32[ss, ebp - 0x18], al);      /* mov [ebp-0x18], al */
            ii(0x1009_7075, 2); jmpd(0x1009_7090, 0x19); goto l_0x1009_7090; /* jmp 0x10097090 */
        l_0x1009_7077:
            ii(0x1009_7077, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1009_707b, 1); pushd(eax);                             /* push eax */
            ii(0x1009_707c, 3); lea(ecx, ebp - 0x28);                   /* lea ecx, [ebp-0x28] */
            ii(0x1009_707f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_7081, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1009_7085, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_7088, 5); calld(0x1009_2e25, -0x4268);            /* call 0x10092e25 */
            ii(0x1009_708d, 3); mov(memb_a32[ss, ebp - 0x18], al);      /* mov [ebp-0x18], al */
        l_0x1009_7090:
            ii(0x1009_7090, 4); cmp(memb_a32[ss, ebp - 0x18], 0);       /* cmp byte [ebp-0x18], 0x0 */
            ii(0x1009_7094, 6); if(jzd(0x1009_7181, 0xe7)) goto l_0x1009_7181; /* jz 0x10097181 */
            ii(0x1009_709a, 5); mov(eax, 0x35);                         /* mov eax, 0x35 */
            ii(0x1009_709f, 5); calld(Definitions.sys_new, 0xc_ed5c);   /* call 0x10165e00 */
            ii(0x1009_70a4, 6); mov(memd_a32[ss, ebp - 0x108], eax);    /* mov [ebp-0x108], eax */
            ii(0x1009_70aa, 6); mov(eax, memd_a32[ss, ebp - 0x108]);    /* mov eax, [ebp-0x108] */
            ii(0x1009_70b0, 6); mov(memd_a32[ss, ebp - 0x10c], eax);    /* mov [ebp-0x10c], eax */
            ii(0x1009_70b6, 7); cmp(memd_a32[ss, ebp - 0x10c], 0);      /* cmp dword [ebp-0x10c], 0x0 */
            ii(0x1009_70bd, 2); if(jzd(0x1009_70fc, 0x3d)) goto l_0x1009_70fc; /* jz 0x100970fc */
            ii(0x1009_70bf, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_70c2, 1); pushd(eax);                             /* push eax */
            ii(0x1009_70c3, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x1009_70c6, 6); lea(eax, ebp - 0x110);                  /* lea eax, [ebp-0x110] */
            ii(0x1009_70cc, 5); calld(0x1007_5e64, -0x2_126d);          /* call 0x10075e64 */
            ii(0x1009_70d1, 1); pushd(eax);                             /* push eax */
            ii(0x1009_70d2, 4); movsx(ecx, memw_a32[ss, ebp - 0x8]);    /* movsx ecx, word [ebp-0x8] */
            ii(0x1009_70d6, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1009_70da, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_70dd, 6); mov(eax, memd_a32[ss, ebp - 0x108]);    /* mov eax, [ebp-0x108] */
            ii(0x1009_70e3, 5); calld(0x1008_c999, -0xa74f);            /* call 0x1008c999 */
            ii(0x1009_70e8, 6); mov(memd_a32[ss, ebp - 0x114], eax);    /* mov [ebp-0x114], eax */
            ii(0x1009_70ee, 6); mov(eax, memd_a32[ss, ebp - 0x114]);    /* mov eax, [ebp-0x114] */
            ii(0x1009_70f4, 6); mov(memd_a32[ss, ebp - 0x118], eax);    /* mov [ebp-0x118], eax */
            ii(0x1009_70fa, 2); jmpd(0x1009_7108, 0xc); goto l_0x1009_7108; /* jmp 0x10097108 */
        l_0x1009_70fc:
            ii(0x1009_70fc, 6); mov(eax, memd_a32[ss, ebp - 0x10c]);    /* mov eax, [ebp-0x10c] */
            ii(0x1009_7102, 6); mov(memd_a32[ss, ebp - 0x118], eax);    /* mov [ebp-0x118], eax */
        l_0x1009_7108:
            ii(0x1009_7108, 6); mov(edx, memd_a32[ss, ebp - 0x118]);    /* mov edx, [ebp-0x118] */
            ii(0x1009_710e, 6); lea(eax, ebp - 0x11c);                  /* lea eax, [ebp-0x11c] */
            ii(0x1009_7114, 5); calld(0x1009_c7e0, 0x56c7);             /* call 0x1009c7e0 */
            ii(0x1009_7119, 6); lea(eax, ebp - 0x11c);                  /* lea eax, [ebp-0x11c] */
            ii(0x1009_711f, 5); calld(0x1009_c73c, 0x5618);             /* call 0x1009c73c */
            ii(0x1009_7124, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1009_7127, 3); add(ebx, 0x21);                         /* add ebx, 0x21 */
            ii(0x1009_712a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_712c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_712e, 5); calld(0x1009_c698, 0x5565);             /* call 0x1009c698 */
            ii(0x1009_7133, 6); lea(eax, ebp - 0x11c);                  /* lea eax, [ebp-0x11c] */
            ii(0x1009_7139, 5); calld(0x1009_c73c, 0x55fe);             /* call 0x1009c73c */
            ii(0x1009_713e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_7140, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_7145, 5); calld(0x100a_4d50, 0xdc06);             /* call 0x100a4d50 */
            ii(0x1009_714a, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x1009_714e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_7150, 6); lea(eax, ebp - 0x11c);                  /* lea eax, [ebp-0x11c] */
            ii(0x1009_7156, 5); calld(0x1009_b9ec, 0x4891);             /* call 0x1009b9ec */
            ii(0x1009_715b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_715d, 6); lea(eax, ebp - 0x104);                  /* lea eax, [ebp-0x104] */
            ii(0x1009_7163, 5); calld(0x1008_8b04, -0xe664);            /* call 0x10088b04 */
            ii(0x1009_7168, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_716a, 6); lea(eax, ebp - 0xfc);                   /* lea eax, [ebp-0xfc] */
            ii(0x1009_7170, 5); calld(0x1007_5f6c, -0x2_1209);          /* call 0x10075f6c */
            ii(0x1009_7175, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_7177, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_717a, 5); calld(0x1009_ba6c, 0x48ed);             /* call 0x1009ba6c */
            ii(0x1009_717f, 2); jmpd(0x1009_71cf, 0x4e); goto l_0x1009_71cf; /* jmp 0x100971cf */
        l_0x1009_7181:
            ii(0x1009_7181, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_7185, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_7187, 6); lea(eax, ebp - 0x104);                  /* lea eax, [ebp-0x104] */
            ii(0x1009_718d, 5); calld(0x1008_8b04, -0xe68e);            /* call 0x10088b04 */
            ii(0x1009_7192, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_7194, 6); lea(eax, ebp - 0xfc);                   /* lea eax, [ebp-0xfc] */
            ii(0x1009_719a, 5); calld(0x1007_5f6c, -0x2_1233);          /* call 0x10075f6c */
            ii(0x1009_719f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_71a1, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_71a4, 5); calld(0x1009_ba6c, 0x48c3);             /* call 0x1009ba6c */
            ii(0x1009_71a9, 2); jmpd(0x1009_71cf, 0x24); goto l_0x1009_71cf; /* jmp 0x100971cf */
        //    ii(0x1009_71ab, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1009_71ad, 6); lea(eax, ebp - 0x104);                  /* lea eax, [ebp-0x104] */
        //    ii(0x1009_71b3, 5); calld(0x1008_8b04, -0xe6b4);            /* call 0x10088b04 */
        //    ii(0x1009_71b8, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1009_71ba, 6); lea(eax, ebp - 0xfc);                   /* lea eax, [ebp-0xfc] */
        //    ii(0x1009_71c0, 5); calld(0x1007_5f6c, -0x2_1259);          /* call 0x10075f6c */
        //    ii(0x1009_71c5, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1009_71c7, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
        //    ii(0x1009_71ca, 5); calld(0x1009_ba6c, 0x489d);             /* call 0x1009ba6c */
        l_0x1009_71cf:
            ii(0x1009_71cf, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1009_71d2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_71d4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_71d5, 1); popd(edi);                              /* pop edi */
            ii(0x1009_71d6, 1); popd(esi);                              /* pop esi */
            ii(0x1009_71d7, 1); retd(); return;                         /* ret */
        }
    }
}
