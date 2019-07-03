FUNC_BEGIN(0x101182a8, 0xd7c10afec3b854e7, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xa0, 0xda, 0x4, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x89, 0x5d, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x101182a8, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x101182ad, 0x5)   calld(sys_check_available_stack_size, 0x4daa0); /* call 0x10165d52 */
    II(0x101182b2, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101182b3, 0x1)   pushd(esi);                           /* push esi */
    II(0x101182b4, 0x1)   pushd(edi);                           /* push edi */
    II(0x101182b5, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101182b6, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101182b8, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x101182be, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x101182c1, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x101182c4, 0x3)   mov(memd_a32(ss, ebp - 0x4), ebx);    /* mov [ebp-0x4], ebx */
    II(0x101182c7, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101182c9, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101182ca, 0x1)   popd(edi);                            /* pop edi */
    II(0x101182cb, 0x1)   popd(esi);                            /* pop esi */
    II(0x101182cc, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101182cd, 0x1)   retd();                               /* ret */
FUNC_END

