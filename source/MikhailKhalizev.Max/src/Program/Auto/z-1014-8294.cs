using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_8294-27bb89da")]
        public void Method_1014_8294()
        {
            ii(0x1014_8294, 5); push(0x24);                             /* push 0x24 */
            ii(0x1014_8299, 5); call(Definitions.sys_check_available_stack_size, 0x1_dab4); /* call 0x10165d52 */
            ii(0x1014_829e, 1); push(ebx);                              /* push ebx */
            ii(0x1014_829f, 1); push(ecx);                              /* push ecx */
            ii(0x1014_82a0, 1); push(edx);                              /* push edx */
            ii(0x1014_82a1, 1); push(esi);                              /* push esi */
            ii(0x1014_82a2, 1); push(edi);                              /* push edi */
            ii(0x1014_82a3, 1); push(ebp);                              /* push ebp */
            ii(0x1014_82a4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_82a6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_82ac, 5); call(Definitions.sys_cli, 0x3_8d29);    /* call 0x10180fda */
            ii(0x1014_82b1, 5); mov(edx, 0x80);                         /* mov edx, 0x80 */
            ii(0x1014_82b6, 5); mov(eax, 0x43);                         /* mov eax, 0x43 */
            ii(0x1014_82bb, 5); call(Definitions.sys_write_port, 0x3_8d08); /* call 0x10180fc8 */
            ii(0x1014_82c0, 5); mov(eax, 0x42);                         /* mov eax, 0x42 */
            ii(0x1014_82c5, 5); call(Definitions.sys_read_port, 0x3_8d08); /* call 0x10180fd2 */
            ii(0x1014_82ca, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_82cd, 5); mov(eax, 0x42);                         /* mov eax, 0x42 */
            ii(0x1014_82d2, 5); call(Definitions.sys_read_port, 0x3_8cfb); /* call 0x10180fd2 */
            ii(0x1014_82d7, 3); shl(eax, 0x8);                          /* shl eax, 0x8 */
            ii(0x1014_82da, 3); add(memd[ss, ebp - 0x4], eax);          /* add [ebp-0x4], eax */
            ii(0x1014_82dd, 5); call(Definitions.sys_sti, 0x3_8cfa);    /* call 0x10180fdc */
            ii(0x1014_82e2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_82e5, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_82e8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_82eb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_82ed, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_82ee, 1); pop(edi);                               /* pop edi */
            ii(0x1014_82ef, 1); pop(esi);                               /* pop esi */
            ii(0x1014_82f0, 1); pop(edx);                               /* pop edx */
            ii(0x1014_82f1, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_82f2, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_82f3, 1); ret();                                  /* ret */
        }
    }
}
