FUNC_BEGIN(/* sys */ 0x10179970, 0xce4056111d0665a3, 0x20, ({0x55, 0x89, 0xe5, 0x53, 0x51, 0x52, 0x56, 0x89, 0xc3, 0xb8, 0x60, 0x9c, 0x20, 0x10, 0x89, 0xda, 0xe8, 0x4b, 0xfc, 0xff, 0xff, 0x89, 0xc6, 0x85, 0xc0, 0x74, 0x18, 0x53, 0x50, 0x8b, 0x15, 0xb0, 0x9d, 0x20, 0x10, 0x52, 0xff, 0x15, 0xb8, 0x9d, 0x20, 0x10, 0x83, 0xc4, 0xc, 0x85, 0xc0, 0x75, 0x2, 0x31, 0xf6, 0x89, 0xf0, 0x8d, 0x65, 0xf0, 0x5e, 0x5a, 0x59, 0x5b, 0x5d, 0xc3}))
    II(0x10179970, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10179971, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10179973, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10179974, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10179975, 0x1)   pushd(edx);                           /* push edx */
    II(0x10179976, 0x1)   pushd(esi);                           /* push esi */
    II(0x10179977, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x10179979, 0x5)   mov(eax, 0x10209c60);                 /* mov eax, 0x10209c60 */
    II(0x1017997e, 0x2)   mov(edx, ebx);                        /* mov edx, ebx */
    II(0x10179980, 0x5)   calld(/* sys */ 0x101795d0, -0x3b5);  /* call 0x101795d0 */
    II(0x10179985, 0x2)   mov(esi, eax);                        /* mov esi, eax */
    II(0x10179987, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10179989, 0x2)   jzd(0x101799a3, 0x18);                /* jz 0x101799a3 */
    II(0x1017998b, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1017998c, 0x1)   pushd(eax);                           /* push eax */
    II(0x1017998d, 0x6)   mov(edx, memd_a32(ds, 0x10209db0));   /* mov edx, [0x10209db0] */
    II(0x10179993, 0x1)   pushd(edx);                           /* push edx */
    II(0x10179994, 0x6)   calld_abs(memd_a32(ds, 0x10209db8));  /* call dword near [0x10209db8] */
    II(0x1017999a, 0x3)   add(esp, 0xc);                        /* add esp, 0xc */
    II(0x1017999d, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1017999f, 0x2)   jnzd(0x101799a3, 0x2);                /* jnz 0x101799a3 */
    II(0x101799a1, 0x2)   xor_(esi, esi);                       /* xor esi, esi */
l_0x101799a3:
    II(0x101799a3, 0x2)   mov(eax, esi);                        /* mov eax, esi */
    II(0x101799a5, 0x3)   lea(esp, ebp - 0x10);                 /* lea esp, [ebp-0x10] */
    II(0x101799a8, 0x1)   popd(esi);                            /* pop esi */
    II(0x101799a9, 0x1)   popd(edx);                            /* pop edx */
    II(0x101799aa, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101799ab, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101799ac, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101799ad, 0x1)   retd();                               /* ret */
FUNC_END

