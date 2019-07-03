FUNC_BEGIN(0x00009cc4, 0x9f42e9cc4b4da484, 0x10, ({0x9c, 0x58, 0x80, 0xe4, 0xcf, 0x50, 0x9d, 0x9c, 0x58, 0x25, 0, 0x30, 0xc3}))
    II(0x00009cc4, 0x1)   pushfw();                             /* pushfw  */
    II(0x00009cc5, 0x1)   popw(ax);                             /* pop ax */
    II(0x00009cc6, 0x3)   and_(ah, 0xcf);                       /* and ah, 0xcf */
    II(0x00009cc9, 0x1)   pushw(ax);                            /* push ax */
    II(0x00009cca, 0x1)   popfw();                              /* popfw  */
    II(0x00009ccb, 0x1)   pushfw();                             /* pushfw  */
    II(0x00009ccc, 0x1)   popw(ax);                             /* pop ax */
    II(0x00009ccd, 0x3)   and_(ax, 0x3000);                     /* and ax, 0x3000 */
    II(0x00009cd0, 0x1)   retw();                               /* ret  */
FUNC_END

