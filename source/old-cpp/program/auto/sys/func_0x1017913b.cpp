FUNC_BEGIN(/* sys */ 0x1017913b, 0xc5fd5d9501bf2fdf, 0x20, ({0x53, 0x52, 0x83, 0xec, 0x4, 0x8d, 0x44, 0x24, 0x18, 0x89, 0xe3, 0x8b, 0x54, 0x24, 0x14, 0x89, 0x4, 0x24, 0x8b, 0x44, 0x24, 0x10, 0xe8, 0x4d, 0xec, 0, 0, 0x83, 0xc4, 0x4, 0x5a, 0x5b, 0xc3}))
    II(0x1017913b, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1017913c, 0x1)   pushd(edx);                           /* push edx */
    II(0x1017913d, 0x3)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x10179140, 0x4)   lea(eax, esp + 0x18);                 /* lea eax, [esp+0x18] */
    II(0x10179144, 0x2)   mov(ebx, esp);                        /* mov ebx, esp */
    II(0x10179146, 0x4)   mov(edx, memd_a32(ss, esp + 0x14));   /* mov edx, [esp+0x14] */
    II(0x1017914a, 0x3)   mov(memd_a32(ss, esp), eax);          /* mov [esp], eax */
    II(0x1017914d, 0x4)   mov(eax, memd_a32(ss, esp + 0x10));   /* mov eax, [esp+0x10] */
    II(0x10179151, 0x5)   calld(/* sys */ 0x10187da3, 0xec4d);  /* call 0x10187da3 */
    II(0x10179156, 0x3)   add(esp, 0x4);                        /* add esp, 0x4 */
    II(0x10179159, 0x1)   popd(edx);                            /* pop edx */
    II(0x1017915a, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x1017915b, 0x1)   retd();                               /* ret */
FUNC_END

