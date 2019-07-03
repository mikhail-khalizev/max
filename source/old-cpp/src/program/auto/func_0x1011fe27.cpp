FUNC_BEGIN(0x1011fe27, 0x4dda7a6dd781519b, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x21, 0x5f, 0x4, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x55, 0xfc, 0xb8, 0x6c, 0x53, 0x1c, 0x10, 0xe8, 0xbc, 0xe6, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1011fe27, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1011fe2c, 0x5)   calld(sys_check_available_stack_size, 0x45f21); /* call 0x10165d52 */
    II(0x1011fe31, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1011fe32, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011fe33, 0x1)   pushd(edx);                           /* push edx */
    II(0x1011fe34, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011fe35, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011fe36, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011fe37, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1011fe39, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1011fe3f, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1011fe42, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x1011fe45, 0x5)   mov(eax, 0x101c536c);                 /* mov eax, 0x101c536c */
    II(0x1011fe4a, 0x5)   calld(0x1011e50b, -0x1944);           /* call 0x1011e50b */
    II(0x1011fe4f, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1011fe51, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011fe52, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011fe53, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011fe54, 0x1)   popd(edx);                            /* pop edx */
    II(0x1011fe55, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1011fe56, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1011fe57, 0x1)   retd();                               /* ret */
FUNC_END

