FUNC_BEGIN(0x101182ce, 0xec713780cbc35808, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x7a, 0xda, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x101182ce, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x101182d3, 0x5)   calld(sys_check_available_stack_size, 0x4da7a); /* call 0x10165d52 */
    II(0x101182d8, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101182d9, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101182da, 0x1)   pushd(esi);                           /* push esi */
    II(0x101182db, 0x1)   pushd(edi);                           /* push edi */
    II(0x101182dc, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101182dd, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101182df, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x101182e5, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x101182e8, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x101182eb, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101182ed, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101182ee, 0x1)   popd(edi);                            /* pop edi */
    II(0x101182ef, 0x1)   popd(esi);                            /* pop esi */
    II(0x101182f0, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101182f1, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101182f2, 0x1)   retd();                               /* ret */
FUNC_END

