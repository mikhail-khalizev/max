FUNC_BEGIN(0x10108dfa, 0xb18e70fbeae37264, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x4e, 0xcf, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0xc7, 0x40, 0x9, 0, 0, 0x8b, 0x45, 0xfc, 0xc7, 0x40, 0x4, 0x1, 0, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10108dfa, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10108dff, 0x5)   calld(sys_check_available_stack_size, 0x5cf4e); /* call 0x10165d52 */
    II(0x10108e04, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10108e05, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10108e06, 0x1)   pushd(edx);                           /* push edx */
    II(0x10108e07, 0x1)   pushd(esi);                           /* push esi */
    II(0x10108e08, 0x1)   pushd(edi);                           /* push edi */
    II(0x10108e09, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10108e0a, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10108e0c, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10108e12, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10108e15, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10108e18, 0x6)   mov(memw_a32(ds, eax + 0x9), 0);      /* mov word [eax+0x9], 0x0 */
    II(0x10108e1e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10108e21, 0x7)   mov(memd_a32(ds, eax + 0x4), 0x1);    /* mov dword [eax+0x4], 0x1 */
    II(0x10108e28, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10108e2a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10108e2b, 0x1)   popd(edi);                            /* pop edi */
    II(0x10108e2c, 0x1)   popd(esi);                            /* pop esi */
    II(0x10108e2d, 0x1)   popd(edx);                            /* pop edx */
    II(0x10108e2e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10108e2f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10108e30, 0x1)   retd();                               /* ret */
FUNC_END

