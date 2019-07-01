FUNC_BEGIN(0x100d86f5, 0x829640b1b9d67694, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x53, 0xd6, 0x8, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0xaa, 0xfe, 0xff, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100d86f5, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100d86fa, 0x5)   calld(sys_check_available_stack_size, 0x8d653); /* call 0x10165d52 */
    II(0x100d86ff, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100d8700, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100d8701, 0x1)   pushd(edx);                           /* push edx */
    II(0x100d8702, 0x1)   pushd(esi);                           /* push esi */
    II(0x100d8703, 0x1)   pushd(edi);                           /* push edi */
    II(0x100d8704, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100d8705, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100d8707, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100d870d, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100d8710, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d8713, 0x5)   calld(0x100d85c2, -0x156);            /* call 0x100d85c2 */
    II(0x100d8718, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100d871b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d871e, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100d8720, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100d8721, 0x1)   popd(edi);                            /* pop edi */
    II(0x100d8722, 0x1)   popd(esi);                            /* pop esi */
    II(0x100d8723, 0x1)   popd(edx);                            /* pop edx */
    II(0x100d8724, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100d8725, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100d8726, 0x1)   retd();                               /* ret */
FUNC_END

