FUNC_BEGIN(0x1009c350, 0xab7e0d17119b331f, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xf8, 0x99, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0xd1, 0xaa, 0xfd, 0xff, 0x89, 0x45, 0xfc, 0x8d, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1009c350, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x1009c355, 0x5)   calld(sys_check_available_stack_size, 0xc99f8); /* call 0x10165d52 */
    II(0x1009c35a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009c35b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009c35c, 0x1)   pushd(edx);                           /* push edx */
    II(0x1009c35d, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009c35e, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009c35f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009c360, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009c362, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1009c368, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1009c36b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1009c36e, 0x5)   calld(my_ctor_0x101b6edc, -0x2552f);  /* call 0x10076e44 */
    II(0x1009c373, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1009c376, 0x3)   lea(eax, ebp - 0x4);                  /* lea eax, [ebp-0x4] */
    II(0x1009c379, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1009c37c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1009c37f, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1009c382, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1009c385, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009c387, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009c388, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009c389, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009c38a, 0x1)   popd(edx);                            /* pop edx */
    II(0x1009c38b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009c38c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009c38d, 0x1)   retd();                               /* ret */
FUNC_END

