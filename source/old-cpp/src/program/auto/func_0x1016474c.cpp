FUNC_BEGIN(0x1016474c, 0x4baf8bcf9c6b5069, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xfc, 0x15, 0, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xf, 0xbf, 0x45, 0xfc, 0x1, 0xc0, 0x89, 0xc2, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x8, 0x1, 0xd0, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1016474c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10164751, 0x5)   calld(sys_check_available_stack_size, 0x15fc); /* call 0x10165d52 */
    II(0x10164756, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10164757, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10164758, 0x1)   pushd(esi);                           /* push esi */
    II(0x10164759, 0x1)   pushd(edi);                           /* push edi */
    II(0x1016475a, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1016475b, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1016475d, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10164763, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10164766, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x10164769, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x1016476d, 0x2)   add(eax, eax);                        /* add eax, eax */
    II(0x1016476f, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10164771, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10164774, 0x3)   mov(eax, memd_a32(ds, eax + 0x8));    /* mov eax, [eax+0x8] */
    II(0x10164777, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x10164779, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1016477c, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1016477f, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10164781, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10164782, 0x1)   popd(edi);                            /* pop edi */
    II(0x10164783, 0x1)   popd(esi);                            /* pop esi */
    II(0x10164784, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10164785, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10164786, 0x1)   retd();                               /* ret */
FUNC_END

