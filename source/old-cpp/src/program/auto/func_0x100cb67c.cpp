FUNC_BEGIN(0x100cb67c, 0xe317d349a096a756, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xcc, 0xa6, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x40, 0x6, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100cb67c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100cb681, 0x5)   calld(sys_check_available_stack_size, 0x9a6cc); /* call 0x10165d52 */
    II(0x100cb686, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cb687, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cb688, 0x1)   pushd(edx);                           /* push edx */
    II(0x100cb689, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cb68a, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cb68b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cb68c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cb68e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100cb694, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100cb697, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cb69a, 0x4)   mov(ax, memw_a32(ds, eax + 0x6));     /* mov ax, [eax+0x6] */
    II(0x100cb69e, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100cb6a1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100cb6a4, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cb6a6, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cb6a7, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cb6a8, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cb6a9, 0x1)   popd(edx);                            /* pop edx */
    II(0x100cb6aa, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cb6ab, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cb6ac, 0x1)   retd();                               /* ret */
FUNC_END

