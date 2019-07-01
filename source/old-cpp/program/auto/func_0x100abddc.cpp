FUNC_BEGIN(0x100abddc, 0x288478a30df9d00, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x6c, 0x9f, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100abddc, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100abde1, 0x5)   calld(sys_check_available_stack_size, 0xb9f6c); /* call 0x10165d52 */
    II(0x100abde6, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100abde7, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100abde8, 0x1)   pushd(edx);                           /* push edx */
    II(0x100abde9, 0x1)   pushd(esi);                           /* push esi */
    II(0x100abdea, 0x1)   pushd(edi);                           /* push edi */
    II(0x100abdeb, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100abdec, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100abdee, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100abdf4, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100abdf7, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100abdf9, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100abdfa, 0x1)   popd(edi);                            /* pop edi */
    II(0x100abdfb, 0x1)   popd(esi);                            /* pop esi */
    II(0x100abdfc, 0x1)   popd(edx);                            /* pop edx */
    II(0x100abdfd, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100abdfe, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100abdff, 0x1)   retd();                               /* ret */
FUNC_END

