FUNC_BEGIN(0x100cafd0, 0x57d8167bf145d8a4, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x78, 0xad, 0x9, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0xb3, 0xf2, 0x6, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100cafd0, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100cafd5, 0x5)   calld(sys_check_available_stack_size, 0x9ad78); /* call 0x10165d52 */
    II(0x100cafda, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cafdb, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cafdc, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cafdd, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cafde, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cafdf, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cafe1, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100cafe7, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100cafea, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100cafed, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x100caff0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100caff3, 0x5)   calld(0x1013a2ab, 0x6f2b3);           /* call 0x1013a2ab */
    II(0x100caff8, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100caffa, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100caffb, 0x1)   popd(edi);                            /* pop edi */
    II(0x100caffc, 0x1)   popd(esi);                            /* pop esi */
    II(0x100caffd, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100caffe, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cafff, 0x1)   retd();                               /* ret */
FUNC_END

