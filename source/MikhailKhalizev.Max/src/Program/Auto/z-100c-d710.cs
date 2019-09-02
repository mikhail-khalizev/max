using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_d710-329519cd")]
        public void Method_100c_d710()
        {
            ii(0x100c_d710, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_d715, 5); call(Definitions.sys_check_available_stack_size, 0x9_8638); /* call 0x10165d52 */
            ii(0x100c_d71a, 1); push(ebx);                              /* push ebx */
            ii(0x100c_d71b, 1); push(ecx);                              /* push ecx */
            ii(0x100c_d71c, 1); push(esi);                              /* push esi */
            ii(0x100c_d71d, 1); push(edi);                              /* push edi */
            ii(0x100c_d71e, 1); push(ebp);                              /* push ebp */
            ii(0x100c_d71f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_d721, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_d727, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_d72a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_d72d, 7); test(memd[ss, ebp - 4], 4);             /* test dword [ebp-0x4], 0x4 */
            ii(0x100c_d734, 2); if(jz(0x100c_d74a, 0x14)) goto l_0x100c_d74a; /* jz 0x100cd74a */
            ii(0x100c_d736, 5); mov(edx, 0x101b_59b4);                  /* mov edx, 0x101b59b4 */
            ii(0x100c_d73b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_d73e, 5); call(Definitions.sys_call_dtor_arr, 0x9_8875); /* call 0x10165fb8 */
            ii(0x100c_d743, 5); call(Definitions.sys_delete_arr, 0x9_8890); /* call 0x10165fd8 */
            ii(0x100c_d748, 2); jmp(0x100c_d76b, 0x21); goto l_0x100c_d76b; /* jmp 0x100cd76b */
        l_0x100c_d74a:
            ii(0x100c_d74a, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100c_d74f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_d752, 5); call(0x100c_d67c, -0xdb);               /* call 0x100cd67c */
            ii(0x100c_d757, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_d75a, 7); test(memd[ss, ebp - 4], 2);             /* test dword [ebp-0x4], 0x2 */
            ii(0x100c_d761, 2); if(jz(0x100c_d76b, 8)) goto l_0x100c_d76b; /* jz 0x100cd76b */
            ii(0x100c_d763, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_d766, 5); call(Definitions.sys_delete, 0x9_87f9); /* call 0x10165f64 */
        l_0x100c_d76b:
            ii(0x100c_d76b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_d76e, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_d771, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_d774, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_d776, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_d777, 1); pop(edi);                               /* pop edi */
            ii(0x100c_d778, 1); pop(esi);                               /* pop esi */
            ii(0x100c_d779, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_d77a, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_d77b, 1); ret();                                  /* ret */
        }
    }
}
