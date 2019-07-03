FUNC_BEGIN(0x100caa00, 0x1fcb14bda5493ab2, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0xc6, 0x45, 0xfc, 0, 0x8a, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100caa00, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100caa01, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100caa02, 0x1)   pushd(edx);                           /* push edx */
    II(0x100caa03, 0x1)   pushd(esi);                           /* push esi */
    II(0x100caa04, 0x1)   pushd(edi);                           /* push edi */
    II(0x100caa05, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100caa06, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100caa08, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100caa0e, 0x4)   mov(memb_a32(ss, ebp - 0x4), 0);      /* mov byte [ebp-0x4], 0x0 */
    II(0x100caa12, 0x3)   mov(al, memb_a32(ss, ebp - 0x4));     /* mov al, [ebp-0x4] */
    II(0x100caa15, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100caa17, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100caa18, 0x1)   popd(edi);                            /* pop edi */
    II(0x100caa19, 0x1)   popd(esi);                            /* pop esi */
    II(0x100caa1a, 0x1)   popd(edx);                            /* pop edx */
    II(0x100caa1b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100caa1c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100caa1d, 0x1)   retd();                               /* ret */
FUNC_END

