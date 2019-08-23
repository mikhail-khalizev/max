using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_49d4-60139354")]
        public void Method_1007_49d4()
        {
            ii(0x1007_49d4, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_49d9, 5); call(Definitions.sys_check_available_stack_size, 0xf_1374); /* call 0x10165d52 */
            ii(0x1007_49de, 1); push(ebx);                              /* push ebx */
            ii(0x1007_49df, 1); push(ecx);                              /* push ecx */
            ii(0x1007_49e0, 1); push(esi);                              /* push esi */
            ii(0x1007_49e1, 1); push(edi);                              /* push edi */
            ii(0x1007_49e2, 1); push(ebp);                              /* push ebp */
            ii(0x1007_49e3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_49e5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_49eb, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_49ee, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_49f1, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1007_49f5, 3); imul(edx, edx, 0x33);                   /* imul edx, edx, 0x33 */
            ii(0x1007_49f8, 6); mov(ebx, memd[ds, edx + 0x101c_81c0]);  /* mov ebx, [edx+0x101c81c0] */
            ii(0x1007_49fe, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1007_4a02, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1007_4a06, 5); call(0x1007_486b, -0x1a0);              /* call 0x1007486b */
            ii(0x1007_4a0b, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x1007_4a0e, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1007_4a11, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_4a13, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_4a14, 1); pop(edi);                               /* pop edi */
            ii(0x1007_4a15, 1); pop(esi);                               /* pop esi */
            ii(0x1007_4a16, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_4a17, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_4a18, 1); ret();                                  /* ret */
        }
    }
}
