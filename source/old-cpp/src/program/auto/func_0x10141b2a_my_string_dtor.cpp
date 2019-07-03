FUNC_BEGIN(my_string_dtor, 0x9638e73f5464a2d9, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x1e, 0x42, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x8b, 0, 0xe8, 0xcb, 0x8, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10141b2a, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10141b2f, 0x5)   calld(sys_check_available_stack_size, 0x2421e); /* call 0x10165d52 */
    II(0x10141b34, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10141b35, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10141b36, 0x1)   pushd(esi);                           /* push esi */
    II(0x10141b37, 0x1)   pushd(edi);                           /* push edi */
    II(0x10141b38, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10141b39, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10141b3b, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10141b41, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10141b44, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10141b47, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141b4a, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10141b4c, 0x5)   calld(my_string_release, 0x8cb);      /* call 0x1014241c */
    II(0x10141b51, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141b54, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x10141b57, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10141b5a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10141b5c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10141b5d, 0x1)   popd(edi);                            /* pop edi */
    II(0x10141b5e, 0x1)   popd(esi);                            /* pop esi */
    II(0x10141b5f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10141b60, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10141b61, 0x1)   retd();                               /* ret */
FUNC_END

