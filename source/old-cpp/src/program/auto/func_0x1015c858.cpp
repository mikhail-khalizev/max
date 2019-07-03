FUNC_BEGIN(0x1015c858, 0xcf43d981ecd31bed, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xf0, 0x94, 0, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8a, 0x40, 0x29, 0x30, 0xe4, 0x5, 0xc8, 0, 0, 0, 0xf, 0xbf, 0xd0, 0x8b, 0x45, 0xfc, 0xe8, 0x7c, 0xd2, 0xfe, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1015c858, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x1015c85d, 0x5)   calld(sys_check_available_stack_size, 0x94f0); /* call 0x10165d52 */
    II(0x1015c862, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1015c863, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1015c864, 0x1)   pushd(edx);                           /* push edx */
    II(0x1015c865, 0x1)   pushd(esi);                           /* push esi */
    II(0x1015c866, 0x1)   pushd(edi);                           /* push edi */
    II(0x1015c867, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1015c868, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1015c86a, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1015c870, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1015c873, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1015c876, 0x3)   mov(al, memb_a32(ds, eax + 0x29));    /* mov al, [eax+0x29] */
    II(0x1015c879, 0x2)   xor_(ah, ah);                         /* xor ah, ah */
    II(0x1015c87b, 0x5)   add(eax, 0xc8);                       /* add eax, 0xc8 */
    II(0x1015c880, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x1015c883, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1015c886, 0x5)   calld(0x10149b07, -0x12d84);          /* call 0x10149b07 */
    II(0x1015c88b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1015c88d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1015c88e, 0x1)   popd(edi);                            /* pop edi */
    II(0x1015c88f, 0x1)   popd(esi);                            /* pop esi */
    II(0x1015c890, 0x1)   popd(edx);                            /* pop edx */
    II(0x1015c891, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1015c892, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1015c893, 0x1)   retd();                               /* ret */
FUNC_END

