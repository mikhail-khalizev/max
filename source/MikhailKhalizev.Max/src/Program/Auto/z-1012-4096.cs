using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_4096-c756b062")]
        public void Method_1012_4096()
        {
            ii(0x1012_4096, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x1012_409b, 5); calld(Definitions.sys_check_available_stack_size, 0x4_1cb2); /* call 0x10165d52 */
            ii(0x1012_40a0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_40a1, 1); pushd(esi);                             /* push esi */
            ii(0x1012_40a2, 1); pushd(edi);                             /* push edi */
            ii(0x1012_40a3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_40a4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_40a6, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1012_40ac, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x1012_40af, 1); pushd(eax);                             /* push eax */
            ii(0x1012_40b0, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_40b3, 1); pushd(eax);                             /* push eax */
            ii(0x1012_40b4, 5); calld(0x1012_3850, -0x869);             /* call 0x10123850 */
            ii(0x1012_40b9, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1012_40bc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_40be, 2); if(jnzd(0x1012_40c9, 0x9)) goto l_0x1012_40c9; /* jnz 0x101240c9 */
            ii(0x1012_40c0, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x1012_40c7, 2); jmpd(0x1012_4109, 0x40); goto l_0x1012_4109; /* jmp 0x10124109 */
        l_0x1012_40c9:
            ii(0x1012_40c9, 2); pushd(0x20);                            /* push 0x20 */
            ii(0x1012_40cb, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1012_40ce, 1); pushd(eax);                             /* push eax */
            ii(0x1012_40cf, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_40d2, 1); pushd(eax);                             /* push eax */
            ii(0x1012_40d3, 5); calld(0x1012_3b6c, -0x56c);             /* call 0x10123b6c */
            ii(0x1012_40d8, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1012_40db, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_40dd, 2); if(jnzd(0x1012_40e8, 0x9)) goto l_0x1012_40e8; /* jnz 0x101240e8 */
            ii(0x1012_40df, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x1012_40e6, 2); jmpd(0x1012_4109, 0x21); goto l_0x1012_4109; /* jmp 0x10124109 */
        l_0x1012_40e8:
            ii(0x1012_40e8, 5); mov(edx, StringDefinitions.Yes);        /* mov edx, 0x101a8118 */
            ii(0x1012_40ed, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1012_40f0, 5); calld(Definitions.sys_strcasecmp, 0x4_203b); /* call 0x10166130 */
            ii(0x1012_40f5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_40f7, 2); if(jnzd(0x1012_4102, 0x9)) goto l_0x1012_4102; /* jnz 0x10124102 */
            ii(0x1012_40f9, 7); mov(memd_a32[ss, ebp - 0x4], 0x1);      /* mov dword [ebp-0x4], 0x1 */
            ii(0x1012_4100, 2); jmpd(0x1012_4109, 0x7); goto l_0x1012_4109; /* jmp 0x10124109 */
        l_0x1012_4102:
            ii(0x1012_4102, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
        l_0x1012_4109:
            ii(0x1012_4109, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_410c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_410e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_410f, 1); popd(edi);                              /* pop edi */
            ii(0x1012_4110, 1); popd(esi);                              /* pop esi */
            ii(0x1012_4111, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_4112, 1); retd();                                 /* ret */
        }
    }
}
