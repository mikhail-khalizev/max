FUNC_BEGIN(0x100ea2d6, 0x3e49b2698a62e353, 0x20, ({0x68, 0xb4, 0, 0, 0, 0xe8, 0x72, 0xba, 0x7, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x98, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xc6, 0x45, 0xf4, 0, 0x8d, 0x7d, 0xe8, 0x8b, 0x75, 0xf8, 0x8d, 0x76, 0x2, 0x66, 0xa5, 0xa4, 0x80, 0x7d, 0xf4, 0, 0xf, 0x85, 0xf1, 0, 0, 0, 0x8d, 0x45, 0xa8, 0x50, 0x8d, 0x8d, 0x68, 0xff, 0xff, 0xff, 0xbb, 0x1, 0, 0, 0, 0x8d, 0x55, 0xe8, 0x8b, 0x45, 0xf8, 0xe8, 0x67, 0xfe, 0xff, 0xff, 0x89, 0x45, 0xec, 0x8d, 0x45, 0xa8, 0x50, 0x8d, 0x8d, 0x68, 0xff, 0xff, 0xff, 0xbb, 0xff, 0xff, 0xff, 0xff, 0x8d, 0x55, 0xe8, 0x8b, 0x45, 0xf8, 0xe8, 0x4a, 0xfe, 0xff, 0xff, 0x89, 0x45, 0xf0, 0x8a, 0x45, 0xfc, 0, 0x45, 0xe8, 0xf, 0xbe, 0x45, 0xe8, 0x85, 0xc0, 0x7c, 0x9, 0xf, 0xbe, 0x45, 0xe8, 0x83, 0xf8, 0x1f, 0x7e, 0x9, 0xc6, 0x45, 0xf4, 0x1, 0xe9, 0x92, 0, 0, 0, 0x8d, 0x55, 0xe8, 0x8b, 0x45, 0xf8, 0xe8, 0xf5, 0xfc, 0xff, 0xff, 0x84, 0xc0, 0xf, 0x85, 0x7f, 0, 0, 0, 0xc6, 0x45, 0xf4, 0x1, 0x8a, 0x45, 0xf0, 0x88, 0x45, 0xe9, 0x80, 0x7d, 0xf4, 0, 0x74, 0xc, 0xf, 0xbe, 0x55, 0xe9, 0xf, 0xbf, 0x45, 0xec, 0x39, 0xc2, 0x7e, 0x2, 0xeb, 0x61, 0xf, 0xbe, 0x45, 0xe9, 0x1, 0xc0, 0x8a, 0x84, 0x28, 0x68, 0xff, 0xff, 0xff, 0x88, 0x45, 0xea, 0xf, 0xbe, 0x45, 0xe9, 0x1, 0xc0, 0x8b, 0x44, 0x28, 0xa6, 0xc1, 0xf8, 0x10, 0xf, 0xbe, 0x55, 0xea, 0x39, 0xc2, 0x7f, 0xf, 0x8d, 0x55, 0xe8, 0x8b, 0x45, 0xf8, 0xe8, 0x9f, 0xfc, 0xff, 0xff, 0x84, 0xc0, 0x74, 0x2, 0xeb, 0x8, 0x8a, 0x45, 0xea, 0xfe, 0x45, 0xea, 0xeb, 0xd2, 0xf, 0xbe, 0x45, 0xe9, 0x1, 0xc0, 0x8b, 0x44, 0x28, 0xa6, 0xc1, 0xf8, 0x10, 0xf, 0xbe, 0x55, 0xea, 0x39, 0xc2, 0x7f, 0x6, 0xc6, 0x45, 0xf4, 0, 0xeb, 0x6, 0x8a, 0x45, 0xe9, 0xfe, 0x45, 0xe9, 0xeb, 0x8b, 0xe9, 0x5, 0xff, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100ea2d6, 0x5)   pushd(0xb4);                          /* push dword 0xb4 */
    II(0x100ea2db, 0x5)   calld(sys_check_available_stack_size, 0x7ba72); /* call 0x10165d52 */
    II(0x100ea2e0, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100ea2e1, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ea2e2, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ea2e3, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ea2e4, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ea2e5, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ea2e7, 0x6)   sub(esp, 0x98);                       /* sub esp, 0x98 */
    II(0x100ea2ed, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100ea2f0, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100ea2f3, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0);      /* mov byte [ebp-0xc], 0x0 */
    II(0x100ea2f7, 0x3)   lea(edi, ebp - 0x18);                 /* lea edi, [ebp-0x18] */
    II(0x100ea2fa, 0x3)   mov(esi, memd_a32(ss, ebp - 0x8));    /* mov esi, [ebp-0x8] */
    II(0x100ea2fd, 0x3)   lea(esi, esi + 0x2);                  /* lea esi, [esi+0x2] */
    II(0x100ea300, 0x2)   movsw_a32();                          /* movsw */
    II(0x100ea302, 0x1)   movsb_a32();                          /* movsb */
l_0x100ea303:
    II(0x100ea303, 0x4)   cmp(memb_a32(ss, ebp - 0xc), 0);      /* cmp byte [ebp-0xc], 0x0 */
    II(0x100ea307, 0x6)   jnzd(0x100ea3fe, 0xf1);               /* jnz dword 0x100ea3fe */
    II(0x100ea30d, 0x3)   lea(eax, ebp - 0x58);                 /* lea eax, [ebp-0x58] */
    II(0x100ea310, 0x1)   pushd(eax);                           /* push eax */
    II(0x100ea311, 0x6)   lea(ecx, ebp - 0x98);                 /* lea ecx, [ebp+0xffffff68] */
    II(0x100ea317, 0x5)   mov(ebx, 0x1);                        /* mov ebx, 0x1 */
    II(0x100ea31c, 0x3)   lea(edx, ebp - 0x18);                 /* lea edx, [ebp-0x18] */
    II(0x100ea31f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ea322, 0x5)   calld(0x100ea18e, -0x199);            /* call 0x100ea18e */
    II(0x100ea327, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x100ea32a, 0x3)   lea(eax, ebp - 0x58);                 /* lea eax, [ebp-0x58] */
    II(0x100ea32d, 0x1)   pushd(eax);                           /* push eax */
    II(0x100ea32e, 0x6)   lea(ecx, ebp - 0x98);                 /* lea ecx, [ebp+0xffffff68] */
    II(0x100ea334, 0x5)   mov(ebx, 0xffffffff);                 /* mov ebx, 0xffffffff */
    II(0x100ea339, 0x3)   lea(edx, ebp - 0x18);                 /* lea edx, [ebp-0x18] */
    II(0x100ea33c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ea33f, 0x5)   calld(0x100ea18e, -0x1b6);            /* call 0x100ea18e */
    II(0x100ea344, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x100ea347, 0x3)   mov(al, memb_a32(ss, ebp - 0x4));     /* mov al, [ebp-0x4] */
    II(0x100ea34a, 0x3)   add(memb_a32(ss, ebp - 0x18), al);    /* add [ebp-0x18], al */
    II(0x100ea34d, 0x4)   movsx(eax, memb_a32(ss, ebp - 0x18)); /* movsx eax, byte [ebp-0x18] */
    II(0x100ea351, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x100ea353, 0x2)   jld(0x100ea35e, 0x9);                 /* jl 0x100ea35e */
    II(0x100ea355, 0x4)   movsx(eax, memb_a32(ss, ebp - 0x18)); /* movsx eax, byte [ebp-0x18] */
    II(0x100ea359, 0x3)   cmp(eax, 0x1f);                       /* cmp eax, 0x1f */
    II(0x100ea35c, 0x2)   jled(0x100ea367, 0x9);                /* jle 0x100ea367 */
l_0x100ea35e:
    II(0x100ea35e, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0x1);    /* mov byte [ebp-0xc], 0x1 */
    II(0x100ea362, 0x5)   jmpd(0x100ea3f9, 0x92);               /* jmp 0x100ea3f9 */
l_0x100ea367:
    II(0x100ea367, 0x3)   lea(edx, ebp - 0x18);                 /* lea edx, [ebp-0x18] */
    II(0x100ea36a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ea36d, 0x5)   calld(0x100ea067, -0x30b);            /* call 0x100ea067 */
    II(0x100ea372, 0x2)   test(al, al);                         /* test al, al */
    II(0x100ea374, 0x6)   jnzd(0x100ea3f9, 0x7f);               /* jnz dword 0x100ea3f9 */
    II(0x100ea37a, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0x1);    /* mov byte [ebp-0xc], 0x1 */
    II(0x100ea37e, 0x3)   mov(al, memb_a32(ss, ebp - 0x10));    /* mov al, [ebp-0x10] */
    II(0x100ea381, 0x3)   mov(memb_a32(ss, ebp - 0x17), al);    /* mov [ebp-0x17], al */
l_0x100ea384:
    II(0x100ea384, 0x4)   cmp(memb_a32(ss, ebp - 0xc), 0);      /* cmp byte [ebp-0xc], 0x0 */
    II(0x100ea388, 0x2)   jzd(0x100ea396, 0xc);                 /* jz 0x100ea396 */
    II(0x100ea38a, 0x4)   movsx(edx, memb_a32(ss, ebp - 0x17)); /* movsx edx, byte [ebp-0x17] */
    II(0x100ea38e, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x14)); /* movsx eax, word [ebp-0x14] */
    II(0x100ea392, 0x2)   cmp(edx, eax);                        /* cmp edx, eax */
    II(0x100ea394, 0x2)   jled(0x100ea398, 0x2);                /* jle 0x100ea398 */
l_0x100ea396:
    II(0x100ea396, 0x2)   jmpd(0x100ea3f9, 0x61);               /* jmp 0x100ea3f9 */
l_0x100ea398:
    II(0x100ea398, 0x4)   movsx(eax, memb_a32(ss, ebp - 0x17)); /* movsx eax, byte [ebp-0x17] */
    II(0x100ea39c, 0x2)   add(eax, eax);                        /* add eax, eax */
    II(0x100ea39e, 0x7)   mov(al, memb_a32(ds, eax + ebp - 0x98)); /* mov al, [eax+ebp+0xffffff68] */
    II(0x100ea3a5, 0x3)   mov(memb_a32(ss, ebp - 0x16), al);    /* mov [ebp-0x16], al */
l_0x100ea3a8:
    II(0x100ea3a8, 0x4)   movsx(eax, memb_a32(ss, ebp - 0x17)); /* movsx eax, byte [ebp-0x17] */
    II(0x100ea3ac, 0x2)   add(eax, eax);                        /* add eax, eax */
    II(0x100ea3ae, 0x4)   mov(eax, memd_a32(ds, eax + ebp - 0x5a)); /* mov eax, [eax+ebp-0x5a] */
    II(0x100ea3b2, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100ea3b5, 0x4)   movsx(edx, memb_a32(ss, ebp - 0x16)); /* movsx edx, byte [ebp-0x16] */
    II(0x100ea3b9, 0x2)   cmp(edx, eax);                        /* cmp edx, eax */
    II(0x100ea3bb, 0x2)   jgd(0x100ea3cc, 0xf);                 /* jg 0x100ea3cc */
    II(0x100ea3bd, 0x3)   lea(edx, ebp - 0x18);                 /* lea edx, [ebp-0x18] */
    II(0x100ea3c0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ea3c3, 0x5)   calld(0x100ea067, -0x361);            /* call 0x100ea067 */
    II(0x100ea3c8, 0x2)   test(al, al);                         /* test al, al */
    II(0x100ea3ca, 0x2)   jzd(0x100ea3ce, 0x2);                 /* jz 0x100ea3ce */
l_0x100ea3cc:
    II(0x100ea3cc, 0x2)   jmpd(0x100ea3d6, 0x8);                /* jmp 0x100ea3d6 */
l_0x100ea3ce:
    II(0x100ea3ce, 0x3)   mov(al, memb_a32(ss, ebp - 0x16));    /* mov al, [ebp-0x16] */
    II(0x100ea3d1, 0x3)   inc(memb_a32(ss, ebp - 0x16));        /* inc byte [ebp-0x16] */
    II(0x100ea3d4, 0x2)   jmpd(0x100ea3a8, -0x2e);              /* jmp 0x100ea3a8 */
l_0x100ea3d6:
    II(0x100ea3d6, 0x4)   movsx(eax, memb_a32(ss, ebp - 0x17)); /* movsx eax, byte [ebp-0x17] */
    II(0x100ea3da, 0x2)   add(eax, eax);                        /* add eax, eax */
    II(0x100ea3dc, 0x4)   mov(eax, memd_a32(ds, eax + ebp - 0x5a)); /* mov eax, [eax+ebp-0x5a] */
    II(0x100ea3e0, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100ea3e3, 0x4)   movsx(edx, memb_a32(ss, ebp - 0x16)); /* movsx edx, byte [ebp-0x16] */
    II(0x100ea3e7, 0x2)   cmp(edx, eax);                        /* cmp edx, eax */
    II(0x100ea3e9, 0x2)   jgd(0x100ea3f1, 0x6);                 /* jg 0x100ea3f1 */
    II(0x100ea3eb, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0);      /* mov byte [ebp-0xc], 0x0 */
    II(0x100ea3ef, 0x2)   jmpd(0x100ea3f7, 0x6);                /* jmp 0x100ea3f7 */
l_0x100ea3f1:
    II(0x100ea3f1, 0x3)   mov(al, memb_a32(ss, ebp - 0x17));    /* mov al, [ebp-0x17] */
    II(0x100ea3f4, 0x3)   inc(memb_a32(ss, ebp - 0x17));        /* inc byte [ebp-0x17] */
l_0x100ea3f7:
    II(0x100ea3f7, 0x2)   jmpd(0x100ea384, -0x75);              /* jmp 0x100ea384 */
l_0x100ea3f9:
    II(0x100ea3f9, 0x5)   jmpd(0x100ea303, -0xfb);              /* jmp 0x100ea303 */
l_0x100ea3fe:
    II(0x100ea3fe, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ea400, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ea401, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ea402, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ea403, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ea404, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ea405, 0x1)   retd();                               /* ret */
FUNC_END

