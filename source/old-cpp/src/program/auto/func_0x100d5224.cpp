FUNC_BEGIN(0x100d5224, 0x85b962f219a9e550, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0xba, 0xa8, 0x35, 0x1c, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x36, 0xfb, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100d5224, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100d5225, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100d5226, 0x1)   pushd(edx);                           /* push edx */
    II(0x100d5227, 0x1)   pushd(esi);                           /* push esi */
    II(0x100d5228, 0x1)   pushd(edi);                           /* push edi */
    II(0x100d5229, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100d522a, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100d522c, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100d5232, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100d5235, 0x5)   mov(edx, 0x101c35a8);                 /* mov edx, 0x101c35a8 */
//    II(0x100d523a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d523d, 0x5)   calld(0x100d4d78, -0x4ca);            /* call 0x100d4d78 */
    II(0x100d5242, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d5245, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100d5247, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100d5248, 0x1)   popd(edi);                            /* pop edi */
    II(0x100d5249, 0x1)   popd(esi);                            /* pop esi */
    II(0x100d524a, 0x1)   popd(edx);                            /* pop edx */
    II(0x100d524b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100d524c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100d524d, 0x1)   retd();                               /* ret */
FUNC_END

