FUNC_BEGIN(0x100e0a44, 0xa756ed6a1a1189ff, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x4, 0x53, 0x8, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x4, 0xe8, 0xa2, 0, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100e0a44, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100e0a49, 0x5)   calld(sys_check_available_stack_size, 0x85304); /* call 0x10165d52 */
    II(0x100e0a4e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e0a4f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e0a50, 0x1)   pushd(edx);                           /* push edx */
    II(0x100e0a51, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e0a52, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e0a53, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e0a54, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e0a56, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100e0a5c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100e0a5f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100e0a62, 0x3)   mov(eax, memd_a32(ds, eax + 0x4));    /* mov eax, [eax+0x4] */
    II(0x100e0a65, 0x5)   calld(0x100e0b0c, 0xa2);              /* call 0x100e0b0c */
    II(0x100e0a6a, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100e0a6d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100e0a70, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e0a72, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e0a73, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e0a74, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e0a75, 0x1)   popd(edx);                            /* pop edx */
    II(0x100e0a76, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e0a77, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e0a78, 0x1)   retd();                               /* ret */
FUNC_END

