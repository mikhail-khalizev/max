using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_9684-5b964eb1")]
        public void Method_100a_9684()
        {
            ii(0x100a_9684, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100a_9689, 5);  call(Definitions.sys_check_available_stack_size, 0xb_c6c4);/* call 0x10165d52 */
            ii(0x100a_968e, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_968f, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_9690, 1);  push(edx);                            /* push edx */
            ii(0x100a_9691, 1);  push(esi);                            /* push esi */
            ii(0x100a_9692, 1);  push(edi);                            /* push edi */
            ii(0x100a_9693, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_9694, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_9696, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100a_969c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_969f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_96a2, 4);  mov(ax, memw[ds, eax + 2]);           /* mov ax, [eax+0x2] */
            ii(0x100a_96a6, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_96a9, 4);  sub(ax, memw[ds, edx + 4]);           /* sub ax, [edx+0x4] */
            ii(0x100a_96ad, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_96b0, 4);  mov(memw[ds, edx + 10], ax);          /* mov [edx+0xa], ax */
            ii(0x100a_96b4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_96b7, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x100a_96ba, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100a_96bd, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_96bf, 2);  if(jge(0x100a_96ca, 9)) goto l_0x100a_96ca;/* jge 0x100a96ca */
            ii(0x100a_96c1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_96c4, 6);  mov(memw[ds, eax + 10], 0);           /* mov word [eax+0xa], 0x0 */
        l_0x100a_96ca:
            ii(0x100a_96ca, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_96cd, 5);  call(0x100a_9742, 0x70);              /* call 0x100a9742 */
            ii(0x100a_96d2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_96d4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_96d5, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_96d6, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_96d7, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_96d8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_96d9, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_96da, 1);  ret();                                /* ret */
        }
    }
}
