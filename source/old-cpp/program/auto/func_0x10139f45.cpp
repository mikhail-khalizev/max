FUNC_BEGIN(0x10139f45, 0xcc579c18b65588e6, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x3, 0xbe, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xf8, 0x83, 0xc2, 0xa, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0xa, 0xe8, 0xfd, 0xa, 0, 0, 0x8b, 0x55, 0xf8, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0xe, 0xe8, 0x17, 0xcd, 0xf3, 0xff, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0xa, 0xe8, 0xe3, 0xd, 0, 0, 0x84, 0xc0, 0x74, 0x16, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0xa, 0xe8, 0x9c, 0xa, 0, 0, 0x83, 0xc0, 0xe, 0xe8, 0xf0, 0xcc, 0xf3, 0xff, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0xa, 0xe8, 0xe2, 0xcc, 0xf3, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10139f45, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10139f4a, 0x5)   calld(sys_check_available_stack_size, 0x2be03); /* call 0x10165d52 */
    II(0x10139f4f, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10139f50, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10139f51, 0x1)   pushd(esi);                           /* push esi */
    II(0x10139f52, 0x1)   pushd(edi);                           /* push edi */
    II(0x10139f53, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10139f54, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10139f56, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10139f5c, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10139f5f, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x10139f62, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x10139f65, 0x3)   add(edx, 0xa);                        /* add edx, 0xa */
    II(0x10139f68, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10139f6b, 0x3)   add(eax, 0xa);                        /* add eax, 0xa */
    II(0x10139f6e, 0x5)   calld(0x1013aa70, 0xafd);             /* call 0x1013aa70 */
    II(0x10139f73, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x10139f76, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10139f79, 0x3)   add(eax, 0xe);                        /* add eax, 0xe */
    II(0x10139f7c, 0x5)   calld(0x10076c98, -0xc32e9);          /* call 0x10076c98 */
    II(0x10139f81, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10139f83, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10139f86, 0x3)   add(eax, 0xa);                        /* add eax, 0xa */
    II(0x10139f89, 0x5)   calld(0x1013ad71, 0xde3);             /* call 0x1013ad71 */
    II(0x10139f8e, 0x2)   test(al, al);                         /* test al, al */
    II(0x10139f90, 0x2)   jzd(0x10139fa8, 0x16);                /* jz 0x10139fa8 */
    II(0x10139f92, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x10139f95, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10139f98, 0x3)   add(eax, 0xa);                        /* add eax, 0xa */
    II(0x10139f9b, 0x5)   calld(0x1013aa3c, 0xa9c);             /* call 0x1013aa3c */
    II(0x10139fa0, 0x3)   add(eax, 0xe);                        /* add eax, 0xe */
    II(0x10139fa3, 0x5)   calld(0x10076c98, -0xc3310);          /* call 0x10076c98 */
l_0x10139fa8:
    II(0x10139fa8, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x10139fab, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10139fae, 0x3)   add(eax, 0xa);                        /* add eax, 0xa */
    II(0x10139fb1, 0x5)   calld(0x10076c98, -0xc331e);          /* call 0x10076c98 */
    II(0x10139fb6, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10139fb8, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10139fb9, 0x1)   popd(edi);                            /* pop edi */
    II(0x10139fba, 0x1)   popd(esi);                            /* pop esi */
    II(0x10139fbb, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10139fbc, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10139fbd, 0x1)   retd();                               /* ret */
FUNC_END

