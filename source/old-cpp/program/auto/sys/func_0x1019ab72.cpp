FUNC_BEGIN(/* sys */ 0x1019ab72, 0xf105742a4789c967, 0x20, ({0x53, 0x51, 0x52, 0x89, 0xc3, 0xf6, 0xc3, 0x3, 0x75, 0x2b, 0x89, 0xc2, 0xb9, 0x64, 0, 0, 0, 0xc1, 0xfa, 0x1f, 0xf7, 0xf9, 0x85, 0xd2, 0x74, 0x9, 0xb8, 0x1, 0, 0, 0, 0x5a, 0x59, 0x5b, 0xc3, 0xb9, 0x90, 0x1, 0, 0, 0x89, 0xda, 0x89, 0xd8, 0xc1, 0xfa, 0x1f, 0xf7, 0xf9, 0x85, 0xd2, 0x74, 0xe5, 0x31, 0xc0, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1019ab72, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1019ab73, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1019ab74, 0x1)   pushd(edx);                           /* push edx */
    II(0x1019ab75, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x1019ab77, 0x3)   test(bl, 0x3);                        /* test bl, 0x3 */
    II(0x1019ab7a, 0x2)   jnzd(0x1019aba7, 0x2b);               /* jnz 0x1019aba7 */
    II(0x1019ab7c, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1019ab7e, 0x5)   mov(ecx, 0x64);                       /* mov ecx, 0x64 */
    II(0x1019ab83, 0x3)   sar(edx, 0x1f);                       /* sar edx, 0x1f */
    II(0x1019ab86, 0x2)   idiv(ecx);                            /* idiv ecx */
    II(0x1019ab88, 0x2)   test(edx, edx);                       /* test edx, edx */
    II(0x1019ab8a, 0x2)   jzd(0x1019ab95, 0x9);                 /* jz 0x1019ab95 */
l_0x1019ab8c:
    II(0x1019ab8c, 0x5)   mov(eax, 0x1);                        /* mov eax, 0x1 */
    II(0x1019ab91, 0x1)   popd(edx);                            /* pop edx */
    II(0x1019ab92, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1019ab93, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1019ab94, 0x1)   retd();                               /* ret */
l_0x1019ab95:
    II(0x1019ab95, 0x5)   mov(ecx, 0x190);                      /* mov ecx, 0x190 */
    II(0x1019ab9a, 0x2)   mov(edx, ebx);                        /* mov edx, ebx */
    II(0x1019ab9c, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x1019ab9e, 0x3)   sar(edx, 0x1f);                       /* sar edx, 0x1f */
    II(0x1019aba1, 0x2)   idiv(ecx);                            /* idiv ecx */
    II(0x1019aba3, 0x2)   test(edx, edx);                       /* test edx, edx */
    II(0x1019aba5, 0x2)   jzd(0x1019ab8c, -0x1b);               /* jz 0x1019ab8c */
l_0x1019aba7:
    II(0x1019aba7, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1019aba9, 0x1)   popd(edx);                            /* pop edx */
    II(0x1019abaa, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1019abab, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1019abac, 0x1)   retd();                               /* ret */
FUNC_END

