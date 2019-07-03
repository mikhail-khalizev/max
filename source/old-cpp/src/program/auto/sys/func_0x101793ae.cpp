FUNC_BEGIN(/* sys */ 0x101793ae, 0x866ccbed3bfd1550, 0x20, ({0x51, 0x56, 0x57, 0x55, 0x83, 0xec, 0x28, 0x89, 0xd5, 0x89, 0xdf, 0x89, 0xd6, 0x30, 0xd2, 0x8d, 0x4c, 0x24, 0x1, 0x88, 0x14, 0x24, 0x8d, 0x5c, 0x24, 0x24, 0x89, 0x7c, 0x24, 0x24, 0x31, 0xd2, 0xf7, 0x33, 0x89, 0x3, 0x2e, 0x8a, 0x82, 0x89, 0x93, 0x17, 0x10, 0x88, 0x1, 0x8b, 0x44, 0x24, 0x24, 0x41, 0x85, 0xc0, 0x75, 0xe0, 0x49, 0x8a, 0x1, 0x88, 0x6, 0x46, 0x84, 0xc0, 0x75, 0xf6, 0x89, 0xe8, 0x83, 0xc4, 0x28, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x101793ae, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101793af, 0x1)   pushd(esi);                           /* push esi */
    II(0x101793b0, 0x1)   pushd(edi);                           /* push edi */
    II(0x101793b1, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101793b2, 0x3)   sub(esp, 0x28);                       /* sub esp, 0x28 */
    II(0x101793b5, 0x2)   mov(ebp, edx);                        /* mov ebp, edx */
    II(0x101793b7, 0x2)   mov(edi, ebx);                        /* mov edi, ebx */
    II(0x101793b9, 0x2)   mov(esi, edx);                        /* mov esi, edx */
    II(0x101793bb, 0x2)   xor_(dl, dl);                         /* xor dl, dl */
    II(0x101793bd, 0x4)   lea(ecx, esp + 0x1);                  /* lea ecx, [esp+0x1] */
    II(0x101793c1, 0x3)   mov(memb_a32(ss, esp), dl);           /* mov [esp], dl */
l_0x101793c4:
    II(0x101793c4, 0x4)   lea(ebx, esp + 0x24);                 /* lea ebx, [esp+0x24] */
    II(0x101793c8, 0x4)   mov(memd_a32(ss, esp + 0x24), edi);   /* mov [esp+0x24], edi */
    II(0x101793cc, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x101793ce, 0x2)   div(memd_a32(ds, ebx));               /* div dword [ebx] */
    II(0x101793d0, 0x2)   mov(memd_a32(ds, ebx), eax);          /* mov [ebx], eax */
    II(0x101793d2, 0x7)   mov(al, memb_a32(cs, edx + /* sys */ 0x10179389)); /* mov al, [cs:edx+0x10179389] */
    II(0x101793d9, 0x2)   mov(memb_a32(ds, ecx), al);           /* mov [ecx], al */
    II(0x101793db, 0x4)   mov(eax, memd_a32(ss, esp + 0x24));   /* mov eax, [esp+0x24] */
    II(0x101793df, 0x1)   inc(ecx);                             /* inc ecx */
    II(0x101793e0, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x101793e2, 0x2)   jnzd(0x101793c4, -0x20);              /* jnz 0x101793c4 */
l_0x101793e4:
    II(0x101793e4, 0x1)   dec(ecx);                             /* dec ecx */
    II(0x101793e5, 0x2)   mov(al, memb_a32(ds, ecx));           /* mov al, [ecx] */
    II(0x101793e7, 0x2)   mov(memb_a32(ds, esi), al);           /* mov [esi], al */
    II(0x101793e9, 0x1)   inc(esi);                             /* inc esi */
    II(0x101793ea, 0x2)   test(al, al);                         /* test al, al */
    II(0x101793ec, 0x2)   jnzd(0x101793e4, -0xa);               /* jnz 0x101793e4 */
    II(0x101793ee, 0x2)   mov(eax, ebp);                        /* mov eax, ebp */
    II(0x101793f0, 0x3)   add(esp, 0x28);                       /* add esp, 0x28 */
    II(0x101793f3, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101793f4, 0x1)   popd(edi);                            /* pop edi */
    II(0x101793f5, 0x1)   popd(esi);                            /* pop esi */
    II(0x101793f6, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101793f7, 0x1)   retd();                               /* ret */
FUNC_END

