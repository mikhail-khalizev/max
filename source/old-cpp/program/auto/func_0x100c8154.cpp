FUNC_BEGIN(0x100c8154, 0x12e6d5797d1eb37f, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xf4, 0xdb, 0x9, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xf8, 0x8b, 0x52, 0x17, 0x8b, 0x45, 0xf8, 0x3, 0x50, 0xf, 0x89, 0xd0, 0xc1, 0xfa, 0x1f, 0x2b, 0xc2, 0xd1, 0xf8, 0xf, 0xbf, 0xd8, 0x8b, 0x55, 0xf8, 0x8b, 0x52, 0x13, 0x8b, 0x45, 0xf8, 0x3, 0x50, 0xb, 0x89, 0xd0, 0xc1, 0xfa, 0x1f, 0x2b, 0xc2, 0xd1, 0xf8, 0xf, 0xbf, 0xd0, 0x8b, 0x45, 0xfc, 0xe8, 0x3, 0xe9, 0xfa, 0xff, 0x8b, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100c8154, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100c8159, 0x5)   calld(sys_check_available_stack_size, 0x9dbf4); /* call 0x10165d52 */
    II(0x100c815e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100c815f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100c8160, 0x1)   pushd(esi);                           /* push esi */
    II(0x100c8161, 0x1)   pushd(edi);                           /* push edi */
    II(0x100c8162, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100c8163, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100c8165, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100c816b, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100c816e, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100c8171, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100c8174, 0x3)   mov(edx, memd_a32(ds, edx + 0x17));   /* mov edx, [edx+0x17] */
//    II(0x100c8177, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100c817a, 0x3)   add(edx, memd_a32(ds, eax + 0xf));    /* add edx, [eax+0xf] */
    II(0x100c817d, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x100c817f, 0x3)   sar(edx, 0x1f);                       /* sar edx, 0x1f */
    II(0x100c8182, 0x2)   sub(eax, edx);                        /* sub eax, edx */
    II(0x100c8184, 0x2)   sar(eax, 0x1);                        /* sar eax, 1 */
    II(0x100c8186, 0x3)   movsx(ebx, ax);                       /* movsx ebx, ax */
    II(0x100c8189, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100c818c, 0x3)   mov(edx, memd_a32(ds, edx + 0x13));   /* mov edx, [edx+0x13] */
    II(0x100c818f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100c8192, 0x3)   add(edx, memd_a32(ds, eax + 0xb));    /* add edx, [eax+0xb] */
    II(0x100c8195, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x100c8197, 0x3)   sar(edx, 0x1f);                       /* sar edx, 0x1f */
    II(0x100c819a, 0x2)   sub(eax, edx);                        /* sub eax, edx */
    II(0x100c819c, 0x2)   sar(eax, 0x1);                        /* sar eax, 1 */
    II(0x100c819e, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x100c81a1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100c81a4, 0x5)   calld(0x10076aac, -0x516fd);          /* call 0x10076aac */
    II(0x100c81a9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100c81ac, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100c81ae, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100c81af, 0x1)   popd(edi);                            /* pop edi */
    II(0x100c81b0, 0x1)   popd(esi);                            /* pop esi */
    II(0x100c81b1, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100c81b2, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100c81b3, 0x1)   retd();                               /* ret */
FUNC_END

