FUNC_BEGIN(0x1011486b, 0xf7b12fcc25fbade6, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xdd, 0x14, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xc6, 0x40, 0xb, 0x2, 0xe8, 0x9d, 0x62, 0x1, 0, 0x8b, 0x45, 0xfc, 0xe8, 0x73, 0xf0, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1011486b, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10114870, 0x5)   calld(sys_check_available_stack_size, 0x514dd); /* call 0x10165d52 */
    II(0x10114875, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10114876, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10114877, 0x1)   pushd(edx);                           /* push edx */
    II(0x10114878, 0x1)   pushd(esi);                           /* push esi */
    II(0x10114879, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011487a, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011487b, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1011487d, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10114883, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10114886, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10114889, 0x4)   mov(memb_a32(ds, eax + 0xb), 0x2);    /* mov byte [eax+0xb], 0x2 */
    II(0x1011488d, 0x5)   calld(0x1012ab2f, 0x1629d);           /* call 0x1012ab2f */
    II(0x10114892, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10114895, 0x5)   calld(0x1011390d, -0xf8d);            /* call 0x1011390d */
    II(0x1011489a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1011489c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011489d, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011489e, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011489f, 0x1)   popd(edx);                            /* pop edx */
    II(0x101148a0, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101148a1, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101148a2, 0x1)   retd();                               /* ret */
FUNC_END

