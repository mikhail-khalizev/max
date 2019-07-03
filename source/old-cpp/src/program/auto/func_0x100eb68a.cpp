FUNC_BEGIN(0x100eb68a, 0x8b9d47bc5e9a93a3, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xbe, 0xa6, 0x7, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x50, 0x23, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x1f, 0xe8, 0x19, 0xa8, 0x7, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100eb68a, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100eb68f, 0x5)   calld(sys_check_available_stack_size, 0x7a6be); /* call 0x10165d52 */
    II(0x100eb694, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100eb695, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100eb696, 0x1)   pushd(edx);                           /* push edx */
    II(0x100eb697, 0x1)   pushd(esi);                           /* push esi */
    II(0x100eb698, 0x1)   pushd(edi);                           /* push edi */
    II(0x100eb699, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100eb69a, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100eb69c, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100eb6a2, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100eb6a5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100eb6a8, 0x3)   mov(edx, memd_a32(ds, eax + 0x23));   /* mov edx, [eax+0x23] */
//    II(0x100eb6ab, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100eb6ae, 0x3)   mov(eax, memd_a32(ds, eax + 0x1f));   /* mov eax, [eax+0x1f] */
    II(0x100eb6b1, 0x5)   calld(sys_strcpy, 0x7a819);           /* call 0x10165ecf */
    II(0x100eb6b6, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100eb6b8, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100eb6b9, 0x1)   popd(edi);                            /* pop edi */
    II(0x100eb6ba, 0x1)   popd(esi);                            /* pop esi */
    II(0x100eb6bb, 0x1)   popd(edx);                            /* pop edx */
    II(0x100eb6bc, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100eb6bd, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100eb6be, 0x1)   retd();                               /* ret */
FUNC_END

