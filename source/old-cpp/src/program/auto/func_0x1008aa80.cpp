FUNC_BEGIN(0x1008aa80, 0x2f99f3f6feabd062, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xc8, 0xb2, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x80, 0xdd, 0, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1008aa80, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1008aa85, 0x5)   calld(sys_check_available_stack_size, 0xdb2c8); /* call 0x10165d52 */
    II(0x1008aa8a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008aa8b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008aa8c, 0x1)   pushd(edx);                           /* push edx */
    II(0x1008aa8d, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008aa8e, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008aa8f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008aa90, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008aa92, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1008aa98, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1008aa9b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008aa9e, 0x6)   mov(eax, memd_a32(ds, eax + 0xdd));   /* mov eax, [eax+0xdd] */
    II(0x1008aaa4, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1008aaa7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008aaaa, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008aaac, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008aaad, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008aaae, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008aaaf, 0x1)   popd(edx);                            /* pop edx */
    II(0x1008aab0, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008aab1, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008aab2, 0x1)   retd();                               /* ret */
FUNC_END

