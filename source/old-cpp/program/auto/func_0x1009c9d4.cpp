FUNC_BEGIN(0x1009c9d4, 0xe50c77beed896c8e, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x74, 0x93, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x40, 0xb, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1009c9d4, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1009c9d9, 0x5)   calld(sys_check_available_stack_size, 0xc9374); /* call 0x10165d52 */
    II(0x1009c9de, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009c9df, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009c9e0, 0x1)   pushd(edx);                           /* push edx */
    II(0x1009c9e1, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009c9e2, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009c9e3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009c9e4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009c9e6, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1009c9ec, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1009c9ef, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1009c9f2, 0x4)   mov(ax, memw_a32(ds, eax + 0xb));     /* mov ax, [eax+0xb] */
    II(0x1009c9f6, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1009c9f9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009c9fc, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009c9fe, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009c9ff, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009ca00, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009ca01, 0x1)   popd(edx);                            /* pop edx */
    II(0x1009ca02, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009ca03, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009ca04, 0x1)   retd();                               /* ret */
FUNC_END

