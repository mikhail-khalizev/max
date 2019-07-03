FUNC_BEGIN(0x1008b410, 0x3ed87edc50fe7939, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x38, 0xa9, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1008b410, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1008b415, 0x5)   calld(sys_check_available_stack_size, 0xda938); /* call 0x10165d52 */
    II(0x1008b41a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008b41b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008b41c, 0x1)   pushd(edx);                           /* push edx */
    II(0x1008b41d, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008b41e, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008b41f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008b420, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008b422, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1008b428, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1008b42b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008b42e, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1008b430, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1008b433, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008b436, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008b438, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008b439, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008b43a, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008b43b, 0x1)   popd(edx);                            /* pop edx */
    II(0x1008b43c, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008b43d, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008b43e, 0x1)   retd();                               /* ret */
FUNC_END

