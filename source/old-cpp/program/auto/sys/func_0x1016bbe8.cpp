FUNC_BEGIN(/* sys */ 0x1016bbe8, 0xfcfaf5ae70ef0eae, 0x20, ({0x56, 0x57, 0x55, 0x89, 0xc6, 0x89, 0xd5, 0x89, 0xdf, 0x8b, 0x5c, 0x24, 0x10, 0x89, 0xca, 0x31, 0xc0, 0x8a, 0x44, 0x24, 0x1c, 0x50, 0x8b, 0x4c, 0x24, 0x1c, 0x51, 0x8b, 0x44, 0x24, 0x1c, 0x50, 0x89, 0xf8, 0xf, 0xaf, 0xc2, 0xf, 0xaf, 0xc3, 0x89, 0xd1, 0x1, 0xf0, 0xe8, 0x23, 0xfe, 0xff, 0xff, 0x83, 0xf8, 0xff, 0x74, 0x27, 0x8b, 0x44, 0x24, 0x20, 0x89, 0x35, 0x68, 0xde, 0x1b, 0x10, 0x89, 0x2d, 0xf4, 0xfb, 0x1c, 0x10, 0xa3, 0xe0, 0xfb, 0x1c, 0x10, 0xb8, 0x4c, 0xbc, 0x16, 0x10, 0x89, 0x3d, 0xe4, 0xfb, 0x1c, 0x10, 0xe8, 0x99, 0xf7, 0xff, 0xff, 0x31, 0xc0, 0x5d, 0x5f, 0x5e, 0xc2, 0x14, 0}))
    II(0x1016bbe8, 0x1)   pushd(esi);                           /* push esi */
    II(0x1016bbe9, 0x1)   pushd(edi);                           /* push edi */
    II(0x1016bbea, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1016bbeb, 0x2)   mov(esi, eax);                        /* mov esi, eax */
    II(0x1016bbed, 0x2)   mov(ebp, edx);                        /* mov ebp, edx */
    II(0x1016bbef, 0x2)   mov(edi, ebx);                        /* mov edi, ebx */
    II(0x1016bbf1, 0x4)   mov(ebx, memd_a32(ss, esp + 0x10));   /* mov ebx, [esp+0x10] */
    II(0x1016bbf5, 0x2)   mov(edx, ecx);                        /* mov edx, ecx */
    II(0x1016bbf7, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1016bbf9, 0x4)   mov(al, memb_a32(ss, esp + 0x1c));    /* mov al, [esp+0x1c] */
    II(0x1016bbfd, 0x1)   pushd(eax);                           /* push eax */
    II(0x1016bbfe, 0x4)   mov(ecx, memd_a32(ss, esp + 0x1c));   /* mov ecx, [esp+0x1c] */
    II(0x1016bc02, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1016bc03, 0x4)   mov(eax, memd_a32(ss, esp + 0x1c));   /* mov eax, [esp+0x1c] */
    II(0x1016bc07, 0x1)   pushd(eax);                           /* push eax */
    II(0x1016bc08, 0x2)   mov(eax, edi);                        /* mov eax, edi */
    II(0x1016bc0a, 0x3)   imul(eax, edx);                       /* imul eax, edx */
    II(0x1016bc0d, 0x3)   imul(eax, ebx);                       /* imul eax, ebx */
    II(0x1016bc10, 0x2)   mov(ecx, edx);                        /* mov ecx, edx */
    II(0x1016bc12, 0x2)   add(eax, esi);                        /* add eax, esi */
    II(0x1016bc14, 0x5)   calld(/* sys */ 0x1016ba3c, -0x1dd);  /* call 0x1016ba3c */
    II(0x1016bc19, 0x3)   cmp(eax, -0x1 /* 0xff */);            /* cmp eax, 0xff */
    II(0x1016bc1c, 0x2)   jzd(0x1016bc45, 0x27);                /* jz 0x1016bc45 */
    II(0x1016bc1e, 0x4)   mov(eax, memd_a32(ss, esp + 0x20));   /* mov eax, [esp+0x20] */
    II(0x1016bc22, 0x6)   mov(memd_a32(ds, 0x101bde68), esi);   /* mov [0x101bde68], esi */
    II(0x1016bc28, 0x6)   mov(memd_a32(ds, 0x101cfbf4), ebp);   /* mov [0x101cfbf4], ebp */
    II(0x1016bc2e, 0x5)   mov(memd_a32(ds, 0x101cfbe0), eax);   /* mov [0x101cfbe0], eax */
    II(0x1016bc33, 0x5)   mov(eax, /* sys */ 0x1016bc4c);       /* mov eax, 0x1016bc4c */
    II(0x1016bc38, 0x6)   mov(memd_a32(ds, 0x101cfbe4), edi);   /* mov [0x101cfbe4], edi */
    II(0x1016bc3e, 0x5)   calld(/* sys */ 0x1016b3dc, -0x867);  /* call 0x1016b3dc */
    II(0x1016bc43, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
l_0x1016bc45:
    II(0x1016bc45, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1016bc46, 0x1)   popd(edi);                            /* pop edi */
    II(0x1016bc47, 0x1)   popd(esi);                            /* pop esi */
    II(0x1016bc48, 0x3)   retd(0x14);                           /* ret 0x14 */
FUNC_END

