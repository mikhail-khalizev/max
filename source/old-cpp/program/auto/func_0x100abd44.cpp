FUNC_BEGIN(0x100abd44, 0x904a91eaecb80508, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x4, 0xa0, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0x5, 0xf0, 0x8, 0, 0x88, 0x45, 0xf8, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100abd44, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100abd49, 0x5)   calld(sys_check_available_stack_size, 0xba004); /* call 0x10165d52 */
    II(0x100abd4e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100abd4f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100abd50, 0x1)   pushd(edx);                           /* push edx */
    II(0x100abd51, 0x1)   pushd(esi);                           /* push esi */
    II(0x100abd52, 0x1)   pushd(edi);                           /* push edi */
    II(0x100abd53, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100abd54, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100abd56, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100abd5c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100abd5f, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100abd61, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100abd64, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x100abd67, 0x5)   calld(0x1013ad71, 0x8f005);           /* call 0x1013ad71 */
    II(0x100abd6c, 0x3)   mov(memb_a32(ss, ebp - 0x8), al);     /* mov [ebp-0x8], al */
//    II(0x100abd6f, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x100abd72, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100abd74, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100abd75, 0x1)   popd(edi);                            /* pop edi */
    II(0x100abd76, 0x1)   popd(esi);                            /* pop esi */
    II(0x100abd77, 0x1)   popd(edx);                            /* pop edx */
    II(0x100abd78, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100abd79, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100abd7a, 0x1)   retd();                               /* ret */
FUNC_END

