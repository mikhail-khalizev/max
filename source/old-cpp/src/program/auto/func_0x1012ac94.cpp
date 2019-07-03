FUNC_BEGIN(0x1012ac94, 0x84f921c00f0d9c77, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xb4, 0xb0, 0x3, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0xe8, 0x3c, 0xc9, 0xff, 0xff, 0x8b, 0x15, 0xcc, 0x59, 0x1c, 0x10, 0x31, 0xc0, 0x8a, 0x42, 0xe, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1012ac94, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1012ac99, 0x5)   calld(sys_check_available_stack_size, 0x3b0b4); /* call 0x10165d52 */
    II(0x1012ac9e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1012ac9f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1012aca0, 0x1)   pushd(edx);                           /* push edx */
    II(0x1012aca1, 0x1)   pushd(esi);                           /* push esi */
    II(0x1012aca2, 0x1)   pushd(edi);                           /* push edi */
    II(0x1012aca3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1012aca4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1012aca6, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1012acac, 0x5)   calld(0x101275ed, -0x36c4);           /* call 0x101275ed */
    II(0x1012acb1, 0x6)   mov(edx, memd_a32(ds, 0x101c59cc));   /* mov edx, [0x101c59cc] */
    II(0x1012acb7, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1012acb9, 0x3)   mov(al, memb_a32(ds, edx + 0xe));     /* mov al, [edx+0xe] */
    II(0x1012acbc, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1012acbf, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1012acc2, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1012acc4, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1012acc5, 0x1)   popd(edi);                            /* pop edi */
    II(0x1012acc6, 0x1)   popd(esi);                            /* pop esi */
    II(0x1012acc7, 0x1)   popd(edx);                            /* pop edx */
    II(0x1012acc8, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1012acc9, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1012acca, 0x1)   retd();                               /* ret */
FUNC_END

