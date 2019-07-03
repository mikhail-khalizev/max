FUNC_BEGIN(0x10120a90, 0xc00a1f728ff12eac, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0xc6, 0x45, 0xfc, 0x1, 0x8a, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10120a90, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10120a91, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10120a92, 0x1)   pushd(edx);                           /* push edx */
    II(0x10120a93, 0x1)   pushd(esi);                           /* push esi */
    II(0x10120a94, 0x1)   pushd(edi);                           /* push edi */
    II(0x10120a95, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10120a96, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10120a98, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10120a9e, 0x4)   mov(memb_a32(ss, ebp - 0x4), 0x1);    /* mov byte [ebp-0x4], 0x1 */
    II(0x10120aa2, 0x3)   mov(al, memb_a32(ss, ebp - 0x4));     /* mov al, [ebp-0x4] */
    II(0x10120aa5, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10120aa7, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10120aa8, 0x1)   popd(edi);                            /* pop edi */
    II(0x10120aa9, 0x1)   popd(esi);                            /* pop esi */
    II(0x10120aaa, 0x1)   popd(edx);                            /* pop edx */
    II(0x10120aab, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10120aac, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10120aad, 0x1)   retd();                               /* ret */
FUNC_END

