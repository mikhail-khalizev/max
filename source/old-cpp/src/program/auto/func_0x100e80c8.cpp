FUNC_BEGIN(0x100e80c8, 0xcd7b52b5d7e5541, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x80, 0xdc, 0x7, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xe8, 0xd0, 0x4, 0, 0, 0xf, 0xbf, 0xd0, 0x8b, 0x45, 0xfc, 0xe8, 0x71, 0x4, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100e80c8, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100e80cd, 0x5)   calld(sys_check_available_stack_size, 0x7dc80); /* call 0x10165d52 */
    II(0x100e80d2, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e80d3, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e80d4, 0x1)   pushd(edx);                           /* push edx */
    II(0x100e80d5, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e80d6, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e80d7, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e80d8, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e80da, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100e80e0, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100e80e3, 0x5)   calld(0x100e85b8, 0x4d0);             /* call 0x100e85b8 */
    II(0x100e80e8, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x100e80eb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100e80ee, 0x5)   calld(0x100e8564, 0x471);             /* call 0x100e8564 */
    II(0x100e80f3, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100e80f6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100e80f9, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e80fb, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e80fc, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e80fd, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e80fe, 0x1)   popd(edx);                            /* pop edx */
    II(0x100e80ff, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e8100, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e8101, 0x1)   retd();                               /* ret */
FUNC_END

