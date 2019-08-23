using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_5fca-34f7bc34")]
        public void Method_100a_5fca()
        {
            ii(0x100a_5fca, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_5fcf, 5); call(Definitions.sys_check_available_stack_size, 0xb_fd7e); /* call 0x10165d52 */
            ii(0x100a_5fd4, 1); push(ebx);                              /* push ebx */
            ii(0x100a_5fd5, 1); push(ecx);                              /* push ecx */
            ii(0x100a_5fd6, 1); push(esi);                              /* push esi */
            ii(0x100a_5fd7, 1); push(edi);                              /* push edi */
            ii(0x100a_5fd8, 1); push(ebp);                              /* push ebp */
            ii(0x100a_5fd9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_5fdb, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_5fe1, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_5fe4, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_5fe7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_5fea, 4); mov(ax, memw[ds, eax + 0x2]);           /* mov ax, [eax+0x2] */
            ii(0x100a_5fee, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_5ff1, 4); sub(ax, memw[ds, edx + 0x2]);           /* sub ax, [edx+0x2] */
            ii(0x100a_5ff5, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100a_5ff8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_5ffb, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100a_5ffe, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_6001, 3); sub(ax, memw[ds, edx]);                 /* sub ax, [edx] */
            ii(0x100a_6004, 1); cwde();                                 /* cwde */
            ii(0x100a_6005, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100a_6007, 5); call(0x100a_5f65, -0xa7);               /* call 0x100a5f65 */
            ii(0x100a_600c, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_600f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_6012, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_6014, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_6015, 1); pop(edi);                               /* pop edi */
            ii(0x100a_6016, 1); pop(esi);                               /* pop esi */
            ii(0x100a_6017, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_6018, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_6019, 1); ret();                                  /* ret */
        }
    }
}
