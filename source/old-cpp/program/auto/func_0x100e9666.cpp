FUNC_BEGIN(0x100e9666, 0x1107334797c095b3, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xe2, 0xc6, 0x7, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x50, 0x4, 0x8b, 0x45, 0xfc, 0x8b, 0, 0xc1, 0xf8, 0x10, 0xe8, 0xe4, 0x3, 0x8, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100e9666, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100e966b, 0x5)   calld(sys_check_available_stack_size, 0x7c6e2); /* call 0x10165d52 */
    II(0x100e9670, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e9671, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e9672, 0x1)   pushd(edx);                           /* push edx */
    II(0x100e9673, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e9674, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e9675, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e9676, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e9678, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100e967e, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100e9681, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100e9684, 0x3)   mov(edx, memd_a32(ds, eax + 0x4));    /* mov edx, [eax+0x4] */
//    II(0x100e9687, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100e968a, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x100e968c, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100e968f, 0x5)   calld(/* sys */ 0x10169a78, 0x803e4); /* call 0x10169a78 */
    II(0x100e9694, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e9696, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e9697, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e9698, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e9699, 0x1)   popd(edx);                            /* pop edx */
    II(0x100e969a, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e969b, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e969c, 0x1)   retd();                               /* ret */
FUNC_END

