using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_d409-a74e34a5")]
        public void Method_1013_d409()
        {
            ii(0x1013_d409, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1013_d40e, 5);  call(Definitions.sys_check_available_stack_size, 0x2_893f);/* call 0x10165d52 */
            ii(0x1013_d413, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_d414, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_d415, 1);  push(esi);                            /* push esi */
            ii(0x1013_d416, 1);  push(edi);                            /* push edi */
            ii(0x1013_d417, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_d418, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_d41a, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1013_d420, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_d423, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1013_d426, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1013_d42a, 2);  if(jz(0x1013_d456, 0x2a)) goto l_0x1013_d456;/* jz 0x1013d456 */
            ii(0x1013_d42c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_d42f, 4);  cmp(memd[ds, eax + 4], 0);            /* cmp dword [eax+0x4], 0x0 */
            ii(0x1013_d433, 2);  if(jz(0x1013_d456, 0x21)) goto l_0x1013_d456;/* jz 0x1013d456 */
            ii(0x1013_d435, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_d438, 3);  mov(edx, memd[ds, eax + 4]);          /* mov edx, [eax+0x4] */
            ii(0x1013_d43b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_d43e, 5);  call(0x1013_ce3f, -0x604);            /* call 0x1013ce3f */
            ii(0x1013_d443, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_d446, 7);  mov(memd[ds, eax + 4], 0);            /* mov dword [eax+0x4], 0x0 */
            ii(0x1013_d44d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_d450, 6);  mov(memw[ds, eax + 16], 0xffff);      /* mov word [eax+0x10], 0xffff */
        l_0x1013_d456:
            ii(0x1013_d456, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_d458, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_d459, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_d45a, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_d45b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_d45c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_d45d, 1);  ret();                                /* ret */
        }
    }
}
