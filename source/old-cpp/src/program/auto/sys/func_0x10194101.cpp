FUNC_BEGIN(/* sys */ 0x10194101, 0x15ea40e5c1f7d5c0, 0x20, ({0x55, 0x8b, 0xec, 0x56, 0x53, 0x8b, 0x45, 0xc, 0x8b, 0x4d, 0x10, 0x8b, 0x75, 0x8, 0x3d, 0, 0x1, 0, 0, 0x72, 0x4, 0x5b, 0x5e, 0xc9, 0xc3, 0x8d, 0x1c, 0x1, 0x81, 0xfb, 0, 0x1, 0, 0, 0x76, 0x7, 0xb9, 0, 0x1, 0, 0, 0x2b, 0xc8, 0x3, 0xf0, 0x3, 0xf0, 0x3, 0xf0, 0x8d, 0xc, 0x49, 0xba, 0xc8, 0x3, 0, 0, 0xee, 0x42, 0xf3, 0x6e, 0x5b, 0x5e, 0xc9, 0xc3}))
    II(0x10194101, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10194102, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10194104, 0x1)   pushd(esi);                           /* push esi */
    II(0x10194105, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10194106, 0x3)   mov(eax, memd_a32(ss, ebp + 0xc));    /* mov eax, [ebp+0xc] */
    II(0x10194109, 0x3)   mov(ecx, memd_a32(ss, ebp + 0x10));   /* mov ecx, [ebp+0x10] */
    II(0x1019410c, 0x3)   mov(esi, memd_a32(ss, ebp + 0x8));    /* mov esi, [ebp+0x8] */
    II(0x1019410f, 0x5)   cmp(eax, 0x100);                      /* cmp eax, 0x100 */
    II(0x10194114, 0x2)   jbd(0x1019411a, 0x4);                 /* jb 0x1019411a */
    II(0x10194116, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10194117, 0x1)   popd(esi);                            /* pop esi */
    II(0x10194118, 0x1)   leaved();                             /* leave */
    II(0x10194119, 0x1)   retd();                               /* ret */
l_0x1019411a:
    II(0x1019411a, 0x3)   lea(ebx, ecx + eax);                  /* lea ebx, [ecx+eax] */
    II(0x1019411d, 0x6)   cmp(ebx, 0x100);                      /* cmp ebx, 0x100 */
    II(0x10194123, 0x2)   jbed(0x1019412c, 0x7);                /* jbe 0x1019412c */
    II(0x10194125, 0x5)   mov(ecx, 0x100);                      /* mov ecx, 0x100 */
    II(0x1019412a, 0x2)   sub(ecx, eax);                        /* sub ecx, eax */
l_0x1019412c:
    II(0x1019412c, 0x2)   add(esi, eax);                        /* add esi, eax */
    II(0x1019412e, 0x2)   add(esi, eax);                        /* add esi, eax */
    II(0x10194130, 0x2)   add(esi, eax);                        /* add esi, eax */
    II(0x10194132, 0x3)   lea(ecx, ecx + ecx * 0x2);            /* lea ecx, [ecx+ecx*2] */
    II(0x10194135, 0x5)   mov(edx, 0x3c8);                      /* mov edx, 0x3c8 */
    II(0x1019413a, 0x1)   outb(dx, al);                         /* out dx, al */
    II(0x1019413b, 0x1)   inc(edx);                             /* inc edx */
    II(0x1019413c, 0x2)   rep_a32 outsb_a32();                  /* rep outsb */
    II(0x1019413e, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1019413f, 0x1)   popd(esi);                            /* pop esi */
    II(0x10194140, 0x1)   leaved();                             /* leave */
    II(0x10194141, 0x1)   retd();                               /* ret */
FUNC_END

