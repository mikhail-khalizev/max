FUNC_BEGIN(/* sys */ 0x10195bc1, 0x86be286d5df1ff42, 0x20, ({0x51, 0x56, 0x57, 0x55, 0x83, 0xec, 0x28, 0x89, 0xd5, 0x89, 0xdf, 0x89, 0xd6, 0x30, 0xd2, 0x8d, 0x4c, 0x24, 0x1, 0x88, 0x14, 0x24, 0x8d, 0x5c, 0x24, 0x24, 0x89, 0x7c, 0x24, 0x24, 0x31, 0xd2, 0xf7, 0x33, 0x89, 0x13, 0x8b, 0x54, 0x24, 0x24, 0x2e, 0x8a, 0x92, 0x9c, 0x5b, 0x19, 0x10, 0x88, 0x11, 0x41, 0x85, 0xc0, 0x75, 0xe0, 0x49, 0x8a, 0x1, 0x88, 0x6, 0x46, 0x84, 0xc0, 0x75, 0xf6, 0x89, 0xe8, 0x83, 0xc4, 0x28, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x10195bc1, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10195bc2, 0x1)   pushd(esi);                           /* push esi */
    II(0x10195bc3, 0x1)   pushd(edi);                           /* push edi */
    II(0x10195bc4, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10195bc5, 0x3)   sub(esp, 0x28);                       /* sub esp, 0x28 */
    II(0x10195bc8, 0x2)   mov(ebp, edx);                        /* mov ebp, edx */
    II(0x10195bca, 0x2)   mov(edi, ebx);                        /* mov edi, ebx */
    II(0x10195bcc, 0x2)   mov(esi, edx);                        /* mov esi, edx */
    II(0x10195bce, 0x2)   xor_(dl, dl);                         /* xor dl, dl */
    II(0x10195bd0, 0x4)   lea(ecx, esp + 0x1);                  /* lea ecx, [esp+0x1] */
    II(0x10195bd4, 0x3)   mov(memb_a32(ss, esp), dl);           /* mov [esp], dl */
l_0x10195bd7:
    II(0x10195bd7, 0x4)   lea(ebx, esp + 0x24);                 /* lea ebx, [esp+0x24] */
    II(0x10195bdb, 0x4)   mov(memd_a32(ss, esp + 0x24), edi);   /* mov [esp+0x24], edi */
    II(0x10195bdf, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10195be1, 0x2)   div(memd_a32(ds, ebx));               /* div dword [ebx] */
    II(0x10195be3, 0x2)   mov(memd_a32(ds, ebx), edx);          /* mov [ebx], edx */
    II(0x10195be5, 0x4)   mov(edx, memd_a32(ss, esp + 0x24));   /* mov edx, [esp+0x24] */
    II(0x10195be9, 0x7)   mov(dl, memb_a32(cs, edx + /* sys */ 0x10195b9c)); /* mov dl, [cs:edx+0x10195b9c] */
    II(0x10195bf0, 0x2)   mov(memb_a32(ds, ecx), dl);           /* mov [ecx], dl */
    II(0x10195bf2, 0x1)   inc(ecx);                             /* inc ecx */
    II(0x10195bf3, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10195bf5, 0x2)   jnzd(0x10195bd7, -0x20);              /* jnz 0x10195bd7 */
l_0x10195bf7:
    II(0x10195bf7, 0x1)   dec(ecx);                             /* dec ecx */
    II(0x10195bf8, 0x2)   mov(al, memb_a32(ds, ecx));           /* mov al, [ecx] */
    II(0x10195bfa, 0x2)   mov(memb_a32(ds, esi), al);           /* mov [esi], al */
    II(0x10195bfc, 0x1)   inc(esi);                             /* inc esi */
    II(0x10195bfd, 0x2)   test(al, al);                         /* test al, al */
    II(0x10195bff, 0x2)   jnzd(0x10195bf7, -0xa);               /* jnz 0x10195bf7 */
    II(0x10195c01, 0x2)   mov(eax, ebp);                        /* mov eax, ebp */
    II(0x10195c03, 0x3)   add(esp, 0x28);                       /* add esp, 0x28 */
    II(0x10195c06, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10195c07, 0x1)   popd(edi);                            /* pop edi */
    II(0x10195c08, 0x1)   popd(esi);                            /* pop esi */
    II(0x10195c09, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10195c0a, 0x1)   retd();                               /* ret */
FUNC_END

