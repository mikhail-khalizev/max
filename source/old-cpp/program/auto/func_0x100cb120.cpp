FUNC_BEGIN(0x100cb120, 0xbb7ac610a356685c, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x28, 0xac, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0xed, 0xba, 0xfa, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100cb120, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100cb125, 0x5)   calld(sys_check_available_stack_size, 0x9ac28); /* call 0x10165d52 */
    II(0x100cb12a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cb12b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cb12c, 0x1)   pushd(edx);                           /* push edx */
    II(0x100cb12d, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cb12e, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cb12f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cb130, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cb132, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100cb138, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100cb13b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cb13e, 0x5)   calld(0x10076c30, -0x54513);          /* call 0x10076c30 */
    II(0x100cb143, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100cb146, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100cb149, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cb14b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cb14c, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cb14d, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cb14e, 0x1)   popd(edx);                            /* pop edx */
    II(0x100cb14f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cb150, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cb151, 0x1)   retd();                               /* ret */
FUNC_END

