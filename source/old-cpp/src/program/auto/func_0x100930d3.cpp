FUNC_BEGIN(0x100930d3, 0xe381ae8f6477ea8c, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x75, 0x2c, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc6, 0x45, 0xf8, 0x1, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100930d3, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100930d8, 0x5)   calld(sys_check_available_stack_size, 0xd2c75); /* call 0x10165d52 */
    II(0x100930dd, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100930de, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100930df, 0x1)   pushd(edx);                           /* push edx */
    II(0x100930e0, 0x1)   pushd(esi);                           /* push esi */
    II(0x100930e1, 0x1)   pushd(edi);                           /* push edi */
    II(0x100930e2, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100930e3, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100930e5, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100930eb, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100930ee, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x1);    /* mov byte [ebp-0x8], 0x1 */
    II(0x100930f2, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x100930f5, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100930f7, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100930f8, 0x1)   popd(edi);                            /* pop edi */
    II(0x100930f9, 0x1)   popd(esi);                            /* pop esi */
    II(0x100930fa, 0x1)   popd(edx);                            /* pop edx */
    II(0x100930fb, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100930fc, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100930fd, 0x1)   retd();                               /* ret */
FUNC_END

