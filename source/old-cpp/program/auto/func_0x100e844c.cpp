FUNC_BEGIN(0x100e844c, 0x3735b0067cf6ccf1, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xfc, 0xd8, 0x7, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xf7, 0x45, 0xfc, 0x4, 0, 0, 0, 0x74, 0x14, 0xba, 0xf0, 0x60, 0x1b, 0x10, 0x8b, 0x45, 0xf8, 0xe8, 0x39, 0xdb, 0x7, 0, 0xe8, 0x54, 0xdb, 0x7, 0, 0xeb, 0x21, 0xba, 0x1, 0, 0, 0, 0x8b, 0x45, 0xf8, 0xe8, 0x83, 0x54, 0xfe, 0xff, 0x89, 0x45, 0xf8, 0xf7, 0x45, 0xfc, 0x2, 0, 0, 0, 0x74, 0x8, 0x8b, 0x45, 0xf8, 0xe8, 0xbd, 0xda, 0x7, 0, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100e844c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100e8451, 0x5)   calld(sys_check_available_stack_size, 0x7d8fc); /* call 0x10165d52 */
    II(0x100e8456, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e8457, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e8458, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e8459, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e845a, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e845b, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e845d, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100e8463, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100e8466, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100e8469, 0x7)   test(memd_a32(ss, ebp - 0x4), 0x4);   /* test dword [ebp-0x4], 0x4 */
    II(0x100e8470, 0x2)   jzd(0x100e8486, 0x14);                /* jz 0x100e8486 */
    II(0x100e8472, 0x5)   mov(edx, 0x101b60f0);                 /* mov edx, 0x101b60f0 */
    II(0x100e8477, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100e847a, 0x5)   calld(sys_call_dtor_arr, 0x7db39);    /* call 0x10165fb8 */
    II(0x100e847f, 0x5)   calld(sys_delete_arr, 0x7db54);       /* call 0x10165fd8 */
    II(0x100e8484, 0x2)   jmpd(0x100e84a7, 0x21);               /* jmp 0x100e84a7 */
l_0x100e8486:
    II(0x100e8486, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
    II(0x100e848b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100e848e, 0x5)   calld(0x100cd916, -0x1ab7d);          /* call 0x100cd916 */
    II(0x100e8493, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100e8496, 0x7)   test(memd_a32(ss, ebp - 0x4), 0x2);   /* test dword [ebp-0x4], 0x2 */
    II(0x100e849d, 0x2)   jzd(0x100e84a7, 0x8);                 /* jz 0x100e84a7 */
    II(0x100e849f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100e84a2, 0x5)   calld(sys_delete, 0x7dabd);           /* call 0x10165f64 */
l_0x100e84a7:
    II(0x100e84a7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100e84aa, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100e84ad, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100e84b0, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e84b2, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e84b3, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e84b4, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e84b5, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e84b6, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e84b7, 0x1)   retd();                               /* ret */
FUNC_END

