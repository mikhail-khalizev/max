using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_4a19-ffd9c93e")]
        public void Method_1007_4a19()
        {
            ii(0x1007_4a19, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1007_4a1e, 5);  call(Definitions.sys_check_available_stack_size, 0xf_132f);/* call 0x10165d52 */
            ii(0x1007_4a23, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_4a24, 1);  push(esi);                            /* push esi */
            ii(0x1007_4a25, 1);  push(edi);                            /* push edi */
            ii(0x1007_4a26, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_4a27, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_4a29, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1007_4a2f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_4a32, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_4a35, 3);  mov(memd[ss, ebp - 12], ebx);         /* mov [ebp-0xc], ebx */
            ii(0x1007_4a38, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1007_4a3b, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_4a3e, 5);  call(0x1007_5e64, 0x1421);            /* call 0x10075e64 */
            ii(0x1007_4a43, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1007_4a45, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_4a49, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x1007_4a4c, 6);  mov(ebx, memd[ds, eax + 0x101c_81c0]);/* mov ebx, [eax+0x101c81c0] */
            ii(0x1007_4a52, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1007_4a56, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1007_4a5a, 5);  call(0x1007_4955, -0x10a);            /* call 0x10074955 */
            ii(0x1007_4a5f, 3);  mov(memb[ss, ebp - 16], al);          /* mov [ebp-0x10], al */
            ii(0x1007_4a62, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x1007_4a65, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_4a67, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_4a68, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_4a69, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_4a6a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_4a6b, 1);  ret();                                /* ret */
        }
    }
}
