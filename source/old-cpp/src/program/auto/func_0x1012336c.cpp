FUNC_BEGIN(0x1012336c, 0x56daaacbe7c015f1, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0xba, 0x78, 0x36, 0x1c, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0xee, 0x19, 0xfb, 0xff, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1012336c, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1012336d, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1012336e, 0x1)   pushd(edx);                           /* push edx */
    II(0x1012336f, 0x1)   pushd(esi);                           /* push esi */
    II(0x10123370, 0x1)   pushd(edi);                           /* push edi */
    II(0x10123371, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10123372, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10123374, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1012337a, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1012337d, 0x5)   mov(edx, 0x101c3678);                 /* mov edx, 0x101c3678 */
//    II(0x10123382, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10123385, 0x5)   calld(0x100d4d78, -0x4e612);          /* call 0x100d4d78 */
    II(0x1012338a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1012338d, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1012338f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10123390, 0x1)   popd(edi);                            /* pop edi */
    II(0x10123391, 0x1)   popd(esi);                            /* pop esi */
    II(0x10123392, 0x1)   popd(edx);                            /* pop edx */
    II(0x10123393, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10123394, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10123395, 0x1)   retd();                               /* ret */
FUNC_END

