FUNC_BEGIN(/* sys */ 0x1019513e, 0xac15b658667b563d, 0x20, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0x66, 0xb8, 0, 0x16, 0xcd, 0x2f, 0x3c, 0x3, 0x75, 0x14, 0x90, 0x90, 0x90, 0x90, 0xb4, 0x81, 0xb0, 0xb, 0x8b, 0x5d, 0x8, 0x66, 0x33, 0xd2, 0xcd, 0x4b, 0x66, 0xb8, 0, 0, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x1019513e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1019513f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10195141, 0x1)   pushd(esi);                           /* push esi */
    II(0x10195142, 0x1)   pushd(edi);                           /* push edi */
    II(0x10195143, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10195144, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10195145, 0x2)   pushd(fs);                            /* push fs */
    II(0x10195147, 0x2)   pushd(gs);                            /* push gs */
    II(0x10195149, 0x1)   pushd(es);                            /* push es */
    II(0x1019514a, 0x4)   mov(ax, 0x1600);                      /* mov ax, 0x1600 */
    II(0x1019514e, 0x2)   int_(0x2f);                           /* int 0x2f */
    II(0x10195150, 0x2)   cmp(al, 0x3);                         /* cmp al, 0x3 */
    II(0x10195152, 0x2)   jnzd(0x10195168, 0x14);               /* jnz 0x10195168 */
//    II(0x10195154, 0x1)   nop();                                /* nop */
//    II(0x10195155, 0x1)   nop();                                /* nop */
//    II(0x10195156, 0x1)   nop();                                /* nop */
//    II(0x10195157, 0x1)   nop();                                /* nop */
    II(0x10195158, 0x2)   mov(ah, 0x81);                        /* mov ah, 0x81 */
    II(0x1019515a, 0x2)   mov(al, 0xb);                         /* mov al, 0xb */
    II(0x1019515c, 0x3)   mov(ebx, memd_a32(ss, ebp + 0x8));    /* mov ebx, [ebp+0x8] */
    II(0x1019515f, 0x3)   xor_(dx, dx);                         /* xor dx, dx */
    II(0x10195162, 0x2)   int_(0x4b);                           /* int 0x4b */
    II(0x10195164, 0x4)   mov(ax, 0);                           /* mov ax, 0x0 */
l_0x10195168:
    II(0x10195168, 0x1)   popd(es);                             /* pop es */
    II(0x10195169, 0x2)   popd(gs);                             /* pop gs */
    II(0x1019516b, 0x2)   popd(fs);                             /* pop fs */
    II(0x1019516d, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1019516e, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1019516f, 0x1)   popd(edi);                            /* pop edi */
    II(0x10195170, 0x1)   popd(esi);                            /* pop esi */
    II(0x10195171, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10195172, 0x1)   retd();                               /* ret */
FUNC_END

