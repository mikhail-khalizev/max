FUNC_BEGIN(0x100aad20, 0xa356e7d34f96c04b, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x28, 0xb0, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x15, 0xbe, 0xfc, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100aad20, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100aad25, 0x5)   calld(sys_check_available_stack_size, 0xbb028); /* call 0x10165d52 */
    II(0x100aad2a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100aad2b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100aad2c, 0x1)   pushd(edx);                           /* push edx */
    II(0x100aad2d, 0x1)   pushd(esi);                           /* push esi */
    II(0x100aad2e, 0x1)   pushd(edi);                           /* push edi */
    II(0x100aad2f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100aad30, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100aad32, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100aad38, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100aad3b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100aad3e, 0x5)   calld(0x10076b58, -0x341eb);          /* call 0x10076b58 */
    II(0x100aad43, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100aad46, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100aad49, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100aad4b, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100aad4c, 0x1)   popd(edi);                            /* pop edi */
    II(0x100aad4d, 0x1)   popd(esi);                            /* pop esi */
    II(0x100aad4e, 0x1)   popd(edx);                            /* pop edx */
    II(0x100aad4f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100aad50, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100aad51, 0x1)   retd();                               /* ret */
FUNC_END

