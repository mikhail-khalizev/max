FUNC_BEGIN(0x1013f115, 0xc0521ada8ce1d212, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x33, 0x6c, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0x38, 0, 0x74, 0x34, 0x8b, 0x45, 0xfc, 0x8b, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x8b, 0, 0x8b, 0x40, 0x2, 0xe8, 0x17, 0x6e, 0x2, 0, 0x8b, 0x45, 0xf8, 0x8b, 0, 0xe8, 0xd, 0x6e, 0x2, 0, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x4, 0x8b, 0x45, 0xfc, 0x89, 0x10, 0x8b, 0x45, 0xf8, 0xe8, 0xfa, 0x6d, 0x2, 0, 0xeb, 0xc4, 0x8b, 0x45, 0xfc, 0xc7, 0x40, 0x4, 0, 0, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1013f115, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1013f11a, 0x5)   calld(sys_check_available_stack_size, 0x26c33); /* call 0x10165d52 */
    II(0x1013f11f, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013f120, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013f121, 0x1)   pushd(edx);                           /* push edx */
    II(0x1013f122, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013f123, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013f124, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013f125, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013f127, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1013f12d, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
l_0x1013f130:
    II(0x1013f130, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013f133, 0x3)   cmp(memd_a32(ds, eax), 0);            /* cmp dword [eax], 0x0 */
    II(0x1013f136, 0x2)   jzd(0x1013f16c, 0x34);                /* jz 0x1013f16c */
    II(0x1013f138, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013f13b, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1013f13d, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1013f140, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013f143, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1013f145, 0x3)   mov(eax, memd_a32(ds, eax + 0x2));    /* mov eax, [eax+0x2] */
    II(0x1013f148, 0x5)   calld(sys_delete, 0x26e17);           /* call 0x10165f64 */
    II(0x1013f14d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013f150, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1013f152, 0x5)   calld(sys_delete, 0x26e0d);           /* call 0x10165f64 */
    II(0x1013f157, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013f15a, 0x3)   mov(edx, memd_a32(ds, eax + 0x4));    /* mov edx, [eax+0x4] */
    II(0x1013f15d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013f160, 0x2)   mov(memd_a32(ds, eax), edx);          /* mov [eax], edx */
    II(0x1013f162, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013f165, 0x5)   calld(sys_delete, 0x26dfa);           /* call 0x10165f64 */
    II(0x1013f16a, 0x2)   jmpd(0x1013f130, -0x3c);              /* jmp 0x1013f130 */
l_0x1013f16c:
    II(0x1013f16c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013f16f, 0x7)   mov(memd_a32(ds, eax + 0x4), 0);      /* mov dword [eax+0x4], 0x0 */
    II(0x1013f176, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013f178, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013f179, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013f17a, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013f17b, 0x1)   popd(edx);                            /* pop edx */
    II(0x1013f17c, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013f17d, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013f17e, 0x1)   retd();                               /* ret */
FUNC_END

