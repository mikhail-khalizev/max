FUNC_BEGIN(my_string_ctor_char_ptr, 0x79911611a1278e3f, 0x20, ({0x68, 0x34, 0, 0, 0, 0xe8, 0xd, 0x43, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x1c, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xb8, 0xc, 0, 0, 0, 0xe8, 0x9e, 0x43, 0x2, 0, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xf0, 0x89, 0x45, 0xec, 0x83, 0x7d, 0xec, 0, 0x74, 0x16, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf0, 0xe8, 0x20, 0xfd, 0xff, 0xff, 0x89, 0x45, 0xe8, 0x8b, 0x45, 0xe8, 0x89, 0x45, 0xf4, 0xeb, 0x6, 0x8b, 0x45, 0xec, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x8b, 0x55, 0xf8, 0x89, 0x2, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xe4, 0x8b, 0x45, 0xe4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10141a3b, 0x5)   pushd(0x34);                          /* push dword 0x34 */
    II(0x10141a40, 0x5)   calld(sys_check_available_stack_size, 0x2430d); /* call 0x10165d52 */
    II(0x10141a45, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10141a46, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10141a47, 0x1)   pushd(esi);                           /* push esi */
    II(0x10141a48, 0x1)   pushd(edi);                           /* push edi */
    II(0x10141a49, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10141a4a, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10141a4c, 0x6)   sub(esp, 0x1c);                       /* sub esp, 0x1c */
    II(0x10141a52, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10141a55, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x10141a58, 0x5)   mov(eax, 0xc);                        /* mov eax, 0xc */
    II(0x10141a5d, 0x5)   calld(sys_new, 0x2439e);              /* call 0x10165e00 */
    II(0x10141a62, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
//    II(0x10141a65, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10141a68, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x10141a6b, 0x4)   cmp(memd_a32(ss, ebp - 0x14), 0);     /* cmp dword [ebp-0x14], 0x0 */
    II(0x10141a6f, 0x2)   jzd(0x10141a87, 0x16);                /* jz 0x10141a87 */
    II(0x10141a71, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x10141a74, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10141a77, 0x5)   calld(my_strobj_ctor_char_ptr, -0x2e0); /* call 0x1014179c */
    II(0x10141a7c, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
//    II(0x10141a7f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x10141a82, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x10141a85, 0x2)   jmpd(0x10141a8d, 0x6);                /* jmp 0x10141a8d */
l_0x10141a87:
    II(0x10141a87, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x10141a8a, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
l_0x10141a8d:
    II(0x10141a8d, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10141a90, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x10141a93, 0x2)   mov(memd_a32(ds, edx), eax);          /* mov [edx], eax */
    II(0x10141a95, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141a98, 0x3)   mov(memd_a32(ss, ebp - 0x1c), eax);   /* mov [ebp-0x1c], eax */
//    II(0x10141a9b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x1c));   /* mov eax, [ebp-0x1c] */
    II(0x10141a9e, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10141aa0, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10141aa1, 0x1)   popd(edi);                            /* pop edi */
    II(0x10141aa2, 0x1)   popd(esi);                            /* pop esi */
    II(0x10141aa3, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10141aa4, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10141aa5, 0x1)   retd();                               /* ret */
FUNC_END

