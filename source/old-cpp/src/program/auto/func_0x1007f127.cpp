FUNC_BEGIN(0x1007f127, 0xd70be88d93e4f607, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x21, 0x6c, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x2, 0x8b, 0x45, 0xf8, 0xff, 0x52, 0x4c, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1007f127, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1007f12c, 0x5)   calld(sys_check_available_stack_size, 0xe6c21); /* call 0x10165d52 */
    II(0x1007f131, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1007f132, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1007f133, 0x1)   pushd(edx);                           /* push edx */
    II(0x1007f134, 0x1)   pushd(esi);                           /* push esi */
    II(0x1007f135, 0x1)   pushd(edi);                           /* push edi */
    II(0x1007f136, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1007f137, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1007f139, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1007f13f, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1007f142, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1007f145, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1007f148, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1007f14b, 0x3)   mov(edx, memd_a32(ds, eax + 0x2));    /* mov edx, [eax+0x2] */
//    II(0x1007f14e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1007f151, 0x3)   calld_abs(memd_a32(ds, edx + 0x4c));  /* call dword near [edx+0x4c] */
    II(0x1007f154, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1007f156, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1007f157, 0x1)   popd(edi);                            /* pop edi */
    II(0x1007f158, 0x1)   popd(esi);                            /* pop esi */
    II(0x1007f159, 0x1)   popd(edx);                            /* pop edx */
    II(0x1007f15a, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1007f15b, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1007f15c, 0x1)   retd();                               /* ret */
FUNC_END

