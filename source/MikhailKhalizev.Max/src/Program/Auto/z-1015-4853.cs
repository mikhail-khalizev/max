using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_4853-8a63f3b4")]
        public void Method_1015_4853()
        {
            ii(0x1015_4853, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1015_4858, 5);  call(Definitions.sys_check_available_stack_size, 0x1_14f5);/* call 0x10165d52 */
            ii(0x1015_485d, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_485e, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_485f, 1);  push(edx);                            /* push edx */
            ii(0x1015_4860, 1);  push(esi);                            /* push esi */
            ii(0x1015_4861, 1);  push(edi);                            /* push edi */
            ii(0x1015_4862, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_4863, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_4865, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1015_486b, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1015_486e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_4871, 6);  mov(edx, memd[ds, eax + 213]);        /* mov edx, [eax+0xd5] */
            ii(0x1015_4877, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1015_487a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_487d, 3);  mov(eax, memd[ds, eax + 57]);         /* mov eax, [eax+0x39] */
            ii(0x1015_4880, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1015_4883, 1);  inc(edx);                             /* inc edx */
            ii(0x1015_4884, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1015_4886, 2);  if(jle(0x1015_489b, 0x13)) goto l_0x1015_489b;/* jle 0x1015489b */
            ii(0x1015_4888, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_488b, 3);  mov(edx, memd[ds, eax + 51]);         /* mov edx, [eax+0x33] */
            ii(0x1015_488e, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1015_4891, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_4894, 5);  call(0x1014_9b9b, -0xacfe);           /* call 0x10149b9b */
            ii(0x1015_4899, 2);  jmp(0x1015_48b1, 0x16); goto l_0x1015_48b1;/* jmp 0x101548b1 */
        l_0x1015_489b:
            ii(0x1015_489b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_489e, 7);  mov(ax, memw[ds, eax + 215]);         /* mov ax, [eax+0xd7] */
            ii(0x1015_48a5, 1);  inc(eax);                             /* inc eax */
            ii(0x1015_48a6, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1015_48a9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_48ac, 5);  call(0x1014_9b9b, -0xad16);           /* call 0x10149b9b */
        l_0x1015_48b1:
            ii(0x1015_48b1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_48b3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_48b4, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_48b5, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_48b6, 1);  pop(edx);                             /* pop edx */
            ii(0x1015_48b7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_48b8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_48b9, 1);  ret();                                /* ret */
        }
    }
}
