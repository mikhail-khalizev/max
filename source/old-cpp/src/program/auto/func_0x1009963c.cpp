FUNC_BEGIN(0x1009963c, 0x9c6a67097d2b3433, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xc, 0xc7, 0xc, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x88, 0x5d, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x1009963c, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10099641, 0x5)   calld(sys_check_available_stack_size, 0xcc70c); /* call 0x10165d52 */
    II(0x10099646, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10099647, 0x1)   pushd(esi);                           /* push esi */
    II(0x10099648, 0x1)   pushd(edi);                           /* push edi */
    II(0x10099649, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009964a, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009964c, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10099652, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x10099655, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x10099658, 0x3)   mov(memb_a32(ss, ebp - 0x4), bl);     /* mov [ebp-0x4], bl */
    II(0x1009965b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009965d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009965e, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009965f, 0x1)   popd(esi);                            /* pop esi */
    II(0x10099660, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10099661, 0x1)   retd();                               /* ret */
FUNC_END

