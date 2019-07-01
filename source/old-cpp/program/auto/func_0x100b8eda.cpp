FUNC_BEGIN(0x100b8eda, 0x564fe8321f3f1292, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x6e, 0xce, 0xa, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x66, 0, 0, 0, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x40, 0x12, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100b8eda, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100b8edf, 0x5)   calld(sys_check_available_stack_size, 0xace6e); /* call 0x10165d52 */
    II(0x100b8ee4, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b8ee5, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b8ee6, 0x1)   pushd(edx);                           /* push edx */
    II(0x100b8ee7, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b8ee8, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b8ee9, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b8eea, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b8eec, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100b8ef2, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100b8ef5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b8ef8, 0x5)   calld(0x100b8f63, 0x66);              /* call 0x100b8f63 */
    II(0x100b8efd, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b8f00, 0x4)   mov(ax, memw_a32(ds, eax + 0x12));    /* mov ax, [eax+0x12] */
    II(0x100b8f04, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100b8f07, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b8f0a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b8f0c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b8f0d, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b8f0e, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b8f0f, 0x1)   popd(edx);                            /* pop edx */
    II(0x100b8f10, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b8f11, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b8f12, 0x1)   retd();                               /* ret */
FUNC_END

