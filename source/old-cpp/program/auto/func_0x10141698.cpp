FUNC_BEGIN(0x10141698, 0xb9d24ceb2e70871f, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xb0, 0x46, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x81, 0x4b, 0xf3, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10141698, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1014169d, 0x5)   calld(sys_check_available_stack_size, 0x246b0); /* call 0x10165d52 */
    II(0x101416a2, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101416a3, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101416a4, 0x1)   pushd(edx);                           /* push edx */
    II(0x101416a5, 0x1)   pushd(esi);                           /* push esi */
    II(0x101416a6, 0x1)   pushd(edi);                           /* push edi */
    II(0x101416a7, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101416a8, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101416aa, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x101416b0, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x101416b3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101416b6, 0x5)   calld(0x1007623c, -0xcb47f);          /* call 0x1007623c */
    II(0x101416bb, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x101416be, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101416c1, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101416c3, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101416c4, 0x1)   popd(edi);                            /* pop edi */
    II(0x101416c5, 0x1)   popd(esi);                            /* pop esi */
    II(0x101416c6, 0x1)   popd(edx);                            /* pop edx */
    II(0x101416c7, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101416c8, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101416c9, 0x1)   retd();                               /* ret */
FUNC_END

