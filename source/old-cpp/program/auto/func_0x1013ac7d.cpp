FUNC_BEGIN(0x1013ac7d, 0xaecdcd67130f4cb2, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xcb, 0xb0, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x86, 0x1, 0, 0, 0x8b, 0x45, 0xf8, 0x8b, 0, 0xe8, 0x28, 0x1, 0, 0, 0x8b, 0x45, 0xfc, 0x8b, 0x55, 0xf8, 0x89, 0x2, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1013ac7d, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1013ac82, 0x5)   calld(sys_check_available_stack_size, 0x2b0cb); /* call 0x10165d52 */
    II(0x1013ac87, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013ac88, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013ac89, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013ac8a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013ac8b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013ac8c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013ac8e, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1013ac94, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1013ac97, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1013ac9a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013ac9d, 0x5)   calld(0x1013ae28, 0x186);             /* call 0x1013ae28 */
    II(0x1013aca2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013aca5, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1013aca7, 0x5)   calld(0x1013add4, 0x128);             /* call 0x1013add4 */
    II(0x1013acac, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013acaf, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x1013acb2, 0x2)   mov(memd_a32(ds, edx), eax);          /* mov [edx], eax */
    II(0x1013acb4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013acb7, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1013acba, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1013acbd, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013acbf, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013acc0, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013acc1, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013acc2, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013acc3, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013acc4, 0x1)   retd();                               /* ret */
FUNC_END

