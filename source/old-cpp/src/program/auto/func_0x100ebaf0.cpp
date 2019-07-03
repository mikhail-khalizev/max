FUNC_BEGIN(0x100ebaf0, 0xc4c9838aafc2927c, 0x20, ({0x68, 0x1c, 0, 0, 0, 0xe8, 0x58, 0xa2, 0x7, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0, 0, 0, 0, 0xb9, 0xc7, 0, 0, 0, 0xbb, 0xac, 0, 0, 0, 0xba, 0xa2, 0, 0, 0, 0xb8, 0x7c, 0x36, 0x1c, 0x10, 0xe8, 0x83, 0x98, 0xfe, 0xff, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100ebaf0, 0x5)   pushd(0x1c);                          /* push dword 0x1c */
    II(0x100ebaf5, 0x5)   calld(sys_check_available_stack_size, 0x7a258); /* call 0x10165d52 */
    II(0x100ebafa, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100ebafb, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ebafc, 0x1)   pushd(edx);                           /* push edx */
    II(0x100ebafd, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ebafe, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ebaff, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ebb00, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ebb02, 0x6)   sub(esp, 0);                          /* sub esp, 0x0 */
    II(0x100ebb08, 0x5)   mov(ecx, 0xc7);                       /* mov ecx, 0xc7 */
    II(0x100ebb0d, 0x5)   mov(ebx, 0xac);                       /* mov ebx, 0xac */
    II(0x100ebb12, 0x5)   mov(edx, 0xa2);                       /* mov edx, 0xa2 */
    II(0x100ebb17, 0x5)   mov(eax, 0x101c367c);                 /* mov eax, 0x101c367c */
    II(0x100ebb1c, 0x5)   calld(0x100d53a4, -0x1677d);          /* call 0x100d53a4 */
    II(0x100ebb21, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ebb22, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ebb23, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ebb24, 0x1)   popd(edx);                            /* pop edx */
    II(0x100ebb25, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ebb26, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ebb27, 0x1)   retd();                               /* ret */
FUNC_END

