FUNC_BEGIN(/* sys */ 0x101822f8, 0xe8df819f1360a48d, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x89, 0xc6, 0x85, 0xc0, 0x74, 0x6b, 0x8d, 0x70, 0xc, 0x89, 0xf0, 0xe8, 0xd1, 0x8c, 0xfe, 0xff, 0x89, 0xc7, 0x85, 0xc0, 0x74, 0x5b, 0x68, 0xcc, 0, 0, 0, 0xbb, 0x1, 0, 0, 0, 0x89, 0xf1, 0x89, 0xf2, 0xe8, 0x52, 0x8a, 0xfe, 0xff, 0x89, 0xf2, 0x89, 0xf8, 0xe8, 0x91, 0x2, 0, 0, 0x8b, 0x15, 0x24, 0xe8, 0x1b, 0x10, 0x8b, 0x1d, 0x28, 0xe8, 0x1b, 0x10, 0x42, 0x89, 0xc7, 0x89, 0x15, 0x24, 0xe8, 0x1b, 0x10, 0x39, 0xda, 0x7e, 0x6, 0x89, 0x15, 0x28, 0xe8, 0x1b, 0x10, 0x8b, 0xd, 0x2c, 0xe8, 0x1b, 0x10, 0x1, 0xf1, 0x8b, 0x35, 0x30, 0xe8, 0x1b, 0x10, 0x89, 0xd, 0x2c, 0xe8, 0x1b, 0x10, 0x39, 0xf1, 0x76, 0x6, 0x89, 0xd, 0x30, 0xe8, 0x1b, 0x10, 0x89, 0xf8, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x101822f8, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101822f9, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x101822fa, 0x1)   pushd(edx);                           /* push edx */
    II(0x101822fb, 0x1)   pushd(esi);                           /* push esi */
    II(0x101822fc, 0x1)   pushd(edi);                           /* push edi */
    II(0x101822fd, 0x2)   mov(esi, eax);                        /* mov esi, eax */
    II(0x101822ff, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10182301, 0x2)   jzd(0x1018236e, 0x6b);                /* jz 0x1018236e */
    II(0x10182303, 0x3)   lea(esi, eax + 0xc);                  /* lea esi, [eax+0xc] */
    II(0x10182306, 0x2)   mov(eax, esi);                        /* mov eax, esi */
    II(0x10182308, 0x5)   calld(sys_malloc, -0x1732f);          /* call 0x1016afde */
    II(0x1018230d, 0x2)   mov(edi, eax);                        /* mov edi, eax */
    II(0x1018230f, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x10182311, 0x2)   jzd(0x1018236e, 0x5b);                /* jz 0x1018236e */
    II(0x10182313, 0x5)   pushd(0xcc);                          /* push dword 0xcc */
    II(0x10182318, 0x5)   mov(ebx, 0x1);                        /* mov ebx, 0x1 */
    II(0x1018231d, 0x2)   mov(ecx, esi);                        /* mov ecx, esi */
    II(0x1018231f, 0x2)   mov(edx, esi);                        /* mov edx, esi */
    II(0x10182321, 0x5)   calld(/* sys */ 0x1016ad78, -0x175ae); /* call 0x1016ad78 */
    II(0x10182326, 0x2)   mov(edx, esi);                        /* mov edx, esi */
    II(0x10182328, 0x2)   mov(eax, edi);                        /* mov eax, edi */
    II(0x1018232a, 0x5)   calld(/* sys */ 0x101825c0, 0x291);   /* call 0x101825c0 */
    II(0x1018232f, 0x6)   mov(edx, memd_a32(ds, 0x101be824));   /* mov edx, [0x101be824] */
    II(0x10182335, 0x6)   mov(ebx, memd_a32(ds, 0x101be828));   /* mov ebx, [0x101be828] */
    II(0x1018233b, 0x1)   inc(edx);                             /* inc edx */
    II(0x1018233c, 0x2)   mov(edi, eax);                        /* mov edi, eax */
    II(0x1018233e, 0x6)   mov(memd_a32(ds, 0x101be824), edx);   /* mov [0x101be824], edx */
    II(0x10182344, 0x2)   cmp(edx, ebx);                        /* cmp edx, ebx */
    II(0x10182346, 0x2)   jled(0x1018234e, 0x6);                /* jle 0x1018234e */
    II(0x10182348, 0x6)   mov(memd_a32(ds, 0x101be828), edx);   /* mov [0x101be828], edx */
l_0x1018234e:
    II(0x1018234e, 0x6)   mov(ecx, memd_a32(ds, 0x101be82c));   /* mov ecx, [0x101be82c] */
    II(0x10182354, 0x2)   add(ecx, esi);                        /* add ecx, esi */
    II(0x10182356, 0x6)   mov(esi, memd_a32(ds, 0x101be830));   /* mov esi, [0x101be830] */
    II(0x1018235c, 0x6)   mov(memd_a32(ds, 0x101be82c), ecx);   /* mov [0x101be82c], ecx */
    II(0x10182362, 0x2)   cmp(ecx, esi);                        /* cmp ecx, esi */
    II(0x10182364, 0x2)   jbed(0x1018236c, 0x6);                /* jbe 0x1018236c */
    II(0x10182366, 0x6)   mov(memd_a32(ds, 0x101be830), ecx);   /* mov [0x101be830], ecx */
l_0x1018236c:
    II(0x1018236c, 0x2)   mov(eax, edi);                        /* mov eax, edi */
l_0x1018236e:
    II(0x1018236e, 0x1)   popd(edi);                            /* pop edi */
    II(0x1018236f, 0x1)   popd(esi);                            /* pop esi */
    II(0x10182370, 0x1)   popd(edx);                            /* pop edx */
    II(0x10182371, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10182372, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10182373, 0x1)   retd();                               /* ret */
FUNC_END

