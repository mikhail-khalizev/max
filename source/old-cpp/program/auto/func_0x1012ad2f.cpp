FUNC_BEGIN(0x1012ad2f, 0x9e67921935b576fc, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x19, 0xb0, 0x3, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0xe8, 0x4f, 0xb1, 0x3, 0, 0x89, 0x45, 0xf8, 0xe8, 0x51, 0xc5, 0xff, 0xff, 0x88, 0x45, 0xfc, 0xc6, 0x5, 0x30, 0x56, 0x1c, 0x10, 0x2, 0xa1, 0xcc, 0x59, 0x1c, 0x10, 0xc6, 0x40, 0xf, 0, 0xbb, 0x5, 0, 0, 0, 0xf, 0xbf, 0x55, 0xf8, 0xb8, 0x20, 0, 0, 0, 0xe8, 0x81, 0xc3, 0xff, 0xff, 0x31, 0xc0, 0xa0, 0xc8, 0x59, 0x1c, 0x10, 0x83, 0xf8, 0x3, 0xf, 0x85, 0x6b, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x66, 0xa3, 0xd0, 0x40, 0x1c, 0x10, 0xa1, 0xcc, 0x59, 0x1c, 0x10, 0x8a, 0x40, 0xf, 0x3a, 0x45, 0xfc, 0x74, 0x11, 0xe8, 0x48, 0xc8, 0xff, 0xff, 0xe8, 0x5e, 0x4, 0x4, 0, 0x83, 0xf8, 0x1b, 0x74, 0x4f, 0xeb, 0xe2, 0xe8, 0x15, 0xff, 0xff, 0xff, 0xc6, 0x45, 0xf4, 0, 0xeb, 0x6, 0x8a, 0x45, 0xf4, 0xfe, 0x45, 0xf4, 0x31, 0xc0, 0x8a, 0x45, 0xf4, 0x83, 0xf8, 0x4, 0x7d, 0x29, 0x31, 0xc0, 0x8a, 0x45, 0xf4, 0x69, 0xc0, 0x47, 0x2, 0, 0, 0x8a, 0x80, 0x90, 0xa4, 0x1c, 0x10, 0x25, 0xff, 0, 0, 0, 0x83, 0xf8, 0x3, 0x75, 0xc, 0x31, 0xc0, 0x8a, 0x45, 0xf4, 0xc6, 0x80, 0xb0, 0x40, 0x1c, 0x10, 0x1, 0xeb, 0xc7, 0xa1, 0xcc, 0x59, 0x1c, 0x10, 0xc6, 0x40, 0xa, 0x1, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1012ad2f, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x1012ad34, 0x5)   calld(sys_check_available_stack_size, 0x3b019); /* call 0x10165d52 */
    II(0x1012ad39, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1012ad3a, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1012ad3b, 0x1)   pushd(edx);                           /* push edx */
    II(0x1012ad3c, 0x1)   pushd(esi);                           /* push esi */
    II(0x1012ad3d, 0x1)   pushd(edi);                           /* push edi */
    II(0x1012ad3e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1012ad3f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1012ad41, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1012ad47, 0x5)   calld(/* sys */ 0x10165e9b, 0x3b14f); /* call 0x10165e9b */
    II(0x1012ad4c, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1012ad4f, 0x5)   calld(0x101272a5, -0x3aaf);           /* call 0x101272a5 */
    II(0x1012ad54, 0x3)   mov(memb_a32(ss, ebp - 0x4), al);     /* mov [ebp-0x4], al */
    II(0x1012ad57, 0x7)   mov(memb_a32(ds, 0x101c5630), 0x2);   /* mov byte [0x101c5630], 0x2 */
    II(0x1012ad5e, 0x5)   mov(eax, memd_a32(ds, 0x101c59cc));   /* mov eax, [0x101c59cc] */
    II(0x1012ad63, 0x4)   mov(memb_a32(ds, eax + 0xf), 0);      /* mov byte [eax+0xf], 0x0 */
    II(0x1012ad67, 0x5)   mov(ebx, 0x5);                        /* mov ebx, 0x5 */
    II(0x1012ad6c, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x8));  /* movsx edx, word [ebp-0x8] */
    II(0x1012ad70, 0x5)   mov(eax, 0x20);                       /* mov eax, 0x20 */
    II(0x1012ad75, 0x5)   calld(0x101270fb, -0x3c7f);           /* call 0x101270fb */
    II(0x1012ad7a, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1012ad7c, 0x5)   mov(al, memb_a32(ds, 0x101c59c8));    /* mov al, [0x101c59c8] */
    II(0x1012ad81, 0x3)   cmp(eax, 0x3);                        /* cmp eax, 0x3 */
    II(0x1012ad84, 0x6)   jnzd(0x1012adf5, 0x6b);               /* jnz dword 0x1012adf5 */
    II(0x1012ad8a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1012ad8d, 0x6)   mov(memw_a32(ds, 0x101c40d0), ax);    /* mov [0x101c40d0], ax */
l_0x1012ad93:
    II(0x1012ad93, 0x5)   mov(eax, memd_a32(ds, 0x101c59cc));   /* mov eax, [0x101c59cc] */
    II(0x1012ad98, 0x3)   mov(al, memb_a32(ds, eax + 0xf));     /* mov al, [eax+0xf] */
    II(0x1012ad9b, 0x3)   cmp(al, memb_a32(ss, ebp - 0x4));     /* cmp al, [ebp-0x4] */
    II(0x1012ad9e, 0x2)   jzd(0x1012adb1, 0x11);                /* jz 0x1012adb1 */
    II(0x1012ada0, 0x5)   calld(0x101275ed, -0x37b8);           /* call 0x101275ed */
    II(0x1012ada5, 0x5)   calld(/* sys */ 0x1016b208, 0x4045e); /* call 0x1016b208 */
    II(0x1012adaa, 0x3)   cmp(eax, 0x1b);                       /* cmp eax, 0x1b */
    II(0x1012adad, 0x2)   jzd(0x1012adfe, 0x4f);                /* jz 0x1012adfe */
    II(0x1012adaf, 0x2)   jmpd(0x1012ad93, -0x1e);              /* jmp 0x1012ad93 */
l_0x1012adb1:
    II(0x1012adb1, 0x5)   calld(0x1012accb, -0xeb);             /* call 0x1012accb */
    II(0x1012adb6, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0);      /* mov byte [ebp-0xc], 0x0 */
    II(0x1012adba, 0x2)   jmpd(0x1012adc2, 0x6);                /* jmp 0x1012adc2 */
l_0x1012adbc:
    II(0x1012adbc, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x1012adbf, 0x3)   inc(memb_a32(ss, ebp - 0xc));         /* inc byte [ebp-0xc] */
l_0x1012adc2:
    II(0x1012adc2, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1012adc4, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x1012adc7, 0x3)   cmp(eax, 0x4);                        /* cmp eax, 0x4 */
    II(0x1012adca, 0x2)   jged(0x1012adf5, 0x29);               /* jge 0x1012adf5 */
    II(0x1012adcc, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1012adce, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x1012add1, 0x6)   imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
    II(0x1012add7, 0x6)   mov(al, memb_a32(ds, eax + 0x101ca490)); /* mov al, [eax+0x101ca490] */
    II(0x1012addd, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x1012ade2, 0x3)   cmp(eax, 0x3);                        /* cmp eax, 0x3 */
    II(0x1012ade5, 0x2)   jnzd(0x1012adf3, 0xc);                /* jnz 0x1012adf3 */
    II(0x1012ade7, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1012ade9, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x1012adec, 0x7)   mov(memb_a32(ds, eax + 0x101c40b0), 0x1); /* mov byte [eax+0x101c40b0], 0x1 */
l_0x1012adf3:
    II(0x1012adf3, 0x2)   jmpd(0x1012adbc, -0x39);              /* jmp 0x1012adbc */
l_0x1012adf5:
    II(0x1012adf5, 0x5)   mov(eax, memd_a32(ds, 0x101c59cc));   /* mov eax, [0x101c59cc] */
    II(0x1012adfa, 0x4)   mov(memb_a32(ds, eax + 0xa), 0x1);    /* mov byte [eax+0xa], 0x1 */
l_0x1012adfe:
    II(0x1012adfe, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1012ae00, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1012ae01, 0x1)   popd(edi);                            /* pop edi */
    II(0x1012ae02, 0x1)   popd(esi);                            /* pop esi */
    II(0x1012ae03, 0x1)   popd(edx);                            /* pop edx */
    II(0x1012ae04, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1012ae05, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1012ae06, 0x1)   retd();                               /* ret */
FUNC_END

