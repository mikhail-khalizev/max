using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_45d4-908182a2")]
        public void Method_1010_45d4()
        {
            ii(0x1010_45d4, 5); push(0x28);                             /* push 0x28 */
            ii(0x1010_45d9, 5); call(Definitions.sys_check_available_stack_size, 0x6_1774); /* call 0x10165d52 */
            ii(0x1010_45de, 1); push(ebx);                              /* push ebx */
            ii(0x1010_45df, 1); push(ecx);                              /* push ecx */
            ii(0x1010_45e0, 1); push(edx);                              /* push edx */
            ii(0x1010_45e1, 1); push(esi);                              /* push esi */
            ii(0x1010_45e2, 1); push(edi);                              /* push edi */
            ii(0x1010_45e3, 1); push(ebp);                              /* push ebp */
            ii(0x1010_45e4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_45e6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_45ec, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_45ef, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_45f2, 5); call(0x1007_6d58, -0x8_d89f);           /* call 0x10076d58 */
            ii(0x1010_45f7, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_45fa, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1010_45fd, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_4600, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_4603, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1010_4606, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_4609, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_460b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_460c, 1); pop(edi);                               /* pop edi */
            ii(0x1010_460d, 1); pop(esi);                               /* pop esi */
            ii(0x1010_460e, 1); pop(edx);                               /* pop edx */
            ii(0x1010_460f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_4610, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_4611, 1); ret();                                  /* ret */
        }
    }
}
