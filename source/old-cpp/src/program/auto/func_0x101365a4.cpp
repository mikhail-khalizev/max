FUNC_BEGIN(0x101365a4, 0x8f412e6e21b8e88c, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xa4, 0xf7, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x5, 0xf0, 0x2, 0, 0, 0xe8, 0x28, 0x41, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101365a4, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x101365a9, 0x5)   calld(sys_check_available_stack_size, 0x2f7a4); /* call 0x10165d52 */
    II(0x101365ae, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101365af, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101365b0, 0x1)   pushd(edx);                           /* push edx */
    II(0x101365b1, 0x1)   pushd(esi);                           /* push esi */
    II(0x101365b2, 0x1)   pushd(edi);                           /* push edi */
    II(0x101365b3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101365b4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101365b6, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x101365bc, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x101365bf, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101365c2, 0x5)   add(eax, 0x2f0);                      /* add eax, 0x2f0 */
    II(0x101365c7, 0x5)   calld(0x1013a6f4, 0x4128);            /* call 0x1013a6f4 */
    II(0x101365cc, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101365ce, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101365cf, 0x1)   popd(edi);                            /* pop edi */
    II(0x101365d0, 0x1)   popd(esi);                            /* pop esi */
    II(0x101365d1, 0x1)   popd(edx);                            /* pop edx */
    II(0x101365d2, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101365d3, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101365d4, 0x1)   retd();                               /* ret */
FUNC_END

