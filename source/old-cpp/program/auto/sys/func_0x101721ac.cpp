FUNC_BEGIN(/* sys */ 0x101721ac, 0xfc2cad21d241b6db, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x83, 0xec, 0x4, 0x89, 0xc3, 0x31, 0xc0, 0x8a, 0x3, 0x31, 0xd2, 0xe8, 0x2a, 0xed, 0, 0, 0x88, 0x4, 0x24, 0x25, 0xff, 0, 0, 0, 0x83, 0xf8, 0x72, 0x74, 0x1b, 0x83, 0xf8, 0x77, 0x74, 0x16, 0x83, 0xf8, 0x61, 0x74, 0x11, 0xb8, 0x9, 0, 0, 0, 0xe8, 0xde, 0xb1, 0x1, 0, 0x31, 0xc0, 0xe9, 0x8d, 0, 0, 0, 0x31, 0xc9, 0x89, 0xd6, 0x8a, 0x4b, 0x1, 0x66, 0x83, 0xce, 0x3, 0x83, 0xf9, 0x2b, 0x75, 0x25, 0x31, 0xc0, 0x89, 0xf2, 0x8a, 0x43, 0x2, 0x66, 0x83, 0xce, 0x40, 0x83, 0xf8, 0x62, 0x74, 0x11, 0x83, 0xf8, 0x74, 0x74, 0x4a, 0x81, 0x3d, 0xa9, 0xe7, 0x1b, 0x10, 0, 0x2, 0, 0, 0x75, 0x3e, 0x89, 0xf2, 0xeb, 0x3a, 0x89, 0xd0, 0xc, 0x40, 0x83, 0xf9, 0x62, 0x75, 0x14, 0x89, 0xc2, 0x8a, 0x5b, 0x2, 0x81, 0xe3, 0xff, 0, 0, 0, 0x83, 0xfb, 0x2b, 0x75, 0x21, 0xc, 0x3, 0xeb, 0x1b, 0x83, 0xf9, 0x74, 0x75, 0xa, 0x31, 0xc0, 0x8a, 0x43, 0x2, 0x83, 0xf8, 0x2b, 0xeb, 0xce, 0x81, 0x3d, 0xa9, 0xe7, 0x1b, 0x10, 0, 0x2, 0, 0, 0x75, 0x2, 0x89, 0xc2, 0x31, 0xc0, 0x8a, 0x4, 0x24, 0x83, 0xf8, 0x77, 0x75, 0x5, 0x80, 0xca, 0x2, 0xeb, 0xd, 0x83, 0xf8, 0x61, 0x75, 0x5, 0x80, 0xca, 0x82, 0xeb, 0x3, 0x80, 0xca, 0x1, 0x89, 0xd0, 0x83, 0xc4, 0x4, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101721ac, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101721ad, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101721ae, 0x1)   pushd(edx);                           /* push edx */
    II(0x101721af, 0x1)   pushd(esi);                           /* push esi */
    II(0x101721b0, 0x3)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x101721b3, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x101721b5, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x101721b7, 0x2)   mov(al, memb_a32(ds, ebx));           /* mov al, [ebx] */
    II(0x101721b9, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x101721bb, 0x5)   calld(sys_toupper, 0xed2a);           /* call 0x10180eea */
    II(0x101721c0, 0x3)   mov(memb_a32(ss, esp), al);           /* mov [esp], al */
    II(0x101721c3, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x101721c8, 0x3)   cmp(eax, 0x72);                       /* cmp eax, 0x72 */
    II(0x101721cb, 0x2)   jzd(0x101721e8, 0x1b);                /* jz 0x101721e8 */
    II(0x101721cd, 0x3)   cmp(eax, 0x77);                       /* cmp eax, 0x77 */
    II(0x101721d0, 0x2)   jzd(0x101721e8, 0x16);                /* jz 0x101721e8 */
    II(0x101721d2, 0x3)   cmp(eax, 0x61);                       /* cmp eax, 0x61 */
    II(0x101721d5, 0x2)   jzd(0x101721e8, 0x11);                /* jz 0x101721e8 */
    II(0x101721d7, 0x5)   mov(eax, 0x9);                        /* mov eax, 0x9 */
    II(0x101721dc, 0x5)   calld(/* sys */ 0x1018d3bf, 0x1b1de); /* call 0x1018d3bf */
    II(0x101721e1, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x101721e3, 0x5)   jmpd(0x10172275, 0x8d);               /* jmp 0x10172275 */
l_0x101721e8:
    II(0x101721e8, 0x2)   xor_(ecx, ecx);                       /* xor ecx, ecx */
    II(0x101721ea, 0x2)   mov(esi, edx);                        /* mov esi, edx */
    II(0x101721ec, 0x3)   mov(cl, memb_a32(ds, ebx + 0x1));     /* mov cl, [ebx+0x1] */
    II(0x101721ef, 0x4)   or_(si, 0x3);                         /* or si, 0x3 */
    II(0x101721f3, 0x3)   cmp(ecx, 0x2b);                       /* cmp ecx, 0x2b */
    II(0x101721f6, 0x2)   jnzd(0x1017221d, 0x25);               /* jnz 0x1017221d */
    II(0x101721f8, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x101721fa, 0x2)   mov(edx, esi);                        /* mov edx, esi */
    II(0x101721fc, 0x3)   mov(al, memb_a32(ds, ebx + 0x2));     /* mov al, [ebx+0x2] */
    II(0x101721ff, 0x4)   or_(si, 0x40);                        /* or si, 0x40 */
    II(0x10172203, 0x3)   cmp(eax, 0x62);                       /* cmp eax, 0x62 */
    II(0x10172206, 0x2)   jzd(0x10172219, 0x11);                /* jz 0x10172219 */
    II(0x10172208, 0x3)   cmp(eax, 0x74);                       /* cmp eax, 0x74 */
    II(0x1017220b, 0x2)   jzd(0x10172257, 0x4a);                /* jz 0x10172257 */
    II(0x1017220d, 0xa)   cmp(memd_a32(ds, 0x101be7a9), 0x200); /* cmp dword [0x101be7a9], 0x200 */
l_0x10172217:
    II(0x10172217, 0x2)   jnzd(0x10172257, 0x3e);               /* jnz 0x10172257 */
l_0x10172219:
    II(0x10172219, 0x2)   mov(edx, esi);                        /* mov edx, esi */
    II(0x1017221b, 0x2)   jmpd(0x10172257, 0x3a);               /* jmp 0x10172257 */
l_0x1017221d:
    II(0x1017221d, 0x2)   mov(eax, edx);                        /* mov eax, edx */
    II(0x1017221f, 0x2)   or_(al, 0x40);                        /* or al, 0x40 */
    II(0x10172221, 0x3)   cmp(ecx, 0x62);                       /* cmp ecx, 0x62 */
    II(0x10172224, 0x2)   jnzd(0x1017223a, 0x14);               /* jnz 0x1017223a */
    II(0x10172226, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10172228, 0x3)   mov(bl, memb_a32(ds, ebx + 0x2));     /* mov bl, [ebx+0x2] */
    II(0x1017222b, 0x6)   and_(ebx, 0xff);                      /* and ebx, 0xff */
    II(0x10172231, 0x3)   cmp(ebx, 0x2b);                       /* cmp ebx, 0x2b */
    II(0x10172234, 0x2)   jnzd(0x10172257, 0x21);               /* jnz 0x10172257 */
    II(0x10172236, 0x2)   or_(al, 0x3);                         /* or al, 0x3 */
    II(0x10172238, 0x2)   jmpd(0x10172255, 0x1b);               /* jmp 0x10172255 */
l_0x1017223a:
    II(0x1017223a, 0x3)   cmp(ecx, 0x74);                       /* cmp ecx, 0x74 */
    II(0x1017223d, 0x2)   jnzd(0x10172249, 0xa);                /* jnz 0x10172249 */
    II(0x1017223f, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10172241, 0x3)   mov(al, memb_a32(ds, ebx + 0x2));     /* mov al, [ebx+0x2] */
    II(0x10172244, 0x3)   cmp(eax, 0x2b);                       /* cmp eax, 0x2b */
    II(0x10172247, 0x2)   jmpd(0x10172217, -0x32);              /* jmp 0x10172217 */
l_0x10172249:
    II(0x10172249, 0xa)   cmp(memd_a32(ds, 0x101be7a9), 0x200); /* cmp dword [0x101be7a9], 0x200 */
    II(0x10172253, 0x2)   jnzd(0x10172257, 0x2);                /* jnz 0x10172257 */
l_0x10172255:
    II(0x10172255, 0x2)   mov(edx, eax);                        /* mov edx, eax */
l_0x10172257:
    II(0x10172257, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x10172259, 0x3)   mov(al, memb_a32(ss, esp));           /* mov al, [esp] */
    II(0x1017225c, 0x3)   cmp(eax, 0x77);                       /* cmp eax, 0x77 */
    II(0x1017225f, 0x2)   jnzd(0x10172266, 0x5);                /* jnz 0x10172266 */
    II(0x10172261, 0x3)   or_(dl, 0x2);                         /* or dl, 0x2 */
    II(0x10172264, 0x2)   jmpd(0x10172273, 0xd);                /* jmp 0x10172273 */
l_0x10172266:
    II(0x10172266, 0x3)   cmp(eax, 0x61);                       /* cmp eax, 0x61 */
    II(0x10172269, 0x2)   jnzd(0x10172270, 0x5);                /* jnz 0x10172270 */
    II(0x1017226b, 0x3)   or_(dl, 0x82);                        /* or dl, 0x82 */
    II(0x1017226e, 0x2)   jmpd(0x10172273, 0x3);                /* jmp 0x10172273 */
l_0x10172270:
    II(0x10172270, 0x3)   or_(dl, 0x1);                         /* or dl, 0x1 */
l_0x10172273:
    II(0x10172273, 0x2)   mov(eax, edx);                        /* mov eax, edx */
l_0x10172275:
    II(0x10172275, 0x3)   add(esp, 0x4);                        /* add esp, 0x4 */
    II(0x10172278, 0x1)   popd(esi);                            /* pop esi */
    II(0x10172279, 0x1)   popd(edx);                            /* pop edx */
    II(0x1017227a, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1017227b, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1017227c, 0x1)   retd();                               /* ret */
FUNC_END

