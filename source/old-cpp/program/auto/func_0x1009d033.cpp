FUNC_BEGIN(0x1009d033, 0xbd1b42a25f5c7885, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x15, 0x8d, 0xc, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x17, 0xe8, 0x56, 0xda, 0xfe, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1009d033, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1009d038, 0x5)   calld(sys_check_available_stack_size, 0xc8d15); /* call 0x10165d52 */
    II(0x1009d03d, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009d03e, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009d03f, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009d040, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009d041, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009d042, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009d044, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1009d04a, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1009d04d, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x1009d050, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x1009d053, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009d056, 0x3)   add(eax, 0x17);                       /* add eax, 0x17 */
    II(0x1009d059, 0x5)   calld(0x1008aab4, -0x125aa);          /* call 0x1008aab4 */
    II(0x1009d05e, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009d060, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009d061, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009d062, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009d063, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009d064, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009d065, 0x1)   retd();                               /* ret */
FUNC_END

