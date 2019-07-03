FUNC_BEGIN(0x1014530b, 0xb17389aacd218841, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x3d, 0xa, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xba, 0xde, 0xcf, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x1e, 0xfe, 0xff, 0xff, 0xc7, 0x45, 0xf8, 0, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1014530b, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10145310, 0x5)   calld(sys_check_available_stack_size, 0x20a3d); /* call 0x10165d52 */
    II(0x10145315, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10145316, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10145317, 0x1)   pushd(edx);                           /* push edx */
    II(0x10145318, 0x1)   pushd(esi);                           /* push esi */
    II(0x10145319, 0x1)   pushd(edi);                           /* push edi */
    II(0x1014531a, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1014531b, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1014531d, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10145323, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10145326, 0x5)   mov(edx, 0x101acfde);                 /* mov edx, 0x101acfde */ /* "Expecting a pointer" */
//    II(0x1014532b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014532e, 0x5)   calld(0x10145151, -0x1e2);            /* call 0x10145151 */
    II(0x10145333, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0);      /* mov dword [ebp-0x8], 0x0 */
    II(0x1014533a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014533d, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1014533f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10145340, 0x1)   popd(edi);                            /* pop edi */
    II(0x10145341, 0x1)   popd(esi);                            /* pop esi */
    II(0x10145342, 0x1)   popd(edx);                            /* pop edx */
    II(0x10145343, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10145344, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10145345, 0x1)   retd();                               /* ret */
FUNC_END

