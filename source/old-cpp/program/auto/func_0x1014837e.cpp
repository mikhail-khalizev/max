FUNC_BEGIN(0x1014837e, 0x5660db32861a3a67, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xca, 0xd9, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0xb8, 0x61, 0, 0, 0, 0xe8, 0x32, 0x8c, 0x3, 0, 0x25, 0xfc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x55, 0xfc, 0xb8, 0x61, 0, 0, 0, 0xe8, 0x13, 0x8c, 0x3, 0, 0xe8, 0x20, 0x8c, 0x3, 0, 0xba, 0xb4, 0, 0, 0, 0xb8, 0x43, 0, 0, 0, 0xe8, 0xff, 0x8b, 0x3, 0, 0x31, 0xd2, 0xb8, 0x42, 0, 0, 0, 0xe8, 0xf3, 0x8b, 0x3, 0, 0x31, 0xd2, 0xb8, 0x42, 0, 0, 0, 0xe8, 0xe7, 0x8b, 0x3, 0, 0xe8, 0xf6, 0x8b, 0x3, 0, 0xb8, 0x61, 0, 0, 0, 0xe8, 0xe2, 0x8b, 0x3, 0, 0xc, 0x1, 0x89, 0x45, 0xfc, 0x8b, 0x55, 0xfc, 0xb8, 0x61, 0, 0, 0, 0xe8, 0xc6, 0x8b, 0x3, 0, 0xe8, 0x8d, 0xfe, 0xff, 0xff, 0xa3, 0x30, 0x81, 0x1c, 0x10, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1014837e, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10148383, 0x5)   calld(sys_check_available_stack_size, 0x1d9ca); /* call 0x10165d52 */
    II(0x10148388, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10148389, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1014838a, 0x1)   pushd(edx);                           /* push edx */
    II(0x1014838b, 0x1)   pushd(esi);                           /* push esi */
    II(0x1014838c, 0x1)   pushd(edi);                           /* push edi */
    II(0x1014838d, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1014838e, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10148390, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10148396, 0x5)   mov(eax, 0x61);                       /* mov eax, 0x61 */
    II(0x1014839b, 0x5)   calld(/* sys */ 0x10180fd2, 0x38c32); /* call 0x10180fd2 */
    II(0x101483a0, 0x5)   and_(eax, 0xfc);                      /* and eax, 0xfc */
    II(0x101483a5, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x101483a8, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x101483ab, 0x5)   mov(eax, 0x61);                       /* mov eax, 0x61 */
    II(0x101483b0, 0x5)   calld(/* sys */ 0x10180fc8, 0x38c13); /* call 0x10180fc8 */
    II(0x101483b5, 0x5)   calld(/* sys */ 0x10180fda, 0x38c20); /* call 0x10180fda */
    II(0x101483ba, 0x5)   mov(edx, 0xb4);                       /* mov edx, 0xb4 */
    II(0x101483bf, 0x5)   mov(eax, 0x43);                       /* mov eax, 0x43 */
    II(0x101483c4, 0x5)   calld(/* sys */ 0x10180fc8, 0x38bff); /* call 0x10180fc8 */
    II(0x101483c9, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x101483cb, 0x5)   mov(eax, 0x42);                       /* mov eax, 0x42 */
    II(0x101483d0, 0x5)   calld(/* sys */ 0x10180fc8, 0x38bf3); /* call 0x10180fc8 */
    II(0x101483d5, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x101483d7, 0x5)   mov(eax, 0x42);                       /* mov eax, 0x42 */
    II(0x101483dc, 0x5)   calld(/* sys */ 0x10180fc8, 0x38be7); /* call 0x10180fc8 */
    II(0x101483e1, 0x5)   calld(/* sys */ 0x10180fdc, 0x38bf6); /* call 0x10180fdc */
    II(0x101483e6, 0x5)   mov(eax, 0x61);                       /* mov eax, 0x61 */
    II(0x101483eb, 0x5)   calld(/* sys */ 0x10180fd2, 0x38be2); /* call 0x10180fd2 */
    II(0x101483f0, 0x2)   or_(al, 0x1);                         /* or al, 0x1 */
    II(0x101483f2, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x101483f5, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x101483f8, 0x5)   mov(eax, 0x61);                       /* mov eax, 0x61 */
    II(0x101483fd, 0x5)   calld(/* sys */ 0x10180fc8, 0x38bc6); /* call 0x10180fc8 */
    II(0x10148402, 0x5)   calld(0x10148294, -0x173);            /* call 0x10148294 */
    II(0x10148407, 0x5)   mov(memd_a32(ds, 0x101c8130), eax);   /* mov [0x101c8130], eax */
    II(0x1014840c, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1014840e, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1014840f, 0x1)   popd(edi);                            /* pop edi */
    II(0x10148410, 0x1)   popd(esi);                            /* pop esi */
    II(0x10148411, 0x1)   popd(edx);                            /* pop edx */
    II(0x10148412, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10148413, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10148414, 0x1)   retd();                               /* ret */
FUNC_END

