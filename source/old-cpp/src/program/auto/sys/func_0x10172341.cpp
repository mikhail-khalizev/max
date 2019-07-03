FUNC_BEGIN(/* sys */ 0x10172341, 0xbb33fb4d96bf912d, 0x20, ({0x51, 0x56, 0x57, 0x89, 0xc6, 0x89, 0xd9, 0x89, 0xd0, 0xe8, 0x5d, 0xfe, 0xff, 0xff, 0x89, 0xc3, 0x85, 0xc0, 0x74, 0x21, 0x31, 0xc0, 0xe8, 0x7a, 0xb1, 0x1, 0, 0x89, 0xc7, 0x85, 0xc0, 0x74, 0x12, 0x50, 0x8a, 0x12, 0x81, 0xe2, 0xff, 0, 0, 0, 0x89, 0xf0, 0xe8, 0xb, 0xff, 0xff, 0xff, 0x89, 0xc7, 0x89, 0xf8, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x10172341, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10172342, 0x1)   pushd(esi);                           /* push esi */
    II(0x10172343, 0x1)   pushd(edi);                           /* push edi */
    II(0x10172344, 0x2)   mov(esi, eax);                        /* mov esi, eax */
    II(0x10172346, 0x2)   mov(ecx, ebx);                        /* mov ecx, ebx */
    II(0x10172348, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x1017234a, 0x5)   calld(/* sys */ 0x101721ac, -0x1a3);  /* call 0x101721ac */
    II(0x1017234f, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x10172351, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10172353, 0x2)   jzd(0x10172376, 0x21);                /* jz 0x10172376 */
    II(0x10172355, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10172357, 0x5)   calld(/* sys */ 0x1018d4d6, 0x1b17a); /* call 0x1018d4d6 */
    II(0x1017235c, 0x2)   mov(edi, eax);                        /* mov edi, eax */
    II(0x1017235e, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10172360, 0x2)   jzd(0x10172374, 0x12);                /* jz 0x10172374 */
    II(0x10172362, 0x1)   pushd(eax);                           /* push eax */
    II(0x10172363, 0x2)   mov(dl, memb_a32(ds, edx));           /* mov dl, [edx] */
    II(0x10172365, 0x6)   and_(edx, 0xff);                      /* and edx, 0xff */
    II(0x1017236b, 0x2)   mov(eax, esi);                        /* mov eax, esi */
    II(0x1017236d, 0x5)   calld(/* sys */ 0x1017227d, -0xf5);   /* call 0x1017227d */
    II(0x10172372, 0x2)   mov(edi, eax);                        /* mov edi, eax */
l_0x10172374:
    II(0x10172374, 0x2)   mov(eax, edi);                        /* mov eax, edi */
l_0x10172376:
    II(0x10172376, 0x1)   popd(edi);                            /* pop edi */
    II(0x10172377, 0x1)   popd(esi);                            /* pop esi */
    II(0x10172378, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10172379, 0x1)   retd();                               /* ret */
FUNC_END

