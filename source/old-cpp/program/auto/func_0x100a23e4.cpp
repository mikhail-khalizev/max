FUNC_BEGIN(0x100a23e4, 0xaf9968e2e05af4d2, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x64, 0x39, 0xc, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x10, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0xf, 0xbf, 0x55, 0xfc, 0xf, 0xbf, 0x45, 0xf8, 0xe8, 0x56, 0x27, 0x3, 0, 0x89, 0x45, 0xf4, 0xf, 0xbf, 0x45, 0xf8, 0x6b, 0xc0, 0x33, 0x66, 0xf7, 0x80, 0xc0, 0x81, 0x1c, 0x10, 0xc0, 0x1, 0x74, 0x1a, 0xba, 0x1, 0, 0, 0, 0xb8, 0x19, 0, 0, 0, 0xe8, 0xce, 0xf9, 0xfc, 0xff, 0x8b, 0x55, 0xf4, 0xf, 0xaf, 0xd0, 0x89, 0x55, 0xf4, 0xeb, 0x18, 0xba, 0x1, 0, 0, 0, 0xb8, 0x31, 0, 0, 0, 0xe8, 0xb4, 0xf9, 0xfc, 0xff, 0x8b, 0x55, 0xf4, 0xf, 0xaf, 0xd0, 0x89, 0x55, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0x45, 0xf0, 0x8b, 0x45, 0xf0, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x100a23e4, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x100a23e9, 0x5)   calld(sys_check_available_stack_size, 0xc3964); /* call 0x10165d52 */
    II(0x100a23ee, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100a23ef, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100a23f0, 0x1)   pushd(esi);                           /* push esi */
    II(0x100a23f1, 0x1)   pushd(edi);                           /* push edi */
    II(0x100a23f2, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100a23f3, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100a23f5, 0x6)   sub(esp, 0x10);                       /* sub esp, 0x10 */
    II(0x100a23fb, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100a23fe, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x100a2401, 0x4)   movsx(edx, memw_a32(ss, ebp - 0x4));  /* movsx edx, word [ebp-0x4] */
    II(0x100a2405, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x100a2409, 0x5)   calld(0x100d4b64, 0x32756);           /* call 0x100d4b64 */
    II(0x100a240e, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
    II(0x100a2411, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x8));  /* movsx eax, word [ebp-0x8] */
    II(0x100a2415, 0x3)   imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
    II(0x100a2418, 0x9)   test(memw_a32(ds, eax + 0x101c81c0), 0x1c0); /* test word [eax+0x101c81c0], 0x1c0 */
    II(0x100a2421, 0x2)   jzd(0x100a243d, 0x1a);                /* jz 0x100a243d */
    II(0x100a2423, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
    II(0x100a2428, 0x5)   mov(eax, 0x19);                       /* mov eax, 0x19 */
    II(0x100a242d, 0x5)   calld(0x10071e00, -0x30632);          /* call 0x10071e00 */
    II(0x100a2432, 0x3)   mov(edx, memd_a32(ss, ebp - 0xc));    /* mov edx, [ebp-0xc] */
    II(0x100a2435, 0x3)   imul(edx, eax);                       /* imul edx, eax */
    II(0x100a2438, 0x3)   mov(memd_a32(ss, ebp - 0xc), edx);    /* mov [ebp-0xc], edx */
    II(0x100a243b, 0x2)   jmpd(0x100a2455, 0x18);               /* jmp 0x100a2455 */
l_0x100a243d:
    II(0x100a243d, 0x5)   mov(edx, 0x1);                        /* mov edx, 0x1 */
    II(0x100a2442, 0x5)   mov(eax, 0x31);                       /* mov eax, 0x31 */
    II(0x100a2447, 0x5)   calld(0x10071e00, -0x3064c);          /* call 0x10071e00 */
    II(0x100a244c, 0x3)   mov(edx, memd_a32(ss, ebp - 0xc));    /* mov edx, [ebp-0xc] */
    II(0x100a244f, 0x3)   imul(edx, eax);                       /* imul edx, eax */
    II(0x100a2452, 0x3)   mov(memd_a32(ss, ebp - 0xc), edx);    /* mov [ebp-0xc], edx */
l_0x100a2455:
    II(0x100a2455, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100a2458, 0x3)   mov(memd_a32(ss, ebp - 0x10), eax);   /* mov [ebp-0x10], eax */
//    II(0x100a245b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x10));   /* mov eax, [ebp-0x10] */
    II(0x100a245e, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100a2460, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100a2461, 0x1)   popd(edi);                            /* pop edi */
    II(0x100a2462, 0x1)   popd(esi);                            /* pop esi */
    II(0x100a2463, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100a2464, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100a2465, 0x1)   retd();                               /* ret */
FUNC_END

