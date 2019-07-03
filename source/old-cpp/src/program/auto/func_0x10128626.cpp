FUNC_BEGIN(0x10128626, 0xac17284119448b51, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x22, 0xd7, 0x3, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0xe8, 0xaa, 0xef, 0xff, 0xff, 0x31, 0xc0, 0xa0, 0x9e, 0x60, 0x1c, 0x10, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10128626, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1012862b, 0x5)   calld(sys_check_available_stack_size, 0x3d722); /* call 0x10165d52 */
    II(0x10128630, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10128631, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10128632, 0x1)   pushd(edx);                           /* push edx */
    II(0x10128633, 0x1)   pushd(esi);                           /* push esi */
    II(0x10128634, 0x1)   pushd(edi);                           /* push edi */
    II(0x10128635, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10128636, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10128638, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1012863e, 0x5)   calld(0x101275ed, -0x1056);           /* call 0x101275ed */
    II(0x10128643, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10128645, 0x5)   mov(al, memb_a32(ds, 0x101c609e));    /* mov al, [0x101c609e] */
    II(0x1012864a, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1012864d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10128650, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10128652, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10128653, 0x1)   popd(edi);                            /* pop edi */
    II(0x10128654, 0x1)   popd(esi);                            /* pop esi */
    II(0x10128655, 0x1)   popd(edx);                            /* pop edx */
    II(0x10128656, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10128657, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10128658, 0x1)   retd();                               /* ret */
FUNC_END

