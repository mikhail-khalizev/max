FUNC_BEGIN(0x101044e4, 0x455ef74267831b3b, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x64, 0x18, 0x6, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101044e4, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x101044e9, 0x5)   calld(sys_check_available_stack_size, 0x61864); /* call 0x10165d52 */
    II(0x101044ee, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101044ef, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101044f0, 0x1)   pushd(edx);                           /* push edx */
    II(0x101044f1, 0x1)   pushd(esi);                           /* push esi */
    II(0x101044f2, 0x1)   pushd(edi);                           /* push edi */
    II(0x101044f3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101044f4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101044f6, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x101044fc, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x101044ff, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10104502, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x10104504, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10104507, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1010450a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1010450c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1010450d, 0x1)   popd(edi);                            /* pop edi */
    II(0x1010450e, 0x1)   popd(esi);                            /* pop esi */
    II(0x1010450f, 0x1)   popd(edx);                            /* pop edx */
    II(0x10104510, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10104511, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10104512, 0x1)   retd();                               /* ret */
FUNC_END

