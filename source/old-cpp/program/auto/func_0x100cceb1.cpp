FUNC_BEGIN(0x100cceb1, 0x2fc49d1bc7d565fe, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x97, 0x8e, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc7, 0x45, 0xf8, 0x4, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100cceb1, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100cceb6, 0x5)   calld(sys_check_available_stack_size, 0x98e97); /* call 0x10165d52 */
    II(0x100ccebb, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100ccebc, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ccebd, 0x1)   pushd(edx);                           /* push edx */
    II(0x100ccebe, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ccebf, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ccec0, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ccec1, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ccec3, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100ccec9, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100ccecc, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0x4);    /* mov dword [ebp-0x8], 0x4 */
    II(0x100cced3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100cced6, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cced8, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cced9, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cceda, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ccedb, 0x1)   popd(edx);                            /* pop edx */
    II(0x100ccedc, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ccedd, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ccede, 0x1)   retd();                               /* ret */
FUNC_END

