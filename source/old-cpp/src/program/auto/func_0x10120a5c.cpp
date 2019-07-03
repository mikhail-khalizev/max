FUNC_BEGIN(0x10120a5c, 0xc311882fa5673aa6, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xec, 0x52, 0x4, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x80, 0xd5, 0, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10120a5c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10120a61, 0x5)   calld(sys_check_available_stack_size, 0x452ec); /* call 0x10165d52 */
    II(0x10120a66, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10120a67, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10120a68, 0x1)   pushd(edx);                           /* push edx */
    II(0x10120a69, 0x1)   pushd(esi);                           /* push esi */
    II(0x10120a6a, 0x1)   pushd(edi);                           /* push edi */
    II(0x10120a6b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10120a6c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10120a6e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10120a74, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10120a77, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10120a7a, 0x7)   mov(ax, memw_a32(ds, eax + 0xd5));    /* mov ax, [eax+0xd5] */
    II(0x10120a81, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10120a84, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10120a87, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10120a89, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10120a8a, 0x1)   popd(edi);                            /* pop edi */
    II(0x10120a8b, 0x1)   popd(esi);                            /* pop esi */
    II(0x10120a8c, 0x1)   popd(edx);                            /* pop edx */
    II(0x10120a8d, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10120a8e, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10120a8f, 0x1)   retd();                               /* ret */
FUNC_END

