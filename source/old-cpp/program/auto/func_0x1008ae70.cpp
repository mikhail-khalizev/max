FUNC_BEGIN(0x1008ae70, 0xe83fd5aca0e4705f, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xd8, 0xae, 0xd, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0xe8, 0x7c, 0xbe, 0xfe, 0xff, 0x89, 0x45, 0xf8, 0x8d, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xf0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1008ae70, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x1008ae75, 0x5)   calld(sys_check_available_stack_size, 0xdaed8); /* call 0x10165d52 */
    II(0x1008ae7a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008ae7b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008ae7c, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008ae7d, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008ae7e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008ae7f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008ae81, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x1008ae87, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1008ae8a, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x1008ae8d, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x1008ae90, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008ae93, 0x5)   calld(0x10076d14, -0x14184);          /* call 0x10076d14 */
    II(0x1008ae98, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1008ae9b, 0x3)   lea(eax, ebp - 0x8);                  /* lea eax, [ebp-0x8] */
    II(0x1008ae9e, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x1008aea1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008aea4, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
//    II(0x1008aea7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x1008aeaa, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008aeac, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008aead, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008aeae, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008aeaf, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008aeb0, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008aeb1, 0x1)   retd();                               /* ret */
FUNC_END

