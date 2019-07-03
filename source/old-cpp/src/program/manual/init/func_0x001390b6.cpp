FUNC_BEGIN(0x001390b6, 0x2549155f978b9df9, 0x10, ({0xc8, 0, 0, 0, 0xf, 0, 0x5e, 0x6, 0xc9, 0xcb}))
    II(0x001390b6, 0x4)   enterw(0, 0);                         /* enter 0x0, 0x0 */
    II(0x001390ba, 0x4)   ltr(memw_a16(ss, bp + 0x6));          /* ltr [bp+0x6] */
    II(0x001390be, 0x1)   leavew();                             /* leave  */
    II(0x001390bf, 0x1)   retfw();                              /* retf  */
FUNC_END

