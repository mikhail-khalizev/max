FUNC_BEGIN(0x10124174, 0xe469f136cde1fad5, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xd4, 0x1b, 0x4, 0, 0x53, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x8b, 0x45, 0x18, 0x50, 0x8b, 0x45, 0x14, 0x50, 0xe8, 0xb9, 0xf6, 0xff, 0xff, 0x83, 0xc4, 0x8, 0x85, 0xc0, 0x75, 0x9, 0xc7, 0x45, 0xfc, 0, 0, 0, 0, 0xeb, 0x28, 0x8b, 0x45, 0x20, 0x50, 0x8b, 0x45, 0x1c, 0x50, 0x8b, 0x45, 0x14, 0x50, 0xe8, 0xb4, 0xf9, 0xff, 0xff, 0x83, 0xc4, 0xc, 0x85, 0xc0, 0x75, 0x9, 0xc7, 0x45, 0xfc, 0, 0, 0, 0, 0xeb, 0x7, 0xc7, 0x45, 0xfc, 0x1, 0, 0, 0, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5b, 0xc3}))
    II(0x10124174, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10124179, 0x5)   calld(sys_check_available_stack_size, 0x41bd4); /* call 0x10165d52 */
    II(0x1012417e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1012417f, 0x1)   pushd(esi);                           /* push esi */
    II(0x10124180, 0x1)   pushd(edi);                           /* push edi */
    II(0x10124181, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10124182, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10124184, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1012418a, 0x3)   mov(eax, memd_a32(ss, ebp + 0x18));   /* mov eax, [ebp+0x18] */
    II(0x1012418d, 0x1)   pushd(eax);                           /* push eax */
    II(0x1012418e, 0x3)   mov(eax, memd_a32(ss, ebp + 0x14));   /* mov eax, [ebp+0x14] */
    II(0x10124191, 0x1)   pushd(eax);                           /* push eax */
    II(0x10124192, 0x5)   calld(0x10123850, -0x947);            /* call 0x10123850 */
    II(0x10124197, 0x3)   add(esp, 0x8);                        /* add esp, 0x8 */
    II(0x1012419a, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1012419c, 0x2)   jnzd(0x101241a7, 0x9);                /* jnz 0x101241a7 */
    II(0x1012419e, 0x7)   mov(memd_a32(ss, ebp - 0x4), 0);      /* mov dword [ebp-0x4], 0x0 */
    II(0x101241a5, 0x2)   jmpd(0x101241cf, 0x28);               /* jmp 0x101241cf */
l_0x101241a7:
    II(0x101241a7, 0x3)   mov(eax, memd_a32(ss, ebp + 0x20));   /* mov eax, [ebp+0x20] */
    II(0x101241aa, 0x1)   pushd(eax);                           /* push eax */
    II(0x101241ab, 0x3)   mov(eax, memd_a32(ss, ebp + 0x1c));   /* mov eax, [ebp+0x1c] */
    II(0x101241ae, 0x1)   pushd(eax);                           /* push eax */
    II(0x101241af, 0x3)   mov(eax, memd_a32(ss, ebp + 0x14));   /* mov eax, [ebp+0x14] */
    II(0x101241b2, 0x1)   pushd(eax);                           /* push eax */
    II(0x101241b3, 0x5)   calld(0x10123b6c, -0x64c);            /* call 0x10123b6c */
    II(0x101241b8, 0x3)   add(esp, 0xc);                        /* add esp, 0xc */
    II(0x101241bb, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x101241bd, 0x2)   jnzd(0x101241c8, 0x9);                /* jnz 0x101241c8 */
    II(0x101241bf, 0x7)   mov(memd_a32(ss, ebp - 0x4), 0);      /* mov dword [ebp-0x4], 0x0 */
    II(0x101241c6, 0x2)   jmpd(0x101241cf, 0x7);                /* jmp 0x101241cf */
l_0x101241c8:
    II(0x101241c8, 0x7)   mov(memd_a32(ss, ebp - 0x4), 0x1);    /* mov dword [ebp-0x4], 0x1 */
l_0x101241cf:
    II(0x101241cf, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101241d2, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101241d4, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101241d5, 0x1)   popd(edi);                            /* pop edi */
    II(0x101241d6, 0x1)   popd(esi);                            /* pop esi */
    II(0x101241d7, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101241d8, 0x1)   retd();                               /* ret */
FUNC_END

