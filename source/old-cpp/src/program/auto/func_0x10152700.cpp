FUNC_BEGIN(0x10152700, 0xb344e5226ce6d968, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x48, 0x36, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x5, 0x8a, 0, 0, 0, 0xe8, 0xcc, 0x87, 0xf3, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10152700, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10152705, 0x5)   calld(sys_check_available_stack_size, 0x13648); /* call 0x10165d52 */
    II(0x1015270a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1015270b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1015270c, 0x1)   pushd(edx);                           /* push edx */
    II(0x1015270d, 0x1)   pushd(esi);                           /* push esi */
    II(0x1015270e, 0x1)   pushd(edi);                           /* push edi */
    II(0x1015270f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10152710, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10152712, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10152718, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1015271b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1015271e, 0x5)   add(eax, 0x8a);                       /* add eax, 0x8a */
    II(0x10152723, 0x5)   calld(0x1008aef4, -0xc7834);          /* call 0x1008aef4 */
    II(0x10152728, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1015272b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1015272e, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10152730, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10152731, 0x1)   popd(edi);                            /* pop edi */
    II(0x10152732, 0x1)   popd(esi);                            /* pop esi */
    II(0x10152733, 0x1)   popd(edx);                            /* pop edx */
    II(0x10152734, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10152735, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10152736, 0x1)   retd();                               /* ret */
FUNC_END

