FUNC_BEGIN(0x100b7dd8, 0x107e96a53dd7005c, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x70, 0xdf, 0xa, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x40, 0x26, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100b7dd8, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100b7ddd, 0x5)   calld(sys_check_available_stack_size, 0xadf70); /* call 0x10165d52 */
    II(0x100b7de2, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b7de3, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b7de4, 0x1)   pushd(edx);                           /* push edx */
    II(0x100b7de5, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b7de6, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b7de7, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b7de8, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b7dea, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100b7df0, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100b7df3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b7df6, 0x4)   mov(ax, memw_a32(ds, eax + 0x26));    /* mov ax, [eax+0x26] */
    II(0x100b7dfa, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100b7dfd, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b7e00, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b7e02, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b7e03, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b7e04, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b7e05, 0x1)   popd(edx);                            /* pop edx */
    II(0x100b7e06, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b7e07, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b7e08, 0x1)   retd();                               /* ret */
FUNC_END

