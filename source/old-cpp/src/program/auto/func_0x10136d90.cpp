FUNC_BEGIN(0x10136d90, 0x2ef03d99c2c9ac23, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xb8, 0xef, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x50, 0x18, 0x8b, 0x45, 0xfc, 0xe8, 0x47, 0xff, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10136d90, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10136d95, 0x5)   calld(sys_check_available_stack_size, 0x2efb8); /* call 0x10165d52 */
    II(0x10136d9a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10136d9b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10136d9c, 0x1)   pushd(edx);                           /* push edx */
    II(0x10136d9d, 0x1)   pushd(esi);                           /* push esi */
    II(0x10136d9e, 0x1)   pushd(edi);                           /* push edi */
    II(0x10136d9f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10136da0, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10136da2, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10136da8, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10136dab, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10136dae, 0x3)   mov(edx, memd_a32(ds, eax + 0x18));   /* mov edx, [eax+0x18] */
//    II(0x10136db1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10136db4, 0x5)   calld(0x10136d00, -0xb9);             /* call 0x10136d00 */
    II(0x10136db9, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10136dbb, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10136dbc, 0x1)   popd(edi);                            /* pop edi */
    II(0x10136dbd, 0x1)   popd(esi);                            /* pop esi */
    II(0x10136dbe, 0x1)   popd(edx);                            /* pop edx */
    II(0x10136dbf, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10136dc0, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10136dc1, 0x1)   retd();                               /* ret */
FUNC_END

