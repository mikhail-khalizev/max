FUNC_BEGIN(0x0014eded, 0xbe961ca3db15fb81, 0x10, ({0x66, 0x53, 0x1e, 0x8c, 0xd3, 0x66, 0xf, 0x2, 0xdb, 0x66, 0xc1, 0xeb, 0x17, 0x73, 0x1}))
    II(0x0014eded, 0x2)   pushd(ebx);                           /* push ebx */
    II(0x0014edef, 0x1)   pushw(ds);                            /* push ds */
    II(0x0014edf0, 0x2)   mov(bx, ss);                          /* mov bx, ss */
    II(0x0014edf2, 0x4)   lar(ebx, bx);                         /* lar ebx, bx */
    II(0x0014edf6, 0x4)   shr(ebx, 0x17);                       /* shr ebx, 0x17 */
    II(0x0014edfa, 0x2)   jaew_func(0x0014edfd, 0x1);           /* jae 0x14edfd */
    II(0x0014edfc, 0)     jmpd_func(0x0014edfc, 0);             /* Принудительное завершение функции. */
FUNC_END

