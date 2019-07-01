FUNC_BEGIN(0x101211ea, 0xb49d5b3d49fc8aa2, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x5e, 0x4b, 0x4, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0xa0, 0x20, 0x56, 0x1c, 0x10, 0x88, 0x45, 0xfc, 0x8a, 0x45, 0xfc, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101211ea, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x101211ef, 0x5)   calld(sys_check_available_stack_size, 0x44b5e); /* call 0x10165d52 */
    II(0x101211f4, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101211f5, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101211f6, 0x1)   pushd(edx);                           /* push edx */
    II(0x101211f7, 0x1)   pushd(esi);                           /* push esi */
    II(0x101211f8, 0x1)   pushd(edi);                           /* push edi */
    II(0x101211f9, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101211fa, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101211fc, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10121202, 0x5)   mov(al, memb_a32(ds, 0x101c5620));    /* mov al, [0x101c5620] */
    II(0x10121207, 0x3)   mov(memb_a32(ss, ebp - 0x4), al);     /* mov [ebp-0x4], al */
//    II(0x1012120a, 0x3)   mov(al, memb_a32(ss, ebp - 0x4));     /* mov al, [ebp-0x4] */
    II(0x1012120d, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1012120f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10121210, 0x1)   popd(edi);                            /* pop edi */
    II(0x10121211, 0x1)   popd(esi);                            /* pop esi */
    II(0x10121212, 0x1)   popd(edx);                            /* pop edx */
    II(0x10121213, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10121214, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10121215, 0x1)   retd();                               /* ret */
FUNC_END

