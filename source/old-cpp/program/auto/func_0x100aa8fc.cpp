FUNC_BEGIN(0x100aa8fc, 0x98ccd67396072c39, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x4c, 0xb4, 0xb, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xf, 0xbf, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0xf, 0, 0, 0, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100aa8fc, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100aa901, 0x5)   calld(sys_check_available_stack_size, 0xbb44c); /* call 0x10165d52 */
    II(0x100aa906, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100aa907, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100aa908, 0x1)   pushd(esi);                           /* push esi */
    II(0x100aa909, 0x1)   pushd(edi);                           /* push edi */
    II(0x100aa90a, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100aa90b, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100aa90d, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100aa913, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100aa916, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100aa919, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x4));  /* movsx edx, word [ebp-0x4] */
    II(0x100aa91d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100aa920, 0x5)   calld(0x100aa934, 0xf);               /* call 0x100aa934 */
    II(0x100aa925, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100aa928, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100aa92b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100aa92d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100aa92e, 0x1)   popd(edi);                            /* pop edi */
    II(0x100aa92f, 0x1)   popd(esi);                            /* pop esi */
    II(0x100aa930, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100aa931, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100aa932, 0x1)   retd();                               /* ret */
FUNC_END

