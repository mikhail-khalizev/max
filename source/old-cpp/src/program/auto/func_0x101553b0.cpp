FUNC_BEGIN(0x101553b0, 0xd23dd9106cf95dc9, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x98, 0x9, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101553b0, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x101553b5, 0x5)   calld(sys_check_available_stack_size, 0x10998); /* call 0x10165d52 */
    II(0x101553ba, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101553bb, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101553bc, 0x1)   pushd(edx);                           /* push edx */
    II(0x101553bd, 0x1)   pushd(esi);                           /* push esi */
    II(0x101553be, 0x1)   pushd(edi);                           /* push edi */
    II(0x101553bf, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101553c0, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101553c2, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x101553c8, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x101553cb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101553ce, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x101553d0, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x101553d3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x101553d6, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101553d8, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101553d9, 0x1)   popd(edi);                            /* pop edi */
    II(0x101553da, 0x1)   popd(esi);                            /* pop esi */
    II(0x101553db, 0x1)   popd(edx);                            /* pop edx */
    II(0x101553dc, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101553dd, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101553de, 0x1)   retd();                               /* ret */
FUNC_END

