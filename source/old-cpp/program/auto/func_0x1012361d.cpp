FUNC_BEGIN(0x1012361d, 0xe01c3ab2c274443b, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x2b, 0x27, 0x4, 0, 0x53, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x8b, 0x45, 0x14, 0x83, 0xb8, 0x84, 0, 0, 0, 0, 0x75, 0x9, 0xc7, 0x45, 0xf8, 0x1, 0, 0, 0, 0xeb, 0x5a, 0x8b, 0x45, 0x14, 0xf6, 0x40, 0x1, 0x80, 0x74, 0x4a, 0x6a, 0, 0x68, 0x62, 0x2, 0, 0, 0x8b, 0x45, 0x14, 0x83, 0xc0, 0x4, 0x50, 0xe8, 0xc1, 0x98, 0x5, 0, 0x83, 0xc4, 0xc, 0x89, 0x45, 0xfc, 0x83, 0x7d, 0xfc, 0xff, 0x75, 0x9, 0xc7, 0x45, 0xf8, 0, 0, 0, 0, 0xeb, 0x29, 0x8b, 0x45, 0x14, 0x8b, 0x98, 0x88, 0, 0, 0, 0x8b, 0x45, 0x14, 0x8b, 0x90, 0x84, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xe8, 0x62, 0x9c, 0x5, 0, 0x8b, 0x45, 0xfc, 0xe8, 0x3f, 0x9b, 0x5, 0, 0xc7, 0x45, 0xf8, 0x1, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5b, 0xc3}))
    II(0x1012361d, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x10123622, 0x5)   calld(sys_check_available_stack_size, 0x4272b); /* call 0x10165d52 */
    II(0x10123627, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10123628, 0x1)   pushd(esi);                           /* push esi */
    II(0x10123629, 0x1)   pushd(edi);                           /* push edi */
    II(0x1012362a, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1012362b, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1012362d, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10123633, 0x3)   mov(eax, memd_a32(ss, ebp + 0x14));   /* mov eax, [ebp+0x14] */
    II(0x10123636, 0x7)   cmp(memd_a32(ds, eax + 0x84), 0);     /* cmp dword [eax+0x84], 0x0 */
    II(0x1012363d, 0x2)   jnzd(0x10123648, 0x9);                /* jnz 0x10123648 */
    II(0x1012363f, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0x1);    /* mov dword [ebp-0x8], 0x1 */
    II(0x10123646, 0x2)   jmpd(0x101236a2, 0x5a);               /* jmp 0x101236a2 */
l_0x10123648:
    II(0x10123648, 0x3)   mov(eax, memd_a32(ss, ebp + 0x14));   /* mov eax, [ebp+0x14] */
    II(0x1012364b, 0x4)   test(memb_a32(ds, eax + 0x1), 0x80);  /* test byte [eax+0x1], 0x80 */
    II(0x1012364f, 0x2)   jzd(0x1012369b, 0x4a);                /* jz 0x1012369b */
    II(0x10123651, 0x2)   pushd(0);                             /* push 0x0 */
    II(0x10123653, 0x5)   pushd(0x262);                         /* push dword 0x262 */
    II(0x10123658, 0x3)   mov(eax, memd_a32(ss, ebp + 0x14));   /* mov eax, [ebp+0x14] */
    II(0x1012365b, 0x3)   add(eax, 0x4);                        /* add eax, 0x4 */
    II(0x1012365e, 0x1)   pushd(eax);                           /* push eax */
    II(0x1012365f, 0x5)   calld(/* sys */ 0x1017cf25, 0x598c1); /* call 0x1017cf25 */
    II(0x10123664, 0x3)   add(esp, 0xc);                        /* add esp, 0xc */
    II(0x10123667, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1012366a, 0x4)   cmp(memd_a32(ss, ebp - 0x4), -0x1 /* 0xff */); /* cmp dword [ebp-0x4], 0xff */
    II(0x1012366e, 0x2)   jnzd(0x10123679, 0x9);                /* jnz 0x10123679 */
    II(0x10123670, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0);      /* mov dword [ebp-0x8], 0x0 */
    II(0x10123677, 0x2)   jmpd(0x101236a2, 0x29);               /* jmp 0x101236a2 */
l_0x10123679:
    II(0x10123679, 0x3)   mov(eax, memd_a32(ss, ebp + 0x14));   /* mov eax, [ebp+0x14] */
    II(0x1012367c, 0x6)   mov(ebx, memd_a32(ds, eax + 0x88));   /* mov ebx, [eax+0x88] */
//    II(0x10123682, 0x3)   mov(eax, memd_a32(ss, ebp + 0x14));   /* mov eax, [ebp+0x14] */
    II(0x10123685, 0x6)   mov(edx, memd_a32(ds, eax + 0x84));   /* mov edx, [eax+0x84] */
    II(0x1012368b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1012368e, 0x5)   calld(/* sys */ 0x1017d2f5, 0x59c62); /* call 0x1017d2f5 */
    II(0x10123693, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10123696, 0x5)   calld(/* sys */ 0x1017d1da, 0x59b3f); /* call 0x1017d1da */
l_0x1012369b:
    II(0x1012369b, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0x1);    /* mov dword [ebp-0x8], 0x1 */
l_0x101236a2:
    II(0x101236a2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101236a5, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101236a7, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101236a8, 0x1)   popd(edi);                            /* pop edi */
    II(0x101236a9, 0x1)   popd(esi);                            /* pop esi */
    II(0x101236aa, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101236ab, 0x1)   retd();                               /* ret */
FUNC_END

