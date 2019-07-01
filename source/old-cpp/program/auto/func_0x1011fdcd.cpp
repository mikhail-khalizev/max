FUNC_BEGIN(0x1011fdcd, 0xdcc915bd1a11d0a3, 0x20, ({0x68, 0x1c, 0, 0, 0, 0xe8, 0x7b, 0x5f, 0x4, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0, 0, 0, 0, 0xb8, 0x6c, 0x53, 0x1c, 0x10, 0xe8, 0x3f, 0xe1, 0xff, 0xff, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1011fdcd, 0x5)   pushd(0x1c);                          /* push dword 0x1c */
    II(0x1011fdd2, 0x5)   calld(sys_check_available_stack_size, 0x45f7b); /* call 0x10165d52 */
    II(0x1011fdd7, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1011fdd8, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011fdd9, 0x1)   pushd(edx);                           /* push edx */
    II(0x1011fdda, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011fddb, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011fddc, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011fddd, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1011fddf, 0x6)   sub(esp, 0);                          /* sub esp, 0x0 */
    II(0x1011fde5, 0x5)   mov(eax, 0x101c536c);                 /* mov eax, 0x101c536c */
    II(0x1011fdea, 0x5)   calld(0x1011df2e, -0x1ec1);           /* call 0x1011df2e */
    II(0x1011fdef, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011fdf0, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011fdf1, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011fdf2, 0x1)   popd(edx);                            /* pop edx */
    II(0x1011fdf3, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1011fdf4, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1011fdf5, 0x1)   retd();                               /* ret */
FUNC_END

