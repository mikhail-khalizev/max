FUNC_BEGIN(0x100ef36c, 0x648a5f158d6c37ab, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xdc, 0x69, 0x7, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x40, 0x21, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100ef36c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100ef371, 0x5)   calld(sys_check_available_stack_size, 0x769dc); /* call 0x10165d52 */
    II(0x100ef376, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100ef377, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ef378, 0x1)   pushd(edx);                           /* push edx */
    II(0x100ef379, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ef37a, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ef37b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ef37c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ef37e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100ef384, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100ef387, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100ef38a, 0x4)   mov(ax, memw_a32(ds, eax + 0x21));    /* mov ax, [eax+0x21] */
    II(0x100ef38e, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100ef391, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ef394, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ef396, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ef397, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ef398, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ef399, 0x1)   popd(edx);                            /* pop edx */
    II(0x100ef39a, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ef39b, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ef39c, 0x1)   retd();                               /* ret */
FUNC_END

