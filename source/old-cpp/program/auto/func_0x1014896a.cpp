FUNC_BEGIN(0x1014896a, 0x765bc969bbba3936, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xde, 0xd3, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xb8, 0x4c, 0x81, 0x1c, 0x10, 0xe8, 0xd5, 0x83, 0xfd, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1014896a, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1014896f, 0x5)   calld(sys_check_available_stack_size, 0x1d3de); /* call 0x10165d52 */
    II(0x10148974, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10148975, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10148976, 0x1)   pushd(edx);                           /* push edx */
    II(0x10148977, 0x1)   pushd(esi);                           /* push esi */
    II(0x10148978, 0x1)   pushd(edi);                           /* push edi */
    II(0x10148979, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1014897a, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1014897c, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10148982, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10148985, 0x5)   mov(eax, 0x101c814c);                 /* mov eax, 0x101c814c */
    II(0x1014898a, 0x5)   calld(0x10120d64, -0x27c2b);          /* call 0x10120d64 */
    II(0x1014898f, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10148992, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10148995, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10148997, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10148998, 0x1)   popd(edi);                            /* pop edi */
    II(0x10148999, 0x1)   popd(esi);                            /* pop esi */
    II(0x1014899a, 0x1)   popd(edx);                            /* pop edx */
    II(0x1014899b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1014899c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1014899d, 0x1)   retd();                               /* ret */
FUNC_END

