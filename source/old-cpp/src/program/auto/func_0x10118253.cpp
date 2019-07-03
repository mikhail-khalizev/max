FUNC_BEGIN(0x10118253, 0x33f979c73698ed7a, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xf5, 0xda, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xc7, 0x45, 0xf4, 0, 0, 0, 0, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10118253, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10118258, 0x5)   calld(sys_check_available_stack_size, 0x4daf5); /* call 0x10165d52 */
    II(0x1011825d, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1011825e, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011825f, 0x1)   pushd(esi);                           /* push esi */
    II(0x10118260, 0x1)   pushd(edi);                           /* push edi */
    II(0x10118261, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10118262, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10118264, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1011826a, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1011826d, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x10118270, 0x7)   mov(memd_a32(ss, ebp - 0xc), 0);      /* mov dword [ebp-0xc], 0x0 */
    II(0x10118277, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1011827a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1011827c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011827d, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011827e, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011827f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10118280, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10118281, 0x1)   retd();                               /* ret */
FUNC_END

