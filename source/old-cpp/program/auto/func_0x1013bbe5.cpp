FUNC_BEGIN(0x1013bbe5, 0x43879f06026835a8, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x63, 0xa1, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xbb, 0x4, 0, 0, 0, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x74, 0xfe, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1013bbe5, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1013bbea, 0x5)   calld(sys_check_available_stack_size, 0x2a163); /* call 0x10165d52 */
    II(0x1013bbef, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013bbf0, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013bbf1, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013bbf2, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013bbf3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013bbf4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013bbf6, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1013bbfc, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1013bbff, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1013bc02, 0x5)   mov(ebx, 0x4);                        /* mov ebx, 0x4 */
//    II(0x1013bc07, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x1013bc0a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013bc0d, 0x5)   calld(0x1013ba86, -0x18c);            /* call 0x1013ba86 */
    II(0x1013bc12, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013bc14, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013bc15, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013bc16, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013bc17, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013bc18, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013bc19, 0x1)   retd();                               /* ret */
FUNC_END

