FUNC_BEGIN(0x100b3844, 0x423301f5cdb400e4, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x4, 0x25, 0xb, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0xf2, 0xfe, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100b3844, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100b3849, 0x5)   calld(sys_check_available_stack_size, 0xb2504); /* call 0x10165d52 */
    II(0x100b384e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b384f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b3850, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b3851, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b3852, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b3853, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b3855, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100b385b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100b385e, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100b3861, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b3864, 0x5)   calld(0x100b375b, -0x10e);            /* call 0x100b375b */
    II(0x100b3869, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b386b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b386c, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b386d, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b386e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b386f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b3870, 0x1)   retd();                               /* ret */
FUNC_END

