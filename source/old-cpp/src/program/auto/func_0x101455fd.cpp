FUNC_BEGIN(0x101455fd, 0xb1f5e52acbfc3e2c, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x4b, 0x7, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x14, 0xe8, 0x9d, 0x29, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101455fd, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10145602, 0x5)   calld(sys_check_available_stack_size, 0x2074b); /* call 0x10165d52 */
    II(0x10145607, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10145608, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10145609, 0x1)   pushd(edx);                           /* push edx */
    II(0x1014560a, 0x1)   pushd(esi);                           /* push esi */
    II(0x1014560b, 0x1)   pushd(edi);                           /* push edi */
    II(0x1014560c, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1014560d, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1014560f, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10145615, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10145618, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014561b, 0x3)   add(eax, 0x14);                       /* add eax, 0x14 */
    II(0x1014561e, 0x5)   calld(0x10147fc0, 0x299d);            /* call 0x10147fc0 */
    II(0x10145623, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10145626, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10145629, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1014562b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1014562c, 0x1)   popd(edi);                            /* pop edi */
    II(0x1014562d, 0x1)   popd(esi);                            /* pop esi */
    II(0x1014562e, 0x1)   popd(edx);                            /* pop edx */
    II(0x1014562f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10145630, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10145631, 0x1)   retd();                               /* ret */
FUNC_END

