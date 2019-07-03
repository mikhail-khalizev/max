FUNC_BEGIN(0x10089894, 0xf0c855643d91c07, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xb4, 0xc4, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x8, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10089894, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10089899, 0x5)   calld(sys_check_available_stack_size, 0xdc4b4); /* call 0x10165d52 */
    II(0x1008989e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008989f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100898a0, 0x1)   pushd(edx);                           /* push edx */
    II(0x100898a1, 0x1)   pushd(esi);                           /* push esi */
    II(0x100898a2, 0x1)   pushd(edi);                           /* push edi */
    II(0x100898a3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100898a4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100898a6, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100898ac, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100898af, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100898b2, 0x3)   add(eax, 0x8);                        /* add eax, 0x8 */
    II(0x100898b5, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100898b8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100898bb, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100898bd, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100898be, 0x1)   popd(edi);                            /* pop edi */
    II(0x100898bf, 0x1)   popd(esi);                            /* pop esi */
    II(0x100898c0, 0x1)   popd(edx);                            /* pop edx */
    II(0x100898c1, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100898c2, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100898c3, 0x1)   retd();                               /* ret */
FUNC_END

