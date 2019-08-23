using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_1e5f-fb232f3c")]
        public void Method_100e_1e5f()
        {
            ii(0x100e_1e5f, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_1e64, 5); calld(Definitions.sys_check_available_stack_size, 0x8_3ee9); /* call 0x10165d52 */
            ii(0x100e_1e69, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_1e6a, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_1e6b, 1); pushd(esi);                             /* push esi */
            ii(0x100e_1e6c, 1); pushd(edi);                             /* push edi */
            ii(0x100e_1e6d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_1e6e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_1e70, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_1e76, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_1e79, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_1e7c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_1e7f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_1e82, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_1e84, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_1e87, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_1e8a, 5); calld(0x1013_ad11, 0x5_8e82);           /* call 0x1013ad11 */
            ii(0x100e_1e8f, 2); test(al, al);                           /* test al, al */
            ii(0x100e_1e91, 2); if(jnzd(0x100e_1eae, 0x1b)) goto l_0x100e_1eae; /* jnz 0x100e1eae */
            ii(0x100e_1e93, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_1e96, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_1e99, 5); calld(0x1007_65d0, -0x6_b8ce);          /* call 0x100765d0 */
            ii(0x100e_1e9e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_1ea0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_1ea3, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100e_1ea5, 5); calld(0x100e_3020, 0x1176);             /* call 0x100e3020 */
            ii(0x100e_1eaa, 2); test(al, al);                           /* test al, al */
            ii(0x100e_1eac, 2); if(jnzd(0x100e_1eb0, 0x2)) goto l_0x100e_1eb0; /* jnz 0x100e1eb0 */
        l_0x100e_1eae:
            ii(0x100e_1eae, 2); jmpd(0x100e_1efa, 0x4a); goto l_0x100e_1efa; /* jmp 0x100e1efa */
        l_0x100e_1eb0:
            ii(0x100e_1eb0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_1eb3, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_1eb6, 5); calld(0x1007_65d0, -0x6_b8eb);          /* call 0x100765d0 */
            ii(0x100e_1ebb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_1ebd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_1ec0, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100e_1ec2, 5); calld(0x100e_33cc, 0x1505);             /* call 0x100e33cc */
            ii(0x100e_1ec7, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100e_1ecc, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_1ecf, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100e_1ed1, 5); calld(0x100e_3e05, 0x1f2f);             /* call 0x100e3e05 */
            ii(0x100e_1ed6, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100e_1edb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_1ede, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_1ee1, 5); calld(0x1007_65d0, -0x6_b916);          /* call 0x100765d0 */
            ii(0x100e_1ee6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_1ee8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_1eeb, 5); calld(0x100e_15b6, -0x93a);             /* call 0x100e15b6 */
            ii(0x100e_1ef0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_1ef3, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100e_1ef5, 5); calld(0x100e_3fc4, 0x20ca);             /* call 0x100e3fc4 */
        l_0x100e_1efa:
            ii(0x100e_1efa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_1efc, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_1efd, 1); popd(edi);                              /* pop edi */
            ii(0x100e_1efe, 1); popd(esi);                              /* pop esi */
            ii(0x100e_1eff, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_1f00, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_1f01, 1); retd();                                 /* ret */
        }
    }
}
