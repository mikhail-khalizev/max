FUNC_BEGIN(0x1011b320, 0xd7da54c435c910c8, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x28, 0xaa, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x8b, 0x58, 0x6, 0xc1, 0xfb, 0x10, 0xba, 0x7b, 0x7d, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0xa2, 0xc1, 0x2, 0, 0x8b, 0x45, 0xf8, 0x8b, 0x58, 0x8, 0xc1, 0xfb, 0x10, 0xba, 0x81, 0x7d, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x8c, 0xc1, 0x2, 0, 0x8b, 0x45, 0xf8, 0x8b, 0x58, 0x14, 0xc1, 0xfb, 0x10, 0xba, 0x87, 0x7d, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x76, 0xc1, 0x2, 0, 0xc7, 0x45, 0xf4, 0, 0, 0, 0, 0xeb, 0x6, 0x8b, 0x45, 0xf4, 0xff, 0x45, 0xf4, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x18, 0xe8, 0x23, 0xcf, 0xf9, 0xff, 0x66, 0x3b, 0x45, 0xf4, 0x7e, 0x56, 0xba, 0x8d, 0x7d, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x32, 0xc0, 0x2, 0, 0xf, 0xbf, 0x55, 0xf4, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x18, 0xe8, 0xc1, 0xce, 0xf9, 0xff, 0xf, 0xbe, 0x18, 0xba, 0x92, 0x7d, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x2a, 0xc1, 0x2, 0, 0xf, 0xbf, 0x55, 0xf4, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x18, 0xe8, 0xa2, 0xce, 0xf9, 0xff, 0xf, 0xbe, 0x58, 0x1, 0xba, 0x94, 0x7d, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0xa, 0xc1, 0x2, 0, 0x8b, 0x45, 0xfc, 0xe8, 0x53, 0xc0, 0x2, 0, 0xeb, 0x93, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1011b320, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1011b325, 0x5)   calld(sys_check_available_stack_size, 0x4aa28); /* call 0x10165d52 */
    II(0x1011b32a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1011b32b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011b32c, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011b32d, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011b32e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011b32f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1011b331, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1011b337, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1011b33a, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x1011b33d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011b340, 0x3)   mov(ebx, memd_a32(ds, eax + 0x6));    /* mov ebx, [eax+0x6] */
    II(0x1011b343, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x1011b346, 0x5)   mov(edx, 0x101a7d7b);                 /* mov edx, 0x101a7d7b */ /* "x_end" */
    II(0x1011b34b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1011b34e, 0x5)   calld(0x101474f5, 0x2c1a2);           /* call 0x101474f5 */
    II(0x1011b353, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011b356, 0x3)   mov(ebx, memd_a32(ds, eax + 0x8));    /* mov ebx, [eax+0x8] */
    II(0x1011b359, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x1011b35c, 0x5)   mov(edx, 0x101a7d81);                 /* mov edx, 0x101a7d81 */ /* "y_end" */
    II(0x1011b361, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1011b364, 0x5)   calld(0x101474f5, 0x2c18c);           /* call 0x101474f5 */
    II(0x1011b369, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011b36c, 0x3)   mov(ebx, memd_a32(ds, eax + 0x14));   /* mov ebx, [eax+0x14] */
    II(0x1011b36f, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x1011b372, 0x5)   mov(edx, 0x101a7d87);                 /* mov edx, 0x101a7d87 */ /* "index" */
    II(0x1011b377, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1011b37a, 0x5)   calld(0x101474f5, 0x2c176);           /* call 0x101474f5 */
    II(0x1011b37f, 0x7)   mov(memd_a32(ss, ebp - 0xc), 0);      /* mov dword [ebp-0xc], 0x0 */
    II(0x1011b386, 0x2)   jmpd(0x1011b38e, 0x6);                /* jmp 0x1011b38e */
l_0x1011b388:
    II(0x1011b388, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1011b38b, 0x3)   inc(memd_a32(ss, ebp - 0xc));         /* inc dword [ebp-0xc] */
l_0x1011b38e:
    II(0x1011b38e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011b391, 0x3)   add(eax, 0x18);                       /* add eax, 0x18 */
    II(0x1011b394, 0x5)   calld(0x100b82bc, -0x630dd);          /* call 0x100b82bc */
    II(0x1011b399, 0x4)   cmp(ax, memw_a32(ss, ebp - 0xc));     /* cmp ax, [ebp-0xc] */
    II(0x1011b39d, 0x2)   jled(0x1011b3f5, 0x56);               /* jle 0x1011b3f5 */
    II(0x1011b39f, 0x5)   mov(edx, 0x101a7d8d);                 /* mov edx, 0x101a7d8d */ /* "step" */
    II(0x1011b3a4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1011b3a7, 0x5)   calld(0x101473de, 0x2c032);           /* call 0x101473de */
    II(0x1011b3ac, 0x4)   movsx(edx, memw_a32(ss, ebp - 0xc));  /* movsx edx, word [ebp-0xc] */
    II(0x1011b3b0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011b3b3, 0x3)   add(eax, 0x18);                       /* add eax, 0x18 */
    II(0x1011b3b6, 0x5)   calld(0x100b827c, -0x6313f);          /* call 0x100b827c */
    II(0x1011b3bb, 0x3)   movsx(ebx, memb_a32(ds, eax));        /* movsx ebx, byte [eax] */
    II(0x1011b3be, 0x5)   mov(edx, 0x101a7d92);                 /* mov edx, 0x101a7d92 */ /* "x" */
    II(0x1011b3c3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1011b3c6, 0x5)   calld(0x101474f5, 0x2c12a);           /* call 0x101474f5 */
    II(0x1011b3cb, 0x4)   movsx(edx, memw_a32(ss, ebp - 0xc));  /* movsx edx, word [ebp-0xc] */
    II(0x1011b3cf, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011b3d2, 0x3)   add(eax, 0x18);                       /* add eax, 0x18 */
    II(0x1011b3d5, 0x5)   calld(0x100b827c, -0x6315e);          /* call 0x100b827c */
    II(0x1011b3da, 0x4)   movsx(ebx, memb_a32(ds, eax + 0x1));  /* movsx ebx, byte [eax+0x1] */
    II(0x1011b3de, 0x5)   mov(edx, 0x101a7d94);                 /* mov edx, 0x101a7d94 */ /* "y" */
    II(0x1011b3e3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1011b3e6, 0x5)   calld(0x101474f5, 0x2c10a);           /* call 0x101474f5 */
    II(0x1011b3eb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1011b3ee, 0x5)   calld(0x10147446, 0x2c053);           /* call 0x10147446 */
    II(0x1011b3f3, 0x2)   jmpd(0x1011b388, -0x6d);              /* jmp 0x1011b388 */
l_0x1011b3f5:
    II(0x1011b3f5, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1011b3f7, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011b3f8, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011b3f9, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011b3fa, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1011b3fb, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1011b3fc, 0x1)   retd();                               /* ret */
FUNC_END

