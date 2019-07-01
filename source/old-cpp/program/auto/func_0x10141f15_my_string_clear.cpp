FUNC_BEGIN(my_string_clear, 0x9582e92aaa12a262, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x33, 0x3e, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x24, 0x4, 0, 0, 0x8b, 0x45, 0xfc, 0x8b, 0, 0xe8, 0xba, 0x78, 0xf4, 0xff, 0xc6, 0, 0, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x8b, 0, 0xe8, 0x9b, 0x5, 0, 0, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10141f15, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10141f1a, 0x5)   calld(sys_check_available_stack_size, 0x23e33); /* call 0x10165d52 */
    II(0x10141f1f, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10141f20, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10141f21, 0x1)   pushd(edx);                           /* push edx */
    II(0x10141f22, 0x1)   pushd(esi);                           /* push esi */
    II(0x10141f23, 0x1)   pushd(edi);                           /* push edi */
    II(0x10141f24, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10141f25, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10141f27, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10141f2d, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10141f30, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10141f33, 0x5)   calld(my_string_make_single_ref, 0x424); /* call 0x1014235c */
    II(0x10141f38, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10141f3b, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10141f3d, 0x5)   calld(my_strobj_c_str, -0xb8746);     /* call 0x100897fc */
    II(0x10141f42, 0x3)   mov(memb_a32(ds, eax), 0);            /* mov byte [eax], 0x0 */
    II(0x10141f45, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10141f47, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10141f4a, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10141f4c, 0x5)   calld(my_strobj_set_len, 0x59b);      /* call 0x101424ec */
    II(0x10141f51, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10141f54, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10141f57, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141f5a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10141f5c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10141f5d, 0x1)   popd(edi);                            /* pop edi */
    II(0x10141f5e, 0x1)   popd(esi);                            /* pop esi */
    II(0x10141f5f, 0x1)   popd(edx);                            /* pop edx */
    II(0x10141f60, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10141f61, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10141f62, 0x1)   retd();                               /* ret */
FUNC_END

