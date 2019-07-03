FUNC_BEGIN(0x0014a42e, 0x29b5532feea3ea6b, 0x10, ({0x59, 0xb, 0xc0, 0x74, 0xc4, 0xc3}))
    II(0x0014a42e, 0x1)   popw(cx);                             /* pop cx */
    II(0x0014a42f, 0x2)   or_(ax, ax);                          /* or ax, ax */
    II(0x0014a431, 0x2)   jzw_func(0x0014a3f7, -0x3c);          /* jz 0x14a3f7 */
    II(0x0014a433, 0x1)   retw();                               /* ret  */
FUNC_END

