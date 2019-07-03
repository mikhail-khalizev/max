FUNC_BEGIN(0x0015552f, 0x254917b1a1f24874, 0x10, ({0xc8, 0, 0, 0, 0x57, 0x56, 0x5e, 0x5f, 0xc9, 0xc3}))
    II(0x0015552f, 0x4)   enterw(0, 0);                         /* enter 0x0, 0x0 */
    II(0x00155533, 0x1)   pushw(di);                            /* push di */
    II(0x00155534, 0x1)   pushw(si);                            /* push si */
    II(0x00155535, 0x1)   popw(si);                             /* pop si */
    II(0x00155536, 0x1)   popw(di);                             /* pop di */
    II(0x00155537, 0x1)   leavew();                             /* leave  */
    II(0x00155538, 0x1)   retw();                               /* ret  */
FUNC_END

