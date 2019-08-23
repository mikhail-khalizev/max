using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_5eac-af69449b")]
        public void Method_1014_5eac()
        {
            ii(0x1014_5eac, 5); push(0x30);                             /* push 0x30 */
            ii(0x1014_5eb1, 5); call(Definitions.sys_check_available_stack_size, 0x1_fe9c); /* call 0x10165d52 */
            ii(0x1014_5eb6, 1); push(esi);                              /* push esi */
            ii(0x1014_5eb7, 1); push(edi);                              /* push edi */
            ii(0x1014_5eb8, 1); push(ebp);                              /* push ebp */
            ii(0x1014_5eb9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_5ebb, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1014_5ec1, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_5ec4, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1014_5ec7, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1014_5eca, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1014_5ecd, 3); mov(ebx, memd[ss, ebp - 0xc]);          /* mov ebx, [ebp-0xc] */
            ii(0x1014_5ed0, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1014_5ed3, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_5ed6, 5); call(0x1014_630a, 0x42f);               /* call 0x1014630a */
            ii(0x1014_5edb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_5edd, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1014_5ee0, 5); call(0x1013_ad11, -0xb1d4);             /* call 0x1013ad11 */
            ii(0x1014_5ee5, 2); test(al, al);                           /* test al, al */
            ii(0x1014_5ee7, 2); if(jz(0x1014_5ef9, 0x10)) goto l_0x1014_5ef9; /* jz 0x10145ef9 */
            ii(0x1014_5ee9, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1014_5eed, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_5eef, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1014_5ef2, 5); call(0x100e_03bc, -0x6_5b3b);           /* call 0x100e03bc */
            ii(0x1014_5ef7, 2); jmp(0x1014_5f4a, 0x51); goto l_0x1014_5f4a; /* jmp 0x10145f4a */
        l_0x1014_5ef9:
            ii(0x1014_5ef9, 3); mov(ecx, memd[ss, ebp - 0x4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1014_5efc, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1014_5eff, 5); call(0x100e_0760, -0x6_57a4);           /* call 0x100e0760 */
            ii(0x1014_5f04, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1014_5f07, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1014_5f0a, 3); mov(ebx, memd[ds, eax + 0x2]);          /* mov ebx, [eax+0x2] */
            ii(0x1014_5f0d, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1014_5f10, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1014_5f13, 3); call_abs(memd[ds, ebx + 0xc]);          /* call dword [ebx+0xc] */
            ii(0x1014_5f16, 5); call(Definitions.my_strobj_c_str_v2, -0xb_c753); /* call 0x100897c8 */
            ii(0x1014_5f1b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_5f1d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_5f20, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1014_5f22, 5); call(0x1014_5996, -0x591);              /* call 0x10145996 */
            ii(0x1014_5f27, 3); mov(memb[ss, ebp - 0x14], al);          /* mov [ebp-0x14], al */
            ii(0x1014_5f2a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_5f2c, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1014_5f2f, 5); call(Definitions.my_string_dtor, -0x440a); /* call 0x10141b2a */
            ii(0x1014_5f34, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_5f36, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1014_5f39, 5); call(0x100e_03bc, -0x6_5b82);           /* call 0x100e03bc */
            ii(0x1014_5f3e, 2); jmp(0x1014_5f4a, 0xa); goto l_0x1014_5f4a; /* jmp 0x10145f4a */
        //  ii(0x1014_5f40, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1014_5f42, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
        //  ii(0x1014_5f45, 5); call(0x100e_03bc, -0x6_5b8e);           /* call 0x100e03bc */
        l_0x1014_5f4a:
            ii(0x1014_5f4a, 3); mov(al, memb[ss, ebp - 0x14]);          /* mov al, [ebp-0x14] */
            ii(0x1014_5f4d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_5f4f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_5f50, 1); pop(edi);                               /* pop edi */
            ii(0x1014_5f51, 1); pop(esi);                               /* pop esi */
            ii(0x1014_5f52, 1); ret();                                  /* ret */
        }
    }
}
