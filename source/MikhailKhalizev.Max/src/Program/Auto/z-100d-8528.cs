using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_8528-6e039c48")]
        public void Method_100d_8528()
        {
            ii(0x100d_8528, 5); push(0x24);                             /* push 0x24 */
            ii(0x100d_852d, 5); call(Definitions.sys_check_available_stack_size, 0x8_d820); /* call 0x10165d52 */
            ii(0x100d_8532, 1); push(ebx);                              /* push ebx */
            ii(0x100d_8533, 1); push(ecx);                              /* push ecx */
            ii(0x100d_8534, 1); push(esi);                              /* push esi */
            ii(0x100d_8535, 1); push(edi);                              /* push edi */
            ii(0x100d_8536, 1); push(ebp);                              /* push ebp */
            ii(0x100d_8537, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_8539, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100d_853f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_8542, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100d_8545, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_8548, 3); mov(edx, memd[ds, edx + 23]);           /* mov edx, [edx+0x17] */
            ii(0x100d_854b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_854e, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100d_8552, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100d_8555, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_8558, 3); mov(ebx, memd[ds, eax + 13]);           /* mov ebx, [eax+0xd] */
            ii(0x100d_855b, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_855e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_8560, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_8563, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100d_8565, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100d_8568, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100d_856b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_856d, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_856e, 1); pop(edi);                               /* pop edi */
            ii(0x100d_856f, 1); pop(esi);                               /* pop esi */
            ii(0x100d_8570, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_8571, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_8572, 1); ret();                                  /* ret */
        }
    }
}
