FUNC_BEGIN(0x101503d0, 0x7a84796e6bb1c58f, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x78, 0x59, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0xfc, 0x10, 0, 0, 0xf, 0xbf, 0xd0, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x6, 0xc1, 0xf8, 0x10, 0xe8, 0xfc, 0x19, 0xf2, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101503d0, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x101503d5, 0x5)   calld(sys_check_available_stack_size, 0x15978); /* call 0x10165d52 */
    II(0x101503da, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101503db, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101503dc, 0x1)   pushd(edx);                           /* push edx */
    II(0x101503dd, 0x1)   pushd(esi);                           /* push esi */
    II(0x101503de, 0x1)   pushd(edi);                           /* push edi */
    II(0x101503df, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101503e0, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101503e2, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x101503e8, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x101503eb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101503ee, 0x5)   calld(0x101514ef, 0x10fc);            /* call 0x101514ef */
    II(0x101503f3, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x101503f6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101503f9, 0x3)   mov(eax, memd_a32(ds, eax + 0x6));    /* mov eax, [eax+0x6] */
    II(0x101503fc, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x101503ff, 0x5)   calld(0x10071e00, -0xde604);          /* call 0x10071e00 */
    II(0x10150404, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10150407, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1015040a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1015040c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1015040d, 0x1)   popd(edi);                            /* pop edi */
    II(0x1015040e, 0x1)   popd(esi);                            /* pop esi */
    II(0x1015040f, 0x1)   popd(edx);                            /* pop edx */
    II(0x10150410, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10150411, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10150412, 0x1)   retd();                               /* ret */
FUNC_END

