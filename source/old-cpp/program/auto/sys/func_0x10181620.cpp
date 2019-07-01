FUNC_BEGIN(/* sys */ 0x10181620, 0xed3d9b0f614d5c29, 0x20, ({0x51, 0x56, 0x57, 0x6, 0x89, 0xd1, 0x89, 0xdf, 0x89, 0xc2, 0x8e, 0xc1, 0x31, 0xc0, 0x89, 0xd6, 0x26, 0x8a, 0x1e, 0x42, 0x84, 0xdb, 0x74, 0x7, 0x39, 0xf8, 0x74, 0x3, 0x40, 0xeb, 0xef}))
    II(0x10181620, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10181621, 0x1)   pushd(esi);                           /* push esi */
    II(0x10181622, 0x1)   pushd(edi);                           /* push edi */
    II(0x10181623, 0x1)   pushd(es);                            /* push es */
    II(0x10181624, 0x2)   mov(ecx, edx);                        /* mov ecx, edx */
    II(0x10181626, 0x2)   mov(edi, ebx);                        /* mov edi, ebx */
    II(0x10181628, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x1018162a, 0x2)   mov(es, ecx);                         /* mov es, ecx */
    II(0x1018162c, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
l_0x1018162e:
    II(0x1018162e, 0x2)   mov(esi, edx);                        /* mov esi, edx */
    II(0x10181630, 0x3)   mov(bl, memb_a32(es, esi));           /* mov bl, [es:esi] */
    II(0x10181633, 0x1)   inc(edx);                             /* inc edx */
    II(0x10181634, 0x2)   test(bl, bl);                         /* test bl, bl */
    II(0x10181636, 0x2)   jzd_func(0x1018163f, 0x7);            /* jz 0x1018163f */
    II(0x10181638, 0x2)   cmp(eax, edi);                        /* cmp eax, edi */
    II(0x1018163a, 0x2)   jzd_func(0x1018163f, 0x3);            /* jz 0x1018163f */
    II(0x1018163c, 0x1)   inc(eax);                             /* inc eax */
    II(0x1018163d, 0x2)   jmpd(0x1018162e, -0x11);              /* jmp 0x1018162e */
FUNC_END

