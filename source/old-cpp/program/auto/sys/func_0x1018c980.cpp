FUNC_BEGIN(/* sys */ 0x1018c980, 0x8788bc2b9e556dd0, 0x20, ({0x55, 0x89, 0xe5, 0x83, 0xec, 0x34, 0xe8, 0xc5, 0xfa, 0xff, 0xff, 0x85, 0xc0, 0x74, 0x61, 0x8d, 0x45, 0xcc, 0xbb, 0x32, 0, 0, 0, 0x31, 0xd2, 0xe8, 0x42, 0x94, 0xfd, 0xff, 0xb4, 0x4f, 0xb2, 0x5, 0x88, 0x65, 0xe9, 0x88, 0x55, 0xe8, 0x66, 0xa1, 0x8, 0xb7, 0x20, 0x10, 0xba, 0, 0x8, 0, 0, 0x66, 0x89, 0x45, 0xfc, 0x66, 0x89, 0x55, 0xfa, 0x30, 0xf6, 0x8a, 0x45, 0x8, 0x88, 0x75, 0xdd, 0x88, 0x45, 0xdc, 0x8b, 0x45, 0xc, 0x8d, 0x55, 0xcc, 0x66, 0x89, 0x45, 0xe0, 0xb8, 0x10, 0, 0, 0, 0xe8, 0x66, 0x7b, 0, 0, 0x85, 0xc0, 0x74, 0x7, 0x66, 0x83, 0x7d, 0xe8, 0x4f, 0x74, 0x6, 0x31, 0xc0, 0x89, 0xec, 0x5d, 0xc3, 0xb8, 0x1, 0, 0, 0, 0x89, 0xec, 0x5d, 0xc3}))
    II(0x1018c980, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1018c981, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1018c983, 0x3)   sub(esp, 0x34);                       /* sub esp, 0x34 */
    II(0x1018c986, 0x5)   calld(/* sys */ 0x1018c450, -0x53b);  /* call 0x1018c450 */
    II(0x1018c98b, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1018c98d, 0x2)   jzd(0x1018c9f0, 0x61);                /* jz 0x1018c9f0 */
    II(0x1018c98f, 0x3)   lea(eax, ebp - 0x34);                 /* lea eax, [ebp-0x34] */
    II(0x1018c992, 0x5)   mov(ebx, 0x32);                       /* mov ebx, 0x32 */
    II(0x1018c997, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1018c999, 0x5)   calld(sys_memset, -0x26bbe);          /* call 0x10165de0 */
    II(0x1018c99e, 0x2)   mov(ah, 0x4f);                        /* mov ah, 0x4f */
    II(0x1018c9a0, 0x2)   mov(dl, 0x5);                         /* mov dl, 0x5 */
    II(0x1018c9a2, 0x3)   mov(memb_a32(ss, ebp - 0x17), ah);    /* mov [ebp-0x17], ah */
    II(0x1018c9a5, 0x3)   mov(memb_a32(ss, ebp - 0x18), dl);    /* mov [ebp-0x18], dl */
    II(0x1018c9a8, 0x6)   mov(ax, memw_a32(ds, 0x1020b708));    /* mov ax, [0x1020b708] */
    II(0x1018c9ae, 0x5)   mov(edx, 0x800);                      /* mov edx, 0x800 */
    II(0x1018c9b3, 0x4)   mov(memw_a32(ss, ebp - 0x4), ax);     /* mov [ebp-0x4], ax */
    II(0x1018c9b7, 0x4)   mov(memw_a32(ss, ebp - 0x6), dx);     /* mov [ebp-0x6], dx */
    II(0x1018c9bb, 0x2)   xor_(dh, dh);                         /* xor dh, dh */
    II(0x1018c9bd, 0x3)   mov(al, memb_a32(ss, ebp + 0x8));     /* mov al, [ebp+0x8] */
    II(0x1018c9c0, 0x3)   mov(memb_a32(ss, ebp - 0x23), dh);    /* mov [ebp-0x23], dh */
    II(0x1018c9c3, 0x3)   mov(memb_a32(ss, ebp - 0x24), al);    /* mov [ebp-0x24], al */
    II(0x1018c9c6, 0x3)   mov(eax, memd_a32(ss, ebp + 0xc));    /* mov eax, [ebp+0xc] */
    II(0x1018c9c9, 0x3)   lea(edx, ebp - 0x34);                 /* lea edx, [ebp-0x34] */
    II(0x1018c9cc, 0x4)   mov(memw_a32(ss, ebp - 0x20), ax);    /* mov [ebp-0x20], ax */
    II(0x1018c9d0, 0x5)   mov(eax, 0x10);                       /* mov eax, 0x10 */
    II(0x1018c9d5, 0x5)   calld(/* sys */ 0x10194540, 0x7b66);  /* call 0x10194540 */
    II(0x1018c9da, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1018c9dc, 0x2)   jzd(0x1018c9e5, 0x7);                 /* jz 0x1018c9e5 */
    II(0x1018c9de, 0x5)   cmp(memw_a32(ss, ebp - 0x18), 0x4f);  /* cmp word [ebp-0x18], 0x4f */
    II(0x1018c9e3, 0x2)   jzd(0x1018c9eb, 0x6);                 /* jz 0x1018c9eb */
l_0x1018c9e5:
    II(0x1018c9e5, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1018c9e7, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1018c9e9, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1018c9ea, 0x1)   retd();                               /* ret */
l_0x1018c9eb:
    II(0x1018c9eb, 0x5)   mov(eax, 0x1);                        /* mov eax, 0x1 */
l_0x1018c9f0:
    II(0x1018c9f0, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1018c9f2, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1018c9f3, 0x1)   retd();                               /* ret */
FUNC_END

