FUNC_BEGIN(0x1015012d, 0x8cf14220a01716bf, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x1b, 0x5c, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x6c, 0xe8, 0xdd, 0x65, 0xf2, 0xff, 0x8b, 0x55, 0xfc, 0x8a, 0x52, 0x4d, 0x30, 0xf6, 0x66, 0x8b, 0x40, 0xa, 0x29, 0xd0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x6c, 0xe8, 0xc1, 0x65, 0xf2, 0xff, 0x8b, 0x50, 0x8, 0xc1, 0xfa, 0x10, 0xc1, 0xe2, 0x2, 0x8b, 0x45, 0xfc, 0xe8, 0x26, 0x8, 0, 0, 0x98, 0xf, 0xbf, 0x5d, 0xf8, 0xf, 0xaf, 0xc3, 0x1, 0xc2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x6c, 0xe8, 0x9b, 0x65, 0xf2, 0xff, 0x8b, 0x40, 0x8, 0xc1, 0xf8, 0x10, 0xc1, 0xe0, 0x2, 0x89, 0xc3, 0x4a, 0x89, 0xd0, 0xc1, 0xfa, 0x1f, 0xf7, 0xfb, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1015012d, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x10150132, 0x5)   calld(sys_check_available_stack_size, 0x15c1b); /* call 0x10165d52 */
    II(0x10150137, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10150138, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10150139, 0x1)   pushd(edx);                           /* push edx */
    II(0x1015013a, 0x1)   pushd(esi);                           /* push esi */
    II(0x1015013b, 0x1)   pushd(edi);                           /* push edi */
    II(0x1015013c, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1015013d, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1015013f, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10150145, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10150148, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1015014b, 0x3)   add(eax, 0x6c);                       /* add eax, 0x6c */
    II(0x1015014e, 0x5)   calld(0x10076730, -0xd9a23);          /* call 0x10076730 */
    II(0x10150153, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x10150156, 0x3)   mov(dl, memb_a32(ds, edx + 0x4d));    /* mov dl, [edx+0x4d] */
    II(0x10150159, 0x2)   xor_(dh, dh);                         /* xor dh, dh */
    II(0x1015015b, 0x4)   mov(ax, memw_a32(ds, eax + 0xa));     /* mov ax, [eax+0xa] */
    II(0x1015015f, 0x2)   sub(eax, edx);                        /* sub eax, edx */
    II(0x10150161, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10150164, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10150167, 0x3)   add(eax, 0x6c);                       /* add eax, 0x6c */
    II(0x1015016a, 0x5)   calld(0x10076730, -0xd9a3f);          /* call 0x10076730 */
    II(0x1015016f, 0x3)   mov(edx, memd_a32(ds, eax + 0x8));    /* mov edx, [eax+0x8] */
    II(0x10150172, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x10150175, 0x3)   shl(edx, 0x2);                        /* shl edx, 0x2 */
    II(0x10150178, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1015017b, 0x5)   calld(0x101509a6, 0x826);             /* call 0x101509a6 */
    II(0x10150180, 0x1)   cwde();                               /* cwde */
    II(0x10150181, 0x4)   movsx(ebx, memw_a32(ss, ebp - 0x8));  /* movsx ebx, word [ebp-0x8] */
    II(0x10150185, 0x3)   imul(eax, ebx);                       /* imul eax, ebx */
    II(0x10150188, 0x2)   add(edx, eax);                        /* add edx, eax */
    II(0x1015018a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1015018d, 0x3)   add(eax, 0x6c);                       /* add eax, 0x6c */
    II(0x10150190, 0x5)   calld(0x10076730, -0xd9a65);          /* call 0x10076730 */
    II(0x10150195, 0x3)   mov(eax, memd_a32(ds, eax + 0x8));    /* mov eax, [eax+0x8] */
    II(0x10150198, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1015019b, 0x3)   shl(eax, 0x2);                        /* shl eax, 0x2 */
    II(0x1015019e, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x101501a0, 0x1)   dec(edx);                             /* dec edx */
    II(0x101501a1, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x101501a3, 0x3)   sar(edx, 0x1f);                       /* sar edx, 0x1f */
    II(0x101501a6, 0x2)   idiv(ebx);                            /* idiv ebx */
    II(0x101501a8, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x101501ab, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x101501ae, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101501b0, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101501b1, 0x1)   popd(edi);                            /* pop edi */
    II(0x101501b2, 0x1)   popd(esi);                            /* pop esi */
    II(0x101501b3, 0x1)   popd(edx);                            /* pop edx */
    II(0x101501b4, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101501b5, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101501b6, 0x1)   retd();                               /* ret */
FUNC_END

