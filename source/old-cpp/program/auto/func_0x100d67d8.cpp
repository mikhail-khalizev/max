FUNC_BEGIN(0x100d67d8, 0xfd6d03829644c1c4, 0x20, ({0x68, 0x30, 0x3, 0, 0, 0xe8, 0x70, 0xf5, 0x8, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x18, 0x3, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x55, 0xf8, 0xc7, 0x42, 0x13, 0x98, 0x5f, 0x1b, 0x10, 0x8b, 0x45, 0xf8, 0xc7, 0, 0, 0, 0, 0, 0x8b, 0x55, 0xf8, 0xc7, 0x42, 0xc, 0, 0, 0, 0, 0x8b, 0x55, 0xf8, 0xc6, 0x42, 0x12, 0, 0x8b, 0x45, 0xfc, 0x8b, 0x55, 0xf8, 0x66, 0x89, 0x42, 0x10, 0x8d, 0x95, 0xec, 0xfc, 0xff, 0xff, 0xf, 0xbf, 0x45, 0xfc, 0xe8, 0x90, 0xdd, 0x5, 0, 0xf, 0xbf, 0x95, 0xf0, 0xfc, 0xff, 0xff, 0xb8, 0x80, 0x2, 0, 0, 0x29, 0xd0, 0x89, 0xc2, 0x89, 0xd0, 0xc1, 0xfa, 0x1f, 0x2b, 0xc2, 0xd1, 0xf8, 0x8b, 0x55, 0xf8, 0x66, 0x89, 0x42, 0x4, 0xf, 0xbf, 0x95, 0xf2, 0xfc, 0xff, 0xff, 0xb8, 0xe0, 0x1, 0, 0, 0x29, 0xd0, 0x89, 0xc2, 0x89, 0xd0, 0xc1, 0xfa, 0x1f, 0x2b, 0xc2, 0xd1, 0xf8, 0x8b, 0x55, 0xf8, 0x66, 0x89, 0x42, 0x6, 0x8b, 0x85, 0xf0, 0xfc, 0xff, 0xff, 0x8b, 0x55, 0xf8, 0x66, 0x89, 0x42, 0x8, 0x8b, 0x85, 0xf2, 0xfc, 0xff, 0xff, 0x8b, 0x55, 0xf8, 0x66, 0x89, 0x42, 0xa, 0x8b, 0x45, 0xf8, 0x89, 0x85, 0xe8, 0xfc, 0xff, 0xff, 0x8b, 0x85, 0xe8, 0xfc, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100d67d8, 0x5)   pushd(0x330);                         /* push dword 0x330 */
    II(0x100d67dd, 0x5)   calld(sys_check_available_stack_size, 0x8f570); /* call 0x10165d52 */
    II(0x100d67e2, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100d67e3, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100d67e4, 0x1)   pushd(esi);                           /* push esi */
    II(0x100d67e5, 0x1)   pushd(edi);                           /* push edi */
    II(0x100d67e6, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100d67e7, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100d67e9, 0x6)   sub(esp, 0x318);                      /* sub esp, 0x318 */
    II(0x100d67ef, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100d67f2, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100d67f5, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100d67f8, 0x7)   mov(memd_a32(ds, edx + 0x13), 0x101b5f98); /* mov dword [edx+0x13], 0x101b5f98 */
    II(0x100d67ff, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d6802, 0x6)   mov(memd_a32(ds, eax), 0);            /* mov dword [eax], 0x0 */
    II(0x100d6808, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100d680b, 0x7)   mov(memd_a32(ds, edx + 0xc), 0);      /* mov dword [edx+0xc], 0x0 */
    II(0x100d6812, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100d6815, 0x4)   mov(memb_a32(ds, edx + 0x12), 0);     /* mov byte [edx+0x12], 0x0 */
    II(0x100d6819, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d681c, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100d681f, 0x4)   mov(memw_a32(ds, edx + 0x10), ax);    /* mov [edx+0x10], ax */
    II(0x100d6823, 0x6)   lea(edx, ebp - 0x314);                /* lea edx, [ebp+0xfffffcec] */
    II(0x100d6829, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100d682d, 0x5)   calld(0x101345c2, 0x5dd90);           /* call 0x101345c2 */
    II(0x100d6832, 0x7)   movsx(edx, memw_a32(ss, ebp - 0x310)); /* movsx edx, word [ebp+0xfffffcf0] */
    II(0x100d6839, 0x5)   mov(eax, 0x280);                      /* mov eax, 0x280 */
    II(0x100d683e, 0x2)   sub(eax, edx);                        /* sub eax, edx */
    II(0x100d6840, 0x2)   mov(edx, eax);                        /* mov edx, eax */
//    II(0x100d6842, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x100d6844, 0x3)   sar(edx, 0x1f);                       /* sar edx, 0x1f */
    II(0x100d6847, 0x2)   sub(eax, edx);                        /* sub eax, edx */
    II(0x100d6849, 0x2)   sar(eax, 0x1);                        /* sar eax, 1 */
    II(0x100d684b, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100d684e, 0x4)   mov(memw_a32(ds, edx + 0x4), ax);     /* mov [edx+0x4], ax */
    II(0x100d6852, 0x7)   movsx(edx, memw_a32(ss, ebp - 0x30e)); /* movsx edx, word [ebp+0xfffffcf2] */
    II(0x100d6859, 0x5)   mov(eax, 0x1e0);                      /* mov eax, 0x1e0 */
    II(0x100d685e, 0x2)   sub(eax, edx);                        /* sub eax, edx */
    II(0x100d6860, 0x2)   mov(edx, eax);                        /* mov edx, eax */
//    II(0x100d6862, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x100d6864, 0x3)   sar(edx, 0x1f);                       /* sar edx, 0x1f */
    II(0x100d6867, 0x2)   sub(eax, edx);                        /* sub eax, edx */
    II(0x100d6869, 0x2)   sar(eax, 0x1);                        /* sar eax, 1 */
    II(0x100d686b, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100d686e, 0x4)   mov(memw_a32(ds, edx + 0x6), ax);     /* mov [edx+0x6], ax */
    II(0x100d6872, 0x6)   mov(eax, memd_a32(ss, ebp - 0x310));  /* mov eax, [ebp+0xfffffcf0] */
    II(0x100d6878, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100d687b, 0x4)   mov(memw_a32(ds, edx + 0x8), ax);     /* mov [edx+0x8], ax */
    II(0x100d687f, 0x6)   mov(eax, memd_a32(ss, ebp - 0x30e));  /* mov eax, [ebp+0xfffffcf2] */
    II(0x100d6885, 0x3)   mov(edx, memd_a32(ss, ebp - 0x8));    /* mov edx, [ebp-0x8] */
    II(0x100d6888, 0x4)   mov(memw_a32(ds, edx + 0xa), ax);     /* mov [edx+0xa], ax */
    II(0x100d688c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d688f, 0x6)   mov(memd_a32(ss, ebp - 0x318), eax);  /* mov [ebp+0xfffffce8], eax */
//    II(0x100d6895, 0x6)   mov(eax, memd_a32(ss, ebp - 0x318));  /* mov eax, [ebp+0xfffffce8] */
    II(0x100d689b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100d689d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100d689e, 0x1)   popd(edi);                            /* pop edi */
    II(0x100d689f, 0x1)   popd(esi);                            /* pop esi */
    II(0x100d68a0, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100d68a1, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100d68a2, 0x1)   retd();                               /* ret */
FUNC_END

