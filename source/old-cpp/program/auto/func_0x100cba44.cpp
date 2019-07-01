FUNC_BEGIN(0x100cba44, 0x74ff6d9b5679c337, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x4, 0xa3, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc6, 0x45, 0xf8, 0x25, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100cba44, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100cba49, 0x5)   calld(sys_check_available_stack_size, 0x9a304); /* call 0x10165d52 */
    II(0x100cba4e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cba4f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cba50, 0x1)   pushd(edx);                           /* push edx */
    II(0x100cba51, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cba52, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cba53, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cba54, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cba56, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100cba5c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100cba5f, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x25);   /* mov byte [ebp-0x8], 0x25 */
    II(0x100cba63, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x100cba66, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cba68, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cba69, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cba6a, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cba6b, 0x1)   popd(edx);                            /* pop edx */
    II(0x100cba6c, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cba6d, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cba6e, 0x1)   retd();                               /* ret */
FUNC_END

