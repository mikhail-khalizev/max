FUNC_BEGIN(0x100e809e, 0x7d1d367a57ebba17, 0x20, ({0x68, 0x1c, 0, 0, 0, 0xe8, 0xaa, 0xdc, 0x7, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0, 0, 0, 0, 0xb8, 0x20, 0x36, 0x1c, 0x10, 0xe8, 0xd4, 0x4a, 0xfb, 0xff, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100e809e, 0x5)   pushd(0x1c);                          /* push dword 0x1c */
    II(0x100e80a3, 0x5)   calld(sys_check_available_stack_size, 0x7dcaa); /* call 0x10165d52 */
    II(0x100e80a8, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e80a9, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e80aa, 0x1)   pushd(edx);                           /* push edx */
    II(0x100e80ab, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e80ac, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e80ad, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e80ae, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e80b0, 0x6)   sub(esp, 0);                          /* sub esp, 0x0 */
    II(0x100e80b6, 0x5)   mov(eax, 0x101c3620);                 /* mov eax, 0x101c3620 */
    II(0x100e80bb, 0x5)   calld(0x1009cb94, -0x4b52c);          /* call 0x1009cb94 */
    II(0x100e80c0, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e80c1, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e80c2, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e80c3, 0x1)   popd(edx);                            /* pop edx */
    II(0x100e80c4, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e80c5, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e80c6, 0x1)   retd();                               /* ret */
FUNC_END

