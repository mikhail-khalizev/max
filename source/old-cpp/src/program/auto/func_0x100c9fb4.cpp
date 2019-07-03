FUNC_BEGIN(0x100c9fb4, 0x2624fdb3dd7c9a39, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x94, 0xbd, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xe8, 0x40, 0xf, 0, 0, 0xf, 0xbf, 0xd0, 0x8b, 0x45, 0xfc, 0xe8, 0xcd, 0xe, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100c9fb4, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100c9fb9, 0x5)   calld(sys_check_available_stack_size, 0x9bd94); /* call 0x10165d52 */
    II(0x100c9fbe, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100c9fbf, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100c9fc0, 0x1)   pushd(edx);                           /* push edx */
    II(0x100c9fc1, 0x1)   pushd(esi);                           /* push esi */
    II(0x100c9fc2, 0x1)   pushd(edi);                           /* push edi */
    II(0x100c9fc3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100c9fc4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100c9fc6, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100c9fcc, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100c9fcf, 0x5)   calld(0x100caf14, 0xf40);             /* call 0x100caf14 */
    II(0x100c9fd4, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x100c9fd7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100c9fda, 0x5)   calld(0x100caeac, 0xecd);             /* call 0x100caeac */
    II(0x100c9fdf, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100c9fe2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100c9fe5, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100c9fe7, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100c9fe8, 0x1)   popd(edi);                            /* pop edi */
    II(0x100c9fe9, 0x1)   popd(esi);                            /* pop esi */
    II(0x100c9fea, 0x1)   popd(edx);                            /* pop edx */
    II(0x100c9feb, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100c9fec, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100c9fed, 0x1)   retd();                               /* ret */
FUNC_END

