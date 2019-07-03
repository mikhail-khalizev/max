FUNC_BEGIN(0x1009ac99, 0x4d666a3670ca9edd, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xaf, 0xb0, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc7, 0x45, 0xf8, 0x4, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1009ac99, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1009ac9e, 0x5)   calld(sys_check_available_stack_size, 0xcb0af); /* call 0x10165d52 */
    II(0x1009aca3, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009aca4, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009aca5, 0x1)   pushd(edx);                           /* push edx */
    II(0x1009aca6, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009aca7, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009aca8, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009aca9, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009acab, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1009acb1, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1009acb4, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0x4);    /* mov dword [ebp-0x8], 0x4 */
    II(0x1009acbb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1009acbe, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009acc0, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009acc1, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009acc2, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009acc3, 0x1)   popd(edx);                            /* pop edx */
    II(0x1009acc4, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009acc5, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009acc6, 0x1)   retd();                               /* ret */
FUNC_END

