FUNC_BEGIN(/* sys */ 0x1018dd5b, 0xce6ac402db0089ae, 0x20, ({0x55, 0x8b, 0xec, 0x33, 0xc0, 0xe6, 0xc, 0xeb, 0, 0x8b, 0x55, 0x8, 0xec, 0xeb, 0, 0x8a, 0xe0, 0xec, 0xeb, 0, 0x86, 0xc4, 0x40, 0x83, 0xfa, 0x7, 0x76, 0x2, 0xd1, 0xe0, 0xc9, 0xc3}))
    II(0x1018dd5b, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x1018dd5c, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x1018dd5e, 0x2)   xor_(eax, eax);                       /* xor eax, eax */
    II(0x1018dd60, 0x2)   outb(0xc, al);                        /* out 0xc, al */
    II(0x1018dd62, 0x2)   jmpd(0x1018dd64, 0);                  /* jmp 0x1018dd64 */
l_0x1018dd64:
    II(0x1018dd64, 0x3)   mov(edx, memd_a32(ss, ebp + 0x8));    /* mov edx, [ebp+0x8] */
    II(0x1018dd67, 0x1)   inb(al, dx);                          /* in al, dx */
    II(0x1018dd68, 0x2)   jmpd(0x1018dd6a, 0);                  /* jmp 0x1018dd6a */
l_0x1018dd6a:
    II(0x1018dd6a, 0x2)   mov(ah, al);                          /* mov ah, al */
    II(0x1018dd6c, 0x1)   inb(al, dx);                          /* in al, dx */
    II(0x1018dd6d, 0x2)   jmpd(0x1018dd6f, 0);                  /* jmp 0x1018dd6f */
l_0x1018dd6f:
    II(0x1018dd6f, 0x2)   xchg(ah, al);                         /* xchg ah, al */
    II(0x1018dd71, 0x1)   inc(eax);                             /* inc eax */
    II(0x1018dd72, 0x3)   cmp(edx, 0x7);                        /* cmp edx, 0x7 */
    II(0x1018dd75, 0x2)   jbed(0x1018dd79, 0x2);                /* jbe 0x1018dd79 */
    II(0x1018dd77, 0x2)   shl(eax, 0x1);                        /* shl eax, 1 */
l_0x1018dd79:
    II(0x1018dd79, 0x1)   leaved();                             /* leave */
    II(0x1018dd7a, 0x1)   retd();                               /* ret */
FUNC_END

