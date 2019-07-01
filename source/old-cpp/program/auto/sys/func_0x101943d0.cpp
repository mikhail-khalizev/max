FUNC_BEGIN(/* sys */ 0x101943d0, 0x2e08c524d9686ede, 0x20, ({0x55, 0x89, 0xe5, 0x52, 0x89, 0xc2, 0x66, 0x31, 0xc2, 0xc1, 0xea, 0xc, 0x25, 0xff, 0xff, 0, 0, 0x1, 0xd0, 0x8d, 0x65, 0xfc, 0x5a, 0x5d, 0xc3}))
    II(0x101943d0, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101943d1, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101943d3, 0x1)   pushd(edx);                           /* push edx */
    II(0x101943d4, 0x2)   mov(edx, eax);                        /* mov edx, eax */
    II(0x101943d6, 0x3)   xor_(dx, ax);                         /* xor dx, ax */
    II(0x101943d9, 0x3)   shr(edx, 0xc);                        /* shr edx, 0xc */
    II(0x101943dc, 0x5)   and_(eax, 0xffff);                    /* and eax, 0xffff */
    II(0x101943e1, 0x2)   add(eax, edx);                        /* add eax, edx */
    II(0x101943e3, 0x3)   lea(esp, ebp - 0x4);                  /* lea esp, [ebp-0x4] */
    II(0x101943e6, 0x1)   popd(edx);                            /* pop edx */
    II(0x101943e7, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x101943e8, 0x1)   retd();                               /* ret */
FUNC_END

