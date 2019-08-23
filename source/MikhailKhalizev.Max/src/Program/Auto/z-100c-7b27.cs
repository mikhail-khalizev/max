using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_7b27-d7ac6277")]
        public void Method_100c_7b27()
        {
            ii(0x100c_7b27, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_7b2c, 5); call(Definitions.sys_check_available_stack_size, 0x9_e221); /* call 0x10165d52 */
            ii(0x100c_7b31, 1); push(ecx);                              /* push ecx */
            ii(0x100c_7b32, 1); push(esi);                              /* push esi */
            ii(0x100c_7b33, 1); push(edi);                              /* push edi */
            ii(0x100c_7b34, 1); push(ebp);                              /* push ebp */
            ii(0x100c_7b35, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_7b37, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100c_7b3d, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_7b40, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100c_7b43, 3); mov(memb[ss, ebp - 0x4], bl);           /* mov [ebp-0x4], bl */
            ii(0x100c_7b46, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x100c_7b49, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100c_7b4c, 2); mov(memb[ds, edx], al);                 /* mov [edx], al */
            ii(0x100c_7b4e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_7b51, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100c_7b54, 4); mov(memw[ds, edx + 0x1], ax);           /* mov [edx+0x1], ax */
            ii(0x100c_7b58, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_7b5b, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_7b5e, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_7b61, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_7b63, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_7b64, 1); pop(edi);                               /* pop edi */
            ii(0x100c_7b65, 1); pop(esi);                               /* pop esi */
            ii(0x100c_7b66, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_7b67, 1); ret();                                  /* ret */
        }
    }
}
