using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_3cfd-ab880b35")]
        public void Method_1007_3cfd()
        {
            ii(0x1007_3cfd, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_3d02, 5); call(Definitions.sys_check_available_stack_size, 0xf_204b); /* call 0x10165d52 */
            ii(0x1007_3d07, 1); push(ebx);                              /* push ebx */
            ii(0x1007_3d08, 1); push(ecx);                              /* push ecx */
            ii(0x1007_3d09, 1); push(esi);                              /* push esi */
            ii(0x1007_3d0a, 1); push(edi);                              /* push edi */
            ii(0x1007_3d0b, 1); push(ebp);                              /* push ebp */
            ii(0x1007_3d0c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_3d0e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_3d14, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_3d17, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1007_3d1a, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1007_3d1e, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x1007_3d23, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_3d26, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1007_3d29, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1007_3d2d, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1007_3d2f, 5); mov(eax, memd[ds, 0x101c_9454]);        /* mov eax, [0x101c9454] */
            ii(0x1007_3d34, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1007_3d36, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1007_3d38, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x1007_3d3a, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1007_3d3d, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1007_3d40, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_3d42, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_3d43, 1); pop(edi);                               /* pop edi */
            ii(0x1007_3d44, 1); pop(esi);                               /* pop esi */
            ii(0x1007_3d45, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_3d46, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_3d47, 1); ret();                                  /* ret */
        }
    }
}
