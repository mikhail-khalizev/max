FUNC_BEGIN(/* sys */ 0x10195c7c, 0xf701e62f95383aaa, 0x20, ({0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x83, 0xec, 0x4, 0x89, 0xc6, 0x8b, 0x38, 0x85, 0xff, 0x75, 0x8, 0x89, 0x3c, 0x24, 0xe9, 0x42, 0, 0, 0, 0x8b, 0x48, 0x4, 0x85, 0xc9, 0x76, 0x1, 0x49, 0x8d, 0x6f, 0xc}))
    II(0x10195c7c, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10195c7d, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10195c7e, 0x1)   pushd(edx);                           /* push edx */
    II(0x10195c7f, 0x1)   pushd(esi);                           /* push esi */
    II(0x10195c80, 0x1)   pushd(edi);                           /* push edi */
    II(0x10195c81, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10195c82, 0x3)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10195c85, 0x2)   mov(esi, eax);                        /* mov esi, eax */
    II(0x10195c87, 0x2)   mov(edi, memd_a32(ds, eax));          /* mov edi, [eax] */
    II(0x10195c89, 0x2)   test(edi, edi);                       /* test edi, edi */
    II(0x10195c8b, 0x2)   jnzd(0x10195c95, 0x8);                /* jnz 0x10195c95 */
    II(0x10195c8d, 0x3)   mov(memd_a32(ss, esp), edi);          /* mov [esp], edi */
    II(0x10195c90, 0x5)   jmpd_func(0x10195cd7, 0x42);          /* jmp 0x10195cd7 */
l_0x10195c95:
    II(0x10195c95, 0x3)   mov(ecx, memd_a32(ds, eax + 0x4));    /* mov ecx, [eax+0x4] */
    II(0x10195c98, 0x2)   test(ecx, ecx);                       /* test ecx, ecx */
    II(0x10195c9a, 0x2)   jbed(0x10195c9d, 0x1);                /* jbe 0x10195c9d */
    II(0x10195c9c, 0x1)   dec(ecx);                             /* dec ecx */
l_0x10195c9d:
    II(0x10195c9d, 0x3)   lea(ebp, edi + 0xc);                  /* lea ebp, [edi+0xc] */
    II(0x10195ca0, 0)     jmpd_func(/* sys */ 0x10195ca0, 0);   /* Принудительное завершение функции. */
FUNC_END

