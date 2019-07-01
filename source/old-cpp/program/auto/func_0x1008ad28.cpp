FUNC_BEGIN(0x1008ad28, 0x726a198a09a41ee8, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x20, 0xb0, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8a, 0x40, 0x8, 0x88, 0x45, 0xf8, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1008ad28, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1008ad2d, 0x5)   calld(sys_check_available_stack_size, 0xdb020); /* call 0x10165d52 */
    II(0x1008ad32, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008ad33, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008ad34, 0x1)   pushd(edx);                           /* push edx */
    II(0x1008ad35, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008ad36, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008ad37, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008ad38, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008ad3a, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1008ad40, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1008ad43, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008ad46, 0x3)   mov(al, memb_a32(ds, eax + 0x8));     /* mov al, [eax+0x8] */
    II(0x1008ad49, 0x3)   mov(memb_a32(ss, ebp - 0x8), al);     /* mov [ebp-0x8], al */
//    II(0x1008ad4c, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x1008ad4f, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008ad51, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008ad52, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008ad53, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008ad54, 0x1)   popd(edx);                            /* pop edx */
    II(0x1008ad55, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008ad56, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008ad57, 0x1)   retd();                               /* ret */
FUNC_END

