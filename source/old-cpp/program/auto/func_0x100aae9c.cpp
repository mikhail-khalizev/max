FUNC_BEGIN(0x100aae9c, 0x1defb00ce7a71de6, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0xac, 0xae, 0xb, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0x85, 0xbf, 0xfc, 0xff, 0x89, 0x45, 0xfc, 0x8d, 0x45, 0xfc, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xfc, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100aae9c, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x100aaea1, 0x5)   calld(sys_check_available_stack_size, 0xbaeac); /* call 0x10165d52 */
    II(0x100aaea6, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100aaea7, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100aaea8, 0x1)   pushd(edx);                           /* push edx */
    II(0x100aaea9, 0x1)   pushd(esi);                           /* push esi */
    II(0x100aaeaa, 0x1)   pushd(edi);                           /* push edi */
    II(0x100aaeab, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100aaeac, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100aaeae, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x100aaeb4, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x100aaeb7, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100aaeba, 0x5)   calld(my_ctor_0x101b6edc, -0x3407b);  /* call 0x10076e44 */
    II(0x100aaebf, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100aaec2, 0x3)   lea(eax, ebp - 0x4);                  /* lea eax, [ebp-0x4] */
    II(0x100aaec5, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x100aaec8, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x100aaecb, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x100aaece, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x100aaed1, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100aaed3, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100aaed4, 0x1)   popd(edi);                            /* pop edi */
    II(0x100aaed5, 0x1)   popd(esi);                            /* pop esi */
    II(0x100aaed6, 0x1)   popd(edx);                            /* pop edx */
    II(0x100aaed7, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100aaed8, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100aaed9, 0x1)   retd();                               /* ret */
FUNC_END

