FUNC_BEGIN(0x10116aa4, 0x2656cb9dec9741f0, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xa4, 0xf2, 0x4, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xc6, 0x40, 0x31, 0, 0x8b, 0x45, 0xfc, 0x80, 0x78, 0x31, 0, 0x75, 0x2e, 0xe8, 0x34, 0x47, 0x5, 0, 0x89, 0x45, 0xf8, 0x83, 0x3d, 0x24, 0x56, 0x1c, 0x10, 0, 0x74, 0x10, 0xe8, 0x74, 0x1b, 0x1, 0, 0x85, 0xc0, 0x74, 0x7, 0xc7, 0x45, 0xf8, 0x1b, 0, 0, 0, 0x8b, 0x55, 0xf8, 0x8b, 0x45, 0xfc, 0xe8, 0x42, 0xfd, 0xff, 0xff, 0xeb, 0xc9, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10116aa4, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10116aa9, 0x5)   calld(sys_check_available_stack_size, 0x4f2a4); /* call 0x10165d52 */
    II(0x10116aae, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10116aaf, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10116ab0, 0x1)   pushd(edx);                           /* push edx */
    II(0x10116ab1, 0x1)   pushd(esi);                           /* push esi */
    II(0x10116ab2, 0x1)   pushd(edi);                           /* push edi */
    II(0x10116ab3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10116ab4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10116ab6, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10116abc, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10116abf, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10116ac2, 0x4)   mov(memb_a32(ds, eax + 0x31), 0);     /* mov byte [eax+0x31], 0x0 */
l_0x10116ac6:
    II(0x10116ac6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10116ac9, 0x4)   cmp(memb_a32(ds, eax + 0x31), 0);     /* cmp byte [eax+0x31], 0x0 */
    II(0x10116acd, 0x2)   jnzd(0x10116afd, 0x2e);               /* jnz 0x10116afd */
    II(0x10116acf, 0x5)   calld(/* sys */ 0x1016b208, 0x54734); /* call 0x1016b208 */
    II(0x10116ad4, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10116ad7, 0x7)   cmp(memd_a32(ds, 0x101c5624), 0);     /* cmp dword [0x101c5624], 0x0 */
    II(0x10116ade, 0x2)   jzd(0x10116af0, 0x10);                /* jz 0x10116af0 */
    II(0x10116ae0, 0x5)   calld(0x10128659, 0x11b74);           /* call 0x10128659 */
    II(0x10116ae5, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10116ae7, 0x2)   jzd(0x10116af0, 0x7);                 /* jz 0x10116af0 */
    II(0x10116ae9, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0x1b);   /* mov dword [ebp-0x8], 0x1b */
l_0x10116af0:
    II(0x10116af0, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x10116af3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10116af6, 0x5)   calld(0x1011683d, -0x2be);            /* call 0x1011683d */
    II(0x10116afb, 0x2)   jmpd(0x10116ac6, -0x37);              /* jmp 0x10116ac6 */
l_0x10116afd:
    II(0x10116afd, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10116aff, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10116b00, 0x1)   popd(edi);                            /* pop edi */
    II(0x10116b01, 0x1)   popd(esi);                            /* pop esi */
    II(0x10116b02, 0x1)   popd(edx);                            /* pop edx */
    II(0x10116b03, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10116b04, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10116b05, 0x1)   retd();                               /* ret */
FUNC_END

