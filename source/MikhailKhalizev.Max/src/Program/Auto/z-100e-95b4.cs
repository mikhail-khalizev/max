using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_95b4-b24c95cf")]
        public void Method_100e_95b4()
        {
            ii(0x100e_95b4, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100e_95b9, 5);  call(Definitions.sys_check_available_stack_size, 0x7_c794);/* call 0x10165d52 */
            ii(0x100e_95be, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_95bf, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_95c0, 1);  push(edx);                            /* push edx */
            ii(0x100e_95c1, 1);  push(esi);                            /* push esi */
            ii(0x100e_95c2, 1);  push(edi);                            /* push edi */
            ii(0x100e_95c3, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_95c4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_95c6, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100e_95cc, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_95cf, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x100e_95d6, 2);  jmp(0x100e_95de, 6); goto l_0x100e_95de;/* jmp 0x100e95de */
        l_0x100e_95d8:
            ii(0x100e_95d8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_95db, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
        l_0x100e_95de:
            ii(0x100e_95de, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_95e1, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100e_95e4, 4);  cmp(ax, memw[ds, edx + 2]);           /* cmp ax, [edx+0x2] */
            ii(0x100e_95e8, 2);  if(jge(0x100e_9604, 0x1a)) goto l_0x100e_9604;/* jge 0x100e9604 */
            ii(0x100e_95ea, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100e_95ee, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100e_95f1, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_95f3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_95f6, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x100e_95f9, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100e_95fb, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100e_95fd, 5);  call(Definitions.sys_display_draw_3, 0x8_0212);/* call 0x10169814 */
            ii(0x100e_9602, 2);  jmp(0x100e_95d8, -0x2c); goto l_0x100e_95d8;/* jmp 0x100e95d8 */
        l_0x100e_9604:
            ii(0x100e_9604, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_9606, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_9607, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_9608, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_9609, 1);  pop(edx);                             /* pop edx */
            ii(0x100e_960a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_960b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_960c, 1);  ret();                                /* ret */
        }
    }
}
