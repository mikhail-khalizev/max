FUNC_BEGIN(/* sys */ 0x10181644, 0x7b02e30180232775, 0x20, ({0x51, 0x56, 0x57, 0x6, 0x89, 0xc1, 0x89, 0xde, 0x89, 0xcb, 0x8e, 0xc2, 0x31, 0xc0, 0x89, 0xd9, 0x66, 0x26, 0x8b, 0x39, 0x83, 0xc3, 0x2, 0x66, 0x85, 0xff, 0x74, 0xdf, 0x39, 0xf0, 0x74, 0xdb, 0x40, 0xeb, 0xeb}))
    II(0x10181644, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10181645, 0x1)   pushd(esi);                           /* push esi */
    II(0x10181646, 0x1)   pushd(edi);                           /* push edi */
    II(0x10181647, 0x1)   pushd(es);                            /* push es */
    II(0x10181648, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x1018164a, 0x2)   mov(esi, ebx);                        /* mov esi, ebx */
    II(0x1018164c, 0x2)   mov(ebx, ecx);                        /* mov ebx, ecx */
    II(0x1018164e, 0x2)   mov(es, edx);                         /* mov es, edx */
    II(0x10181650, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
l_0x10181652:
    II(0x10181652, 0x2)   mov(ecx, ebx);                        /* mov ecx, ebx */
    II(0x10181654, 0x4)   mov(di, memw_a32(es, ecx));           /* mov di, [es:ecx] */
    II(0x10181658, 0x3)   add(ebx, 0x2);                        /* add ebx, 0x2 */
    II(0x1018165b, 0x3)   test(di, di);                         /* test di, di */
    II(0x1018165e, 0x2)   jzd_func(0x1018163f, -0x21);          /* jz 0x1018163f */
    II(0x10181660, 0x2)   cmp(eax, esi);                        /* cmp eax, esi */
    II(0x10181662, 0x2)   jzd_func(0x1018163f, -0x25);          /* jz 0x1018163f */
    II(0x10181664, 0x1)   inc(eax);                             /* inc eax */
    II(0x10181665, 0x2)   jmpd(0x10181652, -0x15);              /* jmp 0x10181652 */
FUNC_END

