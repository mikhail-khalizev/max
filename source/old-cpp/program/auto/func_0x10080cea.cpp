FUNC_BEGIN(0x10080cea, 0x241d8242fe29dceb, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x5e, 0x50, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x13, 0xe8, 0x28, 0x56, 0xff, 0xff, 0x8d, 0x5d, 0xf8, 0x89, 0xc2, 0x89, 0xd8, 0xe8, 0x9c, 0x57, 0xff, 0xff, 0xeb, 0x8, 0x8d, 0x45, 0xf8, 0xe8, 0xd2, 0x5e, 0xff, 0xff, 0x31, 0xd2, 0x8d, 0x45, 0xf8, 0xe8, 0x41, 0xa0, 0xb, 0, 0x84, 0xc0, 0x74, 0x2e, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x8b, 0x58, 0x2, 0x8d, 0x45, 0xf8, 0xe8, 0x8c, 0x56, 0xff, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xf4, 0xff, 0x53, 0x44, 0x84, 0xc0, 0x74, 0xc, 0x31, 0xd2, 0x8d, 0x45, 0xf8, 0xe8, 0xe, 0x52, 0xff, 0xff, 0xeb, 0xc, 0xeb, 0xbc, 0x31, 0xd2, 0x8d, 0x45, 0xf8, 0xe8, 0, 0x52, 0xff, 0xff, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10080cea, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x10080cef, 0x5)   calld(sys_check_available_stack_size, 0xe505e); /* call 0x10165d52 */
    II(0x10080cf4, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10080cf5, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10080cf6, 0x1)   pushd(edx);                           /* push edx */
    II(0x10080cf7, 0x1)   pushd(esi);                           /* push esi */
    II(0x10080cf8, 0x1)   pushd(edi);                           /* push edi */
    II(0x10080cf9, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10080cfa, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10080cfc, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10080d02, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x10080d05, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10080d08, 0x3)   add(eax, 0x13);                       /* add eax, 0x13 */
    II(0x10080d0b, 0x5)   calld(0x10076338, -0xa9d8);           /* call 0x10076338 */
    II(0x10080d10, 0x3)   lea(ebx, ebp - 0x8);                  /* lea ebx, [ebp-0x8] */
    II(0x10080d13, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10080d15, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x10080d17, 0x5)   calld(0x100764b8, -0xa864);           /* call 0x100764b8 */
    II(0x10080d1c, 0x2)   jmpd(0x10080d26, 0x8);                /* jmp 0x10080d26 */
l_0x10080d1e:
    II(0x10080d1e, 0x3)   lea(eax, ebp - 0x8);                  /* lea eax, [ebp-0x8] */
    II(0x10080d21, 0x5)   calld(0x10076bf8, -0xa12e);           /* call 0x10076bf8 */
l_0x10080d26:
    II(0x10080d26, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10080d28, 0x3)   lea(eax, ebp - 0x8);                  /* lea eax, [ebp-0x8] */
    II(0x10080d2b, 0x5)   calld(0x1013ad71, 0xba041);           /* call 0x1013ad71 */
    II(0x10080d30, 0x2)   test(al, al);                         /* test al, al */
    II(0x10080d32, 0x2)   jzd(0x10080d62, 0x2e);                /* jz 0x10080d62 */
    II(0x10080d34, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10080d37, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x10080d3a, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10080d3d, 0x3)   mov(ebx, memd_a32(ds, eax + 0x2));    /* mov ebx, [eax+0x2] */
    II(0x10080d40, 0x3)   lea(eax, ebp - 0x8);                  /* lea eax, [ebp-0x8] */
    II(0x10080d43, 0x5)   calld(0x100763d4, -0xa974);           /* call 0x100763d4 */
    II(0x10080d48, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10080d4a, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10080d4d, 0x3)   calld_abs(memd_a32(ds, ebx + 0x44));  /* call dword near [ebx+0x44] */
    II(0x10080d50, 0x2)   test(al, al);                         /* test al, al */
    II(0x10080d52, 0x2)   jzd(0x10080d60, 0xc);                 /* jz 0x10080d60 */
    II(0x10080d54, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10080d56, 0x3)   lea(eax, ebp - 0x8);                  /* lea eax, [ebp-0x8] */
    II(0x10080d59, 0x5)   calld(0x10075f6c, -0xadf2);           /* call 0x10075f6c */
    II(0x10080d5e, 0x2)   jmpd(0x10080d6c, 0xc);                /* jmp 0x10080d6c */
l_0x10080d60:
    II(0x10080d60, 0x2)   jmpd(0x10080d1e, -0x44);              /* jmp 0x10080d1e */
l_0x10080d62:
    II(0x10080d62, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x10080d64, 0x3)   lea(eax, ebp - 0x8);                  /* lea eax, [ebp-0x8] */
    II(0x10080d67, 0x5)   calld(0x10075f6c, -0xae00);           /* call 0x10075f6c */
l_0x10080d6c:
    II(0x10080d6c, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10080d6e, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10080d6f, 0x1)   popd(edi);                            /* pop edi */
    II(0x10080d70, 0x1)   popd(esi);                            /* pop esi */
    II(0x10080d71, 0x1)   popd(edx);                            /* pop edx */
    II(0x10080d72, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10080d73, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10080d74, 0x1)   retd();                               /* ret */
FUNC_END

