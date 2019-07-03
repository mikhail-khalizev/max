FUNC_BEGIN(0x100b80c4, 0xbff5e47a10d8c03, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x84, 0xdc, 0xa, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8a, 0x40, 0x13, 0x88, 0x45, 0xf8, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100b80c4, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100b80c9, 0x5)   calld(sys_check_available_stack_size, 0xadc84); /* call 0x10165d52 */
    II(0x100b80ce, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100b80cf, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100b80d0, 0x1)   pushd(edx);                           /* push edx */
    II(0x100b80d1, 0x1)   pushd(esi);                           /* push esi */
    II(0x100b80d2, 0x1)   pushd(edi);                           /* push edi */
    II(0x100b80d3, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100b80d4, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100b80d6, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100b80dc, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100b80df, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100b80e2, 0x3)   mov(al, memb_a32(ds, eax + 0x13));    /* mov al, [eax+0x13] */
    II(0x100b80e5, 0x3)   mov(memb_a32(ss, ebp - 0x8), al);     /* mov [ebp-0x8], al */
//    II(0x100b80e8, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x100b80eb, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100b80ed, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100b80ee, 0x1)   popd(edi);                            /* pop edi */
    II(0x100b80ef, 0x1)   popd(esi);                            /* pop esi */
    II(0x100b80f0, 0x1)   popd(edx);                            /* pop edx */
    II(0x100b80f1, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100b80f2, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100b80f3, 0x1)   retd();                               /* ret */
FUNC_END

