FUNC_BEGIN(0x1014bf44, 0x4ae9fc225ba39a23, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x4, 0x9e, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc7, 0x45, 0xf8, 0, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xf6, 0x40, 0x6a, 0x4, 0xf, 0x85, 0x3f, 0x1, 0, 0, 0x8b, 0x45, 0xfc, 0x80, 0x48, 0x6a, 0x4, 0x8b, 0x45, 0xfc, 0xf6, 0x40, 0x69, 0x1, 0x74, 0x1e, 0xba, 0x1, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xe8, 0x2e, 0xf8, 0xff, 0xff, 0x89, 0x45, 0xf8, 0x83, 0x7d, 0xf8, 0, 0x74, 0x8, 0x8b, 0x45, 0xf8, 0xe8, 0xa3, 0xff, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0xf6, 0x40, 0x69, 0x2, 0x74, 0x1e, 0xba, 0x2, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xe8, 0x7, 0xf8, 0xff, 0xff, 0x89, 0x45, 0xf8, 0x83, 0x7d, 0xf8, 0, 0x74, 0x8, 0x8b, 0x45, 0xf8, 0xe8, 0x7c, 0xff, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0xf6, 0x40, 0x69, 0x4, 0x74, 0x1e, 0xba, 0x4, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xe8, 0xe0, 0xf7, 0xff, 0xff, 0x89, 0x45, 0xf8, 0x83, 0x7d, 0xf8, 0, 0x74, 0x8, 0x8b, 0x45, 0xf8, 0xe8, 0x55, 0xff, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0xf6, 0x40, 0x69, 0x8, 0x74, 0x1e, 0xba, 0x8, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xe8, 0xb9, 0xf7, 0xff, 0xff, 0x89, 0x45, 0xf8, 0x83, 0x7d, 0xf8, 0, 0x74, 0x8, 0x8b, 0x45, 0xf8, 0xe8, 0x2e, 0xff, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0xf6, 0x40, 0x69, 0x20, 0x74, 0x1e, 0xba, 0x20, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xe8, 0x92, 0xf7, 0xff, 0xff, 0x89, 0x45, 0xf8, 0x83, 0x7d, 0xf8, 0, 0x74, 0x8, 0x8b, 0x45, 0xf8, 0xe8, 0x7, 0xff, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0xf6, 0x40, 0x69, 0x10, 0x74, 0x1e, 0xba, 0x10, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xe8, 0x6b, 0xf7, 0xff, 0xff, 0x89, 0x45, 0xf8, 0x83, 0x7d, 0xf8, 0, 0x74, 0x8, 0x8b, 0x45, 0xf8, 0xe8, 0xe0, 0xfe, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0xf6, 0x40, 0x69, 0x80, 0x74, 0x1e, 0xba, 0x80, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xe8, 0x44, 0xf7, 0xff, 0xff, 0x89, 0x45, 0xf8, 0x83, 0x7d, 0xf8, 0, 0x74, 0x8, 0x8b, 0x45, 0xf8, 0xe8, 0xb9, 0xfe, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0xf6, 0x40, 0x69, 0x40, 0x74, 0x1e, 0xba, 0x40, 0, 0, 0, 0x8b, 0x45, 0xfc, 0xe8, 0x1d, 0xf7, 0xff, 0xff, 0x89, 0x45, 0xf8, 0x83, 0x7d, 0xf8, 0, 0x74, 0x8, 0x8b, 0x45, 0xf8, 0xe8, 0x92, 0xfe, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1014bf44, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1014bf49, 0x5)   calld(sys_check_available_stack_size, 0x19e04); /* call 0x10165d52 */
    II(0x1014bf4e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1014bf4f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1014bf50, 0x1)   pushd(edx);                           /* push edx */
    II(0x1014bf51, 0x1)   pushd(esi);                           /* push esi */
    II(0x1014bf52, 0x1)   pushd(edi);                           /* push edi */
    II(0x1014bf53, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1014bf54, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1014bf56, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1014bf5c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1014bf5f, 0x7)   mov(memd_a32(ss, ebp - 0x8), 0);      /* mov dword [ebp-0x8], 0x0 */
//    II(0x1014bf66, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014bf69, 0x4)   test(memb_a32(ds, eax + 0x6a), 0x4);  /* test byte [eax+0x6a], 0x4 */
    II(0x1014bf6d, 0x6)   jnzd(0x1014c0b2, 0x13f);              /* jnz dword 0x1014c0b2 */
    II(0x1014bf73, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014bf76, 0x4)   or_(memb_a32(ds, eax + 0x6a), 0x4);   /* or byte [eax+0x6a], 0x4 */
    II(0x1014bf7a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014bf7d, 0x4)   test(memb_a32(ds, eax + 0x69), 0x1);  /* test byte [eax+0x69], 0x1 */
    II(0x1014bf81, 0x2)   jzd(0x1014bfa1, 0x1e);                /* jz 0x1014bfa1 */
    II(0x1014bf83, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
    II(0x1014bf88, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014bf8b, 0x5)   calld(0x1014b7be, -0x7d2);            /* call 0x1014b7be */
    II(0x1014bf90, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1014bf93, 0x4)   cmp(memd_a32(ss, ebp - 0x8), 0);      /* cmp dword [ebp-0x8], 0x0 */
    II(0x1014bf97, 0x2)   jzd(0x1014bfa1, 0x8);                 /* jz 0x1014bfa1 */
    II(0x1014bf99, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014bf9c, 0x5)   calld(0x1014bf44, -0x5d);             /* call 0x1014bf44 */
l_0x1014bfa1:
    II(0x1014bfa1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014bfa4, 0x4)   test(memb_a32(ds, eax + 0x69), 0x2);  /* test byte [eax+0x69], 0x2 */
    II(0x1014bfa8, 0x2)   jzd(0x1014bfc8, 0x1e);                /* jz 0x1014bfc8 */
    II(0x1014bfaa, 0x5)   mov(edx, 0x2);                        /* mov edx, 0x2 */
    II(0x1014bfaf, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014bfb2, 0x5)   calld(0x1014b7be, -0x7f9);            /* call 0x1014b7be */
    II(0x1014bfb7, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1014bfba, 0x4)   cmp(memd_a32(ss, ebp - 0x8), 0);      /* cmp dword [ebp-0x8], 0x0 */
    II(0x1014bfbe, 0x2)   jzd(0x1014bfc8, 0x8);                 /* jz 0x1014bfc8 */
    II(0x1014bfc0, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014bfc3, 0x5)   calld(0x1014bf44, -0x84);             /* call 0x1014bf44 */
l_0x1014bfc8:
    II(0x1014bfc8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014bfcb, 0x4)   test(memb_a32(ds, eax + 0x69), 0x4);  /* test byte [eax+0x69], 0x4 */
    II(0x1014bfcf, 0x2)   jzd(0x1014bfef, 0x1e);                /* jz 0x1014bfef */
    II(0x1014bfd1, 0x5)   mov(edx, 0x4);                        /* mov edx, 0x4 */
    II(0x1014bfd6, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014bfd9, 0x5)   calld(0x1014b7be, -0x820);            /* call 0x1014b7be */
    II(0x1014bfde, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1014bfe1, 0x4)   cmp(memd_a32(ss, ebp - 0x8), 0);      /* cmp dword [ebp-0x8], 0x0 */
    II(0x1014bfe5, 0x2)   jzd(0x1014bfef, 0x8);                 /* jz 0x1014bfef */
    II(0x1014bfe7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014bfea, 0x5)   calld(0x1014bf44, -0xab);             /* call 0x1014bf44 */
l_0x1014bfef:
    II(0x1014bfef, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014bff2, 0x4)   test(memb_a32(ds, eax + 0x69), 0x8);  /* test byte [eax+0x69], 0x8 */
    II(0x1014bff6, 0x2)   jzd(0x1014c016, 0x1e);                /* jz 0x1014c016 */
    II(0x1014bff8, 0x5)   mov(edx, 0x8);                        /* mov edx, 0x8 */
    II(0x1014bffd, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014c000, 0x5)   calld(0x1014b7be, -0x847);            /* call 0x1014b7be */
    II(0x1014c005, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1014c008, 0x4)   cmp(memd_a32(ss, ebp - 0x8), 0);      /* cmp dword [ebp-0x8], 0x0 */
    II(0x1014c00c, 0x2)   jzd(0x1014c016, 0x8);                 /* jz 0x1014c016 */
    II(0x1014c00e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014c011, 0x5)   calld(0x1014bf44, -0xd2);             /* call 0x1014bf44 */
l_0x1014c016:
    II(0x1014c016, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014c019, 0x4)   test(memb_a32(ds, eax + 0x69), 0x20); /* test byte [eax+0x69], 0x20 */
    II(0x1014c01d, 0x2)   jzd(0x1014c03d, 0x1e);                /* jz 0x1014c03d */
    II(0x1014c01f, 0x5)   mov(edx, 0x20);                       /* mov edx, 0x20 */
    II(0x1014c024, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014c027, 0x5)   calld(0x1014b7be, -0x86e);            /* call 0x1014b7be */
    II(0x1014c02c, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1014c02f, 0x4)   cmp(memd_a32(ss, ebp - 0x8), 0);      /* cmp dword [ebp-0x8], 0x0 */
    II(0x1014c033, 0x2)   jzd(0x1014c03d, 0x8);                 /* jz 0x1014c03d */
    II(0x1014c035, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014c038, 0x5)   calld(0x1014bf44, -0xf9);             /* call 0x1014bf44 */
l_0x1014c03d:
    II(0x1014c03d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014c040, 0x4)   test(memb_a32(ds, eax + 0x69), 0x10); /* test byte [eax+0x69], 0x10 */
    II(0x1014c044, 0x2)   jzd(0x1014c064, 0x1e);                /* jz 0x1014c064 */
    II(0x1014c046, 0x5)   mov(edx, 0x10);                       /* mov edx, 0x10 */
    II(0x1014c04b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014c04e, 0x5)   calld(0x1014b7be, -0x895);            /* call 0x1014b7be */
    II(0x1014c053, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1014c056, 0x4)   cmp(memd_a32(ss, ebp - 0x8), 0);      /* cmp dword [ebp-0x8], 0x0 */
    II(0x1014c05a, 0x2)   jzd(0x1014c064, 0x8);                 /* jz 0x1014c064 */
    II(0x1014c05c, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014c05f, 0x5)   calld(0x1014bf44, -0x120);            /* call 0x1014bf44 */
l_0x1014c064:
    II(0x1014c064, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014c067, 0x4)   test(memb_a32(ds, eax + 0x69), 0x80); /* test byte [eax+0x69], 0x80 */
    II(0x1014c06b, 0x2)   jzd(0x1014c08b, 0x1e);                /* jz 0x1014c08b */
    II(0x1014c06d, 0x5)   mov(edx, 0x80);                       /* mov edx, 0x80 */
    II(0x1014c072, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014c075, 0x5)   calld(0x1014b7be, -0x8bc);            /* call 0x1014b7be */
    II(0x1014c07a, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1014c07d, 0x4)   cmp(memd_a32(ss, ebp - 0x8), 0);      /* cmp dword [ebp-0x8], 0x0 */
    II(0x1014c081, 0x2)   jzd(0x1014c08b, 0x8);                 /* jz 0x1014c08b */
    II(0x1014c083, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014c086, 0x5)   calld(0x1014bf44, -0x147);            /* call 0x1014bf44 */
l_0x1014c08b:
    II(0x1014c08b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014c08e, 0x4)   test(memb_a32(ds, eax + 0x69), 0x40); /* test byte [eax+0x69], 0x40 */
    II(0x1014c092, 0x2)   jzd(0x1014c0b2, 0x1e);                /* jz 0x1014c0b2 */
    II(0x1014c094, 0x5)   mov(edx, 0x40);                       /* mov edx, 0x40 */
    II(0x1014c099, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014c09c, 0x5)   calld(0x1014b7be, -0x8e3);            /* call 0x1014b7be */
    II(0x1014c0a1, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1014c0a4, 0x4)   cmp(memd_a32(ss, ebp - 0x8), 0);      /* cmp dword [ebp-0x8], 0x0 */
    II(0x1014c0a8, 0x2)   jzd(0x1014c0b2, 0x8);                 /* jz 0x1014c0b2 */
    II(0x1014c0aa, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014c0ad, 0x5)   calld(0x1014bf44, -0x16e);            /* call 0x1014bf44 */
l_0x1014c0b2:
    II(0x1014c0b2, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1014c0b4, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1014c0b5, 0x1)   popd(edi);                            /* pop edi */
    II(0x1014c0b6, 0x1)   popd(esi);                            /* pop esi */
    II(0x1014c0b7, 0x1)   popd(edx);                            /* pop edx */
    II(0x1014c0b8, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1014c0b9, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1014c0ba, 0x1)   retd();                               /* ret */
FUNC_END

