FUNC_BEGIN(0x1009f580, 0xa591d4cf4d50b9a0, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xc8, 0x67, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x17, 0xe8, 0xcb, 0x6f, 0xfd, 0xff, 0xe8, 0x3f, 0x32, 0xb, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1009f580, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1009f585, 0x5)   calld(sys_check_available_stack_size, 0xc67c8); /* call 0x10165d52 */
    II(0x1009f58a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009f58b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009f58c, 0x1)   pushd(edx);                           /* push edx */
    II(0x1009f58d, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009f58e, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009f58f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009f590, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009f592, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1009f598, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1009f59b, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x1009f59e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1009f5a1, 0x3)   add(eax, 0x17);                       /* add eax, 0x17 */
    II(0x1009f5a4, 0x5)   calld(0x10076574, -0x29035);          /* call 0x10076574 */
    II(0x1009f5a9, 0x5)   calld(0x101527ed, 0xb323f);           /* call 0x101527ed */
    II(0x1009f5ae, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009f5b0, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009f5b1, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009f5b2, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009f5b3, 0x1)   popd(edx);                            /* pop edx */
    II(0x1009f5b4, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009f5b5, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009f5b6, 0x1)   retd();                               /* ret */
FUNC_END

