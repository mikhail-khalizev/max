FUNC_BEGIN(0x1008bdc7, 0x81e57ba7cfe6101f, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x81, 0x9f, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc7, 0x45, 0xf8, 0x4, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1008bdc7, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1008bdcc, 0x5)   calld(sys_check_available_stack_size, 0xd9f81); /* call 0x10165d52 */
    II(0x1008bdd1, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008bdd2, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008bdd3, 0x1)   pushd(edx);                           /* push edx */
    II(0x1008bdd4, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008bdd5, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008bdd6, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008bdd7, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008bdd9, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1008bddf, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1008bde2, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0x4);    /* mov dword [ebp-0x8], 0x4 */
    II(0x1008bde9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008bdec, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008bdee, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008bdef, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008bdf0, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008bdf1, 0x1)   popd(edx);                            /* pop edx */
    II(0x1008bdf2, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008bdf3, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008bdf4, 0x1)   retd();                               /* ret */
FUNC_END

