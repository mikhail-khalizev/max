FUNC_BEGIN(0x101327ed, 0xd4fa9ec027c008bc, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x5b, 0x35, 0x3, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x66, 0x8b, 0x40, 0x5, 0x48, 0xf, 0xbf, 0xd0, 0x8b, 0x45, 0xf4, 0xe8, 0xe2, 0xfe, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x101327ed, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x101327f2, 0x5)   calld(sys_check_available_stack_size, 0x3355b); /* call 0x10165d52 */
    II(0x101327f7, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101327f8, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101327f9, 0x1)   pushd(esi);                           /* push esi */
    II(0x101327fa, 0x1)   pushd(edi);                           /* push edi */
    II(0x101327fb, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101327fc, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101327fe, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10132804, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10132807, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1013280a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013280d, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x10132810, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10132813, 0x4)   mov(ax, memw_a32(ds, eax + 0x5));     /* mov ax, [eax+0x5] */
    II(0x10132817, 0x1)   dec(eax);                             /* dec eax */
    II(0x10132818, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x1013281b, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1013281e, 0x5)   calld(0x10132705, -0x11e);            /* call 0x10132705 */
    II(0x10132823, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10132825, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10132826, 0x1)   popd(edi);                            /* pop edi */
    II(0x10132827, 0x1)   popd(esi);                            /* pop esi */
    II(0x10132828, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10132829, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013282a, 0x1)   retd();                               /* ret */
FUNC_END

