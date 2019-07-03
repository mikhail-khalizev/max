FUNC_BEGIN(0x100c9ff0, 0x44a87f152d802364, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x58, 0xbd, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xe8, 0xcc, 0x9, 0, 0, 0xf, 0xbf, 0xd0, 0x8b, 0x45, 0xfc, 0xe8, 0x59, 0x9, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100c9ff0, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100c9ff5, 0x5)   calld(sys_check_available_stack_size, 0x9bd58); /* call 0x10165d52 */
    II(0x100c9ffa, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100c9ffb, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100c9ffc, 0x1)   pushd(edx);                           /* push edx */
    II(0x100c9ffd, 0x1)   pushd(esi);                           /* push esi */
    II(0x100c9ffe, 0x1)   pushd(edi);                           /* push edi */
    II(0x100c9fff, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ca000, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ca002, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100ca008, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100ca00b, 0x5)   calld(0x100ca9dc, 0x9cc);             /* call 0x100ca9dc */
    II(0x100ca010, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x100ca013, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100ca016, 0x5)   calld(0x100ca974, 0x959);             /* call 0x100ca974 */
    II(0x100ca01b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100ca01e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ca021, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ca023, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ca024, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ca025, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ca026, 0x1)   popd(edx);                            /* pop edx */
    II(0x100ca027, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ca028, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ca029, 0x1)   retd();                               /* ret */
FUNC_END

