FUNC_BEGIN(0x1008a674, 0xfb9dd40d40cb441d, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xd4, 0xb6, 0xd, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x88, 0x55, 0xfc, 0x8a, 0x45, 0xfc, 0x8b, 0x55, 0xf8, 0x88, 0x42, 0x45, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1008a674, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1008a679, 0x5)   calld(sys_check_available_stack_size, 0xdb6d4); /* call 0x10165d52 */
    II(0x1008a67e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008a67f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008a680, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008a681, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008a682, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008a683, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008a685, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1008a68b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1008a68e, 0x3)   mov(memb_a32(ss, ebp - 0x4), dl);     /* mov [ebp-0x4], dl */
    II(0x1008a691, 0x3)   mov(al, memb_a32(ss, ebp - 0x4));     /* mov al, [ebp-0x4] */
    II(0x1008a694, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x1008a697, 0x3)   mov(memb_a32(ds, edx + 0x45), al);    /* mov [edx+0x45], al */
    II(0x1008a69a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008a69c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008a69d, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008a69e, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008a69f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008a6a0, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008a6a1, 0x1)   retd();                               /* ret */
FUNC_END

