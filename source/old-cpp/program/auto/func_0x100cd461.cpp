FUNC_BEGIN(0x100cd461, 0x14c861123b2c4fee, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xe7, 0x88, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0x49, 0x91, 0xfa, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xfc, 0x8b, 0x58, 0x7, 0xc1, 0xfb, 0x10, 0x69, 0xdb, 0xc5, 0, 0, 0, 0xb8, 0xc4, 0x31, 0x1c, 0x10, 0x1, 0xd8, 0xe8, 0x96, 0x5f, 0xff, 0xff, 0x84, 0xc0, 0x74, 0x25, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0xc1, 0x90, 0xfa, 0xff, 0xe8, 0xee, 0x34, 0x8, 0, 0xf, 0xbf, 0xd0, 0x89, 0xd0, 0xc1, 0xfa, 0x1f, 0xc1, 0xe2, 0x2, 0x1b, 0xc2, 0xc1, 0xf8, 0x2, 0x89, 0x45, 0xf8, 0xeb, 0x7, 0xc7, 0x45, 0xf8, 0x1, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100cd461, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100cd466, 0x5)   calld(sys_check_available_stack_size, 0x988e7); /* call 0x10165d52 */
    II(0x100cd46b, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cd46c, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cd46d, 0x1)   pushd(edx);                           /* push edx */
    II(0x100cd46e, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cd46f, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cd470, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cd471, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cd473, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100cd479, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100cd47c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cd47f, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100cd482, 0x5)   calld(0x100765d0, -0x56eb7);          /* call 0x100765d0 */
    II(0x100cd487, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x100cd489, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cd48c, 0x3)   mov(ebx, memd_a32(ds, eax + 0x7));    /* mov ebx, [eax+0x7] */
    II(0x100cd48f, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x100cd492, 0x6)   imul(ebx, ebx, 0xc5);                 /* imul ebx, ebx, 0xc5 */
    II(0x100cd498, 0x5)   mov(eax, 0x101c31c4);                 /* mov eax, 0x101c31c4 */
    II(0x100cd49d, 0x2)   add(eax, ebx);                        /* add eax, ebx */
    II(0x100cd49f, 0x5)   calld(0x100c343a, -0xa06a);           /* call 0x100c343a */
    II(0x100cd4a4, 0x2)   test(al, al);                         /* test al, al */
    II(0x100cd4a6, 0x2)   jzd(0x100cd4cd, 0x25);                /* jz 0x100cd4cd */
    II(0x100cd4a8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cd4ab, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100cd4ae, 0x5)   calld(0x10076574, -0x56f3f);          /* call 0x10076574 */
    II(0x100cd4b3, 0x5)   calld(0x101509a6, 0x834ee);           /* call 0x101509a6 */
    II(0x100cd4b8, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x100cd4bb, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x100cd4bd, 0x3)   sar(edx, 0x1f);                       /* sar edx, 0x1f */
    II(0x100cd4c0, 0x3)   shl(edx, 0x2);                        /* shl edx, 0x2 */
    II(0x100cd4c3, 0x2)   sbb(eax, edx);                        /* sbb eax, edx */
    II(0x100cd4c5, 0x3)   sar(eax, 0x2);                        /* sar eax, 0x2 */
    II(0x100cd4c8, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100cd4cb, 0x2)   jmpd(0x100cd4d4, 0x7);                /* jmp 0x100cd4d4 */
l_0x100cd4cd:
    II(0x100cd4cd, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0x1);    /* mov dword [ebp-0x8], 0x1 */
l_0x100cd4d4:
    II(0x100cd4d4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100cd4d7, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cd4d9, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cd4da, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cd4db, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cd4dc, 0x1)   popd(edx);                            /* pop edx */
    II(0x100cd4dd, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cd4de, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cd4df, 0x1)   retd();                               /* ret */
FUNC_END

