FUNC_BEGIN(0x100cafa0, 0x2c1089682ca2dc10, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xa8, 0xad, 0x9, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0xe7, 0xf5, 0x6, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100cafa0, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100cafa5, 0x5)   calld(sys_check_available_stack_size, 0x9ada8); /* call 0x10165d52 */
    II(0x100cafaa, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cafab, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cafac, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cafad, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cafae, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cafaf, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cafb1, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100cafb7, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100cafba, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100cafbd, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x100cafc0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100cafc3, 0x5)   calld(0x1013a5af, 0x6f5e7);           /* call 0x1013a5af */
    II(0x100cafc8, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cafca, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cafcb, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cafcc, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cafcd, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cafce, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cafcf, 0x1)   retd();                               /* ret */
FUNC_END

