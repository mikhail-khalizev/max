FUNC_BEGIN(0x00138e97, 0x288f6e5e721f877a, 0x10, ({0x66, 0x50, 0xf, 0x20, 0xd8, 0xf, 0x22, 0xd8, 0x66, 0x58, 0xcb}))
    II(0x00138e97, 0x2)   pushd(eax);                           /* push eax */
    II(0x00138e99, 0x3)   mov(eax, cr3);                        /* mov eax, cr3 */
//    II(0x00138e9c, 0x3)   mov(cr3, eax);                        /* mov cr3, eax */
    II(0x00138e9f, 0x2)   popd(eax);                            /* pop eax */
    II(0x00138ea1, 0x1)   retfw();                              /* retf  */
FUNC_END

