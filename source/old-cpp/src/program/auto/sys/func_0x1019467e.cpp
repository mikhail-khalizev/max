FUNC_BEGIN(/* sys */ 0x1019467e, 0xb40cb3195feaa263, 0x20, ({0x53, 0x51, 0x52, 0x89, 0xc3, 0xb0, 0, 0xb4, 0x44, 0xcd, 0x21, 0xd1, 0xd2, 0xd1, 0xca, 0x30, 0xf6, 0x31, 0xc0, 0x80, 0xe2, 0x80, 0x66, 0x89, 0xd0, 0x85, 0xc0, 0xf, 0x95, 0xc0, 0x25, 0xff, 0, 0, 0, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1019467e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1019467f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10194680, 0x1)   pushd(edx);                           /* push edx */
    II(0x10194681, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x10194683, 0x2)   mov(al, 0);                           /* mov al, 0x0 */
    II(0x10194685, 0x2)   mov(ah, 0x44);                        /* mov ah, 0x44 */
    II(0x10194687, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x10194689, 0x2)   rcl(edx, 0x1);                        /* rcl edx, 1 */
    II(0x1019468b, 0x2)   ror(edx, 0x1);                        /* ror edx, 1 */
    II(0x1019468d, 0x2)   xor_(dh, dh);                         /* xor dh, dh */
    II(0x1019468f, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10194691, 0x3)   and_(dl, 0x80);                       /* and dl, 0x80 */
    II(0x10194694, 0x3)   mov(ax, dx);                          /* mov ax, dx */
    II(0x10194697, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10194699, 0x3)   setnz(al);                            /* setnz al */
    II(0x1019469c, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x101946a1, 0x1)   popd(edx);                            /* pop edx */
    II(0x101946a2, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101946a3, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101946a4, 0x1)   retd();                               /* ret */
FUNC_END

