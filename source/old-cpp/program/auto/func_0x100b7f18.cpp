FUNC_BEGIN(0x100b7f18, 0x9f409129b086496e, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x30, 0xde, 0xa, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0x38, 0, 0x74, 0x9, 0xc7, 0x45, 0xf8, 0, 0, 0, 0, 0xeb, 0x19, 0xb9, 0xae, 0, 0, 0, 0xbb, 0x68, 0xd, 0x1a, 0x10, 0xba, 0x73, 0xd, 0x1a, 0x10, 0x31, 0xc0, 0xe8, 0x38, 0xde, 0xa, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xfc, 0x8b, 0, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100b7f18, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x100b7f1d, 0x5)   calld(sys_check_available_stack_size, 0xade30); /* call 0x10165d52 */
    II(0x100b7f22, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b7f23, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b7f24, 0x1)   pushd(edx);                           /* push edx */
    II(0x100b7f25, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b7f26, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b7f27, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b7f28, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b7f2a, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100b7f30, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100b7f33, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b7f36, 0x3)   cmp(memd_a32(ds, eax), 0);            /* cmp dword [eax], 0x0 */
    II(0x100b7f39, 0x2)   jzd(0x100b7f44, 0x9);                 /* jz 0x100b7f44 */
    II(0x100b7f3b, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0);      /* mov dword [ebp-0x8], 0x0 */
    II(0x100b7f42, 0x2)   jmpd(0x100b7f5d, 0x19);               /* jmp 0x100b7f5d */
l_0x100b7f44:
    II(0x100b7f44, 0x5)   mov(ecx, 0xae);                       /* mov ecx, 0xae */
    II(0x100b7f49, 0x5)   mov(ebx, 0x101a0d68);                 /* mov ebx, 0x101a0d68 */ /* "smartptr.h" */
    II(0x100b7f4e, 0x5)   mov(edx, 0x101a0d73);                 /* mov edx, 0x101a0d73 */ /* "ptr != 0" */
    II(0x100b7f53, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x100b7f55, 0x5)   calld(sys_assert, 0xade38);           /* call 0x10165d92 */
    II(0x100b7f5a, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
l_0x100b7f5d:
    II(0x100b7f5d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b7f60, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x100b7f62, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100b7f65, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100b7f68, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b7f6a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b7f6b, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b7f6c, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b7f6d, 0x1)   popd(edx);                            /* pop edx */
    II(0x100b7f6e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b7f6f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b7f70, 0x1)   retd();                               /* ret */
FUNC_END

