using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d6f330e8-0edc-4ba7-9084-7eb6f43a53b0")]
        public void Method_100a_5e7b()
        {
            ii(0x100a_5e7b, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_5e80, 5); calld(Definitions.sys_check_available_stack_size, 0xbfecd); /* call 0x10165d52 */
            ii(0x100a_5e85, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_5e86, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_5e87, 1); pushd(esi);                             /* push esi */
            ii(0x100a_5e88, 1); pushd(edi);                             /* push edi */
            ii(0x100a_5e89, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_5e8a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_5e8c, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_5e92, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_5e95, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_5e98, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_5e9b, 5); calld(0x1008_aef4, -0x1afac);           /* call 0x1008aef4 */
            ii(0x100a_5ea0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_5ea2, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5ea5, 5); calld(0x1008_ae70, -0x1b03a);           /* call 0x1008ae70 */
            ii(0x100a_5eaa, 2); jmpd(0x100a_5eb4, 0x8); goto l_0x100a_5eb4; /* jmp 0x100a5eb4 */
        l_0x100a_5eac:
            ii(0x100a_5eac, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5eaf, 5); calld(0x1007_6bf8, -0x2f2bc);           /* call 0x10076bf8 */
        l_0x100a_5eb4:
            ii(0x100a_5eb4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_5eb6, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5eb9, 5); calld(0x1013_ad71, 0x94eb3);            /* call 0x1013ad71 */
            ii(0x100a_5ebe, 2); test(al, al);                           /* test al, al */
            ii(0x100a_5ec0, 2); if(jzd(0x100a_5ede, 0x1c)) goto l_0x100a_5ede; /* jz 0x100a5ede */
            ii(0x100a_5ec2, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5ec5, 5); calld(0x1008_adc4, -0x1b106);           /* call 0x1008adc4 */
            ii(0x100a_5eca, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_5ecd, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_5ed0, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100a_5ed3, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_5ed6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_5ed9, 3); calld_abs(memd_a32[ds, ebx + 0x5c]);    /* call dword [ebx+0x5c] */
            ii(0x100a_5edc, 2); jmpd(0x100a_5eac, -0x32); goto l_0x100a_5eac; /* jmp 0x100a5eac */
        l_0x100a_5ede:
            ii(0x100a_5ede, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_5ee0, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_5ee3, 5); calld(0x1008_8bbc, -0x1d32c);           /* call 0x10088bbc */
            ii(0x100a_5ee8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_5eea, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_5eeb, 1); popd(edi);                              /* pop edi */
            ii(0x100a_5eec, 1); popd(esi);                              /* pop esi */
            ii(0x100a_5eed, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_5eee, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_5eef, 1); retd(); return;                         /* ret */
        }
    }
}
