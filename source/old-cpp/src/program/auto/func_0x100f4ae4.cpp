FUNC_BEGIN(0x100f4ae4, 0xb065bbf621f505e9, 0x20, ({0x68, 0x1c, 0, 0, 0, 0xe8, 0x64, 0x12, 0x7, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0, 0, 0, 0, 0x31, 0xd2, 0xa1, 0x7d, 0x87, 0x1b, 0x10, 0xe8, 0x6b, 0xb0, 0xfd, 0xff, 0xc6, 0x5, 0x11, 0x39, 0x1c, 0x10, 0, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100f4ae4, 0x5)   pushd(0x1c);                          /* push dword 0x1c */
    II(0x100f4ae9, 0x5)   calld(sys_check_available_stack_size, 0x71264); /* call 0x10165d52 */
    II(0x100f4aee, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100f4aef, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100f4af0, 0x1)   pushd(edx);                           /* push edx */
    II(0x100f4af1, 0x1)   pushd(esi);                           /* push esi */
    II(0x100f4af2, 0x1)   pushd(edi);                           /* push edi */
    II(0x100f4af3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100f4af4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100f4af6, 0x6)   sub(esp, 0);                          /* sub esp, 0x0 */
    II(0x100f4afc, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100f4afe, 0x5)   mov(eax, memd_a32(ds, 0x101b877d));   /* mov eax, [0x101b877d] */
    II(0x100f4b03, 0x5)   calld(0x100cfb73, -0x24f95);          /* call 0x100cfb73 */
    II(0x100f4b08, 0x7)   mov(memb_a32(ds, 0x101c3911), 0);     /* mov byte [0x101c3911], 0x0 */
    II(0x100f4b0f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100f4b10, 0x1)   popd(edi);                            /* pop edi */
    II(0x100f4b11, 0x1)   popd(esi);                            /* pop esi */
    II(0x100f4b12, 0x1)   popd(edx);                            /* pop edx */
    II(0x100f4b13, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100f4b14, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100f4b15, 0x1)   retd();                               /* ret */
FUNC_END

