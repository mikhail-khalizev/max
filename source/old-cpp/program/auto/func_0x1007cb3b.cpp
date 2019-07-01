FUNC_BEGIN(0x1007cb3b, 0xfd1ea2e5afaf83ac, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xd, 0x92, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x72, 0, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1007cb3b, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1007cb40, 0x5)   calld(sys_check_available_stack_size, 0xe920d); /* call 0x10165d52 */
    II(0x1007cb45, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1007cb46, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1007cb47, 0x1)   pushd(edx);                           /* push edx */
    II(0x1007cb48, 0x1)   pushd(esi);                           /* push esi */
    II(0x1007cb49, 0x1)   pushd(edi);                           /* push edi */
    II(0x1007cb4a, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1007cb4b, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1007cb4d, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1007cb53, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1007cb56, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1007cb59, 0x5)   calld(0x1007cbd0, 0x72);              /* call 0x1007cbd0 */
    II(0x1007cb5e, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1007cb60, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1007cb61, 0x1)   popd(edi);                            /* pop edi */
    II(0x1007cb62, 0x1)   popd(esi);                            /* pop esi */
    II(0x1007cb63, 0x1)   popd(edx);                            /* pop edx */
    II(0x1007cb64, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1007cb65, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1007cb66, 0x1)   retd();                               /* ret */
FUNC_END

