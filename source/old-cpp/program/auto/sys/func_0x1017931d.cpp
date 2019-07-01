FUNC_BEGIN(/* sys */ 0x1017931d, 0x2eb8f52f9b997a1d, 0x20, ({0x53, 0x51, 0x52, 0x89, 0xc1, 0x89, 0xc2, 0x8a, 0x2, 0x84, 0xc0, 0x74, 0x12, 0x2c, 0x41, 0x31, 0xdb, 0x88, 0xc3, 0x83, 0xfb, 0x19, 0x7f, 0x4, 0x4, 0x61, 0x88, 0x2, 0x42, 0xeb, 0xe8, 0x89, 0xc8, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x1017931d, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1017931e, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1017931f, 0x1)   pushd(edx);                           /* push edx */
    II(0x10179320, 0x2)   mov(ecx, eax);                        /* mov ecx, eax */
    II(0x10179322, 0x2)   mov(edx, eax);                        /* mov edx, eax */
l_0x10179324:
    II(0x10179324, 0x2)   mov(al, memb_a32(ds, edx));           /* mov al, [edx] */
    II(0x10179326, 0x2)   test(al, al);                         /* test al, al */
    II(0x10179328, 0x2)   jzd(0x1017933c, 0x12);                /* jz 0x1017933c */
    II(0x1017932a, 0x2)   sub(al, 0x41);                        /* sub al, 0x41 */
    II(0x1017932c, 0x2)   xor_(ebx, ebx);                       /* xor ebx, ebx */
    II(0x1017932e, 0x2)   mov(bl, al);                          /* mov bl, al */
    II(0x10179330, 0x3)   cmp(ebx, 0x19);                       /* cmp ebx, 0x19 */
    II(0x10179333, 0x2)   jgd(0x10179339, 0x4);                 /* jg 0x10179339 */
    II(0x10179335, 0x2)   add(al, 0x61);                        /* add al, 0x61 */
    II(0x10179337, 0x2)   mov(memb_a32(ds, edx), al);           /* mov [edx], al */
l_0x10179339:
    II(0x10179339, 0x1)   inc(edx);                             /* inc edx */
    II(0x1017933a, 0x2)   jmpd(0x10179324, -0x18);              /* jmp 0x10179324 */
l_0x1017933c:
    II(0x1017933c, 0x2)   mov(eax, ecx);                        /* mov eax, ecx */
    II(0x1017933e, 0x1)   popd(edx);                            /* pop edx */
    II(0x1017933f, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10179340, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10179341, 0x1)   retd();                               /* ret */
FUNC_END

