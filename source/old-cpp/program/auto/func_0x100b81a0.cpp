FUNC_BEGIN(0x100b81a0, 0x24b2287be7f12037, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xa8, 0xdb, 0xa, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x88, 0x55, 0xfc, 0x8a, 0x45, 0xfc, 0x8b, 0x55, 0xf8, 0x88, 0x42, 0x1e, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100b81a0, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100b81a5, 0x5)   calld(sys_check_available_stack_size, 0xadba8); /* call 0x10165d52 */
    II(0x100b81aa, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b81ab, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b81ac, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b81ad, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b81ae, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b81af, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b81b1, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100b81b7, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100b81ba, 0x3)   mov(memb_a32(ss, ebp - 0x4), dl);     /* mov [ebp-0x4], dl */
    II(0x100b81bd, 0x3)   mov(al, memb_a32(ss, ebp - 0x4));     /* mov al, [ebp-0x4] */
    II(0x100b81c0, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100b81c3, 0x3)   mov(memb_a32(ds, edx + 0x1e), al);    /* mov [edx+0x1e], al */
    II(0x100b81c6, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b81c8, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b81c9, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b81ca, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b81cb, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b81cc, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b81cd, 0x1)   retd();                               /* ret */
FUNC_END

