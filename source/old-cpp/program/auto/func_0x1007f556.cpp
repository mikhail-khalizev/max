FUNC_BEGIN(0x1007f556, 0x6c988c20c73a54a5, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xf2, 0x67, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc6, 0x45, 0xf8, 0x11, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1007f556, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1007f55b, 0x5)   calld(sys_check_available_stack_size, 0xe67f2); /* call 0x10165d52 */
    II(0x1007f560, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1007f561, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1007f562, 0x1)   pushd(edx);                           /* push edx */
    II(0x1007f563, 0x1)   pushd(esi);                           /* push esi */
    II(0x1007f564, 0x1)   pushd(edi);                           /* push edi */
    II(0x1007f565, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1007f566, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1007f568, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1007f56e, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1007f571, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x11);   /* mov byte [ebp-0x8], 0x11 */
    II(0x1007f575, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x1007f578, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1007f57a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1007f57b, 0x1)   popd(edi);                            /* pop edi */
    II(0x1007f57c, 0x1)   popd(esi);                            /* pop esi */
    II(0x1007f57d, 0x1)   popd(edx);                            /* pop edx */
    II(0x1007f57e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1007f57f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1007f580, 0x1)   retd();                               /* ret */
FUNC_END

