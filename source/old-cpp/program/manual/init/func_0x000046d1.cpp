FUNC_BEGIN(0x000046d1, 0x5e771e978ef167ad, 0x10, ({0x9b, 0x50, 0x53, 0xff, 0x26, 0xbe, 0x9}))
    II(0x000046d1, 0x1)   wait();                               /* wait  */
    II(0x000046d2, 0x1)   pushw(ax);                            /* push ax */
    II(0x000046d3, 0x1)   pushw(bx);                            /* push bx */
    II(0x000046d4, 0x4)   jmpw_abs(memw_a16(ds, 0x9be));        /* jmp word near [0x9be] */ /* Вызов '0x000065ec'. */
FUNC_END

