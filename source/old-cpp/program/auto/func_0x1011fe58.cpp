FUNC_BEGIN(0x1011fe58, 0xaa701e7dbbc60d2f, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xf0, 0x5e, 0x4, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x55, 0xfc, 0xb8, 0x6c, 0x53, 0x1c, 0x10, 0xe8, 0x5f, 0xe7, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1011fe58, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1011fe5d, 0x5)   calld(sys_check_available_stack_size, 0x45ef0); /* call 0x10165d52 */
    II(0x1011fe62, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1011fe63, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011fe64, 0x1)   pushd(edx);                           /* push edx */
    II(0x1011fe65, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011fe66, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011fe67, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011fe68, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1011fe6a, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1011fe70, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1011fe73, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x1011fe76, 0x5)   mov(eax, 0x101c536c);                 /* mov eax, 0x101c536c */
    II(0x1011fe7b, 0x5)   calld(0x1011e5df, -0x18a1);           /* call 0x1011e5df */
    II(0x1011fe80, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1011fe82, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011fe83, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011fe84, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011fe85, 0x1)   popd(edx);                            /* pop edx */
    II(0x1011fe86, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1011fe87, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1011fe88, 0x1)   retd();                               /* ret */
FUNC_END

