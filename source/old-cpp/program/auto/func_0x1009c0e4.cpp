FUNC_BEGIN(0x1009c0e4, 0x612dec578c28c769, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x64, 0x9c, 0xc, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xf7, 0x45, 0xfc, 0x4, 0, 0, 0, 0x74, 0x14, 0xba, 0xac, 0x41, 0x1b, 0x10, 0x8b, 0x45, 0xf8, 0xe8, 0xa1, 0x9e, 0xc, 0, 0xe8, 0xbc, 0x9e, 0xc, 0, 0xeb, 0x21, 0xba, 0x1, 0, 0, 0, 0x8b, 0x45, 0xf8, 0xe8, 0xeb, 0x17, 0x3, 0, 0x89, 0x45, 0xf8, 0xf7, 0x45, 0xfc, 0x2, 0, 0, 0, 0x74, 0x8, 0x8b, 0x45, 0xf8, 0xe8, 0x25, 0x9e, 0xc, 0, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1009c0e4, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1009c0e9, 0x5)   calld(sys_check_available_stack_size, 0xc9c64); /* call 0x10165d52 */
    II(0x1009c0ee, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009c0ef, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009c0f0, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009c0f1, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009c0f2, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009c0f3, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009c0f5, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1009c0fb, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1009c0fe, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1009c101, 0x7)   test(memd_a32(ss, ebp - 0x4), 0x4);   /* test dword [ebp-0x4], 0x4 */
    II(0x1009c108, 0x2)   jzd(0x1009c11e, 0x14);                /* jz 0x1009c11e */
    II(0x1009c10a, 0x5)   mov(edx, 0x101b41ac);                 /* mov edx, 0x101b41ac */
    II(0x1009c10f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009c112, 0x5)   calld(sys_call_dtor_arr, 0xc9ea1);    /* call 0x10165fb8 */
    II(0x1009c117, 0x5)   calld(sys_delete_arr, 0xc9ebc);       /* call 0x10165fd8 */
    II(0x1009c11c, 0x2)   jmpd(0x1009c13f, 0x21);               /* jmp 0x1009c13f */
l_0x1009c11e:
    II(0x1009c11e, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
    II(0x1009c123, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009c126, 0x5)   calld(0x100cd916, 0x317eb);           /* call 0x100cd916 */
    II(0x1009c12b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1009c12e, 0x7)   test(memd_a32(ss, ebp - 0x4), 0x2);   /* test dword [ebp-0x4], 0x2 */
    II(0x1009c135, 0x2)   jzd(0x1009c13f, 0x8);                 /* jz 0x1009c13f */
    II(0x1009c137, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009c13a, 0x5)   calld(sys_delete, 0xc9e25);           /* call 0x10165f64 */
l_0x1009c13f:
    II(0x1009c13f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009c142, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1009c145, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1009c148, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009c14a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009c14b, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009c14c, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009c14d, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009c14e, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009c14f, 0x1)   retd();                               /* ret */
FUNC_END

