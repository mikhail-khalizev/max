FUNC_BEGIN(0x10082d5c, 0x7bd752c5cce45019, 0x20, ({0x68, 0x30, 0, 0, 0, 0xe8, 0xec, 0x2f, 0xe, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x18, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x83, 0x7d, 0xf8, 0, 0x74, 0xf, 0x8b, 0x45, 0xf8, 0x8a, 0x40, 0x54, 0x25, 0xff, 0, 0, 0, 0x85, 0xc0, 0x75, 0x6, 0xc6, 0x45, 0xf4, 0, 0xeb, 0x43, 0x8b, 0x45, 0xf8, 0xe8, 0xd, 0xfd, 0xc, 0, 0x83, 0xe8, 0x3, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xf0, 0xf, 0xaf, 0x45, 0xf0, 0x89, 0x45, 0xf0, 0x8b, 0x55, 0xfc, 0x8d, 0x45, 0xec, 0xe8, 0xad, 0x30, 0xff, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xf8, 0xe8, 0xe0, 0xde, 0xfe, 0xff, 0x66, 0x3b, 0x45, 0xf0, 0x7f, 0x6, 0xc6, 0x45, 0xe8, 0x1, 0xeb, 0x4, 0xc6, 0x45, 0xe8, 0, 0x8a, 0x45, 0xe8, 0x88, 0x45, 0xf4, 0x8a, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10082d5c, 0x5)   pushd(0x30);                          /* push dword 0x30 */
    II(0x10082d61, 0x5)   calld(sys_check_available_stack_size, 0xe2fec); /* call 0x10165d52 */
    II(0x10082d66, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10082d67, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10082d68, 0x1)   pushd(esi);                           /* push esi */
    II(0x10082d69, 0x1)   pushd(edi);                           /* push edi */
    II(0x10082d6a, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10082d6b, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10082d6d, 0x6)   sub(esp, 0x18);                       /* sub esp, 0x18 */
    II(0x10082d73, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10082d76, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x10082d79, 0x4)   cmp(memd_a32(ss, ebp - 0x8), 0);      /* cmp dword [ebp-0x8], 0x0 */
    II(0x10082d7d, 0x2)   jzd(0x10082d8e, 0xf);                 /* jz 0x10082d8e */
    II(0x10082d7f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10082d82, 0x3)   mov(al, memb_a32(ds, eax + 0x54));    /* mov al, [eax+0x54] */
    II(0x10082d85, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x10082d8a, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10082d8c, 0x2)   jnzd(0x10082d94, 0x6);                /* jnz 0x10082d94 */
l_0x10082d8e:
    II(0x10082d8e, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0);      /* mov byte [ebp-0xc], 0x0 */
    II(0x10082d92, 0x2)   jmpd(0x10082dd7, 0x43);               /* jmp 0x10082dd7 */
l_0x10082d94:
    II(0x10082d94, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10082d97, 0x5)   calld(0x10152aa9, 0xcfd0d);           /* call 0x10152aa9 */
    II(0x10082d9c, 0x3)   sub(eax, 0x3);                        /* sub eax, 0x3 */
    II(0x10082d9f, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
//    II(0x10082da2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10082da5, 0x4)   imul(eax, memd_a32(ss, ebp - 0x10));  /* imul eax, [ebp-0x10] */
    II(0x10082da9, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x10082dac, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x10082daf, 0x3)   lea(eax, ebp - 0x14);                 /* lea eax, [ebp-0x14] */
    II(0x10082db2, 0x5)   calld(0x10075e64, -0xcf53);           /* call 0x10075e64 */
    II(0x10082db7, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10082db9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10082dbc, 0x5)   calld(0x10070ca1, -0x12120);          /* call 0x10070ca1 */
    II(0x10082dc1, 0x4)   cmp(ax, memw_a32(ss, ebp - 0x10));    /* cmp ax, [ebp-0x10] */
    II(0x10082dc5, 0x2)   jgd(0x10082dcd, 0x6);                 /* jg 0x10082dcd */
    II(0x10082dc7, 0x4)   mov(memb_a32(ss, ebp - 0x18), 0x1);   /* mov byte [ebp-0x18], 0x1 */
    II(0x10082dcb, 0x2)   jmpd(0x10082dd1, 0x4);                /* jmp 0x10082dd1 */
l_0x10082dcd:
    II(0x10082dcd, 0x4)   mov(memb_a32(ss, ebp - 0x18), 0);     /* mov byte [ebp-0x18], 0x0 */
l_0x10082dd1:
    II(0x10082dd1, 0x3)   mov(al, memb_a32(ss, ebp - 0x18));    /* mov al, [ebp-0x18] */
    II(0x10082dd4, 0x3)   mov(memb_a32(ss, ebp - 0xc), al);     /* mov [ebp-0xc], al */
l_0x10082dd7:
    II(0x10082dd7, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x10082dda, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10082ddc, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10082ddd, 0x1)   popd(edi);                            /* pop edi */
    II(0x10082dde, 0x1)   popd(esi);                            /* pop esi */
    II(0x10082ddf, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10082de0, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10082de1, 0x1)   retd();                               /* ret */
FUNC_END

