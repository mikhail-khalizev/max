FUNC_BEGIN(/* sys */ 0x101940fc, 0xa3b7db88ba684d, 0x20, ({0x5b, 0x5f, 0x5e, 0xc9, 0xc3}))
    II(0x101940fc, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101940fd, 0x1)   popd(edi);                            /* pop edi */
    II(0x101940fe, 0x1)   popd(esi);                            /* pop esi */
    II(0x101940ff, 0x1)   leaved();                             /* leave */
    II(0x10194100, 0x1)   retd();                               /* ret */
FUNC_END

