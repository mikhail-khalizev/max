FUNC_BEGIN(0x101514ef, 0x79343f74c550abce, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x59, 0x48, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xf6, 0x40, 0x13, 0x1, 0x74, 0xc, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x40, 0x78, 0x89, 0x45, 0xf4, 0xeb, 0x3a, 0x8b, 0x45, 0xfc, 0x8b, 0x58, 0x50, 0xc1, 0xfb, 0x10, 0x8b, 0x45, 0xfc, 0x8a, 0x40, 0x45, 0x30, 0xe4, 0xf, 0xbf, 0xd0, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x6, 0xc1, 0xf8, 0x10, 0xe8, 0x28, 0x37, 0xf8, 0xff, 0x89, 0x45, 0xf8, 0xf, 0xbf, 0x55, 0xf8, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x76, 0xc1, 0xf8, 0x10, 0xe8, 0x2e, 0x82, 0xf3, 0xff, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101514ef, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x101514f4, 0x5)   calld(sys_check_available_stack_size, 0x14859); /* call 0x10165d52 */
    II(0x101514f9, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101514fa, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101514fb, 0x1)   pushd(edx);                           /* push edx */
    II(0x101514fc, 0x1)   pushd(esi);                           /* push esi */
    II(0x101514fd, 0x1)   pushd(edi);                           /* push edi */
    II(0x101514fe, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101514ff, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10151501, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10151507, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1015150a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1015150d, 0x4)   test(memb_a32(ds, eax + 0x13), 0x1);  /* test byte [eax+0x13], 0x1 */
    II(0x10151511, 0x2)   jzd(0x1015151f, 0xc);                 /* jz 0x1015151f */
    II(0x10151513, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10151516, 0x4)   mov(ax, memw_a32(ds, eax + 0x78));    /* mov ax, [eax+0x78] */
    II(0x1015151a, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x1015151d, 0x2)   jmpd(0x10151559, 0x3a);               /* jmp 0x10151559 */
l_0x1015151f:
    II(0x1015151f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10151522, 0x3)   mov(ebx, memd_a32(ds, eax + 0x50));   /* mov ebx, [eax+0x50] */
    II(0x10151525, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x10151528, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1015152b, 0x3)   mov(al, memb_a32(ds, eax + 0x45));    /* mov al, [eax+0x45] */
    II(0x1015152e, 0x2)   xor_(ah, ah);                         /* xor ah, ah */
    II(0x10151530, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x10151533, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10151536, 0x3)   mov(eax, memd_a32(ds, eax + 0x6));    /* mov eax, [eax+0x6] */
    II(0x10151539, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1015153c, 0x5)   calld(0x100d4c69, -0x7c8d8);          /* call 0x100d4c69 */
    II(0x10151541, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10151544, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x8));  /* movsx edx, word [ebp-0x8] */
    II(0x10151548, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1015154b, 0x3)   mov(eax, memd_a32(ds, eax + 0x76));   /* mov eax, [eax+0x76] */
    II(0x1015154e, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x10151551, 0x5)   calld(my_min, -0xc7dd2);              /* call 0x10089784 */
    II(0x10151556, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
l_0x10151559:
    II(0x10151559, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1015155c, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1015155e, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1015155f, 0x1)   popd(edi);                            /* pop edi */
    II(0x10151560, 0x1)   popd(esi);                            /* pop esi */
    II(0x10151561, 0x1)   popd(edx);                            /* pop edx */
    II(0x10151562, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10151563, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10151564, 0x1)   retd();                               /* ret */
FUNC_END

