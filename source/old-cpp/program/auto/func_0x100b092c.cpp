FUNC_BEGIN(0x100b092c, 0x9803800b7be3df00, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x1c, 0x54, 0xb, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xf7, 0x45, 0xfc, 0x4, 0, 0, 0, 0x74, 0x14, 0xba, 0x5c, 0x51, 0x1b, 0x10, 0x8b, 0x45, 0xf8, 0xe8, 0x59, 0x56, 0xb, 0, 0xe8, 0x74, 0x56, 0xb, 0, 0xeb, 0x77, 0x8b, 0x45, 0xf8, 0xc7, 0x40, 0x2, 0xb4, 0x53, 0x1b, 0x10, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x27, 0xe8, 0x3f, 0x83, 0xfd, 0xff, 0x83, 0xe8, 0x27, 0x89, 0x45, 0xf8, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x23, 0xe8, 0xbc, 0x83, 0xfd, 0xff, 0x83, 0xe8, 0x23, 0x89, 0x45, 0xf8, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x19, 0xe8, 0x6d, 0x6c, 0, 0, 0x83, 0xe8, 0x19, 0x89, 0x45, 0xf8, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x15, 0xe8, 0x76, 0x55, 0xfc, 0xff, 0x83, 0xe8, 0x15, 0x89, 0x45, 0xf8, 0xba, 0x1, 0, 0, 0, 0x8b, 0x45, 0xf8, 0xe8, 0x83, 0x1e, 0xff, 0xff, 0x89, 0x45, 0xf8, 0xf7, 0x45, 0xfc, 0x2, 0, 0, 0, 0x74, 0x8, 0x8b, 0x45, 0xf8, 0xe8, 0x87, 0x55, 0xb, 0, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100b092c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100b0931, 0x5)   calld(sys_check_available_stack_size, 0xb541c); /* call 0x10165d52 */
    II(0x100b0936, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b0937, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b0938, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b0939, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b093a, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b093b, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b093d, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100b0943, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100b0946, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100b0949, 0x7)   test(memd_a32(ss, ebp - 0x4), 0x4);   /* test dword [ebp-0x4], 0x4 */
    II(0x100b0950, 0x2)   jzd(0x100b0966, 0x14);                /* jz 0x100b0966 */
    II(0x100b0952, 0x5)   mov(edx, 0x101b515c);                 /* mov edx, 0x101b515c */
    II(0x100b0957, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b095a, 0x5)   calld(sys_call_dtor_arr, 0xb5659);    /* call 0x10165fb8 */
    II(0x100b095f, 0x5)   calld(sys_delete_arr, 0xb5674);       /* call 0x10165fd8 */
    II(0x100b0964, 0x2)   jmpd(0x100b09dd, 0x77);               /* jmp 0x100b09dd */
l_0x100b0966:
    II(0x100b0966, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b0969, 0x7)   mov(memd_a32(ds, eax + 0x2), 0x101b53b4); /* mov dword [eax+0x2], 0x101b53b4 */
    II(0x100b0970, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100b0972, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b0975, 0x3)   add(eax, 0x27);                       /* add eax, 0x27 */
    II(0x100b0978, 0x5)   calld(0x10088cbc, -0x27cc1);          /* call 0x10088cbc */
    II(0x100b097d, 0x3)   sub(eax, 0x27);                       /* sub eax, 0x27 */
    II(0x100b0980, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100b0983, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100b0985, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b0988, 0x3)   add(eax, 0x23);                       /* add eax, 0x23 */
    II(0x100b098b, 0x5)   calld(0x10088d4c, -0x27c44);          /* call 0x10088d4c */
    II(0x100b0990, 0x3)   sub(eax, 0x23);                       /* sub eax, 0x23 */
    II(0x100b0993, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100b0996, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100b0998, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b099b, 0x3)   add(eax, 0x19);                       /* add eax, 0x19 */
    II(0x100b099e, 0x5)   calld(0x100b7610, 0x6c6d);            /* call 0x100b7610 */
    II(0x100b09a3, 0x3)   sub(eax, 0x19);                       /* sub eax, 0x19 */
    II(0x100b09a6, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100b09a9, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100b09ab, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b09ae, 0x3)   add(eax, 0x15);                       /* add eax, 0x15 */
    II(0x100b09b1, 0x5)   calld(0x10075f2c, -0x3aa8a);          /* call 0x10075f2c */
    II(0x100b09b6, 0x3)   sub(eax, 0x15);                       /* sub eax, 0x15 */
    II(0x100b09b9, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100b09bc, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
//    II(0x100b09c1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b09c4, 0x5)   calld(0x100a284c, -0xe17d);           /* call 0x100a284c */
    II(0x100b09c9, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100b09cc, 0x7)   test(memd_a32(ss, ebp - 0x4), 0x2);   /* test dword [ebp-0x4], 0x2 */
    II(0x100b09d3, 0x2)   jzd(0x100b09dd, 0x8);                 /* jz 0x100b09dd */
    II(0x100b09d5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b09d8, 0x5)   calld(sys_delete, 0xb5587);           /* call 0x10165f64 */
l_0x100b09dd:
    II(0x100b09dd, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b09e0, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100b09e3, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100b09e6, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b09e8, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b09e9, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b09ea, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b09eb, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b09ec, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b09ed, 0x1)   retd();                               /* ret */
FUNC_END

