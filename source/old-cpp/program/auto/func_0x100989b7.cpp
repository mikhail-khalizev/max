FUNC_BEGIN(0x100989b7, 0xe72b8de4e8633d8, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x91, 0xd3, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x1a, 0xc1, 0xf8, 0x18, 0x83, 0xf8, 0x3, 0x7c, 0x6, 0xc6, 0x45, 0xf8, 0x1, 0xeb, 0x4, 0xc6, 0x45, 0xf8, 0, 0x8a, 0x45, 0xf8, 0x88, 0x45, 0xf4, 0x8a, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100989b7, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x100989bc, 0x5)   calld(sys_check_available_stack_size, 0xcd391); /* call 0x10165d52 */
    II(0x100989c1, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100989c2, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100989c3, 0x1)   pushd(edx);                           /* push edx */
    II(0x100989c4, 0x1)   pushd(esi);                           /* push esi */
    II(0x100989c5, 0x1)   pushd(edi);                           /* push edi */
    II(0x100989c6, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100989c7, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100989c9, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100989cf, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100989d2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100989d5, 0x3)   mov(eax, memd_a32(ds, eax + 0x1a));   /* mov eax, [eax+0x1a] */
    II(0x100989d8, 0x3)   sar(eax, 0x18);                       /* sar eax, 0x18 */
    II(0x100989db, 0x3)   cmp(eax, 0x3);                        /* cmp eax, 0x3 */
    II(0x100989de, 0x2)   jld(0x100989e6, 0x6);                 /* jl 0x100989e6 */
    II(0x100989e0, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x1);    /* mov byte [ebp-0x8], 0x1 */
    II(0x100989e4, 0x2)   jmpd(0x100989ea, 0x4);                /* jmp 0x100989ea */
l_0x100989e6:
    II(0x100989e6, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0);      /* mov byte [ebp-0x8], 0x0 */
l_0x100989ea:
    II(0x100989ea, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x100989ed, 0x3)   mov(memb_a32(ss, ebp - 0xc), al);     /* mov [ebp-0xc], al */
//    II(0x100989f0, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x100989f3, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100989f5, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100989f6, 0x1)   popd(edi);                            /* pop edi */
    II(0x100989f7, 0x1)   popd(esi);                            /* pop esi */
    II(0x100989f8, 0x1)   popd(edx);                            /* pop edx */
    II(0x100989f9, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100989fa, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100989fb, 0x1)   retd();                               /* ret */
FUNC_END

