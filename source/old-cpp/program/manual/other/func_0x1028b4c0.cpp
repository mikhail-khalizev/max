FUNC_BEGIN(0x1028b4c0, 0xdf657a8843b26c00, 0x20, ({0x1e, 0x64, 0x66, 0x8c, 0x25, 0x37, 0x15, 0, 0, 0xf, 0xa0, 0x1f, 0x53, 0x8b, 0x5c, 0x24, 0xc, 0x89, 0x1d, 0x70, 0x13, 0, 0, 0x5b, 0x53, 0x33, 0xdb, 0x66, 0x8b, 0xd8, 0xc1, 0xe3, 0x2, 0x58, 0x81, 0xc3, 0x92, 0x14, 0, 0, 0x8b, 0x1b, 0xff, 0xd3, 0x1f, 0xcb}))
    II(0x1028b4c0, 0x1)   pushd(ds);                            /* push ds */
    II(0x1028b4c1, 0x8)   mov(memw_a32(fs, 0x1537), fs);        /* mov [fs:0x1537], fs */
    II(0x1028b4c9, 0x2)   pushd(fs);                            /* push fs */
    II(0x1028b4cb, 0x1)   popd(ds);                             /* pop ds */
    II(0x1028b4cc, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1028b4cd, 0x4)   mov(ebx, memd_a32(ss, esp + 0xc));    /* mov ebx, [esp+0xc] */
    II(0x1028b4d1, 0x6)   mov(memd_a32(ds, 0x1370), ebx);       /* mov [0x1370], ebx */
    II(0x1028b4d7, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1028b4d8, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1028b4d9, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x1028b4db, 0x3)   mov(bx, ax);                          /* mov bx, ax */
    II(0x1028b4de, 0x3)   shl(ebx, 0x2);                        /* shl ebx, 0x2 */
    II(0x1028b4e1, 0x1)   popd(eax);                            /* pop eax */
    II(0x1028b4e2, 0x6)   add(ebx, 0x1492);                     /* add ebx, 0x1492 */
    II(0x1028b4e8, 0x2)   mov(ebx, memd_a32(ds, ebx));          /* mov ebx, [ebx] */
    II(0x1028b4ea, 0x2)   calld_abs(ebx);                       /* call ebx */
    II(0x1028b4ec, 0x1)   popd(ds);                             /* pop ds */
    II(0x1028b4ed, 0x1)   retfd();                              /* retf */
FUNC_END

