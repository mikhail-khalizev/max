using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_87e4-c3030df5")]
        public void Method_1014_87e4()
        {
            ii(0x1014_87e4, 5); push(0x24);                             /* push 0x24 */
            ii(0x1014_87e9, 5); call(Definitions.sys_check_available_stack_size, 0x1_d564); /* call 0x10165d52 */
            ii(0x1014_87ee, 1); push(ebx);                              /* push ebx */
            ii(0x1014_87ef, 1); push(ecx);                              /* push ecx */
            ii(0x1014_87f0, 1); push(esi);                              /* push esi */
            ii(0x1014_87f1, 1); push(edi);                              /* push edi */
            ii(0x1014_87f2, 1); push(ebp);                              /* push ebp */
            ii(0x1014_87f3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_87f5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_87fb, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_87fe, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_8801, 7); test(memd[ss, ebp - 0x4], 0x4);         /* test dword [ebp-0x4], 0x4 */
            ii(0x1014_8808, 2); if(jz(0x1014_881e, 0x14)) goto l_0x1014_881e; /* jz 0x1014881e */
            ii(0x1014_880a, 5); mov(edx, 0x101b_72dc);                  /* mov edx, 0x101b72dc */
            ii(0x1014_880f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_8812, 5); call(Definitions.sys_call_dtor_arr, 0x1_d7a1); /* call 0x10165fb8 */
            ii(0x1014_8817, 5); call(Definitions.sys_delete_arr, 0x1_d7bc); /* call 0x10165fd8 */
            ii(0x1014_881c, 2); jmp(0x1014_883f, 0x21); goto l_0x1014_883f; /* jmp 0x1014883f */
        l_0x1014_881e:
            ii(0x1014_881e, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1014_8823, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_8826, 5); call(0x1014_8750, -0xdb);               /* call 0x10148750 */
            ii(0x1014_882b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_882e, 7); test(memd[ss, ebp - 0x4], 0x2);         /* test dword [ebp-0x4], 0x2 */
            ii(0x1014_8835, 2); if(jz(0x1014_883f, 0x8)) goto l_0x1014_883f; /* jz 0x1014883f */
            ii(0x1014_8837, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_883a, 5); call(Definitions.sys_delete, 0x1_d725); /* call 0x10165f64 */
        l_0x1014_883f:
            ii(0x1014_883f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_8842, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1014_8845, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_8848, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_884a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_884b, 1); pop(edi);                               /* pop edi */
            ii(0x1014_884c, 1); pop(esi);                               /* pop esi */
            ii(0x1014_884d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_884e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_884f, 1); ret();                                  /* ret */
        }
    }
}
