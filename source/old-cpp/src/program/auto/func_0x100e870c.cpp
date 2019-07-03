FUNC_BEGIN(0x100e870c, 0xe265a950e3c13fed, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x3c, 0xd6, 0x7, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100e870c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100e8711, 0x5)   calld(sys_check_available_stack_size, 0x7d63c); /* call 0x10165d52 */
    II(0x100e8716, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e8717, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e8718, 0x1)   pushd(edx);                           /* push edx */
    II(0x100e8719, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e871a, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e871b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e871c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e871e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100e8724, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100e8727, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100e872a, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x100e872c, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100e872f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100e8732, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e8734, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e8735, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e8736, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e8737, 0x1)   popd(edx);                            /* pop edx */
    II(0x100e8738, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e8739, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e873a, 0x1)   retd();                               /* ret */
FUNC_END

