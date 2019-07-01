FUNC_BEGIN(0x1007cab7, 0x894d2c14dc9703d6, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x91, 0x92, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc7, 0x45, 0xf8, 0x4, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1007cab7, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1007cabc, 0x5)   calld(sys_check_available_stack_size, 0xe9291); /* call 0x10165d52 */
    II(0x1007cac1, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1007cac2, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1007cac3, 0x1)   pushd(edx);                           /* push edx */
    II(0x1007cac4, 0x1)   pushd(esi);                           /* push esi */
    II(0x1007cac5, 0x1)   pushd(edi);                           /* push edi */
    II(0x1007cac6, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1007cac7, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1007cac9, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1007cacf, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1007cad2, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0x4);    /* mov dword [ebp-0x8], 0x4 */
    II(0x1007cad9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1007cadc, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1007cade, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1007cadf, 0x1)   popd(edi);                            /* pop edi */
    II(0x1007cae0, 0x1)   popd(esi);                            /* pop esi */
    II(0x1007cae1, 0x1)   popd(edx);                            /* pop edx */
    II(0x1007cae2, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1007cae3, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1007cae4, 0x1)   retd();                               /* ret */
FUNC_END

