FUNC_BEGIN(0x0016105e, 0xeb0dd8425042d804, 0x10, ({0x58, 0xe, 0x50, 0xea, 0x44, 0x22, 0x80, 0}))
    II(0x0016105e, 0x1)   popw(ax);                             /* pop ax */
    II(0x0016105f, 0x1)   pushw(cs);                            /* push cs */
    II(0x00161060, 0x1)   pushw(ax);                            /* push ax */
    II(0x00161061, 0x5)   jmpw_far_abs(0x80, 0x2244);           /* jmp word 0x80:0x2244 */
FUNC_END

