FUNC_BEGIN(0x101147a3, 0x14551299cdbff9ab, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xa5, 0x15, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0xc3, 0xf3, 0xff, 0xff, 0xe8, 0x40, 0x91, 0xff, 0xff, 0x85, 0xc0, 0xf, 0x84, 0x85, 0, 0, 0, 0xb8, 0x45, 0, 0, 0, 0xe8, 0xff, 0x17, 0xf6, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xfc, 0x88, 0x90, 0xe, 0x5, 0, 0, 0x8b, 0x45, 0xfc, 0x8a, 0x80, 0xe, 0x5, 0, 0, 0x25, 0xff, 0, 0, 0, 0xc1, 0xe0, 0x2, 0x8b, 0x90, 0x94, 0x97, 0x1b, 0x10, 0x8b, 0x45, 0xfc, 0x5, 0xf0, 0x4, 0, 0, 0xe8, 0xc3, 0x16, 0x5, 0, 0xb8, 0x4b, 0, 0, 0, 0xe8, 0xc6, 0x17, 0xf6, 0xff, 0x66, 0xa3, 0x68, 0x39, 0x1c, 0x10, 0xb8, 0x4a, 0, 0, 0, 0xe8, 0xb6, 0x17, 0xf6, 0xff, 0x66, 0xa3, 0x66, 0x39, 0x1c, 0x10, 0xba, 0x6, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xe8, 0xcd, 0xe1, 0xff, 0xff, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0xe8, 0x97, 0xfe, 0xff, 0xff, 0xb8, 0x33, 0, 0, 0, 0xe8, 0x8f, 0x17, 0xf6, 0xff, 0xf, 0xbf, 0xd0, 0x8b, 0x45, 0xfc, 0xe8, 0xc1, 0xf8, 0xff, 0xff, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0xe8, 0x68, 0xf2, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101147a3, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x101147a8, 0x5)   calld(sys_check_available_stack_size, 0x515a5); /* call 0x10165d52 */
    II(0x101147ad, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101147ae, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101147af, 0x1)   pushd(edx);                           /* push edx */
    II(0x101147b0, 0x1)   pushd(esi);                           /* push esi */
    II(0x101147b1, 0x1)   pushd(edi);                           /* push edi */
    II(0x101147b2, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101147b3, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101147b5, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x101147bb, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x101147be, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101147c1, 0x5)   calld(0x10113b89, -0xc3d);            /* call 0x10113b89 */
    II(0x101147c6, 0x5)   calld(0x1010d90b, -0x6ec0);           /* call 0x1010d90b */
    II(0x101147cb, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x101147cd, 0x6)   jzd(0x10114858, 0x85);                /* jz dword 0x10114858 */
    II(0x101147d3, 0x5)   mov(eax, 0x45);                       /* mov eax, 0x45 */
    II(0x101147d8, 0x5)   calld(0x10075fdc, -0x9e801);          /* call 0x10075fdc */
    II(0x101147dd, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x101147df, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101147e2, 0x6)   mov(memb_a32(ds, eax + 0x50e), dl);   /* mov [eax+0x50e], dl */
    II(0x101147e8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x101147eb, 0x6)   mov(al, memb_a32(ds, eax + 0x50e));   /* mov al, [eax+0x50e] */
    II(0x101147f1, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x101147f6, 0x3)   shl(eax, 0x2);                        /* shl eax, 0x2 */
    II(0x101147f9, 0x6)   mov(edx, memd_a32(ds, eax + 0x101b9794)); /* mov edx, [eax+0x101b9794] */
    II(0x101147ff, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10114802, 0x5)   add(eax, 0x4f0);                      /* add eax, 0x4f0 */
    II(0x10114807, 0x5)   calld(sys_strcpy, 0x516c3);           /* call 0x10165ecf */
    II(0x1011480c, 0x5)   mov(eax, 0x4b);                       /* mov eax, 0x4b */
    II(0x10114811, 0x5)   calld(0x10075fdc, -0x9e83a);          /* call 0x10075fdc */
    II(0x10114816, 0x6)   mov(memw_a32(ds, 0x101c3968), ax);    /* mov [0x101c3968], ax */
    II(0x1011481c, 0x5)   mov(eax, 0x4a);                       /* mov eax, 0x4a */
    II(0x10114821, 0x5)   calld(0x10075fdc, -0x9e84a);          /* call 0x10075fdc */
    II(0x10114826, 0x6)   mov(memw_a32(ds, 0x101c3966), ax);    /* mov [0x101c3966], ax */
    II(0x1011482c, 0x5)   mov(edx, 0x6);                        /* mov edx, 0x6 */
    II(0x10114831, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10114834, 0x5)   calld(0x10112a06, -0x1e33);           /* call 0x10112a06 */
    II(0x10114839, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1011483b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1011483e, 0x5)   calld(0x101146da, -0x169);            /* call 0x101146da */
    II(0x10114843, 0x5)   mov(eax, 0x33);                       /* mov eax, 0x33 */
    II(0x10114848, 0x5)   calld(0x10075fdc, -0x9e871);          /* call 0x10075fdc */
    II(0x1011484d, 0x3)   movsx(edx, ax);                       /* movsx edx, ax */
    II(0x10114850, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10114853, 0x5)   calld(0x10114119, -0x73f);            /* call 0x10114119 */
l_0x10114858:
    II(0x10114858, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1011485a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1011485d, 0x5)   calld(0x10113aca, -0xd98);            /* call 0x10113aca */
    II(0x10114862, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10114864, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10114865, 0x1)   popd(edi);                            /* pop edi */
    II(0x10114866, 0x1)   popd(esi);                            /* pop esi */
    II(0x10114867, 0x1)   popd(edx);                            /* pop edx */
    II(0x10114868, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10114869, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1011486a, 0x1)   retd();                               /* ret */
FUNC_END

