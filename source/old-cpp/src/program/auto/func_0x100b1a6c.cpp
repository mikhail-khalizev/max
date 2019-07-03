FUNC_BEGIN(0x100b1a6c, 0x5bf2a25d553797a1, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xdc, 0x42, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x2, 0x8b, 0x45, 0xf8, 0xff, 0x52, 0x3c, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100b1a6c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100b1a71, 0x5)   calld(sys_check_available_stack_size, 0xb42dc); /* call 0x10165d52 */
    II(0x100b1a76, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b1a77, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b1a78, 0x1)   pushd(edx);                           /* push edx */
    II(0x100b1a79, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b1a7a, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b1a7b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b1a7c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b1a7e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100b1a84, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100b1a87, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b1a8a, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100b1a8d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b1a90, 0x3)   mov(edx, memd_a32(ds, eax + 0x2));    /* mov edx, [eax+0x2] */
//    II(0x100b1a93, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b1a96, 0x3)   calld_abs(memd_a32(ds, edx + 0x3c));  /* call dword near [edx+0x3c] */
    II(0x100b1a99, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b1a9b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b1a9c, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b1a9d, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b1a9e, 0x1)   popd(edx);                            /* pop edx */
    II(0x100b1a9f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b1aa0, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b1aa1, 0x1)   retd();                               /* ret */
FUNC_END

