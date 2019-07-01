FUNC_BEGIN(0x1011bc25, 0x719be967e802a2dc, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x23, 0xa1, 0x4, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xb8, 0x2e, 0x53, 0x1c, 0x10, 0xe8, 0x1a, 0x51, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1011bc25, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1011bc2a, 0x5)   calld(sys_check_available_stack_size, 0x4a123); /* call 0x10165d52 */
    II(0x1011bc2f, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1011bc30, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011bc31, 0x1)   pushd(edx);                           /* push edx */
    II(0x1011bc32, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011bc33, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011bc34, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011bc35, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1011bc37, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1011bc3d, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1011bc40, 0x5)   mov(eax, 0x101c532e);                 /* mov eax, 0x101c532e */
    II(0x1011bc45, 0x5)   calld(0x10120d64, 0x511a);            /* call 0x10120d64 */
    II(0x1011bc4a, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1011bc4d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011bc50, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1011bc52, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011bc53, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011bc54, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011bc55, 0x1)   popd(edx);                            /* pop edx */
    II(0x1011bc56, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1011bc57, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1011bc58, 0x1)   retd();                               /* ret */
FUNC_END

