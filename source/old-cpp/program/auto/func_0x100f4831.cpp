FUNC_BEGIN(0x100f4831, 0x89c43b67dcb3c63d, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x17, 0x15, 0x7, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x88, 0x45, 0xfc, 0x8a, 0x45, 0xfc, 0xa2, 0x89, 0x38, 0x1c, 0x10, 0xa0, 0x89, 0x38, 0x1c, 0x10, 0xa2, 0x37, 0x88, 0x1b, 0x10, 0x31, 0xd2, 0x8a, 0x15, 0x89, 0x38, 0x1c, 0x10, 0xa1, 0x33, 0x88, 0x1b, 0x10, 0xe8, 0x3, 0xb3, 0xfd, 0xff, 0xe8, 0x4c, 0xad, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100f4831, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x100f4836, 0x5)   calld(sys_check_available_stack_size, 0x71517); /* call 0x10165d52 */
    II(0x100f483b, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100f483c, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100f483d, 0x1)   pushd(edx);                           /* push edx */
    II(0x100f483e, 0x1)   pushd(esi);                           /* push esi */
    II(0x100f483f, 0x1)   pushd(edi);                           /* push edi */
    II(0x100f4840, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100f4841, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100f4843, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x100f4849, 0x3)   mov(memb_a32(ss, ebp - 0x4), al);     /* mov [ebp-0x4], al */
//    II(0x100f484c, 0x3)   mov(al, memb_a32(ss, ebp - 0x4));     /* mov al, [ebp-0x4] */
    II(0x100f484f, 0x5)   mov(memb_a32(ds, 0x101c3889), al);    /* mov [0x101c3889], al */
//    II(0x100f4854, 0x5)   mov(al, memb_a32(ds, 0x101c3889));    /* mov al, [0x101c3889] */
    II(0x100f4859, 0x5)   mov(memb_a32(ds, 0x101b8837), al);    /* mov [0x101b8837], al */
    II(0x100f485e, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100f4860, 0x6)   mov(dl, memb_a32(ds, 0x101c3889));    /* mov dl, [0x101c3889] */
    II(0x100f4866, 0x5)   mov(eax, memd_a32(ds, 0x101b8833));   /* mov eax, [0x101b8833] */
    II(0x100f486b, 0x5)   calld(0x100cfb73, -0x24cfd);          /* call 0x100cfb73 */
    II(0x100f4870, 0x5)   calld(0x100ff5c1, 0xad4c);            /* call 0x100ff5c1 */
    II(0x100f4875, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100f4877, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100f4878, 0x1)   popd(edi);                            /* pop edi */
    II(0x100f4879, 0x1)   popd(esi);                            /* pop esi */
    II(0x100f487a, 0x1)   popd(edx);                            /* pop edx */
    II(0x100f487b, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100f487c, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100f487d, 0x1)   retd();                               /* ret */
FUNC_END

