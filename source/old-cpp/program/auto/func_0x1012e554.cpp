FUNC_BEGIN(0x1012e554, 0xe1539d52e57fad5a, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xf4, 0x77, 0x3, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x26, 0xe8, 0x5e, 0xcf, 0xf7, 0xff, 0x98, 0x85, 0xc0, 0x74, 0x6e, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x36, 0xe8, 0x85, 0xc7, 0, 0, 0x84, 0xc0, 0x74, 0x13, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x26, 0xe8, 0x3d, 0xcf, 0xf7, 0xff, 0x83, 0xe8, 0x2, 0x89, 0x45, 0xf8, 0xeb, 0x18, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x36, 0xe8, 0x5e, 0x36, 0, 0, 0x89, 0xc2, 0x8b, 0x45, 0xfc, 0xe8, 0x56, 0xfd, 0xff, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x26, 0xe8, 0x12, 0xcf, 0xf7, 0xff, 0x66, 0x3b, 0x45, 0xf8, 0x7e, 0x21, 0x8b, 0x45, 0xf8, 0x40, 0xf, 0xbf, 0xd0, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x26, 0xe8, 0x1a, 0x33, 0, 0, 0xe8, 0x11, 0x34, 0, 0, 0x89, 0xc2, 0x8b, 0x45, 0xfc, 0xe8, 0x8f, 0xfd, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1012e554, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1012e559, 0x5)   calld(sys_check_available_stack_size, 0x377f4); /* call 0x10165d52 */
    II(0x1012e55e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1012e55f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1012e560, 0x1)   pushd(edx);                           /* push edx */
    II(0x1012e561, 0x1)   pushd(esi);                           /* push esi */
    II(0x1012e562, 0x1)   pushd(edi);                           /* push edi */
    II(0x1012e563, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1012e564, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1012e566, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1012e56c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1012e56f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1012e572, 0x3)   add(eax, 0x26);                       /* add eax, 0x26 */
    II(0x1012e575, 0x5)   calld(my_1_get_count, -0x830a2);      /* call 0x100ab4d8 */
    II(0x1012e57a, 0x1)   cwde();                               /* cwde */
    II(0x1012e57b, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1012e57d, 0x2)   jzd(0x1012e5ed, 0x6e);                /* jz 0x1012e5ed */
    II(0x1012e57f, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1012e581, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1012e584, 0x3)   add(eax, 0x36);                       /* add eax, 0x36 */
    II(0x1012e587, 0x5)   calld(0x1013ad11, 0xc785);            /* call 0x1013ad11 */
    II(0x1012e58c, 0x2)   test(al, al);                         /* test al, al */
    II(0x1012e58e, 0x2)   jzd(0x1012e5a3, 0x13);                /* jz 0x1012e5a3 */
    II(0x1012e590, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1012e593, 0x3)   add(eax, 0x26);                       /* add eax, 0x26 */
    II(0x1012e596, 0x5)   calld(my_1_get_count, -0x830c3);      /* call 0x100ab4d8 */
    II(0x1012e59b, 0x3)   sub(eax, 0x2);                        /* sub eax, 0x2 */
    II(0x1012e59e, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1012e5a1, 0x2)   jmpd(0x1012e5bb, 0x18);               /* jmp 0x1012e5bb */
l_0x1012e5a3:
    II(0x1012e5a3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1012e5a6, 0x3)   add(eax, 0x36);                       /* add eax, 0x36 */
    II(0x1012e5a9, 0x5)   calld(0x10131c0c, 0x365e);            /* call 0x10131c0c */
    II(0x1012e5ae, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1012e5b0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1012e5b3, 0x5)   calld(0x1012e30e, -0x2aa);            /* call 0x1012e30e */
    II(0x1012e5b8, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
l_0x1012e5bb:
    II(0x1012e5bb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1012e5be, 0x3)   add(eax, 0x26);                       /* add eax, 0x26 */
    II(0x1012e5c1, 0x5)   calld(my_1_get_count, -0x830ee);      /* call 0x100ab4d8 */
    II(0x1012e5c6, 0x4)   cmp(ax, memw_a32(ss, ebp - 0x8));     /* cmp ax, [ebp-0x8] */
    II(0x1012e5ca, 0x2)   jled(0x1012e5ed, 0x21);               /* jle 0x1012e5ed */
    II(0x1012e5cc, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1012e5cf, 0x1)   inc(eax);                             /* inc eax */
    II(0x1012e5d0, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x1012e5d3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1012e5d6, 0x3)   add(eax, 0x26);                       /* add eax, 0x26 */
    II(0x1012e5d9, 0x5)   calld(0x101318f8, 0x331a);            /* call 0x101318f8 */
    II(0x1012e5de, 0x5)   calld(0x101319f4, 0x3411);            /* call 0x101319f4 */
    II(0x1012e5e3, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1012e5e5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1012e5e8, 0x5)   calld(0x1012e37c, -0x271);            /* call 0x1012e37c */
l_0x1012e5ed:
    II(0x1012e5ed, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1012e5ef, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1012e5f0, 0x1)   popd(edi);                            /* pop edi */
    II(0x1012e5f1, 0x1)   popd(esi);                            /* pop esi */
    II(0x1012e5f2, 0x1)   popd(edx);                            /* pop edx */
    II(0x1012e5f3, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1012e5f4, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1012e5f5, 0x1)   retd();                               /* ret */
FUNC_END

