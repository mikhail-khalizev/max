using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a6e0-200eda41")]
        public void Method_100c_a6e0()
        {
            ii(0x100c_a6e0, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_a6e5, 5); call(Definitions.sys_check_available_stack_size, 0x9_b668); /* call 0x10165d52 */
            ii(0x100c_a6ea, 1); push(ebx);                              /* push ebx */
            ii(0x100c_a6eb, 1); push(ecx);                              /* push ecx */
            ii(0x100c_a6ec, 1); push(esi);                              /* push esi */
            ii(0x100c_a6ed, 1); push(edi);                              /* push edi */
            ii(0x100c_a6ee, 1); push(ebp);                              /* push ebp */
            ii(0x100c_a6ef, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a6f1, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_a6f7, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_a6fa, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_a6fd, 7); test(memd[ss, ebp - 4], 4);             /* test dword [ebp-0x4], 0x4 */
            ii(0x100c_a704, 2); if(jz(0x100c_a71a, 0x14)) goto l_0x100c_a71a; /* jz 0x100ca71a */
            ii(0x100c_a706, 5); mov(edx, 0x101b_5684);                  /* mov edx, 0x101b5684 */
            ii(0x100c_a70b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_a70e, 5); call(Definitions.sys_call_dtor_arr, 0x9_b8a5); /* call 0x10165fb8 */
            ii(0x100c_a713, 5); call(Definitions.sys_delete_arr, 0x9_b8c0); /* call 0x10165fd8 */
            ii(0x100c_a718, 2); jmp(0x100c_a73b, 0x21); goto l_0x100c_a73b; /* jmp 0x100ca73b */
        l_0x100c_a71a:
            ii(0x100c_a71a, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100c_a71f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_a722, 5); call(0x100a_284c, -0x2_7edb);           /* call 0x100a284c */
            ii(0x100c_a727, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_a72a, 7); test(memd[ss, ebp - 4], 2);             /* test dword [ebp-0x4], 0x2 */
            ii(0x100c_a731, 2); if(jz(0x100c_a73b, 8)) goto l_0x100c_a73b; /* jz 0x100ca73b */
            ii(0x100c_a733, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_a736, 5); call(Definitions.sys_delete, 0x9_b829); /* call 0x10165f64 */
        l_0x100c_a73b:
            ii(0x100c_a73b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_a73e, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100c_a741, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100c_a744, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a746, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_a747, 1); pop(edi);                               /* pop edi */
            ii(0x100c_a748, 1); pop(esi);                               /* pop esi */
            ii(0x100c_a749, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_a74a, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_a74b, 1); ret();                                  /* ret */
        }
    }
}
