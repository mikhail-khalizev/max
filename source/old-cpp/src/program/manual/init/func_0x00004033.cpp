FUNC_BEGIN(0x00004033, 0xa3b7dbdaf276c9, 0x10, ({0x60, 0xff, 0x16, 0xc0, 0x9}))
    II(0x00004033, 0x1)   pusha();                              /* pusha  */
    II(0x00004034, 0x4)   callw_abs(memw_a16(ds, 0x9c0));       /* call word near [0x9c0] */ /* Вызов '0x0000409c'. */
    II(0x00004038, 0)     jmpd_func(0x00004038, 0);             /* Принудительное завершение функции. */
FUNC_END

