FUNC_BEGIN(0x100cb2f4, 0x15215d09ce220483, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x54, 0xaa, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8a, 0x40, 0x6, 0x88, 0x45, 0xf8, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100cb2f4, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100cb2f9, 0x5)   calld(sys_check_available_stack_size, 0x9aa54); /* call 0x10165d52 */
    II(0x100cb2fe, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cb2ff, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cb300, 0x1)   pushd(edx);                           /* push edx */
    II(0x100cb301, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cb302, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cb303, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cb304, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cb306, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100cb30c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100cb30f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100cb312, 0x3)   mov(al, memb_a32(ds, eax + 0x6));     /* mov al, [eax+0x6] */
    II(0x100cb315, 0x3)   mov(memb_a32(ss, ebp - 0x8), al);     /* mov [ebp-0x8], al */
//    II(0x100cb318, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x100cb31b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cb31d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cb31e, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cb31f, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cb320, 0x1)   popd(edx);                            /* pop edx */
    II(0x100cb321, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cb322, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cb323, 0x1)   retd();                               /* ret */
FUNC_END

