FUNC_BEGIN(0x100d60d4, 0x63b2985de0db56d6, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x74, 0xfc, 0x8, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x88, 0x55, 0xfc, 0x8a, 0x45, 0xfc, 0x8b, 0x55, 0xf8, 0x88, 0x42, 0x35, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100d60d4, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100d60d9, 0x5)   calld(sys_check_available_stack_size, 0x8fc74); /* call 0x10165d52 */
    II(0x100d60de, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100d60df, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100d60e0, 0x1)   pushd(esi);                           /* push esi */
    II(0x100d60e1, 0x1)   pushd(edi);                           /* push edi */
    II(0x100d60e2, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100d60e3, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100d60e5, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100d60eb, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100d60ee, 0x3)   mov(memb_a32(ss, ebp - 0x4), dl);     /* mov [ebp-0x4], dl */
    II(0x100d60f1, 0x3)   mov(al, memb_a32(ss, ebp - 0x4));     /* mov al, [ebp-0x4] */
    II(0x100d60f4, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100d60f7, 0x3)   mov(memb_a32(ds, edx + 0x35), al);    /* mov [edx+0x35], al */
    II(0x100d60fa, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100d60fc, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100d60fd, 0x1)   popd(edi);                            /* pop edi */
    II(0x100d60fe, 0x1)   popd(esi);                            /* pop esi */
    II(0x100d60ff, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100d6100, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100d6101, 0x1)   retd();                               /* ret */
FUNC_END

