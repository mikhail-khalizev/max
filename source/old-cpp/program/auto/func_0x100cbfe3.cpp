FUNC_BEGIN(0x100cbfe3, 0x41d5a55d336bd533, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x65, 0x9d, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0x6b, 0xa5, 0xfa, 0xff, 0x31, 0xd2, 0x8a, 0x50, 0x4d, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0x5b, 0xa5, 0xfa, 0xff, 0xe8, 0x1e, 0xa2, 0xfa, 0xff, 0x8b, 0x40, 0x8, 0xc1, 0xf8, 0x10, 0x39, 0xc2, 0x7d, 0x6, 0xc6, 0x45, 0xf8, 0, 0xeb, 0x4b, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0x3b, 0xa5, 0xfa, 0xff, 0x80, 0x78, 0x3e, 0x3, 0x75, 0x2a, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0x2a, 0xa5, 0xfa, 0xff, 0x31, 0xd2, 0x8a, 0x50, 0x54, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0x1a, 0xa5, 0xfa, 0xff, 0xe8, 0xdd, 0xa1, 0xfa, 0xff, 0x8b, 0x40, 0x19, 0xc1, 0xf8, 0x10, 0x39, 0xc2, 0x7c, 0x6, 0xc6, 0x45, 0xf4, 0x1, 0xeb, 0x4, 0xc6, 0x45, 0xf4, 0, 0x8a, 0x45, 0xf4, 0x88, 0x45, 0xf8, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100cbfe3, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x100cbfe8, 0x5)   calld(sys_check_available_stack_size, 0x99d65); /* call 0x10165d52 */
    II(0x100cbfed, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cbfee, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cbfef, 0x1)   pushd(edx);                           /* push edx */
    II(0x100cbff0, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cbff1, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cbff2, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cbff3, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cbff5, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100cbffb, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100cbffe, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cc001, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100cc004, 0x5)   calld(0x10076574, -0x55a95);          /* call 0x10076574 */
    II(0x100cc009, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100cc00b, 0x3)   mov(dl, memb_a32(ds, eax + 0x4d));    /* mov dl, [eax+0x4d] */
    II(0x100cc00e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cc011, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100cc014, 0x5)   calld(0x10076574, -0x55aa5);          /* call 0x10076574 */
    II(0x100cc019, 0x5)   calld(0x1007623c, -0x55de2);          /* call 0x1007623c */
    II(0x100cc01e, 0x3)   mov(eax, memd_a32(ds, eax + 0x8));    /* mov eax, [eax+0x8] */
    II(0x100cc021, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100cc024, 0x2)   cmp(edx, eax);                        /* cmp edx, eax */
    II(0x100cc026, 0x2)   jged(0x100cc02e, 0x6);                /* jge 0x100cc02e */
    II(0x100cc028, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0);      /* mov byte [ebp-0x8], 0x0 */
    II(0x100cc02c, 0x2)   jmpd(0x100cc079, 0x4b);               /* jmp 0x100cc079 */
l_0x100cc02e:
    II(0x100cc02e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cc031, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100cc034, 0x5)   calld(0x10076574, -0x55ac5);          /* call 0x10076574 */
    II(0x100cc039, 0x4)   cmp(memb_a32(ds, eax + 0x3e), 0x3);   /* cmp byte [eax+0x3e], 0x3 */
    II(0x100cc03d, 0x2)   jnzd(0x100cc069, 0x2a);               /* jnz 0x100cc069 */
    II(0x100cc03f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cc042, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100cc045, 0x5)   calld(0x10076574, -0x55ad6);          /* call 0x10076574 */
    II(0x100cc04a, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100cc04c, 0x3)   mov(dl, memb_a32(ds, eax + 0x54));    /* mov dl, [eax+0x54] */
    II(0x100cc04f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cc052, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100cc055, 0x5)   calld(0x10076574, -0x55ae6);          /* call 0x10076574 */
    II(0x100cc05a, 0x5)   calld(0x1007623c, -0x55e23);          /* call 0x1007623c */
    II(0x100cc05f, 0x3)   mov(eax, memd_a32(ds, eax + 0x19));   /* mov eax, [eax+0x19] */
    II(0x100cc062, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100cc065, 0x2)   cmp(edx, eax);                        /* cmp edx, eax */
    II(0x100cc067, 0x2)   jld(0x100cc06f, 0x6);                 /* jl 0x100cc06f */
l_0x100cc069:
    II(0x100cc069, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0x1);    /* mov byte [ebp-0xc], 0x1 */
    II(0x100cc06d, 0x2)   jmpd(0x100cc073, 0x4);                /* jmp 0x100cc073 */
l_0x100cc06f:
    II(0x100cc06f, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0);      /* mov byte [ebp-0xc], 0x0 */
l_0x100cc073:
    II(0x100cc073, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x100cc076, 0x3)   mov(memb_a32(ss, ebp - 0x8), al);     /* mov [ebp-0x8], al */
l_0x100cc079:
    II(0x100cc079, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x100cc07c, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cc07e, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cc07f, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cc080, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cc081, 0x1)   popd(edx);                            /* pop edx */
    II(0x100cc082, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cc083, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cc084, 0x1)   retd();                               /* ret */
FUNC_END

