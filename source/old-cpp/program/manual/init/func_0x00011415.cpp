FUNC_BEGIN(0x00011415, 0x7ddb6878462a4153, 0x10, ({0x33, 0xc9, 0x8a, 0x2e, 0, 0xe, 0xe3, 0x17, 0x38, 0xe, 0xff, 0xd, 0x74, 0x3, 0xb9, 0xf8, 0xff, 0x66, 0x50, 0x66, 0xa1, 0xac, 0, 0x66, 0xc1, 0xe8, 0x6, 0x2b, 0xc8, 0x66, 0x58, 0x91, 0xc3}))
    II(0x00011415, 0x2)   xor_(cx, cx);                         /* xor cx, cx */
    II(0x00011417, 0x4)   mov(ch, memb_a16(ds, 0xe00));         /* mov ch, [0xe00] */
    II(0x0001141b, 0x2)   jcxzw(0x00011434, 0x17);              /* jcxz 0x11434 */
    II(0x0001141d, 0x4)   cmp(memb_a16(ds, 0xdff), cl);         /* cmp [0xdff], cl */
    II(0x00011421, 0x2)   jzw(0x00011426, 0x3);                 /* jz 0x11426 */
    II(0x00011423, 0x3)   mov(cx, 0xfff8);                      /* mov cx, 0xfff8 */
l_0x00011426:
    II(0x00011426, 0x2)   pushd(eax);                           /* push eax */
    II(0x00011428, 0x4)   mov(eax, memd_a16(ds, 0xac));         /* mov eax, [0xac] */
    II(0x0001142c, 0x4)   shr(eax, 0x6);                        /* shr eax, 0x6 */
    II(0x00011430, 0x2)   sub(cx, ax);                          /* sub cx, ax */
    II(0x00011432, 0x2)   popd(eax);                            /* pop eax */
l_0x00011434:
    II(0x00011434, 0x1)   xchg(cx, ax);                         /* xchg cx, ax */
    II(0x00011435, 0x1)   retw();                               /* ret  */
FUNC_END

