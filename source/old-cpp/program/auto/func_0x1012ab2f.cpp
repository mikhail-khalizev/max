FUNC_BEGIN(0x1012ab2f, 0x4fedd6cdaea17cc4, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x19, 0xb2, 0x3, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0xc6, 0x5, 0x1c, 0x5c, 0x1c, 0x10, 0x23, 0xa1, 0xcc, 0x59, 0x1c, 0x10, 0x66, 0x8b, 0x40, 0xc, 0x66, 0xa3, 0x1d, 0x5c, 0x1c, 0x10, 0x66, 0xc7, 0x5, 0x1f, 0x5c, 0x1c, 0x10, 0x23, 0, 0xc7, 0x45, 0xf8, 0x21, 0x5c, 0x1c, 0x10, 0xa1, 0xcc, 0x59, 0x1c, 0x10, 0x66, 0x8b, 0x50, 0x14, 0x8b, 0x45, 0xf8, 0x66, 0x89, 0x10, 0xa1, 0xcc, 0x59, 0x1c, 0x10, 0x31, 0xd2, 0x8a, 0x50, 0x11, 0x8b, 0x45, 0xf8, 0x66, 0x89, 0x50, 0x2, 0xa1, 0xcc, 0x59, 0x1c, 0x10, 0x8a, 0x40, 0xb, 0x25, 0xff, 0, 0, 0, 0x83, 0xf8, 0x2, 0x75, 0x6, 0xc6, 0x45, 0xfc, 0x1, 0xeb, 0x4, 0xc6, 0x45, 0xfc, 0, 0x8a, 0x45, 0xfc, 0x8b, 0x55, 0xf8, 0x88, 0x42, 0x4, 0xa1, 0xcc, 0x59, 0x1c, 0x10, 0x8d, 0x90, 0x1a, 0x2, 0, 0, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x5, 0xe8, 0x7, 0xb3, 0x3, 0, 0xb8, 0x5, 0, 0, 0, 0xe8, 0x17, 0xb0, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1012ab2f, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1012ab34, 0x5)   calld(sys_check_available_stack_size, 0x3b219); /* call 0x10165d52 */
    II(0x1012ab39, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1012ab3a, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1012ab3b, 0x1)   pushd(edx);                           /* push edx */
    II(0x1012ab3c, 0x1)   pushd(esi);                           /* push esi */
    II(0x1012ab3d, 0x1)   pushd(edi);                           /* push edi */
    II(0x1012ab3e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1012ab3f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1012ab41, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1012ab47, 0x7)   mov(memb_a32(ds, 0x101c5c1c), 0x23);  /* mov byte [0x101c5c1c], 0x23 */
    II(0x1012ab4e, 0x5)   mov(eax, memd_a32(ds, 0x101c59cc));   /* mov eax, [0x101c59cc] */
    II(0x1012ab53, 0x4)   mov(ax, memw_a32(ds, eax + 0xc));     /* mov ax, [eax+0xc] */
    II(0x1012ab57, 0x6)   mov(memw_a32(ds, 0x101c5c1d), ax);    /* mov [0x101c5c1d], ax */
    II(0x1012ab5d, 0x9)   mov(memw_a32(ds, 0x101c5c1f), 0x23);  /* mov word [0x101c5c1f], 0x23 */
    II(0x1012ab66, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0x101c5c21); /* mov dword [ebp-0x8], 0x101c5c21 */
    II(0x1012ab6d, 0x5)   mov(eax, memd_a32(ds, 0x101c59cc));   /* mov eax, [0x101c59cc] */
    II(0x1012ab72, 0x4)   mov(dx, memw_a32(ds, eax + 0x14));    /* mov dx, [eax+0x14] */
    II(0x1012ab76, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1012ab79, 0x3)   mov(memw_a32(ds, eax), dx);           /* mov [eax], dx */
    II(0x1012ab7c, 0x5)   mov(eax, memd_a32(ds, 0x101c59cc));   /* mov eax, [0x101c59cc] */
    II(0x1012ab81, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1012ab83, 0x3)   mov(dl, memb_a32(ds, eax + 0x11));    /* mov dl, [eax+0x11] */
    II(0x1012ab86, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1012ab89, 0x4)   mov(memw_a32(ds, eax + 0x2), dx);     /* mov [eax+0x2], dx */
    II(0x1012ab8d, 0x5)   mov(eax, memd_a32(ds, 0x101c59cc));   /* mov eax, [0x101c59cc] */
    II(0x1012ab92, 0x3)   mov(al, memb_a32(ds, eax + 0xb));     /* mov al, [eax+0xb] */
    II(0x1012ab95, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x1012ab9a, 0x3)   cmp(eax, 0x2);                        /* cmp eax, 0x2 */
    II(0x1012ab9d, 0x2)   jnzd(0x1012aba5, 0x6);                /* jnz 0x1012aba5 */
    II(0x1012ab9f, 0x4)   mov(memb_a32(ss, ebp - 0x4), 0x1);    /* mov byte [ebp-0x4], 0x1 */
    II(0x1012aba3, 0x2)   jmpd(0x1012aba9, 0x4);                /* jmp 0x1012aba9 */
l_0x1012aba5:
    II(0x1012aba5, 0x4)   mov(memb_a32(ss, ebp - 0x4), 0);      /* mov byte [ebp-0x4], 0x0 */
l_0x1012aba9:
    II(0x1012aba9, 0x3)   mov(al, memb_a32(ss, ebp - 0x4));     /* mov al, [ebp-0x4] */
    II(0x1012abac, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x1012abaf, 0x3)   mov(memb_a32(ds, edx + 0x4), al);     /* mov [edx+0x4], al */
    II(0x1012abb2, 0x5)   mov(eax, memd_a32(ds, 0x101c59cc));   /* mov eax, [0x101c59cc] */
    II(0x1012abb7, 0x6)   lea(edx, eax + 0x21a);                /* lea edx, [eax+0x21a] */
    II(0x1012abbd, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1012abc0, 0x3)   add(eax, 0x5);                        /* add eax, 0x5 */
    II(0x1012abc3, 0x5)   calld(sys_strcpy, 0x3b307);           /* call 0x10165ecf */
    II(0x1012abc8, 0x5)   mov(eax, 0x5);                        /* mov eax, 0x5 */
    II(0x1012abcd, 0x5)   calld(0x10125be9, -0x4fe9);           /* call 0x10125be9 */
    II(0x1012abd2, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1012abd4, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1012abd5, 0x1)   popd(edi);                            /* pop edi */
    II(0x1012abd6, 0x1)   popd(esi);                            /* pop esi */
    II(0x1012abd7, 0x1)   popd(edx);                            /* pop edx */
    II(0x1012abd8, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1012abd9, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1012abda, 0x1)   retd();                               /* ret */
FUNC_END

