FUNC_BEGIN(0x1013be76, 0x5f8a68236ba9b840, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xd2, 0x9e, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x4, 0xe8, 0xbc, 0x8, 0, 0, 0x83, 0xe8, 0x4, 0x89, 0x45, 0xfc, 0x8d, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xfc, 0xc7, 0, 0, 0, 0, 0, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1013be76, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x1013be7b, 0x5)   calld(sys_check_available_stack_size, 0x29ed2); /* call 0x10165d52 */
    II(0x1013be80, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013be81, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013be82, 0x1)   pushd(edx);                           /* push edx */
    II(0x1013be83, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013be84, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013be85, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013be86, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013be88, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1013be8e, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1013be91, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013be94, 0x3)   add(eax, 0x4);                        /* add eax, 0x4 */
    II(0x1013be97, 0x5)   calld(0x1013c758, 0x8bc);             /* call 0x1013c758 */
    II(0x1013be9c, 0x3)   sub(eax, 0x4);                        /* sub eax, 0x4 */
    II(0x1013be9f, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1013bea2, 0x3)   lea(eax, ebp - 0x4);                  /* lea eax, [ebp-0x4] */
    II(0x1013bea5, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1013bea8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013beab, 0x6)   mov(memd_a32(ds, eax), 0);            /* mov dword [eax], 0x0 */
    II(0x1013beb1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013beb4, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1013beb7, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1013beba, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013bebc, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013bebd, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013bebe, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013bebf, 0x1)   popd(edx);                            /* pop edx */
    II(0x1013bec0, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013bec1, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013bec2, 0x1)   retd();                               /* ret */
FUNC_END

