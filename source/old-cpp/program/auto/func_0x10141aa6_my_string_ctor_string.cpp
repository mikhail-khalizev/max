FUNC_BEGIN(my_string_ctor_string, 0x59a4d615257fbc60, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xa2, 0x42, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x10, 0x8b, 0x45, 0xf8, 0x89, 0x10, 0x8b, 0x45, 0xf8, 0x8b, 0, 0xe8, 0x8d, 0x9, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10141aa6, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10141aab, 0x5)   calld(sys_check_available_stack_size, 0x242a2); /* call 0x10165d52 */
    II(0x10141ab0, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10141ab1, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10141ab2, 0x1)   pushd(esi);                           /* push esi */
    II(0x10141ab3, 0x1)   pushd(edi);                           /* push edi */
    II(0x10141ab4, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10141ab5, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10141ab7, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10141abd, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10141ac0, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x10141ac3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10141ac6, 0x2)   mov(edx, memd_a32(ds, eax));          /* mov edx, [eax] */
    II(0x10141ac8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141acb, 0x2)   mov(memd_a32(ds, eax), edx);          /* mov [eax], edx */
    II(0x10141acd, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141ad0, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10141ad2, 0x5)   calld(my_string_add_ref, 0x98d);      /* call 0x10142464 */
    II(0x10141ad7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141ada, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x10141add, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10141ae0, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10141ae2, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10141ae3, 0x1)   popd(edi);                            /* pop edi */
    II(0x10141ae4, 0x1)   popd(esi);                            /* pop esi */
    II(0x10141ae5, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10141ae6, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10141ae7, 0x1)   retd();                               /* ret */
FUNC_END

