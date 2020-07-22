using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_ac11-4db16e3a")]
        public void Method_1011_ac11()
        {
            ii(0x1011_ac11, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1011_ac16, 5);  call(Definitions.sys_check_available_stack_size, 0x4_b137);/* call 0x10165d52 */
            ii(0x1011_ac1b, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_ac1c, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_ac1d, 1);  push(esi);                            /* push esi */
            ii(0x1011_ac1e, 1);  push(edi);                            /* push edi */
            ii(0x1011_ac1f, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_ac20, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_ac22, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1011_ac28, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_ac2b, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_ac2e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ac31, 3);  mov(edx, memd[ds, eax + 20]);         /* mov edx, [eax+0x14] */
            ii(0x1011_ac34, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1011_ac37, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ac3a, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1011_ac3d, 5);  call(0x100b_82bc, -0x6_2986);         /* call 0x100b82bc */
            ii(0x1011_ac42, 1);  cwde();                               /* cwde */
            ii(0x1011_ac43, 1);  inc(edx);                             /* inc edx */
            ii(0x1011_ac44, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1011_ac46, 2);  if(jge(0x1011_ac9b, 0x53)) goto l_0x1011_ac9b;/* jge 0x1011ac9b */
            ii(0x1011_ac48, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ac4b, 4);  mov(ax, memw[ds, eax + 22]);          /* mov ax, [eax+0x16] */
            ii(0x1011_ac4f, 1);  inc(eax);                             /* inc eax */
            ii(0x1011_ac50, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1011_ac53, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ac56, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1011_ac59, 5);  call(0x100b_827c, -0x6_29e2);         /* call 0x100b827c */
            ii(0x1011_ac5e, 4);  movsx(ax, memb[ds, eax]);             /* movsx ax, byte [eax] */
            ii(0x1011_ac62, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_ac65, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ac68, 4);  mov(ax, memw[ds, eax + 22]);          /* mov ax, [eax+0x16] */
            ii(0x1011_ac6c, 1);  inc(eax);                             /* inc eax */
            ii(0x1011_ac6d, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1011_ac70, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ac73, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1011_ac76, 5);  call(0x100b_827c, -0x6_29ff);         /* call 0x100b827c */
            ii(0x1011_ac7b, 5);  movsx(ax, memb[ds, eax + 1]);         /* movsx ax, byte [eax+0x1] */
            ii(0x1011_ac80, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_ac83, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1011_ac87, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1011_ac8b, 5);  call(0x1011_9e3a, -0xe56);            /* call 0x10119e3a */
            ii(0x1011_ac90, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1011_ac93, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_ac96, 5);  call(0x1011_7fb8, -0x2ce3);           /* call 0x10117fb8 */
        l_0x1011_ac9b:
            ii(0x1011_ac9b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_ac9d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_ac9e, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_ac9f, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_aca0, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_aca1, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_aca2, 1);  ret();                                /* ret */
        }
    }
}
