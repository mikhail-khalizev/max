FUNC_BEGIN(0x100cfd84, 0x523bccdab602928e, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xc4, 0x5f, 0x9, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x4f, 0xcd, 0xfc, 0xff, 0x8d, 0x4d, 0xf4, 0xbb, 0x40, 0x71, 0x1c, 0x10, 0xba, 0x6c, 0x14, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0xee, 0x60, 0x7, 0, 0x84, 0xc0, 0x74, 0x13, 0x8b, 0x45, 0xf4, 0x89, 0x45, 0xf0, 0x8d, 0x55, 0xf0, 0x8b, 0x45, 0xf8, 0xe8, 0xd5, 0xb4, 0xfb, 0xff, 0xeb, 0xd4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100cfd84, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x100cfd89, 0x5)   calld(sys_check_available_stack_size, 0x95fc4); /* call 0x10165d52 */
    II(0x100cfd8e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cfd8f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cfd90, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cfd91, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cfd92, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cfd93, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cfd95, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x100cfd9b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100cfd9e, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100cfda1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100cfda4, 0x5)   calld(0x1009caf8, -0x332b1);          /* call 0x1009caf8 */
l_0x100cfda9:
    II(0x100cfda9, 0x3)   lea(ecx, ebp - 0xc);                  /* lea ecx, [ebp-0xc] */
    II(0x100cfdac, 0x5)   mov(ebx, 0x101c7140);                 /* mov ebx, 0x101c7140 */
    II(0x100cfdb1, 0x5)   mov(edx, 0x101a146c);                 /* mov edx, 0x101a146c */ /* "unit" */
    II(0x100cfdb6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cfdb9, 0x5)   calld(0x10145eac, 0x760ee);           /* call 0x10145eac */
    II(0x100cfdbe, 0x2)   test(al, al);                         /* test al, al */
    II(0x100cfdc0, 0x2)   jzd(0x100cfdd5, 0x13);                /* jz 0x100cfdd5 */
    II(0x100cfdc2, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100cfdc5, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x100cfdc8, 0x3)   lea(edx, ebp - 0x10);                 /* lea edx, [ebp-0x10] */
    II(0x100cfdcb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100cfdce, 0x5)   calld(0x1008b2a8, -0x44b2b);          /* call 0x1008b2a8 */
    II(0x100cfdd3, 0x2)   jmpd(0x100cfda9, -0x2c);              /* jmp 0x100cfda9 */
l_0x100cfdd5:
    II(0x100cfdd5, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cfdd7, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cfdd8, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cfdd9, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cfdda, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cfddb, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cfddc, 0x1)   retd();                               /* ret */
FUNC_END

