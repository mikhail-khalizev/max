FUNC_BEGIN(0x1011ba3d, 0x1f5eae7ebe71ee7b, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xb, 0xa3, 0x4, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x31, 0xdb, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0xe8, 0x51, 0xc6, 0xff, 0xff, 0x89, 0x45, 0xfc, 0x8d, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xfc, 0xc7, 0x40, 0x2, 0xdc, 0x68, 0x1b, 0x10, 0x8b, 0x45, 0xfc, 0x66, 0xc7, 0x40, 0x16, 0x1, 0, 0x8b, 0x45, 0xfc, 0x66, 0xc7, 0x40, 0x18, 0x1, 0, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1011ba3d, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x1011ba42, 0x5)   calld(sys_check_available_stack_size, 0x4a30b); /* call 0x10165d52 */
    II(0x1011ba47, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1011ba48, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1011ba49, 0x1)   pushd(edx);                           /* push edx */
    II(0x1011ba4a, 0x1)   pushd(esi);                           /* push esi */
    II(0x1011ba4b, 0x1)   pushd(edi);                           /* push edi */
    II(0x1011ba4c, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1011ba4d, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1011ba4f, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1011ba55, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1011ba58, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x1011ba5a, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1011ba5c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1011ba5f, 0x5)   calld(0x101180b5, -0x39af);           /* call 0x101180b5 */
    II(0x1011ba64, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1011ba67, 0x3)   lea(eax, ebp - 0x4);                  /* lea eax, [ebp-0x4] */
    II(0x1011ba6a, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1011ba6d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1011ba70, 0x7)   mov(memd_a32(ds, eax + 0x2), 0x101b68dc); /* mov dword [eax+0x2], 0x101b68dc */
    II(0x1011ba77, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1011ba7a, 0x6)   mov(memw_a32(ds, eax + 0x16), 0x1);   /* mov word [eax+0x16], 0x1 */
    II(0x1011ba80, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1011ba83, 0x6)   mov(memw_a32(ds, eax + 0x18), 0x1);   /* mov word [eax+0x18], 0x1 */
    II(0x1011ba89, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1011ba8c, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1011ba8f, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1011ba92, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1011ba94, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011ba95, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011ba96, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011ba97, 0x1)   popd(edx);                            /* pop edx */
    II(0x1011ba98, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1011ba99, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1011ba9a, 0x1)   retd();                               /* ret */
FUNC_END

