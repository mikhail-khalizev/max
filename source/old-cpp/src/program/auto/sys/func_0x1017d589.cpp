FUNC_BEGIN(/* sys */ 0x1017d589, 0x785a86a6baff2558, 0x20, ({0x57, 0x89, 0xc7, 0x88, 0xd8, 0x6, 0x57, 0x8e, 0xc2, 0x88, 0xc4, 0xd1, 0xe9, 0xf2, 0x66, 0xab, 0x11, 0xc9, 0xf2, 0xaa, 0x5f, 0x7, 0x89, 0xf8, 0x5f, 0xc3}))
    II(0x1017d589, 0x1)   pushd(edi);                           /* push edi */
    II(0x1017d58a, 0x2)   mov(edi, eax);                        /* mov edi, eax */
    II(0x1017d58c, 0x2)   mov(al, bl);                          /* mov al, bl */
    II(0x1017d58e, 0x1)   pushd(es);                            /* push es */
    II(0x1017d58f, 0x1)   pushd(edi);                           /* push edi */
    II(0x1017d590, 0x2)   mov(es, edx);                         /* mov es, edx */
    II(0x1017d592, 0x2)   mov(ah, al);                          /* mov ah, al */
    II(0x1017d594, 0x2)   shr(ecx, 0x1);                        /* shr ecx, 1 */
    II(0x1017d596, 0x3)   repne_a32 stosw_a32();                /* repne stosw */
    II(0x1017d599, 0x2)   adc(ecx, ecx);                        /* adc ecx, ecx */
    II(0x1017d59b, 0x2)   repne_a32 stosb_a32();                /* repne stosb */
    II(0x1017d59d, 0x1)   popd(edi);                            /* pop edi */
    II(0x1017d59e, 0x1)   popd(es);                             /* pop es */
    II(0x1017d59f, 0x2)   mov(eax, edi);                        /* mov eax, edi */
    II(0x1017d5a1, 0x1)   popd(edi);                            /* pop edi */
    II(0x1017d5a2, 0x1)   retd();                               /* ret */
FUNC_END

