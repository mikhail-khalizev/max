FUNC_BEGIN(0x100ea763, 0x6ae11ea101c7e20b, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xe5, 0xb5, 0x7, 0, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x18, 0, 0, 0, 0x89, 0x45, 0xf0, 0x89, 0x55, 0xf8, 0x89, 0x5d, 0xfc, 0x89, 0x4d, 0xf4, 0xc7, 0x45, 0xec, 0, 0, 0, 0, 0xeb, 0x6, 0x8b, 0x45, 0xec, 0xff, 0x45, 0xec, 0x8b, 0x45, 0xec, 0x66, 0x3b, 0x45, 0xf4, 0x7d, 0x43, 0xc7, 0x45, 0xe8, 0, 0, 0, 0, 0xeb, 0x6, 0x8b, 0x45, 0xe8, 0xff, 0x45, 0xe8, 0x8b, 0x45, 0xe8, 0x66, 0x3b, 0x45, 0xfc, 0x7d, 0x1c, 0x8b, 0x45, 0xf0, 0x8a, 0, 0x25, 0xff, 0, 0, 0, 0x3, 0x45, 0x10, 0x8a, 0x10, 0x8b, 0x45, 0xf0, 0x88, 0x10, 0x8b, 0x45, 0xf0, 0xff, 0x45, 0xf0, 0xeb, 0xd5, 0xf, 0xbf, 0x55, 0xf8, 0xf, 0xbf, 0x45, 0xfc, 0x29, 0xc2, 0x1, 0x55, 0xf0, 0xeb, 0xae, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0xc2, 0x4, 0}))
    II(0x100ea763, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x100ea768, 0x5)   calld(sys_check_available_stack_size, 0x7b5e5); /* call 0x10165d52 */
    II(0x100ea76d, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ea76e, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ea76f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ea770, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ea772, 0x6)   sub(esp, 0x18);                       /* sub esp, 0x18 */
    II(0x100ea778, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x100ea77b, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x100ea77e, 0x3)   mov(memd_a32(ss, ebp - 0x4), ebx);    /* mov [ebp-0x4], ebx */
    II(0x100ea781, 0x3)   mov(memd_a32(ss, ebp - 0xc), ecx);    /* mov [ebp-0xc], ecx */
    II(0x100ea784, 0x7)   mov(memd_a32(ss, ebp - 0x14), 0);     /* mov dword [ebp-0x14], 0x0 */
    II(0x100ea78b, 0x2)   jmpd(0x100ea793, 0x6);                /* jmp 0x100ea793 */
l_0x100ea78d:
    II(0x100ea78d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x100ea790, 0x3)   inc(memd_a32(ss, ebp - 0x14));        /* inc dword [ebp-0x14] */
l_0x100ea793:
    II(0x100ea793, 0x3)   mov(eax, memd_a32(ss, ebp - 0x14));   /* mov eax, [ebp-0x14] */
    II(0x100ea796, 0x4)   cmp(ax, memw_a32(ss, ebp - 0xc));     /* cmp ax, [ebp-0xc] */
    II(0x100ea79a, 0x2)   jged(0x100ea7df, 0x43);               /* jge 0x100ea7df */
    II(0x100ea79c, 0x7)   mov(memd_a32(ss, ebp - 0x18), 0);     /* mov dword [ebp-0x18], 0x0 */
    II(0x100ea7a3, 0x2)   jmpd(0x100ea7ab, 0x6);                /* jmp 0x100ea7ab */
l_0x100ea7a5:
    II(0x100ea7a5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x100ea7a8, 0x3)   inc(memd_a32(ss, ebp - 0x18));        /* inc dword [ebp-0x18] */
l_0x100ea7ab:
    II(0x100ea7ab, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x100ea7ae, 0x4)   cmp(ax, memw_a32(ss, ebp - 0x4));     /* cmp ax, [ebp-0x4] */
    II(0x100ea7b2, 0x2)   jged(0x100ea7d0, 0x1c);               /* jge 0x100ea7d0 */
    II(0x100ea7b4, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100ea7b7, 0x2)   mov(al, memb_a32(ds, eax));           /* mov al, [eax] */
    II(0x100ea7b9, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x100ea7be, 0x3)   add(eax, memd_a32(ss, ebp + 0x10));   /* add eax, [ebp+0x10] */
    II(0x100ea7c1, 0x2)   mov(dl, memb_a32(ds, eax));           /* mov dl, [eax] */
    II(0x100ea7c3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100ea7c6, 0x2)   mov(memb_a32(ds, eax), dl);           /* mov [eax], dl */
    II(0x100ea7c8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100ea7cb, 0x3)   inc(memd_a32(ss, ebp - 0x10));        /* inc dword [ebp-0x10] */
    II(0x100ea7ce, 0x2)   jmpd(0x100ea7a5, -0x2b);              /* jmp 0x100ea7a5 */
l_0x100ea7d0:
    II(0x100ea7d0, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x8));  /* movsx edx, word [ebp-0x8] */
    II(0x100ea7d4, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100ea7d8, 0x2)   sub(edx, eax);                        /* sub edx, eax */
    II(0x100ea7da, 0x3)   add(memd_a32(ss, ebp - 0x10), edx);   /* add [ebp-0x10], edx */
    II(0x100ea7dd, 0x2)   jmpd(0x100ea78d, -0x52);              /* jmp 0x100ea78d */
l_0x100ea7df:
    II(0x100ea7df, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ea7e1, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ea7e2, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ea7e3, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ea7e4, 0x3)   retd(0x4);                            /* ret 0x4 */
FUNC_END

