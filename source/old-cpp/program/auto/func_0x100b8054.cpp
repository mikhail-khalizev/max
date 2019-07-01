FUNC_BEGIN(0x100b8054, 0x7d3de6f7eb75141, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xf4, 0xdc, 0xa, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x16, 0xe8, 0x56, 0xe5, 0xfb, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100b8054, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100b8059, 0x5)   calld(sys_check_available_stack_size, 0xadcf4); /* call 0x10165d52 */
    II(0x100b805e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b805f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b8060, 0x1)   pushd(edx);                           /* push edx */
    II(0x100b8061, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b8062, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b8063, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b8064, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b8066, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100b806c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100b806f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b8072, 0x3)   add(eax, 0x16);                       /* add eax, 0x16 */
    II(0x100b8075, 0x5)   calld(0x100765d0, -0x41aaa);          /* call 0x100765d0 */
    II(0x100b807a, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100b807d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b8080, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b8082, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b8083, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b8084, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b8085, 0x1)   popd(edx);                            /* pop edx */
    II(0x100b8086, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b8087, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b8088, 0x1)   retd();                               /* ret */
FUNC_END

