FUNC_BEGIN(0x10089fc4, 0x592b456bd612d7ac, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x84, 0xbd, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x19, 0xe8, 0x4e, 0xc3, 0xfe, 0xff, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10089fc4, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10089fc9, 0x5)   calld(sys_check_available_stack_size, 0xdbd84); /* call 0x10165d52 */
    II(0x10089fce, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10089fcf, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10089fd0, 0x1)   pushd(edx);                           /* push edx */
    II(0x10089fd1, 0x1)   pushd(esi);                           /* push esi */
    II(0x10089fd2, 0x1)   pushd(edi);                           /* push edi */
    II(0x10089fd3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10089fd4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10089fd6, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10089fdc, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10089fdf, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10089fe2, 0x3)   add(eax, 0x19);                       /* add eax, 0x19 */
    II(0x10089fe5, 0x5)   calld(0x10076338, -0x13cb2);          /* call 0x10076338 */
    II(0x10089fea, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x10089fed, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10089ff0, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10089ff2, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10089ff3, 0x1)   popd(edi);                            /* pop edi */
    II(0x10089ff4, 0x1)   popd(esi);                            /* pop esi */
    II(0x10089ff5, 0x1)   popd(edx);                            /* pop edx */
    II(0x10089ff6, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10089ff7, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10089ff8, 0x1)   retd();                               /* ret */
FUNC_END

