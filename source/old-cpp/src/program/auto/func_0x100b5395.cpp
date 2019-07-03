FUNC_BEGIN(0x100b5395, 0x655c5b65bc3145a1, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xb3, 0x9, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc7, 0x45, 0xf8, 0x4, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100b5395, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100b539a, 0x5)   calld(sys_check_available_stack_size, 0xb09b3); /* call 0x10165d52 */
    II(0x100b539f, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b53a0, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b53a1, 0x1)   pushd(edx);                           /* push edx */
    II(0x100b53a2, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b53a3, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b53a4, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b53a5, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b53a7, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100b53ad, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100b53b0, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0x4);    /* mov dword [ebp-0x8], 0x4 */
    II(0x100b53b7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b53ba, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b53bc, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b53bd, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b53be, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b53bf, 0x1)   popd(edx);                            /* pop edx */
    II(0x100b53c0, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b53c1, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b53c2, 0x1)   retd();                               /* ret */
FUNC_END

