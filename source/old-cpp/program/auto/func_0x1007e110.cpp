FUNC_BEGIN(0x1007e110, 0x31104aaa31fd2f7d, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x38, 0x7c, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc7, 0x45, 0xf8, 0, 0, 0, 0, 0xeb, 0x6, 0x8b, 0x45, 0xf8, 0xff, 0x45, 0xf8, 0xf, 0xbf, 0x45, 0xf8, 0x83, 0xf8, 0x8, 0x7d, 0x16, 0xf, 0xbf, 0x45, 0xf8, 0x6b, 0xd0, 0x16, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x21, 0x1, 0xd0, 0xe8, 0x7c, 0xf0, 0xff, 0xff, 0xeb, 0xdb, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0xf, 0xe8, 0x7e, 0xce, 0, 0, 0x8b, 0x55, 0xfc, 0xb8, 0x80, 0x31, 0x1c, 0x10, 0xe8, 0xb4, 0x7c, 0x2, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1007e110, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1007e115, 0x5)   calld(sys_check_available_stack_size, 0xe7c38); /* call 0x10165d52 */
    II(0x1007e11a, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1007e11b, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1007e11c, 0x1)   pushd(edx);                           /* push edx */
    II(0x1007e11d, 0x1)   pushd(esi);                           /* push esi */
    II(0x1007e11e, 0x1)   pushd(edi);                           /* push edi */
    II(0x1007e11f, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1007e120, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1007e122, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1007e128, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1007e12b, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0);      /* mov dword [ebp-0x8], 0x0 */
    II(0x1007e132, 0x2)   jmpd(0x1007e13a, 0x6);                /* jmp 0x1007e13a */
l_0x1007e134:
    II(0x1007e134, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1007e137, 0x3)   inc(memd_a32(ss, ebp - 0x8));         /* inc dword [ebp-0x8] */
l_0x1007e13a:
    II(0x1007e13a, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x1007e13e, 0x3)   cmp(eax, 0x8);                        /* cmp eax, 0x8 */
    II(0x1007e141, 0x2)   jged(0x1007e159, 0x16);               /* jge 0x1007e159 */
    II(0x1007e143, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x1007e147, 0x3)   imul(edx, eax, 0x16);                 /* imul edx, eax, 0x16 */
    II(0x1007e14a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1007e14d, 0x3)   add(eax, 0x21);                       /* add eax, 0x21 */
    II(0x1007e150, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x1007e152, 0x5)   calld(0x1007d1d3, -0xf84);            /* call 0x1007d1d3 */
    II(0x1007e157, 0x2)   jmpd(0x1007e134, -0x25);              /* jmp 0x1007e134 */
l_0x1007e159:
    II(0x1007e159, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1007e15b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1007e15e, 0x3)   add(eax, 0xf);                        /* add eax, 0xf */
    II(0x1007e161, 0x5)   calld(0x1008afe4, 0xce7e);            /* call 0x1008afe4 */
    II(0x1007e166, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x1007e169, 0x5)   mov(eax, 0x101c3180);                 /* mov eax, 0x101c3180 */
    II(0x1007e16e, 0x5)   calld(0x100a5e27, 0x27cb4);           /* call 0x100a5e27 */
    II(0x1007e173, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1007e175, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1007e176, 0x1)   popd(edi);                            /* pop edi */
    II(0x1007e177, 0x1)   popd(esi);                            /* pop esi */
    II(0x1007e178, 0x1)   popd(edx);                            /* pop edx */
    II(0x1007e179, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1007e17a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1007e17b, 0x1)   retd();                               /* ret */
FUNC_END

