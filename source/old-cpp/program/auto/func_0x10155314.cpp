FUNC_BEGIN(0x10155314, 0x96f8620bde34979e, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x34, 0xa, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10155314, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10155319, 0x5)   calld(sys_check_available_stack_size, 0x10a34); /* call 0x10165d52 */
    II(0x1015531e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1015531f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10155320, 0x1)   pushd(edx);                           /* push edx */
    II(0x10155321, 0x1)   pushd(esi);                           /* push esi */
    II(0x10155322, 0x1)   pushd(edi);                           /* push edi */
    II(0x10155323, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10155324, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10155326, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1015532c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1015532f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10155332, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10155334, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10155337, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1015533a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1015533c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1015533d, 0x1)   popd(edi);                            /* pop edi */
    II(0x1015533e, 0x1)   popd(esi);                            /* pop esi */
    II(0x1015533f, 0x1)   popd(edx);                            /* pop edx */
    II(0x10155340, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10155341, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10155342, 0x1)   retd();                               /* ret */
FUNC_END

