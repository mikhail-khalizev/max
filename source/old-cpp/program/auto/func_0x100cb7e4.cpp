FUNC_BEGIN(0x100cb7e4, 0x67479b95f3983306, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x64, 0xa5, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x80, 0x78, 0x23, 0, 0x74, 0x7, 0x8b, 0x45, 0xfc, 0x66, 0xff, 0x40, 0x21, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100cb7e4, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100cb7e9, 0x5)   calld(sys_check_available_stack_size, 0x9a564); /* call 0x10165d52 */
    II(0x100cb7ee, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cb7ef, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cb7f0, 0x1)   pushd(edx);                           /* push edx */
    II(0x100cb7f1, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cb7f2, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cb7f3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cb7f4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cb7f6, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100cb7fc, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100cb7ff, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cb802, 0x4)   cmp(memb_a32(ds, eax + 0x23), 0);     /* cmp byte [eax+0x23], 0x0 */
    II(0x100cb806, 0x2)   jzd(0x100cb80f, 0x7);                 /* jz 0x100cb80f */
    II(0x100cb808, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cb80b, 0x4)   inc(memw_a32(ds, eax + 0x21));        /* inc word [eax+0x21] */
l_0x100cb80f:
    II(0x100cb80f, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cb811, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cb812, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cb813, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cb814, 0x1)   popd(edx);                            /* pop edx */
    II(0x100cb815, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cb816, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cb817, 0x1)   retd();                               /* ret */
FUNC_END

