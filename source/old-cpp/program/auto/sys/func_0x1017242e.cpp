FUNC_BEGIN(/* sys */ 0x1017242e, 0x2a4367b36e3ec5e4, 0x20, ({0x53, 0x51, 0x56, 0x57, 0x80, 0x62, 0xc, 0xef, 0x3b, 0x42, 0x4, 0x7f, 0x1f, 0x8b, 0x5a, 0x8, 0x8b, 0xa, 0x29, 0xcb, 0x39, 0xd8, 0x7c, 0x14, 0x8b, 0x7a, 0x4, 0x8d, 0x34, 0x1, 0x29, 0xc7, 0x89, 0x32, 0x31, 0xc0, 0x89, 0x7a, 0x4, 0x5f, 0x5e, 0x59, 0x5b, 0xc3, 0x8b, 0x42, 0x8, 0xc7, 0x42, 0x4, 0, 0, 0, 0, 0x89, 0x2, 0xb8, 0x1, 0, 0, 0, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x1017242e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1017242f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10172430, 0x1)   pushd(esi);                           /* push esi */
    II(0x10172431, 0x1)   pushd(edi);                           /* push edi */
    II(0x10172432, 0x4)   and_(memb_a32(ds, edx + 0xc), -0x11 /* 0xef */); /* and byte [edx+0xc], 0xef */
    II(0x10172436, 0x3)   cmp(eax, memd_a32(ds, edx + 0x4));    /* cmp eax, [edx+0x4] */
    II(0x10172439, 0x2)   jgd(0x1017245a, 0x1f);                /* jg 0x1017245a */
    II(0x1017243b, 0x3)   mov(ebx, memd_a32(ds, edx + 0x8));    /* mov ebx, [edx+0x8] */
    II(0x1017243e, 0x2)   mov(ecx, memd_a32(ds, edx));          /* mov ecx, [edx] */
    II(0x10172440, 0x2)   sub(ebx, ecx);                        /* sub ebx, ecx */
    II(0x10172442, 0x2)   cmp(eax, ebx);                        /* cmp eax, ebx */
    II(0x10172444, 0x2)   jld(0x1017245a, 0x14);                /* jl 0x1017245a */
    II(0x10172446, 0x3)   mov(edi, memd_a32(ds, edx + 0x4));    /* mov edi, [edx+0x4] */
    II(0x10172449, 0x3)   lea(esi, ecx + eax);                  /* lea esi, [ecx+eax] */
    II(0x1017244c, 0x2)   sub(edi, eax);                        /* sub edi, eax */
    II(0x1017244e, 0x2)   mov(memd_a32(ds, edx), esi);          /* mov [edx], esi */
    II(0x10172450, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10172452, 0x3)   mov(memd_a32(ds, edx + 0x4), edi);    /* mov [edx+0x4], edi */
    II(0x10172455, 0x1)   popd(edi);                            /* pop edi */
    II(0x10172456, 0x1)   popd(esi);                            /* pop esi */
    II(0x10172457, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10172458, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10172459, 0x1)   retd();                               /* ret */
l_0x1017245a:
    II(0x1017245a, 0x3)   mov(eax, memd_a32(ds, edx + 0x8));    /* mov eax, [edx+0x8] */
    II(0x1017245d, 0x7)   mov(memd_a32(ds, edx + 0x4), 0);      /* mov dword [edx+0x4], 0x0 */
    II(0x10172464, 0x2)   mov(memd_a32(ds, edx), eax);          /* mov [edx], eax */
    II(0x10172466, 0x5)   mov(eax, 0x1);                        /* mov eax, 0x1 */
    II(0x1017246b, 0x1)   popd(edi);                            /* pop edi */
    II(0x1017246c, 0x1)   popd(esi);                            /* pop esi */
    II(0x1017246d, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1017246e, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1017246f, 0x1)   retd();                               /* ret */
FUNC_END

