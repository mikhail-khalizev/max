FUNC_BEGIN(0x100cfbbe, 0xf25066c3c796207e, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x8a, 0x61, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x50, 0x33, 0xc1, 0xfa, 0x10, 0xb8, 0x78, 0x72, 0x1c, 0x10, 0xe8, 0x6d, 0xe0, 0x6, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100cfbbe, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100cfbc3, 0x5)   calld(sys_check_available_stack_size, 0x9618a); /* call 0x10165d52 */
    II(0x100cfbc8, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cfbc9, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cfbca, 0x1)   pushd(edx);                           /* push edx */
    II(0x100cfbcb, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cfbcc, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cfbcd, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cfbce, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cfbd0, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100cfbd6, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100cfbd9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cfbdc, 0x3)   mov(edx, memd_a32(ds, eax + 0x33));   /* mov edx, [eax+0x33] */
    II(0x100cfbdf, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x100cfbe2, 0x5)   mov(eax, 0x101c7278);                 /* mov eax, 0x101c7278 */
    II(0x100cfbe7, 0x5)   calld(0x1013dc59, 0x6e06d);           /* call 0x1013dc59 */
    II(0x100cfbec, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cfbee, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cfbef, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cfbf0, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cfbf1, 0x1)   popd(edx);                            /* pop edx */
    II(0x100cfbf2, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cfbf3, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cfbf4, 0x1)   retd();                               /* ret */
FUNC_END

