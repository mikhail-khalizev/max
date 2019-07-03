FUNC_BEGIN(0x100810e3, 0xa5085360e9221d52, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x65, 0x4c, 0xe, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x83, 0xc0, 0x13, 0xe8, 0xa6, 0x99, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100810e3, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100810e8, 0x5)   calld(sys_check_available_stack_size, 0xe4c65); /* call 0x10165d52 */
    II(0x100810ed, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100810ee, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100810ef, 0x1)   pushd(esi);                           /* push esi */
    II(0x100810f0, 0x1)   pushd(edi);                           /* push edi */
    II(0x100810f1, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100810f2, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100810f4, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100810fa, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100810fd, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10081100, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
//    II(0x10081103, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10081106, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x10081109, 0x5)   calld(0x1008aab4, 0x99a6);            /* call 0x1008aab4 */
    II(0x1008110e, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10081110, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10081111, 0x1)   popd(edi);                            /* pop edi */
    II(0x10081112, 0x1)   popd(esi);                            /* pop esi */
    II(0x10081113, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10081114, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10081115, 0x1)   retd();                               /* ret */
FUNC_END

