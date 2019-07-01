FUNC_BEGIN(0x100d5250, 0x9f7c4601e0d9ccd0, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0xba, 0xa8, 0x35, 0x1c, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0xa, 0xfb, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100d5250, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100d5251, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100d5252, 0x1)   pushd(edx);                           /* push edx */
    II(0x100d5253, 0x1)   pushd(esi);                           /* push esi */
    II(0x100d5254, 0x1)   pushd(edi);                           /* push edi */
    II(0x100d5255, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100d5256, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100d5258, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100d525e, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100d5261, 0x5)   mov(edx, 0x101c35a8);                 /* mov edx, 0x101c35a8 */
//    II(0x100d5266, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d5269, 0x5)   calld(0x100d4d78, -0x4f6);            /* call 0x100d4d78 */
    II(0x100d526e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d5271, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100d5273, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100d5274, 0x1)   popd(edi);                            /* pop edi */
    II(0x100d5275, 0x1)   popd(esi);                            /* pop esi */
    II(0x100d5276, 0x1)   popd(edx);                            /* pop edx */
    II(0x100d5277, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100d5278, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100d5279, 0x1)   retd();                               /* ret */
FUNC_END

