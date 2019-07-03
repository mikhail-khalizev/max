FUNC_BEGIN(/* sys */ 0x101798a0, 0x5de1611c1baed4f6, 0x20, ({0x55, 0x89, 0xe5, 0x8b, 0x45, 0x8, 0xa3, 0xb8, 0x9d, 0x20, 0x10, 0x89, 0xec, 0x5d, 0xc3}))
    II(0x101798a0, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101798a1, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101798a3, 0x3)   mov(eax, memd_a32(ss, ebp + 0x8));    /* mov eax, [ebp+0x8] */
    II(0x101798a6, 0x5)   mov(memd_a32(ds, 0x10209db8), eax);   /* mov [0x10209db8], eax */
//    II(0x101798ab, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x101798ad, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101798ae, 0x1)   retd();                               /* ret */
FUNC_END

