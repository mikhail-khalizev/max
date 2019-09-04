using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_b528-a8b29fc2")]
        public void Method_100e_b528()
        {
            ii(0x100e_b528, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100e_b52d, 5);  call(Definitions.sys_check_available_stack_size, 0x7_a820);/* call 0x10165d52 */
            ii(0x100e_b532, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_b533, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_b534, 1);  push(esi);                            /* push esi */
            ii(0x100e_b535, 1);  push(edi);                            /* push edi */
            ii(0x100e_b536, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_b537, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_b539, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100e_b53f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_b542, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_b545, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_b548, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x100e_b54b, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100e_b54e, 3);  sub(eax, memd[ds, edx + 4]);          /* sub eax, [edx+0x4] */
            ii(0x100e_b551, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_b553, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_b556, 3);  mov(eax, memd[ds, eax + 14]);         /* mov eax, [eax+0xe] */
            ii(0x100e_b559, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100e_b55c, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x100e_b55f, 2);  mov(ebx, edx);                        /* mov ebx, edx */
            ii(0x100e_b561, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_b564, 3);  mov(edx, memd[ds, eax + 22]);         /* mov edx, [eax+0x16] */
            ii(0x100e_b567, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_b56a, 2);  add(edx, memd[ds, eax]);              /* add edx, [eax] */
            ii(0x100e_b56c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_b56f, 2);  sub(edx, memd[ds, eax]);              /* sub edx, [eax] */
            ii(0x100e_b571, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_b574, 2);  add(edx, ebx);                        /* add edx, ebx */
            ii(0x100e_b576, 3);  mov(memd[ds, eax + 22], edx);         /* mov [eax+0x16], edx */
            ii(0x100e_b579, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_b57c, 4);  mov(dx, memw[ds, eax + 16]);          /* mov dx, [eax+0x10] */
            ii(0x100e_b580, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_b583, 4);  mov(memw[ds, eax + 16], dx);          /* mov [eax+0x10], dx */
            ii(0x100e_b587, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_b589, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_b58a, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_b58b, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_b58c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_b58d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_b58e, 1);  ret();                                /* ret */
        }
    }
}
