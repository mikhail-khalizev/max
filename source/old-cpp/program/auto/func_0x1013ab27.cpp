FUNC_BEGIN(0x1013ab27, 0xf35962b2ea649667, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x21, 0xb2, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xf7, 0x45, 0xfc, 0x4, 0, 0, 0, 0x74, 0x14, 0xba, 0xb0, 0x6e, 0x1b, 0x10, 0x8b, 0x45, 0xf8, 0xe8, 0x5e, 0xb4, 0x2, 0, 0xe8, 0x79, 0xb4, 0x2, 0, 0xeb, 0x51, 0x8b, 0x45, 0xf8, 0xc7, 0x40, 0x2, 0xc4, 0x6e, 0x1b, 0x10, 0x8b, 0x45, 0xf8, 0xf, 0xbf, 0, 0x85, 0xc0, 0x74, 0x2c, 0x8b, 0x45, 0xf8, 0xf, 0xbf, 0, 0x85, 0xc0, 0x75, 0x9, 0xc7, 0x45, 0xf0, 0, 0, 0, 0, 0xeb, 0x19, 0xb9, 0x24, 0, 0, 0, 0xbb, 0x20, 0xcc, 0x1a, 0x10, 0xba, 0x2d, 0xcc, 0x1a, 0x10, 0x31, 0xc0, 0xe8, 0xf4, 0xb1, 0x2, 0, 0x89, 0x45, 0xf0, 0xf7, 0x45, 0xfc, 0x2, 0, 0, 0, 0x74, 0x8, 0x8b, 0x45, 0xf8, 0xe8, 0xb2, 0xb3, 0x2, 0, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1013ab27, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x1013ab2c, 0x5)   calld(sys_check_available_stack_size, 0x2b221); /* call 0x10165d52 */
    II(0x1013ab31, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013ab32, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013ab33, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013ab34, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013ab35, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013ab36, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013ab38, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x1013ab3e, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1013ab41, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1013ab44, 0x7)   test(memd_a32(ss, ebp - 0x4), 0x4);   /* test dword [ebp-0x4], 0x4 */
    II(0x1013ab4b, 0x2)   jzd(0x1013ab61, 0x14);                /* jz 0x1013ab61 */
    II(0x1013ab4d, 0x5)   mov(edx, 0x101b6eb0);                 /* mov edx, 0x101b6eb0 */
    II(0x1013ab52, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013ab55, 0x5)   calld(sys_call_dtor_arr, 0x2b45e);    /* call 0x10165fb8 */
    II(0x1013ab5a, 0x5)   calld(sys_delete_arr, 0x2b479);       /* call 0x10165fd8 */
    II(0x1013ab5f, 0x2)   jmpd(0x1013abb2, 0x51);               /* jmp 0x1013abb2 */
l_0x1013ab61:
    II(0x1013ab61, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013ab64, 0x7)   mov(memd_a32(ds, eax + 0x2), 0x101b6ec4); /* mov dword [eax+0x2], 0x101b6ec4 */
    II(0x1013ab6b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013ab6e, 0x3)   movsx(eax, memw_a32(ds, eax));        /* movsx eax, word [eax] */
    II(0x1013ab71, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1013ab73, 0x2)   jzd(0x1013aba1, 0x2c);                /* jz 0x1013aba1 */
    II(0x1013ab75, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013ab78, 0x3)   movsx(eax, memw_a32(ds, eax));        /* movsx eax, word [eax] */
    II(0x1013ab7b, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1013ab7d, 0x2)   jnzd(0x1013ab88, 0x9);                /* jnz 0x1013ab88 */
    II(0x1013ab7f, 0x7)   mov(memd_a32(ss, ebp - 0x10), 0);     /* mov dword [ebp-0x10], 0x0 */
    II(0x1013ab86, 0x2)   jmpd(0x1013aba1, 0x19);               /* jmp 0x1013aba1 */
l_0x1013ab88:
    II(0x1013ab88, 0x5)   mov(ecx, 0x24);                       /* mov ecx, 0x24 */
    II(0x1013ab8d, 0x5)   mov(ebx, 0x101acc20);                 /* mov ebx, 0x101acc20 */ /* "smartptr.cpp" */
    II(0x1013ab92, 0x5)   mov(edx, 0x101acc2d);                 /* mov edx, 0x101acc2d */ /* "reference_count == 0" */
    II(0x1013ab97, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1013ab99, 0x5)   calld(sys_assert, 0x2b1f4);           /* call 0x10165d92 */
    II(0x1013ab9e, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
l_0x1013aba1:
    II(0x1013aba1, 0x7)   test(memd_a32(ss, ebp - 0x4), 0x2);   /* test dword [ebp-0x4], 0x2 */
    II(0x1013aba8, 0x2)   jzd(0x1013abb2, 0x8);                 /* jz 0x1013abb2 */
    II(0x1013abaa, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013abad, 0x5)   calld(sys_delete, 0x2b3b2);           /* call 0x10165f64 */
l_0x1013abb2:
    II(0x1013abb2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013abb5, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1013abb8, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1013abbb, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013abbd, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013abbe, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013abbf, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013abc0, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013abc1, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013abc2, 0x1)   retd();                               /* ret */
FUNC_END

