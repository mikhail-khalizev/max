FUNC_BEGIN(0x1014fb48, 0x472641f84375b8cb, 0x20, ({0x68, 0x3c, 0, 0, 0, 0xe8, 0, 0x62, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x20, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x6, 0xc1, 0xf8, 0x10, 0x6b, 0xc0, 0x33, 0x80, 0xb8, 0xd5, 0x81, 0x1c, 0x10, 0x1, 0x74, 0x9, 0xc7, 0x45, 0xf8, 0, 0, 0, 0, 0xeb, 0x49, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x70, 0xe8, 0x83, 0xb1, 0xfe, 0xff, 0x84, 0xc0, 0x74, 0xc, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x40, 0x52, 0x89, 0x45, 0xf8, 0xeb, 0x2c, 0x8d, 0x45, 0xec, 0xe8, 0xb, 0x25, 0xf2, 0xff, 0x8d, 0x45, 0xe0, 0xe8, 0x3, 0x25, 0xf2, 0xff, 0x8d, 0x5d, 0xe0, 0x8d, 0x55, 0xec, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x70, 0xe8, 0x21, 0x6d, 0xf2, 0xff, 0xe8, 0x52, 0x3a, 0xff, 0xff, 0x8b, 0x45, 0xee, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1014fb48, 0x5)   pushd(0x3c);                          /* push dword 0x3c */
    II(0x1014fb4d, 0x5)   calld(sys_check_available_stack_size, 0x16200); /* call 0x10165d52 */
    II(0x1014fb52, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1014fb53, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1014fb54, 0x1)   pushd(edx);                           /* push edx */
    II(0x1014fb55, 0x1)   pushd(esi);                           /* push esi */
    II(0x1014fb56, 0x1)   pushd(edi);                           /* push edi */
    II(0x1014fb57, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1014fb58, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1014fb5a, 0x6)   sub(esp, 0x20);                       /* sub esp, 0x20 */
    II(0x1014fb60, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1014fb63, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014fb66, 0x3)   mov(eax, memd_a32(ds, eax + 0x6));    /* mov eax, [eax+0x6] */
    II(0x1014fb69, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1014fb6c, 0x3)   imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
    II(0x1014fb6f, 0x7)   cmp(memb_a32(ds, eax + 0x101c81d5), 0x1); /* cmp byte [eax+0x101c81d5], 0x1 */
    II(0x1014fb76, 0x2)   jzd(0x1014fb81, 0x9);                 /* jz 0x1014fb81 */
    II(0x1014fb78, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0);      /* mov dword [ebp-0x8], 0x0 */
    II(0x1014fb7f, 0x2)   jmpd(0x1014fbca, 0x49);               /* jmp 0x1014fbca */
l_0x1014fb81:
    II(0x1014fb81, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1014fb83, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014fb86, 0x3)   add(eax, 0x70);                       /* add eax, 0x70 */
    II(0x1014fb89, 0x5)   calld(0x1013ad11, -0x14e7d);          /* call 0x1013ad11 */
    II(0x1014fb8e, 0x2)   test(al, al);                         /* test al, al */
    II(0x1014fb90, 0x2)   jzd(0x1014fb9e, 0xc);                 /* jz 0x1014fb9e */
    II(0x1014fb92, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014fb95, 0x4)   mov(ax, memw_a32(ds, eax + 0x52));    /* mov ax, [eax+0x52] */
    II(0x1014fb99, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1014fb9c, 0x2)   jmpd(0x1014fbca, 0x2c);               /* jmp 0x1014fbca */
l_0x1014fb9e:
    II(0x1014fb9e, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x1014fba1, 0x5)   calld(0x100720b1, -0xddaf5);          /* call 0x100720b1 */
    II(0x1014fba6, 0x3)   lea(eax, ebp - 0x20);                 /* lea eax, [ebp-0x20] */
    II(0x1014fba9, 0x5)   calld(0x100720b1, -0xddafd);          /* call 0x100720b1 */
    II(0x1014fbae, 0x3)   lea(ebx, ebp - 0x20);                 /* lea ebx, [ebp-0x20] */
    II(0x1014fbb1, 0x3)   lea(edx, ebp - 0x14);                 /* lea edx, [ebp-0x14] */
    II(0x1014fbb4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014fbb7, 0x3)   add(eax, 0x70);                       /* add eax, 0x70 */
    II(0x1014fbba, 0x5)   calld(0x100768e0, -0xd92df);          /* call 0x100768e0 */
    II(0x1014fbbf, 0x5)   calld(0x10143616, -0xc5ae);           /* call 0x10143616 */
    II(0x1014fbc4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x12));   /* mov eax, [ebp-0x12] */
    II(0x1014fbc7, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
l_0x1014fbca:
    II(0x1014fbca, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014fbcd, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1014fbcf, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1014fbd0, 0x1)   popd(edi);                            /* pop edi */
    II(0x1014fbd1, 0x1)   popd(esi);                            /* pop esi */
    II(0x1014fbd2, 0x1)   popd(edx);                            /* pop edx */
    II(0x1014fbd3, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1014fbd4, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1014fbd5, 0x1)   retd();                               /* ret */
FUNC_END

