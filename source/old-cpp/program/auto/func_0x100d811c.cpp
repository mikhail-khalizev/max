FUNC_BEGIN(0x100d811c, 0x9e6c745081ed7d54, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x2c, 0xdc, 0x8, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x80, 0x78, 0xc, 0, 0x75, 0x4e, 0x8b, 0x45, 0xfc, 0x8b, 0x50, 0x6, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x8, 0xc1, 0xf8, 0x10, 0xf, 0xaf, 0xc2, 0xe8, 0xb6, 0xde, 0x8, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xfc, 0x8b, 0x50, 0x6, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0x8b, 0x58, 0x8, 0xc1, 0xfb, 0x10, 0xf, 0xaf, 0xda, 0x8b, 0x45, 0xfc, 0x8b, 0x10, 0x8b, 0x45, 0xf8, 0xe8, 0xcc, 0xdc, 0x8, 0, 0x8b, 0x45, 0xf8, 0x8b, 0x55, 0xfc, 0x89, 0x2, 0x8b, 0x45, 0xfc, 0xc6, 0x40, 0xc, 0x1, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100d811c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100d8121, 0x5)   calld(sys_check_available_stack_size, 0x8dc2c); /* call 0x10165d52 */
    II(0x100d8126, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100d8127, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100d8128, 0x1)   pushd(edx);                           /* push edx */
    II(0x100d8129, 0x1)   pushd(esi);                           /* push esi */
    II(0x100d812a, 0x1)   pushd(edi);                           /* push edi */
    II(0x100d812b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100d812c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100d812e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100d8134, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100d8137, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d813a, 0x4)   cmp(memb_a32(ds, eax + 0xc), 0);      /* cmp byte [eax+0xc], 0x0 */
    II(0x100d813e, 0x2)   jnzd(0x100d818e, 0x4e);               /* jnz 0x100d818e */
    II(0x100d8140, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d8143, 0x3)   mov(edx, memd_a32(ds, eax + 0x6));    /* mov edx, [eax+0x6] */
    II(0x100d8146, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x100d8149, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d814c, 0x3)   mov(eax, memd_a32(ds, eax + 0x8));    /* mov eax, [eax+0x8] */
    II(0x100d814f, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100d8152, 0x3)   imul(eax, edx);                       /* imul eax, edx */
    II(0x100d8155, 0x5)   calld(sys_new_arr, 0x8deb6);          /* call 0x10166010 */
    II(0x100d815a, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100d815d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d8160, 0x3)   mov(edx, memd_a32(ds, eax + 0x6));    /* mov edx, [eax+0x6] */
    II(0x100d8163, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x100d8166, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d8169, 0x3)   mov(ebx, memd_a32(ds, eax + 0x8));    /* mov ebx, [eax+0x8] */
    II(0x100d816c, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x100d816f, 0x3)   imul(ebx, edx);                       /* imul ebx, edx */
    II(0x100d8172, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d8175, 0x2)   mov(edx, memd_a32(ds, eax));          /* mov edx, [eax] */
    II(0x100d8177, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d817a, 0x5)   calld(sys_memcpy, 0x8dccc);           /* call 0x10165e4b */
    II(0x100d817f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d8182, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100d8185, 0x2)   mov(memd_a32(ds, edx), eax);          /* mov [edx], eax */
    II(0x100d8187, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d818a, 0x4)   mov(memb_a32(ds, eax + 0xc), 0x1);    /* mov byte [eax+0xc], 0x1 */
l_0x100d818e:
    II(0x100d818e, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100d8190, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100d8191, 0x1)   popd(edi);                            /* pop edi */
    II(0x100d8192, 0x1)   popd(esi);                            /* pop esi */
    II(0x100d8193, 0x1)   popd(edx);                            /* pop edx */
    II(0x100d8194, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100d8195, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100d8196, 0x1)   retd();                               /* ret */
FUNC_END

