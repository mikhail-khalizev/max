FUNC_BEGIN(0x1010bd92, 0xef02cc565840ff65, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xb6, 0x9f, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0xe8, 0xba, 0x90, 0xfc, 0xff, 0x31, 0xdb, 0x88, 0xc3, 0x31, 0xd2, 0xb8, 0x1c, 0, 0, 0, 0xe8, 0x3e, 0x9d, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1010bd92, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1010bd97, 0x5)   calld(sys_check_available_stack_size, 0x59fb6); /* call 0x10165d52 */
    II(0x1010bd9c, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1010bd9d, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1010bd9e, 0x1)   pushd(edx);                           /* push edx */
    II(0x1010bd9f, 0x1)   pushd(esi);                           /* push esi */
    II(0x1010bda0, 0x1)   pushd(edi);                           /* push edi */
    II(0x1010bda1, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1010bda2, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1010bda4, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1010bdaa, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1010bdad, 0x5)   calld(0x100d4e6c, -0x36f46);          /* call 0x100d4e6c */
    II(0x1010bdb2, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x1010bdb4, 0x2)   mov(bl, al);                          /* mov bl, al */
    II(0x1010bdb6, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1010bdb8, 0x5)   mov(eax, 0x1c);                       /* mov eax, 0x1c */
    II(0x1010bdbd, 0x5)   calld(0x10105b00, -0x62c2);           /* call 0x10105b00 */
    II(0x1010bdc2, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1010bdc4, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1010bdc5, 0x1)   popd(edi);                            /* pop edi */
    II(0x1010bdc6, 0x1)   popd(esi);                            /* pop esi */
    II(0x1010bdc7, 0x1)   popd(edx);                            /* pop edx */
    II(0x1010bdc8, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1010bdc9, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1010bdca, 0x1)   retd();                               /* ret */
FUNC_END

