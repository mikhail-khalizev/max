FUNC_BEGIN(0x1007b4b2, 0x80ce448c7dff0721, 0x20, ({0x68, 0x28, 0, 0, 0, 0xe8, 0x96, 0xa8, 0xe, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x89, 0x45, 0xfc, 0x31, 0xd2, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x15, 0xe8, 0x37, 0xf8, 0xb, 0, 0x84, 0xc0, 0x75, 0x1c, 0x8b, 0x45, 0xfc, 0x83, 0xc0, 0x15, 0xe8, 0x3f, 0xed, 0, 0, 0xe8, 0x82, 0xee, 0, 0, 0x8a, 0x40, 0x4d, 0x25, 0xff, 0, 0, 0, 0x85, 0xc0, 0x7f, 0x6, 0xc6, 0x45, 0xf8, 0x1, 0xeb, 0x4, 0xc6, 0x45, 0xf8, 0, 0x8a, 0x45, 0xf8, 0x88, 0x45, 0xf4, 0x8a, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1007b4b2, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x1007b4b7, 0x5)   calld(sys_check_available_stack_size, 0xea896); /* call 0x10165d52 */
    II(0x1007b4bc, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1007b4bd, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1007b4be, 0x1)   pushd(edx);                           /* push edx */
    II(0x1007b4bf, 0x1)   pushd(esi);                           /* push esi */
    II(0x1007b4c0, 0x1)   pushd(edi);                           /* push edi */
    II(0x1007b4c1, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1007b4c2, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1007b4c4, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1007b4ca, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1007b4cd, 0x2)   xor_(edx, edx);                       /* xor edx, edx */
    II(0x1007b4cf, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1007b4d2, 0x3)   add(eax, 0x15);                       /* add eax, 0x15 */
    II(0x1007b4d5, 0x5)   calld(0x1013ad11, 0xbf837);           /* call 0x1013ad11 */
    II(0x1007b4da, 0x2)   test(al, al);                         /* test al, al */
    II(0x1007b4dc, 0x2)   jnzd(0x1007b4fa, 0x1c);               /* jnz 0x1007b4fa */
    II(0x1007b4de, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x1007b4e1, 0x3)   add(eax, 0x15);                       /* add eax, 0x15 */
    II(0x1007b4e4, 0x5)   calld(0x1008a228, 0xed3f);            /* call 0x1008a228 */
    II(0x1007b4e9, 0x5)   calld(0x1008a370, 0xee82);            /* call 0x1008a370 */
    II(0x1007b4ee, 0x3)   mov(al, memb_a32(ds, eax + 0x4d));    /* mov al, [eax+0x4d] */
    II(0x1007b4f1, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x1007b4f6, 0x2)   test(eax, eax);                       /* test eax, eax */
    II(0x1007b4f8, 0x2)   jgd(0x1007b500, 0x6);                 /* jg 0x1007b500 */
l_0x1007b4fa:
    II(0x1007b4fa, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0x1);    /* mov byte [ebp-0x8], 0x1 */
    II(0x1007b4fe, 0x2)   jmpd(0x1007b504, 0x4);                /* jmp 0x1007b504 */
l_0x1007b500:
    II(0x1007b500, 0x4)   mov(memb_a32(ss, ebp - 0x8), 0);      /* mov byte [ebp-0x8], 0x0 */
l_0x1007b504:
    II(0x1007b504, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x1007b507, 0x3)   mov(memb_a32(ss, ebp - 0xc), al);     /* mov [ebp-0xc], al */
//    II(0x1007b50a, 0x3)   mov(al, memb_a32(ss, ebp - 0xc));     /* mov al, [ebp-0xc] */
    II(0x1007b50d, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1007b50f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1007b510, 0x1)   popd(edi);                            /* pop edi */
    II(0x1007b511, 0x1)   popd(esi);                            /* pop esi */
    II(0x1007b512, 0x1)   popd(edx);                            /* pop edx */
    II(0x1007b513, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x1007b514, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1007b515, 0x1)   retd();                               /* ret */
FUNC_END

