using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_5df2-6ba070b0")]
        public void Method_1014_5df2()
        {
            ii(0x1014_5df2, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1014_5df7, 5); calld(Definitions.sys_check_available_stack_size, 0x1_ff56); /* call 0x10165d52 */
            ii(0x1014_5dfc, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_5dfd, 1); pushd(esi);                             /* push esi */
            ii(0x1014_5dfe, 1); pushd(edi);                             /* push edi */
            ii(0x1014_5dff, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_5e00, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_5e02, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1014_5e08, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_5e0b, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1014_5e0e, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1014_5e11, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_5e14, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1014_5e17, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_5e1a, 5); calld(0x1014_630a, 0x4eb);              /* call 0x1014630a */
            ii(0x1014_5e1f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_5e21, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1014_5e24, 5); calld(0x1013_ad11, -0xb118);            /* call 0x1013ad11 */
            ii(0x1014_5e29, 2); test(al, al);                           /* test al, al */
            ii(0x1014_5e2b, 2); if(jzd(0x1014_5e3d, 0x10)) goto l_0x1014_5e3d; /* jz 0x10145e3d */
            ii(0x1014_5e2d, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x1014_5e31, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_5e33, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1014_5e36, 5); calld(0x100e_03bc, -0x6_5a7f);          /* call 0x100e03bc */
            ii(0x1014_5e3b, 2); jmpd(0x1014_5ea2, 0x65); goto l_0x1014_5ea2; /* jmp 0x10145ea2 */
        l_0x1014_5e3d:
            ii(0x1014_5e3d, 5); mov(ecx, StringDefinitions.True);       /* mov ecx, 0x101ad012 */
            ii(0x1014_5e42, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1014_5e45, 5); calld(0x100e_0760, -0x6_56ea);          /* call 0x100e0760 */
            ii(0x1014_5e4a, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_5e4d, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_5e50, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1014_5e53, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x1014_5e56, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_5e59, 3); calld_abs(memd_a32[ds, ebx + 0xc]);     /* call dword [ebx+0xc] */
            ii(0x1014_5e5c, 5); calld(Definitions.my_strobj_c_str_v2, -0xb_c699); /* call 0x100897c8 */
            ii(0x1014_5e61, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1014_5e63, 5); calld(Definitions.sys_strcasecmp, 0x2_02c8); /* call 0x10166130 */
            ii(0x1014_5e68, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_5e6a, 2); if(jnzd(0x1014_5e72, 0x6)) goto l_0x1014_5e72; /* jnz 0x10145e72 */
            ii(0x1014_5e6c, 4); mov(memb_a32[ss, ebp - 0x20], 0x1);     /* mov byte [ebp-0x20], 0x1 */
            ii(0x1014_5e70, 2); jmpd(0x1014_5e76, 0x4); goto l_0x1014_5e76; /* jmp 0x10145e76 */
        l_0x1014_5e72:
            ii(0x1014_5e72, 4); mov(memb_a32[ss, ebp - 0x20], 0);       /* mov byte [ebp-0x20], 0x0 */
        l_0x1014_5e76:
            ii(0x1014_5e76, 3); mov(al, memb_a32[ss, ebp - 0x20]);      /* mov al, [ebp-0x20] */
            ii(0x1014_5e79, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_5e7c, 2); mov(memb_a32[ds, edx], al);             /* mov [edx], al */
            ii(0x1014_5e7e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_5e80, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_5e83, 5); calld(Definitions.my_string_dtor, -0x435e); /* call 0x10141b2a */
            ii(0x1014_5e88, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1014_5e8c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_5e8e, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1014_5e91, 5); calld(0x100e_03bc, -0x6_5ada);          /* call 0x100e03bc */
            ii(0x1014_5e96, 2); jmpd(0x1014_5ea2, 0xa); goto l_0x1014_5ea2; /* jmp 0x10145ea2 */
        //    ii(0x1014_5e98, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1014_5e9a, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
        //    ii(0x1014_5e9d, 5); calld(0x100e_03bc, -0x6_5ae6);          /* call 0x100e03bc */
        l_0x1014_5ea2:
            ii(0x1014_5ea2, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1014_5ea5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_5ea7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_5ea8, 1); popd(edi);                              /* pop edi */
            ii(0x1014_5ea9, 1); popd(esi);                              /* pop esi */
            ii(0x1014_5eaa, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_5eab, 1); retd(); return;                         /* ret */
        }
    }
}
