FUNC_BEGIN(0x10123334, 0x7a068c901b8d4314, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x14, 0x2a, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x7d, 0xf8, 0x8b, 0x75, 0xfc, 0x66, 0xa5, 0xa4, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10123334, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10123339, 0x5)   calld(sys_check_available_stack_size, 0x42a14); /* call 0x10165d52 */
    II(0x1012333e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1012333f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10123340, 0x1)   pushd(esi);                           /* push esi */
    II(0x10123341, 0x1)   pushd(edi);                           /* push edi */
    II(0x10123342, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10123343, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10123345, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1012334b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1012334e, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x10123351, 0x3)   mov(edi, memd_a32(ss, ebp - 0x8));    /* mov edi, [ebp-0x8] */
    II(0x10123354, 0x3)   mov(esi, memd_a32(ss, ebp - 0x4));    /* mov esi, [ebp-0x4] */
    II(0x10123357, 0x2)   movsw_a32();                          /* movsw */
    II(0x10123359, 0x1)   movsb_a32();                          /* movsb */
    II(0x1012335a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1012335d, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x10123360, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10123363, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10123365, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10123366, 0x1)   popd(edi);                            /* pop edi */
    II(0x10123367, 0x1)   popd(esi);                            /* pop esi */
    II(0x10123368, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10123369, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1012336a, 0x1)   retd();                               /* ret */
FUNC_END

