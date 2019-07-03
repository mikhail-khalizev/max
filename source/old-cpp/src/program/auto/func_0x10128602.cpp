FUNC_BEGIN(0x10128602, 0xcb8bc23c20b55399, 0x20, ({0x68, 0x1c, 0, 0, 0, 0xe8, 0x46, 0xd7, 0x3, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0, 0, 0, 0, 0xe8, 0xce, 0xef, 0xff, 0xff, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10128602, 0x5)   pushd(0x1c);                          /* push dword 0x1c */
    II(0x10128607, 0x5)   calld(sys_check_available_stack_size, 0x3d746); /* call 0x10165d52 */
    II(0x1012860c, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1012860d, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x1012860e, 0x1)   pushd(edx);                           /* push edx */
    II(0x1012860f, 0x1)   pushd(esi);                           /* push esi */
    II(0x10128610, 0x1)   pushd(edi);                           /* push edi */
    II(0x10128611, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10128612, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10128614, 0x6)   sub(esp, 0);                          /* sub esp, 0x0 */
    II(0x1012861a, 0x5)   calld(0x101275ed, -0x1032);           /* call 0x101275ed */
    II(0x1012861f, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10128620, 0x1)   popd(edi);                            /* pop edi */
    II(0x10128621, 0x1)   popd(esi);                            /* pop esi */
    II(0x10128622, 0x1)   popd(edx);                            /* pop edx */
    II(0x10128623, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10128624, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10128625, 0x1)   retd();                               /* ret */
FUNC_END

