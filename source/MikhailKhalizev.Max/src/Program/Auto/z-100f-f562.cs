using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_f562-2cca8c4c")]
        public void Method_100f_f562()
        {
            ii(0x100f_f562, 5); push(0x34);                             /* push 0x34 */
            ii(0x100f_f567, 5); call(Definitions.sys_check_available_stack_size, 0x6_67e6); /* call 0x10165d52 */
            ii(0x100f_f56c, 1); push(ebx);                              /* push ebx */
            ii(0x100f_f56d, 1); push(ecx);                              /* push ecx */
            ii(0x100f_f56e, 1); push(edx);                              /* push edx */
            ii(0x100f_f56f, 1); push(esi);                              /* push esi */
            ii(0x100f_f570, 1); push(edi);                              /* push edi */
            ii(0x100f_f571, 1); push(ebp);                              /* push ebp */
            ii(0x100f_f572, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_f574, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100f_f57a, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_f57d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_f580, 4); mov(ax, memw[ds, eax + 0xc]);           /* mov ax, [eax+0xc] */
            ii(0x100f_f584, 1); inc(eax);                               /* inc eax */
            ii(0x100f_f585, 1); cwde();                                 /* cwde */
            ii(0x100f_f586, 1); push(eax);                              /* push eax */
            ii(0x100f_f587, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_f58a, 4); mov(ax, memw[ds, eax + 0x8]);           /* mov ax, [eax+0x8] */
            ii(0x100f_f58e, 1); inc(eax);                               /* inc eax */
            ii(0x100f_f58f, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_f592, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_f595, 3); mov(ebx, memd[ds, eax + 0x2]);          /* mov ebx, [eax+0x2] */
            ii(0x100f_f598, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_f59b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_f59e, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100f_f5a1, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_f5a4, 5); call(0x1008_b148, -0x7_4461);           /* call 0x1008b148 */
            ii(0x100f_f5a9, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_f5ac, 5); call(0x100e_4f96, -0x1_a61b);           /* call 0x100e4f96 */
            ii(0x100f_f5b1, 7); mov(memb[ds, 0x101c_391a], 0x1);        /* mov byte [0x101c391a], 0x1 */
            ii(0x100f_f5b8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_f5ba, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_f5bb, 1); pop(edi);                               /* pop edi */
            ii(0x100f_f5bc, 1); pop(esi);                               /* pop esi */
            ii(0x100f_f5bd, 1); pop(edx);                               /* pop edx */
            ii(0x100f_f5be, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_f5bf, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_f5c0, 1); ret();                                  /* ret */
        }
    }
}
