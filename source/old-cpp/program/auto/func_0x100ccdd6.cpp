FUNC_BEGIN(0x100ccdd6, 0x6cb319562a6d2582, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x72, 0x8f, 0x9, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x14, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x88, 0x5d, 0xfc, 0x8b, 0x45, 0xf4, 0x89, 0x45, 0xf0, 0x80, 0x7d, 0xfc, 0x2, 0x75, 0xa, 0x8b, 0x45, 0xf0, 0xe8, 0x5f, 0xff, 0xff, 0xff, 0xeb, 0x18, 0x80, 0x7d, 0xfc, 0, 0x75, 0x12, 0x8b, 0x45, 0xf0, 0x89, 0x45, 0xec, 0x8b, 0x45, 0xec, 0x8b, 0x50, 0x2, 0x8b, 0x45, 0xec, 0xff, 0x52, 0x3c, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x100ccdd6, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x100ccddb, 0x5)   calld(sys_check_available_stack_size, 0x98f72); /* call 0x10165d52 */
    II(0x100ccde0, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ccde1, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ccde2, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ccde3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ccde4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ccde6, 0x6)   sub(esp, 0x14);                       /* sub esp, 0x14 */
    II(0x100ccdec, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x100ccdef, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x100ccdf2, 0x3)   mov(memb_a32(ss, ebp - 0x4), bl);     /* mov [ebp-0x4], bl */
    II(0x100ccdf5, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100ccdf8, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x100ccdfb, 0x4)   cmp(memb_a32(ss, ebp - 0x4), 0x2);    /* cmp byte [ebp-0x4], 0x2 */
    II(0x100ccdff, 0x2)   jnzd(0x100cce0b, 0xa);                /* jnz 0x100cce0b */
    II(0x100cce01, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100cce04, 0x5)   calld(0x100ccd68, -0xa1);             /* call 0x100ccd68 */
    II(0x100cce09, 0x2)   jmpd(0x100cce23, 0x18);               /* jmp 0x100cce23 */
l_0x100cce0b:
    II(0x100cce0b, 0x4)   cmp(memb_a32(ss, ebp - 0x4), 0);      /* cmp byte [ebp-0x4], 0x0 */
    II(0x100cce0f, 0x2)   jnzd(0x100cce23, 0x12);               /* jnz 0x100cce23 */
    II(0x100cce11, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100cce14, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
//    II(0x100cce17, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x100cce1a, 0x3)   mov(edx, memd_a32(ds, eax + 0x2));    /* mov edx, [eax+0x2] */
//    II(0x100cce1d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x100cce20, 0x3)   calld_abs(memd_a32(ds, edx + 0x3c));  /* call dword near [edx+0x3c] */
l_0x100cce23:
    II(0x100cce23, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cce25, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cce26, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cce27, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cce28, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cce29, 0x1)   retd();                               /* ret */
FUNC_END

