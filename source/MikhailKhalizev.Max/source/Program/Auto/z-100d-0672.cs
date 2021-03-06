using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_0672-dbe45bee")]
        public void Method_100d_0672()
        {
            ii(0x100d_0672, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100d_0677, 5);  call(Definitions.sys_check_available_stack_size, 0x9_56d6);/* call 0x10165d52 */
            ii(0x100d_067c, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_067d, 1);  push(esi);                            /* push esi */
            ii(0x100d_067e, 1);  push(edi);                            /* push edi */
            ii(0x100d_067f, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_0680, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_0682, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100d_0688, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_068b, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100d_068e, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100d_0691, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_0694, 3);  add(eax, 0x1e);                       /* add eax, 0x1e */
            ii(0x100d_0697, 5);  call(Definitions.my_2_get_count, -0x4_5334);/* call 0x1008b368 */
            ii(0x100d_069c, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x100d_06a0, 2);  if(jge(0x100d_06b0, 0xe)) goto l_0x100d_06b0;/* jge 0x100d06b0 */
            ii(0x100d_06a2, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_06a5, 3);  add(eax, 0x1e);                       /* add eax, 0x1e */
            ii(0x100d_06a8, 5);  call(Definitions.my_2_get_count, -0x4_5345);/* call 0x1008b368 */
            ii(0x100d_06ad, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
        l_0x100d_06b0:
            ii(0x100d_06b0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_06b3, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100d_06b6, 4);  mov(memw[ds, edx + 38], ax);          /* mov [edx+0x26], ax */
            ii(0x100d_06ba, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100d_06be, 3);  lea(edx, memd[ss, ebp - 8]);          /* lea edx, [ebp-0x8] */
            ii(0x100d_06c1, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_06c4, 3);  add(eax, 0x1e);                       /* add eax, 0x1e */
            ii(0x100d_06c7, 5);  call(0x1008_b2ec, -0x4_53e0);         /* call 0x1008b2ec */
            ii(0x100d_06cc, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_06ce, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_06d1, 5);  call(0x100d_0617, -0xbf);             /* call 0x100d0617 */
            ii(0x100d_06d6, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_06d9, 3);  mov(edx, memd[ds, eax + 36]);         /* mov edx, [eax+0x24] */
            ii(0x100d_06dc, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100d_06df, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_06e2, 5);  call(0x100d_01a3, -0x544);            /* call 0x100d01a3 */
            ii(0x100d_06e7, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_06ea, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_06ed, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_06f0, 3);  mov(edx, memd[ds, eax + 64]);         /* mov edx, [eax+0x40] */
            ii(0x100d_06f3, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_06f6, 3);  call_abs(memd[ds, edx + 16]);         /* call dword [edx+0x10] */
            ii(0x100d_06f9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_06fb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_06fc, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_06fd, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_06fe, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_06ff, 1);  ret();                                /* ret */
        }
    }
}
