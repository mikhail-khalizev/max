FUNC_BEGIN(0x10155204, 0x1998339ca2f3eca4, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x44, 0xb, 0x1, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0xee, 0x4f, 0xfe, 0xff, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10155204, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10155209, 0x5)   calld(sys_check_available_stack_size, 0x10b44); /* call 0x10165d52 */
    II(0x1015520e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1015520f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10155210, 0x1)   pushd(esi);                           /* push esi */
    II(0x10155211, 0x1)   pushd(edi);                           /* push edi */
    II(0x10155212, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10155213, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10155215, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1015521b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1015521e, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10155221, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x10155224, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10155227, 0x5)   calld(0x1013a21a, -0x1b012);          /* call 0x1013a21a */
    II(0x1015522c, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1015522f, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10155232, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10155234, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10155235, 0x1)   popd(edi);                            /* pop edi */
    II(0x10155236, 0x1)   popd(esi);                            /* pop esi */
    II(0x10155237, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10155238, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10155239, 0x1)   retd();                               /* ret */
FUNC_END

