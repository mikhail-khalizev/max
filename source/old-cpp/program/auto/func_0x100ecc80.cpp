FUNC_BEGIN(0x100ecc80, 0x46a20ffd3150160d, 0x20, ({0x68, 0x2c, 0, 0, 0, 0xe8, 0xc8, 0x90, 0x7, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x14, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xf, 0xbf, 0x45, 0xfc, 0xe8, 0x56, 0xf7, 0xff, 0xff, 0x89, 0xc2, 0x8d, 0x45, 0xec, 0xe8, 0x8, 0x98, 0xf8, 0xff, 0xc7, 0x45, 0xf0, 0, 0, 0, 0, 0xeb, 0x8, 0x8d, 0x45, 0xec, 0xe8, 0x37, 0x9f, 0xf8, 0xff, 0x31, 0xd2, 0x8d, 0x45, 0xec, 0xe8, 0xa6, 0xe0, 0x4, 0, 0x84, 0xc0, 0x74, 0x57, 0x8d, 0x45, 0xec, 0xe8, 0xc9, 0x96, 0xf8, 0xff, 0x31, 0xd2, 0x8a, 0x50, 0x26, 0xf, 0xbf, 0x45, 0xf8, 0x39, 0xc2, 0x75, 0x12, 0x8d, 0x45, 0xec, 0xe8, 0xb4, 0x96, 0xf8, 0xff, 0x66, 0x8b, 0x40, 0x8, 0x66, 0x3b, 0x45, 0xfc, 0x74, 0x2, 0xeb, 0x24, 0x8d, 0x45, 0xec, 0xe8, 0xa0, 0x96, 0xf8, 0xff, 0x31, 0xd2, 0x8a, 0x50, 0x54, 0x8d, 0x45, 0xec, 0xe8, 0x93, 0x96, 0xf8, 0xff, 0xe8, 0x2a, 0x95, 0xf8, 0xff, 0x8b, 0x40, 0x19, 0xc1, 0xf8, 0x10, 0x39, 0xc2, 0x75, 0x2, 0xeb, 0x6, 0x8b, 0x45, 0xf0, 0xff, 0x45, 0xf0, 0xeb, 0x93, 0x8a, 0x45, 0xf0, 0x88, 0x45, 0xf4, 0x31, 0xd2, 0x8d, 0x45, 0xec, 0xe8, 0x36, 0x92, 0xf8, 0xff, 0xeb, 0xa, 0x31, 0xd2, 0x8d, 0x45, 0xec, 0xe8, 0x2a, 0x92, 0xf8, 0xff, 0x8a, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100ecc80, 0x5)   pushd(0x2c);                          /* push dword 0x2c */
    II(0x100ecc85, 0x5)   calld(sys_check_available_stack_size, 0x790c8); /* call 0x10165d52 */
    II(0x100ecc8a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100ecc8b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ecc8c, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ecc8d, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ecc8e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ecc8f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ecc91, 0x6)   sub(esp, 0x14);                       /* sub esp, 0x14 */
    II(0x100ecc97, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100ecc9a, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100ecc9d, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100ecca1, 0x5)   calld(0x100ec3fc, -0x8aa);            /* call 0x100ec3fc */
    II(0x100ecca6, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x100ecca8, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x100eccab, 0x5)   calld(0x100764b8, -0x767f8);          /* call 0x100764b8 */
    II(0x100eccb0, 0x7)   mov(memd_a32(ss, ebp - 0x10), 0);     /* mov dword [ebp-0x10], 0x0 */
    II(0x100eccb7, 0x2)   jmpd(0x100eccc1, 0x8);                /* jmp 0x100eccc1 */
l_0x100eccb9:
    II(0x100eccb9, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x100eccbc, 0x5)   calld(0x10076bf8, -0x760c9);          /* call 0x10076bf8 */
l_0x100eccc1:
    II(0x100eccc1, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100eccc3, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x100eccc6, 0x5)   calld(0x1013ad71, 0x4e0a6);           /* call 0x1013ad71 */
    II(0x100ecccb, 0x2)   test(al, al);                         /* test al, al */
    II(0x100ecccd, 0x2)   jzd(0x100ecd26, 0x57);                /* jz 0x100ecd26 */
    II(0x100ecccf, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x100eccd2, 0x5)   calld(0x100763a0, -0x76937);          /* call 0x100763a0 */
    II(0x100eccd7, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100eccd9, 0x3)   mov(dl, memb_a32(ds, eax + 0x26));    /* mov dl, [eax+0x26] */
    II(0x100eccdc, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x100ecce0, 0x2)   cmp(edx, eax);                        /* cmp edx, eax */
    II(0x100ecce2, 0x2)   jnzd(0x100eccf6, 0x12);               /* jnz 0x100eccf6 */
    II(0x100ecce4, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x100ecce7, 0x5)   calld(0x100763a0, -0x7694c);          /* call 0x100763a0 */
    II(0x100eccec, 0x4)   mov(ax, memw_a32(ds, eax + 0x8));     /* mov ax, [eax+0x8] */
    II(0x100eccf0, 0x4)   cmp(ax, memw_a32(ss, ebp - 0x4));     /* cmp ax, [ebp-0x4] */
    II(0x100eccf4, 0x2)   jzd(0x100eccf8, 0x2);                 /* jz 0x100eccf8 */
l_0x100eccf6:
    II(0x100eccf6, 0x2)   jmpd(0x100ecd1c, 0x24);               /* jmp 0x100ecd1c */
l_0x100eccf8:
    II(0x100eccf8, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x100eccfb, 0x5)   calld(0x100763a0, -0x76960);          /* call 0x100763a0 */
    II(0x100ecd00, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100ecd02, 0x3)   mov(dl, memb_a32(ds, eax + 0x54));    /* mov dl, [eax+0x54] */
    II(0x100ecd05, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x100ecd08, 0x5)   calld(0x100763a0, -0x7696d);          /* call 0x100763a0 */
    II(0x100ecd0d, 0x5)   calld(0x1007623c, -0x76ad6);          /* call 0x1007623c */
    II(0x100ecd12, 0x3)   mov(eax, memd_a32(ds, eax + 0x19));   /* mov eax, [eax+0x19] */
    II(0x100ecd15, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100ecd18, 0x2)   cmp(edx, eax);                        /* cmp edx, eax */
    II(0x100ecd1a, 0x2)   jnzd(0x100ecd1e, 0x2);                /* jnz 0x100ecd1e */
l_0x100ecd1c:
    II(0x100ecd1c, 0x2)   jmpd(0x100ecd24, 0x6);                /* jmp 0x100ecd24 */
l_0x100ecd1e:
    II(0x100ecd1e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100ecd21, 0x3)   inc(memd_a32(ss, ebp - 0x10));        /* inc dword [ebp-0x10] */
l_0x100ecd24:
    II(0x100ecd24, 0x2)   jmpd(0x100eccb9, -0x6d);              /* jmp 0x100eccb9 */
l_0x100ecd26:
    II(0x100ecd26, 0x3)   mov(al, memb_a32(ss, ebp - 0x10));    /* mov al, [ebp-0x10] */
    II(0x100ecd29, 0x3)   mov(memb_a32(ss, ebp - 0xc), al);     /* mov [ebp-0xc], al */
    II(0x100ecd2c, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100ecd2e, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x100ecd31, 0x5)   calld(0x10075f6c, -0x76dca);          /* call 0x10075f6c */
    II(0x100ecd36, 0x2)   jmpd(0x100ecd42, 0xa);                /* jmp 0x100ecd42 */
//  II(0x100ecd38, 0xa)   /* Недостижимый код. */
l_0x100ecd42:
    II(0x100ecd42, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x100ecd45, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ecd47, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ecd48, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ecd49, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ecd4a, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ecd4b, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ecd4c, 0x1)   retd();                               /* ret */
FUNC_END

