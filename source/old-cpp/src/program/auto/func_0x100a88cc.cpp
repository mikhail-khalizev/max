FUNC_BEGIN(0x100a88cc, 0x545bf6aefc923b89, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x7c, 0xd4, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x2, 0x8b, 0x45, 0xf8, 0xff, 0x52, 0x3c, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100a88cc, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100a88d1, 0x5)   calld(sys_check_available_stack_size, 0xbd47c); /* call 0x10165d52 */
    II(0x100a88d6, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100a88d7, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100a88d8, 0x1)   pushd(edx);                           /* push edx */
    II(0x100a88d9, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a88da, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a88db, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a88dc, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a88de, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100a88e4, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100a88e7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100a88ea, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100a88ed, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100a88f0, 0x3)   mov(edx, memd_a32(ds, eax + 0x2));    /* mov edx, [eax+0x2] */
//    II(0x100a88f3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100a88f6, 0x3)   calld_abs(memd_a32(ds, edx + 0x3c));  /* call dword near [edx+0x3c] */
    II(0x100a88f9, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100a88fb, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100a88fc, 0x1)   popd(edi);                            /* pop edi */
    II(0x100a88fd, 0x1)   popd(esi);                            /* pop esi */
    II(0x100a88fe, 0x1)   popd(edx);                            /* pop edx */
    II(0x100a88ff, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100a8900, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100a8901, 0x1)   retd();                               /* ret */
FUNC_END

