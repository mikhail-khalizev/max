FUNC_BEGIN(0x100cbf40, 0xf4203ea18ccfa1b4, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x8, 0x9e, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x2, 0x8b, 0x45, 0xf8, 0xff, 0x52, 0x3c, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100cbf40, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100cbf45, 0x5)   calld(sys_check_available_stack_size, 0x99e08); /* call 0x10165d52 */
    II(0x100cbf4a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cbf4b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cbf4c, 0x1)   pushd(edx);                           /* push edx */
    II(0x100cbf4d, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cbf4e, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cbf4f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cbf50, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cbf52, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100cbf58, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100cbf5b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cbf5e, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100cbf61, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100cbf64, 0x3)   mov(edx, memd_a32(ds, eax + 0x2));    /* mov edx, [eax+0x2] */
//    II(0x100cbf67, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100cbf6a, 0x3)   calld_abs(memd_a32(ds, edx + 0x3c));  /* call dword near [edx+0x3c] */
    II(0x100cbf6d, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cbf6f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cbf70, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cbf71, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cbf72, 0x1)   popd(edx);                            /* pop edx */
    II(0x100cbf73, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cbf74, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cbf75, 0x1)   retd();                               /* ret */
FUNC_END

