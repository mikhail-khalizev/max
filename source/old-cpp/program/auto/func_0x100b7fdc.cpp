FUNC_BEGIN(0x100b7fdc, 0x337933e2586e569e, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x6c, 0xdd, 0xa, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x45, 0xee, 0xfb, 0xff, 0x89, 0x45, 0xfc, 0x8d, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100b7fdc, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x100b7fe1, 0x5)   calld(sys_check_available_stack_size, 0xadd6c); /* call 0x10165d52 */
    II(0x100b7fe6, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b7fe7, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b7fe8, 0x1)   pushd(edx);                           /* push edx */
    II(0x100b7fe9, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b7fea, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b7feb, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b7fec, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b7fee, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100b7ff4, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100b7ff7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b7ffa, 0x5)   calld(my_ctor_0x101b6edc, -0x411bb);  /* call 0x10076e44 */
    II(0x100b7fff, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100b8002, 0x3)   lea(eax, ebp - 0x4);                  /* lea eax, [ebp-0x4] */
    II(0x100b8005, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100b8008, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b800b, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100b800e, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100b8011, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b8013, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b8014, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b8015, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b8016, 0x1)   popd(edx);                            /* pop edx */
    II(0x100b8017, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b8018, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b8019, 0x1)   retd();                               /* ret */
FUNC_END

