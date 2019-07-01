FUNC_BEGIN(0x00003f21, 0x5e771e034c6af4c8, 0x10, ({0x90, 0x50, 0x53, 0xff, 0x26, 0xbe, 0x9}))
//    II(0x00003f21, 0x1)   nop();                                /* nop  */
    II(0x00003f22, 0x1)   pushw(ax);                            /* push ax */
    II(0x00003f23, 0x1)   pushw(bx);                            /* push bx */
    II(0x00003f24, 0x4)   jmpw_abs(memw_a16(ds, 0x9be));        /* jmp word near [0x9be] */ /* Вызов '0x000035f0'. */
FUNC_END

