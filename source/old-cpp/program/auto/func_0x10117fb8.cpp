FUNC_BEGIN(0x10117fb8, 0x849b923165ae1ead, 0x20, ({0x68, 0x34, 0, 0, 0, 0xe8, 0x90, 0xdd, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x1c, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x31, 0xd2, 0x8a, 0x50, 0x29, 0xf, 0xbf, 0x45, 0xfc, 0x39, 0xc2, 0x75, 0x9, 0xc6, 0x45, 0xf4, 0, 0xe9, 0x74, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x8a, 0x40, 0x29, 0x30, 0xe4, 0x8b, 0x55, 0xfc, 0x29, 0xc2, 0x89, 0x55, 0xf0, 0xf, 0xbf, 0x45, 0xf0, 0x85, 0xc0, 0x7d, 0x4, 0x83, 0x45, 0xf0, 0x8, 0x8b, 0x45, 0xf8, 0x8a, 0x40, 0x29, 0x30, 0xe4, 0x2b, 0x45, 0xfc, 0x89, 0x45, 0xec, 0xf, 0xbf, 0x45, 0xec, 0x85, 0xc0, 0x7d, 0x4, 0x83, 0x45, 0xec, 0x8, 0x8b, 0x45, 0xf0, 0x66, 0x3b, 0x45, 0xec, 0x7d, 0x9, 0xc7, 0x45, 0xe8, 0x1, 0, 0, 0, 0xeb, 0x7, 0xc7, 0x45, 0xe8, 0xff, 0xff, 0xff, 0xff, 0x8b, 0x45, 0xe8, 0x89, 0x45, 0xe4, 0x8b, 0x45, 0xf8, 0x8a, 0x40, 0x29, 0x30, 0xe4, 0x3, 0x45, 0xe4, 0x25, 0x7, 0, 0, 0, 0xf, 0xbf, 0xd0, 0x8b, 0x45, 0xf8, 0xe8, 0x88, 0x1f, 0x3, 0, 0xc6, 0x45, 0xf4, 0x1, 0x8a, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10117fb8, 0x5)   pushd(0x34);                          /* push dword 0x34 */
    II(0x10117fbd, 0x5)   calld(sys_check_available_stack_size, 0x4dd90); /* call 0x10165d52 */
    II(0x10117fc2, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10117fc3, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10117fc4, 0x1)   pushd(esi);                           /* push esi */
    II(0x10117fc5, 0x1)   pushd(edi);                           /* push edi */
    II(0x10117fc6, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10117fc7, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10117fc9, 0x6)   sub(esp, 0x1c);                       /* sub esp, 0x1c */
    II(0x10117fcf, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10117fd2, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10117fd5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10117fd8, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10117fda, 0x3)   mov(dl, memb_a32(ds, eax + 0x29));    /* mov dl, [eax+0x29] */
    II(0x10117fdd, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x10117fe1, 0x2)   cmp(edx, eax);                        /* cmp edx, eax */
    II(0x10117fe3, 0x2)   jnzd(0x10117fee, 0x9);                /* jnz 0x10117fee */
    II(0x10117fe5, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0);      /* mov byte [ebp-0xc], 0x0 */
    II(0x10117fe9, 0x5)   jmpd(0x10118062, 0x74);               /* jmp 0x10118062 */
l_0x10117fee:
    II(0x10117fee, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10117ff1, 0x3)   mov(al, memb_a32(ds, eax + 0x29));    /* mov al, [eax+0x29] */
    II(0x10117ff4, 0x2)   xor_(ah, ah);                         /* xor ah, ah */
    II(0x10117ff6, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x10117ff9, 0x2)   sub(edx, eax);                        /* sub edx, eax */
    II(0x10117ffb, 0x3)   mov(memd_a32(ss, ebp - 0x10), edx);   /* mov [ebp-0x10], edx */
    II(0x10117ffe, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x10)); /* movsx eax, word [ebp-0x10] */
    II(0x10118002, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10118004, 0x2)   jged(0x1011800a, 0x4);                /* jge 0x1011800a */
    II(0x10118006, 0x4)   add(memd_a32(ss, ebp - 0x10), 0x8);   /* add dword [ebp-0x10], 0x8 */
l_0x1011800a:
    II(0x1011800a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1011800d, 0x3)   mov(al, memb_a32(ds, eax + 0x29));    /* mov al, [eax+0x29] */
    II(0x10118010, 0x2)   xor_(ah, ah);                         /* xor ah, ah */
    II(0x10118012, 0x3)   sub(eax, memd_a32(ss, ebp - 0x4));    /* sub eax, [ebp-0x4] */
    II(0x10118015, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x10118018, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x14)); /* movsx eax, word [ebp-0x14] */
    II(0x1011801c, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1011801e, 0x2)   jged(0x10118024, 0x4);                /* jge 0x10118024 */
    II(0x10118020, 0x4)   add(memd_a32(ss, ebp - 0x14), 0x8);   /* add dword [ebp-0x14], 0x8 */
l_0x10118024:
    II(0x10118024, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10118027, 0x4)   cmp(ax, memw_a32(ss, ebp - 0x14));    /* cmp ax, [ebp-0x14] */
    II(0x1011802b, 0x2)   jged(0x10118036, 0x9);                /* jge 0x10118036 */
    II(0x1011802d, 0x7)   mov(memd_a32(ss, ebp - 0x18), 0x1);   /* mov dword [ebp-0x18], 0x1 */
    II(0x10118034, 0x2)   jmpd(0x1011803d, 0x7);                /* jmp 0x1011803d */
l_0x10118036:
    II(0x10118036, 0x7)   mov(memd_a32(ss, ebp - 0x18), 0xffffffff); /* mov dword [ebp-0x18], 0xffffffff */
l_0x1011803d:
    II(0x1011803d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x10118040, 0x3)   mov(memd_a32(ss, ebp - 0x1c), eax);   /* mov [ebp-0x1c], eax */
    II(0x10118043, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10118046, 0x3)   mov(al, memb_a32(ds, eax + 0x29));    /* mov al, [eax+0x29] */
    II(0x10118049, 0x2)   xor_(ah, ah);                         /* xor ah, ah */
    II(0x1011804b, 0x3)   add(eax, memd_a32(ss, ebp - 0x1c));   /* add eax, [ebp-0x1c] */
    II(0x1011804e, 0x5)   and_(eax, 0x7);                       /* and eax, 0x7 */
    II(0x10118053, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x10118056, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10118059, 0x5)   calld(0x10149fe6, 0x31f88);           /* call 0x10149fe6 */
    II(0x1011805e, 0x4)   mov(memb_a32(ss, ebp - 0xc), 0x1);    /* mov byte [ebp-0xc], 0x1 */
l_0x10118062:
    II(0x10118062, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x10118065, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10118067, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10118068, 0x1)   popd(edi);                            /* pop edi */
    II(0x10118069, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011806a, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1011806b, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1011806c, 0x1)   retd();                               /* ret */
FUNC_END

