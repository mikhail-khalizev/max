FUNC_BEGIN(0x10136dc2, 0x63d2e36f0f7d4a7c, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x86, 0xef, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x50, 0x14, 0x8b, 0x45, 0xfc, 0xe8, 0x15, 0xff, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10136dc2, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10136dc7, 0x5)   calld(sys_check_available_stack_size, 0x2ef86); /* call 0x10165d52 */
    II(0x10136dcc, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10136dcd, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10136dce, 0x1)   pushd(edx);                           /* push edx */
    II(0x10136dcf, 0x1)   pushd(esi);                           /* push esi */
    II(0x10136dd0, 0x1)   pushd(edi);                           /* push edi */
    II(0x10136dd1, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10136dd2, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10136dd4, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10136dda, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10136ddd, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10136de0, 0x3)   mov(edx, memd_a32(ds, eax + 0x14));   /* mov edx, [eax+0x14] */
//    II(0x10136de3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10136de6, 0x5)   calld(0x10136d00, -0xeb);             /* call 0x10136d00 */
    II(0x10136deb, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10136ded, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10136dee, 0x1)   popd(edi);                            /* pop edi */
    II(0x10136def, 0x1)   popd(esi);                            /* pop esi */
    II(0x10136df0, 0x1)   popd(edx);                            /* pop edx */
    II(0x10136df1, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10136df2, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10136df3, 0x1)   retd();                               /* ret */
FUNC_END

