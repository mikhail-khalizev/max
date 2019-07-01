FUNC_BEGIN(0x10145346, 0x8726d6ebdf308abf, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x2, 0xa, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xba, 0xf2, 0xcf, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0xe3, 0xfd, 0xff, 0xff, 0xc7, 0x45, 0xf8, 0, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10145346, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1014534b, 0x5)   calld(sys_check_available_stack_size, 0x20a02); /* call 0x10165d52 */
    II(0x10145350, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10145351, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10145352, 0x1)   pushd(edx);                           /* push edx */
    II(0x10145353, 0x1)   pushd(esi);                           /* push esi */
    II(0x10145354, 0x1)   pushd(edi);                           /* push edi */
    II(0x10145355, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10145356, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10145358, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1014535e, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10145361, 0x5)   mov(edx, 0x101acff2);                 /* mov edx, 0x101acff2 */ /* "Expecting a {" */
//    II(0x10145366, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10145369, 0x5)   calld(0x10145151, -0x21d);            /* call 0x10145151 */
    II(0x1014536e, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0);      /* mov dword [ebp-0x8], 0x0 */
    II(0x10145375, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10145378, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1014537a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1014537b, 0x1)   popd(edi);                            /* pop edi */
    II(0x1014537c, 0x1)   popd(esi);                            /* pop esi */
    II(0x1014537d, 0x1)   popd(edx);                            /* pop edx */
    II(0x1014537e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1014537f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10145380, 0x1)   retd();                               /* ret */
FUNC_END

