FUNC_BEGIN(0x100ead24, 0xd3691f91e832264d, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x24, 0xb0, 0x7, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x40, 0xe8, 0xa8, 0xbd, 0xf8, 0xff, 0x48, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100ead24, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100ead29, 0x5)   calld(sys_check_available_stack_size, 0x7b024); /* call 0x10165d52 */
    II(0x100ead2e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100ead2f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ead30, 0x1)   pushd(edx);                           /* push edx */
    II(0x100ead31, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ead32, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ead33, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ead34, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ead36, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100ead3c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100ead3f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100ead42, 0x1)   inc(eax);                             /* inc eax */
    II(0x100ead43, 0x5)   calld(my_ctor_0x101b4184, -0x74258);  /* call 0x10076af0 */
    II(0x100ead48, 0x1)   dec(eax);                             /* dec eax */
    II(0x100ead49, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100ead4c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100ead4f, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100ead52, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ead55, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ead57, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ead58, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ead59, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ead5a, 0x1)   popd(edx);                            /* pop edx */
    II(0x100ead5b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ead5c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ead5d, 0x1)   retd();                               /* ret */
FUNC_END

