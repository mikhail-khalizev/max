FUNC_BEGIN(0x100eacb0, 0x67c41ab1614cb0a0, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x98, 0xb0, 0x7, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xe8, 0xfc, 0x1, 0, 0, 0xf, 0xbf, 0xd0, 0x8b, 0x45, 0xfc, 0xe8, 0x9d, 0x1, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100eacb0, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100eacb5, 0x5)   calld(sys_check_available_stack_size, 0x7b098); /* call 0x10165d52 */
    II(0x100eacba, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100eacbb, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100eacbc, 0x1)   pushd(edx);                           /* push edx */
    II(0x100eacbd, 0x1)   pushd(esi);                           /* push esi */
    II(0x100eacbe, 0x1)   pushd(edi);                           /* push edi */
    II(0x100eacbf, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100eacc0, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100eacc2, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100eacc8, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100eaccb, 0x5)   calld(0x100eaecc, 0x1fc);             /* call 0x100eaecc */
    II(0x100eacd0, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x100eacd3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100eacd6, 0x5)   calld(0x100eae78, 0x19d);             /* call 0x100eae78 */
    II(0x100eacdb, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100eacde, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100eace1, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100eace3, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100eace4, 0x1)   popd(edi);                            /* pop edi */
    II(0x100eace5, 0x1)   popd(esi);                            /* pop esi */
    II(0x100eace6, 0x1)   popd(edx);                            /* pop edx */
    II(0x100eace7, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100eace8, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100eace9, 0x1)   retd();                               /* ret */
FUNC_END

