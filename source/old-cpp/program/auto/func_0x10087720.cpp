FUNC_BEGIN(0x10087720, 0x943dddc8df7a26a0, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x28, 0xe6, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0xa, 0xff, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10087720, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10087725, 0x5)   calld(sys_check_available_stack_size, 0xde628); /* call 0x10165d52 */
    II(0x1008772a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008772b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008772c, 0x1)   pushd(edx);                           /* push edx */
    II(0x1008772d, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008772e, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008772f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10087730, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10087732, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10087738, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1008773b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008773e, 0x5)   calld(0x1008764d, -0xf6);             /* call 0x1008764d */
    II(0x10087743, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10087745, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10087746, 0x1)   popd(edi);                            /* pop edi */
    II(0x10087747, 0x1)   popd(esi);                            /* pop esi */
    II(0x10087748, 0x1)   popd(edx);                            /* pop edx */
    II(0x10087749, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008774a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008774b, 0x1)   retd();                               /* ret */
FUNC_END

