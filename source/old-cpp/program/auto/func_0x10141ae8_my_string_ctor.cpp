FUNC_BEGIN(my_string_ctor, 0xfd302fc4b7a61924, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x60, 0x42, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x15, 0x14, 0x81, 0x1c, 0x10, 0x8b, 0x45, 0xfc, 0x89, 0x10, 0x8b, 0x45, 0xfc, 0x8b, 0, 0xe8, 0x4c, 0x9, 0, 0, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10141ae8, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10141aed, 0x5)   calld(sys_check_available_stack_size, 0x24260); /* call 0x10165d52 */
    II(0x10141af2, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10141af3, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10141af4, 0x1)   pushd(edx);                           /* push edx */
    II(0x10141af5, 0x1)   pushd(esi);                           /* push esi */
    II(0x10141af6, 0x1)   pushd(edi);                           /* push edi */
    II(0x10141af7, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10141af8, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10141afa, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10141b00, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10141b03, 0x6)   mov(edx, memd_a32(ds, 0x101c8114));   /* mov edx, [0x101c8114] */
//    II(0x10141b09, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10141b0c, 0x2)   mov(memd_a32(ds, eax), edx);          /* mov [eax], edx */
    II(0x10141b0e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10141b11, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10141b13, 0x5)   calld(my_string_add_ref, 0x94c);      /* call 0x10142464 */
    II(0x10141b18, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10141b1b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10141b1e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141b21, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10141b23, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10141b24, 0x1)   popd(edi);                            /* pop edi */
    II(0x10141b25, 0x1)   popd(esi);                            /* pop esi */
    II(0x10141b26, 0x1)   popd(edx);                            /* pop edx */
    II(0x10141b27, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10141b28, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10141b29, 0x1)   retd();                               /* ret */
FUNC_END

