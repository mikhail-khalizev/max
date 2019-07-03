FUNC_BEGIN(0x100ac130, 0x9b805c4ddbe937be, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x18, 0x9c, 0xb, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x1a, 0xe8, 0x45, 0xbd, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100ac130, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100ac135, 0x5)   calld(sys_check_available_stack_size, 0xb9c18); /* call 0x10165d52 */
    II(0x100ac13a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100ac13b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ac13c, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ac13d, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ac13e, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ac13f, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ac141, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100ac147, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100ac14a, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x100ac14d, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x100ac150, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100ac153, 0x3)   add(eax, 0x1a);                       /* add eax, 0x1a */
    II(0x100ac156, 0x5)   calld(0x100b7ea0, 0xbd45);            /* call 0x100b7ea0 */
    II(0x100ac15b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ac15d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ac15e, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ac15f, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ac160, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ac161, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ac162, 0x1)   retd();                               /* ret */
FUNC_END

