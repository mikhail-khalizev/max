FUNC_BEGIN(/* sys */ 0x10179230, 0xf3f426460bb95342, 0x20, ({0x53, 0x89, 0xc3, 0x29, 0xc0, 0xb4, 0x19, 0xcd, 0x21, 0x66, 0x40, 0xb4, 0, 0x89, 0x3, 0x66, 0x29, 0xc0, 0x5b, 0xc3}))
    II(0x10179230, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10179231, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x10179233, 0x2)   sub(eax, eax);                        /* sub eax, eax */
    II(0x10179235, 0x2)   mov(ah, 0x19);                        /* mov ah, 0x19 */
    II(0x10179237, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x10179239, 0x2)   inc(ax);                              /* inc ax */
    II(0x1017923b, 0x2)   mov(ah, 0);                           /* mov ah, 0x0 */
    II(0x1017923d, 0x2)   mov(memd_a32(ds, ebx), eax);          /* mov [ebx], eax */
    II(0x1017923f, 0x3)   sub(ax, ax);                          /* sub ax, ax */
    II(0x10179242, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10179243, 0x1)   retd();                               /* ret */
FUNC_END

