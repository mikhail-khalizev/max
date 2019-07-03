FUNC_BEGIN(0x101157d4, 0x8c9f296f6154eb2b, 0x20, ({0x68, 0x1c, 0, 0, 0, 0xe8, 0x74, 0x5, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0, 0, 0, 0, 0x31, 0xd2, 0xb8, 0xb3, 0x6, 0, 0, 0xe8, 0x73, 0xfd, 0xff, 0xff, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101157d4, 0x5)   pushd(0x1c);                          /* push dword 0x1c */
    II(0x101157d9, 0x5)   calld(sys_check_available_stack_size, 0x50574); /* call 0x10165d52 */
    II(0x101157de, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101157df, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101157e0, 0x1)   pushd(edx);                           /* push edx */
    II(0x101157e1, 0x1)   pushd(esi);                           /* push esi */
    II(0x101157e2, 0x1)   pushd(edi);                           /* push edi */
    II(0x101157e3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101157e4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101157e6, 0x6)   sub(esp, 0);                          /* sub esp, 0x0 */
    II(0x101157ec, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x101157ee, 0x5)   mov(eax, 0x6b3);                      /* mov eax, 0x6b3 */
    II(0x101157f3, 0x5)   calld(0x1011556b, -0x28d);            /* call 0x1011556b */
    II(0x101157f8, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101157f9, 0x1)   popd(edi);                            /* pop edi */
    II(0x101157fa, 0x1)   popd(esi);                            /* pop esi */
    II(0x101157fb, 0x1)   popd(edx);                            /* pop edx */
    II(0x101157fc, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101157fd, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101157fe, 0x1)   retd();                               /* ret */
FUNC_END

