using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_8573-3b7c597")]
        public void Method_100d_8573()
        {
            ii(0x100d_8573, 5); push(0x24);                             /* push 0x24 */
            ii(0x100d_8578, 5); call(Definitions.sys_check_available_stack_size, 0x8_d7d5); /* call 0x10165d52 */
            ii(0x100d_857d, 1); push(ebx);                              /* push ebx */
            ii(0x100d_857e, 1); push(ecx);                              /* push ecx */
            ii(0x100d_857f, 1); push(esi);                              /* push esi */
            ii(0x100d_8580, 1); push(edi);                              /* push edi */
            ii(0x100d_8581, 1); push(ebp);                              /* push ebp */
            ii(0x100d_8582, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_8584, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100d_858a, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_858d, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100d_8590, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_8593, 3); mov(ecx, memd[ds, eax + 13]);           /* mov ecx, [eax+0xd] */
            ii(0x100d_8596, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100d_8599, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_859c, 3); mov(ebx, memd[ds, eax + 29]);           /* mov ebx, [eax+0x1d] */
            ii(0x100d_859f, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_85a2, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100d_85a6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_85a9, 3); mov(eax, memd[ds, eax + 11]);           /* mov eax, [eax+0xb] */
            ii(0x100d_85ac, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x100d_85af, 5); call(0x100d_8248, -0x36c);              /* call 0x100d8248 */
            ii(0x100d_85b4, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100d_85b7, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100d_85ba, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_85bc, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_85bd, 1); pop(edi);                               /* pop edi */
            ii(0x100d_85be, 1); pop(esi);                               /* pop esi */
            ii(0x100d_85bf, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_85c0, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_85c1, 1); ret();                                  /* ret */
        }
    }
}
