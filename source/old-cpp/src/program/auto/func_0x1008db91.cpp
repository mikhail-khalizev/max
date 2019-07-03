FUNC_BEGIN(0x1008db91, 0x260494161ec36e78, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xb7, 0x81, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x8a, 0x3, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1008db91, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1008db96, 0x5)   calld(sys_check_available_stack_size, 0xd81b7); /* call 0x10165d52 */
    II(0x1008db9b, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008db9c, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008db9d, 0x1)   pushd(edx);                           /* push edx */
    II(0x1008db9e, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008db9f, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008dba0, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008dba1, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008dba3, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1008dba9, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1008dbac, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008dbaf, 0x5)   calld(0x1008df3e, 0x38a);             /* call 0x1008df3e */
    II(0x1008dbb4, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008dbb6, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008dbb7, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008dbb8, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008dbb9, 0x1)   popd(edx);                            /* pop edx */
    II(0x1008dbba, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008dbbb, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008dbbc, 0x1)   retd();                               /* ret */
FUNC_END

