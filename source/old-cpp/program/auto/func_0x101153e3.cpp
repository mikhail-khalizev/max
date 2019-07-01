FUNC_BEGIN(0x101153e3, 0xba4f155cfeefafd7, 0x20, ({0x68, 0x14, 0, 0, 0, 0xe8, 0x65, 0x9, 0x5, 0, 0x53, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0, 0, 0, 0, 0x8b, 0x45, 0x14, 0xe8, 0xc0, 0x5c, 0x5, 0, 0x5d, 0x5f, 0x5e, 0x5b, 0xc3}))
    II(0x101153e3, 0x5)   pushd(0x14);                          /* push dword 0x14 */
    II(0x101153e8, 0x5)   calld(sys_check_available_stack_size, 0x50965); /* call 0x10165d52 */
    II(0x101153ed, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x101153ee, 0x1)   pushd(esi);                           /* push esi */
    II(0x101153ef, 0x1)   pushd(edi);                           /* push edi */
    II(0x101153f0, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x101153f1, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x101153f3, 0x6)   sub(esp, 0);                          /* sub esp, 0x0 */
    II(0x101153f9, 0x3)   mov(eax, memd_a32(ss, ebp + 0x14));   /* mov eax, [ebp+0x14] */
    II(0x101153fc, 0x5)   calld(sys_free, 0x55cc0);             /* call 0x1016b0c1 */
    II(0x10115401, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10115402, 0x1)   popd(edi);                            /* pop edi */
    II(0x10115403, 0x1)   popd(esi);                            /* pop esi */
    II(0x10115404, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10115405, 0x1)   retd();                               /* ret */
FUNC_END

