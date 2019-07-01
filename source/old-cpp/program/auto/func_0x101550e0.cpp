FUNC_BEGIN(0x101550e0, 0x65f1c687112c731f, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x68, 0xc, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xc6, 0x80, 0x9e, 0, 0, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101550e0, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x101550e5, 0x5)   calld(sys_check_available_stack_size, 0x10c68); /* call 0x10165d52 */
    II(0x101550ea, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101550eb, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101550ec, 0x1)   pushd(edx);                           /* push edx */
    II(0x101550ed, 0x1)   pushd(esi);                           /* push esi */
    II(0x101550ee, 0x1)   pushd(edi);                           /* push edi */
    II(0x101550ef, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101550f0, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101550f2, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x101550f8, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x101550fb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101550fe, 0x7)   mov(memb_a32(ds, eax + 0x9e), 0);     /* mov byte [eax+0x9e], 0x0 */
    II(0x10155105, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10155107, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10155108, 0x1)   popd(edi);                            /* pop edi */
    II(0x10155109, 0x1)   popd(esi);                            /* pop esi */
    II(0x1015510a, 0x1)   popd(edx);                            /* pop edx */
    II(0x1015510b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1015510c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1015510d, 0x1)   retd();                               /* ret */
FUNC_END

