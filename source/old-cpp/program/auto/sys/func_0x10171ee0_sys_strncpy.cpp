FUNC_BEGIN(sys_strncpy, 0x438e0b9fa50a9449, 0x20, ({0x51, 0x56, 0x89, 0xc6, 0xeb, 0xb, 0x8a, 0xa, 0x84, 0xc9, 0x74, 0x9, 0x42, 0x4b, 0x88, 0x8, 0x40, 0x85, 0xdb, 0x75, 0xf1, 0x85, 0xdb, 0x74, 0x7, 0x4b, 0xc6, 0, 0, 0x40, 0xeb, 0xf5, 0x89, 0xf0, 0x5e, 0x59, 0xc3}))
    II(0x10171ee0, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10171ee1, 0x1)   pushd(esi);                           /* push esi */
    II(0x10171ee2, 0x2)   mov(esi, eax);                        /* mov esi, eax */
    II(0x10171ee4, 0x2)   jmpd(0x10171ef1, 0xb);                /* jmp 0x10171ef1 */
l_0x10171ee6:
    II(0x10171ee6, 0x2)   mov(cl, memb_a32(ds, edx));           /* mov cl, [edx] */
    II(0x10171ee8, 0x2)   test(cl, cl);                         /* test cl, cl */
    II(0x10171eea, 0x2)   jzd(0x10171ef5, 0x9);                 /* jz 0x10171ef5 */
    II(0x10171eec, 0x1)   inc(edx);                             /* inc edx */
    II(0x10171eed, 0x1)   dec(ebx);                             /* dec ebx */
    II(0x10171eee, 0x2)   mov(memb_a32(ds, eax), cl);           /* mov [eax], cl */
    II(0x10171ef0, 0x1)   inc(eax);                             /* inc eax */
l_0x10171ef1:
    II(0x10171ef1, 0x2)   test(ebx, ebx);                       /* test ebx, ebx */
    II(0x10171ef3, 0x2)   jnzd(0x10171ee6, -0xf);               /* jnz 0x10171ee6 */
l_0x10171ef5:
    II(0x10171ef5, 0x2)   test(ebx, ebx);                       /* test ebx, ebx */
    II(0x10171ef7, 0x2)   jzd(0x10171f00, 0x7);                 /* jz 0x10171f00 */
    II(0x10171ef9, 0x1)   dec(ebx);                             /* dec ebx */
    II(0x10171efa, 0x3)   mov(memb_a32(ds, eax), 0);            /* mov byte [eax], 0x0 */
    II(0x10171efd, 0x1)   inc(eax);                             /* inc eax */
    II(0x10171efe, 0x2)   jmpd(0x10171ef5, -0xb);               /* jmp 0x10171ef5 */
l_0x10171f00:
    II(0x10171f00, 0x2)   mov(eax, esi);                        /* mov eax, esi */
    II(0x10171f02, 0x1)   popd(esi);                            /* pop esi */
    II(0x10171f03, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10171f04, 0x1)   retd();                               /* ret */
FUNC_END

