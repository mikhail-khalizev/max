FUNC_BEGIN(0x1015ec1c, 0x8983c10dc9d3005d, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x2c, 0x71, 0, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x66, 0x83, 0x7d, 0xfc, 0x17, 0x74, 0x7, 0x66, 0x83, 0x7d, 0xfc, 0x18, 0x75, 0x2, 0xeb, 0x7, 0x66, 0x83, 0x7d, 0xfc, 0x19, 0x75, 0x2, 0xeb, 0x7, 0x66, 0x83, 0x7d, 0xfc, 0x1b, 0x75, 0x6, 0xc6, 0x45, 0xf8, 0x1, 0xeb, 0x4, 0xc6, 0x45, 0xf8, 0, 0x8a, 0x45, 0xf8, 0x88, 0x45, 0xf4, 0x8a, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1015ec1c, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x1015ec21, 0x5)   calld(sys_check_available_stack_size, 0x712c); /* call 0x10165d52 */
    II(0x1015ec26, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1015ec27, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1015ec28, 0x1)   pushd(edx);                           /* push edx */
    II(0x1015ec29, 0x1)   pushd(esi);                           /* push esi */
    II(0x1015ec2a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1015ec2b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1015ec2c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1015ec2e, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1015ec34, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1015ec37, 0x5)   cmp(memw_a32(ss, ebp - 0x4), 0x17);   /* cmp word [ebp-0x4], 0x17 */
    II(0x1015ec3c, 0x2)   jzd(0x1015ec45, 0x7);                 /* jz 0x1015ec45 */
    II(0x1015ec3e, 0x5)   cmp(memw_a32(ss, ebp - 0x4), 0x18);   /* cmp word [ebp-0x4], 0x18 */
    II(0x1015ec43, 0x2)   jnzd(0x1015ec47, 0x2);                /* jnz 0x1015ec47 */
l_0x1015ec45:
    II(0x1015ec45, 0x2)   jmpd(0x1015ec4e, 0x7);                /* jmp 0x1015ec4e */
l_0x1015ec47:
    II(0x1015ec47, 0x5)   cmp(memw_a32(ss, ebp - 0x4), 0x19);   /* cmp word [ebp-0x4], 0x19 */
    II(0x1015ec4c, 0x2)   jnzd(0x1015ec50, 0x2);                /* jnz 0x1015ec50 */
l_0x1015ec4e:
    II(0x1015ec4e, 0x2)   jmpd(0x1015ec57, 0x7);                /* jmp 0x1015ec57 */
l_0x1015ec50:
    II(0x1015ec50, 0x5)   cmp(memw_a32(ss, ebp - 0x4), 0x1b);   /* cmp word [ebp-0x4], 0x1b */
    II(0x1015ec55, 0x2)   jnzd(0x1015ec5d, 0x6);                /* jnz 0x1015ec5d */
l_0x1015ec57:
    II(0x1015ec57, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x1);    /* mov byte [ebp-0x8], 0x1 */
    II(0x1015ec5b, 0x2)   jmpd(0x1015ec61, 0x4);                /* jmp 0x1015ec61 */
l_0x1015ec5d:
    II(0x1015ec5d, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0);      /* mov byte [ebp-0x8], 0x0 */
l_0x1015ec61:
    II(0x1015ec61, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x1015ec64, 0x3)   mov(memb_a32(ss, ebp - 0xc), al);     /* mov [ebp-0xc], al */
//    II(0x1015ec67, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x1015ec6a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1015ec6c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1015ec6d, 0x1)   popd(edi);                            /* pop edi */
    II(0x1015ec6e, 0x1)   popd(esi);                            /* pop esi */
    II(0x1015ec6f, 0x1)   popd(edx);                            /* pop edx */
    II(0x1015ec70, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1015ec71, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1015ec72, 0x1)   retd();                               /* ret */
FUNC_END

