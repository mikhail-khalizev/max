FUNC_BEGIN(0x100f4ab2, 0x67b4d2235b742c4, 0x20, ({0x68, 0x1c, 0, 0, 0, 0xe8, 0x96, 0x12, 0x7, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0, 0, 0, 0, 0x31, 0xd2, 0xa1, 0x6f, 0x87, 0x1b, 0x10, 0xe8, 0x9d, 0xb0, 0xfd, 0xff, 0xc6, 0x5, 0x11, 0x39, 0x1c, 0x10, 0x1, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100f4ab2, 0x5)   pushd(0x1c);                          /* push dword 0x1c */
    II(0x100f4ab7, 0x5)   calld(sys_check_available_stack_size, 0x71296); /* call 0x10165d52 */
    II(0x100f4abc, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100f4abd, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100f4abe, 0x1)   pushd(edx);                           /* push edx */
    II(0x100f4abf, 0x1)   pushd(esi);                           /* push esi */
    II(0x100f4ac0, 0x1)   pushd(edi);                           /* push edi */
    II(0x100f4ac1, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100f4ac2, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100f4ac4, 0x6)   sub(esp, 0);                          /* sub esp, 0x0 */
    II(0x100f4aca, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100f4acc, 0x5)   mov(eax, memd_a32(ds, 0x101b876f));   /* mov eax, [0x101b876f] */
    II(0x100f4ad1, 0x5)   calld(0x100cfb73, -0x24f63);          /* call 0x100cfb73 */
    II(0x100f4ad6, 0x7)   mov(memb_a32(ds, 0x101c3911), 0x1);   /* mov byte [0x101c3911], 0x1 */
    II(0x100f4add, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100f4ade, 0x1)   popd(edi);                            /* pop edi */
    II(0x100f4adf, 0x1)   popd(esi);                            /* pop esi */
    II(0x100f4ae0, 0x1)   popd(edx);                            /* pop edx */
    II(0x100f4ae1, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100f4ae2, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100f4ae3, 0x1)   retd();                               /* ret */
FUNC_END

