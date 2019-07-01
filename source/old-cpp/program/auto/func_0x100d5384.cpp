FUNC_BEGIN(0x100d5384, 0xc00a1f728ff12eac, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0xc6, 0x45, 0xfc, 0x1, 0x8a, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100d5384, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100d5385, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100d5386, 0x1)   pushd(edx);                           /* push edx */
    II(0x100d5387, 0x1)   pushd(esi);                           /* push esi */
    II(0x100d5388, 0x1)   pushd(edi);                           /* push edi */
    II(0x100d5389, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100d538a, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100d538c, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100d5392, 0x4)   mov(memb_a32(ss, ebp - 0x4), 0x1);    /* mov byte [ebp-0x4], 0x1 */
    II(0x100d5396, 0x3)   mov(al, memb_a32(ss, ebp - 0x4));     /* mov al, [ebp-0x4] */
    II(0x100d5399, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100d539b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100d539c, 0x1)   popd(edi);                            /* pop edi */
    II(0x100d539d, 0x1)   popd(esi);                            /* pop esi */
    II(0x100d539e, 0x1)   popd(edx);                            /* pop edx */
    II(0x100d539f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100d53a0, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100d53a1, 0x1)   retd();                               /* ret */
FUNC_END

