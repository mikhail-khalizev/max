FUNC_BEGIN(0x100ec1bd, 0x505a8950177f6507, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x8b, 0x9b, 0x7, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xb8, 0x3e, 0, 0, 0, 0xe8, 0xfa, 0x9d, 0xf8, 0xff, 0x83, 0xf8, 0x1, 0x75, 0xd, 0xa1, 0x80, 0x39, 0x1c, 0x10, 0xc1, 0xf8, 0x10, 0x83, 0xf8, 0x1, 0x74, 0x2, 0xeb, 0x8, 0xf, 0xbf, 0x45, 0xfc, 0x85, 0xc0, 0x74, 0x2, 0xeb, 0x6, 0xc6, 0x45, 0xf8, 0x1, 0xeb, 0x5d, 0xba, 0x84, 0x81, 0x1c, 0x10, 0xf, 0xbf, 0x45, 0xfc, 0xe8, 0x14, 0xf9, 0xff, 0xff, 0x84, 0xc0, 0x75, 0x12, 0xba, 0xa8, 0x81, 0x1c, 0x10, 0xf, 0xbf, 0x45, 0xfc, 0xe8, 0x2, 0xf9, 0xff, 0xff, 0x84, 0xc0, 0x74, 0x2, 0xeb, 0x12, 0xba, 0x9c, 0x81, 0x1c, 0x10, 0xf, 0xbf, 0x45, 0xfc, 0xe8, 0xee, 0xf8, 0xff, 0xff, 0x84, 0xc0, 0x74, 0x6, 0xc6, 0x45, 0xf8, 0x1, 0xeb, 0x1f, 0xf, 0xbf, 0x45, 0xfc, 0xe8, 0xd9, 0xfa, 0xff, 0xff, 0x84, 0xc0, 0x74, 0x6, 0xc6, 0x45, 0xf8, 0x1, 0xeb, 0xc, 0xf, 0xbf, 0x45, 0xfc, 0xe8, 0x1b, 0xfd, 0xff, 0xff, 0x88, 0x45, 0xf8, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100ec1bd, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100ec1c2, 0x5)   calld(sys_check_available_stack_size, 0x79b8b); /* call 0x10165d52 */
    II(0x100ec1c7, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100ec1c8, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100ec1c9, 0x1)   pushd(edx);                           /* push edx */
    II(0x100ec1ca, 0x1)   pushd(esi);                           /* push esi */
    II(0x100ec1cb, 0x1)   pushd(edi);                           /* push edi */
    II(0x100ec1cc, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100ec1cd, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100ec1cf, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100ec1d5, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100ec1d8, 0x5)   mov(eax, 0x3e);                       /* mov eax, 0x3e */
    II(0x100ec1dd, 0x5)   calld(0x10075fdc, -0x76206);          /* call 0x10075fdc */
    II(0x100ec1e2, 0x3)   cmp(eax, 0x1);                        /* cmp eax, 0x1 */
    II(0x100ec1e5, 0x2)   jnzd(0x100ec1f4, 0xd);                /* jnz 0x100ec1f4 */
    II(0x100ec1e7, 0x5)   mov(eax, memd_a32(ds, 0x101c3980));   /* mov eax, [0x101c3980] */
    II(0x100ec1ec, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x100ec1ef, 0x3)   cmp(eax, 0x1);                        /* cmp eax, 0x1 */
    II(0x100ec1f2, 0x2)   jzd(0x100ec1f6, 0x2);                 /* jz 0x100ec1f6 */
l_0x100ec1f4:
    II(0x100ec1f4, 0x2)   jmpd(0x100ec1fe, 0x8);                /* jmp 0x100ec1fe */
l_0x100ec1f6:
    II(0x100ec1f6, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100ec1fa, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x100ec1fc, 0x2)   jzd(0x100ec200, 0x2);                 /* jz 0x100ec200 */
l_0x100ec1fe:
    II(0x100ec1fe, 0x2)   jmpd(0x100ec206, 0x6);                /* jmp 0x100ec206 */
l_0x100ec200:
    II(0x100ec200, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x1);    /* mov byte [ebp-0x8], 0x1 */
    II(0x100ec204, 0x2)   jmpd(0x100ec263, 0x5d);               /* jmp 0x100ec263 */
l_0x100ec206:
    II(0x100ec206, 0x5)   mov(edx, 0x101c8184);                 /* mov edx, 0x101c8184 */
    II(0x100ec20b, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100ec20f, 0x5)   calld(0x100ebb28, -0x6ec);            /* call 0x100ebb28 */
    II(0x100ec214, 0x2)   test(al, al);                         /* test al, al */
    II(0x100ec216, 0x2)   jnzd(0x100ec22a, 0x12);               /* jnz 0x100ec22a */
    II(0x100ec218, 0x5)   mov(edx, 0x101c81a8);                 /* mov edx, 0x101c81a8 */
    II(0x100ec21d, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100ec221, 0x5)   calld(0x100ebb28, -0x6fe);            /* call 0x100ebb28 */
    II(0x100ec226, 0x2)   test(al, al);                         /* test al, al */
    II(0x100ec228, 0x2)   jzd(0x100ec22c, 0x2);                 /* jz 0x100ec22c */
l_0x100ec22a:
    II(0x100ec22a, 0x2)   jmpd(0x100ec23e, 0x12);               /* jmp 0x100ec23e */
l_0x100ec22c:
    II(0x100ec22c, 0x5)   mov(edx, 0x101c819c);                 /* mov edx, 0x101c819c */
    II(0x100ec231, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100ec235, 0x5)   calld(0x100ebb28, -0x712);            /* call 0x100ebb28 */
    II(0x100ec23a, 0x2)   test(al, al);                         /* test al, al */
    II(0x100ec23c, 0x2)   jzd(0x100ec244, 0x6);                 /* jz 0x100ec244 */
l_0x100ec23e:
    II(0x100ec23e, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x1);    /* mov byte [ebp-0x8], 0x1 */
    II(0x100ec242, 0x2)   jmpd(0x100ec263, 0x1f);               /* jmp 0x100ec263 */
l_0x100ec244:
    II(0x100ec244, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100ec248, 0x5)   calld(0x100ebd26, -0x527);            /* call 0x100ebd26 */
    II(0x100ec24d, 0x2)   test(al, al);                         /* test al, al */
    II(0x100ec24f, 0x2)   jzd(0x100ec257, 0x6);                 /* jz 0x100ec257 */
    II(0x100ec251, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x1);    /* mov byte [ebp-0x8], 0x1 */
    II(0x100ec255, 0x2)   jmpd(0x100ec263, 0xc);                /* jmp 0x100ec263 */
l_0x100ec257:
    II(0x100ec257, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100ec25b, 0x5)   calld(0x100ebf7b, -0x2e5);            /* call 0x100ebf7b */
    II(0x100ec260, 0x3)   mov(memb_a32(ss, ebp - 0x8), al);     /* mov [ebp-0x8], al */
l_0x100ec263:
    II(0x100ec263, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x100ec266, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100ec268, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100ec269, 0x1)   popd(edi);                            /* pop edi */
    II(0x100ec26a, 0x1)   popd(esi);                            /* pop esi */
    II(0x100ec26b, 0x1)   popd(edx);                            /* pop edx */
    II(0x100ec26c, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100ec26d, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100ec26e, 0x1)   retd();                               /* ret */
FUNC_END

