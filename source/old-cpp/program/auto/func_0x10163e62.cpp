FUNC_BEGIN(0x10163e62, 0x6c7f8d0baf8e91ab, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xe6, 0x1e, 0, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xb8, 0x1a, 0xb1, 0x1c, 0x10, 0xe8, 0xdd, 0xce, 0xfb, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10163e62, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10163e67, 0x5)   calld(sys_check_available_stack_size, 0x1ee6); /* call 0x10165d52 */
    II(0x10163e6c, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10163e6d, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10163e6e, 0x1)   pushd(edx);                           /* push edx */
    II(0x10163e6f, 0x1)   pushd(esi);                           /* push esi */
    II(0x10163e70, 0x1)   pushd(edi);                           /* push edi */
    II(0x10163e71, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10163e72, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10163e74, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10163e7a, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10163e7d, 0x5)   mov(eax, 0x101cb11a);                 /* mov eax, 0x101cb11a */
    II(0x10163e82, 0x5)   calld(0x10120d64, -0x43123);          /* call 0x10120d64 */
    II(0x10163e87, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10163e8a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10163e8d, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10163e8f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10163e90, 0x1)   popd(edi);                            /* pop edi */
    II(0x10163e91, 0x1)   popd(esi);                            /* pop esi */
    II(0x10163e92, 0x1)   popd(edx);                            /* pop edx */
    II(0x10163e93, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10163e94, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10163e95, 0x1)   retd();                               /* ret */
FUNC_END

