FUNC_BEGIN(0x101468e2, 0x77a8bfdd3f9d613c, 0x20, ({0x68, 0x2c, 0, 0, 0, 0xe8, 0x66, 0xf4, 0x1, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xfc, 0xc6, 0x45, 0xf8, 0, 0x8b, 0x45, 0xfc, 0x83, 0x78, 0x1c, 0x20, 0x74, 0x9, 0x8b, 0x45, 0xfc, 0x83, 0x78, 0x1c, 0xa, 0x75, 0x2, 0xeb, 0x9, 0x8b, 0x45, 0xfc, 0x83, 0x78, 0x1c, 0x9, 0x75, 0xa, 0x8b, 0x45, 0xfc, 0xe8, 0xfc, 0xfd, 0xff, 0xff, 0xeb, 0xd9, 0x8b, 0x45, 0xfc, 0x83, 0x78, 0x1c, 0x2f, 0x75, 0x16, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x12, 0xe8, 0xb4, 0x45, 0xfa, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xfc, 0x66, 0x3b, 0x50, 0x1a, 0x7f, 0x2, 0xeb, 0x19, 0x8b, 0x45, 0xfc, 0x8b, 0x50, 0x18, 0xc1, 0xfa, 0x10, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x12, 0xe8, 0x35, 0xb9, 0xff, 0xff, 0x80, 0x38, 0x2f, 0x74, 0x2, 0xeb, 0x22, 0x8b, 0x45, 0xfc, 0x83, 0x78, 0x1c, 0xa, 0x74, 0x9, 0x8b, 0x45, 0xfc, 0x83, 0x78, 0x1c, 0xff, 0x75, 0x2, 0xeb, 0xa, 0x8b, 0x45, 0xfc, 0xe8, 0xa2, 0xfd, 0xff, 0xff, 0xeb, 0xe2, 0xc6, 0x45, 0xf8, 0x1, 0x80, 0x7d, 0xf8, 0, 0xf, 0x85, 0x6d, 0xff, 0xff, 0xff, 0x8b, 0x45, 0xfc, 0x83, 0x78, 0x1c, 0xff, 0x74, 0x6, 0xc6, 0x45, 0xf0, 0x1, 0xeb, 0x4, 0xc6, 0x45, 0xf0, 0, 0x8a, 0x45, 0xf0, 0x88, 0x45, 0xf4, 0x8a, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101468e2, 0x5)   pushd(0x2c);                          /* push dword 0x2c */
    II(0x101468e7, 0x5)   calld(sys_check_available_stack_size, 0x1f466); /* call 0x10165d52 */
    II(0x101468ec, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101468ed, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101468ee, 0x1)   pushd(edx);                           /* push edx */
    II(0x101468ef, 0x1)   pushd(esi);                           /* push esi */
    II(0x101468f0, 0x1)   pushd(edi);                           /* push edi */
    II(0x101468f1, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101468f2, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101468f4, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x101468fa, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
l_0x101468fd:
    II(0x101468fd, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0);      /* mov byte [ebp-0x8], 0x0 */
l_0x10146901:
    II(0x10146901, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10146904, 0x4)   cmp(memd_a32(ds, eax + 0x1c), 0x20);  /* cmp dword [eax+0x1c], 0x20 */
    II(0x10146908, 0x2)   jzd(0x10146913, 0x9);                 /* jz 0x10146913 */
    II(0x1014690a, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014690d, 0x4)   cmp(memd_a32(ds, eax + 0x1c), 0xa);   /* cmp dword [eax+0x1c], 0xa */
    II(0x10146911, 0x2)   jnzd(0x10146915, 0x2);                /* jnz 0x10146915 */
l_0x10146913:
    II(0x10146913, 0x2)   jmpd(0x1014691e, 0x9);                /* jmp 0x1014691e */
l_0x10146915:
    II(0x10146915, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10146918, 0x4)   cmp(memd_a32(ds, eax + 0x1c), 0x9);   /* cmp dword [eax+0x1c], 0x9 */
    II(0x1014691c, 0x2)   jnzd(0x10146928, 0xa);                /* jnz 0x10146928 */
l_0x1014691e:
    II(0x1014691e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10146921, 0x5)   calld(0x10146722, -0x204);            /* call 0x10146722 */
    II(0x10146926, 0x2)   jmpd(0x10146901, -0x27);              /* jmp 0x10146901 */
l_0x10146928:
    II(0x10146928, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014692b, 0x4)   cmp(memd_a32(ds, eax + 0x1c), 0x2f);  /* cmp dword [eax+0x1c], 0x2f */
    II(0x1014692f, 0x2)   jnzd(0x10146947, 0x16);               /* jnz 0x10146947 */
    II(0x10146931, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10146934, 0x3)   add(eax, 0x12);                       /* add eax, 0x12 */
    II(0x10146937, 0x5)   calld(0x100eaef0, -0x5ba4c);          /* call 0x100eaef0 */
    II(0x1014693c, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1014693e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10146941, 0x4)   cmp(dx, memw_a32(ds, eax + 0x1a));    /* cmp dx, [eax+0x1a] */
    II(0x10146945, 0x2)   jgd(0x10146949, 0x2);                 /* jg 0x10146949 */
l_0x10146947:
    II(0x10146947, 0x2)   jmpd(0x10146962, 0x19);               /* jmp 0x10146962 */
l_0x10146949:
    II(0x10146949, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014694c, 0x3)   mov(edx, memd_a32(ds, eax + 0x18));   /* mov edx, [eax+0x18] */
    II(0x1014694f, 0x3)   sar(edx, 0x10);                       /* sar edx, 0x10 */
    II(0x10146952, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10146955, 0x3)   add(eax, 0x12);                       /* add eax, 0x12 */
    II(0x10146958, 0x5)   calld(my_string_get, -0x46cb);        /* call 0x10142292 */
    II(0x1014695d, 0x3)   cmp(memb_a32(ds, eax), 0x2f);         /* cmp byte [eax], 0x2f */
    II(0x10146960, 0x2)   jzd(0x10146964, 0x2);                 /* jz 0x10146964 */
l_0x10146962:
    II(0x10146962, 0x2)   jmpd(0x10146986, 0x22);               /* jmp 0x10146986 */
l_0x10146964:
    II(0x10146964, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10146967, 0x4)   cmp(memd_a32(ds, eax + 0x1c), 0xa);   /* cmp dword [eax+0x1c], 0xa */
    II(0x1014696b, 0x2)   jzd(0x10146976, 0x9);                 /* jz 0x10146976 */
    II(0x1014696d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10146970, 0x4)   cmp(memd_a32(ds, eax + 0x1c), -0x1 /* 0xff */); /* cmp dword [eax+0x1c], 0xff */
    II(0x10146974, 0x2)   jnzd(0x10146978, 0x2);                /* jnz 0x10146978 */
l_0x10146976:
    II(0x10146976, 0x2)   jmpd(0x10146982, 0xa);                /* jmp 0x10146982 */
l_0x10146978:
    II(0x10146978, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014697b, 0x5)   calld(0x10146722, -0x25e);            /* call 0x10146722 */
    II(0x10146980, 0x2)   jmpd(0x10146964, -0x1e);              /* jmp 0x10146964 */
l_0x10146982:
    II(0x10146982, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x1);    /* mov byte [ebp-0x8], 0x1 */
l_0x10146986:
    II(0x10146986, 0x4)   cmp(memb_a32(ss, ebp - 0x8), 0);      /* cmp byte [ebp-0x8], 0x0 */
    II(0x1014698a, 0x6)   jnzd(0x101468fd, -0x93);              /* jnz dword 0x101468fd */
    II(0x10146990, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10146993, 0x4)   cmp(memd_a32(ds, eax + 0x1c), -0x1 /* 0xff */); /* cmp dword [eax+0x1c], 0xff */
    II(0x10146997, 0x2)   jzd(0x1014699f, 0x6);                 /* jz 0x1014699f */
    II(0x10146999, 0x4)   mov(memb_a32(ss, ebp - 0x10), 0x1);   /* mov byte [ebp-0x10], 0x1 */
    II(0x1014699d, 0x2)   jmpd(0x101469a3, 0x4);                /* jmp 0x101469a3 */
l_0x1014699f:
    II(0x1014699f, 0x4)   mov(memb_a32(ss, ebp - 0x10), 0);     /* mov byte [ebp-0x10], 0x0 */
l_0x101469a3:
    II(0x101469a3, 0x3)   mov(al, memb_a32(ss, ebp - 0x10));    /* mov al, [ebp-0x10] */
    II(0x101469a6, 0x3)   mov(memb_a32(ss, ebp - 0xc), al);     /* mov [ebp-0xc], al */
//    II(0x101469a9, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x101469ac, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101469ae, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101469af, 0x1)   popd(edi);                            /* pop edi */
    II(0x101469b0, 0x1)   popd(esi);                            /* pop esi */
    II(0x101469b1, 0x1)   popd(edx);                            /* pop edx */
    II(0x101469b2, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x101469b3, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x101469b4, 0x1)   retd();                               /* ret */
FUNC_END

