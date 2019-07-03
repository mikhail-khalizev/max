FUNC_BEGIN(0x1009c73c, 0x2c390e7211a25962, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xc, 0x96, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1009c73c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1009c741, 0x5)   calld(sys_check_available_stack_size, 0xc960c); /* call 0x10165d52 */
    II(0x1009c746, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009c747, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009c748, 0x1)   pushd(edx);                           /* push edx */
    II(0x1009c749, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009c74a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009c74b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009c74c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009c74e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1009c754, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1009c757, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1009c75a, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1009c75c, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1009c75f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009c762, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009c764, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009c765, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009c766, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009c767, 0x1)   popd(edx);                            /* pop edx */
    II(0x1009c768, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009c769, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009c76a, 0x1)   retd();                               /* ret */
FUNC_END

