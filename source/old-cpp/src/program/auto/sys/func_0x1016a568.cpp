FUNC_BEGIN(/* sys */ 0x1016a568, 0x2e3ac75ba816e3e8, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x55, 0x8b, 0x35, 0x64, 0xf9, 0x1c, 0x10, 0x89, 0xf1, 0x8b, 0x46, 0xc, 0x31, 0xdb, 0x31, 0xd2, 0xeb, 0xc, 0x8b, 0x28, 0x39, 0xeb, 0x7d, 0x2, 0x89, 0xeb, 0x83, 0xc0, 0x8, 0x42, 0x3b, 0x16, 0x7c, 0xf0, 0x8b, 0x46, 0x8, 0x1, 0xd8, 0x89, 0x35, 0x64, 0xf9, 0x1c, 0x10, 0x5d, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1016a568, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1016a569, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1016a56a, 0x1)   pushd(edx);                           /* push edx */
    II(0x1016a56b, 0x1)   pushd(esi);                           /* push esi */
    II(0x1016a56c, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1016a56d, 0x6)   mov(esi, memd_a32(ds, 0x101cf964));   /* mov esi, [0x101cf964] */
    II(0x1016a573, 0x2)   mov(ecx, esi);                        /* mov ecx, esi */
    II(0x1016a575, 0x3)   mov(eax, memd_a32(ds, esi + 0xc));    /* mov eax, [esi+0xc] */
    II(0x1016a578, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x1016a57a, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1016a57c, 0x2)   jmpd(0x1016a58a, 0xc);                /* jmp 0x1016a58a */
l_0x1016a57e:
    II(0x1016a57e, 0x2)   mov(ebp, memd_a32(ds, eax));          /* mov ebp, [eax] */
    II(0x1016a580, 0x2)   cmp(ebx, ebp);                        /* cmp ebx, ebp */
    II(0x1016a582, 0x2)   jged(0x1016a586, 0x2);                /* jge 0x1016a586 */
    II(0x1016a584, 0x2)   mov(ebx, ebp);                        /* mov ebx, ebp */
l_0x1016a586:
    II(0x1016a586, 0x3)   add(eax, 0x8);                        /* add eax, 0x8 */
    II(0x1016a589, 0x1)   inc(edx);                             /* inc edx */
l_0x1016a58a:
    II(0x1016a58a, 0x2)   cmp(edx, memd_a32(ds, esi));          /* cmp edx, [esi] */
    II(0x1016a58c, 0x2)   jld(0x1016a57e, -0x10);               /* jl 0x1016a57e */
    II(0x1016a58e, 0x3)   mov(eax, memd_a32(ds, esi + 0x8));    /* mov eax, [esi+0x8] */
    II(0x1016a591, 0x2)   add(eax, ebx);                        /* add eax, ebx */
    II(0x1016a593, 0x6)   mov(memd_a32(ds, 0x101cf964), esi);   /* mov [0x101cf964], esi */
    II(0x1016a599, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1016a59a, 0x1)   popd(esi);                            /* pop esi */
    II(0x1016a59b, 0x1)   popd(edx);                            /* pop edx */
    II(0x1016a59c, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1016a59d, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1016a59e, 0x1)   retd();                               /* ret */
FUNC_END

