FUNC_BEGIN(0x1007678c, 0x981a2011ae67d2a4, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xbc, 0xf5, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1007678c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10076791, 0x5)   calld(sys_check_available_stack_size, 0xef5bc); /* call 0x10165d52 */
    II(0x10076796, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10076797, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10076798, 0x1)   pushd(edx);                           /* push edx */
    II(0x10076799, 0x1)   pushd(esi);                           /* push esi */
    II(0x1007679a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1007679b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1007679c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1007679e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100767a4, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100767a7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100767aa, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x100767ac, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100767af, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100767b2, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100767b4, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100767b5, 0x1)   popd(edi);                            /* pop edi */
    II(0x100767b6, 0x1)   popd(esi);                            /* pop esi */
    II(0x100767b7, 0x1)   popd(edx);                            /* pop edx */
    II(0x100767b8, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100767b9, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100767ba, 0x1)   retd();                               /* ret */
FUNC_END

