FUNC_BEGIN(0x100a9fb0, 0x1b63a7a75c00c8b8, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x98, 0xbd, 0xb, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xf7, 0x45, 0xfc, 0x4, 0, 0, 0, 0x74, 0x14, 0xba, 0x40, 0x4c, 0x1b, 0x10, 0x8b, 0x45, 0xf8, 0xe8, 0xd5, 0xbf, 0xb, 0, 0xe8, 0xf0, 0xbf, 0xb, 0, 0xeb, 0x34, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x13, 0xe8, 0xd, 0xeb, 0xfd, 0xff, 0x83, 0xe8, 0x13, 0x89, 0x45, 0xf8, 0xba, 0x1, 0, 0, 0, 0x8b, 0x45, 0xf8, 0xe8, 0x42, 0x88, 0xff, 0xff, 0x89, 0x45, 0xf8, 0xf7, 0x45, 0xfc, 0x2, 0, 0, 0, 0x74, 0x8, 0x8b, 0x45, 0xf8, 0xe8, 0x46, 0xbf, 0xb, 0, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100a9fb0, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100a9fb5, 0x5)   calld(sys_check_available_stack_size, 0xbbd98); /* call 0x10165d52 */
    II(0x100a9fba, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100a9fbb, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100a9fbc, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a9fbd, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a9fbe, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a9fbf, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a9fc1, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100a9fc7, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100a9fca, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100a9fcd, 0x7)   test(memd_a32(ss, ebp - 0x4), 0x4);   /* test dword [ebp-0x4], 0x4 */
    II(0x100a9fd4, 0x2)   jzd(0x100a9fea, 0x14);                /* jz 0x100a9fea */
    II(0x100a9fd6, 0x5)   mov(edx, 0x101b4c40);                 /* mov edx, 0x101b4c40 */
    II(0x100a9fdb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100a9fde, 0x5)   calld(sys_call_dtor_arr, 0xbbfd5);    /* call 0x10165fb8 */
    II(0x100a9fe3, 0x5)   calld(sys_delete_arr, 0xbbff0);       /* call 0x10165fd8 */
    II(0x100a9fe8, 0x2)   jmpd(0x100aa01e, 0x34);               /* jmp 0x100aa01e */
l_0x100a9fea:
    II(0x100a9fea, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100a9fec, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100a9fef, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100a9ff2, 0x5)   calld(0x10088b04, -0x214f3);          /* call 0x10088b04 */
    II(0x100a9ff7, 0x3)   sub(eax, 0x13);                       /* sub eax, 0x13 */
    II(0x100a9ffa, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100a9ffd, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
//    II(0x100aa002, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100aa005, 0x5)   calld(0x100a284c, -0x77be);           /* call 0x100a284c */
    II(0x100aa00a, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100aa00d, 0x7)   test(memd_a32(ss, ebp - 0x4), 0x2);   /* test dword [ebp-0x4], 0x2 */
    II(0x100aa014, 0x2)   jzd(0x100aa01e, 0x8);                 /* jz 0x100aa01e */
    II(0x100aa016, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100aa019, 0x5)   calld(sys_delete, 0xbbf46);           /* call 0x10165f64 */
l_0x100aa01e:
    II(0x100aa01e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100aa021, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100aa024, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100aa027, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100aa029, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100aa02a, 0x1)   popd(edi);                            /* pop edi */
    II(0x100aa02b, 0x1)   popd(esi);                            /* pop esi */
    II(0x100aa02c, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100aa02d, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100aa02e, 0x1)   retd();                               /* ret */
FUNC_END

