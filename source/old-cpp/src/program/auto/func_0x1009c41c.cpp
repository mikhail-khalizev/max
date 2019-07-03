FUNC_BEGIN(0x1009c41c, 0x14f7da1e4a5bd868, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x2c, 0x99, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1009c41c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1009c421, 0x5)   calld(sys_check_available_stack_size, 0xc992c); /* call 0x10165d52 */
    II(0x1009c426, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009c427, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009c428, 0x1)   pushd(edx);                           /* push edx */
    II(0x1009c429, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009c42a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009c42b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009c42c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009c42e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1009c434, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1009c437, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1009c43a, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1009c43c, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1009c43f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009c442, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009c444, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009c445, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009c446, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009c447, 0x1)   popd(edx);                            /* pop edx */
    II(0x1009c448, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009c449, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009c44a, 0x1)   retd();                               /* ret */
FUNC_END

