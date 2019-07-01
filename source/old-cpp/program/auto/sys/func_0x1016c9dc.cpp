FUNC_BEGIN(/* sys */ 0x1016c9dc, 0x15d451d5a2959225, 0x20, ({0x89, 0xc1, 0x89, 0xd0, 0x89, 0xec, 0x87, 0x4d, 0x28, 0x87, 0x45, 0x2c, 0xf, 0xa9, 0xf, 0xa1, 0x7, 0x1f, 0x5f, 0x5e, 0x5d, 0x5b, 0x5b, 0x5a, 0xcb}))
    II(0x1016c9dc, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x1016c9de, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x1016c9e0, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1016c9e2, 0x3)   xchg(memd_a32(ss, ebp + 0x28), ecx);  /* xchg [ebp+0x28], ecx */
    II(0x1016c9e5, 0x3)   xchg(memd_a32(ss, ebp + 0x2c), eax);  /* xchg [ebp+0x2c], eax */
    II(0x1016c9e8, 0x2)   popd(gs);                             /* pop gs */
    II(0x1016c9ea, 0x2)   popd(fs);                             /* pop fs */
    II(0x1016c9ec, 0x1)   popd(es);                             /* pop es */
    II(0x1016c9ed, 0x1)   popd(ds);                             /* pop ds */
    II(0x1016c9ee, 0x1)   popd(edi);                            /* pop edi */
    II(0x1016c9ef, 0x1)   popd(esi);                            /* pop esi */
    II(0x1016c9f0, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1016c9f1, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1016c9f2, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1016c9f3, 0x1)   popd(edx);                            /* pop edx */
    II(0x1016c9f4, 0x1)   retfd();                              /* retf */
FUNC_END

