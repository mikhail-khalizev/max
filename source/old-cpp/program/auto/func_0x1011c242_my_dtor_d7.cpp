FUNC_BEGIN(my_dtor_d7, 0xfa589b6136a92d1b, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x6, 0x9b, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xc7, 0x45, 0xf4, 0, 0, 0, 0, 0xeb, 0x6, 0x8b, 0x45, 0xf4, 0xff, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x66, 0x3b, 0x5, 0x72, 0x81, 0x1c, 0x10, 0x7d, 0x2f, 0xf, 0xbf, 0x45, 0xf4, 0xc1, 0xe0, 0x2, 0x89, 0xc2, 0x8b, 0x45, 0xf8, 0x8b, 0, 0x1, 0xd0, 0x8b, 0, 0xe8, 0xd3, 0x9c, 0x4, 0, 0xf, 0xbf, 0x55, 0xf4, 0xc1, 0xe2, 0x2, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x4, 0x1, 0xd0, 0x8b, 0, 0xe8, 0xbd, 0x9c, 0x4, 0, 0xeb, 0xbf, 0x8b, 0x45, 0xf8, 0x8b, 0, 0xe8, 0xb1, 0x9c, 0x4, 0, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x4, 0xe8, 0xa6, 0x9c, 0x4, 0, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x8, 0xe8, 0x9b, 0x9c, 0x4, 0, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0xe, 0xe8, 0x6, 0x42, 0, 0, 0x83, 0xe8, 0xe, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xf0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1011c242, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x1011c247, 0x5)   calld(sys_check_available_stack_size, 0x49b06); /* call 0x10165d52 */
    II(0x1011c24c, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1011c24d, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011c24e, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011c24f, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011c250, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011c251, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1011c253, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x1011c259, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1011c25c, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1011c25f, 0x7)   mov(memd_a32(ss, ebp - 0xc), 0);      /* mov dword [ebp-0xc], 0x0 */
    II(0x1011c266, 0x2)   jmpd(0x1011c26e, 0x6);                /* jmp 0x1011c26e */
l_0x1011c268:
    II(0x1011c268, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1011c26b, 0x3)   inc(memd_a32(ss, ebp - 0xc));         /* inc dword [ebp-0xc] */
l_0x1011c26e:
    II(0x1011c26e, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1011c271, 0x7)   cmp(ax, memw_a32(ds, 0x101c8172));    /* cmp ax, [0x101c8172] */
    II(0x1011c278, 0x2)   jged(0x1011c2a9, 0x2f);               /* jge 0x1011c2a9 */
    II(0x1011c27a, 0x4)   movsx(eax, memw_a32(ss, ebp - 0xc));  /* movsx eax, word [ebp-0xc] */
    II(0x1011c27e, 0x3)   shl(eax, 0x2);                        /* shl eax, 0x2 */
    II(0x1011c281, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1011c283, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011c286, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1011c288, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x1011c28a, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1011c28c, 0x5)   calld(sys_delete, 0x49cd3);           /* call 0x10165f64 */
    II(0x1011c291, 0x4)   movsx(edx, memw_a32(ss, ebp - 0xc));  /* movsx edx, word [ebp-0xc] */
    II(0x1011c295, 0x3)   shl(edx, 0x2);                        /* shl edx, 0x2 */
    II(0x1011c298, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011c29b, 0x3)   mov(eax, memd_a32(ds, eax + 0x4));    /* mov eax, [eax+0x4] */
    II(0x1011c29e, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x1011c2a0, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1011c2a2, 0x5)   calld(sys_delete, 0x49cbd);           /* call 0x10165f64 */
    II(0x1011c2a7, 0x2)   jmpd(0x1011c268, -0x41);              /* jmp 0x1011c268 */
l_0x1011c2a9:
    II(0x1011c2a9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011c2ac, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1011c2ae, 0x5)   calld(sys_delete, 0x49cb1);           /* call 0x10165f64 */
    II(0x1011c2b3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011c2b6, 0x3)   mov(eax, memd_a32(ds, eax + 0x4));    /* mov eax, [eax+0x4] */
    II(0x1011c2b9, 0x5)   calld(sys_delete, 0x49ca6);           /* call 0x10165f64 */
    II(0x1011c2be, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011c2c1, 0x3)   mov(eax, memd_a32(ds, eax + 0x8));    /* mov eax, [eax+0x8] */
    II(0x1011c2c4, 0x5)   calld(sys_delete, 0x49c9b);           /* call 0x10165f64 */
    II(0x1011c2c9, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1011c2cb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011c2ce, 0x3)   add(eax, 0xe);                        /* add eax, 0xe */
    II(0x1011c2d1, 0x5)   calld(0x101204dc, 0x4206);            /* call 0x101204dc */
    II(0x1011c2d6, 0x3)   sub(eax, 0xe);                        /* sub eax, 0xe */
    II(0x1011c2d9, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1011c2dc, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011c2df, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
//    II(0x1011c2e2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x1011c2e5, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1011c2e7, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011c2e8, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011c2e9, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011c2ea, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1011c2eb, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1011c2ec, 0x1)   retd();                               /* ret */
FUNC_END

