FUNC_BEGIN(/* sys */ 0x10180fd2, 0xeb064c5b690e770d, 0x20, ({0x52, 0x89, 0xc2, 0x29, 0xc0, 0xec, 0x5a, 0xc3}))
    II(0x10180fd2, 0x1)   pushd(edx);                           /* push edx */
    II(0x10180fd3, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10180fd5, 0x2)   sub(eax, eax);                        /* sub eax, eax */
    II(0x10180fd7, 0x1)   inb(al, dx);                          /* in al, dx */
    II(0x10180fd8, 0x1)   popd(edx);                            /* pop edx */
    II(0x10180fd9, 0x1)   retd();                               /* ret */
FUNC_END

