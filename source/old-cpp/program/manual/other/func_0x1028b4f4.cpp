FUNC_BEGIN(0x1028b4f4, 0xa738e5392bc142de, 0x20, ({0x66, 0xa3, 0x88, 0x13, 0, 0, 0x66, 0x89, 0x15, 0xbe, 0x14, 0, 0, 0x66, 0x89, 0xd, 0x66, 0x13, 0, 0, 0x66, 0x8c, 0xc0, 0x66, 0xa3, 0x5c, 0x13, 0, 0, 0x89, 0x3d, 0x58, 0x13, 0, 0, 0x66, 0x8c, 0x2d, 0x6e, 0x13, 0, 0, 0xbf, 0x2e, 0x15, 0, 0, 0xbe, 0xd0, 0x3, 0, 0, 0xb9, 0x30, 0x13, 0, 0, 0xc3}))
    II(0x1028b4f4, 0x6)   mov(memw_a32(ds, 0x1388), ax);        /* mov [0x1388], ax */
    II(0x1028b4fa, 0x7)   mov(memw_a32(ds, 0x14be), dx);        /* mov [0x14be], dx */
    II(0x1028b501, 0x7)   mov(memw_a32(ds, 0x1366), cx);        /* mov [0x1366], cx */
    II(0x1028b508, 0x3)   mov(ax, es);                          /* mov ax, es */
    II(0x1028b50b, 0x6)   mov(memw_a32(ds, 0x135c), ax);        /* mov [0x135c], ax */
    II(0x1028b511, 0x6)   mov(memd_a32(ds, 0x1358), edi);       /* mov [0x1358], edi */
    II(0x1028b517, 0x7)   mov(memw_a32(ds, 0x136e), gs);        /* mov [0x136e], gs */
    II(0x1028b51e, 0x5)   mov(edi, 0x152e);                     /* mov edi, 0x152e */
    II(0x1028b523, 0x5)   mov(esi, 0x3d0);                      /* mov esi, 0x3d0 */
    II(0x1028b528, 0x5)   mov(ecx, 0x1330);                     /* mov ecx, 0x1330 */
    II(0x1028b52d, 0x1)   retd();                               /* ret */
FUNC_END

