FUNC_BEGIN(0x100b3172, 0x2cde757ce6bc3eb5, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xd6, 0x2b, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc7, 0x45, 0xf8, 0x4, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100b3172, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100b3177, 0x5)   calld(sys_check_available_stack_size, 0xb2bd6); /* call 0x10165d52 */
    II(0x100b317c, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b317d, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b317e, 0x1)   pushd(edx);                           /* push edx */
    II(0x100b317f, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b3180, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b3181, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b3182, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b3184, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100b318a, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100b318d, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0x4);    /* mov dword [ebp-0x8], 0x4 */
    II(0x100b3194, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b3197, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b3199, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b319a, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b319b, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b319c, 0x1)   popd(edx);                            /* pop edx */
    II(0x100b319d, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b319e, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b319f, 0x1)   retd();                               /* ret */
FUNC_END

