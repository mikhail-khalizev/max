FUNC_BEGIN(my_strobj_c_str_v2, 0x60c742ebf6e0df7f, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x80, 0xc5, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0, 0xe8, 0xf, 0, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100897c8, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100897cd, 0x5)   calld(sys_check_available_stack_size, 0xdc580); /* call 0x10165d52 */
    II(0x100897d2, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100897d3, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100897d4, 0x1)   pushd(edx);                           /* push edx */
    II(0x100897d5, 0x1)   pushd(esi);                           /* push esi */
    II(0x100897d6, 0x1)   pushd(edi);                           /* push edi */
    II(0x100897d7, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100897d8, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100897da, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100897e0, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100897e3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100897e6, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x100897e8, 0x5)   calld(my_strobj_c_str, 0xf);          /* call 0x100897fc */
    II(0x100897ed, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100897f0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100897f3, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100897f5, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100897f6, 0x1)   popd(edi);                            /* pop edi */
    II(0x100897f7, 0x1)   popd(esi);                            /* pop esi */
    II(0x100897f8, 0x1)   popd(edx);                            /* pop edx */
    II(0x100897f9, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100897fa, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100897fb, 0x1)   retd();                               /* ret */
FUNC_END

