FUNC_BEGIN(0x10119ce6, 0x1f0ee08fcb5806c8, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x62, 0xc0, 0x4, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x5d, 0xf8, 0x8b, 0x5b, 0x14, 0xc1, 0xfb, 0x10, 0xba, 0xd, 0x7d, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0xdc, 0xd7, 0x2, 0, 0x8b, 0x5d, 0xf8, 0x8a, 0x5b, 0x18, 0x81, 0xe3, 0xff, 0, 0, 0, 0xba, 0x14, 0x7d, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0xc3, 0xd7, 0x2, 0, 0x8b, 0x5d, 0xf8, 0x8b, 0x5b, 0x17, 0xc1, 0xfb, 0x10, 0xba, 0x1a, 0x7d, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0xad, 0xd7, 0x2, 0, 0x8b, 0x5d, 0xf8, 0x8b, 0x5b, 0x19, 0xc1, 0xfb, 0x10, 0xba, 0x28, 0x7d, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x97, 0xd7, 0x2, 0, 0x8b, 0x5d, 0xf8, 0x8b, 0x5b, 0x6, 0xc1, 0xfb, 0x10, 0xba, 0x36, 0x7d, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x81, 0xd7, 0x2, 0, 0x8b, 0x5d, 0xf8, 0x8b, 0x5b, 0x8, 0xc1, 0xfb, 0x10, 0xba, 0x3c, 0x7d, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x6b, 0xd7, 0x2, 0, 0x8b, 0x5d, 0xf8, 0x8b, 0x5b, 0x1d, 0xba, 0x42, 0x7d, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x58, 0xd7, 0x2, 0, 0x8b, 0x5d, 0xf8, 0x8b, 0x5b, 0x21, 0xba, 0x49, 0x7d, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x45, 0xd7, 0x2, 0, 0x8b, 0x5d, 0xf8, 0x8b, 0x5b, 0x25, 0xba, 0x50, 0x7d, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x32, 0xd7, 0x2, 0, 0x8b, 0x5d, 0xf8, 0x8b, 0x5b, 0x29, 0xba, 0x58, 0x7d, 0x1a, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x1f, 0xd7, 0x2, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10119ce6, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10119ceb, 0x5)   calld(sys_check_available_stack_size, 0x4c062); /* call 0x10165d52 */
    II(0x10119cf0, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10119cf1, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10119cf2, 0x1)   pushd(esi);                           /* push esi */
    II(0x10119cf3, 0x1)   pushd(edi);                           /* push edi */
    II(0x10119cf4, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10119cf5, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10119cf7, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x10119cfd, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10119d00, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x10119d03, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x8));    /* mov ebx, [ebp-0x8] */
    II(0x10119d06, 0x3)   mov(ebx, memd_a32(ds, ebx + 0x14));   /* mov ebx, [ebx+0x14] */
    II(0x10119d09, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x10119d0c, 0x5)   mov(edx, 0x101a7d0d);                 /* mov edx, 0x101a7d0d */ /* "length" */
    II(0x10119d11, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119d14, 0x5)   calld(0x101474f5, 0x2d7dc);           /* call 0x101474f5 */
    II(0x10119d19, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x8));    /* mov ebx, [ebp-0x8] */
    II(0x10119d1c, 0x3)   mov(bl, memb_a32(ds, ebx + 0x18));    /* mov bl, [ebx+0x18] */
    II(0x10119d1f, 0x6)   and_(ebx, 0xff);                      /* and ebx, 0xff */
    II(0x10119d25, 0x5)   mov(edx, 0x101a7d14);                 /* mov edx, 0x101a7d14 */ /* "angle" */
    II(0x10119d2a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119d2d, 0x5)   calld(0x101474f5, 0x2d7c3);           /* call 0x101474f5 */
    II(0x10119d32, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x8));    /* mov ebx, [ebp-0x8] */
    II(0x10119d35, 0x3)   mov(ebx, memd_a32(ds, ebx + 0x17));   /* mov ebx, [ebx+0x17] */
    II(0x10119d38, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x10119d3b, 0x5)   mov(edx, 0x101a7d1a);                 /* mov edx, 0x101a7d1a */ /* "pixel_x_start" */
    II(0x10119d40, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119d43, 0x5)   calld(0x101474f5, 0x2d7ad);           /* call 0x101474f5 */
    II(0x10119d48, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x8));    /* mov ebx, [ebp-0x8] */
    II(0x10119d4b, 0x3)   mov(ebx, memd_a32(ds, ebx + 0x19));   /* mov ebx, [ebx+0x19] */
    II(0x10119d4e, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x10119d51, 0x5)   mov(edx, 0x101a7d28);                 /* mov edx, 0x101a7d28 */ /* "pixel_y_start" */
    II(0x10119d56, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119d59, 0x5)   calld(0x101474f5, 0x2d797);           /* call 0x101474f5 */
    II(0x10119d5e, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x8));    /* mov ebx, [ebp-0x8] */
    II(0x10119d61, 0x3)   mov(ebx, memd_a32(ds, ebx + 0x6));    /* mov ebx, [ebx+0x6] */
    II(0x10119d64, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x10119d67, 0x5)   mov(edx, 0x101a7d36);                 /* mov edx, 0x101a7d36 */ /* "x_end" */
    II(0x10119d6c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119d6f, 0x5)   calld(0x101474f5, 0x2d781);           /* call 0x101474f5 */
    II(0x10119d74, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x8));    /* mov ebx, [ebp-0x8] */
    II(0x10119d77, 0x3)   mov(ebx, memd_a32(ds, ebx + 0x8));    /* mov ebx, [ebx+0x8] */
    II(0x10119d7a, 0x3)   sar(ebx, 0x10);                       /* sar ebx, 0x10 */
    II(0x10119d7d, 0x5)   mov(edx, 0x101a7d3c);                 /* mov edx, 0x101a7d3c */ /* "y_end" */
    II(0x10119d82, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119d85, 0x5)   calld(0x101474f5, 0x2d76b);           /* call 0x101474f5 */
    II(0x10119d8a, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x8));    /* mov ebx, [ebp-0x8] */
    II(0x10119d8d, 0x3)   mov(ebx, memd_a32(ds, ebx + 0x1d));   /* mov ebx, [ebx+0x1d] */
    II(0x10119d90, 0x5)   mov(edx, 0x101a7d42);                 /* mov edx, 0x101a7d42 */ /* "x_step" */
    II(0x10119d95, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119d98, 0x5)   calld(0x101474f5, 0x2d758);           /* call 0x101474f5 */
    II(0x10119d9d, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x8));    /* mov ebx, [ebp-0x8] */
    II(0x10119da0, 0x3)   mov(ebx, memd_a32(ds, ebx + 0x21));   /* mov ebx, [ebx+0x21] */
    II(0x10119da3, 0x5)   mov(edx, 0x101a7d49);                 /* mov edx, 0x101a7d49 */ /* "y_step" */
    II(0x10119da8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119dab, 0x5)   calld(0x101474f5, 0x2d745);           /* call 0x101474f5 */
    II(0x10119db0, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x8));    /* mov ebx, [ebp-0x8] */
    II(0x10119db3, 0x3)   mov(ebx, memd_a32(ds, ebx + 0x25));   /* mov ebx, [ebx+0x25] */
    II(0x10119db6, 0x5)   mov(edx, 0x101a7d50);                 /* mov edx, 0x101a7d50 */ /* "delta_x" */
    II(0x10119dbb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119dbe, 0x5)   calld(0x101474f5, 0x2d732);           /* call 0x101474f5 */
    II(0x10119dc3, 0x3)   mov(ebx, memd_a32(ss, ebp - 0x8));    /* mov ebx, [ebp-0x8] */
    II(0x10119dc6, 0x3)   mov(ebx, memd_a32(ds, ebx + 0x29));   /* mov ebx, [ebx+0x29] */
    II(0x10119dc9, 0x5)   mov(edx, 0x101a7d58);                 /* mov edx, 0x101a7d58 */ /* "delta_y" */
    II(0x10119dce, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10119dd1, 0x5)   calld(0x101474f5, 0x2d71f);           /* call 0x101474f5 */
    II(0x10119dd6, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10119dd8, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10119dd9, 0x1)   popd(edi);                            /* pop edi */
    II(0x10119dda, 0x1)   popd(esi);                            /* pop esi */
    II(0x10119ddb, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10119ddc, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10119ddd, 0x1)   retd();                               /* ret */
FUNC_END

