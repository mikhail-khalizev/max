FUNC_BEGIN(/* sys */ 0x10194357, 0xe5fb61ff89423dc3, 0x20, ({0x55, 0x8b, 0xec, 0xba, 0xda, 0x3, 0, 0, 0x8b, 0x45, 0x8, 0xb, 0xc0, 0x75, 0x7, 0xec, 0x24, 0x8, 0x75, 0xfb, 0xc9, 0xc3, 0xec, 0x24, 0x8, 0x74, 0xfb, 0xc9, 0xc3}))
    II(0x10194357, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10194358, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1019435a, 0x5)   mov(edx, 0x3da);                      /* mov edx, 0x3da */
    II(0x1019435f, 0x3)   mov(eax, memd_a32(ss, ebp + 0x8));    /* mov eax, [ebp+0x8] */
    II(0x10194362, 0x2)   or_(eax, eax);                        /* or eax, eax */
    II(0x10194364, 0x2)   jnzd(0x1019436d, 0x7);                /* jnz 0x1019436d */
l_0x10194366:
    II(0x10194366, 0x1)   inb(al, dx);                          /* in al, dx */
    II(0x10194367, 0x2)   and_(al, 0x8);                        /* and al, 0x8 */
    II(0x10194369, 0x2)   jnzd(0x10194366, -0x5);               /* jnz 0x10194366 */
    II(0x1019436b, 0x1)   leaved();                             /* leave */
    II(0x1019436c, 0x1)   retd();                               /* ret */
l_0x1019436d:
    II(0x1019436d, 0x1)   inb(al, dx);                          /* in al, dx */
    II(0x1019436e, 0x2)   and_(al, 0x8);                        /* and al, 0x8 */
    II(0x10194370, 0x2)   jzd(0x1019436d, -0x5);                /* jz 0x1019436d */
    II(0x10194372, 0x1)   leaved();                             /* leave */
    II(0x10194373, 0x1)   retd();                               /* ret */
FUNC_END

