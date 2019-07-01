FUNC_BEGIN(0x10120a2c, 0xe407873ac3f22c9e, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x1c, 0x53, 0x4, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8a, 0x40, 0xe, 0x88, 0x45, 0xf8, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10120a2c, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10120a31, 0x5)   calld(sys_check_available_stack_size, 0x4531c); /* call 0x10165d52 */
    II(0x10120a36, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10120a37, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10120a38, 0x1)   pushd(edx);                           /* push edx */
    II(0x10120a39, 0x1)   pushd(esi);                           /* push esi */
    II(0x10120a3a, 0x1)   pushd(edi);                           /* push edi */
    II(0x10120a3b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10120a3c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10120a3e, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10120a44, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10120a47, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10120a4a, 0x3)   mov(al, memb_a32(ds, eax + 0xe));     /* mov al, [eax+0xe] */
    II(0x10120a4d, 0x3)   mov(memb_a32(ss, ebp - 0x8), al);     /* mov [ebp-0x8], al */
//    II(0x10120a50, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x10120a53, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10120a55, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10120a56, 0x1)   popd(edi);                            /* pop edi */
    II(0x10120a57, 0x1)   popd(esi);                            /* pop esi */
    II(0x10120a58, 0x1)   popd(edx);                            /* pop edx */
    II(0x10120a59, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10120a5a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10120a5b, 0x1)   retd();                               /* ret */
FUNC_END

