FUNC_BEGIN(0x100cd43d, 0x102cff081e94adc9, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xb, 0x89, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100cd43d, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100cd442, 0x5)   calld(sys_check_available_stack_size, 0x9890b); /* call 0x10165d52 */
    II(0x100cd447, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cd448, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cd449, 0x1)   pushd(edx);                           /* push edx */
    II(0x100cd44a, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cd44b, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cd44c, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cd44d, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cd44f, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100cd455, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100cd458, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cd45a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cd45b, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cd45c, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cd45d, 0x1)   popd(edx);                            /* pop edx */
    II(0x100cd45e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cd45f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cd460, 0x1)   retd();                               /* ret */
FUNC_END

