FUNC_BEGIN(0x100ea903, 0x2a6578a19cb4bc8f, 0x20, ({0x68, 0x1c, 0, 0, 0, 0xe8, 0x45, 0xb4, 0x7, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0, 0, 0, 0, 0xb8, 0x64, 0x36, 0x1c, 0x10, 0xe8, 0x6f, 0x22, 0xfb, 0xff, 0xc6, 0x5, 0x74, 0x36, 0x1c, 0x10, 0, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100ea903, 0x5)   pushd(0x1c);                          /* push dword 0x1c */
    II(0x100ea908, 0x5)   calld(sys_check_available_stack_size, 0x7b445); /* call 0x10165d52 */
    II(0x100ea90d, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100ea90e, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ea90f, 0x1)   pushd(edx);                           /* push edx */
    II(0x100ea910, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ea911, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ea912, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ea913, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ea915, 0x6)   sub(esp, 0);                          /* sub esp, 0x0 */
    II(0x100ea91b, 0x5)   mov(eax, 0x101c3664);                 /* mov eax, 0x101c3664 */
    II(0x100ea920, 0x5)   calld(0x1009cb94, -0x4dd91);          /* call 0x1009cb94 */
    II(0x100ea925, 0x7)   mov(memb_a32(ds, 0x101c3674), 0);     /* mov byte [0x101c3674], 0x0 */
    II(0x100ea92c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ea92d, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ea92e, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ea92f, 0x1)   popd(edx);                            /* pop edx */
    II(0x100ea930, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ea931, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ea932, 0x1)   retd();                               /* ret */
FUNC_END

