FUNC_BEGIN(0x100c89d1, 0x355aa5dd3a327843, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x77, 0xd3, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x7, 0xc1, 0xf8, 0x10, 0x69, 0xd0, 0xc5, 0, 0, 0, 0xb8, 0xc4, 0x31, 0x1c, 0x10, 0x1, 0xd0, 0xe8, 0xa, 0x45, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100c89d1, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100c89d6, 0x5)   calld(sys_check_available_stack_size, 0x9d377); /* call 0x10165d52 */
    II(0x100c89db, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100c89dc, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100c89dd, 0x1)   pushd(edx);                           /* push edx */
    II(0x100c89de, 0x1)   pushd(esi);                           /* push esi */
    II(0x100c89df, 0x1)   pushd(edi);                           /* push edi */
    II(0x100c89e0, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100c89e1, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100c89e3, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100c89e9, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100c89ec, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100c89ef, 0x3)   mov(eax, memd_a32(ds, eax + 0x7));    /* mov eax, [eax+0x7] */
    II(0x100c89f2, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100c89f5, 0x6)   imul(edx, eax, 0xc5);                 /* imul edx, eax, 0xc5 */
    II(0x100c89fb, 0x5)   mov(eax, 0x101c31c4);                 /* mov eax, 0x101c31c4 */
    II(0x100c8a00, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x100c8a02, 0x5)   calld(0x100bcf11, -0xbaf6);           /* call 0x100bcf11 */
    II(0x100c8a07, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100c8a09, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100c8a0a, 0x1)   popd(edi);                            /* pop edi */
    II(0x100c8a0b, 0x1)   popd(esi);                            /* pop esi */
    II(0x100c8a0c, 0x1)   popd(edx);                            /* pop edx */
    II(0x100c8a0d, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100c8a0e, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100c8a0f, 0x1)   retd();                               /* ret */
FUNC_END

