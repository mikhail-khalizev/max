FUNC_BEGIN(0x10089f38, 0x9d4a9ec51d5cb811, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x10, 0xbe, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x15, 0xe8, 0x26, 0x3, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10089f38, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10089f3d, 0x5)   calld(sys_check_available_stack_size, 0xdbe10); /* call 0x10165d52 */
    II(0x10089f42, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10089f43, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10089f44, 0x1)   pushd(edx);                           /* push edx */
    II(0x10089f45, 0x1)   pushd(esi);                           /* push esi */
    II(0x10089f46, 0x1)   pushd(edi);                           /* push edi */
    II(0x10089f47, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10089f48, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10089f4a, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10089f50, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10089f53, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10089f56, 0x3)   add(eax, 0x15);                       /* add eax, 0x15 */
    II(0x10089f59, 0x5)   calld(0x1008a284, 0x326);             /* call 0x1008a284 */
    II(0x10089f5e, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10089f61, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10089f64, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10089f66, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10089f67, 0x1)   popd(edi);                            /* pop edi */
    II(0x10089f68, 0x1)   popd(esi);                            /* pop esi */
    II(0x10089f69, 0x1)   popd(edx);                            /* pop edx */
    II(0x10089f6a, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10089f6b, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10089f6c, 0x1)   retd();                               /* ret */
FUNC_END

