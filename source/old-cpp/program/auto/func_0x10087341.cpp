FUNC_BEGIN(0x10087341, 0xd03fcb44615e65ed, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x7, 0xea, 0xd, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xc6, 0x45, 0xf4, 0, 0x8a, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10087341, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10087346, 0x5)   calld(sys_check_available_stack_size, 0xdea07); /* call 0x10165d52 */
    II(0x1008734b, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008734c, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008734d, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008734e, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008734f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10087350, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10087352, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10087358, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1008735b, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x1008735e, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0);      /* mov byte [ebp-0xc], 0x0 */
    II(0x10087362, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x10087365, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10087367, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10087368, 0x1)   popd(edi);                            /* pop edi */
    II(0x10087369, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008736a, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008736b, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008736c, 0x1)   retd();                               /* ret */
FUNC_END

