FUNC_BEGIN(0x100f3f62, 0x2cde96474ae74cf3, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xe6, 0x1d, 0x7, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x80, 0x78, 0x3e, 0x6, 0x75, 0x9, 0x31, 0xc0, 0xe8, 0x71, 0xcf, 0, 0, 0xeb, 0xee, 0xe8, 0xd8, 0x20, 0x2, 0, 0x8b, 0x45, 0xfc, 0x80, 0x78, 0x3e, 0x19, 0xf, 0x85, 0x9a, 0, 0, 0, 0xb9, 0xff, 0xff, 0xff, 0xff, 0xbb, 0xe1, 0x3, 0, 0, 0xba, 0xde, 0x3, 0, 0, 0xb8, 0x78, 0x72, 0x1c, 0x10, 0xe8, 0x30, 0x9b, 0x4, 0, 0x31, 0xd2, 0xb8, 0xc0, 0x37, 0x1c, 0x10, 0xe8, 0xab, 0x6d, 0x4, 0, 0x84, 0xc0, 0x74, 0x9, 0xc7, 0x45, 0xf8, 0, 0, 0, 0, 0xeb, 0x19, 0xb9, 0x86, 0x7, 0, 0, 0xbb, 0x11, 0x25, 0x1a, 0x10, 0xba, 0x1d, 0x25, 0x1a, 0x10, 0x31, 0xc0, 0xe8, 0xa9, 0x1d, 0x7, 0, 0x89, 0x45, 0xf8, 0xb8, 0xc0, 0x37, 0x1c, 0x10, 0xe8, 0xa, 0x26, 0xf8, 0xff, 0xe8, 0xd1, 0xb2, 0x6, 0, 0x31, 0xd2, 0xb8, 0xc0, 0x37, 0x1c, 0x10, 0xe8, 0x29, 0x26, 0xf8, 0xff, 0x8d, 0x55, 0xf4, 0x8b, 0x45, 0xfc, 0xe8, 0x4d, 0xca, 0x5, 0, 0xe8, 0xe1, 0x8a, 0xfa, 0xff, 0x31, 0xd2, 0x8d, 0x45, 0xf4, 0xe8, 0xe3, 0x4a, 0xf9, 0xff, 0x8b, 0x45, 0xfc, 0x8a, 0x50, 0x3f, 0x8b, 0x45, 0xfc, 0x88, 0x50, 0x3d, 0x8b, 0x45, 0xfc, 0x8a, 0x50, 0x40, 0x8b, 0x45, 0xfc, 0x88, 0x50, 0x3e, 0xeb, 0x5a, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x50, 0x1a, 0x8b, 0x45, 0xfc, 0x66, 0x89, 0x50, 0x41, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x50, 0x1c, 0x8b, 0x45, 0xfc, 0x66, 0x89, 0x50, 0x43, 0xbb, 0xd, 0, 0, 0, 0xba, 0x4, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xe8, 0xea, 0xef, 0x6, 0, 0xba, 0xbc, 0x37, 0x1c, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x22, 0x2d, 0xf8, 0xff, 0x84, 0xc0, 0x74, 0x1b, 0xe8, 0x79, 0xeb, 0, 0, 0x31, 0xc9, 0x88, 0xc1, 0xbb, 0x10, 0, 0, 0, 0x8b, 0x55, 0xfc, 0xb8, 0x78, 0x72, 0x1c, 0x10, 0xe8, 0x2b, 0x95, 0x4, 0, 0x8b, 0x45, 0xfc, 0xe8, 0x9a, 0xb5, 0, 0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100f3f62, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x100f3f67, 0x5)   calld(sys_check_available_stack_size, 0x71de6); /* call 0x10165d52 */
    II(0x100f3f6c, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100f3f6d, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100f3f6e, 0x1)   pushd(edx);                           /* push edx */
    II(0x100f3f6f, 0x1)   pushd(esi);                           /* push esi */
    II(0x100f3f70, 0x1)   pushd(edi);                           /* push edi */
    II(0x100f3f71, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100f3f72, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100f3f74, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100f3f7a, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
l_0x100f3f7d:
    II(0x100f3f7d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100f3f80, 0x4)   cmp(memb_a32(ds, eax + 0x3e), 0x6);   /* cmp byte [eax+0x3e], 0x6 */
    II(0x100f3f84, 0x2)   jnzd(0x100f3f8f, 0x9);                /* jnz 0x100f3f8f */
    II(0x100f3f86, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x100f3f88, 0x5)   calld(0x10100efe, 0xcf71);            /* call 0x10100efe */
    II(0x100f3f8d, 0x2)   jmpd(0x100f3f7d, -0x12);              /* jmp 0x100f3f7d */
l_0x100f3f8f:
    II(0x100f3f8f, 0x5)   calld(0x1011606c, 0x220d8);           /* call 0x1011606c */
    II(0x100f3f94, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100f3f97, 0x4)   cmp(memb_a32(ds, eax + 0x3e), 0x19);  /* cmp byte [eax+0x3e], 0x19 */
    II(0x100f3f9b, 0x6)   jnzd(0x100f403b, 0x9a);               /* jnz dword 0x100f403b */
    II(0x100f3fa1, 0x5)   mov(ecx, 0xffffffff);                 /* mov ecx, 0xffffffff */
    II(0x100f3fa6, 0x5)   mov(ebx, 0x3e1);                      /* mov ebx, 0x3e1 */
    II(0x100f3fab, 0x5)   mov(edx, 0x3de);                      /* mov edx, 0x3de */
    II(0x100f3fb0, 0x5)   mov(eax, 0x101c7278);                 /* mov eax, 0x101c7278 */
    II(0x100f3fb5, 0x5)   calld(0x1013daea, 0x49b30);           /* call 0x1013daea */
    II(0x100f3fba, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100f3fbc, 0x5)   mov(eax, 0x101c37c0);                 /* mov eax, 0x101c37c0 */
    II(0x100f3fc1, 0x5)   calld(0x1013ad71, 0x46dab);           /* call 0x1013ad71 */
    II(0x100f3fc6, 0x2)   test(al, al);                         /* test al, al */
    II(0x100f3fc8, 0x2)   jzd(0x100f3fd3, 0x9);                 /* jz 0x100f3fd3 */
    II(0x100f3fca, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0);      /* mov dword [ebp-0x8], 0x0 */
    II(0x100f3fd1, 0x2)   jmpd(0x100f3fec, 0x19);               /* jmp 0x100f3fec */
l_0x100f3fd3:
    II(0x100f3fd3, 0x5)   mov(ecx, 0x786);                      /* mov ecx, 0x786 */
    II(0x100f3fd8, 0x5)   mov(ebx, 0x101a2511);                 /* mov ebx, 0x101a2511 */ /* "gamemgr.cpp" */
    II(0x100f3fdd, 0x5)   mov(edx, 0x101a251d);                 /* mov edx, 0x101a251d */ /* "temp_tape != 0" */
    II(0x100f3fe2, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x100f3fe4, 0x5)   calld(sys_assert, 0x71da9);           /* call 0x10165d92 */
    II(0x100f3fe9, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
l_0x100f3fec:
    II(0x100f3fec, 0x5)   mov(eax, 0x101c37c0);                 /* mov eax, 0x101c37c0 */
    II(0x100f3ff1, 0x5)   calld(0x10076600, -0x7d9f6);          /* call 0x10076600 */
    II(0x100f3ff6, 0x5)   calld(0x1015f2cc, 0x6b2d1);           /* call 0x1015f2cc */
    II(0x100f3ffb, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100f3ffd, 0x5)   mov(eax, 0x101c37c0);                 /* mov eax, 0x101c37c0 */
    II(0x100f4002, 0x5)   calld(0x10076630, -0x7d9d7);          /* call 0x10076630 */
    II(0x100f4007, 0x3)   lea(edx, ebp - 0xc);                  /* lea edx, [ebp-0xc] */
    II(0x100f400a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100f400d, 0x5)   calld(0x10150a5f, 0x5ca4d);           /* call 0x10150a5f */
    II(0x100f4012, 0x5)   calld(0x1009caf8, -0x5751f);          /* call 0x1009caf8 */
    II(0x100f4017, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x100f4019, 0x3)   lea(eax, ebp - 0xc);                  /* lea eax, [ebp-0xc] */
    II(0x100f401c, 0x5)   calld(0x10088b04, -0x6b51d);          /* call 0x10088b04 */
    II(0x100f4021, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100f4024, 0x3)   mov(dl, memb_a32(ds, eax + 0x3f));    /* mov dl, [eax+0x3f] */
//    II(0x100f4027, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100f402a, 0x3)   mov(memb_a32(ds, eax + 0x3d), dl);    /* mov [eax+0x3d], dl */
    II(0x100f402d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100f4030, 0x3)   mov(dl, memb_a32(ds, eax + 0x40));    /* mov dl, [eax+0x40] */
//    II(0x100f4033, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100f4036, 0x3)   mov(memb_a32(ds, eax + 0x3e), dl);    /* mov [eax+0x3e], dl */
    II(0x100f4039, 0x2)   jmpd(0x100f4095, 0x5a);               /* jmp 0x100f4095 */
l_0x100f403b:
    II(0x100f403b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100f403e, 0x4)   mov(dx, memw_a32(ds, eax + 0x1a));    /* mov dx, [eax+0x1a] */
//    II(0x100f4042, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100f4045, 0x4)   mov(memw_a32(ds, eax + 0x41), dx);    /* mov [eax+0x41], dx */
    II(0x100f4049, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100f404c, 0x4)   mov(dx, memw_a32(ds, eax + 0x1c));    /* mov dx, [eax+0x1c] */
//    II(0x100f4050, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100f4053, 0x4)   mov(memw_a32(ds, eax + 0x43), dx);    /* mov [eax+0x43], dx */
    II(0x100f4057, 0x5)   mov(ebx, 0xd);                        /* mov ebx, 0xd */
    II(0x100f405c, 0x5)   mov(edx, 0x4);                        /* mov edx, 0x4 */
    II(0x100f4061, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100f4064, 0x5)   calld(0x10163053, 0x6efea);           /* call 0x10163053 */
    II(0x100f4069, 0x5)   mov(edx, 0x101c37bc);                 /* mov edx, 0x101c37bc */
    II(0x100f406e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100f4071, 0x5)   calld(0x10076d98, -0x7d2de);          /* call 0x10076d98 */
    II(0x100f4076, 0x2)   test(al, al);                         /* test al, al */
    II(0x100f4078, 0x2)   jzd(0x100f4095, 0x1b);                /* jz 0x100f4095 */
    II(0x100f407a, 0x5)   calld(0x10102bf8, 0xeb79);            /* call 0x10102bf8 */
    II(0x100f407f, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x100f4081, 0x2)   mov(cl, al);                          /* mov cl, al */
    II(0x100f4083, 0x5)   mov(ebx, 0x10);                       /* mov ebx, 0x10 */
    II(0x100f4088, 0x3)   mov(edx, memd_a32(ss, ebp - 0x4));    /* mov edx, [ebp-0x4] */
    II(0x100f408b, 0x5)   mov(eax, 0x101c7278);                 /* mov eax, 0x101c7278 */
    II(0x100f4090, 0x5)   calld(0x1013d5c0, 0x4952b);           /* call 0x1013d5c0 */
l_0x100f4095:
    II(0x100f4095, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100f4098, 0x5)   calld(0x100ff637, 0xb59a);            /* call 0x100ff637 */
    II(0x100f409d, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100f409f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100f40a0, 0x1)   popd(edi);                            /* pop edi */
    II(0x100f40a1, 0x1)   popd(esi);                            /* pop esi */
    II(0x100f40a2, 0x1)   popd(edx);                            /* pop edx */
    II(0x100f40a3, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100f40a4, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100f40a5, 0x1)   retd();                               /* ret */
FUNC_END

