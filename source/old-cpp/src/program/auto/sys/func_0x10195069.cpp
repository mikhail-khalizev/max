FUNC_BEGIN(/* sys */ 0x10195069, 0x78abf754e7c46f65, 0x20, ({0x55, 0x8b, 0xec, 0x56, 0x57, 0x53, 0x51, 0xf, 0xa0, 0xf, 0xa8, 0x6, 0xf, 0xb4, 0x7d, 0x10, 0xb8, 0, 0, 0, 0, 0x66, 0x8b, 0x5d, 0x18, 0x66, 0x8b, 0x4d, 0x1c, 0x66, 0x8b, 0x55, 0x20, 0x8a, 0xea, 0x66, 0x8b, 0x75, 0x2c, 0xff, 0x5d, 0x8, 0x7, 0xf, 0xa9, 0xf, 0xa1, 0x59, 0x5b, 0x5f, 0x5e, 0x5d, 0xc3}))
    II(0x10195069, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1019506a, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1019506c, 0x1)   pushd(esi);                           /* push esi */
    II(0x1019506d, 0x1)   pushd(edi);                           /* push edi */
    II(0x1019506e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1019506f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10195070, 0x2)   pushd(fs);                            /* push fs */
    II(0x10195072, 0x2)   pushd(gs);                            /* push gs */
    II(0x10195074, 0x1)   pushd(es);                            /* push es */
    II(0x10195075, 0x4)   lfs(edi, ss, ebp + 0x10);             /* lfs edi, [ebp+0x10] */
    II(0x10195079, 0x5)   mov(eax, 0);                          /* mov eax, 0x0 */
    II(0x1019507e, 0x4)   mov(bx, memw_a32(ss, ebp + 0x18));    /* mov bx, [ebp+0x18] */
    II(0x10195082, 0x4)   mov(cx, memw_a32(ss, ebp + 0x1c));    /* mov cx, [ebp+0x1c] */
    II(0x10195086, 0x4)   mov(dx, memw_a32(ss, ebp + 0x20));    /* mov dx, [ebp+0x20] */
    II(0x1019508a, 0x2)   mov(ch, dl);                          /* mov ch, dl */
    II(0x1019508c, 0x4)   mov(si, memw_a32(ss, ebp + 0x2c));    /* mov si, [ebp+0x2c] */
    II(0x10195090, 0x3)   calld_a32_far_ind(ss, ebp + 0x8);     /* call dword far [ebp+0x8] */
    II(0x10195093, 0x1)   popd(es);                             /* pop es */
    II(0x10195094, 0x2)   popd(gs);                             /* pop gs */
    II(0x10195096, 0x2)   popd(fs);                             /* pop fs */
    II(0x10195098, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10195099, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1019509a, 0x1)   popd(edi);                            /* pop edi */
    II(0x1019509b, 0x1)   popd(esi);                            /* pop esi */
    II(0x1019509c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1019509d, 0x1)   retd();                               /* ret */
FUNC_END

