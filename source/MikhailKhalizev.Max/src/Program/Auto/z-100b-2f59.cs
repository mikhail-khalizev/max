using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_2f59-4866dc96")]
        public void Method_100b_2f59()
        {
            ii(0x100b_2f59, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_2f5e, 5); call(Definitions.sys_check_available_stack_size, 0xb_2def); /* call 0x10165d52 */
            ii(0x100b_2f63, 1); push(ebx);                              /* push ebx */
            ii(0x100b_2f64, 1); push(ecx);                              /* push ecx */
            ii(0x100b_2f65, 1); push(esi);                              /* push esi */
            ii(0x100b_2f66, 1); push(edi);                              /* push edi */
            ii(0x100b_2f67, 1); push(ebp);                              /* push ebp */
            ii(0x100b_2f68, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_2f6a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_2f70, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_2f73, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_2f76, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_2f79, 3); add(edx, 0x15);                         /* add edx, 0x15 */
            ii(0x100b_2f7c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_2f7f, 5); call(0x1007_6d98, -0x3_c1ec);           /* call 0x10076d98 */
            ii(0x100b_2f84, 2); test(al, al);                           /* test al, al */
            ii(0x100b_2f86, 2); if(jz(0x100b_2fed, 0x65)) goto l_0x100b_2fed; /* jz 0x100b2fed */
            ii(0x100b_2f88, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_2f8b, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_2f8e, 5); call(0x100b_7c44, 0x4cb1);              /* call 0x100b7c44 */
            ii(0x100b_2f93, 3); lea(ebx, memd[ss, ebp - 0xc]);          /* lea ebx, [ebp-0xc] */
            ii(0x100b_2f96, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_2f98, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_2f9a, 5); call(0x100b_7b28, 0x4b89);              /* call 0x100b7b28 */
            ii(0x100b_2f9f, 2); jmp(0x100b_2fa9, 0x8); goto l_0x100b_2fa9; /* jmp 0x100b2fa9 */
        l_0x100b_2fa1:
            ii(0x100b_2fa1, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100b_2fa4, 5); call(0x1007_6bf8, -0x3_c3b1);           /* call 0x10076bf8 */
        l_0x100b_2fa9:
            ii(0x100b_2fa9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_2fab, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100b_2fae, 5); call(0x1013_ad71, 0x8_7dbe);            /* call 0x1013ad71 */
            ii(0x100b_2fb3, 2); test(al, al);                           /* test al, al */
            ii(0x100b_2fb5, 2); if(jz(0x100b_2fcb, 0x14)) goto l_0x100b_2fcb; /* jz 0x100b2fcb */
            ii(0x100b_2fb7, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100b_2fba, 5); call(0x100b_7a48, 0x4a89);              /* call 0x100b7a48 */
            ii(0x100b_2fbf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_2fc1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_2fc4, 5); call(0x100b_1814, -0x17b5);             /* call 0x100b1814 */
            ii(0x100b_2fc9, 2); jmp(0x100b_2fa1, -0x2a); goto l_0x100b_2fa1; /* jmp 0x100b2fa1 */
        l_0x100b_2fcb:
            ii(0x100b_2fcb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_2fce, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_2fd1, 5); call(0x1013_a6f4, 0x8_771e);            /* call 0x1013a6f4 */
            ii(0x100b_2fd6, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_2fd9, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_2fde, 5); call(0x100a_5e27, -0xd1bc);             /* call 0x100a5e27 */
            ii(0x100b_2fe3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_2fe5, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100b_2fe8, 5); call(0x100b_7650, 0x4663);              /* call 0x100b7650 */
        l_0x100b_2fed:
            ii(0x100b_2fed, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_2fef, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_2ff0, 1); pop(edi);                               /* pop edi */
            ii(0x100b_2ff1, 1); pop(esi);                               /* pop esi */
            ii(0x100b_2ff2, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_2ff3, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_2ff4, 1); ret();                                  /* ret */
        }
    }
}
