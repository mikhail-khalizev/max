FUNC_BEGIN(0x10127184, 0x31419c2182fad9b3, 0x20, ({0x68, 0x2c, 0, 0, 0, 0xe8, 0xc4, 0xeb, 0x3, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0xc6, 0x5, 0x1c, 0x5c, 0x1c, 0x10, 0x1e, 0x66, 0xc7, 0x5, 0x1f, 0x5c, 0x1c, 0x10, 0x2f, 0x1, 0xe8, 0xea, 0xec, 0x3, 0, 0x69, 0xc0, 0xf7, 0x7c, 0, 0, 0xc1, 0xe8, 0xf, 0x83, 0xc0, 0xa, 0x89, 0x45, 0xf8, 0xc6, 0x45, 0xf0, 0x4, 0xfe, 0x4d, 0xf0, 0x80, 0x7d, 0xf0, 0xff, 0x74, 0x26, 0x31, 0xd2, 0x8a, 0x55, 0xf0, 0x89, 0xd0, 0x1, 0xc0, 0x8b, 0x15, 0xcc, 0x59, 0x1c, 0x10, 0x1, 0xc2, 0x8b, 0x45, 0xf8, 0x66, 0x3b, 0x82, 0xdc, 0x4, 0, 0, 0x75, 0x7, 0xc7, 0x45, 0xf8, 0, 0, 0, 0, 0xeb, 0xd1, 0x66, 0x83, 0x7d, 0xf8, 0, 0x74, 0xb2, 0x8b, 0x45, 0xf8, 0x66, 0xa3, 0x1d, 0x5c, 0x1c, 0x10, 0xc7, 0x45, 0xf4, 0x21, 0x5c, 0x1c, 0x10, 0xa1, 0xcc, 0x59, 0x1c, 0x10, 0x66, 0x8b, 0x50, 0x14, 0x8b, 0x45, 0xf4, 0x66, 0x89, 0x10, 0xc6, 0x45, 0xfc, 0x4, 0xfe, 0x4d, 0xfc, 0x80, 0x7d, 0xfc, 0xff, 0x74, 0x51, 0x31, 0xc0, 0x8a, 0x45, 0xfc, 0x6b, 0xc0, 0x1e, 0x8b, 0x15, 0xcc, 0x59, 0x1c, 0x10, 0x81, 0xc2, 0x38, 0x3, 0, 0, 0x1, 0xc2, 0x31, 0xc0, 0x8a, 0x45, 0xfc, 0x6b, 0xc0, 0x1e, 0x8b, 0x5d, 0xf4, 0x83, 0xc3, 0x2, 0x1, 0xd8, 0xe8, 0x7e, 0xec, 0x3, 0, 0x31, 0xc0, 0x8a, 0x45, 0xfc, 0x1, 0xc0, 0x8b, 0x15, 0xcc, 0x59, 0x1c, 0x10, 0x1, 0xd0, 0x31, 0xd2, 0x8a, 0x55, 0xfc, 0x1, 0xd2, 0x3, 0x55, 0xf4, 0x66, 0x8b, 0x80, 0xdc, 0x4, 0, 0, 0x66, 0x89, 0x42, 0x7a, 0xeb, 0xa6, 0xbb, 0xad, 0, 0, 0, 0x8b, 0x15, 0xcc, 0x59, 0x1c, 0x10, 0x81, 0xc2, 0xf0, 0x4, 0, 0, 0x8b, 0x45, 0xf4, 0x5, 0x82, 0, 0, 0, 0xe8, 0xb6, 0xeb, 0x3, 0, 0x31, 0xc0, 0xe8, 0x4d, 0xe9, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10127184, 0x5)   pushd(0x2c);                          /* push dword 0x2c */
    II(0x10127189, 0x5)   calld(sys_check_available_stack_size, 0x3ebc4); /* call 0x10165d52 */
    II(0x1012718e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1012718f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10127190, 0x1)   pushd(edx);                           /* push edx */
    II(0x10127191, 0x1)   pushd(esi);                           /* push esi */
    II(0x10127192, 0x1)   pushd(edi);                           /* push edi */
    II(0x10127193, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10127194, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10127196, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x1012719c, 0x7)   mov(memb_a32(ds, 0x101c5c1c), 0x1e);  /* mov byte [0x101c5c1c], 0x1e */
    II(0x101271a3, 0x9)   mov(memw_a32(ds, 0x101c5c1f), 0x12f); /* mov word [0x101c5c1f], 0x12f */
l_0x101271ac:
    II(0x101271ac, 0x5)   calld(/* sys */ 0x10165e9b, 0x3ecea); /* call 0x10165e9b */
    II(0x101271b1, 0x6)   imul(eax, eax, 0x7cf7);               /* imul eax, eax, 0x7cf7 */
    II(0x101271b7, 0x3)   shr(eax, 0xf);                        /* shr eax, 0xf */
    II(0x101271ba, 0x3)   add(eax, 0xa);                        /* add eax, 0xa */
    II(0x101271bd, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x101271c0, 0x4)   mov(memb_a32(ss, ebp - 0x10), 0x4);   /* mov byte [ebp-0x10], 0x4 */
l_0x101271c4:
    II(0x101271c4, 0x3)   dec(memb_a32(ss, ebp - 0x10));        /* dec byte [ebp-0x10] */
    II(0x101271c7, 0x4)   cmp(memb_a32(ss, ebp - 0x10), -0x1 /* 0xff */); /* cmp byte [ebp-0x10], 0xff */
    II(0x101271cb, 0x2)   jzd(0x101271f3, 0x26);                /* jz 0x101271f3 */
    II(0x101271cd, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x101271cf, 0x3)   mov(dl, memb_a32(ss, ebp - 0x10));    /* mov dl, [ebp-0x10] */
    II(0x101271d2, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x101271d4, 0x2)   add(eax, eax);                        /* add eax, eax */
    II(0x101271d6, 0x6)   mov(edx, memd_a32(ds, 0x101c59cc));   /* mov edx, [0x101c59cc] */
    II(0x101271dc, 0x2)   add(edx, eax);                        /* add edx, eax */
    II(0x101271de, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101271e1, 0x7)   cmp(ax, memw_a32(ds, edx + 0x4dc));   /* cmp ax, [edx+0x4dc] */
    II(0x101271e8, 0x2)   jnzd(0x101271f1, 0x7);                /* jnz 0x101271f1 */
    II(0x101271ea, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0);      /* mov dword [ebp-0x8], 0x0 */
l_0x101271f1:
    II(0x101271f1, 0x2)   jmpd(0x101271c4, -0x2f);              /* jmp 0x101271c4 */
l_0x101271f3:
    II(0x101271f3, 0x5)   cmp(memw_a32(ss, ebp - 0x8), 0);      /* cmp word [ebp-0x8], 0x0 */
    II(0x101271f8, 0x2)   jzd(0x101271ac, -0x4e);               /* jz 0x101271ac */
    II(0x101271fa, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101271fd, 0x6)   mov(memw_a32(ds, 0x101c5c1d), ax);    /* mov [0x101c5c1d], ax */
    II(0x10127203, 0x7)   mov(memd_a32(ss, ebp - 0xc), 0x101c5c21); /* mov dword [ebp-0xc], 0x101c5c21 */
    II(0x1012720a, 0x5)   mov(eax, memd_a32(ds, 0x101c59cc));   /* mov eax, [0x101c59cc] */
    II(0x1012720f, 0x4)   mov(dx, memw_a32(ds, eax + 0x14));    /* mov dx, [eax+0x14] */
    II(0x10127213, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10127216, 0x3)   mov(memw_a32(ds, eax), dx);           /* mov [eax], dx */
    II(0x10127219, 0x4)   mov(memb_a32(ss, ebp - 0x4), 0x4);    /* mov byte [ebp-0x4], 0x4 */
l_0x1012721d:
    II(0x1012721d, 0x3)   dec(memb_a32(ss, ebp - 0x4));         /* dec byte [ebp-0x4] */
    II(0x10127220, 0x4)   cmp(memb_a32(ss, ebp - 0x4), -0x1 /* 0xff */); /* cmp byte [ebp-0x4], 0xff */
    II(0x10127224, 0x2)   jzd(0x10127277, 0x51);                /* jz 0x10127277 */
    II(0x10127226, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10127228, 0x3)   mov(al, memb_a32(ss, ebp - 0x4));     /* mov al, [ebp-0x4] */
    II(0x1012722b, 0x3)   imul(eax, eax, 0x1e);                 /* imul eax, eax, 0x1e */
    II(0x1012722e, 0x6)   mov(edx, memd_a32(ds, 0x101c59cc));   /* mov edx, [0x101c59cc] */
    II(0x10127234, 0x6)   add(edx, 0x338);                      /* add edx, 0x338 */
    II(0x1012723a, 0x2)   add(edx, eax);                        /* add edx, eax */
    II(0x1012723c, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1012723e, 0x3)   mov(al, memb_a32(ss, ebp - 0x4));     /* mov al, [ebp-0x4] */
    II(0x10127241, 0x3)   imul(eax, eax, 0x1e);                 /* imul eax, eax, 0x1e */
    II(0x10127244, 0x3)   mov(ebx, memd_a32(ss, ebp - 0xc));    /* mov ebx, [ebp-0xc] */
    II(0x10127247, 0x3)   add(ebx, 0x2);                        /* add ebx, 0x2 */
    II(0x1012724a, 0x2)   add(eax, ebx);                        /* add eax, ebx */
    II(0x1012724c, 0x5)   calld(sys_strcpy, 0x3ec7e);           /* call 0x10165ecf */
    II(0x10127251, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10127253, 0x3)   mov(al, memb_a32(ss, ebp - 0x4));     /* mov al, [ebp-0x4] */
    II(0x10127256, 0x2)   add(eax, eax);                        /* add eax, eax */
    II(0x10127258, 0x6)   mov(edx, memd_a32(ds, 0x101c59cc));   /* mov edx, [0x101c59cc] */
    II(0x1012725e, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x10127260, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10127262, 0x3)   mov(dl, memb_a32(ss, ebp - 0x4));     /* mov dl, [ebp-0x4] */
    II(0x10127265, 0x2)   add(edx, edx);                        /* add edx, edx */
    II(0x10127267, 0x3)   add(edx, memd_a32(ss, ebp - 0xc));    /* add edx, [ebp-0xc] */
    II(0x1012726a, 0x7)   mov(ax, memw_a32(ds, eax + 0x4dc));   /* mov ax, [eax+0x4dc] */
    II(0x10127271, 0x4)   mov(memw_a32(ds, edx + 0x7a), ax);    /* mov [edx+0x7a], ax */
    II(0x10127275, 0x2)   jmpd(0x1012721d, -0x5a);              /* jmp 0x1012721d */
l_0x10127277:
    II(0x10127277, 0x5)   mov(ebx, 0xad);                       /* mov ebx, 0xad */
    II(0x1012727c, 0x6)   mov(edx, memd_a32(ds, 0x101c59cc));   /* mov edx, [0x101c59cc] */
    II(0x10127282, 0x6)   add(edx, 0x4f0);                      /* add edx, 0x4f0 */
    II(0x10127288, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1012728b, 0x5)   add(eax, 0x82);                       /* add eax, 0x82 */
    II(0x10127290, 0x5)   calld(sys_memcpy, 0x3ebb6);           /* call 0x10165e4b */
    II(0x10127295, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10127297, 0x5)   calld(0x10125be9, -0x16b3);           /* call 0x10125be9 */
    II(0x1012729c, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1012729e, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1012729f, 0x1)   popd(edi);                            /* pop edi */
    II(0x101272a0, 0x1)   popd(esi);                            /* pop esi */
    II(0x101272a1, 0x1)   popd(edx);                            /* pop edx */
    II(0x101272a2, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101272a3, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101272a4, 0x1)   retd();                               /* ret */
FUNC_END

