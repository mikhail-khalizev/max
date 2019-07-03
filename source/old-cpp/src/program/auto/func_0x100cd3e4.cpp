FUNC_BEGIN(0x100cd3e4, 0xf14b953d5b5838c0, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x64, 0x89, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc7, 0x45, 0xf8, 0x4, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100cd3e4, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100cd3e9, 0x5)   calld(sys_check_available_stack_size, 0x98964); /* call 0x10165d52 */
    II(0x100cd3ee, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cd3ef, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cd3f0, 0x1)   pushd(edx);                           /* push edx */
    II(0x100cd3f1, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cd3f2, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cd3f3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cd3f4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cd3f6, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100cd3fc, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100cd3ff, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0x4);    /* mov dword [ebp-0x8], 0x4 */
    II(0x100cd406, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100cd409, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cd40b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cd40c, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cd40d, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cd40e, 0x1)   popd(edx);                            /* pop edx */
    II(0x100cd40f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cd410, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cd411, 0x1)   retd();                               /* ret */
FUNC_END

