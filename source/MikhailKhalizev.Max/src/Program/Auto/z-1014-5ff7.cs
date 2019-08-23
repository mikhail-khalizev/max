using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_5ff7-ec1722da")]
        public void Method_1014_5ff7()
        {
            ii(0x1014_5ff7, 5); push(0x34);                             /* push 0x34 */
            ii(0x1014_5ffc, 5); call(Definitions.sys_check_available_stack_size, 0x1_fd51); /* call 0x10165d52 */
            ii(0x1014_6001, 1); push(ebx);                              /* push ebx */
            ii(0x1014_6002, 1); push(ecx);                              /* push ecx */
            ii(0x1014_6003, 1); push(esi);                              /* push esi */
            ii(0x1014_6004, 1); push(edi);                              /* push edi */
            ii(0x1014_6005, 1); push(ebp);                              /* push ebp */
            ii(0x1014_6006, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_6008, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1014_600e, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_6011, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_6014, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1014_6017, 3); lea(edx, memd[ss, ebp - 0x18]);         /* lea edx, [ebp-0x18] */
            ii(0x1014_601a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_601d, 5); call(0x1014_630a, 0x2e8);               /* call 0x1014630a */
            ii(0x1014_6022, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6024, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1014_6027, 5); call(0x1013_ad11, -0xb31b);             /* call 0x1013ad11 */
            ii(0x1014_602c, 2); test(al, al);                           /* test al, al */
            ii(0x1014_602e, 2); if(jz(0x1014_6040, 0x10)) goto l_0x1014_6040; /* jz 0x10146040 */
            ii(0x1014_6030, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1014_6034, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6036, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1014_6039, 5); call(0x100e_03bc, -0x6_5c82);           /* call 0x100e03bc */
            ii(0x1014_603e, 2); jmp(0x1014_609f, 0x5f); goto l_0x1014_609f; /* jmp 0x1014609f */
        l_0x1014_6040:
            ii(0x1014_6040, 5); mov(ecx, StringDefinitions.True2);      /* mov ecx, 0x101ad017 */
            ii(0x1014_6045, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1014_6048, 5); call(0x100e_0760, -0x6_58ed);           /* call 0x100e0760 */
            ii(0x1014_604d, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_6050, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_6053, 3); mov(ebx, memd[ds, eax + 0x2]);          /* mov ebx, [eax+0x2] */
            ii(0x1014_6056, 3); lea(edx, memd[ss, ebp - 0x14]);         /* lea edx, [ebp-0x14] */
            ii(0x1014_6059, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_605c, 3); call_abs(memd[ds, ebx + 0xc]);          /* call dword [ebx+0xc] */
            ii(0x1014_605f, 5); call(Definitions.my_strobj_c_str_v2, -0xb_c89c); /* call 0x100897c8 */
            ii(0x1014_6064, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1014_6066, 5); call(Definitions.sys_strcasecmp, 0x2_00c5); /* call 0x10166130 */
            ii(0x1014_606b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_606d, 2); if(jnz(0x1014_6075, 0x6)) goto l_0x1014_6075; /* jnz 0x10146075 */
            ii(0x1014_606f, 4); mov(memb[ss, ebp - 0x1c], 0x1);         /* mov byte [ebp-0x1c], 0x1 */
            ii(0x1014_6073, 2); jmp(0x1014_6079, 0x4); goto l_0x1014_6079; /* jmp 0x10146079 */
        l_0x1014_6075:
            ii(0x1014_6075, 4); mov(memb[ss, ebp - 0x1c], 0);           /* mov byte [ebp-0x1c], 0x0 */
        l_0x1014_6079:
            ii(0x1014_6079, 3); mov(al, memb[ss, ebp - 0x1c]);          /* mov al, [ebp-0x1c] */
            ii(0x1014_607c, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x1014_607f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6081, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1014_6084, 5); call(Definitions.my_string_dtor, -0x455f); /* call 0x10141b2a */
            ii(0x1014_6089, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_608b, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1014_608e, 5); call(0x100e_03bc, -0x6_5cd7);           /* call 0x100e03bc */
            ii(0x1014_6093, 2); jmp(0x1014_609f, 0xa); goto l_0x1014_609f; /* jmp 0x1014609f */
        //  ii(0x1014_6095, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1014_6097, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
        //  ii(0x1014_609a, 5); call(0x100e_03bc, -0x6_5ce3);           /* call 0x100e03bc */
        l_0x1014_609f:
            ii(0x1014_609f, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1014_60a2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_60a4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_60a5, 1); pop(edi);                               /* pop edi */
            ii(0x1014_60a6, 1); pop(esi);                               /* pop esi */
            ii(0x1014_60a7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_60a8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_60a9, 1); ret();                                  /* ret */
        }
    }
}
