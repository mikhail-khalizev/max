FUNC_BEGIN(0x100eaef0, 0xb2065b6af8e28866, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x58, 0xae, 0x7, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0, 0xe8, 0xf, 0, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100eaef0, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100eaef5, 0x5)   calld(sys_check_available_stack_size, 0x7ae58); /* call 0x10165d52 */
    II(0x100eaefa, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100eaefb, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100eaefc, 0x1)   pushd(edx);                           /* push edx */
    II(0x100eaefd, 0x1)   pushd(esi);                           /* push esi */
    II(0x100eaefe, 0x1)   pushd(edi);                           /* push edi */
    II(0x100eaeff, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100eaf00, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100eaf02, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100eaf08, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100eaf0b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100eaf0e, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x100eaf10, 0x5)   calld(my_strobj_get_len, 0xf);        /* call 0x100eaf24 */
    II(0x100eaf15, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100eaf18, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100eaf1b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100eaf1d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100eaf1e, 0x1)   popd(edi);                            /* pop edi */
    II(0x100eaf1f, 0x1)   popd(esi);                            /* pop esi */
    II(0x100eaf20, 0x1)   popd(edx);                            /* pop edx */
    II(0x100eaf21, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100eaf22, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100eaf23, 0x1)   retd();                               /* ret */
FUNC_END

