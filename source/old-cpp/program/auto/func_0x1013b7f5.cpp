FUNC_BEGIN(0x1013b7f5, 0x3160e0236f707954, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x53, 0xa5, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xf, 0xbf, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x7b, 0xfb, 0xff, 0xff, 0x89, 0x45, 0xf8, 0x8d, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf8, 0xc7, 0x40, 0xa, 0x1c, 0x6f, 0x1b, 0x10, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xf0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1013b7f5, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x1013b7fa, 0x5)   calld(sys_check_available_stack_size, 0x2a553); /* call 0x10165d52 */
    II(0x1013b7ff, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013b800, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013b801, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013b802, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013b803, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013b804, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013b806, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x1013b80c, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1013b80f, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1013b812, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x4));  /* movsx edx, word [ebp-0x4] */
    II(0x1013b816, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013b819, 0x5)   calld(0x1013b399, -0x485);            /* call 0x1013b399 */
    II(0x1013b81e, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1013b821, 0x3)   lea(eax, ebp - 0x8);                  /* lea eax, [ebp-0x8] */
    II(0x1013b824, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x1013b827, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013b82a, 0x7)   mov(memd_a32(ds, eax + 0xa), 0x101b6f1c); /* mov dword [eax+0xa], 0x101b6f1c */
    II(0x1013b831, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013b834, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
//    II(0x1013b837, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x1013b83a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013b83c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013b83d, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013b83e, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013b83f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013b840, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013b841, 0x1)   retd();                               /* ret */
FUNC_END

