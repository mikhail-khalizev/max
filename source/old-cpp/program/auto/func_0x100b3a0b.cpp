FUNC_BEGIN(0x100b3a0b, 0x567fd10ba295ca5c, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x3d, 0x23, 0xb, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xba, 0xe1, 0x10, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x9a, 0x24, 0xb, 0, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100b3a0b, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100b3a10, 0x5)   calld(sys_check_available_stack_size, 0xb233d); /* call 0x10165d52 */
    II(0x100b3a15, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b3a16, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b3a17, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b3a18, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b3a19, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b3a1a, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b3a1c, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100b3a22, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100b3a25, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100b3a28, 0x5)   mov(edx, 0x101a10e1);                 /* mov edx, 0x101a10e1 */ /* "Activate unit" */
    II(0x100b3a2d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b3a30, 0x5)   calld(sys_strcpy, 0xb249a);           /* call 0x10165ecf */
    II(0x100b3a35, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b3a38, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100b3a3b, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100b3a3e, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b3a40, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b3a41, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b3a42, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b3a43, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b3a44, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b3a45, 0x1)   retd();                               /* ret */
FUNC_END

