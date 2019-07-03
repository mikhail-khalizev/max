FUNC_BEGIN(0x100d6bb8, 0xdaaa1c638ff1a666, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x90, 0xf1, 0x8, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xc6, 0x45, 0xf4, 0, 0x8a, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100d6bb8, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100d6bbd, 0x5)   calld(sys_check_available_stack_size, 0x8f190); /* call 0x10165d52 */
    II(0x100d6bc2, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100d6bc3, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100d6bc4, 0x1)   pushd(esi);                           /* push esi */
    II(0x100d6bc5, 0x1)   pushd(edi);                           /* push edi */
    II(0x100d6bc6, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100d6bc7, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100d6bc9, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100d6bcf, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100d6bd2, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100d6bd5, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0);      /* mov byte [ebp-0xc], 0x0 */
    II(0x100d6bd9, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x100d6bdc, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100d6bde, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100d6bdf, 0x1)   popd(edi);                            /* pop edi */
    II(0x100d6be0, 0x1)   popd(esi);                            /* pop esi */
    II(0x100d6be1, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100d6be2, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100d6be3, 0x1)   retd();                               /* ret */
FUNC_END

