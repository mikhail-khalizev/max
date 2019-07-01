FUNC_BEGIN(0x101153b8, 0xfdcd673f6f179137, 0x20, ({0x68, 0x18, 0, 0, 0, 0xe8, 0x90, 0x9, 0x5, 0, 0x53, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x8b, 0x45, 0x14, 0xe8, 0x8, 0x5c, 0x5, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5b, 0xc3}))
    II(0x101153b8, 0x5)   pushd(0x18);                          /* push dword 0x18 */
    II(0x101153bd, 0x5)   calld(sys_check_available_stack_size, 0x50990); /* call 0x10165d52 */
    II(0x101153c2, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101153c3, 0x1)   pushd(esi);                           /* push esi */
    II(0x101153c4, 0x1)   pushd(edi);                           /* push edi */
    II(0x101153c5, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101153c6, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101153c8, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x101153ce, 0x3)   mov(eax, memd_a32(ss, ebp + 0x14));   /* mov eax, [ebp+0x14] */
    II(0x101153d1, 0x5)   calld(sys_malloc, 0x55c08);           /* call 0x1016afde */
    II(0x101153d6, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x101153d9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101153dc, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101153de, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101153df, 0x1)   popd(edi);                            /* pop edi */
    II(0x101153e0, 0x1)   popd(esi);                            /* pop esi */
    II(0x101153e1, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101153e2, 0x1)   retd();                               /* ret */
FUNC_END

