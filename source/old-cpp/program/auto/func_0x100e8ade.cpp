FUNC_BEGIN(0x100e8ade, 0xbaadf9580081e021, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x6a, 0xd2, 0x7, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xf, 0xbf, 0x45, 0xfc, 0xe8, 0xe9, 0xb6, 0x4, 0, 0x89, 0x45, 0xf8, 0x83, 0x7d, 0xf8, 0, 0x74, 0x10, 0x8b, 0x45, 0xf8, 0xe8, 0x2d, 0xff, 0xff, 0xff, 0x8b, 0x45, 0xf8, 0xe8, 0x49, 0xd4, 0x7, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100e8ade, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100e8ae3, 0x5)   calld(sys_check_available_stack_size, 0x7d26a); /* call 0x10165d52 */
    II(0x100e8ae8, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e8ae9, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e8aea, 0x1)   pushd(edx);                           /* push edx */
    II(0x100e8aeb, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e8aec, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e8aed, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e8aee, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e8af0, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100e8af6, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100e8af9, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100e8afd, 0x5)   calld(my_get_res_data_by_id_malloc, 0x4b6e9); /* call 0x101341eb */
    II(0x100e8b02, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100e8b05, 0x4)   cmp(memd_a32(ss, ebp - 0x8), 0);      /* cmp dword [ebp-0x8], 0x0 */
    II(0x100e8b09, 0x2)   jzd(0x100e8b1b, 0x10);                /* jz 0x100e8b1b */
    II(0x100e8b0b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100e8b0e, 0x5)   calld(0x100e8a40, -0xd3);             /* call 0x100e8a40 */
    II(0x100e8b13, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100e8b16, 0x5)   calld(sys_delete, 0x7d449);           /* call 0x10165f64 */
l_0x100e8b1b:
    II(0x100e8b1b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e8b1d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e8b1e, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e8b1f, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e8b20, 0x1)   popd(edx);                            /* pop edx */
    II(0x100e8b21, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e8b22, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e8b23, 0x1)   retd();                               /* ret */
FUNC_END

