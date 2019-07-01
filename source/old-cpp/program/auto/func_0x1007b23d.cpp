FUNC_BEGIN(0x1007b23d, 0xa99e777d5d3a66f2, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xb, 0xab, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc6, 0x45, 0xf8, 0x14, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1007b23d, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1007b242, 0x5)   calld(sys_check_available_stack_size, 0xeab0b); /* call 0x10165d52 */
    II(0x1007b247, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1007b248, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1007b249, 0x1)   pushd(edx);                           /* push edx */
    II(0x1007b24a, 0x1)   pushd(esi);                           /* push esi */
    II(0x1007b24b, 0x1)   pushd(edi);                           /* push edi */
    II(0x1007b24c, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1007b24d, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1007b24f, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1007b255, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1007b258, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x14);   /* mov byte [ebp-0x8], 0x14 */
    II(0x1007b25c, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x1007b25f, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1007b261, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1007b262, 0x1)   popd(edi);                            /* pop edi */
    II(0x1007b263, 0x1)   popd(esi);                            /* pop esi */
    II(0x1007b264, 0x1)   popd(edx);                            /* pop edx */
    II(0x1007b265, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1007b266, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1007b267, 0x1)   retd();                               /* ret */
FUNC_END

