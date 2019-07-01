FUNC_BEGIN(/* sys */ 0x10166177, 0x9bdc2871c1be425e, 0x20, ({0x51, 0x56, 0x57, 0x89, 0xd9, 0x39, 0xc2, 0x74, 0x40, 0x73, 0x28, 0x8d, 0x3c, 0x1a, 0x39, 0xc7, 0x76, 0x21, 0x8d, 0x77, 0xff, 0x8d, 0x3c, 0x18, 0x8c, 0xda, 0x4f, 0x6, 0x8e, 0xc2, 0xfd, 0x4e, 0x4f, 0xd1, 0xe9, 0x66, 0xf3, 0xa5, 0x11, 0xc9, 0x46, 0x47, 0x66, 0xf3, 0xa4, 0x7, 0xfc, 0x5f, 0x5e, 0x59, 0xc3, 0x89, 0xd6, 0x89, 0xc7, 0x8c, 0xda, 0x6, 0x8e, 0xc2, 0x51, 0xc1, 0xe9, 0x2, 0xf3, 0xa5, 0x59, 0x83, 0xe1, 0x3, 0xf3, 0xa4, 0x7, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x10166177, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10166178, 0x1)   pushd(esi);                           /* push esi */
    II(0x10166179, 0x1)   pushd(edi);                           /* push edi */
    II(0x1016617a, 0x2)   mov(ecx, ebx);                        /* mov ecx, ebx */
    II(0x1016617c, 0x2)   cmp(edx, eax);                        /* cmp edx, eax */
    II(0x1016617e, 0x2)   jzd(0x101661c0, 0x40);                /* jz 0x101661c0 */
    II(0x10166180, 0x2)   jaed(0x101661aa, 0x28);               /* jae 0x101661aa */
    II(0x10166182, 0x3)   lea(edi, edx + ebx);                  /* lea edi, [edx+ebx] */
    II(0x10166185, 0x2)   cmp(edi, eax);                        /* cmp edi, eax */
    II(0x10166187, 0x2)   jbed(0x101661aa, 0x21);               /* jbe 0x101661aa */
    II(0x10166189, 0x3)   lea(esi, edi - 0x1);                  /* lea esi, [edi-0x1] */
    II(0x1016618c, 0x3)   lea(edi, eax + ebx);                  /* lea edi, [eax+ebx] */
    II(0x1016618f, 0x2)   mov(edx, ds);                         /* mov edx, ds */
    II(0x10166191, 0x1)   dec(edi);                             /* dec edi */
    II(0x10166192, 0x1)   pushd(es);                            /* push es */
    II(0x10166193, 0x2)   mov(es, edx);                         /* mov es, edx */
    II(0x10166195, 0x1)   std_();                               /* std */
    II(0x10166196, 0x1)   dec(esi);                             /* dec esi */
    II(0x10166197, 0x1)   dec(edi);                             /* dec edi */
    II(0x10166198, 0x2)   shr(ecx, 0x1);                        /* shr ecx, 1 */
    II(0x1016619a, 0x3)   rep_a32 movsw_a32();                  /* rep movsw */
    II(0x1016619d, 0x2)   adc(ecx, ecx);                        /* adc ecx, ecx */
    II(0x1016619f, 0x1)   inc(esi);                             /* inc esi */
    II(0x101661a0, 0x1)   inc(edi);                             /* inc edi */
    II(0x101661a1, 0x3)   rep_a32 movsb_a32();                  /* o16 rep movsb */
    II(0x101661a4, 0x1)   popd(es);                             /* pop es */
    II(0x101661a5, 0x1)   cld();                                /* cld */
    II(0x101661a6, 0x1)   popd(edi);                            /* pop edi */
    II(0x101661a7, 0x1)   popd(esi);                            /* pop esi */
    II(0x101661a8, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101661a9, 0x1)   retd();                               /* ret */
l_0x101661aa:
    II(0x101661aa, 0x2)   mov(esi, edx);                        /* mov esi, edx */
    II(0x101661ac, 0x2)   mov(edi, eax);                        /* mov edi, eax */
    II(0x101661ae, 0x2)   mov(edx, ds);                         /* mov edx, ds */
    II(0x101661b0, 0x1)   pushd(es);                            /* push es */
    II(0x101661b1, 0x2)   mov(es, edx);                         /* mov es, edx */
    II(0x101661b3, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101661b4, 0x3)   shr(ecx, 0x2);                        /* shr ecx, 0x2 */
    II(0x101661b7, 0x2)   rep_a32 movsd_a32();                  /* rep movsd */
    II(0x101661b9, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101661ba, 0x3)   and_(ecx, 0x3);                       /* and ecx, 0x3 */
    II(0x101661bd, 0x2)   rep_a32 movsb_a32();                  /* rep movsb */
    II(0x101661bf, 0x1)   popd(es);                             /* pop es */
l_0x101661c0:
    II(0x101661c0, 0x1)   popd(edi);                            /* pop edi */
    II(0x101661c1, 0x1)   popd(esi);                            /* pop esi */
    II(0x101661c2, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101661c3, 0x1)   retd();                               /* ret */
FUNC_END

