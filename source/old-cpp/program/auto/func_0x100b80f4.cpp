FUNC_BEGIN(0x100b80f4, 0xf0f0643866f2634, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x54, 0xdc, 0xa, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100b80f4, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100b80f9, 0x5)   calld(sys_check_available_stack_size, 0xadc54); /* call 0x10165d52 */
    II(0x100b80fe, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b80ff, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b8100, 0x1)   pushd(edx);                           /* push edx */
    II(0x100b8101, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b8102, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b8103, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b8104, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b8106, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100b810c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100b810f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b8112, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x100b8114, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100b8117, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b811a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b811c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b811d, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b811e, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b811f, 0x1)   popd(edx);                            /* pop edx */
    II(0x100b8120, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b8121, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b8122, 0x1)   retd();                               /* ret */
FUNC_END

