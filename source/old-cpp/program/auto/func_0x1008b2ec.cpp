FUNC_BEGIN(0x1008b2ec, 0xb21bec81acf96f13, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x5c, 0xaa, 0xd, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x89, 0x5d, 0xfc, 0xf, 0xbf, 0x5d, 0xfc, 0x8b, 0x55, 0xf8, 0x8b, 0x45, 0xf4, 0xe8, 0xf6, 0, 0, 0, 0x83, 0xc0, 0x6, 0xe8, 0x6e, 0x26, 0x4, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x1008b2ec, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1008b2f1, 0x5)   calld(sys_check_available_stack_size, 0xdaa5c); /* call 0x10165d52 */
    II(0x1008b2f6, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008b2f7, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008b2f8, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008b2f9, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008b2fa, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008b2fc, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1008b302, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x1008b305, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x1008b308, 0x3)   mov(memd_a32(ss, ebp - 0x4), ebx);    /* mov [ebp-0x4], ebx */
    II(0x1008b30b, 0x4)   movsx(ebx, memw_a32(ss, ebp - 0x4));  /* movsx ebx, word [ebp-0x4] */
    II(0x1008b30f, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x1008b312, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1008b315, 0x5)   calld(0x1008b410, 0xf6);              /* call 0x1008b410 */
    II(0x1008b31a, 0x3)   add(eax, 0x6);                        /* add eax, 0x6 */
    II(0x1008b31d, 0x5)   calld(0x100cd990, 0x4266e);           /* call 0x100cd990 */
    II(0x1008b322, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008b324, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008b325, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008b326, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008b327, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008b328, 0x1)   retd();                               /* ret */
FUNC_END

