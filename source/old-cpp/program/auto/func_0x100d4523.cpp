FUNC_BEGIN(0x100d4523, 0x59b11da7e3a5c326, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x25, 0x18, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x8b, 0x80, 0x8d, 0, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x40, 0x8b, 0x45, 0xf8, 0xff, 0x52, 0x8, 0x8b, 0x45, 0xfc, 0x5, 0x87, 0, 0, 0, 0xe8, 0x5, 0x6e, 0xfb, 0xff, 0x98, 0x85, 0xc0, 0x75, 0xf, 0x8b, 0x45, 0xfc, 0x8b, 0x50, 0x3e, 0x8b, 0x45, 0xfc, 0x89, 0x90, 0x91, 0, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100d4523, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100d4528, 0x5)   calld(sys_check_available_stack_size, 0x91825); /* call 0x10165d52 */
    II(0x100d452d, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100d452e, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100d452f, 0x1)   pushd(edx);                           /* push edx */
    II(0x100d4530, 0x1)   pushd(esi);                           /* push esi */
    II(0x100d4531, 0x1)   pushd(edi);                           /* push edi */
    II(0x100d4532, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100d4533, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100d4535, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100d453b, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100d453e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d4541, 0x6)   mov(eax, memd_a32(ds, eax + 0x8d));   /* mov eax, [eax+0x8d] */
    II(0x100d4547, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100d454a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d454d, 0x3)   mov(edx, memd_a32(ds, eax + 0x40));   /* mov edx, [eax+0x40] */
//    II(0x100d4550, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100d4553, 0x3)   calld_abs(memd_a32(ds, edx + 0x8));   /* call dword near [edx+0x8] */
    II(0x100d4556, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d4559, 0x5)   add(eax, 0x87);                       /* add eax, 0x87 */
    II(0x100d455e, 0x5)   calld(my_2_get_count, -0x491fb);      /* call 0x1008b368 */
    II(0x100d4563, 0x1)   cwde();                               /* cwde */
    II(0x100d4564, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x100d4566, 0x2)   jnzd(0x100d4577, 0xf);                /* jnz 0x100d4577 */
    II(0x100d4568, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d456b, 0x3)   mov(edx, memd_a32(ds, eax + 0x3e));   /* mov edx, [eax+0x3e] */
//    II(0x100d456e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100d4571, 0x6)   mov(memd_a32(ds, eax + 0x91), edx);   /* mov [eax+0x91], edx */
l_0x100d4577:
    II(0x100d4577, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100d4579, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100d457a, 0x1)   popd(edi);                            /* pop edi */
    II(0x100d457b, 0x1)   popd(esi);                            /* pop esi */
    II(0x100d457c, 0x1)   popd(edx);                            /* pop edx */
    II(0x100d457d, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100d457e, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100d457f, 0x1)   retd();                               /* ret */
FUNC_END

