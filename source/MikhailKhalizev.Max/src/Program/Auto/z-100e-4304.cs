using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_4304-4ec648b5")]
        public void Method_100e_4304()
        {
            ii(0x100e_4304, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_4309, 5); call(Definitions.sys_check_available_stack_size, 0x8_1a44); /* call 0x10165d52 */
            ii(0x100e_430e, 1); push(ebx);                              /* push ebx */
            ii(0x100e_430f, 1); push(ecx);                              /* push ecx */
            ii(0x100e_4310, 1); push(edx);                              /* push edx */
            ii(0x100e_4311, 1); push(esi);                              /* push esi */
            ii(0x100e_4312, 1); push(edi);                              /* push edi */
            ii(0x100e_4313, 1); push(ebp);                              /* push ebp */
            ii(0x100e_4314, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_4316, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100e_431c, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_431f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_4322, 4); mov(ax, memw[ds, eax + 12]);            /* mov ax, [eax+0xc] */
            ii(0x100e_4326, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100e_4329, 4); sub(ax, memw[ds, edx + 4]);             /* sub ax, [edx+0x4] */
            ii(0x100e_432d, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_4330, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_4333, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_4335, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_4336, 1); pop(edi);                               /* pop edi */
            ii(0x100e_4337, 1); pop(esi);                               /* pop esi */
            ii(0x100e_4338, 1); pop(edx);                               /* pop edx */
            ii(0x100e_4339, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_433a, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_433b, 1); ret();                                  /* ret */
        }
    }
}
