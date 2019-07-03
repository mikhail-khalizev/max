FUNC_BEGIN(/* sys */ 0x101879b4, 0xa3c75fc4f954741b, 0x20, ({0x55, 0x6, 0x53, 0x1e, 0x52, 0xe8, 0x2e, 0, 0, 0, 0x1e, 0x57, 0x89, 0xe5, 0x8b, 0x7d, 0x8, 0x8e, 0x5d, 0xc, 0x89, 0x7, 0x89, 0x5f, 0x4, 0x89, 0x4f, 0x8, 0x89, 0x57, 0xc, 0x89, 0x77, 0x10, 0x8f, 0x47, 0x14, 0x19, 0xc0, 0x89, 0x47, 0x18, 0x58, 0x5b, 0x5b, 0x5b, 0x66, 0x89, 0x43, 0x6, 0x66, 0x8c, 0x3, 0x7, 0x5d, 0xc3}))
    II(0x101879b4, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101879b5, 0x1)   pushd(es);                            /* push es */
    II(0x101879b6, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101879b7, 0x1)   pushd(ds);                            /* push ds */
    II(0x101879b8, 0x1)   pushd(edx);                           /* push edx */
    II(0x101879b9, 0x5)   calld(/* sys */ 0x101879ec, 0x2e);    /* call 0x101879ec */
    II(0x101879be, 0x1)   pushd(ds);                            /* push ds */
    II(0x101879bf, 0x1)   pushd(edi);                           /* push edi */
    II(0x101879c0, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101879c2, 0x3)   mov(edi, memd_a32(ss, ebp + 0x8));    /* mov edi, [ebp+0x8] */
    II(0x101879c5, 0x3)   mov(ds, memd_a32(ss, ebp + 0xc));     /* mov ds, [ebp+0xc] */
    II(0x101879c8, 0x2)   mov(memd_a32(ds, edi), eax);          /* mov [edi], eax */
    II(0x101879ca, 0x3)   mov(memd_a32(ds, edi + 0x4), ebx);    /* mov [edi+0x4], ebx */
    II(0x101879cd, 0x3)   mov(memd_a32(ds, edi + 0x8), ecx);    /* mov [edi+0x8], ecx */
    II(0x101879d0, 0x3)   mov(memd_a32(ds, edi + 0xc), edx);    /* mov [edi+0xc], edx */
    II(0x101879d3, 0x3)   mov(memd_a32(ds, edi + 0x10), esi);   /* mov [edi+0x10], esi */
    II(0x101879d6, 0x3)   popd(memd_a32(ds, edi + 0x14));       /* pop dword [edi+0x14] */
    II(0x101879d9, 0x2)   sbb(eax, eax);                        /* sbb eax, eax */
    II(0x101879db, 0x3)   mov(memd_a32(ds, edi + 0x18), eax);   /* mov [edi+0x18], eax */
    II(0x101879de, 0x1)   popd(eax);                            /* pop eax */
    II(0x101879df, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101879e0, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101879e1, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101879e2, 0x4)   mov(memw_a32(ds, ebx + 0x6), ax);     /* mov [ebx+0x6], ax */
    II(0x101879e6, 0x3)   mov(memw_a32(ds, ebx), es);           /* mov [ebx], es */
    II(0x101879e9, 0x1)   popd(es);                             /* pop es */
    II(0x101879ea, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101879eb, 0x1)   retd();                               /* ret */
FUNC_END

