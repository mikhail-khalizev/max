FUNC_BEGIN(0x1008adf8, 0x825c899da1330924, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x50, 0xaf, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x15, 0xbe, 0xfe, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1008adf8, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1008adfd, 0x5)   calld(sys_check_available_stack_size, 0xdaf50); /* call 0x10165d52 */
    II(0x1008ae02, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008ae03, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008ae04, 0x1)   pushd(edx);                           /* push edx */
    II(0x1008ae05, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008ae06, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008ae07, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008ae08, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008ae0a, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1008ae10, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1008ae13, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008ae16, 0x5)   calld(0x10076c30, -0x141eb);          /* call 0x10076c30 */
    II(0x1008ae1b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1008ae1e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008ae21, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008ae23, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008ae24, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008ae25, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008ae26, 0x1)   popd(edx);                            /* pop edx */
    II(0x1008ae27, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008ae28, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008ae29, 0x1)   retd();                               /* ret */
FUNC_END

