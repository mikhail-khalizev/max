FUNC_BEGIN(0x100b8124, 0x7dc576d2fd20cd1e, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x24, 0xdc, 0xa, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x79, 0x2b, 0x8, 0, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100b8124, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100b8129, 0x5)   calld(sys_check_available_stack_size, 0xadc24); /* call 0x10165d52 */
    II(0x100b812e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b812f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b8130, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b8131, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b8132, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b8133, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b8135, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100b813b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100b813e, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100b8141, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x100b8144, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b8147, 0x5)   calld(0x1013acc5, 0x82b79);           /* call 0x1013acc5 */
    II(0x100b814c, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100b814f, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100b8152, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b8154, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b8155, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b8156, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b8157, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b8158, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b8159, 0x1)   retd();                               /* ret */
FUNC_END

