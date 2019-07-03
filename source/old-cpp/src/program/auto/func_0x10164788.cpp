FUNC_BEGIN(0x10164788, 0xddc3fd0441a305aa, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xc0, 0x15, 0, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x8b, 0x18, 0xc1, 0xfb, 0x10, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x8, 0, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10164788, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1016478d, 0x5)   calld(sys_check_available_stack_size, 0x15c0); /* call 0x10165d52 */
    II(0x10164792, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10164793, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10164794, 0x1)   pushd(esi);                           /* push esi */
    II(0x10164795, 0x1)   pushd(edi);                           /* push edi */
    II(0x10164796, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10164797, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10164799, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1016479f, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x101647a2, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x101647a5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101647a8, 0x2)   mov(ebx, memd_a32(ds, eax));          /* mov ebx, [eax] */
    II(0x101647aa, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x101647ad, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x101647b0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101647b3, 0x5)   calld(0x101647c0, 0x8);               /* call 0x101647c0 */
    II(0x101647b8, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101647ba, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101647bb, 0x1)   popd(edi);                            /* pop edi */
    II(0x101647bc, 0x1)   popd(esi);                            /* pop esi */
    II(0x101647bd, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101647be, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101647bf, 0x1)   retd();                               /* ret */
FUNC_END

