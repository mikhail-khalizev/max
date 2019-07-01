FUNC_BEGIN(my_2_get_count, 0x56035b037de4aa05, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xe0, 0xa9, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x85, 0, 0, 0, 0x83, 0xc0, 0x6, 0xe8, 0xed, 0, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1008b368, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1008b36d, 0x5)   calld(sys_check_available_stack_size, 0xda9e0); /* call 0x10165d52 */
    II(0x1008b372, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008b373, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008b374, 0x1)   pushd(edx);                           /* push edx */
    II(0x1008b375, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008b376, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008b377, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008b378, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008b37a, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1008b380, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1008b383, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008b386, 0x5)   calld(0x1008b410, 0x85);              /* call 0x1008b410 */
    II(0x1008b38b, 0x3)   add(eax, 0x6);                        /* add eax, 0x6 */
    II(0x1008b38e, 0x5)   calld(my_3_get_count, 0xed);          /* call 0x1008b480 */
    II(0x1008b393, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1008b396, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008b399, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008b39b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008b39c, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008b39d, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008b39e, 0x1)   popd(edx);                            /* pop edx */
    II(0x1008b39f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008b3a0, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008b3a1, 0x1)   retd();                               /* ret */
FUNC_END

