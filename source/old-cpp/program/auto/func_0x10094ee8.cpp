FUNC_BEGIN(0x10094ee8, 0xa6ea3e947fdc3fe1, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0x60, 0xe, 0xd, 0, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf4, 0x89, 0x55, 0xf8, 0x89, 0x5d, 0xfc, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x8, 0x8b, 0x45, 0xf4, 0x3b, 0x10, 0x7e, 0xd, 0x8b, 0x45, 0xf4, 0x8b, 0x50, 0x8, 0x8b, 0x45, 0xf8, 0x3b, 0x10, 0x7f, 0x2, 0xeb, 0x54, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0xc, 0x8b, 0x45, 0xf4, 0x3b, 0x50, 0x4, 0x7f, 0xe, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0xc, 0x8b, 0x45, 0xfc, 0x3b, 0x50, 0x4, 0x7f, 0x2, 0xeb, 0xc, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0xc, 0x8b, 0x45, 0xfc, 0x89, 0x50, 0x4, 0x8b, 0x45, 0xf4, 0x8b, 0x50, 0xc, 0x8b, 0x45, 0xf8, 0x3b, 0x50, 0x4, 0x7f, 0xe, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x4, 0x8b, 0x45, 0xfc, 0x3b, 0x50, 0xc, 0x7c, 0x2, 0xeb, 0xc, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x4, 0x8b, 0x45, 0xfc, 0x89, 0x50, 0xc, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0xc, 0x8b, 0x45, 0xf4, 0x3b, 0x50, 0x4, 0x7e, 0xe, 0x8b, 0x45, 0xf4, 0x8b, 0x50, 0xc, 0x8b, 0x45, 0xf8, 0x3b, 0x50, 0x4, 0x7f, 0x2, 0xeb, 0x4e, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x8, 0x8b, 0x45, 0xf4, 0x3b, 0x10, 0x7f, 0xd, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x8, 0x8b, 0x45, 0xfc, 0x3b, 0x10, 0x7f, 0x2, 0xeb, 0xb, 0x8b, 0x45, 0xf8, 0x8b, 0x50, 0x8, 0x8b, 0x45, 0xfc, 0x89, 0x10, 0x8b, 0x45, 0xf4, 0x8b, 0x50, 0x8, 0x8b, 0x45, 0xf8, 0x3b, 0x10, 0x7f, 0xd, 0x8b, 0x45, 0xf8, 0x8b, 0x10, 0x8b, 0x45, 0xfc, 0x3b, 0x50, 0x8, 0x7c, 0x2, 0xeb, 0xb, 0x8b, 0x45, 0xf8, 0x8b, 0x10, 0x8b, 0x45, 0xfc, 0x89, 0x50, 0x8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0xc3}))
    II(0x10094ee8, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10094eed, 0x5)   calld(sys_check_available_stack_size, 0xd0e60); /* call 0x10165d52 */
    II(0x10094ef2, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10094ef3, 0x1)   pushd(esi);                           /* push esi */
    II(0x10094ef4, 0x1)   pushd(edi);                           /* push edi */
    II(0x10094ef5, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10094ef6, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10094ef8, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10094efe, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x10094f01, 0x3)   mov(memd_a32(ss, ebp - 0x8), edx);    /* mov [ebp-0x8], edx */
    II(0x10094f04, 0x3)   mov(memd_a32(ss, ebp - 0x4), ebx);    /* mov [ebp-0x4], ebx */
    II(0x10094f07, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10094f0a, 0x3)   mov(edx, memd_a32(ds, eax + 0x8));    /* mov edx, [eax+0x8] */
    II(0x10094f0d, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10094f10, 0x2)   cmp(edx, memd_a32(ds, eax));          /* cmp edx, [eax] */
    II(0x10094f12, 0x2)   jled(0x10094f21, 0xd);                /* jle 0x10094f21 */
    II(0x10094f14, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10094f17, 0x3)   mov(edx, memd_a32(ds, eax + 0x8));    /* mov edx, [eax+0x8] */
    II(0x10094f1a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10094f1d, 0x2)   cmp(edx, memd_a32(ds, eax));          /* cmp edx, [eax] */
    II(0x10094f1f, 0x2)   jgd(0x10094f23, 0x2);                 /* jg 0x10094f23 */
l_0x10094f21:
    II(0x10094f21, 0x2)   jmpd(0x10094f77, 0x54);               /* jmp 0x10094f77 */
l_0x10094f23:
    II(0x10094f23, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10094f26, 0x3)   mov(edx, memd_a32(ds, eax + 0xc));    /* mov edx, [eax+0xc] */
    II(0x10094f29, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10094f2c, 0x3)   cmp(edx, memd_a32(ds, eax + 0x4));    /* cmp edx, [eax+0x4] */
    II(0x10094f2f, 0x2)   jgd(0x10094f3f, 0xe);                 /* jg 0x10094f3f */
    II(0x10094f31, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10094f34, 0x3)   mov(edx, memd_a32(ds, eax + 0xc));    /* mov edx, [eax+0xc] */
    II(0x10094f37, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10094f3a, 0x3)   cmp(edx, memd_a32(ds, eax + 0x4));    /* cmp edx, [eax+0x4] */
    II(0x10094f3d, 0x2)   jgd(0x10094f41, 0x2);                 /* jg 0x10094f41 */
l_0x10094f3f:
    II(0x10094f3f, 0x2)   jmpd(0x10094f4d, 0xc);                /* jmp 0x10094f4d */
l_0x10094f41:
    II(0x10094f41, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10094f44, 0x3)   mov(edx, memd_a32(ds, eax + 0xc));    /* mov edx, [eax+0xc] */
    II(0x10094f47, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10094f4a, 0x3)   mov(memd_a32(ds, eax + 0x4), edx);    /* mov [eax+0x4], edx */
l_0x10094f4d:
    II(0x10094f4d, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10094f50, 0x3)   mov(edx, memd_a32(ds, eax + 0xc));    /* mov edx, [eax+0xc] */
    II(0x10094f53, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10094f56, 0x3)   cmp(edx, memd_a32(ds, eax + 0x4));    /* cmp edx, [eax+0x4] */
    II(0x10094f59, 0x2)   jgd(0x10094f69, 0xe);                 /* jg 0x10094f69 */
    II(0x10094f5b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10094f5e, 0x3)   mov(edx, memd_a32(ds, eax + 0x4));    /* mov edx, [eax+0x4] */
    II(0x10094f61, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10094f64, 0x3)   cmp(edx, memd_a32(ds, eax + 0xc));    /* cmp edx, [eax+0xc] */
    II(0x10094f67, 0x2)   jld(0x10094f6b, 0x2);                 /* jl 0x10094f6b */
l_0x10094f69:
    II(0x10094f69, 0x2)   jmpd(0x10094f77, 0xc);                /* jmp 0x10094f77 */
l_0x10094f6b:
    II(0x10094f6b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10094f6e, 0x3)   mov(edx, memd_a32(ds, eax + 0x4));    /* mov edx, [eax+0x4] */
    II(0x10094f71, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10094f74, 0x3)   mov(memd_a32(ds, eax + 0xc), edx);    /* mov [eax+0xc], edx */
l_0x10094f77:
    II(0x10094f77, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10094f7a, 0x3)   mov(edx, memd_a32(ds, eax + 0xc));    /* mov edx, [eax+0xc] */
    II(0x10094f7d, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10094f80, 0x3)   cmp(edx, memd_a32(ds, eax + 0x4));    /* cmp edx, [eax+0x4] */
    II(0x10094f83, 0x2)   jled(0x10094f93, 0xe);                /* jle 0x10094f93 */
    II(0x10094f85, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10094f88, 0x3)   mov(edx, memd_a32(ds, eax + 0xc));    /* mov edx, [eax+0xc] */
    II(0x10094f8b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10094f8e, 0x3)   cmp(edx, memd_a32(ds, eax + 0x4));    /* cmp edx, [eax+0x4] */
    II(0x10094f91, 0x2)   jgd(0x10094f95, 0x2);                 /* jg 0x10094f95 */
l_0x10094f93:
    II(0x10094f93, 0x2)   jmpd(0x10094fe3, 0x4e);               /* jmp 0x10094fe3 */
l_0x10094f95:
    II(0x10094f95, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10094f98, 0x3)   mov(edx, memd_a32(ds, eax + 0x8));    /* mov edx, [eax+0x8] */
    II(0x10094f9b, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10094f9e, 0x2)   cmp(edx, memd_a32(ds, eax));          /* cmp edx, [eax] */
    II(0x10094fa0, 0x2)   jgd(0x10094faf, 0xd);                 /* jg 0x10094faf */
    II(0x10094fa2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10094fa5, 0x3)   mov(edx, memd_a32(ds, eax + 0x8));    /* mov edx, [eax+0x8] */
    II(0x10094fa8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10094fab, 0x2)   cmp(edx, memd_a32(ds, eax));          /* cmp edx, [eax] */
    II(0x10094fad, 0x2)   jgd(0x10094fb1, 0x2);                 /* jg 0x10094fb1 */
l_0x10094faf:
    II(0x10094faf, 0x2)   jmpd(0x10094fbc, 0xb);                /* jmp 0x10094fbc */
l_0x10094fb1:
    II(0x10094fb1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10094fb4, 0x3)   mov(edx, memd_a32(ds, eax + 0x8));    /* mov edx, [eax+0x8] */
    II(0x10094fb7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10094fba, 0x2)   mov(memd_a32(ds, eax), edx);          /* mov [eax], edx */
l_0x10094fbc:
    II(0x10094fbc, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10094fbf, 0x3)   mov(edx, memd_a32(ds, eax + 0x8));    /* mov edx, [eax+0x8] */
    II(0x10094fc2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10094fc5, 0x2)   cmp(edx, memd_a32(ds, eax));          /* cmp edx, [eax] */
    II(0x10094fc7, 0x2)   jgd(0x10094fd6, 0xd);                 /* jg 0x10094fd6 */
    II(0x10094fc9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10094fcc, 0x2)   mov(edx, memd_a32(ds, eax));          /* mov edx, [eax] */
    II(0x10094fce, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10094fd1, 0x3)   cmp(edx, memd_a32(ds, eax + 0x8));    /* cmp edx, [eax+0x8] */
    II(0x10094fd4, 0x2)   jld(0x10094fd8, 0x2);                 /* jl 0x10094fd8 */
l_0x10094fd6:
    II(0x10094fd6, 0x2)   jmpd(0x10094fe3, 0xb);                /* jmp 0x10094fe3 */
l_0x10094fd8:
    II(0x10094fd8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10094fdb, 0x2)   mov(edx, memd_a32(ds, eax));          /* mov edx, [eax] */
    II(0x10094fdd, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10094fe0, 0x3)   mov(memd_a32(ds, eax + 0x8), edx);    /* mov [eax+0x8], edx */
l_0x10094fe3:
    II(0x10094fe3, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10094fe5, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10094fe6, 0x1)   popd(edi);                            /* pop edi */
    II(0x10094fe7, 0x1)   popd(esi);                            /* pop esi */
    II(0x10094fe8, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10094fe9, 0x1)   retd();                               /* ret */
FUNC_END

