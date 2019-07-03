FUNC_BEGIN(0x100760e4, 0x643622ac414d1394, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x64, 0xfc, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x5, 0x86, 0, 0, 0, 0xe8, 0xf4, 0x4, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100760e4, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100760e9, 0x5)   calld(sys_check_available_stack_size, 0xefc64); /* call 0x10165d52 */
    II(0x100760ee, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100760ef, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100760f0, 0x1)   pushd(edx);                           /* push edx */
    II(0x100760f1, 0x1)   pushd(esi);                           /* push esi */
    II(0x100760f2, 0x1)   pushd(edi);                           /* push edi */
    II(0x100760f3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100760f4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100760f6, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100760fc, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100760ff, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10076102, 0x5)   add(eax, 0x86);                       /* add eax, 0x86 */
    II(0x10076107, 0x5)   calld(0x10076600, 0x4f4);             /* call 0x10076600 */
    II(0x1007610c, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1007610f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10076112, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10076114, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10076115, 0x1)   popd(edi);                            /* pop edi */
    II(0x10076116, 0x1)   popd(esi);                            /* pop esi */
    II(0x10076117, 0x1)   popd(edx);                            /* pop edx */
    II(0x10076118, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10076119, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1007611a, 0x1)   retd();                               /* ret */
FUNC_END

