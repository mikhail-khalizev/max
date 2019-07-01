FUNC_BEGIN(0x1013c838, 0xd2e051c79ffe3729, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x10, 0x95, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x12, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1013c838, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1013c83d, 0x5)   calld(sys_check_available_stack_size, 0x29510); /* call 0x10165d52 */
    II(0x1013c842, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1013c843, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1013c844, 0x1)   pushd(edx);                           /* push edx */
    II(0x1013c845, 0x1)   pushd(esi);                           /* push esi */
    II(0x1013c846, 0x1)   pushd(edi);                           /* push edi */
    II(0x1013c847, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1013c848, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1013c84a, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1013c850, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1013c853, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1013c856, 0x3)   mov(eax, memd_a32(ds, eax + 0x12));   /* mov eax, [eax+0x12] */
    II(0x1013c859, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1013c85c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1013c85f, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1013c861, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1013c862, 0x1)   popd(edi);                            /* pop edi */
    II(0x1013c863, 0x1)   popd(esi);                            /* pop esi */
    II(0x1013c864, 0x1)   popd(edx);                            /* pop edx */
    II(0x1013c865, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1013c866, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1013c867, 0x1)   retd();                               /* ret */
FUNC_END

