FUNC_BEGIN(0x10159943, 0xf1dd0ac7e9c39672, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x5, 0xc4, 0, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x80, 0x78, 0x3d, 0x7, 0x75, 0x36, 0xb8, 0x6, 0x99, 0x15, 0x10, 0x50, 0xb9, 0x31, 0, 0, 0, 0xbb, 0x45, 0x26, 0x1b, 0x10, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0xe8, 0x4c, 0xe3, 0xff, 0xff, 0xb8, 0x12, 0x97, 0x15, 0x10, 0x50, 0xb9, 0x37, 0, 0, 0, 0xbb, 0x4c, 0x26, 0x1b, 0x10, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0xe8, 0x32, 0xe3, 0xff, 0xff, 0xeb, 0x1a, 0xb8, 0x80, 0x96, 0x15, 0x10, 0x50, 0xb9, 0x32, 0, 0, 0, 0xbb, 0x51, 0x26, 0x1b, 0x10, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0xe8, 0x16, 0xe3, 0xff, 0xff, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0xf7, 0xf1, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10159943, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10159948, 0x5)   calld(sys_check_available_stack_size, 0xc405); /* call 0x10165d52 */
    II(0x1015994d, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1015994e, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1015994f, 0x1)   pushd(esi);                           /* push esi */
    II(0x10159950, 0x1)   pushd(edi);                           /* push edi */
    II(0x10159951, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10159952, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10159954, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1015995a, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1015995d, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10159960, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10159963, 0x4)   cmp(memb_a32(ds, eax + 0x3d), 0x7);   /* cmp byte [eax+0x3d], 0x7 */
    II(0x10159967, 0x2)   jnzd(0x1015999f, 0x36);               /* jnz 0x1015999f */
    II(0x10159969, 0x5)   mov(eax, 0x10159906);                 /* mov eax, 0x10159906 */
    II(0x1015996e, 0x1)   pushd(eax);                           /* push eax */
    II(0x1015996f, 0x5)   mov(ecx, 0x31);                       /* mov ecx, 0x31 */
    II(0x10159974, 0x5)   mov(ebx, 0x101b2645);                 /* mov ebx, 0x101b2645 */ /* "resrch" */
    II(0x10159979, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1015997b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1015997e, 0x5)   calld(0x10157ccf, -0x1cb4);           /* call 0x10157ccf */
    II(0x10159983, 0x5)   mov(eax, 0x10159712);                 /* mov eax, 0x10159712 */
    II(0x10159988, 0x1)   pushd(eax);                           /* push eax */
    II(0x10159989, 0x5)   mov(ecx, 0x37);                       /* mov ecx, 0x37 */
    II(0x1015998e, 0x5)   mov(ebx, 0x101b264c);                 /* mov ebx, 0x101b264c */ /* "stop" */
    II(0x10159993, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10159995, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10159998, 0x5)   calld(0x10157ccf, -0x1cce);           /* call 0x10157ccf */
    II(0x1015999d, 0x2)   jmpd(0x101599b9, 0x1a);               /* jmp 0x101599b9 */
l_0x1015999f:
    II(0x1015999f, 0x5)   mov(eax, 0x10159680);                 /* mov eax, 0x10159680 */
    II(0x101599a4, 0x1)   pushd(eax);                           /* push eax */
    II(0x101599a5, 0x5)   mov(ecx, 0x32);                       /* mov ecx, 0x32 */
    II(0x101599aa, 0x5)   mov(ebx, 0x101b2651);                 /* mov ebx, 0x101b2651 */ /* "start" */
    II(0x101599af, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x101599b1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101599b4, 0x5)   calld(0x10157ccf, -0x1cea);           /* call 0x10157ccf */
l_0x101599b9:
    II(0x101599b9, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x101599bc, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101599bf, 0x5)   calld(0x10158bbb, -0xe09);            /* call 0x10158bbb */
    II(0x101599c4, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101599c6, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101599c7, 0x1)   popd(edi);                            /* pop edi */
    II(0x101599c8, 0x1)   popd(esi);                            /* pop esi */
    II(0x101599c9, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101599ca, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101599cb, 0x1)   retd();                               /* ret */
FUNC_END

