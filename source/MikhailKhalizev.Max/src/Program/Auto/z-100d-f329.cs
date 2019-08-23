using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_f329-e6534de7")]
        public void Method_100d_f329()
        {
            ii(0x100d_f329, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100d_f32e, 5); calld(Definitions.sys_check_available_stack_size, 0x8_6a1f); /* call 0x10165d52 */
            ii(0x100d_f333, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_f334, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_f335, 1); pushd(esi);                             /* push esi */
            ii(0x100d_f336, 1); pushd(edi);                             /* push edi */
            ii(0x100d_f337, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_f338, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_f33a, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100d_f340, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_f343, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_f346, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x100d_f34a, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100d_f34d, 5); calld(0x100e_0608, 0x12b6);             /* call 0x100e0608 */
            ii(0x100d_f352, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_f355, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100d_f359, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_f35c, 5); add(eax, 0x2f0);                        /* add eax, 0x2f0 */
            ii(0x100d_f361, 5); calld(0x100e_0cf0, 0x198a);             /* call 0x100e0cf0 */
            ii(0x100d_f366, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_f368, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100d_f36b, 5); calld(0x100e_0548, 0x11d8);             /* call 0x100e0548 */
            ii(0x100d_f370, 2); jmpd(0x100d_f37a, 0x8); goto l_0x100d_f37a; /* jmp 0x100df37a */
        l_0x100d_f372:
            ii(0x100d_f372, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100d_f375, 5); calld(0x1007_6bf8, -0x6_8782);          /* call 0x10076bf8 */
        l_0x100d_f37a:
            ii(0x100d_f37a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_f37c, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100d_f37f, 5); calld(0x1013_ad71, 0x5_b9ed);           /* call 0x1013ad71 */
            ii(0x100d_f384, 2); test(al, al);                           /* test al, al */
            ii(0x100d_f386, 2); if(jzd(0x100d_f3b4, 0x2c)) goto l_0x100d_f3b4; /* jz 0x100df3b4 */
            ii(0x100d_f388, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100d_f38b, 5); calld(0x100e_047c, 0x10ec);             /* call 0x100e047c */
            ii(0x100d_f390, 5); calld(0x100e_0d64, 0x19cf);             /* call 0x100e0d64 */
            ii(0x100d_f395, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100d_f399, 2); if(jnzd(0x100d_f3b2, 0x17)) goto l_0x100d_f3b2; /* jnz 0x100df3b2 */
            ii(0x100d_f39b, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100d_f39e, 5); calld(0x100e_04e4, 0x1141);             /* call 0x100e04e4 */
            ii(0x100d_f3a3, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100d_f3a6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_f3a8, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100d_f3ab, 5); calld(0x100e_043c, 0x108c);             /* call 0x100e043c */
            ii(0x100d_f3b0, 2); jmpd(0x100d_f3d1, 0x1f); goto l_0x100d_f3d1; /* jmp 0x100df3d1 */
        l_0x100d_f3b2:
            ii(0x100d_f3b2, 2); jmpd(0x100d_f372, -0x42); goto l_0x100d_f372; /* jmp 0x100df372 */
        l_0x100d_f3b4:
            ii(0x100d_f3b4, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x100d_f3bb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_f3bd, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100d_f3c0, 5); calld(0x100e_043c, 0x1077);             /* call 0x100e043c */
            ii(0x100d_f3c5, 2); jmpd(0x100d_f3d1, 0xa); goto l_0x100d_f3d1; /* jmp 0x100df3d1 */
        //  ii(0x100d_f3c7, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100d_f3c9, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
        //  ii(0x100d_f3cc, 5); calld(0x100e_043c, 0x106b);             /* call 0x100e043c */
        l_0x100d_f3d1:
            ii(0x100d_f3d1, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100d_f3d4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_f3d6, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_f3d7, 1); popd(edi);                              /* pop edi */
            ii(0x100d_f3d8, 1); popd(esi);                              /* pop esi */
            ii(0x100d_f3d9, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_f3da, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_f3db, 1); retd();                                 /* ret */
        }
    }
}
