FUNC_BEGIN(0x1009cb94, 0x47810d3751bcb419, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xb4, 0x91, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0xc7, 0x40, 0x2, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1009cb94, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1009cb99, 0x5)   calld(sys_check_available_stack_size, 0xc91b4); /* call 0x10165d52 */
    II(0x1009cb9e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009cb9f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009cba0, 0x1)   pushd(edx);                           /* push edx */
    II(0x1009cba1, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009cba2, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009cba3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009cba4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009cba6, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1009cbac, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1009cbaf, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1009cbb2, 0x6)   mov(memw_a32(ds, eax + 0x2), 0);      /* mov word [eax+0x2], 0x0 */
    II(0x1009cbb8, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009cbba, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009cbbb, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009cbbc, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009cbbd, 0x1)   popd(edx);                            /* pop edx */
    II(0x1009cbbe, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009cbbf, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009cbc0, 0x1)   retd();                               /* ret */
FUNC_END

