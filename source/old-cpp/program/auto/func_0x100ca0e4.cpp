FUNC_BEGIN(0x100ca0e4, 0x81098dfe8484b3ba, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x64, 0xbc, 0x9, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xbb, 0x24, 0x57, 0x1b, 0x10, 0xba, 0xa, 0, 0, 0, 0x8b, 0x45, 0xf8, 0xe8, 0xcd, 0xbe, 0x9, 0, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100ca0e4, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100ca0e9, 0x5)   calld(sys_check_available_stack_size, 0x9bc64); /* call 0x10165d52 */
    II(0x100ca0ee, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100ca0ef, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ca0f0, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ca0f1, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ca0f2, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ca0f3, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ca0f5, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100ca0fb, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100ca0fe, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100ca101, 0x5)   mov(ebx, 0x101b5724);                 /* mov ebx, 0x101b5724 */
    II(0x100ca106, 0x5)   mov(edx, 0xa);                        /* mov edx, 0xa */
//    II(0x100ca10b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ca10e, 0x5)   calld(sys_call_dtor_arr_v2, 0x9becd); /* call 0x10165fe0 */
    II(0x100ca113, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100ca116, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100ca119, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ca11b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ca11c, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ca11d, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ca11e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ca11f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ca120, 0x1)   retd();                               /* ret */
FUNC_END

