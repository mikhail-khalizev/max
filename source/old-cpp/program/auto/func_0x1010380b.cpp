FUNC_BEGIN(0x1010380b, 0x22dd6ee7f0febe37, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x3d, 0x25, 0x6, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc7, 0x45, 0xf8, 0, 0, 0, 0, 0xeb, 0x6, 0x8b, 0x45, 0xf8, 0xff, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x8b, 0x55, 0xfc, 0x66, 0x3b, 0x2, 0x7d, 0x16, 0xf, 0xbf, 0x45, 0xf8, 0x6b, 0xd0, 0xa, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x4, 0x1, 0xd0, 0xe8, 0xa0, 0x6e, 0x3, 0, 0xeb, 0xd9, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1010380b, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10103810, 0x5)   calld(sys_check_available_stack_size, 0x6253d); /* call 0x10165d52 */
    II(0x10103815, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10103816, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10103817, 0x1)   pushd(edx);                           /* push edx */
    II(0x10103818, 0x1)   pushd(esi);                           /* push esi */
    II(0x10103819, 0x1)   pushd(edi);                           /* push edi */
    II(0x1010381a, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1010381b, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1010381d, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10103823, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10103826, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0);      /* mov dword [ebp-0x8], 0x0 */
    II(0x1010382d, 0x2)   jmpd(0x10103835, 0x6);                /* jmp 0x10103835 */
l_0x1010382f:
    II(0x1010382f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10103832, 0x3)   inc(memd_a32(ss, ebp - 0x8));         /* inc dword [ebp-0x8] */
l_0x10103835:
    II(0x10103835, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10103838, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x1010383b, 0x3)   cmp(ax, memw_a32(ds, edx));           /* cmp ax, [edx] */
    II(0x1010383e, 0x2)   jged(0x10103856, 0x16);               /* jge 0x10103856 */
    II(0x10103840, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x10103844, 0x3)   imul(edx, eax, 0xa);                  /* imul edx, eax, 0xa */
    II(0x10103847, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1010384a, 0x3)   mov(eax, memd_a32(ds, eax + 0x4));    /* mov eax, [eax+0x4] */
    II(0x1010384d, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x1010384f, 0x5)   calld(0x1013a6f4, 0x36ea0);           /* call 0x1013a6f4 */
    II(0x10103854, 0x2)   jmpd(0x1010382f, -0x27);              /* jmp 0x1010382f */
l_0x10103856:
    II(0x10103856, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10103858, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10103859, 0x1)   popd(edi);                            /* pop edi */
    II(0x1010385a, 0x1)   popd(esi);                            /* pop esi */
    II(0x1010385b, 0x1)   popd(edx);                            /* pop edx */
    II(0x1010385c, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1010385d, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1010385e, 0x1)   retd();                               /* ret */
FUNC_END

