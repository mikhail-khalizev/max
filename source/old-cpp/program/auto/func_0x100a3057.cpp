FUNC_BEGIN(0x100a3057, 0x857e4a2990b44bbb, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xf1, 0x2c, 0xc, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100a3057, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100a305c, 0x5)   calld(sys_check_available_stack_size, 0xc2cf1); /* call 0x10165d52 */
    II(0x100a3061, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100a3062, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100a3063, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a3064, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a3065, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a3066, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a3068, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100a306e, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100a3071, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100a3074, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100a3076, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100a3077, 0x1)   popd(edi);                            /* pop edi */
    II(0x100a3078, 0x1)   popd(esi);                            /* pop esi */
    II(0x100a3079, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100a307a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100a307b, 0x1)   retd();                               /* ret */
FUNC_END

