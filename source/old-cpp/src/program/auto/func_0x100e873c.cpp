FUNC_BEGIN(0x100e873c, 0x1eedbf59b989ea3b, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xc, 0xd6, 0x7, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x40, 0x10, 0x8b, 0x55, 0xfc, 0x66, 0x2b, 0x42, 0x8, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100e873c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100e8741, 0x5)   calld(sys_check_available_stack_size, 0x7d60c); /* call 0x10165d52 */
    II(0x100e8746, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e8747, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e8748, 0x1)   pushd(edx);                           /* push edx */
    II(0x100e8749, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e874a, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e874b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e874c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e874e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100e8754, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100e8757, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100e875a, 0x4)   mov(ax, memw_a32(ds, eax + 0x10));    /* mov ax, [eax+0x10] */
    II(0x100e875e, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100e8761, 0x4)   sub(ax, memw_a32(ds, edx + 0x8));     /* sub ax, [edx+0x8] */
    II(0x100e8765, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100e8768, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100e876b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e876d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e876e, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e876f, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e8770, 0x1)   popd(edx);                            /* pop edx */
    II(0x100e8771, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e8772, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e8773, 0x1)   retd();                               /* ret */
FUNC_END

