FUNC_BEGIN(0x1007b91c, 0xad12484ddfd2be23, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x2c, 0xa4, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x19, 0xe8, 0xf6, 0xa9, 0xff, 0xff, 0x8d, 0x5d, 0xf4, 0x89, 0xc2, 0x89, 0xd8, 0xe8, 0x6a, 0xab, 0xff, 0xff, 0xeb, 0x8, 0x8d, 0x45, 0xf4, 0xe8, 0xa0, 0xb2, 0xff, 0xff, 0x31, 0xd2, 0x8d, 0x45, 0xf4, 0xe8, 0xf, 0xf4, 0xb, 0, 0x84, 0xc0, 0x74, 0x3b, 0x8d, 0x45, 0xf4, 0xe8, 0x32, 0xaa, 0xff, 0xff, 0x8a, 0x40, 0x4e, 0x25, 0xff, 0, 0, 0, 0x85, 0xc0, 0x7e, 0x14, 0x8b, 0x55, 0xfc, 0x8d, 0x45, 0xf4, 0xe8, 0x1b, 0xaa, 0xff, 0xff, 0xe8, 0xc8, 0x70, 0xd, 0, 0x84, 0xc0, 0x75, 0x2, 0xeb, 0xf, 0x31, 0xd2, 0x8d, 0x45, 0xf4, 0xe8, 0x3a, 0xaa, 0xff, 0xff, 0xe8, 0xde, 0x6f, 0x2, 0, 0xeb, 0xaf, 0xc6, 0x45, 0xf8, 0, 0x31, 0xd2, 0x8d, 0x45, 0xf4, 0xe8, 0xbd, 0xa5, 0xff, 0xff, 0xeb, 0xa, 0x31, 0xd2, 0x8d, 0x45, 0xf4, 0xe8, 0xb1, 0xa5, 0xff, 0xff, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1007b91c, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x1007b921, 0x5)   calld(sys_check_available_stack_size, 0xea42c); /* call 0x10165d52 */
    II(0x1007b926, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1007b927, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1007b928, 0x1)   pushd(edx);                           /* push edx */
    II(0x1007b929, 0x1)   pushd(esi);                           /* push esi */
    II(0x1007b92a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1007b92b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1007b92c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1007b92e, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1007b934, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1007b937, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1007b93a, 0x3)   add(eax, 0x19);                       /* add eax, 0x19 */
    II(0x1007b93d, 0x5)   calld(0x10076338, -0x560a);           /* call 0x10076338 */
    II(0x1007b942, 0x3)   lea(ebx, ebp - 0xc);                  /* lea ebx, [ebp-0xc] */
    II(0x1007b945, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1007b947, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x1007b949, 0x5)   calld(0x100764b8, -0x5496);           /* call 0x100764b8 */
    II(0x1007b94e, 0x2)   jmpd(0x1007b958, 0x8);                /* jmp 0x1007b958 */
l_0x1007b950:
    II(0x1007b950, 0x3)   lea(eax, ebp - 0xc);                  /* lea eax, [ebp-0xc] */
    II(0x1007b953, 0x5)   calld(0x10076bf8, -0x4d60);           /* call 0x10076bf8 */
l_0x1007b958:
    II(0x1007b958, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1007b95a, 0x3)   lea(eax, ebp - 0xc);                  /* lea eax, [ebp-0xc] */
    II(0x1007b95d, 0x5)   calld(0x1013ad71, 0xbf40f);           /* call 0x1013ad71 */
    II(0x1007b962, 0x2)   test(al, al);                         /* test al, al */
    II(0x1007b964, 0x2)   jzd(0x1007b9a1, 0x3b);                /* jz 0x1007b9a1 */
    II(0x1007b966, 0x3)   lea(eax, ebp - 0xc);                  /* lea eax, [ebp-0xc] */
    II(0x1007b969, 0x5)   calld(0x100763a0, -0x55ce);           /* call 0x100763a0 */
    II(0x1007b96e, 0x3)   mov(al, memb_a32(ds, eax + 0x4e));    /* mov al, [eax+0x4e] */
    II(0x1007b971, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x1007b976, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1007b978, 0x2)   jled(0x1007b98e, 0x14);               /* jle 0x1007b98e */
    II(0x1007b97a, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x1007b97d, 0x3)   lea(eax, ebp - 0xc);                  /* lea eax, [ebp-0xc] */
    II(0x1007b980, 0x5)   calld(0x100763a0, -0x55e5);           /* call 0x100763a0 */
    II(0x1007b985, 0x5)   calld(0x10152a52, 0xd70c8);           /* call 0x10152a52 */
    II(0x1007b98a, 0x2)   test(al, al);                         /* test al, al */
    II(0x1007b98c, 0x2)   jnzd(0x1007b990, 0x2);                /* jnz 0x1007b990 */
l_0x1007b98e:
    II(0x1007b98e, 0x2)   jmpd(0x1007b99f, 0xf);                /* jmp 0x1007b99f */
l_0x1007b990:
    II(0x1007b990, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1007b992, 0x3)   lea(eax, ebp - 0xc);                  /* lea eax, [ebp-0xc] */
    II(0x1007b995, 0x5)   calld(0x100763d4, -0x55c6);           /* call 0x100763d4 */
    II(0x1007b99a, 0x5)   calld(0x100a297d, 0x26fde);           /* call 0x100a297d */
l_0x1007b99f:
    II(0x1007b99f, 0x2)   jmpd(0x1007b950, -0x51);              /* jmp 0x1007b950 */
l_0x1007b9a1:
    II(0x1007b9a1, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0);      /* mov byte [ebp-0x8], 0x0 */
    II(0x1007b9a5, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1007b9a7, 0x3)   lea(eax, ebp - 0xc);                  /* lea eax, [ebp-0xc] */
    II(0x1007b9aa, 0x5)   calld(0x10075f6c, -0x5a43);           /* call 0x10075f6c */
    II(0x1007b9af, 0x2)   jmpd(0x1007b9bb, 0xa);                /* jmp 0x1007b9bb */
//  II(0x1007b9b1, 0xa)   /* Недостижимый код. */
l_0x1007b9bb:
    II(0x1007b9bb, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x1007b9be, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1007b9c0, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1007b9c1, 0x1)   popd(edi);                            /* pop edi */
    II(0x1007b9c2, 0x1)   popd(esi);                            /* pop esi */
    II(0x1007b9c3, 0x1)   popd(edx);                            /* pop edx */
    II(0x1007b9c4, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1007b9c5, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1007b9c6, 0x1)   retd();                               /* ret */
FUNC_END

