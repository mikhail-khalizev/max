FUNC_BEGIN(sys_call_dtor_arr_v2, 0x3f2cc2910b953daf, 0x20, ({0x51, 0x56, 0x83, 0xec, 0x20, 0x89, 0xc1, 0x89, 0xd6, 0x89, 0xe2, 0xe8, 0x1, 0xbd, 0x1, 0, 0x89, 0xe2, 0x89, 0xc3, 0x31, 0xc0, 0x89, 0x74, 0x24, 0x8, 0xe8, 0xe9, 0xbe, 0x1, 0, 0x8b, 0x3, 0x8b, 0, 0x89, 0x3, 0x89, 0xc8, 0x83, 0xc4, 0x20, 0x5e, 0x59, 0xc3}))
    II(0x10165fe0, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10165fe1, 0x1)   pushd(esi);                           /* push esi */
    II(0x10165fe2, 0x3)   sub(esp, 0x20);                       /* sub esp, 0x20 */
    II(0x10165fe5, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x10165fe7, 0x2)   mov(esi, edx);                        /* mov esi, edx */
    II(0x10165fe9, 0x2)   mov(edx, esp);                        /* mov edx, esp */
    II(0x10165feb, 0x5)   calld(/* sys */ 0x10181cf1, 0x1bd01); /* call 0x10181cf1 */
    II(0x10165ff0, 0x2)   mov(edx, esp);                        /* mov edx, esp */
    II(0x10165ff2, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x10165ff4, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10165ff6, 0x4)   mov(memd_a32(ss, esp + 0x8), esi);    /* mov [esp+0x8], esi */
    II(0x10165ffa, 0x5)   calld(/* sys */ 0x10181ee8, 0x1bee9); /* call 0x10181ee8 */
    II(0x10165fff, 0x2)   mov(eax, memd_a32(ds, ebx));          /* mov eax, [ebx] */
    II(0x10166001, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10166003, 0x2)   mov(memd_a32(ds, ebx), eax);          /* mov [ebx], eax */
    II(0x10166005, 0x2)   mov(eax, ecx);                        /* mov eax, ecx */
    II(0x10166007, 0x3)   add(esp, 0x20);                       /* add esp, 0x20 */
    II(0x1016600a, 0x1)   popd(esi);                            /* pop esi */
    II(0x1016600b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1016600c, 0x1)   retd();                               /* ret */
FUNC_END

