using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_7f86-c9b2b440")]
        public void Method_1007_7f86()
        {
            ii(0x1007_7f86, 5); push(0x28);                             /* push 0x28 */
            ii(0x1007_7f8b, 5); call(Definitions.sys_check_available_stack_size, 0xe_ddc2); /* call 0x10165d52 */
            ii(0x1007_7f90, 1); push(ebx);                              /* push ebx */
            ii(0x1007_7f91, 1); push(ecx);                              /* push ecx */
            ii(0x1007_7f92, 1); push(esi);                              /* push esi */
            ii(0x1007_7f93, 1); push(edi);                              /* push edi */
            ii(0x1007_7f94, 1); push(ebp);                              /* push ebp */
            ii(0x1007_7f95, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_7f97, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_7f9d, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_7fa0, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1007_7fa3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_7fa6, 5); call(0x1007_623c, -0x1d6f);             /* call 0x1007623c */
            ii(0x1007_7fab, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1007_7fae, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1007_7fb1, 3); mov(edx, memd[ds, eax + 8]);            /* mov edx, [eax+0x8] */
            ii(0x1007_7fb4, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_7fb7, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1007_7fbb, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1007_7fbd, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_7fc0, 3); mov(al, memb[ds, eax + 77]);            /* mov al, [eax+0x4d] */
            ii(0x1007_7fc3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_7fc8, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1007_7fca, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_7fcc, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1007_7fcf, 3); mov(edx, memd[ds, edx + 6]);            /* mov edx, [edx+0x6] */
            ii(0x1007_7fd2, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_7fd5, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1007_7fd8, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1007_7fdb, 3); mov(ebx, memd[ds, eax + 8]);            /* mov ebx, [eax+0x8] */
            ii(0x1007_7fde, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1007_7fe1, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_7fe3, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_7fe6, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1007_7fe8, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1007_7feb, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1007_7fee, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_7ff0, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_7ff1, 1); pop(edi);                               /* pop edi */
            ii(0x1007_7ff2, 1); pop(esi);                               /* pop esi */
            ii(0x1007_7ff3, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_7ff4, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_7ff5, 1); ret();                                  /* ret */
        }
    }
}
