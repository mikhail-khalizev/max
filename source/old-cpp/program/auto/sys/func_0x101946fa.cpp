FUNC_BEGIN(/* sys */ 0x101946fa, 0xb9e595f197146d19, 0x20, ({0x53, 0x80, 0xce, 0x40, 0x89, 0xd3, 0x89, 0xc2, 0xa1, 0x24, 0xa, 0x1c, 0x10, 0xc1, 0xe2, 0x2, 0x89, 0x1c, 0x2, 0x5b, 0xc3}))
    II(0x101946fa, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101946fb, 0x3)   or_(dh, 0x40);                        /* or dh, 0x40 */
    II(0x101946fe, 0x2)   mov(ebx, edx);                        /* mov ebx, edx */
    II(0x10194700, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10194702, 0x5)   mov(eax, memd_a32(ds, ptr_of_fd_table_)); /* mov eax, [0x101c0a24] */
    II(0x10194707, 0x3)   shl(edx, 0x2);                        /* shl edx, 0x2 */
    II(0x1019470a, 0x3)   mov(memd_a32(ds, edx + eax), ebx);    /* mov [edx+eax], ebx */
    II(0x1019470d, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1019470e, 0x1)   retd();                               /* ret */
FUNC_END

