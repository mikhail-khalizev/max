FUNC_BEGIN(my_strobj_set_len, 0x7df2b286d5103202, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x5c, 0x38, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x55, 0xf8, 0x66, 0x89, 0x42, 0x6, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x101424ec, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x101424f1, 0x5)   calld(sys_check_available_stack_size, 0x2385c); /* call 0x10165d52 */
    II(0x101424f6, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101424f7, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101424f8, 0x1)   pushd(esi);                           /* push esi */
    II(0x101424f9, 0x1)   pushd(edi);                           /* push edi */
    II(0x101424fa, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101424fb, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101424fd, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10142503, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10142506, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x10142509, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014250c, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x1014250f, 0x4)   mov(memw_a32(ds, edx + 0x6), ax);     /* mov [edx+0x6], ax */
    II(0x10142513, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10142515, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10142516, 0x1)   popd(edi);                            /* pop edi */
    II(0x10142517, 0x1)   popd(esi);                            /* pop esi */
    II(0x10142518, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10142519, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1014251a, 0x1)   retd();                               /* ret */
FUNC_END

