FUNC_BEGIN(0x10164b08, 0x44873ff6d2c3e89b, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x40, 0x12, 0, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0xc7, 0x80, 0xa3, 0, 0, 0, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10164b08, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10164b0d, 0x5)   calld(sys_check_available_stack_size, 0x1240); /* call 0x10165d52 */
    II(0x10164b12, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10164b13, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10164b14, 0x1)   pushd(edx);                           /* push edx */
    II(0x10164b15, 0x1)   pushd(esi);                           /* push esi */
    II(0x10164b16, 0x1)   pushd(edi);                           /* push edi */
    II(0x10164b17, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10164b18, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10164b1a, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10164b20, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10164b23, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10164b26, 0x9)   mov(memw_a32(ds, eax + 0xa3), 0);     /* mov word [eax+0xa3], 0x0 */
    II(0x10164b2f, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10164b31, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10164b32, 0x1)   popd(edi);                            /* pop edi */
    II(0x10164b33, 0x1)   popd(esi);                            /* pop esi */
    II(0x10164b34, 0x1)   popd(edx);                            /* pop edx */
    II(0x10164b35, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10164b36, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10164b37, 0x1)   retd();                               /* ret */
FUNC_END

