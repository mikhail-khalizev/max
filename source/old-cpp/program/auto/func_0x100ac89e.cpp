FUNC_BEGIN(0x100ac89e, 0xf84666409c463eb7, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xaa, 0x94, 0xb, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x8a, 0x40, 0x19, 0x88, 0x45, 0xf4, 0x8a, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100ac89e, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100ac8a3, 0x5)   calld(sys_check_available_stack_size, 0xb94aa); /* call 0x10165d52 */
    II(0x100ac8a8, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100ac8a9, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ac8aa, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ac8ab, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ac8ac, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ac8ad, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ac8af, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100ac8b5, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100ac8b8, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100ac8bb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ac8be, 0x3)   mov(al, memb_a32(ds, eax + 0x19));    /* mov al, [eax+0x19] */
    II(0x100ac8c1, 0x3)   mov(memb_a32(ss, ebp - 0xc), al);     /* mov [ebp-0xc], al */
//    II(0x100ac8c4, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x100ac8c7, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ac8c9, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ac8ca, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ac8cb, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ac8cc, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ac8cd, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ac8ce, 0x1)   retd();                               /* ret */
FUNC_END

