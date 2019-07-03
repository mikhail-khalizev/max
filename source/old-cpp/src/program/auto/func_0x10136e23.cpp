FUNC_BEGIN(0x10136e23, 0x1863378ae2e12b42, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x25, 0xef, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x4f, 0xe8, 0xdd, 0x43, 0xfb, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10136e23, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10136e28, 0x5)   calld(sys_check_available_stack_size, 0x2ef25); /* call 0x10165d52 */
    II(0x10136e2d, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10136e2e, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10136e2f, 0x1)   pushd(edx);                           /* push edx */
    II(0x10136e30, 0x1)   pushd(esi);                           /* push esi */
    II(0x10136e31, 0x1)   pushd(edi);                           /* push edi */
    II(0x10136e32, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10136e33, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10136e35, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10136e3b, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10136e3e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10136e41, 0x3)   mov(eax, memd_a32(ds, eax + 0x4f));   /* mov eax, [eax+0x4f] */
    II(0x10136e44, 0x5)   calld(0x100eb226, -0x4bc23);          /* call 0x100eb226 */
    II(0x10136e49, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10136e4b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10136e4c, 0x1)   popd(edi);                            /* pop edi */
    II(0x10136e4d, 0x1)   popd(esi);                            /* pop esi */
    II(0x10136e4e, 0x1)   popd(edx);                            /* pop edx */
    II(0x10136e4f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10136e50, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10136e51, 0x1)   retd();                               /* ret */
FUNC_END

