using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_8210-4fd299da")]
        public void Method_1011_8210()
        {
            ii(0x1011_8210, 5); push(0x20);                             /* push 0x20 */
            ii(0x1011_8215, 5); call(Definitions.sys_check_available_stack_size, 0x4_db38); /* call 0x10165d52 */
            ii(0x1011_821a, 1); push(ecx);                              /* push ecx */
            ii(0x1011_821b, 1); push(esi);                              /* push esi */
            ii(0x1011_821c, 1); push(edi);                              /* push edi */
            ii(0x1011_821d, 1); push(ebp);                              /* push ebp */
            ii(0x1011_821e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_8220, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_8226, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1011_8229, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1011_822c, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1011_822f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_8232, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1011_8235, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_8238, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_823b, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1011_823e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_8241, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_8244, 5); call(0x1007_6aac, -0xa_179d);           /* call 0x10076aac */
            ii(0x1011_8249, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_824c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_824e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_824f, 1); pop(edi);                               /* pop edi */
            ii(0x1011_8250, 1); pop(esi);                               /* pop esi */
            ii(0x1011_8251, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_8252, 1); ret();                                  /* ret */
        }
    }
}
