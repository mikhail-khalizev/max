FUNC_BEGIN(0x1008bd66, 0x29cf11a3ccce68a1, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xe2, 0x9f, 0xd, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0xf, 0xe8, 0xe3, 0xef, 0xa, 0, 0x84, 0xc0, 0x74, 0x1f, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0xf, 0xe8, 0x8b, 0xf1, 0xff, 0xff, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x8b, 0x50, 0x2, 0x8b, 0x45, 0xf4, 0xff, 0x52, 0x14, 0x89, 0x45, 0xf8, 0xeb, 0xa, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x40, 0xd, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1008bd66, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x1008bd6b, 0x5)   calld(sys_check_available_stack_size, 0xd9fe2); /* call 0x10165d52 */
    II(0x1008bd70, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1008bd71, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1008bd72, 0x1)   pushd(edx);                           /* push edx */
    II(0x1008bd73, 0x1)   pushd(esi);                           /* push esi */
    II(0x1008bd74, 0x1)   pushd(edi);                           /* push edi */
    II(0x1008bd75, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1008bd76, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1008bd78, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1008bd7e, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1008bd81, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1008bd83, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008bd86, 0x3)   add(eax, 0xf);                        /* add eax, 0xf */
    II(0x1008bd89, 0x5)   calld(0x1013ad71, 0xaefe3);           /* call 0x1013ad71 */
    II(0x1008bd8e, 0x2)   test(al, al);                         /* test al, al */
    II(0x1008bd90, 0x2)   jzd(0x1008bdb1, 0x1f);                /* jz 0x1008bdb1 */
    II(0x1008bd92, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008bd95, 0x3)   add(eax, 0xf);                        /* add eax, 0xf */
    II(0x1008bd98, 0x5)   calld(0x1008af28, -0xe75);            /* call 0x1008af28 */
    II(0x1008bd9d, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1008bda0, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1008bda3, 0x3)   mov(edx, memd_a32(ds, eax + 0x2));    /* mov edx, [eax+0x2] */
//    II(0x1008bda6, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1008bda9, 0x3)   calld_abs(memd_a32(ds, edx + 0x14));  /* call dword near [edx+0x14] */
    II(0x1008bdac, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x1008bdaf, 0x2)   jmpd(0x1008bdbb, 0xa);                /* jmp 0x1008bdbb */
l_0x1008bdb1:
    II(0x1008bdb1, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1008bdb4, 0x4)   mov(ax, memw_a32(ds, eax + 0xd));     /* mov ax, [eax+0xd] */
    II(0x1008bdb8, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
l_0x1008bdbb:
    II(0x1008bdbb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1008bdbe, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1008bdc0, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1008bdc1, 0x1)   popd(edi);                            /* pop edi */
    II(0x1008bdc2, 0x1)   popd(esi);                            /* pop esi */
    II(0x1008bdc3, 0x1)   popd(edx);                            /* pop edx */
    II(0x1008bdc4, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1008bdc5, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1008bdc6, 0x1)   retd();                               /* ret */
FUNC_END

