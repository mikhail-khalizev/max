FUNC_BEGIN(0x100df5ba, 0xc134a4b4d85f88c0, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x8e, 0x67, 0x8, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0x8b, 0x5d, 0xf4, 0x83, 0xc3, 0x2, 0x8b, 0x45, 0xf4, 0xf, 0xbf, 0x10, 0x8b, 0x45, 0xf8, 0xe8, 0x38, 0xfd, 0xff, 0xff, 0x89, 0xda, 0xe8, 0x26, 0x49, 0x8, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100df5ba, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100df5bf, 0x5)   calld(sys_check_available_stack_size, 0x8678e); /* call 0x10165d52 */
    II(0x100df5c4, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100df5c5, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100df5c6, 0x1)   pushd(esi);                           /* push esi */
    II(0x100df5c7, 0x1)   pushd(edi);                           /* push edi */
    II(0x100df5c8, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100df5c9, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100df5cb, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100df5d1, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100df5d4, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100df5d7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100df5da, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x100df5dd, 0x3)   mov(ebx, memd_a32(ss, ebp - 0xc));    /* mov ebx, [ebp-0xc] */
    II(0x100df5e0, 0x3)   add(ebx, 0x2);                        /* add ebx, 0x2 */
    II(0x100df5e3, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100df5e6, 0x3)   movsx(edx, memw_a32(ds, eax));        /* movsx edx, word [eax] */
    II(0x100df5e9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100df5ec, 0x5)   calld(0x100df329, -0x2c8);            /* call 0x100df329 */
    II(0x100df5f1, 0x2)   mov(edx, ebx);                        /* mov edx, ebx */
    II(0x100df5f3, 0x5)   calld(0x10163f1e, 0x84926);           /* call 0x10163f1e */
    II(0x100df5f8, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100df5fa, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100df5fb, 0x1)   popd(edi);                            /* pop edi */
    II(0x100df5fc, 0x1)   popd(esi);                            /* pop esi */
    II(0x100df5fd, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100df5fe, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100df5ff, 0x1)   retd();                               /* ret */
FUNC_END

