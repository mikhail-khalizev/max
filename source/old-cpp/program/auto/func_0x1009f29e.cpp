FUNC_BEGIN(0x1009f29e, 0x359bd4cf5bfd13e4, 0x20, ({0x68, 0x2c, 0, 0, 0, 0xe8, 0xaa, 0x6a, 0xc, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x18, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x89, 0x5d, 0xfc, 0x8b, 0x55, 0xfc, 0x8d, 0x45, 0xe8, 0xe8, 0x9c, 0x6b, 0xfd, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xf4, 0x8b, 0x40, 0x7, 0xc1, 0xf8, 0x10, 0x69, 0xd8, 0xc5, 0, 0, 0, 0xb8, 0xc4, 0x31, 0x1c, 0x10, 0x1, 0xd8, 0xe8, 0xa0, 0x38, 0x2, 0, 0x98, 0x85, 0xc0, 0x7f, 0x6, 0xc6, 0x45, 0xf0, 0x1, 0xeb, 0x4, 0xc6, 0x45, 0xf0, 0, 0x8a, 0x45, 0xf0, 0x88, 0x45, 0xec, 0x8a, 0x45, 0xec, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x1009f29e, 0x5)   pushd(0x2c);                          /* push dword 0x2c */
    II(0x1009f2a3, 0x5)   calld(sys_check_available_stack_size, 0xc6aaa); /* call 0x10165d52 */
    II(0x1009f2a8, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009f2a9, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009f2aa, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009f2ab, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009f2ac, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009f2ae, 0x6)   sub(esp, 0x18);                       /* sub esp, 0x18 */
    II(0x1009f2b4, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x1009f2b7, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x1009f2ba, 0x3)   mov(memd_a32(ss, ebp - 0x4), ebx);    /* mov [ebp-0x4], ebx */
    II(0x1009f2bd, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x1009f2c0, 0x3)   lea(eax, ebp - 0x18);                 /* lea eax, [ebp-0x18] */
    II(0x1009f2c3, 0x5)   calld(0x10075e64, -0x29464);          /* call 0x10075e64 */
    II(0x1009f2c8, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1009f2ca, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1009f2cd, 0x3)   mov(eax, memd_a32(ds, eax + 0x7));    /* mov eax, [eax+0x7] */
    II(0x1009f2d0, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1009f2d3, 0x6)   imul(ebx, eax, 0xc5);                 /* imul ebx, eax, 0xc5 */
    II(0x1009f2d9, 0x5)   mov(eax, 0x101c31c4);                 /* mov eax, 0x101c31c4 */
    II(0x1009f2de, 0x2)   add(eax, ebx);                        /* add eax, ebx */
    II(0x1009f2e0, 0x5)   calld(0x100c2b85, 0x238a0);           /* call 0x100c2b85 */
    II(0x1009f2e5, 0x1)   cwde();                               /* cwde */
    II(0x1009f2e6, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1009f2e8, 0x2)   jgd(0x1009f2f0, 0x6);                 /* jg 0x1009f2f0 */
    II(0x1009f2ea, 0x4)   mov(memb_a32(ss, ebp - 0x10), 0x1);   /* mov byte [ebp-0x10], 0x1 */
    II(0x1009f2ee, 0x2)   jmpd(0x1009f2f4, 0x4);                /* jmp 0x1009f2f4 */
l_0x1009f2f0:
    II(0x1009f2f0, 0x4)   mov(memb_a32(ss, ebp - 0x10), 0);     /* mov byte [ebp-0x10], 0x0 */
l_0x1009f2f4:
    II(0x1009f2f4, 0x3)   mov(al, memb_a32(ss, ebp - 0x10));    /* mov al, [ebp-0x10] */
    II(0x1009f2f7, 0x3)   mov(memb_a32(ss, ebp - 0x14), al);    /* mov [ebp-0x14], al */
//    II(0x1009f2fa, 0x3)   mov(al, memb_a32(ss, ebp - 0x14));    /* mov al, [ebp-0x14] */
    II(0x1009f2fd, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009f2ff, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009f300, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009f301, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009f302, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009f303, 0x1)   retd();                               /* ret */
FUNC_END

