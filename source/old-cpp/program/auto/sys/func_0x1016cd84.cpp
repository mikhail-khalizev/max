FUNC_BEGIN(/* sys */ 0x1016cd84, 0xb776ec24010e7aea, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x83, 0xec, 0x10, 0x88, 0x44, 0x24, 0xc, 0x31, 0xc9, 0x31, 0xd2, 0x31, 0xdb, 0x8a, 0x5c, 0x24, 0xc, 0x89, 0xd8, 0xe8, 0x46, 0xfd, 0xff, 0xff, 0x89, 0xc7, 0x89, 0xd8, 0xe8, 0x3d, 0xfd, 0xff, 0xff, 0x89, 0xc6, 0x89, 0xd8, 0x81, 0xe7, 0, 0x7c, 0, 0, 0xe8, 0x2e, 0xfd, 0xff, 0xff, 0x83, 0xe0, 0x1f, 0xc1, 0xff, 0xa, 0x89, 0x44, 0x24, 0x8, 0x89, 0xf8, 0xf, 0xaf, 0xc2, 0x8b, 0x6c, 0x24, 0x8, 0xf, 0xaf, 0xea, 0x81, 0xe6, 0xe0, 0x3, 0, 0, 0xc1, 0xf8, 0x10, 0xc1, 0xfe, 0x5, 0x89, 0x44, 0x24, 0x4, 0x89, 0xf0, 0xf, 0xaf, 0xc2, 0xc1, 0xfd, 0x10, 0x89, 0x2c, 0x24, 0x8b, 0x6c, 0x24, 0x4, 0xc1, 0xf8, 0x10, 0xc1, 0xe5, 0xa, 0xc1, 0xe0, 0x5, 0x9, 0xe8, 0xb, 0x4, 0x24, 0x8a, 0x80, 0x20, 0x5, 0x20, 0x10, 0xbd, 0x1f, 0, 0, 0, 0x2b, 0x6c, 0x24, 0x8, 0xf, 0xaf, 0xea, 0x25, 0xff, 0, 0, 0, 0xc1, 0xe3, 0x8, 0x88, 0x84, 0x19, 0x20, 0x5, 0x1e, 0x10, 0xb8, 0x1f, 0, 0, 0, 0x29, 0xf8, 0xf, 0xaf, 0xc2, 0xc1, 0xf8, 0x10, 0x89, 0x44, 0x24, 0x4, 0xb8, 0x1f, 0, 0, 0, 0x29, 0xf0, 0xf, 0xaf, 0xc2, 0xc1, 0xfd, 0x10, 0x89, 0x2c, 0x24, 0x8b, 0x6c, 0x24, 0x4, 0xc1, 0xf8, 0x10, 0x1, 0xef, 0x1, 0xf0, 0xc1, 0xe7, 0xa, 0xc1, 0xe0, 0x5, 0x8b, 0x34, 0x24, 0x9, 0xc7, 0x8b, 0x44, 0x24, 0x8, 0x1, 0xf0, 0x9, 0xf8, 0x8a, 0x80, 0x20, 0x5, 0x20, 0x10, 0x25, 0xff, 0, 0, 0, 0x41, 0x81, 0xc2, 0, 0x2, 0, 0, 0x88, 0x84, 0x19, 0x9f, 0x5, 0x1e, 0x10, 0x81, 0xf9, 0x80, 0, 0, 0, 0xf, 0x8c, 0x13, 0xff, 0xff, 0xff, 0x83, 0xc4, 0x10, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1016cd84, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1016cd85, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1016cd86, 0x1)   pushd(edx);                           /* push edx */
    II(0x1016cd87, 0x1)   pushd(esi);                           /* push esi */
    II(0x1016cd88, 0x1)   pushd(edi);                           /* push edi */
    II(0x1016cd89, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1016cd8a, 0x3)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x1016cd8d, 0x4)   mov(memb_a32(ss, esp + 0xc), al);     /* mov [esp+0xc], al */
    II(0x1016cd91, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x1016cd93, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
l_0x1016cd95:
    II(0x1016cd95, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x1016cd97, 0x4)   mov(bl, memb_a32(ss, esp + 0xc));     /* mov bl, [esp+0xc] */
    II(0x1016cd9b, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x1016cd9d, 0x5)   calld(/* sys */ 0x1016cae8, -0x2ba);  /* call 0x1016cae8 */
    II(0x1016cda2, 0x2)   mov(edi, eax);                        /* mov edi, eax */
    II(0x1016cda4, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x1016cda6, 0x5)   calld(/* sys */ 0x1016cae8, -0x2c3);  /* call 0x1016cae8 */
    II(0x1016cdab, 0x2)   mov(esi, eax);                        /* mov esi, eax */
    II(0x1016cdad, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x1016cdaf, 0x6)   and_(edi, 0x7c00);                    /* and edi, 0x7c00 */
    II(0x1016cdb5, 0x5)   calld(/* sys */ 0x1016cae8, -0x2d2);  /* call 0x1016cae8 */
    II(0x1016cdba, 0x3)   and_(eax, 0x1f);                      /* and eax, 0x1f */
    II(0x1016cdbd, 0x3)   sar(edi, 0xa);                        /* sar edi, 0xa */
    II(0x1016cdc0, 0x4)   mov(memd_a32(ss, esp + 0x8), eax);    /* mov [esp+0x8], eax */
    II(0x1016cdc4, 0x2)   mov(eax, edi);                        /* mov eax, edi */
    II(0x1016cdc6, 0x3)   imul(eax, edx);                       /* imul eax, edx */
    II(0x1016cdc9, 0x4)   mov(ebp, memd_a32(ss, esp + 0x8));    /* mov ebp, [esp+0x8] */
    II(0x1016cdcd, 0x3)   imul(ebp, edx);                       /* imul ebp, edx */
    II(0x1016cdd0, 0x6)   and_(esi, 0x3e0);                     /* and esi, 0x3e0 */
    II(0x1016cdd6, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1016cdd9, 0x3)   sar(esi, 0x5);                        /* sar esi, 0x5 */
    II(0x1016cddc, 0x4)   mov(memd_a32(ss, esp + 0x4), eax);    /* mov [esp+0x4], eax */
    II(0x1016cde0, 0x2)   mov(eax, esi);                        /* mov eax, esi */
    II(0x1016cde2, 0x3)   imul(eax, edx);                       /* imul eax, edx */
    II(0x1016cde5, 0x3)   sar(ebp, 0x10);                       /* sar ebp, 0x10 */
    II(0x1016cde8, 0x3)   mov(memd_a32(ss, esp), ebp);          /* mov [esp], ebp */
    II(0x1016cdeb, 0x4)   mov(ebp, memd_a32(ss, esp + 0x4));    /* mov ebp, [esp+0x4] */
    II(0x1016cdef, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1016cdf2, 0x3)   shl(ebp, 0xa);                        /* shl ebp, 0xa */
    II(0x1016cdf5, 0x3)   shl(eax, 0x5);                        /* shl eax, 0x5 */
    II(0x1016cdf8, 0x2)   or_(eax, ebp);                        /* or eax, ebp */
    II(0x1016cdfa, 0x3)   or_(eax, memd_a32(ss, esp));          /* or eax, [esp] */
    II(0x1016cdfd, 0x6)   mov(al, memb_a32(ds, eax + 0x10200520)); /* mov al, [eax+0x10200520] */
    II(0x1016ce03, 0x5)   mov(ebp, 0x1f);                       /* mov ebp, 0x1f */
    II(0x1016ce08, 0x4)   sub(ebp, memd_a32(ss, esp + 0x8));    /* sub ebp, [esp+0x8] */
    II(0x1016ce0c, 0x3)   imul(ebp, edx);                       /* imul ebp, edx */
    II(0x1016ce0f, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x1016ce14, 0x3)   shl(ebx, 0x8);                        /* shl ebx, 0x8 */
    II(0x1016ce17, 0x7)   mov(memb_a32(ds, ecx + ebx + 0x101e0520), al); /* mov [ecx+ebx+0x101e0520], al */
    II(0x1016ce1e, 0x5)   mov(eax, 0x1f);                       /* mov eax, 0x1f */
    II(0x1016ce23, 0x2)   sub(eax, edi);                        /* sub eax, edi */
    II(0x1016ce25, 0x3)   imul(eax, edx);                       /* imul eax, edx */
    II(0x1016ce28, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1016ce2b, 0x4)   mov(memd_a32(ss, esp + 0x4), eax);    /* mov [esp+0x4], eax */
    II(0x1016ce2f, 0x5)   mov(eax, 0x1f);                       /* mov eax, 0x1f */
    II(0x1016ce34, 0x2)   sub(eax, esi);                        /* sub eax, esi */
    II(0x1016ce36, 0x3)   imul(eax, edx);                       /* imul eax, edx */
    II(0x1016ce39, 0x3)   sar(ebp, 0x10);                       /* sar ebp, 0x10 */
    II(0x1016ce3c, 0x3)   mov(memd_a32(ss, esp), ebp);          /* mov [esp], ebp */
    II(0x1016ce3f, 0x4)   mov(ebp, memd_a32(ss, esp + 0x4));    /* mov ebp, [esp+0x4] */
    II(0x1016ce43, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1016ce46, 0x2)   add(edi, ebp);                        /* add edi, ebp */
    II(0x1016ce48, 0x2)   add(eax, esi);                        /* add eax, esi */
    II(0x1016ce4a, 0x3)   shl(edi, 0xa);                        /* shl edi, 0xa */
    II(0x1016ce4d, 0x3)   shl(eax, 0x5);                        /* shl eax, 0x5 */
    II(0x1016ce50, 0x3)   mov(esi, memd_a32(ss, esp));          /* mov esi, [esp] */
    II(0x1016ce53, 0x2)   or_(edi, eax);                        /* or edi, eax */
    II(0x1016ce55, 0x4)   mov(eax, memd_a32(ss, esp + 0x8));    /* mov eax, [esp+0x8] */
    II(0x1016ce59, 0x2)   add(eax, esi);                        /* add eax, esi */
    II(0x1016ce5b, 0x2)   or_(eax, edi);                        /* or eax, edi */
    II(0x1016ce5d, 0x6)   mov(al, memb_a32(ds, eax + 0x10200520)); /* mov al, [eax+0x10200520] */
    II(0x1016ce63, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x1016ce68, 0x1)   inc(ecx);                             /* inc ecx */
    II(0x1016ce69, 0x6)   add(edx, 0x200);                      /* add edx, 0x200 */
    II(0x1016ce6f, 0x7)   mov(memb_a32(ds, ecx + ebx + 0x101e059f), al); /* mov [ecx+ebx+0x101e059f], al */
    II(0x1016ce76, 0x6)   cmp(ecx, 0x80);                       /* cmp ecx, 0x80 */
    II(0x1016ce7c, 0x6)   jld(0x1016cd95, -0xed);               /* jl dword 0x1016cd95 */
    II(0x1016ce82, 0x3)   add(esp, 0x10);                       /* add esp, 0x10 */
    II(0x1016ce85, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1016ce86, 0x1)   popd(edi);                            /* pop edi */
    II(0x1016ce87, 0x1)   popd(esi);                            /* pop esi */
    II(0x1016ce88, 0x1)   popd(edx);                            /* pop edx */
    II(0x1016ce89, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1016ce8a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1016ce8b, 0x1)   retd();                               /* ret */
FUNC_END

