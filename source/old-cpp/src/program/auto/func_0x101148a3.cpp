FUNC_BEGIN(0x101148a3, 0x61487e15b029c40e, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xa5, 0x14, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0xe8, 0x6c, 0x64, 0x1, 0, 0x8b, 0x45, 0xfc, 0xc7, 0x40, 0x4, 0x1b, 0, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101148a3, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x101148a8, 0x5)   calld(sys_check_available_stack_size, 0x514a5); /* call 0x10165d52 */
    II(0x101148ad, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101148ae, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101148af, 0x1)   pushd(edx);                           /* push edx */
    II(0x101148b0, 0x1)   pushd(esi);                           /* push esi */
    II(0x101148b1, 0x1)   pushd(edi);                           /* push edi */
    II(0x101148b2, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101148b3, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101148b5, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x101148bb, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x101148be, 0x5)   calld(0x1012ad2f, 0x1646c);           /* call 0x1012ad2f */
    II(0x101148c3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101148c6, 0x7)   mov(memd_a32(ds, eax + 0x4), 0x1b);   /* mov dword [eax+0x4], 0x1b */
    II(0x101148cd, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101148cf, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101148d0, 0x1)   popd(edi);                            /* pop edi */
    II(0x101148d1, 0x1)   popd(esi);                            /* pop esi */
    II(0x101148d2, 0x1)   popd(edx);                            /* pop edx */
    II(0x101148d3, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101148d4, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101148d5, 0x1)   retd();                               /* ret */
FUNC_END

