FUNC_BEGIN(0x100a9e88, 0xd5fa51641f438f02, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xc0, 0xbe, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x55, 0xfc, 0xb8, 0x80, 0x31, 0x1c, 0x10, 0xe8, 0x7c, 0xa4, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100a9e88, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100a9e8d, 0x5)   calld(sys_check_available_stack_size, 0xbbec0); /* call 0x10165d52 */
    II(0x100a9e92, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100a9e93, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100a9e94, 0x1)   pushd(edx);                           /* push edx */
    II(0x100a9e95, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a9e96, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a9e97, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a9e98, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a9e9a, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100a9ea0, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100a9ea3, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100a9ea6, 0x5)   mov(eax, 0x101c3180);                 /* mov eax, 0x101c3180 */
    II(0x100a9eab, 0x5)   calld(0x100a432c, -0x5b84);           /* call 0x100a432c */
    II(0x100a9eb0, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100a9eb2, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100a9eb3, 0x1)   popd(edi);                            /* pop edi */
    II(0x100a9eb4, 0x1)   popd(esi);                            /* pop esi */
    II(0x100a9eb5, 0x1)   popd(edx);                            /* pop edx */
    II(0x100a9eb6, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100a9eb7, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100a9eb8, 0x1)   retd();                               /* ret */
FUNC_END

