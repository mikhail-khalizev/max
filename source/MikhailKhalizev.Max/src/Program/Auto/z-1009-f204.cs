using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b807c95e-caed-4b87-ba7a-e25d8199ac91")]
        public void Method_1009_f204()
        {
            ii(0x1009_f204, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1009_f209, 5); calld(Definitions.sys_check_available_stack_size, 0xc_6b44); /* call 0x10165d52 */
            ii(0x1009_f20e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_f20f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_f210, 1); pushd(edx);                             /* push edx */
            ii(0x1009_f211, 1); pushd(esi);                             /* push esi */
            ii(0x1009_f212, 1); pushd(edi);                             /* push edi */
            ii(0x1009_f213, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_f214, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_f216, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1009_f21c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_f21f, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x1009_f224, 5); calld(Definitions.sys_new, 0xc_6bd7);   /* call 0x10165e00 */
            ii(0x1009_f229, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_f22c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_f22f, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_f232, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1009_f236, 2); if(jzd(0x1009_f254, 0x1c)) goto l_0x1009_f254; /* jz 0x1009f254 */
            ii(0x1009_f238, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1009_f23b, 3); add(ebx, 0x13);                         /* add ebx, 0x13 */
            ii(0x1009_f23e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_f241, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_f244, 5); calld(Definitions.my_ctor_c12, 0x6e23); /* call 0x100a606c */
            ii(0x1009_f249, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_f24c, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_f24f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_f252, 2); jmpd(0x1009_f25a, 0x6); goto l_0x1009_f25a; /* jmp 0x1009f25a */
        l_0x1009_f254:
            ii(0x1009_f254, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_f257, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1009_f25a:
            ii(0x1009_f25a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_f25d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_f260, 5); calld(0x1008_a914, -0x1_4951);          /* call 0x1008a914 */
            ii(0x1009_f265, 5); mov(edx, 0x39);                         /* mov edx, 0x39 */
            ii(0x1009_f26a, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_f26d, 5); calld(0x1008_a7dc, -0x1_4a96);          /* call 0x1008a7dc */
            ii(0x1009_f272, 5); calld(0x100a_63bc, 0x7145);             /* call 0x100a63bc */
            ii(0x1009_f277, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_f27a, 5); calld(0x1008_a838, -0x1_4a47);          /* call 0x1008a838 */
            ii(0x1009_f27f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_f281, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_f286, 5); calld(0x100a_4d50, 0x5ac5);             /* call 0x100a4d50 */
            ii(0x1009_f28b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_f28d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_f290, 5); calld(0x1008_8cbc, -0x1_65d9);          /* call 0x10088cbc */
            ii(0x1009_f295, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_f297, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_f298, 1); popd(edi);                              /* pop edi */
            ii(0x1009_f299, 1); popd(esi);                              /* pop esi */
            ii(0x1009_f29a, 1); popd(edx);                              /* pop edx */
            ii(0x1009_f29b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_f29c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_f29d, 1); retd(); return;                         /* ret */
        }
    }
}
