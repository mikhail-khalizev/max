FUNC_BEGIN(0x0016100b, 0x40b8248b0ccec8cd, 0x10, ({0xc8, 0, 0, 0, 0x66, 0xf, 0xb7, 0x46, 0x6, 0xb, 0xc0, 0x74, 0x8, 0x87, 0xdb, 0x66, 0xf, 0x2, 0xc0, 0xeb, 0, 0x66, 0x8b, 0xd0, 0x66, 0xc1, 0xea, 0x10, 0xc9, 0xcb}))
    II(0x0016100b, 0x4)   enterw(0, 0);                         /* enter 0x0, 0x0 */
    II(0x0016100f, 0x5)   movzx(eax, memw_a16(ss, bp + 0x6));   /* movzx eax, word [bp+0x6] */
    II(0x00161014, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x00161016, 0x2)   jzw(0x00161020, 0x8);                 /* jz 0x161020 */
    II(0x00161018, 0x2)   xchg(bx, bx);                         /* xchg bx, bx */
    II(0x0016101a, 0x4)   lar(eax, ax);                         /* lar eax, ax */
    II(0x0016101e, 0x2)   jmpw(0x00161020, 0);                  /* jmp 0x161020 */
l_0x00161020:
    II(0x00161020, 0x3)   mov(edx, eax);                        /* mov edx, eax */
    II(0x00161023, 0x4)   shr(edx, 0x10);                       /* shr edx, 0x10 */
    II(0x00161027, 0x1)   leavew();                             /* leave  */
    II(0x00161028, 0x1)   retfw();                              /* retf  */
FUNC_END

