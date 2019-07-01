FUNC_BEGIN(0x100aaedc, 0x68569c65d1d1a1eb, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x6c, 0xae, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x31, 0xbd, 0xfc, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100aaedc, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100aaee1, 0x5)   calld(sys_check_available_stack_size, 0xbae6c); /* call 0x10165d52 */
    II(0x100aaee6, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100aaee7, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100aaee8, 0x1)   pushd(edx);                           /* push edx */
    II(0x100aaee9, 0x1)   pushd(esi);                           /* push esi */
    II(0x100aaeea, 0x1)   pushd(edi);                           /* push edi */
    II(0x100aaeeb, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100aaeec, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100aaeee, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100aaef4, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100aaef7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100aaefa, 0x5)   calld(0x10076c30, -0x342cf);          /* call 0x10076c30 */
    II(0x100aaeff, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100aaf02, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100aaf05, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100aaf07, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100aaf08, 0x1)   popd(edi);                            /* pop edi */
    II(0x100aaf09, 0x1)   popd(esi);                            /* pop esi */
    II(0x100aaf0a, 0x1)   popd(edx);                            /* pop edx */
    II(0x100aaf0b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100aaf0c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100aaf0d, 0x1)   retd();                               /* ret */
FUNC_END

