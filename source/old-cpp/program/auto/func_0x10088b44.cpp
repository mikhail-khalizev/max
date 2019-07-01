FUNC_BEGIN(0x10088b44, 0x8dce47a080d69fe8, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x4, 0xd2, 0xd, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x10, 0x8b, 0x45, 0xf8, 0x89, 0x10, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10088b44, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10088b49, 0x5)   calld(sys_check_available_stack_size, 0xdd204); /* call 0x10165d52 */
    II(0x10088b4e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10088b4f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10088b50, 0x1)   pushd(esi);                           /* push esi */
    II(0x10088b51, 0x1)   pushd(edi);                           /* push edi */
    II(0x10088b52, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10088b53, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10088b55, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10088b5b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10088b5e, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x10088b61, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10088b64, 0x2)   mov(edx, memd_a32(ds, eax));          /* mov edx, [eax] */
    II(0x10088b66, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10088b69, 0x2)   mov(memd_a32(ds, eax), edx);          /* mov [eax], edx */
    II(0x10088b6b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10088b6e, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x10088b71, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10088b74, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10088b76, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10088b77, 0x1)   popd(edi);                            /* pop edi */
    II(0x10088b78, 0x1)   popd(esi);                            /* pop esi */
    II(0x10088b79, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10088b7a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10088b7b, 0x1)   retd();                               /* ret */
FUNC_END

