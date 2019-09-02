using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_4524-3d77b5ba")]
        public void Method_1016_4524()
        {
            ii(0x1016_4524, 5); push(0x24);                             /* push 0x24 */
            ii(0x1016_4529, 5); call(Definitions.sys_check_available_stack_size, 0x1824); /* call 0x10165d52 */
            ii(0x1016_452e, 1); push(ebx);                              /* push ebx */
            ii(0x1016_452f, 1); push(ecx);                              /* push ecx */
            ii(0x1016_4530, 1); push(esi);                              /* push esi */
            ii(0x1016_4531, 1); push(edi);                              /* push edi */
            ii(0x1016_4532, 1); push(ebp);                              /* push ebp */
            ii(0x1016_4533, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_4535, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_453b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1016_453e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1016_4541, 7); test(memd[ss, ebp - 4], 4);             /* test dword [ebp-0x4], 0x4 */
            ii(0x1016_4548, 2); if(jz(0x1016_455e, 0x14)) goto l_0x1016_455e; /* jz 0x1016455e */
            ii(0x1016_454a, 5); mov(edx, 0x101b_748c);                  /* mov edx, 0x101b748c */
            ii(0x1016_454f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_4552, 5); call(Definitions.sys_call_dtor_arr, 0x1a61); /* call 0x10165fb8 */
            ii(0x1016_4557, 5); call(Definitions.sys_delete_arr, 0x1a7c); /* call 0x10165fd8 */
            ii(0x1016_455c, 2); jmp(0x1016_457f, 0x21); goto l_0x1016_457f; /* jmp 0x1016457f */
        l_0x1016_455e:
            ii(0x1016_455e, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1016_4563, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_4566, 5); call(0x100c_a200, -0x9_a36b);           /* call 0x100ca200 */
            ii(0x1016_456b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1016_456e, 7); test(memd[ss, ebp - 4], 2);             /* test dword [ebp-0x4], 0x2 */
            ii(0x1016_4575, 2); if(jz(0x1016_457f, 8)) goto l_0x1016_457f; /* jz 0x1016457f */
            ii(0x1016_4577, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_457a, 5); call(Definitions.sys_delete, 0x19e5);   /* call 0x10165f64 */
        l_0x1016_457f:
            ii(0x1016_457f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_4582, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1016_4585, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1016_4588, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_458a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_458b, 1); pop(edi);                               /* pop edi */
            ii(0x1016_458c, 1); pop(esi);                               /* pop esi */
            ii(0x1016_458d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_458e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_458f, 1); ret();                                  /* ret */
        }
    }
}
