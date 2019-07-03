FUNC_BEGIN(0x101453ff, 0xbbd3f4cf54f5676d, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x49, 0x9, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x14, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101453ff, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10145404, 0x5)   calld(sys_check_available_stack_size, 0x20949); /* call 0x10165d52 */
    II(0x10145409, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1014540a, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1014540b, 0x1)   pushd(edx);                           /* push edx */
    II(0x1014540c, 0x1)   pushd(esi);                           /* push esi */
    II(0x1014540d, 0x1)   pushd(edi);                           /* push edi */
    II(0x1014540e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1014540f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10145411, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10145417, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1014541a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014541d, 0x3)   mov(eax, memd_a32(ds, eax + 0x14));   /* mov eax, [eax+0x14] */
    II(0x10145420, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10145423, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10145426, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10145428, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10145429, 0x1)   popd(edi);                            /* pop edi */
    II(0x1014542a, 0x1)   popd(esi);                            /* pop esi */
    II(0x1014542b, 0x1)   popd(edx);                            /* pop edx */
    II(0x1014542c, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1014542d, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1014542e, 0x1)   retd();                               /* ret */
FUNC_END

