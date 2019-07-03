FUNC_BEGIN(/* sys */ 0x1017b850, 0x5d8c66829592763a, 0x20, ({0x55, 0x89, 0xe5, 0x8b, 0x45, 0x8, 0xa3, 0, 0xe2, 0x1b, 0x10, 0x89, 0xec, 0x5d, 0xc3}))
    II(0x1017b850, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1017b851, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1017b853, 0x3)   mov(eax, memd_a32(ss, ebp + 0x8));    /* mov eax, [ebp+0x8] */
    II(0x1017b856, 0x5)   mov(memd_a32(ds, 0x101be200), eax);   /* mov [0x101be200], eax */
//    II(0x1017b85b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1017b85d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1017b85e, 0x1)   retd();                               /* ret */
FUNC_END

