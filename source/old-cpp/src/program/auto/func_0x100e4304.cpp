FUNC_BEGIN(0x100e4304, 0xbe2c90154983c962, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x44, 0x1a, 0x8, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x40, 0xc, 0x8b, 0x55, 0xfc, 0x66, 0x2b, 0x42, 0x4, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100e4304, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100e4309, 0x5)   calld(sys_check_available_stack_size, 0x81a44); /* call 0x10165d52 */
    II(0x100e430e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e430f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e4310, 0x1)   pushd(edx);                           /* push edx */
    II(0x100e4311, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e4312, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e4313, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e4314, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e4316, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100e431c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100e431f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100e4322, 0x4)   mov(ax, memw_a32(ds, eax + 0xc));     /* mov ax, [eax+0xc] */
    II(0x100e4326, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100e4329, 0x4)   sub(ax, memw_a32(ds, edx + 0x4));     /* sub ax, [edx+0x4] */
    II(0x100e432d, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100e4330, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100e4333, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e4335, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e4336, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e4337, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e4338, 0x1)   popd(edx);                            /* pop edx */
    II(0x100e4339, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e433a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e433b, 0x1)   retd();                               /* ret */
FUNC_END

