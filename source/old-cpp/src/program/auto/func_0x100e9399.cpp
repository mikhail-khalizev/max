FUNC_BEGIN(0x100e9399, 0xbdf9c07e8617d490, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xaf, 0xc9, 0x7, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0xf, 0xbf, 0x5d, 0xfc, 0xba, 0xc0, 0xde, 0x1b, 0x10, 0xa1, 0x5c, 0x36, 0x1c, 0x10, 0xe8, 0x61, 0x37, 0x8, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100e9399, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100e939e, 0x5)   calld(sys_check_available_stack_size, 0x7c9af); /* call 0x10165d52 */
    II(0x100e93a3, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e93a4, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e93a5, 0x1)   pushd(edx);                           /* push edx */
    II(0x100e93a6, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e93a7, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e93a8, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e93a9, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e93ab, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100e93b1, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100e93b4, 0x4)   movsx(ebx, memw_a32(ss, ebp - 0x4));  /* movsx ebx, word [ebp-0x4] */
    II(0x100e93b8, 0x5)   mov(edx, 0x101bdec0);                 /* mov edx, 0x101bdec0 */
    II(0x100e93bd, 0x5)   mov(eax, memd_a32(ds, 0x101c365c));   /* mov eax, [0x101c365c] */
    II(0x100e93c2, 0x5)   calld(/* sys */ 0x1016cb28, 0x83761); /* call 0x1016cb28 */
    II(0x100e93c7, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e93c9, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e93ca, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e93cb, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e93cc, 0x1)   popd(edx);                            /* pop edx */
    II(0x100e93cd, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e93ce, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e93cf, 0x1)   retd();                               /* ret */
FUNC_END

