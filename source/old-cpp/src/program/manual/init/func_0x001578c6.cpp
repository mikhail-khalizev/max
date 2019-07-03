FUNC_BEGIN(0x001578c6, 0xfaf7dddfc9018b44, 0x10, ({0xc8, 0, 0, 0, 0x57, 0x56, 0xff, 0xe, 0x74, 0x12, 0x5e, 0x5f, 0xc9, 0xcb}))
    II(0x001578c6, 0x4)   enterw(0, 0);                         /* enter 0x0, 0x0 */
    II(0x001578ca, 0x1)   pushw(di);                            /* push di */
    II(0x001578cb, 0x1)   pushw(si);                            /* push si */
    II(0x001578cc, 0x4)   dec(memw_a16(ds, 0x1274));            /* dec word [0x1274] */
    II(0x001578d0, 0x1)   popw(si);                             /* pop si */
    II(0x001578d1, 0x1)   popw(di);                             /* pop di */
    II(0x001578d2, 0x1)   leavew();                             /* leave  */
    II(0x001578d3, 0x1)   retfw();                              /* retf  */
FUNC_END

