FUNC_BEGIN(0x101067e1, 0x2ed7580ffc952862, 0x20, ({0x68, 0x2c, 0, 0, 0, 0xe8, 0x67, 0xf5, 0x5, 0, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xf0, 0x89, 0x55, 0xf8, 0x89, 0x5d, 0xf4, 0x89, 0x4d, 0xfc, 0xf, 0xbf, 0x45, 0xf8, 0xc1, 0xe0, 0x2, 0xff, 0xb0, 0xdc, 0x8f, 0x1b, 0x10, 0x8b, 0x45, 0xf0, 0x50, 0xe8, 0xe2, 0xce, 0x1, 0, 0x83, 0xc4, 0x8, 0x85, 0xc0, 0x74, 0x2f, 0xb8, 0x15, 0x3b, 0x1a, 0x10, 0x50, 0x8b, 0x45, 0xf0, 0x50, 0xe8, 0x22, 0xd0, 0x1, 0, 0x83, 0xc4, 0x8, 0x85, 0xc0, 0x74, 0x19, 0xf, 0xbf, 0x45, 0xfc, 0x50, 0x8b, 0x45, 0xf4, 0x50, 0x8b, 0x45, 0xf0, 0x50, 0xe8, 0x25, 0xd3, 0x1, 0, 0x83, 0xc4, 0xc, 0x85, 0xc0, 0x75, 0xd, 0xba, 0x1a, 0x3b, 0x1a, 0x10, 0x8b, 0x45, 0xf4, 0xe8, 0x74, 0xf6, 0x5, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0xc3}))
    II(0x101067e1, 0x5)   pushd(0x2c);                          /* push dword 0x2c */
    II(0x101067e6, 0x5)   calld(sys_check_available_stack_size, 0x5f567); /* call 0x10165d52 */
    II(0x101067eb, 0x1)   pushd(esi);                           /* push esi */
    II(0x101067ec, 0x1)   pushd(edi);                           /* push edi */
    II(0x101067ed, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101067ee, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101067f0, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x101067f6, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x101067f9, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x101067fc, 0x3)   mov(memd_a32(ss, ebp - 0xc), ebx);    /* mov [ebp-0xc], ebx */
    II(0x101067ff, 0x3)   mov(memd_a32(ss, ebp - 0x4), ecx);    /* mov [ebp-0x4], ecx */
    II(0x10106802, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x10106806, 0x3)   shl(eax, 0x2);                        /* shl eax, 0x2 */
    II(0x10106809, 0x6)   pushd(memd_a32(ds, eax + 0x101b8fdc)); /* push dword [eax+0x101b8fdc] */
    II(0x1010680f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10106812, 0x1)   pushd(eax);                           /* push eax */
    II(0x10106813, 0x5)   calld(0x101236fa, 0x1cee2);           /* call 0x101236fa */
    II(0x10106818, 0x3)   add(esp, 0x8);                        /* add esp, 0x8 */
    II(0x1010681b, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1010681d, 0x2)   jzd(0x1010684e, 0x2f);                /* jz 0x1010684e */
    II(0x1010681f, 0x5)   mov(eax, 0x101a3b15);                 /* mov eax, 0x101a3b15 */ /* "Text" */
    II(0x10106824, 0x1)   pushd(eax);                           /* push eax */
    II(0x10106825, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10106828, 0x1)   pushd(eax);                           /* push eax */
    II(0x10106829, 0x5)   calld(0x10123850, 0x1d022);           /* call 0x10123850 */
    II(0x1010682e, 0x3)   add(esp, 0x8);                        /* add esp, 0x8 */
    II(0x10106831, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10106833, 0x2)   jzd(0x1010684e, 0x19);                /* jz 0x1010684e */
    II(0x10106835, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x10106839, 0x1)   pushd(eax);                           /* push eax */
    II(0x1010683a, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1010683d, 0x1)   pushd(eax);                           /* push eax */
    II(0x1010683e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10106841, 0x1)   pushd(eax);                           /* push eax */
    II(0x10106842, 0x5)   calld(0x10123b6c, 0x1d325);           /* call 0x10123b6c */
    II(0x10106847, 0x3)   add(esp, 0xc);                        /* add esp, 0xc */
    II(0x1010684a, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1010684c, 0x2)   jnzd(0x1010685b, 0xd);                /* jnz 0x1010685b */
l_0x1010684e:
    II(0x1010684e, 0x5)   mov(edx, 0x101a3b1a);                 /* mov edx, 0x101a3b1a */ /* "No clan chosen - computer will choose a clan at random." */
    II(0x10106853, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10106856, 0x5)   calld(sys_strcpy, 0x5f674);           /* call 0x10165ecf */
l_0x1010685b:
    II(0x1010685b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1010685d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1010685e, 0x1)   popd(edi);                            /* pop edi */
    II(0x1010685f, 0x1)   popd(esi);                            /* pop esi */
    II(0x10106860, 0x1)   retd();                               /* ret */
FUNC_END

