FUNC_BEGIN(0x101064f8, 0xe45aa28c6fac3753, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x50, 0xf8, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xc7, 0x80, 0x84, 0, 0, 0, 0, 0, 0, 0, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101064f8, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x101064fd, 0x5)   calld(sys_check_available_stack_size, 0x5f850); /* call 0x10165d52 */
    II(0x10106502, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10106503, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10106504, 0x1)   pushd(edx);                           /* push edx */
    II(0x10106505, 0x1)   pushd(esi);                           /* push esi */
    II(0x10106506, 0x1)   pushd(edi);                           /* push edi */
    II(0x10106507, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10106508, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1010650a, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10106510, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10106513, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10106516, 0xa)   mov(memd_a32(ds, eax + 0x84), 0);     /* mov dword [eax+0x84], 0x0 */
    II(0x10106520, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10106523, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10106526, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10106529, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1010652b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1010652c, 0x1)   popd(edi);                            /* pop edi */
    II(0x1010652d, 0x1)   popd(esi);                            /* pop esi */
    II(0x1010652e, 0x1)   popd(edx);                            /* pop edx */
    II(0x1010652f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10106530, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10106531, 0x1)   retd();                               /* ret */
FUNC_END

