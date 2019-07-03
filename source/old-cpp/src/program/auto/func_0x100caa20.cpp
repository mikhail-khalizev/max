FUNC_BEGIN(0x100caa20, 0x9ffb2b69932e6995, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0xc7, 0x45, 0xfc, 0, 0, 0, 0, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100caa20, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100caa21, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100caa22, 0x1)   pushd(edx);                           /* push edx */
    II(0x100caa23, 0x1)   pushd(esi);                           /* push esi */
    II(0x100caa24, 0x1)   pushd(edi);                           /* push edi */
    II(0x100caa25, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100caa26, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100caa28, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100caa2e, 0x7)   mov(memd_a32(ss, ebp - 0x4), 0);      /* mov dword [ebp-0x4], 0x0 */
    II(0x100caa35, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100caa38, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100caa3a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100caa3b, 0x1)   popd(edi);                            /* pop edi */
    II(0x100caa3c, 0x1)   popd(esi);                            /* pop esi */
    II(0x100caa3d, 0x1)   popd(edx);                            /* pop edx */
    II(0x100caa3e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100caa3f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100caa40, 0x1)   retd();                               /* ret */
FUNC_END

