using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_95e8-bd3c16b2")]
        public void Method_1009_95e8()
        {
            ii(0x1009_95e8, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1009_95ed, 5);  call(Definitions.sys_check_available_stack_size, 0xc_c760);/* call 0x10165d52 */
            ii(0x1009_95f2, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_95f3, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_95f4, 1);  push(esi);                            /* push esi */
            ii(0x1009_95f5, 1);  push(edi);                            /* push edi */
            ii(0x1009_95f6, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_95f7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_95f9, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1009_95ff, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_9602, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_9605, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_9608, 3);  add(edx, 0x15);                       /* add edx, 0x15 */
            ii(0x1009_960b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_960e, 5);  call(0x1007_6d98, -0x2_287b);         /* call 0x10076d98 */
            ii(0x1009_9613, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_9615, 2);  if(jz(0x1009_9634, 0x1d)) goto l_0x1009_9634;/* jz 0x10099634 */
            ii(0x1009_9617, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_961a, 4);  cmp(memb[ds, eax + 29], 3);           /* cmp byte [eax+0x1d], 0x3 */
            ii(0x1009_961e, 2);  if(jg(0x1009_9627, 7)) goto l_0x1009_9627;/* jg 0x10099627 */
            ii(0x1009_9620, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_9623, 4);  mov(memb[ds, eax + 29], 0);           /* mov byte [eax+0x1d], 0x0 */
        l_0x1009_9627:
            ii(0x1009_9627, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_9629, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_962c, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1009_962f, 5);  call(0x1007_6630, -0x2_3004);         /* call 0x10076630 */
        l_0x1009_9634:
            ii(0x1009_9634, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_9636, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_9637, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_9638, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_9639, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_963a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_963b, 1);  ret();                                /* ret */
        }
    }
}
