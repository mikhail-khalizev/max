FUNC_BEGIN(0x100d7706, 0x91f57547c76e5f57, 0x20, ({0x68, 0x40, 0, 0, 0, 0xe8, 0x42, 0xe6, 0x8, 0, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x18, 0, 0, 0, 0x89, 0x45, 0xf0, 0x89, 0x55, 0xf4, 0x89, 0x5d, 0xf8, 0x89, 0x4d, 0xfc, 0x31, 0xc0, 0x8a, 0x45, 0x24, 0x50, 0xf, 0xbf, 0x45, 0x20, 0x50, 0x8b, 0x45, 0x1c, 0x50, 0x8b, 0x45, 0x18, 0x50, 0x8b, 0x45, 0x14, 0x50, 0xf, 0xbf, 0x45, 0x10, 0x50, 0x8b, 0x4d, 0xfc, 0x8b, 0x5d, 0xf8, 0x8b, 0x55, 0xf4, 0x8b, 0x45, 0xf0, 0xe8, 0x90, 0xf4, 0xff, 0xff, 0x89, 0x45, 0xf0, 0x8d, 0x45, 0xf0, 0x89, 0x45, 0xec, 0x8b, 0x45, 0xf0, 0xc7, 0x40, 0x27, 0x74, 0x5f, 0x1b, 0x10, 0x8b, 0x45, 0xf0, 0x66, 0xc7, 0x40, 0x2b, 0, 0, 0x8b, 0x45, 0xf0, 0x66, 0xc7, 0x40, 0x2d, 0, 0x90, 0x8b, 0x45, 0xf0, 0x89, 0x45, 0xe8, 0x8b, 0x45, 0xe8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0xc2, 0x18, 0}))
    II(0x100d7706, 0x5)   pushd(0x40);                          /* push dword 0x40 */
    II(0x100d770b, 0x5)   calld(sys_check_available_stack_size, 0x8e642); /* call 0x10165d52 */
    II(0x100d7710, 0x1)   pushd(esi);                           /* push esi */
    II(0x100d7711, 0x1)   pushd(edi);                           /* push edi */
    II(0x100d7712, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100d7713, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100d7715, 0x6)   sub(esp, 0x18);                       /* sub esp, 0x18 */
    II(0x100d771b, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x100d771e, 0x3)   mov(memd_a32(ss, ebp - 0xc), edx);    /* mov [ebp-0xc], edx */
    II(0x100d7721, 0x3)   mov(memd_a32(ss, ebp - 0x8), ebx);    /* mov [ebp-0x8], ebx */
    II(0x100d7724, 0x3)   mov(memd_a32(ss, ebp - 0x4), ecx);    /* mov [ebp-0x4], ecx */
    II(0x100d7727, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x100d7729, 0x3)   mov(al, memb_a32(ss, ebp + 0x24));    /* mov al, [ebp+0x24] */
    II(0x100d772c, 0x1)   pushd(eax);                           /* push eax */
    II(0x100d772d, 0x4)   movsx(eax, memw_a32(ss, ebp + 0x20)); /* movsx eax, word [ebp+0x20] */
    II(0x100d7731, 0x1)   pushd(eax);                           /* push eax */
    II(0x100d7732, 0x3)   mov(eax, memd_a32(ss, ebp + 0x1c));   /* mov eax, [ebp+0x1c] */
    II(0x100d7735, 0x1)   pushd(eax);                           /* push eax */
    II(0x100d7736, 0x3)   mov(eax, memd_a32(ss, ebp + 0x18));   /* mov eax, [ebp+0x18] */
    II(0x100d7739, 0x1)   pushd(eax);                           /* push eax */
    II(0x100d773a, 0x3)   mov(eax, memd_a32(ss, ebp + 0x14));   /* mov eax, [ebp+0x14] */
    II(0x100d773d, 0x1)   pushd(eax);                           /* push eax */
    II(0x100d773e, 0x4)   movsx(eax, memw_a32(ss, ebp + 0x10)); /* movsx eax, word [ebp+0x10] */
    II(0x100d7742, 0x1)   pushd(eax);                           /* push eax */
    II(0x100d7743, 0x3)   mov(ecx, memd_a32(ss, ebp - 0x4));    /* mov ecx, [ebp-0x4] */
    II(0x100d7746, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x8));    /* mov ebx, [ebp-0x8] */
    II(0x100d7749, 0x3)   mov(edx, memd_a32(ss, ebp - 0xc));    /* mov edx, [ebp-0xc] */
    II(0x100d774c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100d774f, 0x5)   calld(0x100d6be4, -0xb70);            /* call 0x100d6be4 */
    II(0x100d7754, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x100d7757, 0x3)   lea(eax, ebp - 0x10);                 /* lea eax, [ebp-0x10] */
    II(0x100d775a, 0x3)   mov(memd_a32(ss, ebp - 0x14), eax);   /* mov [ebp-0x14], eax */
    II(0x100d775d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100d7760, 0x7)   mov(memd_a32(ds, eax + 0x27), 0x101b5f74); /* mov dword [eax+0x27], 0x101b5f74 */
    II(0x100d7767, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100d776a, 0x6)   mov(memw_a32(ds, eax + 0x2b), 0);     /* mov word [eax+0x2b], 0x0 */
    II(0x100d7770, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100d7773, 0x6)   mov(memw_a32(ds, eax + 0x2d), 0x9000); /* mov word [eax+0x2d], 0x9000 */
    II(0x100d7779, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100d777c, 0x3)   mov(memd_a32(ss, ebp - 0x18), eax);   /* mov [ebp-0x18], eax */
//    II(0x100d777f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x18));   /* mov eax, [ebp-0x18] */
    II(0x100d7782, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100d7784, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100d7785, 0x1)   popd(edi);                            /* pop edi */
    II(0x100d7786, 0x1)   popd(esi);                            /* pop esi */
    II(0x100d7787, 0x3)   retd(0x18);                           /* ret 0x18 */
FUNC_END

