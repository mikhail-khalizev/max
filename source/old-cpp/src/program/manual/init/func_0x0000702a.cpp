FUNC_BEGIN(0x0000702a, 0x29b55303e9e5831f, 0x10, ({0x58, 0xcc, 0, 0x1, 0, 0x1}))
    II(0x0000702a, 0x1)   popw(ax);                             /* pop ax */
    II(0x0000702b, 0x1)   int3();                               /* int3  */
    II(0x0000702c, 0x2)   add(memb_a16(ds, bx + di), al);       /* add [bx+di], al */
    II(0x0000702e, 0x2)   add(memb_a16(ds, bx + di), al);       /* add [bx+di], al */
    II(0x00007030, 0)     jmpd_func(0x00007030, 0);             /* Принудительное завершение функции. */
FUNC_END

