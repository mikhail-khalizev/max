FUNC_BEGIN(0x10145256, 0x21e94ecf398fc497, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xf2, 0xa, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xba, 0xa7, 0xcf, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0xd3, 0xfe, 0xff, 0xff, 0xc7, 0x45, 0xf8, 0, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10145256, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1014525b, 0x5)   calld(sys_check_available_stack_size, 0x20af2); /* call 0x10165d52 */
    II(0x10145260, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10145261, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10145262, 0x1)   pushd(edx);                           /* push edx */
    II(0x10145263, 0x1)   pushd(esi);                           /* push esi */
    II(0x10145264, 0x1)   pushd(edi);                           /* push edi */
    II(0x10145265, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10145266, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10145268, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1014526e, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10145271, 0x5)   mov(edx, 0x101acfa7);                 /* mov edx, 0x101acfa7 */ /* "Expecting a number" */
//    II(0x10145276, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10145279, 0x5)   calld(0x10145151, -0x12d);            /* call 0x10145151 */
    II(0x1014527e, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0);      /* mov dword [ebp-0x8], 0x0 */
    II(0x10145285, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10145288, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1014528a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1014528b, 0x1)   popd(edi);                            /* pop edi */
    II(0x1014528c, 0x1)   popd(esi);                            /* pop esi */
    II(0x1014528d, 0x1)   popd(edx);                            /* pop edx */
    II(0x1014528e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1014528f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10145290, 0x1)   retd();                               /* ret */
FUNC_END

