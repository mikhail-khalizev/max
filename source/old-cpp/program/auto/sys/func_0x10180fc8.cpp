FUNC_BEGIN(/* sys */ 0x10180fc8, 0xe45b76a49bfd67de, 0x20, ({0x53, 0x89, 0xc3, 0x88, 0xd0, 0x89, 0xda, 0xee, 0x5b, 0xc3}))
    II(0x10180fc8, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10180fc9, 0x2)   mov(ebx, eax);                        /* mov ebx, eax */
    II(0x10180fcb, 0x2)   mov(al, dl);                          /* mov al, dl */
    II(0x10180fcd, 0x2)   mov(edx, ebx);                        /* mov edx, ebx */
    II(0x10180fcf, 0x1)   outb(dx, al);                         /* out dx, al */
    II(0x10180fd0, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10180fd1, 0x1)   retd();                               /* ret */
FUNC_END

