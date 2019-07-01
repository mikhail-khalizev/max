FUNC_BEGIN(my_ctor_0x101b6edc, 0x1b7f9e0155742e0b, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x4, 0xef, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xc7, 0, 0, 0, 0, 0, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10076e44, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10076e49, 0x5)   calld(sys_check_available_stack_size, 0xeef04); /* call 0x10165d52 */
    II(0x10076e4e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10076e4f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10076e50, 0x1)   pushd(edx);                           /* push edx */
    II(0x10076e51, 0x1)   pushd(esi);                           /* push esi */
    II(0x10076e52, 0x1)   pushd(edi);                           /* push edi */
    II(0x10076e53, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10076e54, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10076e56, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10076e5c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10076e5f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10076e62, 0x6)   mov(memd_a32(ds, eax), 0);            /* mov dword [eax], 0x0 */
    II(0x10076e68, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10076e6b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10076e6e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10076e71, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10076e73, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10076e74, 0x1)   popd(edi);                            /* pop edi */
    II(0x10076e75, 0x1)   popd(esi);                            /* pop esi */
    II(0x10076e76, 0x1)   popd(edx);                            /* pop edx */
    II(0x10076e77, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10076e78, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10076e79, 0x1)   retd();                               /* ret */
FUNC_END

