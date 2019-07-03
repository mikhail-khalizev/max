FUNC_BEGIN(my_string_add_ref, 0xd2817fb46f1ca580, 0x20, ({0x68, 0x20, 0, 0, 0, 0xe8, 0xe4, 0x38, 0x2, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x4, 0, 0, 0, 0x89, 0x45, 0xfc, 0x83, 0x7d, 0xfc, 0, 0x74, 0x6, 0x8b, 0x45, 0xfc, 0xff, 0x40, 0x8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10142464, 0x5)   pushd(0x20);                          /* push dword 0x20 */
    II(0x10142469, 0x5)   calld(sys_check_available_stack_size, 0x238e4); /* call 0x10165d52 */
    II(0x1014246e, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x1014246f, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10142470, 0x1)   pushd(edx);                           /* push edx */
    II(0x10142471, 0x1)   pushd(esi);                           /* push esi */
    II(0x10142472, 0x1)   pushd(edi);                           /* push edi */
    II(0x10142473, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10142474, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10142476, 0x6)   sub(esp, 0x4);                        /* sub esp, 0x4 */
    II(0x1014247c, 0x3)   mov(memd_a32(ss, ebp - 0x4), eax);    /* mov [ebp-0x4], eax */
    II(0x1014247f, 0x4)   cmp(memd_a32(ss, ebp - 0x4), 0);      /* cmp dword [ebp-0x4], 0x0 */
    II(0x10142483, 0x2)   jzd(0x1014248b, 0x6);                 /* jz 0x1014248b */
    II(0x10142485, 0x3)   mov(eax, memd_a32(ss, ebp - 0x4));    /* mov eax, [ebp-0x4] */
    II(0x10142488, 0x3)   inc(memd_a32(ds, eax + 0x8));         /* inc dword [eax+0x8] */
l_0x1014248b:
    II(0x1014248b, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x1014248d, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x1014248e, 0x1)   popd(edi);                            /* pop edi */
    II(0x1014248f, 0x1)   popd(esi);                            /* pop esi */
    II(0x10142490, 0x1)   popd(edx);                            /* pop edx */
    II(0x10142491, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10142492, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10142493, 0x1)   retd();                               /* ret */
FUNC_END

