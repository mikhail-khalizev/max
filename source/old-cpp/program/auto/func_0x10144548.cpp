FUNC_BEGIN(0x10144548, 0x8dddbd5b2dcbfa00, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0, 0x18, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x3a, 0xe8, 0x4e, 0xb6, 0xf8, 0xff, 0x8b, 0x45, 0xfc, 0x8b, 0x55, 0xf8, 0x66, 0x1, 0x82, 0x54, 0x1, 0, 0, 0x8b, 0x45, 0xfc, 0x8b, 0x55, 0xf8, 0x66, 0x29, 0x82, 0x5c, 0x1, 0, 0, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x4e, 0xe8, 0xef, 0x22, 0xf3, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xfc, 0x66, 0x1, 0x42, 0x8, 0x8b, 0x45, 0xf8, 0xe8, 0xae, 0xf7, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10144548, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1014454d, 0x5)   calld(sys_check_available_stack_size, 0x21800); /* call 0x10165d52 */
    II(0x10144552, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10144553, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10144554, 0x1)   pushd(esi);                           /* push esi */
    II(0x10144555, 0x1)   pushd(edi);                           /* push edi */
    II(0x10144556, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10144557, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10144559, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1014455f, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10144562, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10144565, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10144568, 0x3)   mov(eax, memd_a32(ds, eax + 0x3a));   /* mov eax, [eax+0x3a] */
    II(0x1014456b, 0x5)   calld(0x100cfbbe, -0x749b2);          /* call 0x100cfbbe */
    II(0x10144570, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10144573, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x10144576, 0x7)   add(memw_a32(ds, edx + 0x154), ax);   /* add [edx+0x154], ax */
    II(0x1014457d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10144580, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x10144583, 0x7)   sub(memw_a32(ds, edx + 0x15c), ax);   /* sub [edx+0x15c], ax */
    II(0x1014458a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014458d, 0x3)   add(eax, 0x4e);                       /* add eax, 0x4e */
    II(0x10144590, 0x5)   calld(0x10076884, -0xcdd11);          /* call 0x10076884 */
    II(0x10144595, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10144597, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014459a, 0x4)   add(memw_a32(ds, edx + 0x8), ax);     /* add [edx+0x8], ax */
    II(0x1014459e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101445a1, 0x5)   calld(0x10143d54, -0x852);            /* call 0x10143d54 */
    II(0x101445a6, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101445a8, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101445a9, 0x1)   popd(edi);                            /* pop edi */
    II(0x101445aa, 0x1)   popd(esi);                            /* pop esi */
    II(0x101445ab, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101445ac, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101445ad, 0x1)   retd();                               /* ret */
FUNC_END

