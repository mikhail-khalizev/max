FUNC_BEGIN(0x10072999, 0x9ec4032e7c20c9cc, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xaf, 0x33, 0xf, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xfc, 0x89, 0x55, 0xf8, 0x8b, 0x45, 0xf8, 0xe8, 0x7a, 0x39, 0, 0, 0x89, 0xc2, 0x8d, 0x45, 0xf4, 0xe8, 0xf0, 0x3a, 0, 0, 0x31, 0xd2, 0x8d, 0x45, 0xf4, 0xe8, 0x9f, 0x83, 0xc, 0, 0x84, 0xc0, 0x74, 0x46, 0x8d, 0x45, 0xf4, 0xe8, 0xc2, 0x39, 0, 0, 0x31, 0xd2, 0x8a, 0x50, 0x26, 0xf, 0xbf, 0x45, 0xfc, 0x39, 0xc2, 0x75, 0xe, 0x8d, 0x45, 0xf4, 0xe8, 0xad, 0x39, 0, 0, 0x80, 0x78, 0x3d, 0x10, 0x75, 0x2, 0xeb, 0x17, 0x8d, 0x45, 0xf4, 0xe8, 0x5, 0x3a, 0, 0, 0x89, 0x45, 0xf0, 0x31, 0xd2, 0x8d, 0x45, 0xf4, 0xe8, 0x5c, 0x35, 0, 0, 0xeb, 0x27, 0x8d, 0x45, 0xf4, 0xe8, 0xde, 0x41, 0, 0, 0xeb, 0xac, 0xc7, 0x45, 0xf0, 0, 0, 0, 0, 0x31, 0xd2, 0x8d, 0x45, 0xf4, 0xe8, 0x3f, 0x35, 0, 0, 0xeb, 0xa, 0x31, 0xd2, 0x8d, 0x45, 0xf4, 0xe8, 0x33, 0x35, 0, 0, 0x8b, 0x45, 0xf0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10072999, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x1007299e, 0x5)   calld(sys_check_available_stack_size, 0xf33af); /* call 0x10165d52 */
    II(0x100729a3, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100729a4, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100729a5, 0x1)   pushd(esi);                           /* push esi */
    II(0x100729a6, 0x1)   pushd(edi);                           /* push edi */
    II(0x100729a7, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100729a8, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100729aa, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x100729b0, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100729b3, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x100729b6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100729b9, 0x5)   calld(0x10076338, 0x397a);            /* call 0x10076338 */
    II(0x100729be, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x100729c0, 0x3)   lea(eax, ebp - 0xc);                  /* lea eax, [ebp-0xc] */
    II(0x100729c3, 0x5)   calld(0x100764b8, 0x3af0);            /* call 0x100764b8 */
l_0x100729c8:
    II(0x100729c8, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100729ca, 0x3)   lea(eax, ebp - 0xc);                  /* lea eax, [ebp-0xc] */
    II(0x100729cd, 0x5)   calld(0x1013ad71, 0xc839f);           /* call 0x1013ad71 */
    II(0x100729d2, 0x2)   test(al, al);                         /* test al, al */
    II(0x100729d4, 0x2)   jzd(0x10072a1c, 0x46);                /* jz 0x10072a1c */
    II(0x100729d6, 0x3)   lea(eax, ebp - 0xc);                  /* lea eax, [ebp-0xc] */
    II(0x100729d9, 0x5)   calld(0x100763a0, 0x39c2);            /* call 0x100763a0 */
    II(0x100729de, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100729e0, 0x3)   mov(dl, memb_a32(ds, eax + 0x26));    /* mov dl, [eax+0x26] */
    II(0x100729e3, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100729e7, 0x2)   cmp(edx, eax);                        /* cmp edx, eax */
    II(0x100729e9, 0x2)   jnzd(0x100729f9, 0xe);                /* jnz 0x100729f9 */
    II(0x100729eb, 0x3)   lea(eax, ebp - 0xc);                  /* lea eax, [ebp-0xc] */
    II(0x100729ee, 0x5)   calld(0x100763a0, 0x39ad);            /* call 0x100763a0 */
    II(0x100729f3, 0x4)   cmp(memb_a32(ds, eax + 0x3d), 0x10);  /* cmp byte [eax+0x3d], 0x10 */
    II(0x100729f7, 0x2)   jnzd(0x100729fb, 0x2);                /* jnz 0x100729fb */
l_0x100729f9:
    II(0x100729f9, 0x2)   jmpd(0x10072a12, 0x17);               /* jmp 0x10072a12 */
l_0x100729fb:
    II(0x100729fb, 0x3)   lea(eax, ebp - 0xc);                  /* lea eax, [ebp-0xc] */
    II(0x100729fe, 0x5)   calld(0x10076408, 0x3a05);            /* call 0x10076408 */
    II(0x10072a03, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x10072a06, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10072a08, 0x3)   lea(eax, ebp - 0xc);                  /* lea eax, [ebp-0xc] */
    II(0x10072a0b, 0x5)   calld(0x10075f6c, 0x355c);            /* call 0x10075f6c */
    II(0x10072a10, 0x2)   jmpd(0x10072a39, 0x27);               /* jmp 0x10072a39 */
l_0x10072a12:
    II(0x10072a12, 0x3)   lea(eax, ebp - 0xc);                  /* lea eax, [ebp-0xc] */
    II(0x10072a15, 0x5)   calld(0x10076bf8, 0x41de);            /* call 0x10076bf8 */
    II(0x10072a1a, 0x2)   jmpd(0x100729c8, -0x54);              /* jmp 0x100729c8 */
l_0x10072a1c:
    II(0x10072a1c, 0x7)   mov(memd_a32(ss, ebp - 0x10), 0);     /* mov dword [ebp-0x10], 0x0 */
    II(0x10072a23, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10072a25, 0x3)   lea(eax, ebp - 0xc);                  /* lea eax, [ebp-0xc] */
    II(0x10072a28, 0x5)   calld(0x10075f6c, 0x353f);            /* call 0x10075f6c */
    II(0x10072a2d, 0x2)   jmpd(0x10072a39, 0xa);                /* jmp 0x10072a39 */
//  II(0x10072a2f, 0xa)   /* Недостижимый код. */
l_0x10072a39:
    II(0x10072a39, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10072a3c, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10072a3e, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10072a3f, 0x1)   popd(edi);                            /* pop edi */
    II(0x10072a40, 0x1)   popd(esi);                            /* pop esi */
    II(0x10072a41, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10072a42, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10072a43, 0x1)   retd();                               /* ret */
FUNC_END

