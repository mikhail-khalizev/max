FUNC_BEGIN(0x10106054, 0x93fb78e3633a0842, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xf4, 0xfc, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x50, 0xe8, 0x34, 0xd6, 0x1, 0, 0x83, 0xc4, 0x4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10106054, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10106059, 0x5)   calld(sys_check_available_stack_size, 0x5fcf4); /* call 0x10165d52 */
    II(0x1010605e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1010605f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10106060, 0x1)   pushd(edx);                           /* push edx */
    II(0x10106061, 0x1)   pushd(esi);                           /* push esi */
    II(0x10106062, 0x1)   pushd(edi);                           /* push edi */
    II(0x10106063, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10106064, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10106066, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1010606c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1010606f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10106072, 0x1)   pushd(eax);                           /* push eax */
    II(0x10106073, 0x5)   calld(0x101236ac, 0x1d634);           /* call 0x101236ac */
    II(0x10106078, 0x3)   add(esp, 0x4);                        /* add esp, 0x4 */
    II(0x1010607b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1010607d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1010607e, 0x1)   popd(edi);                            /* pop edi */
    II(0x1010607f, 0x1)   popd(esi);                            /* pop esi */
    II(0x10106080, 0x1)   popd(edx);                            /* pop edx */
    II(0x10106081, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10106082, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10106083, 0x1)   retd();                               /* ret */
FUNC_END

