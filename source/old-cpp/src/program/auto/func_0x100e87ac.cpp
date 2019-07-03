FUNC_BEGIN(0x100e87ac, 0xfe3616c1b2df43fa, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x9c, 0xd5, 0x7, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x4, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100e87ac, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100e87b1, 0x5)   calld(sys_check_available_stack_size, 0x7d59c); /* call 0x10165d52 */
    II(0x100e87b6, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e87b7, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e87b8, 0x1)   pushd(edx);                           /* push edx */
    II(0x100e87b9, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e87ba, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e87bb, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e87bc, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e87be, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100e87c4, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100e87c7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100e87ca, 0x3)   add(eax, 0x4);                        /* add eax, 0x4 */
    II(0x100e87cd, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100e87d0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100e87d3, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e87d5, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e87d6, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e87d7, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e87d8, 0x1)   popd(edx);                            /* pop edx */
    II(0x100e87d9, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e87da, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e87db, 0x1)   retd();                               /* ret */
FUNC_END

