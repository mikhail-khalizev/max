FUNC_BEGIN(/* sys */ 0x1016b244, 0xc44a7f609ef95ba6, 0x20, ({0x53, 0x8b, 0x1d, 0x4c, 0xfb, 0x1c, 0x10, 0x89, 0x18, 0xa1, 0x50, 0xfb, 0x1c, 0x10, 0x89, 0x2, 0x5b}))
    II(0x1016b244, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1016b245, 0x6)   mov(ebx, memd_a32(ds, 0x101cfb4c));   /* mov ebx, [0x101cfb4c] */
    II(0x1016b24b, 0x2)   mov(memd_a32(ds, eax), ebx);          /* mov [eax], ebx */
    II(0x1016b24d, 0x5)   mov(eax, memd_a32(ds, 0x101cfb50));   /* mov eax, [0x101cfb50] */
    II(0x1016b252, 0x2)   mov(memd_a32(ds, edx), eax);          /* mov [edx], eax */
    II(0x1016b254, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1016b255, 0)     jmpd_func(/* sys */ 0x1016b255, 0);   /* Принудительное завершение функции. */
FUNC_END

