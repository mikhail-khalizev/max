FUNC_BEGIN(0x1007efe9, 0xe35d8fd14d10375d, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x5f, 0x6d, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc7, 0x45, 0xf8, 0x4, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1007efe9, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1007efee, 0x5)   calld(sys_check_available_stack_size, 0xe6d5f); /* call 0x10165d52 */
    II(0x1007eff3, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1007eff4, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1007eff5, 0x1)   pushd(edx);                           /* push edx */
    II(0x1007eff6, 0x1)   pushd(esi);                           /* push esi */
    II(0x1007eff7, 0x1)   pushd(edi);                           /* push edi */
    II(0x1007eff8, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1007eff9, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1007effb, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1007f001, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1007f004, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0x4);    /* mov dword [ebp-0x8], 0x4 */
    II(0x1007f00b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1007f00e, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1007f010, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1007f011, 0x1)   popd(edi);                            /* pop edi */
    II(0x1007f012, 0x1)   popd(esi);                            /* pop esi */
    II(0x1007f013, 0x1)   popd(edx);                            /* pop edx */
    II(0x1007f014, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1007f015, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1007f016, 0x1)   retd();                               /* ret */
FUNC_END

