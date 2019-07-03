FUNC_BEGIN(0x1013ae28, 0xd9459757c72d5107, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x20, 0xaf, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x83, 0x7d, 0xfc, 0, 0x74, 0x6, 0x8b, 0x45, 0xfc, 0x66, 0xff, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1013ae28, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1013ae2d, 0x5)   calld(sys_check_available_stack_size, 0x2af20); /* call 0x10165d52 */
    II(0x1013ae32, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013ae33, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013ae34, 0x1)   pushd(edx);                           /* push edx */
    II(0x1013ae35, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013ae36, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013ae37, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013ae38, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013ae3a, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1013ae40, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1013ae43, 0x4)   cmp(memd_a32(ss, ebp - 0x4), 0);      /* cmp dword [ebp-0x4], 0x0 */
    II(0x1013ae47, 0x2)   jzd(0x1013ae4f, 0x6);                 /* jz 0x1013ae4f */
    II(0x1013ae49, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013ae4c, 0x3)   inc(memw_a32(ds, eax));               /* inc word [eax] */
l_0x1013ae4f:
    II(0x1013ae4f, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013ae51, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013ae52, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013ae53, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013ae54, 0x1)   popd(edx);                            /* pop edx */
    II(0x1013ae55, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013ae56, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013ae57, 0x1)   retd();                               /* ret */
FUNC_END

