FUNC_BEGIN(0x100de97e, 0x99846298eeea2f23, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xca, 0x73, 0x8, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0xf0, 0xfa, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100de97e, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100de983, 0x5)   calld(sys_check_available_stack_size, 0x873ca); /* call 0x10165d52 */
    II(0x100de988, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100de989, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100de98a, 0x1)   pushd(esi);                           /* push esi */
    II(0x100de98b, 0x1)   pushd(edi);                           /* push edi */
    II(0x100de98c, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100de98d, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100de98f, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100de995, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100de998, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100de99b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100de99e, 0x5)   calld(0x100de493, -0x510);            /* call 0x100de493 */
    II(0x100de9a3, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100de9a5, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100de9a6, 0x1)   popd(edi);                            /* pop edi */
    II(0x100de9a7, 0x1)   popd(esi);                            /* pop esi */
    II(0x100de9a8, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100de9a9, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100de9aa, 0x1)   retd();                               /* ret */
FUNC_END

