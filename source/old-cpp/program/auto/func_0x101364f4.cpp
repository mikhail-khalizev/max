FUNC_BEGIN(0x101364f4, 0xbf54ce66ca8c6ff, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x54, 0xf8, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x5, 0xf0, 0x2, 0, 0, 0xe8, 0x78, 0x9c, 0xfa, 0xff, 0x2d, 0xf0, 0x2, 0, 0, 0x89, 0x45, 0xf8, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x5, 0x7c, 0x1, 0, 0, 0xe8, 0xe1, 0x9b, 0xfa, 0xff, 0x2d, 0x7c, 0x1, 0, 0, 0x89, 0x45, 0xf8, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x8, 0xe8, 0xcc, 0x9b, 0xfa, 0xff, 0x83, 0xe8, 0x8, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x101364f4, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x101364f9, 0x5)   calld(sys_check_available_stack_size, 0x2f854); /* call 0x10165d52 */
    II(0x101364fe, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101364ff, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10136500, 0x1)   pushd(esi);                           /* push esi */
    II(0x10136501, 0x1)   pushd(edi);                           /* push edi */
    II(0x10136502, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10136503, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10136505, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1013650b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1013650e, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x10136511, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10136513, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10136516, 0x5)   add(eax, 0x2f0);                      /* add eax, 0x2f0 */
    II(0x1013651b, 0x5)   calld(0x100e0198, -0x56388);          /* call 0x100e0198 */
    II(0x10136520, 0x5)   sub(eax, 0x2f0);                      /* sub eax, 0x2f0 */
    II(0x10136525, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10136528, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1013652a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013652d, 0x5)   add(eax, 0x17c);                      /* add eax, 0x17c */
    II(0x10136532, 0x5)   calld(0x100e0118, -0x5641f);          /* call 0x100e0118 */
    II(0x10136537, 0x5)   sub(eax, 0x17c);                      /* sub eax, 0x17c */
    II(0x1013653c, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1013653f, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10136541, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10136544, 0x3)   add(eax, 0x8);                        /* add eax, 0x8 */
    II(0x10136547, 0x5)   calld(0x100e0118, -0x56434);          /* call 0x100e0118 */
    II(0x1013654c, 0x3)   sub(eax, 0x8);                        /* sub eax, 0x8 */
    II(0x1013654f, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10136552, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10136555, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x10136558, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1013655b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013655d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013655e, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013655f, 0x1)   popd(esi);                            /* pop esi */
    II(0x10136560, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10136561, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10136562, 0x1)   retd();                               /* ret */
FUNC_END

