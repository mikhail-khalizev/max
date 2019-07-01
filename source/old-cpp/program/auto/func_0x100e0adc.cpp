FUNC_BEGIN(0x100e0adc, 0x40c88762cf893e2c, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x6c, 0x52, 0x8, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x55, 0xf8, 0x66, 0x89, 0x42, 0xe, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100e0adc, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100e0ae1, 0x5)   calld(sys_check_available_stack_size, 0x8526c); /* call 0x10165d52 */
    II(0x100e0ae6, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100e0ae7, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100e0ae8, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e0ae9, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e0aea, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e0aeb, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e0aed, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100e0af3, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100e0af6, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100e0af9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100e0afc, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100e0aff, 0x4)   mov(memw_a32(ds, edx + 0xe), ax);     /* mov [edx+0xe], ax */
    II(0x100e0b03, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e0b05, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e0b06, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e0b07, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e0b08, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100e0b09, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100e0b0a, 0x1)   retd();                               /* ret */
FUNC_END

