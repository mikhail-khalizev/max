FUNC_BEGIN(0x100aa0f8, 0xc5af005a3ba68315, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x50, 0xbc, 0xb, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xba, 0x1, 0, 0, 0, 0x8b, 0x45, 0xf8, 0xe8, 0x23, 0xb, 0x9, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100aa0f8, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100aa0fd, 0x5)   calld(sys_check_available_stack_size, 0xbbc50); /* call 0x10165d52 */
    II(0x100aa102, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100aa103, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100aa104, 0x1)   pushd(esi);                           /* push esi */
    II(0x100aa105, 0x1)   pushd(edi);                           /* push edi */
    II(0x100aa106, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100aa107, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100aa109, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100aa10f, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100aa112, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100aa115, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
//    II(0x100aa11a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100aa11d, 0x5)   calld(my_dtor_0x101b6edc, 0x90b23);   /* call 0x1013ac45 */
    II(0x100aa122, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100aa125, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100aa128, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100aa12b, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100aa12e, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100aa130, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100aa131, 0x1)   popd(edi);                            /* pop edi */
    II(0x100aa132, 0x1)   popd(esi);                            /* pop esi */
    II(0x100aa133, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100aa134, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100aa135, 0x1)   retd();                               /* ret */
FUNC_END

