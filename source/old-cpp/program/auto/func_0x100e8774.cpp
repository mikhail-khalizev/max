FUNC_BEGIN(0x100e8774, 0xc2d05286078bff24, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xd4, 0xd5, 0x7, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x40, 0xc, 0x8b, 0x55, 0xfc, 0x66, 0x2b, 0x42, 0x4, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100e8774, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100e8779, 0x5)   calld(sys_check_available_stack_size, 0x7d5d4); /* call 0x10165d52 */
    II(0x100e877e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e877f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e8780, 0x1)   pushd(edx);                           /* push edx */
    II(0x100e8781, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e8782, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e8783, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e8784, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e8786, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100e878c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100e878f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100e8792, 0x4)   mov(ax, memw_a32(ds, eax + 0xc));     /* mov ax, [eax+0xc] */
    II(0x100e8796, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100e8799, 0x4)   sub(ax, memw_a32(ds, edx + 0x4));     /* sub ax, [edx+0x4] */
    II(0x100e879d, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100e87a0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100e87a3, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e87a5, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e87a6, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e87a7, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e87a8, 0x1)   popd(edx);                            /* pop edx */
    II(0x100e87a9, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e87aa, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e87ab, 0x1)   retd();                               /* ret */
FUNC_END

