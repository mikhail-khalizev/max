FUNC_BEGIN(0x100cdec2, 0x721eb7830050d30c, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x86, 0x7e, 0x9, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x89, 0x45, 0xfc, 0xf, 0xbf, 0x45, 0xfc, 0xe8, 0x51, 0xff, 0xff, 0xff, 0x25, 0xff, 0, 0, 0, 0x89, 0x45, 0xf8, 0x8b, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x100cdec2, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x100cdec7, 0x5)   calld(sys_check_available_stack_size, 0x97e86); /* call 0x10165d52 */
    II(0x100cdecc, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x100cdecd, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x100cdece, 0x1)   pushd(edx);                           /* push edx */
    II(0x100cdecf, 0x1)   pushd(esi);                           /* push esi */
    II(0x100cded0, 0x1)   pushd(edi);                           /* push edi */
    II(0x100cded1, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x100cded2, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x100cded4, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x100cdeda, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x100cdedd, 0x4)   movsx(eax, memw_a32(ss, ebp - 0x4));  /* movsx eax, word [ebp-0x4] */
    II(0x100cdee1, 0x5)   calld(0x100cde37, -0xaf);             /* call 0x100cde37 */
    II(0x100cdee6, 0x5)   and_(eax, 0xff);                      /* and eax, 0xff */
    II(0x100cdeeb, 0x3)   mov(memd_a32(ss, ebp - 0x8), eax);    /* mov [ebp-0x8], eax */
//    II(0x100cdeee, 0x3)   mov(eax, memd_a32(ss, ebp - 0x8));    /* mov eax, [ebp-0x8] */
    II(0x100cdef1, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x100cdef3, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x100cdef4, 0x1)   popd(edi);                            /* pop edi */
    II(0x100cdef5, 0x1)   popd(esi);                            /* pop esi */
    II(0x100cdef6, 0x1)   popd(edx);                            /* pop edx */
    II(0x100cdef7, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x100cdef8, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x100cdef9, 0x1)   retd();                               /* ret */
FUNC_END

