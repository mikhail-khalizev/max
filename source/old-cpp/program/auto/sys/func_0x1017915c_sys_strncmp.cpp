FUNC_BEGIN(sys_strncmp, 0xfb33909fba778f91, 0x20, ({0x51, 0x85, 0xdb, 0x75, 0x4, 0x31, 0xc0, 0x59, 0xc3, 0x8a, 0x8, 0x8a, 0x2a, 0x38, 0xe9, 0x74, 0xe, 0x31, 0xdb, 0x31, 0xc0, 0x88, 0xcb, 0x88, 0xe8, 0x29, 0xc3, 0x89, 0xd8, 0x59, 0xc3, 0x80, 0x38, 0, 0x74, 0xe1, 0x40, 0x42, 0x4b, 0xeb, 0xd8}))
    II(0x1017915c, 0x1)   pushd(ecx);                           /* push ecx */
l_0x1017915d:
    II(0x1017915d, 0x2)   test(ebx, ebx);                       /* test ebx, ebx */
    II(0x1017915f, 0x2)   jnzd(0x10179165, 0x4);                /* jnz 0x10179165 */
l_0x10179161:
    II(0x10179161, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10179163, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10179164, 0x1)   retd();                               /* ret */
l_0x10179165:
    II(0x10179165, 0x2)   mov(cl, memb_a32(ds, eax));           /* mov cl, [eax] */
    II(0x10179167, 0x2)   mov(ch, memb_a32(ds, edx));           /* mov ch, [edx] */
    II(0x10179169, 0x2)   cmp(cl, ch);                          /* cmp cl, ch */
    II(0x1017916b, 0x2)   jzd(0x1017917b, 0xe);                 /* jz 0x1017917b */
    II(0x1017916d, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x1017916f, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10179171, 0x2)   mov(bl, cl);                          /* mov bl, cl */
    II(0x10179173, 0x2)   mov(al, ch);                          /* mov al, ch */
    II(0x10179175, 0x2)   sub(ebx, eax);                        /* sub ebx, eax */
    II(0x10179177, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x10179179, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1017917a, 0x1)   retd();                               /* ret */
l_0x1017917b:
    II(0x1017917b, 0x3)   cmp(memb_a32(ds, eax), 0);            /* cmp byte [eax], 0x0 */
    II(0x1017917e, 0x2)   jzd(0x10179161, -0x1f);               /* jz 0x10179161 */
    II(0x10179180, 0x1)   inc(eax);                             /* inc eax */
    II(0x10179181, 0x1)   inc(edx);                             /* inc edx */
    II(0x10179182, 0x1)   dec(ebx);                             /* dec ebx */
    II(0x10179183, 0x2)   jmpd(0x1017915d, -0x28);              /* jmp 0x1017915d */
FUNC_END

