FUNC_BEGIN(0x100b46df, 0x437ad9e08eac84a9, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x69, 0x16, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x2, 0x8b, 0x45, 0xf8, 0xff, 0x52, 0x3c, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100b46df, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100b46e4, 0x5)   calld(sys_check_available_stack_size, 0xb1669); /* call 0x10165d52 */
    II(0x100b46e9, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b46ea, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b46eb, 0x1)   pushd(edx);                           /* push edx */
    II(0x100b46ec, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b46ed, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b46ee, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b46ef, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b46f1, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100b46f7, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100b46fa, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b46fd, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100b4700, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b4703, 0x3)   mov(edx, memd_a32(ds, eax + 0x2));    /* mov edx, [eax+0x2] */
//    II(0x100b4706, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b4709, 0x3)   calld_abs(memd_a32(ds, edx + 0x3c));  /* call dword near [edx+0x3c] */
    II(0x100b470c, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b470e, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b470f, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b4710, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b4711, 0x1)   popd(edx);                            /* pop edx */
    II(0x100b4712, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b4713, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b4714, 0x1)   retd();                               /* ret */
FUNC_END

