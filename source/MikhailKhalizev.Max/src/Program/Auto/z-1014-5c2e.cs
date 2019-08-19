using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_5c2e-be03edff")]
        public void Method_1014_5c2e()
        {
            ii(0x1014_5c2e, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1014_5c33, 5); calld(Definitions.sys_check_available_stack_size, 0x2_011a); /* call 0x10165d52 */
            ii(0x1014_5c38, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_5c39, 1); pushd(esi);                             /* push esi */
            ii(0x1014_5c3a, 1); pushd(edi);                             /* push edi */
            ii(0x1014_5c3b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_5c3c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_5c3e, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1014_5c44, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_5c47, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1014_5c4a, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1014_5c4d, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_5c50, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x1014_5c53, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_5c56, 5); calld(0x1014_630a, 0x6af);              /* call 0x1014630a */
            ii(0x1014_5c5b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_5c5d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_5c60, 5); calld(0x1013_ad11, -0xaf54);            /* call 0x1013ad11 */
            ii(0x1014_5c65, 2); test(al, al);                           /* test al, al */
            ii(0x1014_5c67, 2); if(jzd(0x1014_5c79, 0x10)) goto l_0x1014_5c79; /* jz 0x10145c79 */
            ii(0x1014_5c69, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x1014_5c6d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_5c6f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_5c72, 5); calld(0x100e_03bc, -0x6_58bb);          /* call 0x100e03bc */
            ii(0x1014_5c77, 2); jmpd(0x1014_5cb2, 0x39); goto l_0x1014_5cb2; /* jmp 0x10145cb2 */
        l_0x1014_5c79:
            ii(0x1014_5c79, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_5c7c, 5); calld(0x100e_0760, -0x6_5521);          /* call 0x100e0760 */
            ii(0x1014_5c81, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_5c84, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_5c87, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1014_5c8a, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_5c8d, 3); calld_abs(memd_a32[ds, edx + 0x4]);     /* call dword [edx+0x4] */
            ii(0x1014_5c90, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_5c92, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_5c95, 3); mov(memw_a32[ds, eax], dx);             /* mov [eax], dx */
            ii(0x1014_5c98, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1014_5c9c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_5c9e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_5ca1, 5); calld(0x100e_03bc, -0x6_58ea);          /* call 0x100e03bc */
            ii(0x1014_5ca6, 2); jmpd(0x1014_5cb2, 0xa); goto l_0x1014_5cb2; /* jmp 0x10145cb2 */
        //  ii(0x1014_5ca8, 10); Недостижимый код.
        l_0x1014_5cb2:
            ii(0x1014_5cb2, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1014_5cb5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_5cb7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_5cb8, 1); popd(edi);                              /* pop edi */
            ii(0x1014_5cb9, 1); popd(esi);                              /* pop esi */
            ii(0x1014_5cba, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_5cbb, 1); retd(); return;                         /* ret */
        }
    }
}
