using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_ae08-c8ccafa0")]
        public void Method_100e_ae08()
        {
            ii(0x100e_ae08, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100e_ae0d, 5);  call(Definitions.sys_check_available_stack_size, 0x7_af40);/* call 0x10165d52 */
            ii(0x100e_ae12, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_ae13, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_ae14, 1);  push(esi);                            /* push esi */
            ii(0x100e_ae15, 1);  push(edi);                            /* push edi */
            ii(0x100e_ae16, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_ae17, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_ae19, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100e_ae1f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_ae22, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_ae25, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_ae28, 2);  mov(ebx, memd[ds, eax]);              /* mov ebx, [eax] */
            ii(0x100e_ae2a, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100e_ae2d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100e_ae30, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_ae33, 5);  call(0x100e_ae40, 8);                 /* call 0x100eae40 */
            ii(0x100e_ae38, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_ae3a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_ae3b, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_ae3c, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_ae3d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_ae3e, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_ae3f, 1);  ret();                                /* ret */
        }
    }
}
