FUNC_BEGIN(0x10146562, 0xfd416497f9e17034, 0x20, ({0x68, 0x30, 0, 0, 0, 0xe8, 0xe6, 0xf7, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x14, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x5c, 0x53, 0xff, 0xff, 0x89, 0x45, 0xfc, 0x8d, 0x45, 0xfc, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0xe, 0xe8, 0x87, 0xa1, 0xf9, 0xff, 0x83, 0xe8, 0xe, 0x89, 0x45, 0xfc, 0x8d, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x12, 0xe8, 0x9c, 0x12, 0, 0, 0x83, 0xe8, 0x12, 0x89, 0x45, 0xfc, 0x8d, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xec, 0x8b, 0x45, 0xec, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10146562, 0x5)   pushd(0x30);                          /* push dword 0x30 */
    II(0x10146567, 0x5)   calld(sys_check_available_stack_size, 0x1f7e6); /* call 0x10165d52 */
    II(0x1014656c, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1014656d, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1014656e, 0x1)   pushd(edx);                           /* push edx */
    II(0x1014656f, 0x1)   pushd(esi);                           /* push esi */
    II(0x10146570, 0x1)   pushd(edi);                           /* push edi */
    II(0x10146571, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10146572, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10146574, 0x6)   sub(esp, 0x14);                       /* sub esp, 0x14 */
    II(0x1014657a, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1014657d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10146580, 0x5)   calld(0x1013b8e1, -0xaca4);           /* call 0x1013b8e1 */
    II(0x10146585, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10146588, 0x3)   lea(eax, ebp - 0x4);                  /* lea eax, [ebp-0x4] */
    II(0x1014658b, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x1014658e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10146591, 0x3)   add(eax, 0xe);                        /* add eax, 0xe */
    II(0x10146594, 0x5)   calld(0x100e0720, -0x65e79);          /* call 0x100e0720 */
    II(0x10146599, 0x3)   sub(eax, 0xe);                        /* sub eax, 0xe */
    II(0x1014659c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1014659f, 0x3)   lea(eax, ebp - 0x4);                  /* lea eax, [ebp-0x4] */
    II(0x101465a2, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x101465a5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101465a8, 0x3)   add(eax, 0x12);                       /* add eax, 0x12 */
    II(0x101465ab, 0x5)   calld(0x1014784c, 0x129c);            /* call 0x1014784c */
    II(0x101465b0, 0x3)   sub(eax, 0x12);                       /* sub eax, 0x12 */
    II(0x101465b3, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x101465b6, 0x3)   lea(eax, ebp - 0x4);                  /* lea eax, [ebp-0x4] */
    II(0x101465b9, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x101465bc, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101465bf, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
//    II(0x101465c2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x101465c5, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101465c7, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101465c8, 0x1)   popd(edi);                            /* pop edi */
    II(0x101465c9, 0x1)   popd(esi);                            /* pop esi */
    II(0x101465ca, 0x1)   popd(edx);                            /* pop edx */
    II(0x101465cb, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101465cc, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101465cd, 0x1)   retd();                               /* ret */
FUNC_END

