FUNC_BEGIN(0x100ab494, 0x1e94805fa89ca663, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xb4, 0xa8, 0xb, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xf, 0xbf, 0x45, 0xfc, 0xc1, 0xe0, 0x2, 0x89, 0xc2, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x6, 0x1, 0xd0, 0xe8, 0x9, 0xb9, 0xfc, 0xff, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100ab494, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100ab499, 0x5)   calld(sys_check_available_stack_size, 0xba8b4); /* call 0x10165d52 */
    II(0x100ab49e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100ab49f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ab4a0, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ab4a1, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ab4a2, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ab4a3, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ab4a5, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100ab4ab, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100ab4ae, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100ab4b1, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100ab4b5, 0x3)   shl(eax, 0x2);                        /* shl eax, 0x2 */
    II(0x100ab4b8, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x100ab4ba, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ab4bd, 0x3)   mov(eax, memd_a32(ds, eax + 0x6));    /* mov eax, [eax+0x6] */
    II(0x100ab4c0, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x100ab4c2, 0x5)   calld(0x10076dd0, -0x346f7);          /* call 0x10076dd0 */
    II(0x100ab4c7, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100ab4ca, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100ab4cd, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ab4cf, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ab4d0, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ab4d1, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ab4d2, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ab4d3, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ab4d4, 0x1)   retd();                               /* ret */
FUNC_END

