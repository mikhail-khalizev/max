FUNC_BEGIN(0x00009d53, 0xa3b7db869833d4, 0x10, ({0x59, 0x58, 0x58, 0xff, 0xe1}))
    II(0x00009d53, 0x1)   popw(cx);                             /* pop cx */
    II(0x00009d54, 0x1)   popw(ax);                             /* pop ax */
    II(0x00009d55, 0x1)   popw(ax);                             /* pop ax */
    II(0x00009d56, 0x2)   jmpw_abs(cx);                         /* jmp cx */
FUNC_END

