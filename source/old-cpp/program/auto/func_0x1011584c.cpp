FUNC_BEGIN(0x1011584c, 0x939c92646df27d0a, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xfc, 0x4, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0xe8, 0x51, 0x30, 0xfd, 0xff, 0x31, 0xd2, 0xf, 0xbf, 0x45, 0xfc, 0xe8, 0xf4, 0xfc, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1011584c, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10115851, 0x5)   calld(sys_check_available_stack_size, 0x504fc); /* call 0x10165d52 */
    II(0x10115856, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10115857, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10115858, 0x1)   pushd(edx);                           /* push edx */
    II(0x10115859, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011585a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011585b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011585c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1011585e, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10115864, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10115867, 0x5)   calld(0x100e88bd, -0x2cfaf);          /* call 0x100e88bd */
    II(0x1011586c, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1011586e, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x10115872, 0x5)   calld(0x1011556b, -0x30c);            /* call 0x1011556b */
    II(0x10115877, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10115879, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011587a, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011587b, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011587c, 0x1)   popd(edx);                            /* pop edx */
    II(0x1011587d, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1011587e, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1011587f, 0x1)   retd();                               /* ret */
FUNC_END

