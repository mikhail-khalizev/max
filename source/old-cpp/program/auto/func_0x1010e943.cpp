FUNC_BEGIN(0x1010e943, 0xb09a46edf97241ab, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x5, 0x74, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x83, 0x3d, 0xf0, 0x4d, 0x1c, 0x10, 0, 0x74, 0x29, 0xa1, 0xf0, 0x4d, 0x1c, 0x10, 0x89, 0x45, 0xf8, 0x83, 0x7d, 0xf8, 0, 0x74, 0x14, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0xe8, 0xbc, 0xfb, 0xfb, 0xff, 0xe8, 0xe3, 0x75, 0x5, 0, 0x89, 0x45, 0xfc, 0xeb, 0x7, 0xc7, 0x45, 0xfc, 0, 0, 0, 0, 0xc7, 0x5, 0xf0, 0x4d, 0x1c, 0x10, 0, 0, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1010e943, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1010e948, 0x5)   calld(sys_check_available_stack_size, 0x57405); /* call 0x10165d52 */
    II(0x1010e94d, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1010e94e, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1010e94f, 0x1)   pushd(edx);                           /* push edx */
    II(0x1010e950, 0x1)   pushd(esi);                           /* push esi */
    II(0x1010e951, 0x1)   pushd(edi);                           /* push edi */
    II(0x1010e952, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1010e953, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1010e955, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1010e95b, 0x7)   cmp(memd_a32(ds, 0x101c4df0), 0);     /* cmp dword [0x101c4df0], 0x0 */
    II(0x1010e962, 0x2)   jzd(0x1010e98d, 0x29);                /* jz 0x1010e98d */
    II(0x1010e964, 0x5)   mov(eax, memd_a32(ds, 0x101c4df0));   /* mov eax, [0x101c4df0] */
    II(0x1010e969, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1010e96c, 0x4)   cmp(memd_a32(ss, ebp - 0x8), 0);      /* cmp dword [ebp-0x8], 0x0 */
    II(0x1010e970, 0x2)   jzd(0x1010e986, 0x14);                /* jz 0x1010e986 */
    II(0x1010e972, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1010e974, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1010e977, 0x5)   calld(my_dtor_d2, -0x40444);          /* call 0x100ce538 */
    II(0x1010e97c, 0x5)   calld(sys_delete, 0x575e3);           /* call 0x10165f64 */
    II(0x1010e981, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1010e984, 0x2)   jmpd(0x1010e98d, 0x7);                /* jmp 0x1010e98d */
l_0x1010e986:
    II(0x1010e986, 0x7)   mov(memd_a32(ss, ebp - 0x4), 0);      /* mov dword [ebp-0x4], 0x0 */
l_0x1010e98d:
    II(0x1010e98d, 0xa)   mov(memd_a32(ds, 0x101c4df0), 0);     /* mov dword [0x101c4df0], 0x0 */
    II(0x1010e997, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1010e999, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1010e99a, 0x1)   popd(edi);                            /* pop edi */
    II(0x1010e99b, 0x1)   popd(esi);                            /* pop esi */
    II(0x1010e99c, 0x1)   popd(edx);                            /* pop edx */
    II(0x1010e99d, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1010e99e, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1010e99f, 0x1)   retd();                               /* ret */
FUNC_END

