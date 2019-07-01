FUNC_BEGIN(my_dtor_0x101b6edc, 0x282ce8987be74cd9, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x3, 0xb1, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x8b, 0, 0xe8, 0x68, 0x1, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1013ac45, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1013ac4a, 0x5)   calld(sys_check_available_stack_size, 0x2b103); /* call 0x10165d52 */
    II(0x1013ac4f, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013ac50, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013ac51, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013ac52, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013ac53, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013ac54, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013ac56, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1013ac5c, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1013ac5f, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x1013ac62, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013ac65, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1013ac67, 0x5)   calld(0x1013add4, 0x168);             /* call 0x1013add4 */
    II(0x1013ac6c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013ac6f, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1013ac72, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1013ac75, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013ac77, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013ac78, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013ac79, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013ac7a, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013ac7b, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013ac7c, 0x1)   retd();                               /* ret */
FUNC_END

