FUNC_BEGIN(0x1007653c, 0x91c2a02a0c90f252, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xc, 0xf8, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x6, 0xe8, 0x6e, 0x8, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1007653c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10076541, 0x5)   calld(sys_check_available_stack_size, 0xef80c); /* call 0x10165d52 */
    II(0x10076546, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10076547, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10076548, 0x1)   pushd(edx);                           /* push edx */
    II(0x10076549, 0x1)   pushd(esi);                           /* push esi */
    II(0x1007654a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1007654b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1007654c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1007654e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10076554, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10076557, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1007655a, 0x3)   add(eax, 0x6);                        /* add eax, 0x6 */
    II(0x1007655d, 0x5)   calld(0x10076dd0, 0x86e);             /* call 0x10076dd0 */
    II(0x10076562, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10076565, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10076568, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1007656a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1007656b, 0x1)   popd(edi);                            /* pop edi */
    II(0x1007656c, 0x1)   popd(esi);                            /* pop esi */
    II(0x1007656d, 0x1)   popd(edx);                            /* pop edx */
    II(0x1007656e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1007656f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10076570, 0x1)   retd();                               /* ret */
FUNC_END

