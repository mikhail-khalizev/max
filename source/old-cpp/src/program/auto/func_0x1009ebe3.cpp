FUNC_BEGIN(0x1009ebe3, 0xed685696a2d725a6, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x65, 0x71, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc6, 0x45, 0xf8, 0xb, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1009ebe3, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1009ebe8, 0x5)   calld(sys_check_available_stack_size, 0xc7165); /* call 0x10165d52 */
    II(0x1009ebed, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009ebee, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009ebef, 0x1)   pushd(edx);                           /* push edx */
    II(0x1009ebf0, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009ebf1, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009ebf2, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009ebf3, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009ebf5, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1009ebfb, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1009ebfe, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0xb);    /* mov byte [ebp-0x8], 0xb */
    II(0x1009ec02, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x1009ec05, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009ec07, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009ec08, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009ec09, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009ec0a, 0x1)   popd(edx);                            /* pop edx */
    II(0x1009ec0b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009ec0c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009ec0d, 0x1)   retd();                               /* ret */
FUNC_END

