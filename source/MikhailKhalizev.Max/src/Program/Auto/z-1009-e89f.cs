using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_e89f-d094d560")]
        public void Method_1009_e89f()
        {
            ii(0x1009_e89f, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1009_e8a4, 5); calld(Definitions.sys_check_available_stack_size, 0xc_74a9); /* call 0x10165d52 */
            ii(0x1009_e8a9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_e8aa, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_e8ab, 1); pushd(edx);                             /* push edx */
            ii(0x1009_e8ac, 1); pushd(esi);                             /* push esi */
            ii(0x1009_e8ad, 1); pushd(edi);                             /* push edi */
            ii(0x1009_e8ae, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_e8af, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_e8b1, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1009_e8b7, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_e8ba, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x1009_e8bf, 5); calld(Definitions.sys_new, 0xc_753c);   /* call 0x10165e00 */
            ii(0x1009_e8c4, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_e8c7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_e8ca, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_e8cd, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1009_e8d1, 2); if(jzd(0x1009_e8ef, 0x1c)) goto l_0x1009_e8ef; /* jz 0x1009e8ef */
            ii(0x1009_e8d3, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1009_e8d6, 3); add(ebx, 0x13);                         /* add ebx, 0x13 */
            ii(0x1009_e8d9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_e8dc, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_e8df, 5); calld(Definitions.my_ctor_c12, 0x7788); /* call 0x100a606c */
            ii(0x1009_e8e4, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_e8e7, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_e8ea, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_e8ed, 2); jmpd(0x1009_e8f5, 0x6); goto l_0x1009_e8f5; /* jmp 0x1009e8f5 */
        l_0x1009_e8ef:
            ii(0x1009_e8ef, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_e8f2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1009_e8f5:
            ii(0x1009_e8f5, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_e8f8, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_e8fb, 5); calld(0x1008_a914, -0x1_3fec);          /* call 0x1008a914 */
            ii(0x1009_e900, 5); mov(edx, 0x39);                         /* mov edx, 0x39 */
            ii(0x1009_e905, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_e908, 5); calld(0x1008_a7dc, -0x1_4131);          /* call 0x1008a7dc */
            ii(0x1009_e90d, 5); calld(0x100a_63bc, 0x7aaa);             /* call 0x100a63bc */
            ii(0x1009_e912, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_e915, 5); calld(0x1008_a838, -0x1_40e2);          /* call 0x1008a838 */
            ii(0x1009_e91a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_e91c, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_e921, 5); calld(0x100a_4d50, 0x642a);             /* call 0x100a4d50 */
            ii(0x1009_e926, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_e928, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_e92b, 5); calld(0x1008_8cbc, -0x1_5c74);          /* call 0x10088cbc */
            ii(0x1009_e930, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_e932, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_e933, 1); popd(edi);                              /* pop edi */
            ii(0x1009_e934, 1); popd(esi);                              /* pop esi */
            ii(0x1009_e935, 1); popd(edx);                              /* pop edx */
            ii(0x1009_e936, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_e937, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_e938, 1); retd();                                 /* ret */
        }
    }
}
