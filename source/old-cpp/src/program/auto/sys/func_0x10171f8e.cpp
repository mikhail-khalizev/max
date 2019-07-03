FUNC_BEGIN(/* sys */ 0x10171f8e, 0x3fa7a332ca0e7d71, 0x20, ({0x53, 0x51, 0x52, 0x89, 0xc2, 0xe8, 0x25, 0, 0, 0, 0x85, 0xc0, 0x75, 0x9, 0xb8, 0xff, 0xff, 0xff, 0xff, 0x5a, 0x59, 0x5b, 0xc3, 0x8b, 0x5a, 0x4, 0x8b, 0xa, 0x4b, 0x41, 0x89, 0x5a, 0x4, 0x89, 0xa, 0x8a, 0x41, 0xff, 0x25, 0xff, 0, 0, 0, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10171f8e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10171f8f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10171f90, 0x1)   pushd(edx);                           /* push edx */
    II(0x10171f91, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10171f93, 0x5)   calld(/* sys */ 0x10171fbd, 0x25);    /* call 0x10171fbd */
    II(0x10171f98, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10171f9a, 0x2)   jnzd(0x10171fa5, 0x9);                /* jnz 0x10171fa5 */
    II(0x10171f9c, 0x5)   mov(eax, 0xffffffff);                 /* mov eax, 0xffffffff */
    II(0x10171fa1, 0x1)   popd(edx);                            /* pop edx */
    II(0x10171fa2, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10171fa3, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10171fa4, 0x1)   retd();                               /* ret */
l_0x10171fa5:
    II(0x10171fa5, 0x3)   mov(ebx, memd_a32(ds, edx + 0x4));    /* mov ebx, [edx+0x4] */
    II(0x10171fa8, 0x2)   mov(ecx, memd_a32(ds, edx));          /* mov ecx, [edx] */
    II(0x10171faa, 0x1)   dec(ebx);                             /* dec ebx */
    II(0x10171fab, 0x1)   inc(ecx);                             /* inc ecx */
    II(0x10171fac, 0x3)   mov(memd_a32(ds, edx + 0x4), ebx);    /* mov [edx+0x4], ebx */
    II(0x10171faf, 0x2)   mov(memd_a32(ds, edx), ecx);          /* mov [edx], ecx */
    II(0x10171fb1, 0x3)   mov(al, memb_a32(ds, ecx - 0x1));     /* mov al, [ecx-0x1] */
    II(0x10171fb4, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x10171fb9, 0x1)   popd(edx);                            /* pop edx */
    II(0x10171fba, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10171fbb, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10171fbc, 0x1)   retd();                               /* ret */
FUNC_END

