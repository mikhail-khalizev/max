FUNC_BEGIN(0x1007af7a, 0x68814dbe32df2963, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xce, 0xad, 0xe, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0xe7, 0xd7, 0xff, 0xff, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf8, 0xe8, 0x8f, 0xb2, 0xff, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xf4, 0x66, 0xf, 0xaf, 0x42, 0x14, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xfc, 0xe8, 0x7a, 0xb2, 0xff, 0xff, 0x8b, 0x40, 0xc, 0xc1, 0xf8, 0x10, 0x85, 0xc0, 0x7e, 0x55, 0x8b, 0x45, 0xfc, 0xe8, 0x68, 0xb2, 0xff, 0xff, 0x8b, 0x40, 0xe, 0xc1, 0xf8, 0x10, 0x85, 0xc0, 0x75, 0x1c, 0x8b, 0x45, 0xf8, 0xe8, 0x56, 0xb2, 0xff, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xfc, 0xe8, 0x4c, 0xb2, 0xff, 0xff, 0x66, 0x8b, 0x52, 0x12, 0x66, 0x3b, 0x50, 0x12, 0x7f, 0x1b, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x6, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x6, 0xc1, 0xf8, 0x10, 0xe8, 0xc3, 0x99, 0xff, 0xff, 0x84, 0xc0, 0x75, 0xc, 0x8b, 0x45, 0xfc, 0x8a, 0x40, 0x4d, 0x30, 0xe4, 0x48, 0x1, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xf0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1007af7a, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x1007af7f, 0x5)   calld(sys_check_available_stack_size, 0xeadce); /* call 0x10165d52 */
    II(0x1007af84, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1007af85, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1007af86, 0x1)   pushd(esi);                           /* push esi */
    II(0x1007af87, 0x1)   pushd(edi);                           /* push edi */
    II(0x1007af88, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1007af89, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1007af8b, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x1007af91, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1007af94, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x1007af97, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x1007af9a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1007af9d, 0x5)   calld(0x10078789, -0x2819);           /* call 0x10078789 */
    II(0x1007afa2, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x1007afa5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1007afa8, 0x5)   calld(0x1007623c, -0x4d71);           /* call 0x1007623c */
    II(0x1007afad, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1007afaf, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1007afb2, 0x5)   imul(ax, memw_a32(ds, edx + 0x14));   /* imul ax, [edx+0x14] */
    II(0x1007afb7, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x1007afba, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1007afbd, 0x5)   calld(0x1007623c, -0x4d86);           /* call 0x1007623c */
    II(0x1007afc2, 0x3)   mov(eax, memd_a32(ds, eax + 0xc));    /* mov eax, [eax+0xc] */
    II(0x1007afc5, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1007afc8, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1007afca, 0x2)   jled(0x1007b021, 0x55);               /* jle 0x1007b021 */
    II(0x1007afcc, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1007afcf, 0x5)   calld(0x1007623c, -0x4d98);           /* call 0x1007623c */
    II(0x1007afd4, 0x3)   mov(eax, memd_a32(ds, eax + 0xe));    /* mov eax, [eax+0xe] */
    II(0x1007afd7, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1007afda, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1007afdc, 0x2)   jnzd(0x1007affa, 0x1c);               /* jnz 0x1007affa */
    II(0x1007afde, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1007afe1, 0x5)   calld(0x1007623c, -0x4daa);           /* call 0x1007623c */
    II(0x1007afe6, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1007afe8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1007afeb, 0x5)   calld(0x1007623c, -0x4db4);           /* call 0x1007623c */
    II(0x1007aff0, 0x4)   mov(dx, memw_a32(ds, edx + 0x12));    /* mov dx, [edx+0x12] */
    II(0x1007aff4, 0x4)   cmp(dx, memw_a32(ds, eax + 0x12));    /* cmp dx, [eax+0x12] */
    II(0x1007aff8, 0x2)   jgd(0x1007b015, 0x1b);                /* jg 0x1007b015 */
l_0x1007affa:
    II(0x1007affa, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1007affd, 0x3)   mov(edx, memd_a32(ds, eax + 0x6));    /* mov edx, [eax+0x6] */
    II(0x1007b000, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x1007b003, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1007b006, 0x3)   mov(eax, memd_a32(ds, eax + 0x6));    /* mov eax, [eax+0x6] */
    II(0x1007b009, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1007b00c, 0x5)   calld(0x100749d4, -0x663d);           /* call 0x100749d4 */
    II(0x1007b011, 0x2)   test(al, al);                         /* test al, al */
    II(0x1007b013, 0x2)   jnzd(0x1007b021, 0xc);                /* jnz 0x1007b021 */
l_0x1007b015:
    II(0x1007b015, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1007b018, 0x3)   mov(al, memb_a32(ds, eax + 0x4d));    /* mov al, [eax+0x4d] */
    II(0x1007b01b, 0x2)   xor_(ah, ah);                         /* xor ah, ah */
    II(0x1007b01d, 0x1)   dec(eax);                             /* dec eax */
    II(0x1007b01e, 0x3)   add(memd_a32(ss, ebp - 0xc), eax);    /* add [ebp-0xc], eax */
l_0x1007b021:
    II(0x1007b021, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1007b024, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
//    II(0x1007b027, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x1007b02a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1007b02c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1007b02d, 0x1)   popd(edi);                            /* pop edi */
    II(0x1007b02e, 0x1)   popd(esi);                            /* pop esi */
    II(0x1007b02f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1007b030, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1007b031, 0x1)   retd();                               /* ret */
FUNC_END

