FUNC_BEGIN(0x1013dcdf, 0xacdd6faaec21ef6a, 0x20, ({0x68, 0x44, 0, 0, 0, 0xe8, 0x69, 0x80, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x28, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x15, 0xdc, 0x38, 0x1c, 0x10, 0xc1, 0xfa, 0x10, 0xa1, 0xd8, 0x38, 0x1c, 0x10, 0xc1, 0xf8, 0x10, 0x1, 0xd0, 0xd1, 0xf8, 0x89, 0x45, 0xf8, 0x8b, 0x15, 0xde, 0x38, 0x1c, 0x10, 0xc1, 0xfa, 0x10, 0xa1, 0xda, 0x38, 0x1c, 0x10, 0xc1, 0xf8, 0x10, 0x1, 0xd0, 0xd1, 0xf8, 0x89, 0x45, 0xf4, 0xc7, 0x45, 0xf0, 0x14, 0, 0, 0, 0xff, 0x4d, 0xf0, 0x66, 0x83, 0x7d, 0xf0, 0xff, 0xf, 0x84, 0xfc, 0, 0, 0, 0xf, 0xbf, 0x45, 0xf0, 0x69, 0xc0, 0x91, 0, 0, 0, 0x8b, 0x55, 0xfc, 0x81, 0xc2, 0x51, 0x2, 0, 0, 0x1, 0xc2, 0x89, 0x55, 0xec, 0x8b, 0x45, 0xec, 0x81, 0x38, 0xff, 0xff, 0, 0, 0x74, 0x9, 0x8b, 0x45, 0xec, 0x80, 0x78, 0x6, 0x1, 0x7e, 0x5, 0xe9, 0xc6, 0, 0, 0, 0x8b, 0x45, 0xec, 0x66, 0x8b, 0x40, 0x7, 0x2b, 0x45, 0xf8, 0x89, 0x45, 0xe0, 0xf, 0xbf, 0x45, 0xe0, 0xe8, 0x72, 0x80, 0x2, 0, 0x89, 0x45, 0xe4, 0x8b, 0x45, 0xec, 0x8b, 0x40, 0x7, 0xc1, 0xf8, 0x10, 0xf, 0xbf, 0x55, 0xf4, 0x29, 0xd0, 0xe8, 0x5b, 0x80, 0x2, 0, 0x89, 0x45, 0xdc, 0xf, 0xbf, 0x45, 0xe0, 0x85, 0xc0, 0x7d, 0x6, 0xc6, 0x45, 0xe8, 0x1, 0xeb, 0x4, 0xc6, 0x45, 0xe8, 0, 0x31, 0xd2, 0x8a, 0x55, 0xe8, 0xf, 0xbf, 0x45, 0xe4, 0xe8, 0x9e, 0xf6, 0xff, 0xff, 0x89, 0xc3, 0x8b, 0x45, 0xec, 0x8b, 0x10, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x1c, 0xe8, 0x78, 0x2c, 0x4, 0, 0xf, 0xbf, 0x55, 0xdc, 0xf, 0xbf, 0x45, 0xe4, 0xe8, 0x9d, 0x90, 0xf3, 0xff, 0x8b, 0x55, 0xec, 0xf, 0xaf, 0x82, 0x83, 0, 0, 0, 0xbb, 0x70, 0, 0, 0, 0x31, 0xd2, 0xf7, 0xf3, 0x8b, 0x55, 0xec, 0x8b, 0x92, 0x83, 0, 0, 0, 0x29, 0xc2, 0x89, 0x55, 0xd8, 0xb8, 0x37, 0, 0, 0, 0xe8, 0xd2, 0x81, 0xf3, 0xff, 0x8b, 0x55, 0xd8, 0xf, 0xaf, 0xd0, 0xbb, 0x64, 0, 0, 0, 0x89, 0xd0, 0xc1, 0xfa, 0x1f, 0xf7, 0xfb, 0x89, 0x45, 0xd8, 0x8b, 0x5d, 0xd8, 0x8b, 0x55, 0xec, 0x8b, 0x2, 0x8b, 0x55, 0xfc, 0x8b, 0x4a, 0x1c, 0x89, 0xc2, 0x89, 0xc8, 0xe8, 0x71, 0x29, 0x4, 0, 0xe9, 0xf6, 0xfe, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1013dcdf, 0x5)   pushd(0x44);                          /* push dword 0x44 */
    II(0x1013dce4, 0x5)   calld(sys_check_available_stack_size, 0x28069); /* call 0x10165d52 */
    II(0x1013dce9, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013dcea, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013dceb, 0x1)   pushd(edx);                           /* push edx */
    II(0x1013dcec, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013dced, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013dcee, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013dcef, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013dcf1, 0x6)   sub(esp, 0x28);                       /* sub esp, 0x28 */
    II(0x1013dcf7, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1013dcfa, 0x6)   mov(edx, memd_a32(ds, 0x101c38dc));   /* mov edx, [0x101c38dc] */
    II(0x1013dd00, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x1013dd03, 0x5)   mov(eax, memd_a32(ds, 0x101c38d8));   /* mov eax, [0x101c38d8] */
    II(0x1013dd08, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1013dd0b, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x1013dd0d, 0x2)   sar(eax, 0x1);                        /* sar eax, 1 */
    II(0x1013dd0f, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1013dd12, 0x6)   mov(edx, memd_a32(ds, 0x101c38de));   /* mov edx, [0x101c38de] */
    II(0x1013dd18, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x1013dd1b, 0x5)   mov(eax, memd_a32(ds, 0x101c38da));   /* mov eax, [0x101c38da] */
    II(0x1013dd20, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1013dd23, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x1013dd25, 0x2)   sar(eax, 0x1);                        /* sar eax, 1 */
    II(0x1013dd27, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x1013dd2a, 0x7)   mov(memd_a32(ss, ebp - 0x10), 0x14);  /* mov dword [ebp-0x10], 0x14 */
l_0x1013dd31:
    II(0x1013dd31, 0x3)   dec(memd_a32(ss, ebp - 0x10));        /* dec dword [ebp-0x10] */
    II(0x1013dd34, 0x5)   cmp(memw_a32(ss, ebp - 0x10), -0x1 /* 0xff */); /* cmp word [ebp-0x10], 0xff */
    II(0x1013dd39, 0x6)   jzd(0x1013de3b, 0xfc);                /* jz dword 0x1013de3b */
    II(0x1013dd3f, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x10)); /* movsx eax, word [ebp-0x10] */
    II(0x1013dd43, 0x6)   imul(eax, eax, 0x91);                 /* imul eax, eax, 0x91 */
    II(0x1013dd49, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x1013dd4c, 0x6)   add(edx, 0x251);                      /* add edx, 0x251 */
    II(0x1013dd52, 0x2)   add(edx, eax);                        /* add edx, eax */
    II(0x1013dd54, 0x3)   mov(memd_a32(ss, ebp - 0x14), edx);   /* mov [ebp-0x14], edx */
    II(0x1013dd57, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x1013dd5a, 0x6)   cmp(memd_a32(ds, eax), 0xffff);       /* cmp dword [eax], 0xffff */
    II(0x1013dd60, 0x2)   jzd(0x1013dd6b, 0x9);                 /* jz 0x1013dd6b */
    II(0x1013dd62, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x1013dd65, 0x4)   cmp(memb_a32(ds, eax + 0x6), 0x1);    /* cmp byte [eax+0x6], 0x1 */
    II(0x1013dd69, 0x2)   jled(0x1013dd70, 0x5);                /* jle 0x1013dd70 */
l_0x1013dd6b:
    II(0x1013dd6b, 0x5)   jmpd(0x1013de36, 0xc6);               /* jmp 0x1013de36 */
l_0x1013dd70:
    II(0x1013dd70, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x1013dd73, 0x4)   mov(ax, memw_a32(ds, eax + 0x7));     /* mov ax, [eax+0x7] */
    II(0x1013dd77, 0x3)   sub(eax, memd_a32(ss, ebp - 0x8));    /* sub eax, [ebp-0x8] */
    II(0x1013dd7a, 0x3)   mov(memd_a32(ss, ebp - 0x20), eax);   /* mov [ebp-0x20], eax */
    II(0x1013dd7d, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x20)); /* movsx eax, word [ebp-0x20] */
    II(0x1013dd81, 0x5)   calld(/* sys */ 0x10165df8, 0x28072); /* call 0x10165df8 */
    II(0x1013dd86, 0x3)   mov(memd_a32(ss, ebp - 0x1c), eax);   /* mov [ebp-0x1c], eax */
    II(0x1013dd89, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x1013dd8c, 0x3)   mov(eax, memd_a32(ds, eax + 0x7));    /* mov eax, [eax+0x7] */
    II(0x1013dd8f, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1013dd92, 0x4)   movsx(edx, memw_a32(ss, ebp - 0xc));  /* movsx edx, word [ebp-0xc] */
    II(0x1013dd96, 0x2)   sub(eax, edx);                        /* sub eax, edx */
    II(0x1013dd98, 0x5)   calld(/* sys */ 0x10165df8, 0x2805b); /* call 0x10165df8 */
    II(0x1013dd9d, 0x3)   mov(memd_a32(ss, ebp - 0x24), eax);   /* mov [ebp-0x24], eax */
    II(0x1013dda0, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x20)); /* movsx eax, word [ebp-0x20] */
    II(0x1013dda4, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1013dda6, 0x2)   jged(0x1013ddae, 0x6);                /* jge 0x1013ddae */
    II(0x1013dda8, 0x4)   mov(memb_a32(ss, ebp - 0x18), 0x1);   /* mov byte [ebp-0x18], 0x1 */
    II(0x1013ddac, 0x2)   jmpd(0x1013ddb2, 0x4);                /* jmp 0x1013ddb2 */
l_0x1013ddae:
    II(0x1013ddae, 0x4)   mov(memb_a32(ss, ebp - 0x18), 0);     /* mov byte [ebp-0x18], 0x0 */
l_0x1013ddb2:
    II(0x1013ddb2, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1013ddb4, 0x3)   mov(dl, memb_a32(ss, ebp - 0x18));    /* mov dl, [ebp-0x18] */
    II(0x1013ddb7, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x1c)); /* movsx eax, word [ebp-0x1c] */
    II(0x1013ddbb, 0x5)   calld(0x1013d45e, -0x962);            /* call 0x1013d45e */
    II(0x1013ddc0, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x1013ddc2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x1013ddc5, 0x2)   mov(edx, memd_a32(ds, eax));          /* mov edx, [eax] */
    II(0x1013ddc7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013ddca, 0x3)   mov(eax, memd_a32(ds, eax + 0x1c));   /* mov eax, [eax+0x1c] */
    II(0x1013ddcd, 0x5)   calld(/* sys */ 0x10180a4a, 0x42c78); /* call 0x10180a4a */
    II(0x1013ddd2, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x24)); /* movsx edx, word [ebp-0x24] */
    II(0x1013ddd6, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x1c)); /* movsx eax, word [ebp-0x1c] */
    II(0x1013ddda, 0x5)   calld(0x10076e7c, -0xc6f63);          /* call 0x10076e7c */
    II(0x1013dddf, 0x3)   mov(edx, memd_a32(ss, ebp - 0x14));   /* mov edx, [ebp-0x14] */
    II(0x1013dde2, 0x7)   imul(eax, memd_a32(ds, edx + 0x83));  /* imul eax, [edx+0x83] */
    II(0x1013dde9, 0x5)   mov(ebx, 0x70);                       /* mov ebx, 0x70 */
    II(0x1013ddee, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1013ddf0, 0x2)   div(ebx);                             /* div ebx */
    II(0x1013ddf2, 0x3)   mov(edx, memd_a32(ss, ebp - 0x14));   /* mov edx, [ebp-0x14] */
    II(0x1013ddf5, 0x6)   mov(edx, memd_a32(ds, edx + 0x83));   /* mov edx, [edx+0x83] */
    II(0x1013ddfb, 0x2)   sub(edx, eax);                        /* sub edx, eax */
    II(0x1013ddfd, 0x3)   mov(memd_a32(ss, ebp - 0x28), edx);   /* mov [ebp-0x28], edx */
    II(0x1013de00, 0x5)   mov(eax, 0x37);                       /* mov eax, 0x37 */
    II(0x1013de05, 0x5)   calld(0x10075fdc, -0xc7e2e);          /* call 0x10075fdc */
    II(0x1013de0a, 0x3)   mov(edx, memd_a32(ss, ebp - 0x28));   /* mov edx, [ebp-0x28] */
    II(0x1013de0d, 0x3)   imul(edx, eax);                       /* imul edx, eax */
    II(0x1013de10, 0x5)   mov(ebx, 0x64);                       /* mov ebx, 0x64 */
    II(0x1013de15, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x1013de17, 0x3)   sar(edx, 0x1f);                       /* sar edx, 0x1f */
    II(0x1013de1a, 0x2)   idiv(ebx);                            /* idiv ebx */
    II(0x1013de1c, 0x3)   mov(memd_a32(ss, ebp - 0x28), eax);   /* mov [ebp-0x28], eax */
    II(0x1013de1f, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x28));   /* mov ebx, [ebp-0x28] */
    II(0x1013de22, 0x3)   mov(edx, memd_a32(ss, ebp - 0x14));   /* mov edx, [ebp-0x14] */
    II(0x1013de25, 0x2)   mov(eax, memd_a32(ds, edx));          /* mov eax, [edx] */
    II(0x1013de27, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x1013de2a, 0x3)   mov(ecx, memd_a32(ds, edx + 0x1c));   /* mov ecx, [edx+0x1c] */
    II(0x1013de2d, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1013de2f, 0x2)   mov(eax, ecx);                        /* mov eax, ecx */
    II(0x1013de31, 0x5)   calld(/* sys */ 0x101807a7, 0x42971); /* call 0x101807a7 */
l_0x1013de36:
    II(0x1013de36, 0x5)   jmpd(0x1013dd31, -0x10a);             /* jmp 0x1013dd31 */
l_0x1013de3b:
    II(0x1013de3b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013de3d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013de3e, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013de3f, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013de40, 0x1)   popd(edx);                            /* pop edx */
    II(0x1013de41, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013de42, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013de43, 0x1)   retd();                               /* ret */
FUNC_END

