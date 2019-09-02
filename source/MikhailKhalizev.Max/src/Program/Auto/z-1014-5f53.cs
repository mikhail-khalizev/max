using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_5f53-eeb844bc")]
        public void Method_1014_5f53()
        {
            ii(0x1014_5f53, 5); push(0x30);                             /* push 0x30 */
            ii(0x1014_5f58, 5); call(Definitions.sys_check_available_stack_size, 0x1_fdf5); /* call 0x10165d52 */
            ii(0x1014_5f5d, 1); push(ecx);                              /* push ecx */
            ii(0x1014_5f5e, 1); push(esi);                              /* push esi */
            ii(0x1014_5f5f, 1); push(edi);                              /* push edi */
            ii(0x1014_5f60, 1); push(ebp);                              /* push ebp */
            ii(0x1014_5f61, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_5f63, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1014_5f69, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_5f6c, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1014_5f6f, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1014_5f72, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1014_5f75, 3); lea(edx, memd[ss, ebp - 28]);           /* lea edx, [ebp-0x1c] */
            ii(0x1014_5f78, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_5f7b, 5); call(0x1014_630a, 0x38a);               /* call 0x1014630a */
            ii(0x1014_5f80, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_5f82, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1014_5f85, 5); call(0x1013_ad11, -0xb279);             /* call 0x1013ad11 */
            ii(0x1014_5f8a, 2); test(al, al);                           /* test al, al */
            ii(0x1014_5f8c, 2); if(jz(0x1014_5fa1, 0x13)) goto l_0x1014_5fa1; /* jz 0x10145fa1 */
            ii(0x1014_5f8e, 7); mov(memd[ss, ebp - 16], 0);             /* mov dword [ebp-0x10], 0x0 */
            ii(0x1014_5f95, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_5f97, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1014_5f9a, 5); call(0x100e_03bc, -0x6_5be3);           /* call 0x100e03bc */
            ii(0x1014_5f9f, 2); jmp(0x1014_5fed, 0x4c); goto l_0x1014_5fed; /* jmp 0x10145fed */
        l_0x1014_5fa1:
            ii(0x1014_5fa1, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1014_5fa4, 5); call(0x100e_0760, -0x6_5849);           /* call 0x100e0760 */
            ii(0x1014_5fa9, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1014_5fac, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1014_5faf, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1014_5fb2, 3); lea(edx, memd[ss, ebp - 24]);           /* lea edx, [ebp-0x18] */
            ii(0x1014_5fb5, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1014_5fb8, 3); call_abs(memd[ds, ebx + 12]);           /* call dword [ebx+0xc] */
            ii(0x1014_5fbb, 5); call(Definitions.my_strobj_c_str_v2, -0xb_c7f8); /* call 0x100897c8 */
            ii(0x1014_5fc0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_5fc2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_5fc5, 5); call(0x1014_5946, -0x684);              /* call 0x10145946 */
            ii(0x1014_5fca, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1014_5fcd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_5fcf, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1014_5fd2, 5); call(Definitions.my_string_dtor, -0x44ad); /* call 0x10141b2a */
            ii(0x1014_5fd7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_5fd9, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1014_5fdc, 5); call(0x100e_03bc, -0x6_5c25);           /* call 0x100e03bc */
            ii(0x1014_5fe1, 2); jmp(0x1014_5fed, 0xa); goto l_0x1014_5fed; /* jmp 0x10145fed */
        //  ii(0x1014_5fe3, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1014_5fe5, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
        //  ii(0x1014_5fe8, 5); call(0x100e_03bc, -0x6_5c31);           /* call 0x100e03bc */
        l_0x1014_5fed:
            ii(0x1014_5fed, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_5ff0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_5ff2, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_5ff3, 1); pop(edi);                               /* pop edi */
            ii(0x1014_5ff4, 1); pop(esi);                               /* pop esi */
            ii(0x1014_5ff5, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_5ff6, 1); ret();                                  /* ret */
        }
    }
}
