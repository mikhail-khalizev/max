FUNC_BEGIN(/* sys */ 0x101879ec, 0x3e3c3e5e15f3033c, 0x20, ({0x8d, 0x34, 0x76, 0x2e, 0x8d, 0x86, 0x92, 0x7a, 0x18, 0x10, 0x50, 0x8e, 0x3, 0x66, 0x8b, 0x6b, 0x6, 0x8b, 0x7, 0x8b, 0x5f, 0x4, 0x8b, 0x4f, 0x8, 0x8b, 0x57, 0xc, 0x8b, 0x77, 0x10, 0x8b, 0x7f, 0x14, 0x8e, 0xdd, 0xc3}))
    II(0x101879ec, 0x3)   lea(esi, esi + esi * 0x2);            /* lea esi, [esi+esi*2] */
    II(0x101879ef, 0x7)   lea(eax, esi + /* sys */ 0x10187a92); /* lea eax, [cs:esi+0x10187a92] */
    II(0x101879f6, 0x1)   pushd(eax);                           /* push eax */
    II(0x101879f7, 0x2)   mov(es, memd_a32(ds, ebx));           /* mov es, [ebx] */
    II(0x101879f9, 0x4)   mov(bp, memw_a32(ds, ebx + 0x6));     /* mov bp, [ebx+0x6] */
    II(0x101879fd, 0x2)   mov(eax, memd_a32(ds, edi));          /* mov eax, [edi] */
    II(0x101879ff, 0x3)   mov(ebx, memd_a32(ds, edi + 0x4));    /* mov ebx, [edi+0x4] */
    II(0x10187a02, 0x3)   mov(ecx, memd_a32(ds, edi + 0x8));    /* mov ecx, [edi+0x8] */
    II(0x10187a05, 0x3)   mov(edx, memd_a32(ds, edi + 0xc));    /* mov edx, [edi+0xc] */
    II(0x10187a08, 0x3)   mov(esi, memd_a32(ds, edi + 0x10));   /* mov esi, [edi+0x10] */
    II(0x10187a0b, 0x3)   mov(edi, memd_a32(ds, edi + 0x14));   /* mov edi, [edi+0x14] */
    II(0x10187a0e, 0x2)   mov(ds, ebp);                         /* mov ds, ebp */
    II(0x10187a10, 0x1)   retd();                               /* ret */
FUNC_END

