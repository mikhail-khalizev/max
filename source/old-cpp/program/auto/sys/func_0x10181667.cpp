FUNC_BEGIN(/* sys */ 0x10181667, 0x56b7f9ebeaba7096, 0x20, ({0x51, 0x56, 0x57, 0x55, 0x83, 0xec, 0x4, 0x89, 0xd5, 0x89, 0x1c, 0x24, 0xbb, 0x10, 0, 0, 0, 0x89, 0xef, 0xe8, 0x79, 0x7d, 0xff, 0xff, 0x6, 0x8c, 0xd8, 0x8e, 0xc0, 0x29, 0xc9, 0x49, 0x31, 0xc0, 0xf2, 0xae, 0xf7, 0xd1, 0x49, 0x7, 0x8b, 0x4, 0x24, 0x89, 0xee, 0x48, 0x8d, 0x14, 0x29, 0x8d, 0x1c, 0x28, 0xeb, 0x7, 0x4a, 0x8a, 0xa, 0x48, 0x88, 0xb, 0x4b, 0x39, 0xf2, 0x75, 0xf5, 0x8d, 0x14, 0x28, 0x85, 0xc0, 0x7c, 0x7, 0x48, 0xc6, 0x2, 0x30, 0x4a, 0xeb, 0xf5, 0x3, 0x2c, 0x24, 0xc6, 0x45, 0, 0, 0x83, 0xc4, 0x4, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x10181667, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10181668, 0x1)   pushd(esi);                           /* push esi */
    II(0x10181669, 0x1)   pushd(edi);                           /* push edi */
    II(0x1018166a, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1018166b, 0x3)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1018166e, 0x2)   mov(ebp, edx);                        /* mov ebp, edx */
    II(0x10181670, 0x3)   mov(memd_a32(ss, esp), ebx);          /* mov [esp], ebx */
    II(0x10181673, 0x5)   mov(ebx, 0x10);                       /* mov ebx, 0x10 */
    II(0x10181678, 0x2)   mov(edi, ebp);                        /* mov edi, ebp */
    II(0x1018167a, 0x5)   calld(/* sys */ 0x101793f8, -0x8287); /* call 0x101793f8 */
    II(0x1018167f, 0x1)   pushd(es);                            /* push es */
    II(0x10181680, 0x2)   mov(eax, ds);                         /* mov eax, ds */
    II(0x10181682, 0x2)   mov(es, eax);                         /* mov es, eax */
    II(0x10181684, 0x2)   sub(ecx, ecx);                        /* sub ecx, ecx */
    II(0x10181686, 0x1)   dec(ecx);                             /* dec ecx */
    II(0x10181687, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10181689, 0x2)   repne_a32 scasb_a32();                /* repne scasb */
    II(0x1018168b, 0x2)   not_(ecx);                            /* not ecx */
    II(0x1018168d, 0x1)   dec(ecx);                             /* dec ecx */
    II(0x1018168e, 0x1)   popd(es);                             /* pop es */
    II(0x1018168f, 0x3)   mov(eax, memd_a32(ss, esp));          /* mov eax, [esp] */
    II(0x10181692, 0x2)   mov(esi, ebp);                        /* mov esi, ebp */
    II(0x10181694, 0x1)   dec(eax);                             /* dec eax */
    II(0x10181695, 0x3)   lea(edx, ecx + ebp);                  /* lea edx, [ecx+ebp] */
    II(0x10181698, 0x3)   lea(ebx, eax + ebp);                  /* lea ebx, [eax+ebp] */
    II(0x1018169b, 0x2)   jmpd(0x101816a4, 0x7);                /* jmp 0x101816a4 */
l_0x1018169d:
    II(0x1018169d, 0x1)   dec(edx);                             /* dec edx */
    II(0x1018169e, 0x2)   mov(cl, memb_a32(ds, edx));           /* mov cl, [edx] */
    II(0x101816a0, 0x1)   dec(eax);                             /* dec eax */
    II(0x101816a1, 0x2)   mov(memb_a32(ds, ebx), cl);           /* mov [ebx], cl */
    II(0x101816a3, 0x1)   dec(ebx);                             /* dec ebx */
l_0x101816a4:
    II(0x101816a4, 0x2)   cmp(edx, esi);                        /* cmp edx, esi */
    II(0x101816a6, 0x2)   jnzd(0x1018169d, -0xb);               /* jnz 0x1018169d */
    II(0x101816a8, 0x3)   lea(edx, eax + ebp);                  /* lea edx, [eax+ebp] */
l_0x101816ab:
    II(0x101816ab, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x101816ad, 0x2)   jld(0x101816b6, 0x7);                 /* jl 0x101816b6 */
    II(0x101816af, 0x1)   dec(eax);                             /* dec eax */
    II(0x101816b0, 0x3)   mov(memb_a32(ds, edx), 0x30);         /* mov byte [edx], 0x30 */
    II(0x101816b3, 0x1)   dec(edx);                             /* dec edx */
    II(0x101816b4, 0x2)   jmpd(0x101816ab, -0xb);               /* jmp 0x101816ab */
l_0x101816b6:
    II(0x101816b6, 0x3)   add(ebp, memd_a32(ss, esp));          /* add ebp, [esp] */
    II(0x101816b9, 0x4)   mov(memb_a32(ss, ebp + 0), 0);        /* mov byte [ebp+0x0], 0x0 */
    II(0x101816bd, 0x3)   add(esp, 0x4);                        /* add esp, 0x4 */
    II(0x101816c0, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101816c1, 0x1)   popd(edi);                            /* pop edi */
    II(0x101816c2, 0x1)   popd(esi);                            /* pop esi */
    II(0x101816c3, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101816c4, 0x1)   retd();                               /* ret */
FUNC_END

