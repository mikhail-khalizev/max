FUNC_BEGIN(/* sys */ 0x10195267, 0xd72391901fb46c0c, 0x20, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0x56, 0x6, 0x66, 0xb8, 0xb, 0, 0xf, 0xb4, 0x7d, 0x20, 0xff, 0x5d, 0x18, 0x8b, 0xf0, 0x8e, 0xc2, 0x66, 0xb8, 0xc, 0, 0xf, 0xb4, 0x7d, 0x10, 0xff, 0x5d, 0x8, 0x7, 0x5e, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x10195267, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10195268, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1019526a, 0x1)   pushd(esi);                           /* push esi */
    II(0x1019526b, 0x1)   pushd(edi);                           /* push edi */
    II(0x1019526c, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1019526d, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1019526e, 0x2)   pushd(fs);                            /* push fs */
    II(0x10195270, 0x2)   pushd(gs);                            /* push gs */
    II(0x10195272, 0x1)   pushd(es);                            /* push es */
    II(0x10195273, 0x1)   pushd(esi);                           /* push esi */
    II(0x10195274, 0x1)   pushd(es);                            /* push es */
    II(0x10195275, 0x4)   mov(ax, 0xb);                         /* mov ax, 0xb */
    II(0x10195279, 0x4)   lfs(edi, ss, ebp + 0x20);             /* lfs edi, [ebp+0x20] */
    II(0x1019527d, 0x3)   calld_a32_far_ind(ss, ebp + 0x18);    /* call dword far [ebp+0x18] */
    II(0x10195280, 0x2)   mov(esi, eax);                        /* mov esi, eax */
    II(0x10195282, 0x2)   mov(es, edx);                         /* mov es, edx */
    II(0x10195284, 0x4)   mov(ax, 0xc);                         /* mov ax, 0xc */
    II(0x10195288, 0x4)   lfs(edi, ss, ebp + 0x10);             /* lfs edi, [ebp+0x10] */
    II(0x1019528c, 0x3)   calld_a32_far_ind(ss, ebp + 0x8);     /* call dword far [ebp+0x8] */
    II(0x1019528f, 0x1)   popd(es);                             /* pop es */
    II(0x10195290, 0x1)   popd(esi);                            /* pop esi */
    II(0x10195291, 0x1)   popd(es);                             /* pop es */
    II(0x10195292, 0x2)   popd(gs);                             /* pop gs */
    II(0x10195294, 0x2)   popd(fs);                             /* pop fs */
    II(0x10195296, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10195297, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10195298, 0x1)   popd(edi);                            /* pop edi */
    II(0x10195299, 0x1)   popd(esi);                            /* pop esi */
    II(0x1019529a, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1019529b, 0x1)   retd();                               /* ret */
FUNC_END

