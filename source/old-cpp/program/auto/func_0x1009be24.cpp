FUNC_BEGIN(0x1009be24, 0x79a2b8f639fa9ba1, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x24, 0x9f, 0xc, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xf7, 0x45, 0xfc, 0x4, 0, 0, 0, 0x74, 0x14, 0xba, 0xc, 0x41, 0x1b, 0x10, 0x8b, 0x45, 0xf8, 0xe8, 0x61, 0xa1, 0xc, 0, 0xe8, 0x7c, 0xa1, 0xc, 0, 0xeb, 0x34, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x13, 0xe8, 0x8d, 0xfd, 0xff, 0xff, 0x83, 0xe8, 0x13, 0x89, 0x45, 0xf8, 0xba, 0x1, 0, 0, 0, 0x8b, 0x45, 0xf8, 0xe8, 0xce, 0x69, 0, 0, 0x89, 0x45, 0xf8, 0xf7, 0x45, 0xfc, 0x2, 0, 0, 0, 0x74, 0x8, 0x8b, 0x45, 0xf8, 0xe8, 0xd2, 0xa0, 0xc, 0, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1009be24, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1009be29, 0x5)   calld(sys_check_available_stack_size, 0xc9f24); /* call 0x10165d52 */
    II(0x1009be2e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009be2f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009be30, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009be31, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009be32, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009be33, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009be35, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1009be3b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1009be3e, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1009be41, 0x7)   test(memd_a32(ss, ebp - 0x4), 0x4);   /* test dword [ebp-0x4], 0x4 */
    II(0x1009be48, 0x2)   jzd(0x1009be5e, 0x14);                /* jz 0x1009be5e */
    II(0x1009be4a, 0x5)   mov(edx, 0x101b410c);                 /* mov edx, 0x101b410c */
    II(0x1009be4f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009be52, 0x5)   calld(sys_call_dtor_arr, 0xca161);    /* call 0x10165fb8 */
    II(0x1009be57, 0x5)   calld(sys_delete_arr, 0xca17c);       /* call 0x10165fd8 */
    II(0x1009be5c, 0x2)   jmpd(0x1009be92, 0x34);               /* jmp 0x1009be92 */
l_0x1009be5e:
    II(0x1009be5e, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1009be60, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009be63, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x1009be66, 0x5)   calld(0x1009bbf8, -0x273);            /* call 0x1009bbf8 */
    II(0x1009be6b, 0x3)   sub(eax, 0x13);                       /* sub eax, 0x13 */
    II(0x1009be6e, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1009be71, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
//    II(0x1009be76, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009be79, 0x5)   calld(0x100a284c, 0x69ce);            /* call 0x100a284c */
    II(0x1009be7e, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1009be81, 0x7)   test(memd_a32(ss, ebp - 0x4), 0x2);   /* test dword [ebp-0x4], 0x2 */
    II(0x1009be88, 0x2)   jzd(0x1009be92, 0x8);                 /* jz 0x1009be92 */
    II(0x1009be8a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009be8d, 0x5)   calld(sys_delete, 0xca0d2);           /* call 0x10165f64 */
l_0x1009be92:
    II(0x1009be92, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009be95, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1009be98, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1009be9b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009be9d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009be9e, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009be9f, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009bea0, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009bea1, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009bea2, 0x1)   retd();                               /* ret */
FUNC_END

