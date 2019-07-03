FUNC_BEGIN(0x1011fce3, 0xe972035a9b040110, 0x20, ({0x68, 0x1c, 0, 0, 0, 0xe8, 0x65, 0x60, 0x4, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0, 0, 0, 0, 0xb8, 0x6c, 0x53, 0x1c, 0x10, 0xe8, 0x84, 0xe0, 0xff, 0xff, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1011fce3, 0x5)   pushd(0x1c);                          /* push dword 0x1c */
    II(0x1011fce8, 0x5)   calld(sys_check_available_stack_size, 0x46065); /* call 0x10165d52 */
    II(0x1011fced, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1011fcee, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011fcef, 0x1)   pushd(edx);                           /* push edx */
    II(0x1011fcf0, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011fcf1, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011fcf2, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011fcf3, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1011fcf5, 0x6)   sub(esp, 0);                          /* sub esp, 0x0 */
    II(0x1011fcfb, 0x5)   mov(eax, 0x101c536c);                 /* mov eax, 0x101c536c */
    II(0x1011fd00, 0x5)   calld(0x1011dd89, -0x1f7c);           /* call 0x1011dd89 */
    II(0x1011fd05, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011fd06, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011fd07, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011fd08, 0x1)   popd(edx);                            /* pop edx */
    II(0x1011fd09, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1011fd0a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1011fd0b, 0x1)   retd();                               /* ret */
FUNC_END

