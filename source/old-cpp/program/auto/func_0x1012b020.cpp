FUNC_BEGIN(0x1012b020, 0x8ac9374948286826, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x28, 0xad, 0x3, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc6, 0x5, 0x1c, 0x5c, 0x1c, 0x10, 0x29, 0x8b, 0x45, 0xfc, 0xe8, 0xa, 0xb1, 0xf4, 0xff, 0x66, 0xa3, 0x1d, 0x5c, 0x1c, 0x10, 0xb8, 0x4, 0, 0, 0, 0xe8, 0x8f, 0xab, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1012b020, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1012b025, 0x5)   calld(sys_check_available_stack_size, 0x3ad28); /* call 0x10165d52 */
    II(0x1012b02a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1012b02b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1012b02c, 0x1)   pushd(edx);                           /* push edx */
    II(0x1012b02d, 0x1)   pushd(esi);                           /* push esi */
    II(0x1012b02e, 0x1)   pushd(edi);                           /* push edi */
    II(0x1012b02f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1012b030, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1012b032, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1012b038, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1012b03b, 0x7)   mov(memb_a32(ds, 0x101c5c1c), 0x29);  /* mov byte [0x101c5c1c], 0x29 */
    II(0x1012b042, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1012b045, 0x5)   calld(0x10076154, -0xb4ef6);          /* call 0x10076154 */
    II(0x1012b04a, 0x6)   mov(memw_a32(ds, 0x101c5c1d), ax);    /* mov [0x101c5c1d], ax */
    II(0x1012b050, 0x5)   mov(eax, 0x4);                        /* mov eax, 0x4 */
    II(0x1012b055, 0x5)   calld(0x10125be9, -0x5471);           /* call 0x10125be9 */
    II(0x1012b05a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1012b05c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1012b05d, 0x1)   popd(edi);                            /* pop edi */
    II(0x1012b05e, 0x1)   popd(esi);                            /* pop esi */
    II(0x1012b05f, 0x1)   popd(edx);                            /* pop edx */
    II(0x1012b060, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1012b061, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1012b062, 0x1)   retd();                               /* ret */
FUNC_END

