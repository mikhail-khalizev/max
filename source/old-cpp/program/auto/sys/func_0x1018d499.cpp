FUNC_BEGIN(/* sys */ 0x1018d499, 0x8944e93025db43f8, 0x20, ({0x52, 0x31, 0xd2, 0xa1, 0x80, 0xe5, 0x1b, 0x10, 0x89, 0x15, 0x80, 0xe5, 0x1b, 0x10, 0x85, 0xc0, 0x75, 0x9, 0xb4, 0x1, 0xcd, 0x21, 0x25, 0xff, 0, 0, 0, 0x5a, 0xc3}))
    II(0x1018d499, 0x1)   pushd(edx);                           /* push edx */
    II(0x1018d49a, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1018d49c, 0x5)   mov(eax, memd_a32(ds, 0x101be580));   /* mov eax, [0x101be580] */
    II(0x1018d4a1, 0x6)   mov(memd_a32(ds, 0x101be580), edx);   /* mov [0x101be580], edx */
    II(0x1018d4a7, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1018d4a9, 0x2)   jnzd(0x1018d4b4, 0x9);                /* jnz 0x1018d4b4 */
    II(0x1018d4ab, 0x2)   mov(ah, 0x1);                         /* mov ah, 0x1 */
    II(0x1018d4ad, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x1018d4af, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
l_0x1018d4b4:
    II(0x1018d4b4, 0x1)   popd(edx);                            /* pop edx */
    II(0x1018d4b5, 0x1)   retd();                               /* ret */
FUNC_END

