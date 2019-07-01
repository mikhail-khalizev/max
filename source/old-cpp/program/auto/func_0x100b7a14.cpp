FUNC_BEGIN(0x100b7a14, 0xf633e277ebd1ae69, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x34, 0xe3, 0xa, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0xf9, 0xf1, 0xfb, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100b7a14, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100b7a19, 0x5)   calld(sys_check_available_stack_size, 0xae334); /* call 0x10165d52 */
    II(0x100b7a1e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b7a1f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b7a20, 0x1)   pushd(edx);                           /* push edx */
    II(0x100b7a21, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b7a22, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b7a23, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b7a24, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b7a26, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100b7a2c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100b7a2f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b7a32, 0x5)   calld(0x10076c30, -0x40e07);          /* call 0x10076c30 */
    II(0x100b7a37, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100b7a3a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b7a3d, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b7a3f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b7a40, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b7a41, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b7a42, 0x1)   popd(edx);                            /* pop edx */
    II(0x100b7a43, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b7a44, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b7a45, 0x1)   retd();                               /* ret */
FUNC_END

