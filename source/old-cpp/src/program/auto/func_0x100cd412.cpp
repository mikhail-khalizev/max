FUNC_BEGIN(0x100cd412, 0xa7bb4a2be9828bda, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x36, 0x89, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc6, 0x45, 0xf8, 0x2f, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100cd412, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100cd417, 0x5)   calld(sys_check_available_stack_size, 0x98936); /* call 0x10165d52 */
    II(0x100cd41c, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cd41d, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cd41e, 0x1)   pushd(edx);                           /* push edx */
    II(0x100cd41f, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cd420, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cd421, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cd422, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cd424, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100cd42a, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100cd42d, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x2f);   /* mov byte [ebp-0x8], 0x2f */
    II(0x100cd431, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x100cd434, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cd436, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cd437, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cd438, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cd439, 0x1)   popd(edx);                            /* pop edx */
    II(0x100cd43a, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cd43b, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cd43c, 0x1)   retd();                               /* ret */
FUNC_END

