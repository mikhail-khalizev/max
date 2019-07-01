FUNC_BEGIN(0x1007cb67, 0x33f2bbe84b2b7366, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xe1, 0x91, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x46, 0, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1007cb67, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1007cb6c, 0x5)   calld(sys_check_available_stack_size, 0xe91e1); /* call 0x10165d52 */
    II(0x1007cb71, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1007cb72, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1007cb73, 0x1)   pushd(edx);                           /* push edx */
    II(0x1007cb74, 0x1)   pushd(esi);                           /* push esi */
    II(0x1007cb75, 0x1)   pushd(edi);                           /* push edi */
    II(0x1007cb76, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1007cb77, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1007cb79, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1007cb7f, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1007cb82, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1007cb85, 0x5)   calld(0x1007cbd0, 0x46);              /* call 0x1007cbd0 */
    II(0x1007cb8a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1007cb8c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1007cb8d, 0x1)   popd(edi);                            /* pop edi */
    II(0x1007cb8e, 0x1)   popd(esi);                            /* pop esi */
    II(0x1007cb8f, 0x1)   popd(edx);                            /* pop edx */
    II(0x1007cb90, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1007cb91, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1007cb92, 0x1)   retd();                               /* ret */
FUNC_END

