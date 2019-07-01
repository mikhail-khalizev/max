FUNC_BEGIN(my_string_compute_capacity_from_length, 0xea8889b97874d90d, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x70, 0x39, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xf, 0xbf, 0x55, 0xfc, 0x89, 0xd0, 0xc1, 0xfa, 0x1f, 0xc1, 0xe2, 0x6, 0x1b, 0xc2, 0xc1, 0xf8, 0x6, 0xc1, 0xe0, 0x6, 0x83, 0xc0, 0x40, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101423d8, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x101423dd, 0x5)   calld(sys_check_available_stack_size, 0x23970); /* call 0x10165d52 */
    II(0x101423e2, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101423e3, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101423e4, 0x1)   pushd(edx);                           /* push edx */
    II(0x101423e5, 0x1)   pushd(esi);                           /* push esi */
    II(0x101423e6, 0x1)   pushd(edi);                           /* push edi */
    II(0x101423e7, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101423e8, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101423ea, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x101423f0, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x101423f3, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x4));  /* movsx edx, word [ebp-0x4] */
    II(0x101423f7, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x101423f9, 0x3)   sar(edx, 0x1f);                       /* sar edx, 0x1f */
    II(0x101423fc, 0x3)   shl(edx, 0x6);                        /* shl edx, 0x6 */
    II(0x101423ff, 0x2)   sbb(eax, edx);                        /* sbb eax, edx */
    II(0x10142401, 0x3)   sar(eax, 0x6);                        /* sar eax, 0x6 */
    II(0x10142404, 0x3)   shl(eax, 0x6);                        /* shl eax, 0x6 */
    II(0x10142407, 0x3)   add(eax, 0x40);                       /* add eax, 0x40 */
    II(0x1014240a, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1014240d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10142410, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10142412, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10142413, 0x1)   popd(edi);                            /* pop edi */
    II(0x10142414, 0x1)   popd(esi);                            /* pop esi */
    II(0x10142415, 0x1)   popd(edx);                            /* pop edx */
    II(0x10142416, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10142417, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10142418, 0x1)   retd();                               /* ret */
FUNC_END

