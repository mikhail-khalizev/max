FUNC_BEGIN(0x0014f880, 0x1a06e31ad3c52119, 0x10, ({0xe8, 0x7d, 0x1, 0xfc, 0xe8, 0x79, 0x1, 0xfd, 0xe8, 0x75, 0x1}))
    II(0x0014f880, 0x3)   callw(0x0014fa00, 0x17d);             /* call 0x14fa00 */
    II(0x0014f883, 0x1)   cld();                                /* cld  */
    II(0x0014f884, 0x3)   callw(0x0014fa00, 0x179);             /* call 0x14fa00 */
    II(0x0014f887, 0x1)   std_();                               /* std  */
    II(0x0014f888, 0x3)   callw(0x0014fa00, 0x175);             /* call 0x14fa00 */
    II(0x0014f88b, 0)     jmpd_func(0x0014f88b, 0);             /* Принудительное завершение функции. */
FUNC_END

