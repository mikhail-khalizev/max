FUNC_BEGIN(0x10136df4, 0xdcacc03e6be7d50f, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x54, 0xef, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x40, 0x4f, 0xe8, 0x98, 0x43, 0xfb, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10136df4, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10136df9, 0x5)   calld(sys_check_available_stack_size, 0x2ef54); /* call 0x10165d52 */
    II(0x10136dfe, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10136dff, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10136e00, 0x1)   pushd(edx);                           /* push edx */
    II(0x10136e01, 0x1)   pushd(esi);                           /* push esi */
    II(0x10136e02, 0x1)   pushd(edi);                           /* push edi */
    II(0x10136e03, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10136e04, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10136e06, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10136e0c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10136e0f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10136e12, 0x3)   mov(eax, memd_a32(ds, eax + 0x4f));   /* mov eax, [eax+0x4f] */
    II(0x10136e15, 0x5)   calld(0x100eb1b2, -0x4bc68);          /* call 0x100eb1b2 */
    II(0x10136e1a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10136e1c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10136e1d, 0x1)   popd(edi);                            /* pop edi */
    II(0x10136e1e, 0x1)   popd(esi);                            /* pop esi */
    II(0x10136e1f, 0x1)   popd(edx);                            /* pop edx */
    II(0x10136e20, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10136e21, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10136e22, 0x1)   retd();                               /* ret */
FUNC_END

