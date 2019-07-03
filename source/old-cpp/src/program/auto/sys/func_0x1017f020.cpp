FUNC_BEGIN(/* sys */ 0x1017f020, 0xe14e1645b9678772, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0xe8, 0xd7, 0xfd, 0xff, 0xff, 0xc7, 0x5, 0x58, 0xe5, 0x1b, 0x10, 0, 0, 0, 0, 0xc7, 0x45, 0xfc, 0, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xc9, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1017f020, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1017f021, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1017f022, 0x1)   pushd(edx);                           /* push edx */
    II(0x1017f023, 0x1)   pushd(esi);                           /* push esi */
    II(0x1017f024, 0x1)   pushd(edi);                           /* push edi */
    II(0x1017f025, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1017f026, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1017f028, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1017f02e, 0x5)   calld(/* sys */ 0x1017ee0a, -0x229);  /* call 0x1017ee0a */
    II(0x1017f033, 0xa)   mov(memd_a32(ds, 0x101be558), 0);     /* mov dword [0x101be558], 0x0 */
    II(0x1017f03d, 0x7)   mov(memd_a32(ss, ebp - 0x4), 0);      /* mov dword [ebp-0x4], 0x0 */
    II(0x1017f044, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1017f047, 0x1)   leaved();                             /* leave */
    II(0x1017f048, 0x1)   popd(edi);                            /* pop edi */
    II(0x1017f049, 0x1)   popd(esi);                            /* pop esi */
    II(0x1017f04a, 0x1)   popd(edx);                            /* pop edx */
    II(0x1017f04b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1017f04c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1017f04d, 0x1)   retd();                               /* ret */
FUNC_END

