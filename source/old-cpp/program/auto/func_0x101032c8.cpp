FUNC_BEGIN(0x101032c8, 0x815024dfc119be7, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x80, 0x2a, 0x6, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xba, 0xec, 0x63, 0x1b, 0x10, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x4, 0xe8, 0xc3, 0x2c, 0x6, 0, 0xe8, 0xde, 0x2c, 0x6, 0, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x101032c8, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x101032cd, 0x5)   calld(sys_check_available_stack_size, 0x62a80); /* call 0x10165d52 */
    II(0x101032d2, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101032d3, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101032d4, 0x1)   pushd(esi);                           /* push esi */
    II(0x101032d5, 0x1)   pushd(edi);                           /* push edi */
    II(0x101032d6, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101032d7, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101032d9, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x101032df, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x101032e2, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x101032e5, 0x5)   mov(edx, 0x101b63ec);                 /* mov edx, 0x101b63ec */
//    II(0x101032ea, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101032ed, 0x3)   mov(eax, memd_a32(ds, eax + 0x4));    /* mov eax, [eax+0x4] */
    II(0x101032f0, 0x5)   calld(sys_call_dtor_arr, 0x62cc3);    /* call 0x10165fb8 */
    II(0x101032f5, 0x5)   calld(sys_delete_arr, 0x62cde);       /* call 0x10165fd8 */
    II(0x101032fa, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101032fd, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x10103300, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10103303, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10103305, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10103306, 0x1)   popd(edi);                            /* pop edi */
    II(0x10103307, 0x1)   popd(esi);                            /* pop esi */
    II(0x10103308, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10103309, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1010330a, 0x1)   retd();                               /* ret */
FUNC_END

