FUNC_BEGIN(0x10089860, 0xe86dca6c962e3743, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xe8, 0xc4, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x40, 0x8, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10089860, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10089865, 0x5)   calld(sys_check_available_stack_size, 0xdc4e8); /* call 0x10165d52 */
    II(0x1008986a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008986b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008986c, 0x1)   pushd(edx);                           /* push edx */
    II(0x1008986d, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008986e, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008986f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10089870, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10089872, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10089878, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1008987b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008987e, 0x4)   mov(ax, memw_a32(ds, eax + 0x8));     /* mov ax, [eax+0x8] */
    II(0x10089882, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10089885, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10089888, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008988a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008988b, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008988c, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008988d, 0x1)   popd(edx);                            /* pop edx */
    II(0x1008988e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008988f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10089890, 0x1)   retd();                               /* ret */
FUNC_END

