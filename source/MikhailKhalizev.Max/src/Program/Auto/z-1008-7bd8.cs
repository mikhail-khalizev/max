using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_7bd8-1257d7c1")]
        public void Method_1008_7bd8()
        {
            ii(0x1008_7bd8, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1008_7bdd, 5); calld(Definitions.sys_check_available_stack_size, 0xd_e170); /* call 0x10165d52 */
            ii(0x1008_7be2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_7be3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_7be4, 1); pushd(esi);                             /* push esi */
            ii(0x1008_7be5, 1); pushd(edi);                             /* push edi */
            ii(0x1008_7be6, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_7be7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_7be9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_7bef, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_7bf2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_7bf5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_7bf7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_7bfa, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_7bfd, 5); calld(0x1013_ad11, 0xb_310f);           /* call 0x1013ad11 */
            ii(0x1008_7c02, 2); test(al, al);                           /* test al, al */
            ii(0x1008_7c04, 2); if(jzd(0x1008_7c15, 0xf)) goto l_0x1008_7c15; /* jz 0x10087c15 */
            ii(0x1008_7c06, 5); mov(edx, StringDefinitions.CompletedEscortTask); /* mov edx, 0x101a02e7 */
            ii(0x1008_7c0b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_7c0e, 5); calld(Definitions.sys_strcpy, 0xd_e2bc); /* call 0x10165ecf */
            ii(0x1008_7c13, 2); jmpd(0x1008_7c67, 0x52); goto l_0x1008_7c67; /* jmp 0x10087c67 */
        l_0x1008_7c15:
            ii(0x1008_7c15, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_7c18, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_7c1b, 5); calld(0x1007_6574, -0x1_16ac);          /* call 0x10076574 */
            ii(0x1008_7c20, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1008_7c23, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_7c26, 1); inc(eax);                               /* inc eax */
            ii(0x1008_7c27, 1); pushd(eax);                             /* push eax */
            ii(0x1008_7c28, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_7c2b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_7c2e, 5); calld(0x1007_6574, -0x1_16bf);          /* call 0x10076574 */
            ii(0x1008_7c33, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1008_7c36, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_7c39, 1); inc(eax);                               /* inc eax */
            ii(0x1008_7c3a, 1); pushd(eax);                             /* push eax */
            ii(0x1008_7c3b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_7c3e, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_7c41, 5); calld(0x1007_6574, -0x1_16d2);          /* call 0x10076574 */
            ii(0x1008_7c46, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1008_7c49, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_7c4c, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1008_7c4f, 6); pushd(memd_a32[ds, eax + 0x101c_81d7]); /* push dword [eax+0x101c81d7] */
            ii(0x1008_7c55, 5); mov(eax, StringDefinitions.EscortSAtII); /* mov eax, 0x101a02fd */
            ii(0x1008_7c5a, 1); pushd(eax);                             /* push eax */
            ii(0x1008_7c5b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_7c5e, 1); pushd(eax);                             /* push eax */
            ii(0x1008_7c5f, 5); calld(Definitions.sys_sprintf, 0xd_e29d); /* call 0x10165f01 */
            ii(0x1008_7c64, 3); add(esp, 0x14);                         /* add esp, 0x14 */
        l_0x1008_7c67:
            ii(0x1008_7c67, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_7c6a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_7c6d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_7c70, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_7c72, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_7c73, 1); popd(edi);                              /* pop edi */
            ii(0x1008_7c74, 1); popd(esi);                              /* pop esi */
            ii(0x1008_7c75, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_7c76, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_7c77, 1); retd(); return;                         /* ret */
        }
    }
}
