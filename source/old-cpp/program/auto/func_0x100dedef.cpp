FUNC_BEGIN(0x100dedef, 0xfb6cfc5b28fbb73d, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x59, 0x6f, 0x8, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x8b, 0x80, 0x45, 0x3, 0, 0, 0xe8, 0x2f, 0x13, 0xff, 0xff, 0x89, 0x45, 0xf0, 0xc7, 0x45, 0xf4, 0x2, 0, 0, 0, 0xeb, 0x6, 0x8b, 0x45, 0xf4, 0xff, 0x45, 0xf4, 0x8b, 0x45, 0xf8, 0x5, 0xb3, 0x3, 0, 0, 0xe8, 0x2f, 0xc5, 0xfa, 0xff, 0x66, 0x3b, 0x45, 0xf4, 0x7e, 0x38, 0xf, 0xbf, 0x55, 0xf4, 0x8b, 0x45, 0xf8, 0x5, 0xb3, 0x3, 0, 0, 0xe8, 0xd8, 0xc3, 0xfa, 0xff, 0x66, 0x8b, 0, 0x66, 0x3b, 0x45, 0xf0, 0x75, 0x1c, 0xba, 0x1, 0, 0, 0, 0xb8, 0x19, 0, 0, 0, 0xe8, 0x98, 0x2f, 0xf9, 0xff, 0x8b, 0x55, 0xfc, 0xf, 0xaf, 0xd0, 0x8b, 0x45, 0xf8, 0x66, 0x29, 0x50, 0x4f, 0xeb, 0xaf, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100dedef, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x100dedf4, 0x5)   calld(sys_check_available_stack_size, 0x86f59); /* call 0x10165d52 */
    II(0x100dedf9, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100dedfa, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100dedfb, 0x1)   pushd(esi);                           /* push esi */
    II(0x100dedfc, 0x1)   pushd(edi);                           /* push edi */
    II(0x100dedfd, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100dedfe, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100dee00, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x100dee06, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100dee09, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100dee0c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100dee0f, 0x6)   mov(eax, memd_a32(ds, eax + 0x345));  /* mov eax, [eax+0x345] */
    II(0x100dee15, 0x5)   calld(0x100d0149, -0xecd1);           /* call 0x100d0149 */
    II(0x100dee1a, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x100dee1d, 0x7)   mov(memd_a32(ss, ebp - 0xc), 0x2);    /* mov dword [ebp-0xc], 0x2 */
    II(0x100dee24, 0x2)   jmpd(0x100dee2c, 0x6);                /* jmp 0x100dee2c */
l_0x100dee26:
    II(0x100dee26, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100dee29, 0x3)   inc(memd_a32(ss, ebp - 0xc));         /* inc dword [ebp-0xc] */
l_0x100dee2c:
    II(0x100dee2c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100dee2f, 0x5)   add(eax, 0x3b3);                      /* add eax, 0x3b3 */
    II(0x100dee34, 0x5)   calld(my_2_get_count, -0x53ad1);      /* call 0x1008b368 */
    II(0x100dee39, 0x4)   cmp(ax, memw_a32(ss, ebp - 0xc));     /* cmp ax, [ebp-0xc] */
    II(0x100dee3d, 0x2)   jled(0x100dee77, 0x38);               /* jle 0x100dee77 */
    II(0x100dee3f, 0x4)   movsx(edx, memw_a32(ss, ebp - 0xc));  /* movsx edx, word [ebp-0xc] */
    II(0x100dee43, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100dee46, 0x5)   add(eax, 0x3b3);                      /* add eax, 0x3b3 */
    II(0x100dee4b, 0x5)   calld(0x1008b228, -0x53c28);          /* call 0x1008b228 */
    II(0x100dee50, 0x3)   mov(ax, memw_a32(ds, eax));           /* mov ax, [eax] */
    II(0x100dee53, 0x4)   cmp(ax, memw_a32(ss, ebp - 0x10));    /* cmp ax, [ebp-0x10] */
    II(0x100dee57, 0x2)   jnzd(0x100dee75, 0x1c);               /* jnz 0x100dee75 */
    II(0x100dee59, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
    II(0x100dee5e, 0x5)   mov(eax, 0x19);                       /* mov eax, 0x19 */
    II(0x100dee63, 0x5)   calld(0x10071e00, -0x6d068);          /* call 0x10071e00 */
    II(0x100dee68, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100dee6b, 0x3)   imul(edx, eax);                       /* imul edx, eax */
    II(0x100dee6e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100dee71, 0x4)   sub(memw_a32(ds, eax + 0x4f), dx);    /* sub [eax+0x4f], dx */
l_0x100dee75:
    II(0x100dee75, 0x2)   jmpd(0x100dee26, -0x51);              /* jmp 0x100dee26 */
l_0x100dee77:
    II(0x100dee77, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100dee79, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100dee7a, 0x1)   popd(edi);                            /* pop edi */
    II(0x100dee7b, 0x1)   popd(esi);                            /* pop esi */
    II(0x100dee7c, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100dee7d, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100dee7e, 0x1)   retd();                               /* ret */
FUNC_END

