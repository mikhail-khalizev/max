FUNC_BEGIN(0x10071ec5, 0x615283b69c9dafaa, 0x20, ({0x68, 0x2c, 0, 0, 0, 0xe8, 0x83, 0x3e, 0xf, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0xeb, 0x14, 0xc7, 0x45, 0xf4, 0x6, 0, 0, 0, 0xeb, 0x31, 0xc7, 0x45, 0xf4, 0x2, 0, 0, 0, 0xeb, 0x28, 0xeb, 0x1f, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf0, 0x66, 0x83, 0x7d, 0xf0, 0x1, 0x72, 0x10, 0x66, 0x83, 0x7d, 0xf0, 0x1, 0x76, 0xd8, 0x66, 0x83, 0x7d, 0xf0, 0x2, 0x74, 0xda, 0xeb, 0xe1, 0xeb, 0xdf, 0xc7, 0x45, 0xf4, 0, 0, 0, 0, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10071ec5, 0x5)   pushd(0x2c);                          /* push dword 0x2c */
    II(0x10071eca, 0x5)   calld(sys_check_available_stack_size, 0xf3e83); /* call 0x10165d52 */
    II(0x10071ecf, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10071ed0, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10071ed1, 0x1)   pushd(edx);                           /* push edx */
    II(0x10071ed2, 0x1)   pushd(esi);                           /* push esi */
    II(0x10071ed3, 0x1)   pushd(edi);                           /* push edi */
    II(0x10071ed4, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10071ed5, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10071ed7, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x10071edd, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10071ee0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10071ee3, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10071ee6, 0x2)   jmpd(0x10071efc, 0x14);               /* jmp 0x10071efc */
l_0x10071ee8:
    II(0x10071ee8, 0x7)   mov(memd_a32(ss, ebp - 0xc), 0x6);    /* mov dword [ebp-0xc], 0x6 */
    II(0x10071eef, 0x2)   jmpd(0x10071f22, 0x31);               /* jmp 0x10071f22 */
l_0x10071ef1:
    II(0x10071ef1, 0x7)   mov(memd_a32(ss, ebp - 0xc), 0x2);    /* mov dword [ebp-0xc], 0x2 */
    II(0x10071ef8, 0x2)   jmpd(0x10071f22, 0x28);               /* jmp 0x10071f22 */
l_0x10071efa:
    II(0x10071efa, 0x2)   jmpd(0x10071f1b, 0x1f);               /* jmp 0x10071f1b */
l_0x10071efc:
    II(0x10071efc, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10071eff, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x10071f02, 0x5)   cmp(memw_a32(ss, ebp - 0x10), 0x1);   /* cmp word [ebp-0x10], 0x1 */
    II(0x10071f07, 0x2)   jbd(0x10071f19, 0x10);                /* jb 0x10071f19 */
    II(0x10071f09, 0x5)   cmp(memw_a32(ss, ebp - 0x10), 0x1);   /* cmp word [ebp-0x10], 0x1 */
    II(0x10071f0e, 0x2)   jbed(0x10071ee8, -0x28);              /* jbe 0x10071ee8 */
    II(0x10071f10, 0x5)   cmp(memw_a32(ss, ebp - 0x10), 0x2);   /* cmp word [ebp-0x10], 0x2 */
    II(0x10071f15, 0x2)   jzd(0x10071ef1, -0x26);               /* jz 0x10071ef1 */
    II(0x10071f17, 0x2)   jmpd(0x10071efa, -0x1f);              /* jmp 0x10071efa */
l_0x10071f19:
    II(0x10071f19, 0x2)   jmpd(0x10071efa, -0x21);              /* jmp 0x10071efa */
l_0x10071f1b:
    II(0x10071f1b, 0x7)   mov(memd_a32(ss, ebp - 0xc), 0);      /* mov dword [ebp-0xc], 0x0 */
l_0x10071f22:
    II(0x10071f22, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10071f25, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10071f27, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10071f28, 0x1)   popd(edi);                            /* pop edi */
    II(0x10071f29, 0x1)   popd(esi);                            /* pop esi */
    II(0x10071f2a, 0x1)   popd(edx);                            /* pop edx */
    II(0x10071f2b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10071f2c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10071f2d, 0x1)   retd();                               /* ret */
FUNC_END

