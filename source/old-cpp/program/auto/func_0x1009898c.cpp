FUNC_BEGIN(0x1009898c, 0xeeeab5d72a7cd448, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xbc, 0xd3, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc6, 0x45, 0xf8, 0x8, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1009898c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10098991, 0x5)   calld(sys_check_available_stack_size, 0xcd3bc); /* call 0x10165d52 */
    II(0x10098996, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10098997, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10098998, 0x1)   pushd(edx);                           /* push edx */
    II(0x10098999, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009899a, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009899b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009899c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009899e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100989a4, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100989a7, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x8);    /* mov byte [ebp-0x8], 0x8 */
    II(0x100989ab, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x100989ae, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100989b0, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100989b1, 0x1)   popd(edi);                            /* pop edi */
    II(0x100989b2, 0x1)   popd(esi);                            /* pop esi */
    II(0x100989b3, 0x1)   popd(edx);                            /* pop edx */
    II(0x100989b4, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100989b5, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100989b6, 0x1)   retd();                               /* ret */
FUNC_END

