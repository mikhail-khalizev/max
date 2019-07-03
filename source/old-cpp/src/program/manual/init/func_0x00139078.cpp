FUNC_BEGIN(0x00139078, 0xf1db298f0f9d9bc4, 0x10, ({0xfa, 0x66, 0x50, 0xf, 0x20, 0xc0, 0x66, 0xd, 0, 0, 0, 0x80, 0xf, 0x22, 0xc0, 0x66, 0x58, 0xfb, 0xcb}))
    II(0x00139078, 0x1)   cli();                                /* cli  */
    II(0x00139079, 0x2)   pushd(eax);                           /* push eax */
    II(0x0013907b, 0x3)   mov(eax, cr0);                        /* mov eax, cr0 */
    II(0x0013907e, 0x6)   or_(eax, 0x80000000);                 /* or eax, 0x80000000 */
    II(0x00139084, 0x3)   mov(cr0, eax);                        /* mov cr0, eax */
    II(0x00139087, 0x2)   popd(eax);                            /* pop eax */
    II(0x00139089, 0x1)   sti();                                /* sti  */
    II(0x0013908a, 0x1)   retfw();                              /* retf  */
FUNC_END

