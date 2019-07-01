FUNC_BEGIN(0x100aa9f8, 0x2653ebf9272f294d, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x50, 0xb3, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8a, 0x40, 0x1e, 0x88, 0x45, 0xf8, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100aa9f8, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100aa9fd, 0x5)   calld(sys_check_available_stack_size, 0xbb350); /* call 0x10165d52 */
    II(0x100aaa02, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100aaa03, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100aaa04, 0x1)   pushd(edx);                           /* push edx */
    II(0x100aaa05, 0x1)   pushd(esi);                           /* push esi */
    II(0x100aaa06, 0x1)   pushd(edi);                           /* push edi */
    II(0x100aaa07, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100aaa08, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100aaa0a, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100aaa10, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100aaa13, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100aaa16, 0x3)   mov(al, memb_a32(ds, eax + 0x1e));    /* mov al, [eax+0x1e] */
    II(0x100aaa19, 0x3)   mov(memb_a32(ss, ebp - 0x8), al);     /* mov [ebp-0x8], al */
//    II(0x100aaa1c, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x100aaa1f, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100aaa21, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100aaa22, 0x1)   popd(edi);                            /* pop edi */
    II(0x100aaa23, 0x1)   popd(esi);                            /* pop esi */
    II(0x100aaa24, 0x1)   popd(edx);                            /* pop edx */
    II(0x100aaa25, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100aaa26, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100aaa27, 0x1)   retd();                               /* ret */
FUNC_END

