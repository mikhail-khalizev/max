FUNC_BEGIN(0x1013b0a5, 0x943f7e35690f4d97, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xa3, 0xac, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x5b, 0x2, 0, 0, 0x8b, 0x45, 0xf8, 0x83, 0x78, 0x6, 0, 0x74, 0x15, 0xba, 0xdc, 0x6e, 0x1b, 0x10, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x6, 0xe8, 0xd5, 0xae, 0x2, 0, 0xe8, 0xf0, 0xae, 0x2, 0, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1013b0a5, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1013b0aa, 0x5)   calld(sys_check_available_stack_size, 0x2aca3); /* call 0x10165d52 */
    II(0x1013b0af, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013b0b0, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013b0b1, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013b0b2, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013b0b3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013b0b4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013b0b6, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1013b0bc, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1013b0bf, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x1013b0c2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013b0c5, 0x5)   calld(0x1013b325, 0x25b);             /* call 0x1013b325 */
    II(0x1013b0ca, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013b0cd, 0x4)   cmp(memd_a32(ds, eax + 0x6), 0);      /* cmp dword [eax+0x6], 0x0 */
    II(0x1013b0d1, 0x2)   jzd(0x1013b0e8, 0x15);                /* jz 0x1013b0e8 */
    II(0x1013b0d3, 0x5)   mov(edx, 0x101b6edc);                 /* mov edx, 0x101b6edc */
    II(0x1013b0d8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013b0db, 0x3)   mov(eax, memd_a32(ds, eax + 0x6));    /* mov eax, [eax+0x6] */
    II(0x1013b0de, 0x5)   calld(sys_call_dtor_arr, 0x2aed5);    /* call 0x10165fb8 */
    II(0x1013b0e3, 0x5)   calld(sys_delete_arr, 0x2aef0);       /* call 0x10165fd8 */
l_0x1013b0e8:
    II(0x1013b0e8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013b0eb, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1013b0ee, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1013b0f1, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013b0f3, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013b0f4, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013b0f5, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013b0f6, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013b0f7, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013b0f8, 0x1)   retd();                               /* ret */
FUNC_END

