FUNC_BEGIN(0x100cac88, 0x699373c84b5b277, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xc0, 0xb0, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100cac88, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100cac8d, 0x5)   calld(sys_check_available_stack_size, 0x9b0c0); /* call 0x10165d52 */
    II(0x100cac92, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cac93, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cac94, 0x1)   pushd(edx);                           /* push edx */
    II(0x100cac95, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cac96, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cac97, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cac98, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cac9a, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100caca0, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100caca3, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100caca6, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x100caca8, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100cacab, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100cacae, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cacb0, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cacb1, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cacb2, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cacb3, 0x1)   popd(edx);                            /* pop edx */
    II(0x100cacb4, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cacb5, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cacb6, 0x1)   retd();                               /* ret */
FUNC_END

