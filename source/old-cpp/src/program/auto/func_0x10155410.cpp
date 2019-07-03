FUNC_BEGIN(0x10155410, 0x3fbc112275afdf45, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x38, 0x9, 0x1, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0xd9, 0x66, 0xfe, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10155410, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10155415, 0x5)   calld(sys_check_available_stack_size, 0x10938); /* call 0x10165d52 */
    II(0x1015541a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1015541b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1015541c, 0x1)   pushd(esi);                           /* push esi */
    II(0x1015541d, 0x1)   pushd(edi);                           /* push edi */
    II(0x1015541e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1015541f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10155421, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10155427, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1015542a, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x1015542d, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x10155430, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10155433, 0x5)   calld(0x1013bb11, -0x19927);          /* call 0x1013bb11 */
    II(0x10155438, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1015543a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1015543b, 0x1)   popd(edi);                            /* pop edi */
    II(0x1015543c, 0x1)   popd(esi);                            /* pop esi */
    II(0x1015543d, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1015543e, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1015543f, 0x1)   retd();                               /* ret */
FUNC_END

