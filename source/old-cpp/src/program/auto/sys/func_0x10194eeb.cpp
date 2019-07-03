FUNC_BEGIN(/* sys */ 0x10194eeb, 0x23a11983373fa22e, 0x20, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0xb8, 0x5, 0, 0, 0, 0xf, 0xb4, 0x7d, 0x10, 0xff, 0x5d, 0x8, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x10194eeb, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10194eec, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10194eee, 0x1)   pushd(esi);                           /* push esi */
    II(0x10194eef, 0x1)   pushd(edi);                           /* push edi */
    II(0x10194ef0, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10194ef1, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10194ef2, 0x2)   pushd(fs);                            /* push fs */
    II(0x10194ef4, 0x2)   pushd(gs);                            /* push gs */
    II(0x10194ef6, 0x1)   pushd(es);                            /* push es */
    II(0x10194ef7, 0x5)   mov(eax, 0x5);                        /* mov eax, 0x5 */
    II(0x10194efc, 0x4)   lfs(edi, ss, ebp + 0x10);             /* lfs edi, [ebp+0x10] */
    II(0x10194f00, 0x3)   calld_a32_far_ind(ss, ebp + 0x8);     /* call dword far [ebp+0x8] */
    II(0x10194f03, 0x1)   popd(es);                             /* pop es */
    II(0x10194f04, 0x2)   popd(gs);                             /* pop gs */
    II(0x10194f06, 0x2)   popd(fs);                             /* pop fs */
    II(0x10194f08, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10194f09, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10194f0a, 0x1)   popd(edi);                            /* pop edi */
    II(0x10194f0b, 0x1)   popd(esi);                            /* pop esi */
    II(0x10194f0c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10194f0d, 0x1)   retd();                               /* ret */
FUNC_END

