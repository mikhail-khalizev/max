FUNC_BEGIN(0x10106a9c, 0xfa19632ec1092c6d, 0x20, ({0x68, 0x1c, 0, 0, 0, 0xe8, 0xac, 0xf2, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0, 0, 0, 0, 0xe8, 0xac, 0x1, 0, 0, 0xe8, 0xfa, 0x1, 0, 0, 0xe8, 0xef, 0x2, 0, 0, 0xe8, 0xbe, 0x3, 0, 0, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10106a9c, 0x5)   pushd(0x1c);                          /* push dword 0x1c */
    II(0x10106aa1, 0x5)   calld(sys_check_available_stack_size, 0x5f2ac); /* call 0x10165d52 */
    II(0x10106aa6, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10106aa7, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10106aa8, 0x1)   pushd(edx);                           /* push edx */
    II(0x10106aa9, 0x1)   pushd(esi);                           /* push esi */
    II(0x10106aaa, 0x1)   pushd(edi);                           /* push edi */
    II(0x10106aab, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10106aac, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10106aae, 0x6)   sub(esp, 0);                          /* sub esp, 0x0 */
    II(0x10106ab4, 0x5)   calld(0x10106c65, 0x1ac);             /* call 0x10106c65 */
    II(0x10106ab9, 0x5)   calld(0x10106cb8, 0x1fa);             /* call 0x10106cb8 */
    II(0x10106abe, 0x5)   calld(0x10106db2, 0x2ef);             /* call 0x10106db2 */
    II(0x10106ac3, 0x5)   calld(0x10106e86, 0x3be);             /* call 0x10106e86 */
    II(0x10106ac8, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10106ac9, 0x1)   popd(edi);                            /* pop edi */
    II(0x10106aca, 0x1)   popd(esi);                            /* pop esi */
    II(0x10106acb, 0x1)   popd(edx);                            /* pop edx */
    II(0x10106acc, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10106acd, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10106ace, 0x1)   retd();                               /* ret */
FUNC_END

