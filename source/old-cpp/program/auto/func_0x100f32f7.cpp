FUNC_BEGIN(0x100f32f7, 0xaaab8215a77e578c, 0x20, ({0x68, 0x38, 0, 0, 0, 0xe8, 0x51, 0x2a, 0x7, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xfc, 0xf, 0xbf, 0x45, 0xfc, 0x50, 0xb8, 0x75, 0x24, 0x1a, 0x10, 0x50, 0x8d, 0x45, 0xf0, 0x50, 0xe8, 0xdb, 0x2b, 0x7, 0, 0x83, 0xc4, 0xc, 0xe8, 0x6, 0xf7, 0, 0, 0x89, 0xc1, 0xbb, 0xa2, 0, 0, 0, 0x8d, 0x55, 0xf0, 0xb8, 0x2, 0, 0, 0, 0xe8, 0x34, 0xfe, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100f32f7, 0x5)   pushd(0x38);                          /* push dword 0x38 */
    II(0x100f32fc, 0x5)   calld(sys_check_available_stack_size, 0x72a51); /* call 0x10165d52 */
    II(0x100f3301, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100f3302, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100f3303, 0x1)   pushd(edx);                           /* push edx */
    II(0x100f3304, 0x1)   pushd(esi);                           /* push esi */
    II(0x100f3305, 0x1)   pushd(edi);                           /* push edi */
    II(0x100f3306, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100f3307, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100f3309, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x100f330f, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100f3312, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100f3316, 0x1)   pushd(eax);                           /* push eax */
    II(0x100f3317, 0x5)   mov(eax, 0x101a2475);                 /* mov eax, 0x101a2475 */ /* "%i" */
    II(0x100f331c, 0x1)   pushd(eax);                           /* push eax */
    II(0x100f331d, 0x3)   lea(eax, ebp - 0x10);                 /* lea eax, [ebp-0x10] */
    II(0x100f3320, 0x1)   pushd(eax);                           /* push eax */
    II(0x100f3321, 0x5)   calld(sys_sprintf, 0x72bdb);          /* call 0x10165f01 */
    II(0x100f3326, 0x3)   add(esp, 0xc);                        /* add esp, 0xc */
    II(0x100f3329, 0x5)   calld(0x10102a34, 0xf706);            /* call 0x10102a34 */
    II(0x100f332e, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x100f3330, 0x5)   mov(ebx, 0xa2);                       /* mov ebx, 0xa2 */
    II(0x100f3335, 0x3)   lea(edx, ebp - 0x10);                 /* lea edx, [ebp-0x10] */
    II(0x100f3338, 0x5)   mov(eax, 0x2);                        /* mov eax, 0x2 */
    II(0x100f333d, 0x5)   calld(0x100f3176, -0x1cc);            /* call 0x100f3176 */
    II(0x100f3342, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100f3344, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100f3345, 0x1)   popd(edi);                            /* pop edi */
    II(0x100f3346, 0x1)   popd(esi);                            /* pop esi */
    II(0x100f3347, 0x1)   popd(edx);                            /* pop edx */
    II(0x100f3348, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100f3349, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100f334a, 0x1)   retd();                               /* ret */
FUNC_END

