FUNC_BEGIN(0x100e0580, 0x661d0ab24ed05574, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xc8, 0x57, 0x8, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x28, 0x67, 0xf9, 0xff, 0x89, 0x45, 0xf8, 0x8d, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xf0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100e0580, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x100e0585, 0x5)   calld(sys_check_available_stack_size, 0x857c8); /* call 0x10165d52 */
    II(0x100e058a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e058b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e058c, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e058d, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e058e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e058f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e0591, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x100e0597, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100e059a, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100e059d, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x100e05a0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100e05a3, 0x5)   calld(0x10076cd0, -0x698d8);          /* call 0x10076cd0 */
    II(0x100e05a8, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100e05ab, 0x3)   lea(eax, ebp - 0x8);                  /* lea eax, [ebp-0x8] */
    II(0x100e05ae, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x100e05b1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100e05b4, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
//    II(0x100e05b7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100e05ba, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e05bc, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e05bd, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e05be, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e05bf, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e05c0, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e05c1, 0x1)   retd();                               /* ret */
FUNC_END

