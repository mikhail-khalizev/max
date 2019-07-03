FUNC_BEGIN(0x10076bf8, 0x3d5ac348b0d10f65, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x50, 0xf1, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x4d, 0, 0, 0, 0x8d, 0x50, 0xa, 0x8b, 0x45, 0xfc, 0xe8, 0x9f, 0x40, 0xc, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10076bf8, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10076bfd, 0x5)   calld(sys_check_available_stack_size, 0xef150); /* call 0x10165d52 */
    II(0x10076c02, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10076c03, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10076c04, 0x1)   pushd(edx);                           /* push edx */
    II(0x10076c05, 0x1)   pushd(esi);                           /* push esi */
    II(0x10076c06, 0x1)   pushd(edi);                           /* push edi */
    II(0x10076c07, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10076c08, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10076c0a, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10076c10, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10076c13, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10076c16, 0x5)   calld(0x10076c68, 0x4d);              /* call 0x10076c68 */
    II(0x10076c1b, 0x3)   lea(edx, eax + 0xa);                  /* lea edx, [eax+0xa] */
    II(0x10076c1e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10076c21, 0x5)   calld(0x1013acc5, 0xc409f);           /* call 0x1013acc5 */
    II(0x10076c26, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10076c28, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10076c29, 0x1)   popd(edi);                            /* pop edi */
    II(0x10076c2a, 0x1)   popd(esi);                            /* pop esi */
    II(0x10076c2b, 0x1)   popd(edx);                            /* pop edx */
    II(0x10076c2c, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10076c2d, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10076c2e, 0x1)   retd();                               /* ret */
FUNC_END

