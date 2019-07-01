FUNC_BEGIN(my__get_unit, 0x577c7f50d271caa, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x2c, 0xdd, 0xa, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x6, 0xe8, 0x8e, 0xe5, 0xfb, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100b801c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100b8021, 0x5)   calld(sys_check_available_stack_size, 0xadd2c); /* call 0x10165d52 */
    II(0x100b8026, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b8027, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b8028, 0x1)   pushd(edx);                           /* push edx */
    II(0x100b8029, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b802a, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b802b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b802c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b802e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100b8034, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100b8037, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b803a, 0x3)   add(eax, 0x6);                        /* add eax, 0x6 */
    II(0x100b803d, 0x5)   calld(0x100765d0, -0x41a72);          /* call 0x100765d0 */
    II(0x100b8042, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100b8045, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100b8048, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b804a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b804b, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b804c, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b804d, 0x1)   popd(edx);                            /* pop edx */
    II(0x100b804e, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b804f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b8050, 0x1)   retd();                               /* ret */
FUNC_END

