FUNC_BEGIN(0x101099a7, 0x2181352a84952d41, 0x20, ({0x68, 0x2c, 0, 0, 0, 0xe8, 0xa1, 0xc3, 0x5, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x83, 0x3d, 0xd8, 0x4d, 0x1c, 0x10, 0, 0x74, 0xa, 0xa1, 0xd8, 0x4d, 0x1c, 0x10, 0xe8, 0x92, 0xc5, 0x5, 0, 0xc7, 0x5, 0xd8, 0x4d, 0x1c, 0x10, 0, 0, 0, 0, 0x83, 0x3d, 0xdc, 0x4d, 0x1c, 0x10, 0, 0x74, 0x14, 0xba, 0x10, 0x5c, 0x1b, 0x10, 0xa1, 0xdc, 0x4d, 0x1c, 0x10, 0xe8, 0xc4, 0xc5, 0x5, 0, 0xe8, 0xdf, 0xc5, 0x5, 0, 0xc7, 0x5, 0xdc, 0x4d, 0x1c, 0x10, 0, 0, 0, 0, 0x83, 0x3d, 0xe0, 0x4d, 0x1c, 0x10, 0, 0x74, 0x29, 0xa1, 0xe0, 0x4d, 0x1c, 0x10, 0x89, 0x45, 0xf8, 0x83, 0x7d, 0xf8, 0, 0x74, 0x14, 0x31, 0xd2, 0x8b, 0x45, 0xf8, 0xe8, 0x14, 0x4b, 0xfc, 0xff, 0xe8, 0x3b, 0xc5, 0x5, 0, 0x89, 0x45, 0xfc, 0xeb, 0x7, 0xc7, 0x45, 0xfc, 0, 0, 0, 0, 0xc7, 0x5, 0xe0, 0x4d, 0x1c, 0x10, 0, 0, 0, 0, 0x83, 0x3d, 0xe4, 0x4d, 0x1c, 0x10, 0, 0x74, 0x29, 0xa1, 0xe4, 0x4d, 0x1c, 0x10, 0x89, 0x45, 0xf0, 0x83, 0x7d, 0xf0, 0, 0x74, 0x14, 0x31, 0xd2, 0x8b, 0x45, 0xf0, 0xe8, 0xd8, 0x4a, 0xfc, 0xff, 0xe8, 0xff, 0xc4, 0x5, 0, 0x89, 0x45, 0xf4, 0xeb, 0x7, 0xc7, 0x45, 0xf4, 0, 0, 0, 0, 0xc7, 0x5, 0xe4, 0x4d, 0x1c, 0x10, 0, 0, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101099a7, 0x5)   pushd(0x2c);                          /* push dword 0x2c */
    II(0x101099ac, 0x5)   calld(sys_check_available_stack_size, 0x5c3a1); /* call 0x10165d52 */
    II(0x101099b1, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101099b2, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101099b3, 0x1)   pushd(edx);                           /* push edx */
    II(0x101099b4, 0x1)   pushd(esi);                           /* push esi */
    II(0x101099b5, 0x1)   pushd(edi);                           /* push edi */
    II(0x101099b6, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101099b7, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101099b9, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x101099bf, 0x7)   cmp(memd_a32(ds, 0x101c4dd8), 0);     /* cmp dword [0x101c4dd8], 0x0 */
    II(0x101099c6, 0x2)   jzd(0x101099d2, 0xa);                 /* jz 0x101099d2 */
    II(0x101099c8, 0x5)   mov(eax, memd_a32(ds, 0x101c4dd8));   /* mov eax, [0x101c4dd8] */
    II(0x101099cd, 0x5)   calld(sys_delete, 0x5c592);           /* call 0x10165f64 */
l_0x101099d2:
    II(0x101099d2, 0xa)   mov(memd_a32(ds, 0x101c4dd8), 0);     /* mov dword [0x101c4dd8], 0x0 */
    II(0x101099dc, 0x7)   cmp(memd_a32(ds, 0x101c4ddc), 0);     /* cmp dword [0x101c4ddc], 0x0 */
    II(0x101099e3, 0x2)   jzd(0x101099f9, 0x14);                /* jz 0x101099f9 */
    II(0x101099e5, 0x5)   mov(edx, 0x101b5c10);                 /* mov edx, 0x101b5c10 */
    II(0x101099ea, 0x5)   mov(eax, memd_a32(ds, 0x101c4ddc));   /* mov eax, [0x101c4ddc] */
    II(0x101099ef, 0x5)   calld(sys_call_dtor_arr, 0x5c5c4);    /* call 0x10165fb8 */
    II(0x101099f4, 0x5)   calld(sys_delete_arr, 0x5c5df);       /* call 0x10165fd8 */
l_0x101099f9:
    II(0x101099f9, 0xa)   mov(memd_a32(ds, 0x101c4ddc), 0);     /* mov dword [0x101c4ddc], 0x0 */
    II(0x10109a03, 0x7)   cmp(memd_a32(ds, 0x101c4de0), 0);     /* cmp dword [0x101c4de0], 0x0 */
    II(0x10109a0a, 0x2)   jzd(0x10109a35, 0x29);                /* jz 0x10109a35 */
    II(0x10109a0c, 0x5)   mov(eax, memd_a32(ds, 0x101c4de0));   /* mov eax, [0x101c4de0] */
    II(0x10109a11, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10109a14, 0x4)   cmp(memd_a32(ss, ebp - 0x8), 0);      /* cmp dword [ebp-0x8], 0x0 */
    II(0x10109a18, 0x2)   jzd(0x10109a2e, 0x14);                /* jz 0x10109a2e */
    II(0x10109a1a, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10109a1c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10109a1f, 0x5)   calld(my_dtor_d2, -0x3b4ec);          /* call 0x100ce538 */
    II(0x10109a24, 0x5)   calld(sys_delete, 0x5c53b);           /* call 0x10165f64 */
    II(0x10109a29, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10109a2c, 0x2)   jmpd(0x10109a35, 0x7);                /* jmp 0x10109a35 */
l_0x10109a2e:
    II(0x10109a2e, 0x7)   mov(memd_a32(ss, ebp - 0x4), 0);      /* mov dword [ebp-0x4], 0x0 */
l_0x10109a35:
    II(0x10109a35, 0xa)   mov(memd_a32(ds, 0x101c4de0), 0);     /* mov dword [0x101c4de0], 0x0 */
    II(0x10109a3f, 0x7)   cmp(memd_a32(ds, 0x101c4de4), 0);     /* cmp dword [0x101c4de4], 0x0 */
    II(0x10109a46, 0x2)   jzd(0x10109a71, 0x29);                /* jz 0x10109a71 */
    II(0x10109a48, 0x5)   mov(eax, memd_a32(ds, 0x101c4de4));   /* mov eax, [0x101c4de4] */
    II(0x10109a4d, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
    II(0x10109a50, 0x4)   cmp(memd_a32(ss, ebp - 0x10), 0);     /* cmp dword [ebp-0x10], 0x0 */
    II(0x10109a54, 0x2)   jzd(0x10109a6a, 0x14);                /* jz 0x10109a6a */
    II(0x10109a56, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10109a58, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x10109a5b, 0x5)   calld(my_dtor_d2, -0x3b528);          /* call 0x100ce538 */
    II(0x10109a60, 0x5)   calld(sys_delete, 0x5c4ff);           /* call 0x10165f64 */
    II(0x10109a65, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x10109a68, 0x2)   jmpd(0x10109a71, 0x7);                /* jmp 0x10109a71 */
l_0x10109a6a:
    II(0x10109a6a, 0x7)   mov(memd_a32(ss, ebp - 0xc), 0);      /* mov dword [ebp-0xc], 0x0 */
l_0x10109a71:
    II(0x10109a71, 0xa)   mov(memd_a32(ds, 0x101c4de4), 0);     /* mov dword [0x101c4de4], 0x0 */
    II(0x10109a7b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10109a7d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10109a7e, 0x1)   popd(edi);                            /* pop edi */
    II(0x10109a7f, 0x1)   popd(esi);                            /* pop esi */
    II(0x10109a80, 0x1)   popd(edx);                            /* pop edx */
    II(0x10109a81, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10109a82, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10109a83, 0x1)   retd();                               /* ret */
FUNC_END

