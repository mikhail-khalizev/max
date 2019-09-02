using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_618d-ba2fc3b8")]
        public void Method_100e_618d()
        {
            ii(0x100e_618d, 5); push(0x28);                             /* push 0x28 */
            ii(0x100e_6192, 5); call(Definitions.sys_check_available_stack_size, 0x7_fbbb); /* call 0x10165d52 */
            ii(0x100e_6197, 1); push(ebx);                              /* push ebx */
            ii(0x100e_6198, 1); push(ecx);                              /* push ecx */
            ii(0x100e_6199, 1); push(esi);                              /* push esi */
            ii(0x100e_619a, 1); push(edi);                              /* push edi */
            ii(0x100e_619b, 1); push(ebp);                              /* push ebp */
            ii(0x100e_619c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_619e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_61a4, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_61a7, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100e_61aa, 5); mov(eax, 0x26);                         /* mov eax, 0x26 */
            ii(0x100e_61af, 5); call(0x100e_883d, 0x2689);              /* call 0x100e883d */
            ii(0x100e_61b4, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_61b7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_61ba, 3); shl(eax, 6);                            /* shl eax, 0x6 */
            ii(0x100e_61bd, 5); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x100e_61c2, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_61c5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_61c8, 3); shl(eax, 6);                            /* shl eax, 0x6 */
            ii(0x100e_61cb, 5); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x100e_61d0, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_61d3, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100e_61d7, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_61da, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_61dc, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_61df, 6); idiv(memd[ds, 0x101c_38c4]);            /* idiv dword [0x101c38c4] */
            ii(0x100e_61e5, 6); mov(edx, memd[ds, 0x101c_38fa]);        /* mov edx, [0x101c38fa] */
            ii(0x100e_61eb, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_61ee, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_61f0, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_61f3, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100e_61f7, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_61fa, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_61fc, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_61ff, 6); idiv(memd[ds, 0x101c_38c4]);            /* idiv dword [0x101c38c4] */
            ii(0x100e_6205, 6); mov(edx, memd[ds, 0x101c_38fc]);        /* mov edx, [0x101c38fc] */
            ii(0x100e_620b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_620e, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_6210, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_6213, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100e_6216, 1); push(eax);                              /* push eax */
            ii(0x100e_6217, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x100e_621c, 4); movsx(ebx, memw[ss, ebp - 4]);          /* movsx ebx, word [ebp-0x4] */
            ii(0x100e_6220, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100e_6224, 5); mov(eax, memd[ds, 0x101c_3630]);        /* mov eax, [0x101c3630] */
            ii(0x100e_6229, 5); call(0x100e_8d1e, 0x2af0);              /* call 0x100e8d1e */
            ii(0x100e_622e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_6230, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_6231, 1); pop(edi);                               /* pop edi */
            ii(0x100e_6232, 1); pop(esi);                               /* pop esi */
            ii(0x100e_6233, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_6234, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_6235, 1); ret();                                  /* ret */
        }
    }
}
