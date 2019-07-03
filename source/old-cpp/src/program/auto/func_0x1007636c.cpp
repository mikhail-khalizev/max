FUNC_BEGIN(0x1007636c, 0x19c9126ed7175c90, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xdc, 0xf9, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0xa1, 0x8, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1007636c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10076371, 0x5)   calld(sys_check_available_stack_size, 0xef9dc); /* call 0x10165d52 */
    II(0x10076376, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10076377, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10076378, 0x1)   pushd(edx);                           /* push edx */
    II(0x10076379, 0x1)   pushd(esi);                           /* push esi */
    II(0x1007637a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1007637b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1007637c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1007637e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10076384, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10076387, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1007638a, 0x5)   calld(0x10076c30, 0x8a1);             /* call 0x10076c30 */
    II(0x1007638f, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10076392, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10076395, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10076397, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10076398, 0x1)   popd(edi);                            /* pop edi */
    II(0x10076399, 0x1)   popd(esi);                            /* pop esi */
    II(0x1007639a, 0x1)   popd(edx);                            /* pop edx */
    II(0x1007639b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1007639c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1007639d, 0x1)   retd();                               /* ret */
FUNC_END

