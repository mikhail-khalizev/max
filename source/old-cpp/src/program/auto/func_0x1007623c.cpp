FUNC_BEGIN(0x1007623c, 0x54eb25447bce2b15, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xc, 0xfb, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x6c, 0xe8, 0x2a, 0x5, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1007623c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10076241, 0x5)   calld(sys_check_available_stack_size, 0xefb0c); /* call 0x10165d52 */
    II(0x10076246, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10076247, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10076248, 0x1)   pushd(edx);                           /* push edx */
    II(0x10076249, 0x1)   pushd(esi);                           /* push esi */
    II(0x1007624a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1007624b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1007624c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1007624e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10076254, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10076257, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1007625a, 0x3)   add(eax, 0x6c);                       /* add eax, 0x6c */
    II(0x1007625d, 0x5)   calld(0x1007678c, 0x52a);             /* call 0x1007678c */
    II(0x10076262, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10076265, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10076268, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1007626a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1007626b, 0x1)   popd(edi);                            /* pop edi */
    II(0x1007626c, 0x1)   popd(esi);                            /* pop esi */
    II(0x1007626d, 0x1)   popd(edx);                            /* pop edx */
    II(0x1007626e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1007626f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10076270, 0x1)   retd();                               /* ret */
FUNC_END

