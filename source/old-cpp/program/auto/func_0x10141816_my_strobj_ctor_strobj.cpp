FUNC_BEGIN(my_strobj_ctor_strobj, 0x97d9ddc1e281da93, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x32, 0x45, 0x2, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xfc, 0xe8, 0xe9, 0x96, 0xfa, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xf8, 0x66, 0x89, 0x50, 0x6, 0x8b, 0x45, 0xfc, 0xe8, 0x10, 0xd, 0, 0, 0x89, 0xc2, 0x8b, 0x45, 0xf8, 0x66, 0x89, 0x50, 0x4, 0x8b, 0x45, 0xf8, 0x8b, 0x40, 0x2, 0xc1, 0xf8, 0x10, 0x40, 0xe8, 0xac, 0x47, 0x2, 0, 0x89, 0xc2, 0x8b, 0x45, 0xf8, 0x89, 0x10, 0x8b, 0x45, 0xfc, 0xe8, 0x89, 0x7f, 0xf4, 0xff, 0x89, 0xc2, 0x8b, 0x45, 0xf8, 0x8b, 0, 0xe8, 0x50, 0x46, 0x2, 0, 0x8b, 0x45, 0xf8, 0xc7, 0x40, 0x8, 0x1, 0, 0, 0, 0x8b, 0x45, 0xf8, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10141816, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1014181b, 0x5)   calld(sys_check_available_stack_size, 0x24532); /* call 0x10165d52 */
    II(0x10141820, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10141821, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10141822, 0x1)   pushd(esi);                           /* push esi */
    II(0x10141823, 0x1)   pushd(edi);                           /* push edi */
    II(0x10141824, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10141825, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10141827, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1014182d, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10141830, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
    II(0x10141833, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10141836, 0x5)   calld(my_strobj_get_len, -0x56917);   /* call 0x100eaf24 */
    II(0x1014183b, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1014183d, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141840, 0x4)   mov(memw_a32(ds, eax + 0x6), dx);     /* mov [eax+0x6], dx */
    II(0x10141844, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10141847, 0x5)   calld(my_strobj_get_size, 0xd10);     /* call 0x1014255c */
    II(0x1014184c, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1014184e, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141851, 0x4)   mov(memw_a32(ds, eax + 0x4), dx);     /* mov [eax+0x4], dx */
    II(0x10141855, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141858, 0x3)   mov(eax, memd_a32(ds, eax + 0x2));    /* mov eax, [eax+0x2] */
    II(0x1014185b, 0x3)   sar(eax, 0x10);                       /* sar eax, 0x10 */
    II(0x1014185e, 0x1)   inc(eax);                             /* inc eax */
    II(0x1014185f, 0x5)   calld(sys_new_arr, 0x247ac);          /* call 0x10166010 */
    II(0x10141864, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10141866, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141869, 0x2)   mov(memd_a32(ds, eax), edx);          /* mov [eax], edx */
    II(0x1014186b, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1014186e, 0x5)   calld(my_strobj_c_str, -0xb8077);     /* call 0x100897fc */
    II(0x10141873, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x10141875, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141878, 0x2)   mov(eax, memd_a32(ds, eax));          /* mov eax, [eax] */
    II(0x1014187a, 0x5)   calld(sys_strcpy, 0x24650);           /* call 0x10165ecf */
    II(0x1014187f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10141882, 0x7)   mov(memd_a32(ds, eax + 0x8), 0x1);    /* mov dword [eax+0x8], 0x1 */
    II(0x10141889, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1014188c, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x1014188f, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10141892, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10141894, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10141895, 0x1)   popd(edi);                            /* pop edi */
    II(0x10141896, 0x1)   popd(esi);                            /* pop esi */
    II(0x10141897, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10141898, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10141899, 0x1)   retd();                               /* ret */
FUNC_END

