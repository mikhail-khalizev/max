FUNC_BEGIN(0x1009caf8, 0x5167c8d86e856c49, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x50, 0x92, 0xc, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0xf5, 0xe8, 0xfe, 0xff, 0x83, 0xc0, 0x6, 0xe8, 0x71, 0, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1009caf8, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1009cafd, 0x5)   calld(sys_check_available_stack_size, 0xc9250); /* call 0x10165d52 */
    II(0x1009cb02, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1009cb03, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1009cb04, 0x1)   pushd(edx);                           /* push edx */
    II(0x1009cb05, 0x1)   pushd(esi);                           /* push esi */
    II(0x1009cb06, 0x1)   pushd(edi);                           /* push edi */
    II(0x1009cb07, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1009cb08, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1009cb0a, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1009cb10, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1009cb13, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1009cb16, 0x5)   calld(0x1008b410, -0x1170b);          /* call 0x1008b410 */
    II(0x1009cb1b, 0x3)   add(eax, 0x6);                        /* add eax, 0x6 */
    II(0x1009cb1e, 0x5)   calld(0x1009cb94, 0x71);              /* call 0x1009cb94 */
    II(0x1009cb23, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1009cb25, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1009cb26, 0x1)   popd(edi);                            /* pop edi */
    II(0x1009cb27, 0x1)   popd(esi);                            /* pop esi */
    II(0x1009cb28, 0x1)   popd(edx);                            /* pop edx */
    II(0x1009cb29, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1009cb2a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1009cb2b, 0x1)   retd();                               /* ret */
FUNC_END

