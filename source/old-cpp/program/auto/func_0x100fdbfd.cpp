FUNC_BEGIN(0x100fdbfd, 0x4356d328fcdfa583, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x4b, 0x81, 0x6, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0xc6, 0x5, 0x8b, 0x38, 0x1c, 0x10, 0, 0xc7, 0x45, 0xfc, 0, 0, 0, 0, 0xeb, 0x6, 0x8b, 0x45, 0xfc, 0xff, 0x45, 0xfc, 0xf, 0xbf, 0x45, 0xfc, 0x83, 0xf8, 0x4, 0x7d, 0x22, 0xf, 0xbf, 0x45, 0xfc, 0x69, 0xc0, 0x47, 0x2, 0, 0, 0x8a, 0x80, 0x90, 0xa4, 0x1c, 0x10, 0x25, 0xff, 0, 0, 0, 0x83, 0xf8, 0x1, 0x75, 0x6, 0xfe, 0x5, 0x8b, 0x38, 0x1c, 0x10, 0xeb, 0xcf, 0x31, 0xc0, 0xa0, 0x8b, 0x38, 0x1c, 0x10, 0x83, 0xf8, 0x1, 0x7f, 0x9, 0xc6, 0x5, 0x8b, 0x38, 0x1c, 0x10, 0, 0xeb, 0x7, 0xc6, 0x5, 0xc9, 0x37, 0x1c, 0x10, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100fdbfd, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100fdc02, 0x5)   calld(sys_check_available_stack_size, 0x6814b); /* call 0x10165d52 */
    II(0x100fdc07, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100fdc08, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100fdc09, 0x1)   pushd(edx);                           /* push edx */
    II(0x100fdc0a, 0x1)   pushd(esi);                           /* push esi */
    II(0x100fdc0b, 0x1)   pushd(edi);                           /* push edi */
    II(0x100fdc0c, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100fdc0d, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100fdc0f, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100fdc15, 0x7)   mov(memb_a32(ds, 0x101c388b), 0);     /* mov byte [0x101c388b], 0x0 */
    II(0x100fdc1c, 0x7)   mov(memd_a32(ss, ebp - 0x4), 0);      /* mov dword [ebp-0x4], 0x0 */
    II(0x100fdc23, 0x2)   jmpd(0x100fdc2b, 0x6);                /* jmp 0x100fdc2b */
l_0x100fdc25:
    II(0x100fdc25, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100fdc28, 0x3)   inc(memd_a32(ss, ebp - 0x4));         /* inc dword [ebp-0x4] */
l_0x100fdc2b:
    II(0x100fdc2b, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100fdc2f, 0x3)   cmp(eax, 0x4);                        /* cmp eax, 0x4 */
    II(0x100fdc32, 0x2)   jged(0x100fdc56, 0x22);               /* jge 0x100fdc56 */
    II(0x100fdc34, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100fdc38, 0x6)   imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
    II(0x100fdc3e, 0x6)   mov(al, memb_a32(ds, eax + 0x101ca490)); /* mov al, [eax+0x101ca490] */
    II(0x100fdc44, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x100fdc49, 0x3)   cmp(eax, 0x1);                        /* cmp eax, 0x1 */
    II(0x100fdc4c, 0x2)   jnzd(0x100fdc54, 0x6);                /* jnz 0x100fdc54 */
    II(0x100fdc4e, 0x6)   inc(memb_a32(ds, 0x101c388b));        /* inc byte [0x101c388b] */
l_0x100fdc54:
    II(0x100fdc54, 0x2)   jmpd(0x100fdc25, -0x31);              /* jmp 0x100fdc25 */
l_0x100fdc56:
    II(0x100fdc56, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x100fdc58, 0x5)   mov(al, memb_a32(ds, 0x101c388b));    /* mov al, [0x101c388b] */
    II(0x100fdc5d, 0x3)   cmp(eax, 0x1);                        /* cmp eax, 0x1 */
    II(0x100fdc60, 0x2)   jgd(0x100fdc6b, 0x9);                 /* jg 0x100fdc6b */
    II(0x100fdc62, 0x7)   mov(memb_a32(ds, 0x101c388b), 0);     /* mov byte [0x101c388b], 0x0 */
    II(0x100fdc69, 0x2)   jmpd(0x100fdc72, 0x7);                /* jmp 0x100fdc72 */
l_0x100fdc6b:
    II(0x100fdc6b, 0x7)   mov(memb_a32(ds, 0x101c37c9), 0);     /* mov byte [0x101c37c9], 0x0 */
l_0x100fdc72:
    II(0x100fdc72, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100fdc74, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100fdc75, 0x1)   popd(edi);                            /* pop edi */
    II(0x100fdc76, 0x1)   popd(esi);                            /* pop esi */
    II(0x100fdc77, 0x1)   popd(edx);                            /* pop edx */
    II(0x100fdc78, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100fdc79, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100fdc7a, 0x1)   retd();                               /* ret */
FUNC_END

