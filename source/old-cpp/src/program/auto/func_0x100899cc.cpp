FUNC_BEGIN(0x100899cc, 0x4e0b06028b888659, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x7c, 0xc3, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100899cc, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100899d1, 0x5)   calld(sys_check_available_stack_size, 0xdc37c); /* call 0x10165d52 */
    II(0x100899d6, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100899d7, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100899d8, 0x1)   pushd(edx);                           /* push edx */
    II(0x100899d9, 0x1)   pushd(esi);                           /* push esi */
    II(0x100899da, 0x1)   pushd(edi);                           /* push edi */
    II(0x100899db, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100899dc, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100899de, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100899e4, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100899e7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100899ea, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x100899ec, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100899ef, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100899f2, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100899f4, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100899f5, 0x1)   popd(edi);                            /* pop edi */
    II(0x100899f6, 0x1)   popd(esi);                            /* pop esi */
    II(0x100899f7, 0x1)   popd(edx);                            /* pop edx */
    II(0x100899f8, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100899f9, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100899fa, 0x1)   retd();                               /* ret */
FUNC_END

