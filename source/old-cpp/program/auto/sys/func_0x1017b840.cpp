FUNC_BEGIN(/* sys */ 0x1017b840, 0x5e3ea1461c6d604e, 0x20, ({0x55, 0x89, 0xe5, 0x8b, 0x45, 0x8, 0xa3, 0x8c, 0x9c, 0x20, 0x10, 0x89, 0xec, 0x5d, 0xc3}))
    II(0x1017b840, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1017b841, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1017b843, 0x3)   mov(eax, memd_a32(ss, ebp + 0x8));    /* mov eax, [ebp+0x8] */
    II(0x1017b846, 0x5)   mov(memd_a32(ds, 0x10209c8c), eax);   /* mov [0x10209c8c], eax */
//    II(0x1017b84b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1017b84d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1017b84e, 0x1)   retd();                               /* ret */
FUNC_END

