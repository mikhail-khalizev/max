FUNC_BEGIN(0x10145b05, 0xd00988719353874c, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x43, 0x2, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xf7, 0x45, 0xfc, 0x4, 0, 0, 0, 0x74, 0x14, 0xba, 0xbc, 0x71, 0x1b, 0x10, 0x8b, 0x45, 0xf8, 0xe8, 0x80, 0x4, 0x2, 0, 0xe8, 0x9b, 0x4, 0x2, 0, 0xeb, 0x5d, 0x8b, 0x45, 0xf8, 0xc7, 0x40, 0x2, 0xe4, 0x71, 0x1b, 0x10, 0x8b, 0x45, 0xf8, 0xe8, 0x11, 0x9, 0, 0, 0x84, 0xc0, 0x75, 0xf4, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x1c, 0xe8, 0x2a, 0x1d, 0, 0, 0x83, 0xe8, 0x1c, 0x89, 0x45, 0xf8, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x18, 0xe8, 0x47, 0xa8, 0xf9, 0xff, 0x83, 0xe8, 0x18, 0x89, 0x45, 0xf8, 0xba, 0x1, 0, 0, 0, 0x8b, 0x45, 0xf8, 0xe8, 0x32, 0xf4, 0xff, 0xff, 0x89, 0x45, 0xf8, 0xf7, 0x45, 0xfc, 0x2, 0, 0, 0, 0x74, 0x8, 0x8b, 0x45, 0xf8, 0xe8, 0xc8, 0x3, 0x2, 0, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10145b05, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10145b0a, 0x5)   calld(sys_check_available_stack_size, 0x20243); /* call 0x10165d52 */
    II(0x10145b0f, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10145b10, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10145b11, 0x1)   pushd(esi);                           /* push esi */
    II(0x10145b12, 0x1)   pushd(edi);                           /* push edi */
    II(0x10145b13, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10145b14, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10145b16, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10145b1c, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10145b1f, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x10145b22, 0x7)   test(memd_a32(ss, ebp - 0x4), 0x4);   /* test dword [ebp-0x4], 0x4 */
    II(0x10145b29, 0x2)   jzd(0x10145b3f, 0x14);                /* jz 0x10145b3f */
    II(0x10145b2b, 0x5)   mov(edx, 0x101b71bc);                 /* mov edx, 0x101b71bc */
    II(0x10145b30, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10145b33, 0x5)   calld(sys_call_dtor_arr, 0x20480);    /* call 0x10165fb8 */
    II(0x10145b38, 0x5)   calld(sys_delete_arr, 0x2049b);       /* call 0x10165fd8 */
    II(0x10145b3d, 0x2)   jmpd(0x10145b9c, 0x5d);               /* jmp 0x10145b9c */
l_0x10145b3f:
    II(0x10145b3f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10145b42, 0x7)   mov(memd_a32(ds, eax + 0x2), 0x101b71e4); /* mov dword [eax+0x2], 0x101b71e4 */
l_0x10145b49:
    II(0x10145b49, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10145b4c, 0x5)   calld(0x10146462, 0x911);             /* call 0x10146462 */
    II(0x10145b51, 0x2)   test(al, al);                         /* test al, al */
    II(0x10145b53, 0x2)   jnzd(0x10145b49, -0xc);               /* jnz 0x10145b49 */
    II(0x10145b55, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10145b57, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10145b5a, 0x3)   add(eax, 0x1c);                       /* add eax, 0x1c */
    II(0x10145b5d, 0x5)   calld(0x1014788c, 0x1d2a);            /* call 0x1014788c */
    II(0x10145b62, 0x3)   sub(eax, 0x1c);                       /* sub eax, 0x1c */
    II(0x10145b65, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10145b68, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10145b6a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10145b6d, 0x3)   add(eax, 0x18);                       /* add eax, 0x18 */
    II(0x10145b70, 0x5)   calld(0x100e03bc, -0x657b9);          /* call 0x100e03bc */
    II(0x10145b75, 0x3)   sub(eax, 0x18);                       /* sub eax, 0x18 */
    II(0x10145b78, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10145b7b, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
//    II(0x10145b80, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10145b83, 0x5)   calld(0x10144fba, -0xbce);            /* call 0x10144fba */
    II(0x10145b88, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10145b8b, 0x7)   test(memd_a32(ss, ebp - 0x4), 0x2);   /* test dword [ebp-0x4], 0x2 */
    II(0x10145b92, 0x2)   jzd(0x10145b9c, 0x8);                 /* jz 0x10145b9c */
    II(0x10145b94, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10145b97, 0x5)   calld(sys_delete, 0x203c8);           /* call 0x10165f64 */
l_0x10145b9c:
    II(0x10145b9c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10145b9f, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x10145ba2, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10145ba5, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10145ba7, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10145ba8, 0x1)   popd(edi);                            /* pop edi */
    II(0x10145ba9, 0x1)   popd(esi);                            /* pop esi */
    II(0x10145baa, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10145bab, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10145bac, 0x1)   retd();                               /* ret */
FUNC_END

