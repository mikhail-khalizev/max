FUNC_BEGIN(0x10157c2b, 0x471c18eb4613451e, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x1d, 0xe1, 0, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x40, 0x8, 0x8b, 0x55, 0xfc, 0x66, 0x3b, 0x42, 0x8, 0x74, 0x6, 0xc6, 0x45, 0xf8, 0x1, 0xeb, 0x4, 0xc6, 0x45, 0xf8, 0, 0x8a, 0x45, 0xf8, 0x88, 0x45, 0xf4, 0x8a, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10157c2b, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x10157c30, 0x5)   calld(sys_check_available_stack_size, 0xe11d); /* call 0x10165d52 */
    II(0x10157c35, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10157c36, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10157c37, 0x1)   pushd(edx);                           /* push edx */
    II(0x10157c38, 0x1)   pushd(esi);                           /* push esi */
    II(0x10157c39, 0x1)   pushd(edi);                           /* push edi */
    II(0x10157c3a, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10157c3b, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10157c3d, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10157c43, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10157c46, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10157c49, 0x4)   mov(ax, memw_a32(ds, eax + 0x8));     /* mov ax, [eax+0x8] */
    II(0x10157c4d, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x10157c50, 0x4)   cmp(ax, memw_a32(ds, edx + 0x8));     /* cmp ax, [edx+0x8] */
    II(0x10157c54, 0x2)   jzd(0x10157c5c, 0x6);                 /* jz 0x10157c5c */
    II(0x10157c56, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x1);    /* mov byte [ebp-0x8], 0x1 */
    II(0x10157c5a, 0x2)   jmpd(0x10157c60, 0x4);                /* jmp 0x10157c60 */
l_0x10157c5c:
    II(0x10157c5c, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0);      /* mov byte [ebp-0x8], 0x0 */
l_0x10157c60:
    II(0x10157c60, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x10157c63, 0x3)   mov(memb_a32(ss, ebp - 0xc), al);     /* mov [ebp-0xc], al */
//    II(0x10157c66, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x10157c69, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10157c6b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10157c6c, 0x1)   popd(edi);                            /* pop edi */
    II(0x10157c6d, 0x1)   popd(esi);                            /* pop esi */
    II(0x10157c6e, 0x1)   popd(edx);                            /* pop edx */
    II(0x10157c6f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10157c70, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10157c71, 0x1)   retd();                               /* ret */
FUNC_END

