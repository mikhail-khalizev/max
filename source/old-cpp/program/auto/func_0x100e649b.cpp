FUNC_BEGIN(0x100e649b, 0x5e9b8ba52b6c51f6, 0x20, ({0x68, 0x40, 0, 0, 0, 0xe8, 0xad, 0xf8, 0x7, 0, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x2c, 0, 0, 0, 0x89, 0x45, 0xf0, 0x89, 0x55, 0xf8, 0x89, 0x5d, 0xf4, 0x89, 0x4d, 0xfc, 0x31, 0xd2, 0xf, 0xbf, 0x45, 0xf8, 0xe8, 0xb5, 0x9, 0xf9, 0xff, 0x89, 0x45, 0xec, 0x31, 0xd2, 0xf, 0xbf, 0x45, 0xf4, 0xe8, 0xa7, 0x9, 0xf9, 0xff, 0x89, 0x45, 0xe8, 0x8b, 0x15, 0x46, 0x87, 0x1b, 0x10, 0xc1, 0xfa, 0x10, 0x4a, 0xf, 0xbf, 0x45, 0xfc, 0xe8, 0x99, 0x32, 0xfa, 0xff, 0x89, 0x45, 0xe4, 0xa1, 0x48, 0x87, 0x1b, 0x10, 0xc1, 0xf8, 0x10, 0x8d, 0x50, 0xff, 0xf, 0xbf, 0x45, 0x10, 0xe8, 0x82, 0x32, 0xfa, 0xff, 0x89, 0x45, 0xe0, 0x8b, 0x45, 0xe4, 0x2b, 0x45, 0xec, 0x40, 0x89, 0x45, 0xdc, 0x8b, 0x45, 0xe0, 0x2b, 0x45, 0xe8, 0x40, 0x89, 0x45, 0xd8, 0xf, 0xbf, 0x45, 0xdc, 0x85, 0xc0, 0x7e, 0x8, 0xf, 0xbf, 0x45, 0xd8, 0x85, 0xc0, 0x7f, 0x2, 0xeb, 0x35, 0xf, 0xbf, 0x45, 0xe8, 0x69, 0xd0, 0x80, 0x2, 0, 0, 0x8b, 0x45, 0xf0, 0x8b, 0x40, 0x16, 0x1, 0xc2, 0xf, 0xbf, 0x45, 0xec, 0x1, 0xc2, 0x89, 0x55, 0xd4, 0xf, 0xbf, 0x45, 0x14, 0x50, 0xb9, 0x80, 0x2, 0, 0, 0xf, 0xbf, 0x5d, 0xd8, 0xf, 0xbf, 0x55, 0xdc, 0x8b, 0x45, 0xd4, 0xe8, 0x18, 0x48, 0x8, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0xc2, 0x8, 0}))
    II(0x100e649b, 0x5)   pushd(0x40);                          /* push dword 0x40 */
    II(0x100e64a0, 0x5)   calld(sys_check_available_stack_size, 0x7f8ad); /* call 0x10165d52 */
    II(0x100e64a5, 0x1)   pushd(esi);                           /* push esi */
    II(0x100e64a6, 0x1)   pushd(edi);                           /* push edi */
    II(0x100e64a7, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100e64a8, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100e64aa, 0x6)   sub(esp, 0x2c);                       /* sub esp, 0x2c */
    II(0x100e64b0, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x100e64b3, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x100e64b6, 0x3)   mov(memd_a32(ss, ebp - 0xc), ebx);    /* mov [ebp-0xc], ebx */
    II(0x100e64b9, 0x3)   mov(memd_a32(ss, ebp - 0x4), ecx);    /* mov [ebp-0x4], ecx */
    II(0x100e64bc, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100e64be, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x100e64c2, 0x5)   calld(0x10076e7c, -0x6f64b);          /* call 0x10076e7c */
    II(0x100e64c7, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x100e64ca, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100e64cc, 0x4)   movsx(eax, memw_a32(ss, ebp - 0xc));  /* movsx eax, word [ebp-0xc] */
    II(0x100e64d0, 0x5)   calld(0x10076e7c, -0x6f659);          /* call 0x10076e7c */
    II(0x100e64d5, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
    II(0x100e64d8, 0x6)   mov(edx, memd_a32(ds, 0x101b8746));   /* mov edx, [0x101b8746] */
    II(0x100e64de, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x100e64e1, 0x1)   dec(edx);                             /* dec edx */
    II(0x100e64e2, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100e64e6, 0x5)   calld(my_min, -0x5cd67);              /* call 0x10089784 */
    II(0x100e64eb, 0x3)   mov(memd_a32(ss, ebp - 0x1c), eax);   /* mov [ebp-0x1c], eax */
    II(0x100e64ee, 0x5)   mov(eax, memd_a32(ds, 0x101b8748));   /* mov eax, [0x101b8748] */
    II(0x100e64f3, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100e64f6, 0x3)   lea(edx, eax - 0x1);                  /* lea edx, [eax-0x1] */
    II(0x100e64f9, 0x4)   movsx(eax, memw_a32(ss, ebp + 0x10)); /* movsx eax, word [ebp+0x10] */
    II(0x100e64fd, 0x5)   calld(my_min, -0x5cd7e);              /* call 0x10089784 */
    II(0x100e6502, 0x3)   mov(memd_a32(ss, ebp - 0x20), eax);   /* mov [ebp-0x20], eax */
    II(0x100e6505, 0x3)   mov(eax, memd_a32(ss, ebp - 0x1c));   /* mov eax, [ebp-0x1c] */
    II(0x100e6508, 0x3)   sub(eax, memd_a32(ss, ebp - 0x14));   /* sub eax, [ebp-0x14] */
    II(0x100e650b, 0x1)   inc(eax);                             /* inc eax */
    II(0x100e650c, 0x3)   mov(memd_a32(ss, ebp - 0x24), eax);   /* mov [ebp-0x24], eax */
    II(0x100e650f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x20));   /* mov eax, [ebp-0x20] */
    II(0x100e6512, 0x3)   sub(eax, memd_a32(ss, ebp - 0x18));   /* sub eax, [ebp-0x18] */
    II(0x100e6515, 0x1)   inc(eax);                             /* inc eax */
    II(0x100e6516, 0x3)   mov(memd_a32(ss, ebp - 0x28), eax);   /* mov [ebp-0x28], eax */
    II(0x100e6519, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x24)); /* movsx eax, word [ebp-0x24] */
    II(0x100e651d, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x100e651f, 0x2)   jled(0x100e6529, 0x8);                /* jle 0x100e6529 */
    II(0x100e6521, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x28)); /* movsx eax, word [ebp-0x28] */
    II(0x100e6525, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x100e6527, 0x2)   jgd(0x100e652b, 0x2);                 /* jg 0x100e652b */
l_0x100e6529:
    II(0x100e6529, 0x2)   jmpd(0x100e6560, 0x35);               /* jmp 0x100e6560 */
l_0x100e652b:
    II(0x100e652b, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x18)); /* movsx eax, word [ebp-0x18] */
    II(0x100e652f, 0x6)   imul(edx, eax, 0x280);                /* imul edx, eax, 0x280 */
    II(0x100e6535, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100e6538, 0x3)   mov(eax, memd_a32(ds, eax + 0x16));   /* mov eax, [eax+0x16] */
    II(0x100e653b, 0x2)   add(edx, eax);                        /* add edx, eax */
    II(0x100e653d, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x14)); /* movsx eax, word [ebp-0x14] */
    II(0x100e6541, 0x2)   add(edx, eax);                        /* add edx, eax */
    II(0x100e6543, 0x3)   mov(memd_a32(ss, ebp - 0x2c), edx);   /* mov [ebp-0x2c], edx */
    II(0x100e6546, 0x4)   movsx(eax, memw_a32(ss, ebp + 0x14)); /* movsx eax, word [ebp+0x14] */
    II(0x100e654a, 0x1)   pushd(eax);                           /* push eax */
    II(0x100e654b, 0x5)   mov(ecx, 0x280);                      /* mov ecx, 0x280 */
    II(0x100e6550, 0x4)   movsx(ebx, memw_a32(ss, ebp - 0x28)); /* movsx ebx, word [ebp-0x28] */
    II(0x100e6554, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x24)); /* movsx edx, word [ebp-0x24] */
    II(0x100e6558, 0x3)   mov(eax, memd_a32(ss, ebp - 0x2c));   /* mov eax, [ebp-0x2c] */
    II(0x100e655b, 0x5)   calld(/* sys */ 0x1016ad78, 0x84818); /* call 0x1016ad78 */
l_0x100e6560:
    II(0x100e6560, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100e6562, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100e6563, 0x1)   popd(edi);                            /* pop edi */
    II(0x100e6564, 0x1)   popd(esi);                            /* pop esi */
    II(0x100e6565, 0x3)   retd(0x8);                            /* ret 0x8 */
FUNC_END

