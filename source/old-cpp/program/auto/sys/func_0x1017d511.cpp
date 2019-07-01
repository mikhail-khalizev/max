FUNC_BEGIN(/* sys */ 0x1017d511, 0x73143414acd37054, 0x20, ({0x89, 0xcf, 0x7, 0x89, 0xf8, 0x85, 0xdb, 0x74, 0xd, 0x8a, 0x16, 0x88, 0x10, 0x84, 0xd2, 0x74, 0x5, 0x40, 0x46, 0x4b, 0xeb, 0xef, 0xc6, 0, 0, 0x89, 0xe8, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x1017d511, 0x2)   mov(edi, ecx);                        /* mov edi, ecx */
    II(0x1017d513, 0x1)   popd(es);                             /* pop es */
    II(0x1017d514, 0x2)   mov(eax, edi);                        /* mov eax, edi */
l_0x1017d516:
    II(0x1017d516, 0x2)   test(ebx, ebx);                       /* test ebx, ebx */
    II(0x1017d518, 0x2)   jzd(0x1017d527, 0xd);                 /* jz 0x1017d527 */
    II(0x1017d51a, 0x2)   mov(dl, memb_a32(ds, esi));           /* mov dl, [esi] */
    II(0x1017d51c, 0x2)   mov(memb_a32(ds, eax), dl);           /* mov [eax], dl */
    II(0x1017d51e, 0x2)   test(dl, dl);                         /* test dl, dl */
    II(0x1017d520, 0x2)   jzd(0x1017d527, 0x5);                 /* jz 0x1017d527 */
    II(0x1017d522, 0x1)   inc(eax);                             /* inc eax */
    II(0x1017d523, 0x1)   inc(esi);                             /* inc esi */
    II(0x1017d524, 0x1)   dec(ebx);                             /* dec ebx */
    II(0x1017d525, 0x2)   jmpd(0x1017d516, -0x11);              /* jmp 0x1017d516 */
l_0x1017d527:
    II(0x1017d527, 0x3)   mov(memb_a32(ds, eax), 0);            /* mov byte [eax], 0x0 */
    II(0x1017d52a, 0x2)   mov(eax, ebp);                        /* mov eax, ebp */
    II(0x1017d52c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1017d52d, 0x1)   popd(edi);                            /* pop edi */
    II(0x1017d52e, 0x1)   popd(esi);                            /* pop esi */
    II(0x1017d52f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1017d530, 0x1)   retd();                               /* ret */
FUNC_END

