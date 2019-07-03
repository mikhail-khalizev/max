FUNC_BEGIN(0x1007c9a1, 0x1ac381dbafd20951, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xa7, 0x93, 0xe, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1007c9a1, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1007c9a6, 0x5)   calld(sys_check_available_stack_size, 0xe93a7); /* call 0x10165d52 */
    II(0x1007c9ab, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1007c9ac, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1007c9ad, 0x1)   pushd(esi);                           /* push esi */
    II(0x1007c9ae, 0x1)   pushd(edi);                           /* push edi */
    II(0x1007c9af, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1007c9b0, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1007c9b2, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1007c9b8, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1007c9bb, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1007c9be, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1007c9c0, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1007c9c1, 0x1)   popd(edi);                            /* pop edi */
    II(0x1007c9c2, 0x1)   popd(esi);                            /* pop esi */
    II(0x1007c9c3, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1007c9c4, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1007c9c5, 0x1)   retd();                               /* ret */
FUNC_END

