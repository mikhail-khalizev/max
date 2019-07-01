FUNC_BEGIN(0x101382da, 0x3cba33a5677125bd, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x6e, 0xda, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0xf, 0xbf, 0x55, 0xfc, 0xb8, 0x78, 0x72, 0x1c, 0x10, 0xe8, 0x56, 0x59, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101382da, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x101382df, 0x5)   calld(sys_check_available_stack_size, 0x2da6e); /* call 0x10165d52 */
    II(0x101382e4, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101382e5, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101382e6, 0x1)   pushd(edx);                           /* push edx */
    II(0x101382e7, 0x1)   pushd(esi);                           /* push esi */
    II(0x101382e8, 0x1)   pushd(edi);                           /* push edi */
    II(0x101382e9, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101382ea, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101382ec, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x101382f2, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x101382f5, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x4));  /* movsx edx, word [ebp-0x4] */
    II(0x101382f9, 0x5)   mov(eax, 0x101c7278);                 /* mov eax, 0x101c7278 */
    II(0x101382fe, 0x5)   calld(0x1013dc59, 0x5956);            /* call 0x1013dc59 */
    II(0x10138303, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10138305, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10138306, 0x1)   popd(edi);                            /* pop edi */
    II(0x10138307, 0x1)   popd(esi);                            /* pop esi */
    II(0x10138308, 0x1)   popd(edx);                            /* pop edx */
    II(0x10138309, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013830a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013830b, 0x1)   retd();                               /* ret */
FUNC_END

