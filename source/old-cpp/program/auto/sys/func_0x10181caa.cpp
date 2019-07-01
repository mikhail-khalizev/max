FUNC_BEGIN(/* sys */ 0x10181caa, 0x5d8669cdf004d850, 0x20, ({0x52, 0x89, 0xc2, 0x80, 0x3a, 0, 0x74, 0xe, 0x31, 0xc0, 0x8a, 0x2, 0xe8, 0xda, 0xd, 0xff, 0xff, 0x88, 0x2, 0x42, 0xeb, 0xed, 0x5a, 0xc3}))
    II(0x10181caa, 0x1)   pushd(edx);                           /* push edx */
    II(0x10181cab, 0x2)   mov(edx, eax);                        /* mov edx, eax */
l_0x10181cad:
    II(0x10181cad, 0x3)   cmp(memb_a32(ds, edx), 0);            /* cmp byte [edx], 0x0 */
    II(0x10181cb0, 0x2)   jzd(0x10181cc0, 0xe);                 /* jz 0x10181cc0 */
    II(0x10181cb2, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10181cb4, 0x2)   mov(al, memb_a32(ds, edx));           /* mov al, [edx] */
    II(0x10181cb6, 0x5)   calld(sys_tolower, -0xf226);          /* call 0x10172a95 */
    II(0x10181cbb, 0x2)   mov(memb_a32(ds, edx), al);           /* mov [edx], al */
    II(0x10181cbd, 0x1)   inc(edx);                             /* inc edx */
    II(0x10181cbe, 0x2)   jmpd(0x10181cad, -0x13);              /* jmp 0x10181cad */
l_0x10181cc0:
    II(0x10181cc0, 0x1)   popd(edx);                            /* pop edx */
    II(0x10181cc1, 0x1)   retd();                               /* ret */
FUNC_END

