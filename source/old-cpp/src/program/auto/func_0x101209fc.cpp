FUNC_BEGIN(0x101209fc, 0x621413190c039cfd, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x4c, 0x53, 0x4, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8a, 0x40, 0x14, 0x88, 0x45, 0xf8, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101209fc, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10120a01, 0x5)   calld(sys_check_available_stack_size, 0x4534c); /* call 0x10165d52 */
    II(0x10120a06, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10120a07, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10120a08, 0x1)   pushd(edx);                           /* push edx */
    II(0x10120a09, 0x1)   pushd(esi);                           /* push esi */
    II(0x10120a0a, 0x1)   pushd(edi);                           /* push edi */
    II(0x10120a0b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10120a0c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10120a0e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10120a14, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10120a17, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10120a1a, 0x3)   mov(al, memb_a32(ds, eax + 0x14));    /* mov al, [eax+0x14] */
    II(0x10120a1d, 0x3)   mov(memb_a32(ss, ebp - 0x8), al);     /* mov [ebp-0x8], al */
//    II(0x10120a20, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x10120a23, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10120a25, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10120a26, 0x1)   popd(edi);                            /* pop edi */
    II(0x10120a27, 0x1)   popd(esi);                            /* pop esi */
    II(0x10120a28, 0x1)   popd(edx);                            /* pop edx */
    II(0x10120a29, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10120a2a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10120a2b, 0x1)   retd();                               /* ret */
FUNC_END

