FUNC_BEGIN(0x10070ca1, 0x29beed33ae9d62f0, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0xa7, 0x50, 0xf, 0, 0x53, 0x51, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xf8, 0x89, 0x55, 0xfc, 0x8b, 0x45, 0xf8, 0x66, 0x8b, 0x50, 0x1a, 0x8b, 0x45, 0xfc, 0x66, 0x29, 0x10, 0x8b, 0x45, 0xf8, 0x66, 0x8b, 0x50, 0x1c, 0x8b, 0x45, 0xfc, 0x66, 0x29, 0x50, 0x2, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x50, 0x2, 0x66, 0xf, 0xaf, 0x50, 0x2, 0x8b, 0x45, 0xfc, 0x66, 0x8b, 0x18, 0x66, 0xf, 0xaf, 0x18, 0x89, 0xd8, 0x1, 0xd0, 0x89, 0x45, 0xf4, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x59, 0x5b, 0xc3}))
    II(0x10070ca1, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x10070ca6, 0x5)   calld(sys_check_available_stack_size, 0xf50a7); /* call 0x10165d52 */
    II(0x10070cab, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10070cac, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10070cad, 0x1)   pushd(esi);                           /* push esi */
    II(0x10070cae, 0x1)   pushd(edi);                           /* push edi */
    II(0x10070caf, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10070cb0, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10070cb2, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x10070cb8, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
    II(0x10070cbb, 0x3)   mov(memd_a32(ss, ebp - 0x4), edx);    /* mov [ebp-0x4], edx */
//    II(0x10070cbe, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10070cc1, 0x4)   mov(dx, memw_a32(ds, eax + 0x1a));    /* mov dx, [eax+0x1a] */
    II(0x10070cc5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10070cc8, 0x3)   sub(memw_a32(ds, eax), dx);           /* sub [eax], dx */
    II(0x10070ccb, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10070cce, 0x4)   mov(dx, memw_a32(ds, eax + 0x1c));    /* mov dx, [eax+0x1c] */
    II(0x10070cd2, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10070cd5, 0x4)   sub(memw_a32(ds, eax + 0x2), dx);     /* sub [eax+0x2], dx */
    II(0x10070cd9, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10070cdc, 0x4)   mov(dx, memw_a32(ds, eax + 0x2));     /* mov dx, [eax+0x2] */
    II(0x10070ce0, 0x5)   imul(dx, memw_a32(ds, eax + 0x2));    /* imul dx, [eax+0x2] */
    II(0x10070ce5, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10070ce8, 0x3)   mov(bx, memw_a32(ds, eax));           /* mov bx, [eax] */
    II(0x10070ceb, 0x4)   imul(bx, memw_a32(ds, eax));          /* imul bx, [eax] */
    II(0x10070cef, 0x2)   mov(eax, ebx);                        /* mov eax, ebx */
    II(0x10070cf1, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x10070cf3, 0x3)   mov(memd_a32(ss, ebp - 0xc), eax);    /* mov [ebp-0xc], eax */
//    II(0x10070cf6, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x10070cf9, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10070cfb, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10070cfc, 0x1)   popd(edi);                            /* pop edi */
    II(0x10070cfd, 0x1)   popd(esi);                            /* pop esi */
    II(0x10070cfe, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10070cff, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10070d00, 0x1)   retd();                               /* ret */
FUNC_END

