FUNC_BEGIN(0x00010027, 0xebc16a4800bbf9a7, 0x10, ({0x66, 0x8b, 0xe5, 0x1f, 0x7, 0x66, 0x61, 0x66, 0xcf}))
    II(0x00010027, 0x3)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x0001002a, 0x1)   popw(ds);                             /* pop ds */
    II(0x0001002b, 0x1)   popw(es);                             /* pop es */
    II(0x0001002c, 0x2)   popad();                              /* popad  */
    II(0x0001002e, 0x2)   iretd();                              /* iretd  */
FUNC_END

