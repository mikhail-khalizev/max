FUNC_BEGIN(/* sys */ 0x10179244, 0x2e621ee26bd6d626, 0x20, ({0x53, 0x89, 0xd3, 0x89, 0xc2, 0x4a, 0x29, 0xc0, 0xb4, 0xe, 0xcd, 0x21, 0xb4, 0, 0x89, 0x3, 0x29, 0xc0, 0x5b, 0xc3}))
    II(0x10179244, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10179245, 0x2)   mov(ebx, edx);                        /* mov ebx, edx */
    II(0x10179247, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10179249, 0x1)   dec(edx);                             /* dec edx */
    II(0x1017924a, 0x2)   sub(eax, eax);                        /* sub eax, eax */
    II(0x1017924c, 0x2)   mov(ah, 0xe);                         /* mov ah, 0xe */
    II(0x1017924e, 0x2)   int_(0x21);                           /* int 0x21 */
    II(0x10179250, 0x2)   mov(ah, 0);                           /* mov ah, 0x0 */
    II(0x10179252, 0x2)   mov(memd_a32(ds, ebx), eax);          /* mov [ebx], eax */
    II(0x10179254, 0x2)   sub(eax, eax);                        /* sub eax, eax */
    II(0x10179256, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10179257, 0x1)   retd();                               /* ret */
FUNC_END

