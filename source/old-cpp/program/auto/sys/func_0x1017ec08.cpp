FUNC_BEGIN(/* sys */ 0x1017ec08, 0xc733447996bab4e, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0xc1, 0xe0, 0x2, 0x8b, 0x80, 0xf4, 0xe4, 0x1b, 0x10, 0x89, 0x45, 0xfc, 0x8b, 0x45, 0xfc, 0xc9, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1017ec08, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1017ec09, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1017ec0a, 0x1)   pushd(edx);                           /* push edx */
    II(0x1017ec0b, 0x1)   pushd(esi);                           /* push esi */
    II(0x1017ec0c, 0x1)   pushd(edi);                           /* push edi */
    II(0x1017ec0d, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1017ec0e, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1017ec10, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1017ec16, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x1017ec19, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x1017ec1c, 0x3)   shl(eax, 0x2);                        /* shl eax, 0x2 */
    II(0x1017ec1f, 0x6)   mov(eax, memd_a32(ds, eax + 0x101be4f4)); /* mov eax, [eax+0x101be4f4] */
    II(0x1017ec25, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
//    II(0x1017ec28, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1017ec2b, 0x1)   leaved();                             /* leave */
    II(0x1017ec2c, 0x1)   popd(edi);                            /* pop edi */
    II(0x1017ec2d, 0x1)   popd(esi);                            /* pop esi */
    II(0x1017ec2e, 0x1)   popd(edx);                            /* pop edx */
    II(0x1017ec2f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1017ec30, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1017ec31, 0x1)   retd();                               /* ret */
FUNC_END

