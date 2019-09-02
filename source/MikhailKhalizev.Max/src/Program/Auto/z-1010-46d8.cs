using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_46d8-fe4a7fdc")]
        public void Method_1010_46d8()
        {
            ii(0x1010_46d8, 5); push(0x28);                             /* push 0x28 */
            ii(0x1010_46dd, 5); call(Definitions.sys_check_available_stack_size, 0x6_1670); /* call 0x10165d52 */
            ii(0x1010_46e2, 1); push(ebx);                              /* push ebx */
            ii(0x1010_46e3, 1); push(ecx);                              /* push ecx */
            ii(0x1010_46e4, 1); push(esi);                              /* push esi */
            ii(0x1010_46e5, 1); push(edi);                              /* push edi */
            ii(0x1010_46e6, 1); push(ebp);                              /* push ebp */
            ii(0x1010_46e7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_46e9, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1010_46ef, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1010_46f2, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1010_46f5, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1010_46f8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_46fb, 5); call(0x1013_a112, 0x3_5a12);            /* call 0x1013a112 */
            ii(0x1010_4700, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1010_4703, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1010_4706, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1010_4709, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_470c, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_470f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_4712, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_4714, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_4715, 1); pop(edi);                               /* pop edi */
            ii(0x1010_4716, 1); pop(esi);                               /* pop esi */
            ii(0x1010_4717, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_4718, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_4719, 1); ret();                                  /* ret */
        }
    }
}
