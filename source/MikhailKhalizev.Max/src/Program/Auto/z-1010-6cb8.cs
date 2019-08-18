using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("370a1bec-5d03-43c7-99b5-feeaf66fd02d")]
        public void Method_1010_6cb8()
        {
            ii(0x1010_6cb8, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1010_6cbd, 5); calld(Definitions.sys_check_available_stack_size, 0x5_f090); /* call 0x10165d52 */
            ii(0x1010_6cc2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_6cc3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_6cc4, 1); pushd(edx);                             /* push edx */
            ii(0x1010_6cc5, 1); pushd(esi);                             /* push esi */
            ii(0x1010_6cc6, 1); pushd(edi);                             /* push edi */
            ii(0x1010_6cc7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_6cc8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_6cca, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1010_6cd0, 7); cmp(memb_a32[ds, 0x101c_3d70], 0);      /* cmp byte [0x101c3d70], 0x0 */
            ii(0x1010_6cd7, 2); if(jnzd(0x1010_6ce3, 0xa)) goto l_0x1010_6ce3; /* jnz 0x10106ce3 */
            ii(0x1010_6cd9, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1010_6cdc, 5); calld(/* sys */ 0x1017_9230, 0x7_254f); /* call 0x10179230 */
            ii(0x1010_6ce1, 2); jmpd(0x1010_6cf0, 0xd); goto l_0x1010_6cf0; /* jmp 0x10106cf0 */
        l_0x1010_6ce3:
            ii(0x1010_6ce3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_6ce5, 5); mov(al, memb_a32[ds, 0x101c_3d70]);     /* mov al, [0x101c3d70] */
            ii(0x1010_6cea, 3); sub(eax, 0x40);                         /* sub eax, 0x40 */
            ii(0x1010_6ced, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
        l_0x1010_6cf0:
            ii(0x1010_6cf0, 3); lea(edx, ebp - 0xc);                    /* lea edx, [ebp-0xc] */
            ii(0x1010_6cf3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_6cf6, 5); calld(/* sys */ 0x1017_9258, 0x7_255d); /* call 0x10179258 */
            ii(0x1010_6cfb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_6cfd, 6); if(jnzd(0x1010_6d8a, 0x87)) goto l_0x1010_6d8a; /* jnz 0x10106d8a */
            ii(0x1010_6d03, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_6d05, 4); mov(dx, memw_a32[ss, ebp - 0x6]);       /* mov dx, [ebp-0x6] */
            ii(0x1010_6d09, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_6d0b, 4); mov(ax, memw_a32[ss, ebp - 0x8]);       /* mov ax, [ebp-0x8] */
            ii(0x1010_6d0f, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1010_6d12, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_6d14, 4); mov(ax, memw_a32[ss, ebp - 0xa]);       /* mov ax, [ebp-0xa] */
            ii(0x1010_6d18, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1010_6d1b, 3); mov(memd_a32[ss, ebp - 0x10], edx);     /* mov [ebp-0x10], edx */
            ii(0x1010_6d1e, 7); cmp(memd_a32[ss, ebp - 0x10], 0x3_d090); /* cmp dword [ebp-0x10], 0x3d090 */
            ii(0x1010_6d25, 2); if(jaed(0x1010_6d88, 0x61)) goto l_0x1010_6d88; /* jae 0x10106d88 */
            ii(0x1010_6d27, 5); mov(eax, StringDefinitions.Control);    /* mov eax, 0x101a442e */
            ii(0x1010_6d2c, 1); pushd(eax);                             /* push eax */
            ii(0x1010_6d2d, 5); calld(Definitions.sys_printf, 0x6_590a); /* call 0x1016c63c */
            ii(0x1010_6d32, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1010_6d35, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_6d38, 1); pushd(eax);                             /* push eax */
            ii(0x1010_6d39, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_6d3c, 3); add(eax, 0x40);                         /* add eax, 0x40 */
            ii(0x1010_6d3f, 1); pushd(eax);                             /* push eax */
            ii(0x1010_6d40, 5); mov(eax, StringDefinitions.DriveCHasOnlyLuBytesAvailableYouMayHaveTroubleSavingGames); /* mov eax, 0x101a4431 */
            ii(0x1010_6d45, 1); pushd(eax);                             /* push eax */
            ii(0x1010_6d46, 5); calld(Definitions.sys_printf, 0x6_58f1); /* call 0x1016c63c */
            ii(0x1010_6d4b, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1010_6d4e, 5); mov(eax, StringDefinitions.PressEscToExitAnyOtherKeyToContinue); /* mov eax, 0x101a447e */
            ii(0x1010_6d53, 1); pushd(eax);                             /* push eax */
            ii(0x1010_6d54, 5); calld(Definitions.sys_printf, 0x6_58e3); /* call 0x1016c63c */
            ii(0x1010_6d59, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1010_6d5c, 5); mov(eax, StringDefinitions.Control2);   /* mov eax, 0x101a44af */
            ii(0x1010_6d61, 1); pushd(eax);                             /* push eax */
            ii(0x1010_6d62, 5); calld(Definitions.sys_printf, 0x6_58d5); /* call 0x1016c63c */
            ii(0x1010_6d67, 3); add(esp, 0x4);                          /* add esp, 0x4 */
        l_0x1010_6d6a:
            ii(0x1010_6d6a, 5); calld(/* sys */ 0x1017_9285, 0x7_2516); /* call 0x10179285 */
            ii(0x1010_6d6f, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1010_6d72, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1010_6d76, 2); if(jled(0x1010_6d6a, -0xe)) goto l_0x1010_6d6a; /* jle 0x10106d6a */
            ii(0x1010_6d78, 4); cmp(memd_a32[ss, ebp - 0x14], 0x1b);    /* cmp dword [ebp-0x14], 0x1b */
            ii(0x1010_6d7c, 2); if(jnzd(0x1010_6d88, 0xa)) goto l_0x1010_6d88; /* jnz 0x10106d88 */
            ii(0x1010_6d7e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_6d83, 5); calld(Definitions.sys_exit, 0x6_58d7);  /* call 0x1016c65f */
        l_0x1010_6d88:
            ii(0x1010_6d88, 2); jmpd(0x1010_6da9, 0x1f); goto l_0x1010_6da9; /* jmp 0x10106da9 */
        l_0x1010_6d8a:
            ii(0x1010_6d8a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_6d8d, 3); add(eax, 0x40);                         /* add eax, 0x40 */
            ii(0x1010_6d90, 1); pushd(eax);                             /* push eax */
            ii(0x1010_6d91, 5); mov(eax, StringDefinitions.ErrorCheckingDriveCRunScandisk); /* mov eax, 0x101a44b2 */
            ii(0x1010_6d96, 1); pushd(eax);                             /* push eax */
            ii(0x1010_6d97, 5); calld(Definitions.sys_printf, 0x6_58a0); /* call 0x1016c63c */
            ii(0x1010_6d9c, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1010_6d9f, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_6da4, 5); calld(Definitions.sys_exit, 0x6_58b6);  /* call 0x1016c65f */
        l_0x1010_6da9:
            ii(0x1010_6da9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_6dab, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_6dac, 1); popd(edi);                              /* pop edi */
            ii(0x1010_6dad, 1); popd(esi);                              /* pop esi */
            ii(0x1010_6dae, 1); popd(edx);                              /* pop edx */
            ii(0x1010_6daf, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_6db0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_6db1, 1); retd(); return;                         /* ret */
        }
    }
}
