FUNC_BEGIN(0x10121216, 0xb83622b3631430f2, 0x20, ({0x68, 0x24, 0, 0, 0, 0xe8, 0x32, 0x4b, 0x4, 0, 0x53, 0x51, 0x52, 0x56, 0x57, 0x55, 0x89, 0xe5, 0x81, 0xec, 0x8, 0, 0, 0, 0x88, 0x45, 0xfc, 0xf, 0xbe, 0x45, 0xfc, 0x8a, 0x80, 0x20, 0xb0, 0x1b, 0x10, 0x88, 0x45, 0xf8, 0x8a, 0x45, 0xf8, 0x89, 0xec, 0x5d, 0x5f, 0x5e, 0x5a, 0x59, 0x5b, 0xc3}))
    II(0x10121216, 0x5)   pushd(0x24);                          /* push dword 0x24 */
    II(0x1012121b, 0x5)   calld(sys_check_available_stack_size, 0x44b32); /* call 0x10165d52 */
    II(0x10121220, 0x1)   pushd(ebx);                           /* push ebx */
    II(0x10121221, 0x1)   pushd(ecx);                           /* push ecx */
    II(0x10121222, 0x1)   pushd(edx);                           /* push edx */
    II(0x10121223, 0x1)   pushd(esi);                           /* push esi */
    II(0x10121224, 0x1)   pushd(edi);                           /* push edi */
    II(0x10121225, 0x1)   pushd(ebp);                           /* push ebp */
    II(0x10121226, 0x2)   mov(ebp, esp);                        /* mov ebp, esp */
    II(0x10121228, 0x6)   sub(esp, 0x8);                        /* sub esp, 0x8 */
    II(0x1012122e, 0x3)   mov(memb_a32(ss, ebp - 0x4), al);     /* mov [ebp-0x4], al */
    II(0x10121231, 0x4)   movsx(eax, memb_a32(ss, ebp - 0x4));  /* movsx eax, byte [ebp-0x4] */
    II(0x10121235, 0x6)   mov(al, memb_a32(ds, eax + 0x101bb020)); /* mov al, [eax+0x101bb020] */
    II(0x1012123b, 0x3)   mov(memb_a32(ss, ebp - 0x8), al);     /* mov [ebp-0x8], al */
//    II(0x1012123e, 0x3)   mov(al, memb_a32(ss, ebp - 0x8));     /* mov al, [ebp-0x8] */
    II(0x10121241, 0x2)   mov(esp, ebp);                        /* mov esp, ebp */
    II(0x10121243, 0x1)   popd(ebp);                            /* pop ebp */
    II(0x10121244, 0x1)   popd(edi);                            /* pop edi */
    II(0x10121245, 0x1)   popd(esi);                            /* pop esi */
    II(0x10121246, 0x1)   popd(edx);                            /* pop edx */
    II(0x10121247, 0x1)   popd(ecx);                            /* pop ecx */
    II(0x10121248, 0x1)   popd(ebx);                            /* pop ebx */
    II(0x10121249, 0x1)   retd();                               /* ret */
FUNC_END

