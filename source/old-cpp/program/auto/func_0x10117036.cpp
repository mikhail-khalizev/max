FUNC_BEGIN(0x10117036, 0xa8db3524d9b21e7b, 0x20, ({0x68, 0x68, 0, 0, 0, 0xe8, 0x12, 0xed, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x50, 0, 0, 0, 0x89, 0x45, 0xf8, 0x88, 0x55, 0xfc, 0x80, 0x4d, 0xf4, 0x1, 0x31, 0xdb, 0x8a, 0x5d, 0xfc, 0x8b, 0x55, 0xf8, 0x8d, 0x45, 0xb8, 0xe8, 0x87, 0xfb, 0xff, 0xff, 0x89, 0x45, 0xb4, 0x80, 0x65, 0xf4, 0xfe, 0x8d, 0x45, 0xb8, 0xe8, 0xdd, 0xfe, 0xff, 0xff, 0x89, 0x45, 0xb0, 0x31, 0xd2, 0x8d, 0x45, 0xb8, 0xe8, 0xfe, 0xfd, 0xff, 0xff, 0xeb, 0xa, 0x31, 0xd2, 0x8d, 0x45, 0xb8, 0xe8, 0xf2, 0xfd, 0xff, 0xff, 0x8b, 0x45, 0xb0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10117036, 0x5)   pushd(0x68);                          /* push dword 0x68 */
    II(0x1011703b, 0x5)   calld(sys_check_available_stack_size, 0x4ed12); /* call 0x10165d52 */
    II(0x10117040, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10117041, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10117042, 0x1)   pushd(esi);                           /* push esi */
    II(0x10117043, 0x1)   pushd(edi);                           /* push edi */
    II(0x10117044, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10117045, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10117047, 0x6)   sub(esp, 0x50);                       /* sub esp, 0x50 */
    II(0x1011704d, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10117050, 0x3)   mov(memb_a32(ss, ebp - 0x4), dl);     /* mov [ebp-0x4], dl */
    II(0x10117053, 0x4)   or_(memb_a32(ss, ebp - 0xc), 0x1);    /* or byte [ebp-0xc], 0x1 */
    II(0x10117057, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x10117059, 0x3)   mov(bl, memb_a32(ss, ebp - 0x4));     /* mov bl, [ebp-0x4] */
    II(0x1011705c, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x1011705f, 0x3)   lea(eax, ebp - 0x48);                 /* lea eax, [ebp-0x48] */
    II(0x10117062, 0x5)   calld(0x10116bee, -0x479);            /* call 0x10116bee */
    II(0x10117067, 0x3)   mov(memd_a32(ss, ebp - 0x4c), eax);   /* mov [ebp-0x4c], eax */
    II(0x1011706a, 0x4)   and_(memb_a32(ss, ebp - 0xc), -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
    II(0x1011706e, 0x3)   lea(eax, ebp - 0x48);                 /* lea eax, [ebp-0x48] */
    II(0x10117071, 0x5)   calld(0x10116f53, -0x123);            /* call 0x10116f53 */
    II(0x10117076, 0x3)   mov(memd_a32(ss, ebp - 0x50), eax);   /* mov [ebp-0x50], eax */
    II(0x10117079, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1011707b, 0x3)   lea(eax, ebp - 0x48);                 /* lea eax, [ebp-0x48] */
    II(0x1011707e, 0x5)   calld(0x10116e81, -0x202);            /* call 0x10116e81 */
    II(0x10117083, 0x2)   jmpd(0x1011708f, 0xa);                /* jmp 0x1011708f */
//  II(0x10117085, 0xa)   /* Недостижимый код. */
l_0x1011708f:
    II(0x1011708f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x50));   /* mov eax, [ebp-0x50] */
    II(0x10117092, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10117094, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10117095, 0x1)   popd(edi);                            /* pop edi */
    II(0x10117096, 0x1)   popd(esi);                            /* pop esi */
    II(0x10117097, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10117098, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10117099, 0x1)   retd();                               /* ret */
FUNC_END

