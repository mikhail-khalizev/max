FUNC_BEGIN(0x10118210, 0xa0f29012a9ccfdd2, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x38, 0xdb, 0x4, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x89, 0x5d, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x58, 0x1a, 0xc1, 0xfb, 0x10, 0x8b, 0x45, 0xfc, 0x8b, 0x50, 0x18, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xf8, 0xe8, 0x63, 0xe8, 0xf5, 0xff, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x10118210, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10118215, 0x5)   calld(sys_check_available_stack_size, 0x4db38); /* call 0x10165d52 */
    II(0x1011821a, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011821b, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011821c, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011821d, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011821e, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10118220, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10118226, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x10118229, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x1011822c, 0x3)   mov(memd_a32(ss, ebp - 0x4), ebx);    /* mov [ebp-0x4], ebx */
    II(0x1011822f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10118232, 0x3)   mov(ebx, memd_a32(ds, eax + 0x1a));   /* mov ebx, [eax+0x1a] */
    II(0x10118235, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x10118238, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1011823b, 0x3)   mov(edx, memd_a32(ds, eax + 0x18));   /* mov edx, [eax+0x18] */
    II(0x1011823e, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x10118241, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10118244, 0x5)   calld(0x10076aac, -0xa179d);          /* call 0x10076aac */
    II(0x10118249, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011824c, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1011824e, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011824f, 0x1)   popd(edi);                            /* pop edi */
    II(0x10118250, 0x1)   popd(esi);                            /* pop esi */
    II(0x10118251, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10118252, 0x1)   retd();                               /* ret */
FUNC_END

