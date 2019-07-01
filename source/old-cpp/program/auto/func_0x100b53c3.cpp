FUNC_BEGIN(0x100b53c3, 0xbf6b5757a7d0f1b8, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x85, 0x9, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc6, 0x45, 0xf8, 0x18, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100b53c3, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100b53c8, 0x5)   calld(sys_check_available_stack_size, 0xb0985); /* call 0x10165d52 */
    II(0x100b53cd, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b53ce, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b53cf, 0x1)   pushd(edx);                           /* push edx */
    II(0x100b53d0, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b53d1, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b53d2, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b53d3, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b53d5, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100b53db, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100b53de, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x18);   /* mov byte [ebp-0x8], 0x18 */
    II(0x100b53e2, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x100b53e5, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b53e7, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b53e8, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b53e9, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b53ea, 0x1)   popd(edx);                            /* pop edx */
    II(0x100b53eb, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b53ec, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b53ed, 0x1)   retd();                               /* ret */
FUNC_END

