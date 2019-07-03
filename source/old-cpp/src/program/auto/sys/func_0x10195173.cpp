FUNC_BEGIN(/* sys */ 0x10195173, 0x1bf3467e6bf82190, 0x20, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0x66, 0xb8, 0, 0x16, 0xcd, 0x2f, 0x3c, 0x3, 0x75, 0x14, 0x90, 0x90, 0x90, 0x90, 0xb4, 0x81, 0xb0, 0xc, 0x8b, 0x5d, 0x8, 0x66, 0x33, 0xd2, 0xcd, 0x4b, 0x66, 0xb8, 0, 0, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x10195173, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10195174, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10195176, 0x1)   pushd(esi);                           /* push esi */
    II(0x10195177, 0x1)   pushd(edi);                           /* push edi */
    II(0x10195178, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10195179, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1019517a, 0x2)   pushd(fs);                            /* push fs */
    II(0x1019517c, 0x2)   pushd(gs);                            /* push gs */
    II(0x1019517e, 0x1)   pushd(es);                            /* push es */
    II(0x1019517f, 0x4)   mov(ax, 0x1600);                      /* mov ax, 0x1600 */
    II(0x10195183, 0x2)   int_(0x2f);                           /* int 0x2f */
    II(0x10195185, 0x2)   cmp(al, 0x3);                         /* cmp al, 0x3 */
    II(0x10195187, 0x2)   jnzd(0x1019519d, 0x14);               /* jnz 0x1019519d */
//    II(0x10195189, 0x1)   nop();                                /* nop */
//    II(0x1019518a, 0x1)   nop();                                /* nop */
//    II(0x1019518b, 0x1)   nop();                                /* nop */
//    II(0x1019518c, 0x1)   nop();                                /* nop */
    II(0x1019518d, 0x2)   mov(ah, 0x81);                        /* mov ah, 0x81 */
    II(0x1019518f, 0x2)   mov(al, 0xc);                         /* mov al, 0xc */
    II(0x10195191, 0x3)   mov(ebx, memd_a32(ss, ebp + 0x8));    /* mov ebx, [ebp+0x8] */
    II(0x10195194, 0x3)   xor_(dx, dx);                         /* xor dx, dx */
    II(0x10195197, 0x2)   int_(0x4b);                           /* int 0x4b */
    II(0x10195199, 0x4)   mov(ax, 0);                           /* mov ax, 0x0 */
l_0x1019519d:
    II(0x1019519d, 0x1)   popd(es);                             /* pop es */
    II(0x1019519e, 0x2)   popd(gs);                             /* pop gs */
    II(0x101951a0, 0x2)   popd(fs);                             /* pop fs */
    II(0x101951a2, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101951a3, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101951a4, 0x1)   popd(edi);                            /* pop edi */
    II(0x101951a5, 0x1)   popd(esi);                            /* pop esi */
    II(0x101951a6, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101951a7, 0x1)   retd();                               /* ret */
FUNC_END

