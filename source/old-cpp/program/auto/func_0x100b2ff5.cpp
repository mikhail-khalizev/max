FUNC_BEGIN(0x100b2ff5, 0x781ed3a31373b8ff, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x53, 0x2d, 0xb, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x88, 0x5d, 0xfc, 0x80, 0x7d, 0xfc, 0, 0x74, 0x11, 0x31, 0xd2, 0x8b, 0x45, 0xf4, 0x83, 0xc0, 0x15, 0xe8, 0x4a, 0x7d, 0x8, 0, 0x84, 0xc0, 0x75, 0x2, 0xeb, 0x11, 0x8b, 0x45, 0xf4, 0x83, 0xc0, 0x15, 0xe8, 0x3c, 0x35, 0xfc, 0xff, 0x80, 0x78, 0x3d, 0, 0x74, 0x2, 0xeb, 0x19, 0xe8, 0x9f, 0x80, 0xfd, 0xff, 0x31, 0xd2, 0x88, 0xc2, 0x8b, 0x45, 0xf4, 0x83, 0xc0, 0x15, 0xe8, 0x7c, 0x35, 0xfc, 0xff, 0xe8, 0x24, 0xf9, 0xfe, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x100b2ff5, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100b2ffa, 0x5)   calld(sys_check_available_stack_size, 0xb2d53); /* call 0x10165d52 */
    II(0x100b2fff, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b3000, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b3001, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b3002, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b3003, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b3005, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100b300b, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x100b300e, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x100b3011, 0x3)   mov(memb_a32(ss, ebp - 0x4), bl);     /* mov [ebp-0x4], bl */
    II(0x100b3014, 0x4)   cmp(memb_a32(ss, ebp - 0x4), 0);      /* cmp byte [ebp-0x4], 0x0 */
    II(0x100b3018, 0x2)   jzd(0x100b302b, 0x11);                /* jz 0x100b302b */
    II(0x100b301a, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100b301c, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100b301f, 0x3)   add(eax, 0x15);                       /* add eax, 0x15 */
    II(0x100b3022, 0x5)   calld(0x1013ad71, 0x87d4a);           /* call 0x1013ad71 */
    II(0x100b3027, 0x2)   test(al, al);                         /* test al, al */
    II(0x100b3029, 0x2)   jnzd(0x100b302d, 0x2);                /* jnz 0x100b302d */
l_0x100b302b:
    II(0x100b302b, 0x2)   jmpd(0x100b303e, 0x11);               /* jmp 0x100b303e */
l_0x100b302d:
    II(0x100b302d, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100b3030, 0x3)   add(eax, 0x15);                       /* add eax, 0x15 */
    II(0x100b3033, 0x5)   calld(0x10076574, -0x3cac4);          /* call 0x10076574 */
    II(0x100b3038, 0x4)   cmp(memb_a32(ds, eax + 0x3d), 0);     /* cmp byte [eax+0x3d], 0x0 */
    II(0x100b303c, 0x2)   jzd(0x100b3040, 0x2);                 /* jz 0x100b3040 */
l_0x100b303e:
    II(0x100b303e, 0x2)   jmpd(0x100b3059, 0x19);               /* jmp 0x100b3059 */
l_0x100b3040:
    II(0x100b3040, 0x5)   calld(0x1008b0e4, -0x27f61);          /* call 0x1008b0e4 */
    II(0x100b3045, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100b3047, 0x2)   mov(dl, al);                          /* mov dl, al */
    II(0x100b3049, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100b304c, 0x3)   add(eax, 0x15);                       /* add eax, 0x15 */
    II(0x100b304f, 0x5)   calld(0x100765d0, -0x3ca84);          /* call 0x100765d0 */
    II(0x100b3054, 0x5)   calld(0x100a297d, -0x106dc);          /* call 0x100a297d */
l_0x100b3059:
    II(0x100b3059, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b305b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b305c, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b305d, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b305e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b305f, 0x1)   retd();                               /* ret */
FUNC_END

