FUNC_BEGIN(0x1009e44d, 0x71817908c146f1de, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xfb, 0x78, 0xc, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xba, 0x97, 0x7, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x58, 0x7a, 0xc, 0, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1009e44d, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1009e452, 0x5)   calld(sys_check_available_stack_size, 0xc78fb); /* call 0x10165d52 */
    II(0x1009e457, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009e458, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009e459, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009e45a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009e45b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009e45c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009e45e, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1009e464, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1009e467, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1009e46a, 0x5)   mov(edx, 0x101a0797);                 /* mov edx, 0x101a0797 */ /* "Survey" */
    II(0x1009e46f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1009e472, 0x5)   calld(sys_strcpy, 0xc7a58);           /* call 0x10165ecf */
    II(0x1009e477, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1009e47a, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1009e47d, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1009e480, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009e482, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009e483, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009e484, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009e485, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009e486, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009e487, 0x1)   retd();                               /* ret */
FUNC_END

