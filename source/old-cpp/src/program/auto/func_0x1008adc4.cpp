FUNC_BEGIN(0x1008adc4, 0x33197160b199dd79, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x84, 0xaf, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x49, 0xbe, 0xfe, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1008adc4, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1008adc9, 0x5)   calld(sys_check_available_stack_size, 0xdaf84); /* call 0x10165d52 */
    II(0x1008adce, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008adcf, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008add0, 0x1)   pushd(edx);                           /* push edx */
    II(0x1008add1, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008add2, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008add3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008add4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008add6, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1008addc, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1008addf, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008ade2, 0x5)   calld(0x10076c30, -0x141b7);          /* call 0x10076c30 */
    II(0x1008ade7, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1008adea, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008aded, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008adef, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008adf0, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008adf1, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008adf2, 0x1)   popd(edx);                            /* pop edx */
    II(0x1008adf3, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008adf4, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008adf5, 0x1)   retd();                               /* ret */
FUNC_END

