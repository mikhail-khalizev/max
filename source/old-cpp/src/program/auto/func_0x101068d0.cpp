FUNC_BEGIN(0x101068d0, 0xb353beabb3a2f01a, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x78, 0xf4, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xc7, 0x80, 0x84, 0, 0, 0, 0, 0, 0, 0, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101068d0, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x101068d5, 0x5)   calld(sys_check_available_stack_size, 0x5f478); /* call 0x10165d52 */
    II(0x101068da, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101068db, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101068dc, 0x1)   pushd(edx);                           /* push edx */
    II(0x101068dd, 0x1)   pushd(esi);                           /* push esi */
    II(0x101068de, 0x1)   pushd(edi);                           /* push edi */
    II(0x101068df, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101068e0, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101068e2, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x101068e8, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x101068eb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101068ee, 0xa)   mov(memd_a32(ds, eax + 0x84), 0);     /* mov dword [eax+0x84], 0x0 */
    II(0x101068f8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101068fb, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x101068fe, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10106901, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10106903, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10106904, 0x1)   popd(edi);                            /* pop edi */
    II(0x10106905, 0x1)   popd(esi);                            /* pop esi */
    II(0x10106906, 0x1)   popd(edx);                            /* pop edx */
    II(0x10106907, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10106908, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10106909, 0x1)   retd();                               /* ret */
FUNC_END

