using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_5fdc-23bce2ac")]
        public void Method_1007_5fdc()
        {
            ii(0x1007_5fdc, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_5fe1, 5);  call(Definitions.sys_check_available_stack_size, 0xe_fd6c);/* call 0x10165d52 */
            ii(0x1007_5fe6, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_5fe7, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_5fe8, 1);  push(edx);                            /* push edx */
            ii(0x1007_5fe9, 1);  push(esi);                            /* push esi */
            ii(0x1007_5fea, 1);  push(edi);                            /* push edi */
            ii(0x1007_5feb, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_5fec, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_5fee, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1007_5ff4, 3);  mov(memb[ss, ebp - 4], al);           /* mov [ebp-0x4], al */
            ii(0x1007_5ff7, 4);  movsx(edx, memb[ss, ebp - 4]);        /* movsx edx, byte [ebp-0x4] */
            ii(0x1007_5ffb, 5);  mov(eax, 0x101c_39c8);                /* mov eax, 0x101c39c8 */
            ii(0x1007_6000, 5);  call(0x1010_61bb, 0x9_01b6);          /* call 0x101061bb */
            ii(0x1007_6005, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_6008, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_600b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_600d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_600e, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_600f, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_6010, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_6011, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_6012, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_6013, 1);  ret();                                /* ret */
        }
    }
}
