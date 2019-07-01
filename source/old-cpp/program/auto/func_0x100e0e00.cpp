FUNC_BEGIN(0x100e0e00, 0xc6e6c34f46160d98, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x48, 0x4f, 0x8, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x88, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100e0e00, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100e0e05, 0x5)   calld(sys_check_available_stack_size, 0x84f48); /* call 0x10165d52 */
    II(0x100e0e0a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e0e0b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e0e0c, 0x1)   pushd(edx);                           /* push edx */
    II(0x100e0e0d, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e0e0e, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e0e0f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e0e10, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e0e12, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100e0e18, 0x3)   mov(memb_a32(ss, ebp - 0x4), al);     /* mov [ebp-0x4], al */
    II(0x100e0e1b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e0e1d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e0e1e, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e0e1f, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e0e20, 0x1)   popd(edx);                            /* pop edx */
    II(0x100e0e21, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e0e22, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e0e23, 0x1)   retd();                               /* ret */
FUNC_END

