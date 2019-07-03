FUNC_BEGIN(0x1010e477, 0x2f273095d2d7aefb, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xd1, 0x78, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xc7, 0x40, 0x8, 0x1, 0, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1010e477, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1010e47c, 0x5)   calld(sys_check_available_stack_size, 0x578d1); /* call 0x10165d52 */
    II(0x1010e481, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1010e482, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1010e483, 0x1)   pushd(edx);                           /* push edx */
    II(0x1010e484, 0x1)   pushd(esi);                           /* push esi */
    II(0x1010e485, 0x1)   pushd(edi);                           /* push edi */
    II(0x1010e486, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1010e487, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1010e489, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1010e48f, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1010e492, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010e495, 0x7)   mov(memd_a32(ds, eax + 0x8), 0x1);    /* mov dword [eax+0x8], 0x1 */
    II(0x1010e49c, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1010e49e, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1010e49f, 0x1)   popd(edi);                            /* pop edi */
    II(0x1010e4a0, 0x1)   popd(esi);                            /* pop esi */
    II(0x1010e4a1, 0x1)   popd(edx);                            /* pop edx */
    II(0x1010e4a2, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1010e4a3, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1010e4a4, 0x1)   retd();                               /* ret */
FUNC_END

