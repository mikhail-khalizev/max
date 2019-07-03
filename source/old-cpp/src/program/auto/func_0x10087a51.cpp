FUNC_BEGIN(0x10087a51, 0xf849ca9e772bc6b9, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xf7, 0xe2, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0xf, 0xe8, 0xf8, 0x32, 0xb, 0, 0x88, 0x45, 0xf8, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10087a51, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10087a56, 0x5)   calld(sys_check_available_stack_size, 0xde2f7); /* call 0x10165d52 */
    II(0x10087a5b, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10087a5c, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10087a5d, 0x1)   pushd(edx);                           /* push edx */
    II(0x10087a5e, 0x1)   pushd(esi);                           /* push esi */
    II(0x10087a5f, 0x1)   pushd(edi);                           /* push edi */
    II(0x10087a60, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10087a61, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10087a63, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10087a69, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10087a6c, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10087a6e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10087a71, 0x3)   add(eax, 0xf);                        /* add eax, 0xf */
    II(0x10087a74, 0x5)   calld(0x1013ad71, 0xb32f8);           /* call 0x1013ad71 */
    II(0x10087a79, 0x3)   mov(memb_a32(ss, ebp - 0x8), al);     /* mov [ebp-0x8], al */
//    II(0x10087a7c, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x10087a7f, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10087a81, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10087a82, 0x1)   popd(edi);                            /* pop edi */
    II(0x10087a83, 0x1)   popd(esi);                            /* pop esi */
    II(0x10087a84, 0x1)   popd(edx);                            /* pop edx */
    II(0x10087a85, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10087a86, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10087a87, 0x1)   retd();                               /* ret */
FUNC_END

