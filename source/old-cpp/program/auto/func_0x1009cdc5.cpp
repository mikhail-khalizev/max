FUNC_BEGIN(0x1009cdc5, 0x82b0bc777677405b, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x83, 0x8f, 0xc, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x8b, 0x50, 0x2, 0x8b, 0x45, 0xf4, 0xff, 0x52, 0x20, 0x3c, 0x19, 0x75, 0x1d, 0x8b, 0x45, 0xf8, 0x66, 0xff, 0x48, 0x21, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x1f, 0xc1, 0xf8, 0x10, 0x85, 0xc0, 0x7d, 0x9, 0x8b, 0x45, 0xf8, 0x66, 0xc7, 0x40, 0x21, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1009cdc5, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1009cdca, 0x5)   calld(sys_check_available_stack_size, 0xc8f83); /* call 0x10165d52 */
    II(0x1009cdcf, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009cdd0, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009cdd1, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009cdd2, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009cdd3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009cdd4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009cdd6, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1009cddc, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1009cddf, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1009cde2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1009cde5, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1009cde8, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1009cdeb, 0x3)   mov(edx, memd_a32(ds, eax + 0x2));    /* mov edx, [eax+0x2] */
//    II(0x1009cdee, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1009cdf1, 0x3)   calld_abs(memd_a32(ds, edx + 0x20));  /* call dword near [edx+0x20] */
    II(0x1009cdf4, 0x2)   cmp(al, 0x19);                        /* cmp al, 0x19 */
    II(0x1009cdf6, 0x2)   jnzd(0x1009ce15, 0x1d);               /* jnz 0x1009ce15 */
    II(0x1009cdf8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009cdfb, 0x4)   dec(memw_a32(ds, eax + 0x21));        /* dec word [eax+0x21] */
    II(0x1009cdff, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009ce02, 0x3)   mov(eax, memd_a32(ds, eax + 0x1f));   /* mov eax, [eax+0x1f] */
    II(0x1009ce05, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1009ce08, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1009ce0a, 0x2)   jged(0x1009ce15, 0x9);                /* jge 0x1009ce15 */
    II(0x1009ce0c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009ce0f, 0x6)   mov(memw_a32(ds, eax + 0x21), 0);     /* mov word [eax+0x21], 0x0 */
l_0x1009ce15:
    II(0x1009ce15, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009ce17, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009ce18, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009ce19, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009ce1a, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009ce1b, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009ce1c, 0x1)   retd();                               /* ret */
FUNC_END

