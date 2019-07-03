FUNC_BEGIN(sys_call_dtor_arr, 0x940e0cee244b5579, 0x20, ({0x53, 0x51, 0x56, 0x85, 0xc0, 0x75, 0x4, 0x31, 0xc9, 0xeb, 0xe, 0x8d, 0x48, 0xfc, 0x8b, 0x31, 0x89, 0xd3, 0x89, 0xf2, 0xe8, 0xf, 0, 0, 0, 0x89, 0xc8, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10165fb8, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10165fb9, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10165fba, 0x1)   pushd(esi);                           /* push esi */
    II(0x10165fbb, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10165fbd, 0x2)   jnzd(0x10165fc3, 0x4);                /* jnz 0x10165fc3 */
    II(0x10165fbf, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x10165fc1, 0x2)   jmpd(0x10165fd1, 0xe);                /* jmp 0x10165fd1 */
l_0x10165fc3:
    II(0x10165fc3, 0x3)   lea(ecx, eax - 0x4);                  /* lea ecx, [eax-0x4] */
    II(0x10165fc6, 0x2)   mov(esi, memd_a32(ds, ecx));          /* mov esi, [ecx] */
    II(0x10165fc8, 0x2)   mov(ebx, edx);                        /* mov ebx, edx */
    II(0x10165fca, 0x2)   mov(edx, esi);                        /* mov edx, esi */
    II(0x10165fcc, 0x5)   calld(sys_call_dtor_arr_v2, 0xf);     /* call 0x10165fe0 */
l_0x10165fd1:
    II(0x10165fd1, 0x2)   mov(eax, ecx);                        /* mov eax, ecx */
    II(0x10165fd3, 0x1)   popd(esi);                            /* pop esi */
    II(0x10165fd4, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10165fd5, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10165fd6, 0x1)   retd();                               /* ret */
FUNC_END

