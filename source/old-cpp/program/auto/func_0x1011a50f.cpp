FUNC_BEGIN(0x1011a50f, 0xa3da45d82953000d, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x39, 0xb8, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x80, 0x78, 0x3e, 0x5, 0x75, 0x13, 0xe8, 0x56, 0x65, 0, 0, 0x31, 0xd2, 0x88, 0xc2, 0x8b, 0x45, 0xfc, 0xe8, 0xd1, 0x4a, 0x3, 0, 0xeb, 0x20, 0x8b, 0x45, 0xf8, 0x66, 0xc7, 0x40, 0x16, 0, 0, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x18, 0xe8, 0x30, 0x66, 0, 0, 0x31, 0xdb, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0xe8, 0x3b, 0x7, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1011a50f, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1011a514, 0x5)   calld(sys_check_available_stack_size, 0x4b839); /* call 0x10165d52 */
    II(0x1011a519, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1011a51a, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011a51b, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011a51c, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011a51d, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011a51e, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1011a520, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1011a526, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1011a529, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1011a52c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1011a52f, 0x4)   cmp(memb_a32(ds, eax + 0x3e), 0x5);   /* cmp byte [eax+0x3e], 0x5 */
    II(0x1011a533, 0x2)   jnzd(0x1011a548, 0x13);               /* jnz 0x1011a548 */
    II(0x1011a535, 0x5)   calld(0x10120a90, 0x6556);            /* call 0x10120a90 */
    II(0x1011a53a, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1011a53c, 0x2)   mov(dl, al);                          /* mov dl, al */
    II(0x1011a53e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1011a541, 0x5)   calld(0x1014f017, 0x34ad1);           /* call 0x1014f017 */
    II(0x1011a546, 0x2)   jmpd(0x1011a568, 0x20);               /* jmp 0x1011a568 */
l_0x1011a548:
    II(0x1011a548, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011a54b, 0x6)   mov(memw_a32(ds, eax + 0x16), 0);     /* mov word [eax+0x16], 0x0 */
    II(0x1011a551, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011a554, 0x3)   add(eax, 0x18);                       /* add eax, 0x18 */
    II(0x1011a557, 0x5)   calld(0x10120b8c, 0x6630);            /* call 0x10120b8c */
    II(0x1011a55c, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x1011a55e, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1011a560, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011a563, 0x5)   calld(0x1011aca3, 0x73b);             /* call 0x1011aca3 */
l_0x1011a568:
    II(0x1011a568, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1011a56a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011a56b, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011a56c, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011a56d, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1011a56e, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1011a56f, 0x1)   retd();                               /* ret */
FUNC_END

