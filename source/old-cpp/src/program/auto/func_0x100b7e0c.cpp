FUNC_BEGIN(0x100b7e0c, 0xdad92115b344f8f0, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x3c, 0xdf, 0xa, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x20, 0xe8, 0xa, 0x35, 0xff, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100b7e0c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100b7e11, 0x5)   calld(sys_check_available_stack_size, 0xadf3c); /* call 0x10165d52 */
    II(0x100b7e16, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b7e17, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b7e18, 0x1)   pushd(edx);                           /* push edx */
    II(0x100b7e19, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b7e1a, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b7e1b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b7e1c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b7e1e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100b7e24, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100b7e27, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b7e2a, 0x3)   add(eax, 0x20);                       /* add eax, 0x20 */
    II(0x100b7e2d, 0x5)   calld(0x100ab33c, -0xcaf6);           /* call 0x100ab33c */
    II(0x100b7e32, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100b7e35, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b7e38, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b7e3a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b7e3b, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b7e3c, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b7e3d, 0x1)   popd(edx);                            /* pop edx */
    II(0x100b7e3e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b7e3f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b7e40, 0x1)   retd();                               /* ret */
FUNC_END

