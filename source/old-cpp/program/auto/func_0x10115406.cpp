FUNC_BEGIN(0x10115406, 0x414088eda4a6c8d7, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x42, 0x9, 0x5, 0, 0x53, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0xc, 0, 0, 0, 0x8d, 0x45, 0xf8, 0x50, 0x8b, 0x55, 0x1c, 0x8c, 0xdb, 0x8b, 0x45, 0x18, 0x8b, 0x75, 0x14, 0x89, 0xd9, 0x89, 0xc3, 0x89, 0xf0, 0xe8, 0xde, 0x3f, 0x6, 0, 0x89, 0x45, 0xfc, 0x83, 0x7d, 0xfc, 0, 0x75, 0x8, 0x8b, 0x45, 0xf8, 0x3b, 0x45, 0x1c, 0x74, 0x9, 0xc7, 0x45, 0xf4, 0, 0, 0, 0, 0xeb, 0x7, 0xc7, 0x45, 0xf4, 0x1, 0, 0, 0, 0x8b, 0x45, 0xf4, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5b, 0xc3}))
    II(0x10115406, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1011540b, 0x5)   calld(sys_check_available_stack_size, 0x50942); /* call 0x10165d52 */
    II(0x10115410, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10115411, 0x1)   pushd(esi);                           /* push esi */
    II(0x10115412, 0x1)   pushd(edi);                           /* push edi */
    II(0x10115413, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10115414, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10115416, 0x6)   sub(esp, 0xc);                        /* sub esp, 0xc */
    II(0x1011541c, 0x3)   lea(eax, ebp - 0x8);                  /* lea eax, [ebp-0x8] */
    II(0x1011541f, 0x1)   pushd(eax);                           /* push eax */
    II(0x10115420, 0x3)   mov(edx, memd_a32(ss, ebp + 0x1c));   /* mov edx, [ebp+0x1c] */
    II(0x10115423, 0x2)   mov(ebx, ds);                         /* mov ebx, ds */
    II(0x10115425, 0x3)   mov(eax, memd_a32(ss, ebp + 0x18));   /* mov eax, [ebp+0x18] */
    II(0x10115428, 0x3)   mov(esi, memd_a32(ss, ebp + 0x14));   /* mov esi, [ebp+0x14] */
    II(0x1011542b, 0x2)   mov(ecx, ebx);                        /* mov ecx, ebx */
    II(0x1011542d, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x1011542f, 0x2)   mov(eax, esi);                        /* mov eax, esi */
    II(0x10115431, 0x5)   calld(/* sys */ 0x10179414, 0x63fde); /* call 0x10179414 */
    II(0x10115436, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x10115439, 0x4)   cmp(memd_a32(ss, ebp - 0x4), 0);      /* cmp dword [ebp-0x4], 0x0 */
    II(0x1011543d, 0x2)   jnzd(0x10115447, 0x8);                /* jnz 0x10115447 */
    II(0x1011543f, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x10115442, 0x3)   cmp(eax, memd_a32(ss, ebp + 0x1c));   /* cmp eax, [ebp+0x1c] */
    II(0x10115445, 0x2)   jzd(0x10115450, 0x9);                 /* jz 0x10115450 */
l_0x10115447:
    II(0x10115447, 0x7)   mov(memd_a32(ss, ebp - 0xc), 0);      /* mov dword [ebp-0xc], 0x0 */
    II(0x1011544e, 0x2)   jmpd(0x10115457, 0x7);                /* jmp 0x10115457 */
l_0x10115450:
    II(0x10115450, 0x7)   mov(memd_a32(ss, ebp - 0xc), 0x1);    /* mov dword [ebp-0xc], 0x1 */
l_0x10115457:
    II(0x10115457, 0x3)   mov(eax, memd_a32(ss, ebp - 0xc));    /* mov eax, [ebp-0xc] */
    II(0x1011545a, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1011545c, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1011545d, 0x1)   popd(edi);                            /* pop edi */
    II(0x1011545e, 0x1)   popd(esi);                            /* pop esi */
    II(0x1011545f, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10115460, 0x1)   retd();                               /* ret */
FUNC_END

