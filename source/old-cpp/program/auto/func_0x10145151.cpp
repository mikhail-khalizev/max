FUNC_BEGIN(0x10145151, 0xf286fd4f618fae47, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xf7, 0xb, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xcc, 0xe8, 0x3c, 0x15, 0x2, 0, 0xe8, 0x7, 0xc7, 0x2, 0, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x10, 0xc1, 0xf8, 0x10, 0x50, 0x8b, 0x45, 0xf8, 0x8b, 0x48, 0xe, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0xa, 0xe8, 0x34, 0x46, 0xf4, 0xff, 0x8b, 0x55, 0xfc, 0x8d, 0x75, 0xf4, 0x89, 0xc3, 0x89, 0xf0, 0xe8, 0xb3, 0xfe, 0xff, 0xff, 0xe8, 0x20, 0x46, 0xf4, 0xff, 0xe8, 0x73, 0xbd, 0x3, 0, 0x31, 0xd2, 0x8d, 0x45, 0xf4, 0xe8, 0x73, 0xc9, 0xff, 0xff, 0xb8, 0xa, 0, 0, 0, 0xe8, 0x9e, 0x74, 0x2, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10145151, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x10145156, 0x5)   calld(sys_check_available_stack_size, 0x20bf7); /* call 0x10165d52 */
    II(0x1014515b, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1014515c, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1014515d, 0x1)   pushd(esi);                           /* push esi */
    II(0x1014515e, 0x1)   pushd(edi);                           /* push edi */
    II(0x1014515f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10145160, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10145162, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10145168, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1014516b, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1014516e, 0x1)   int3();                               /* int3 */
    II(0x1014516f, 0x5)   calld(/* sys */ 0x101666b0, 0x2153c); /* call 0x101666b0 */
    II(0x10145174, 0x5)   calld(/* sys */ 0x10171880, 0x2c707); /* call 0x10171880 */
    II(0x10145179, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014517c, 0x3)   mov(eax, memd_a32(ds, eax + 0x10));   /* mov eax, [eax+0x10] */
    II(0x1014517f, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x10145182, 0x1)   pushd(eax);                           /* push eax */
    II(0x10145183, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10145186, 0x3)   mov(ecx, memd_a32(ds, eax + 0xe));    /* mov ecx, [eax+0xe] */
//    II(0x10145189, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014518c, 0x3)   add(eax, 0xa);                        /* add eax, 0xa */
    II(0x1014518f, 0x5)   calld(my_strobj_c_str_v2, -0xbb9cc);  /* call 0x100897c8 */
    II(0x10145194, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x10145197, 0x3)   lea(esi, ebp - 0xc);                  /* lea esi, [ebp-0xc] */
    II(0x1014519a, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x1014519c, 0x2)   mov(eax, esi);                        /* mov eax, esi */
    II(0x1014519e, 0x5)   calld(0x10145056, -0x14d);            /* call 0x10145056 */
    II(0x101451a3, 0x5)   calld(my_strobj_c_str_v2, -0xbb9e0);  /* call 0x100897c8 */
    II(0x101451a8, 0x5)   calld(/* sys */ 0x10180f20, 0x3bd73); /* call 0x10180f20 */
    II(0x101451ad, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x101451af, 0x3)   lea(eax, ebp - 0xc);                  /* lea eax, [ebp-0xc] */
    II(0x101451b2, 0x5)   calld(my_string_dtor, -0x368d);       /* call 0x10141b2a */
    II(0x101451b7, 0x5)   mov(eax, 0xa);                        /* mov eax, 0xa */
    II(0x101451bc, 0x5)   calld(sys_exit, 0x2749e);             /* call 0x1016c65f */
    II(0x101451c1, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101451c3, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101451c4, 0x1)   popd(edi);                            /* pop edi */
    II(0x101451c5, 0x1)   popd(esi);                            /* pop esi */
    II(0x101451c6, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101451c7, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101451c8, 0x1)   retd();                               /* ret */
FUNC_END

