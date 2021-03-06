using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_cb93-be81f111")]
        public void Method_1007_cb93()
        {
            ii(0x1007_cb93, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1007_cb98, 5);  call(Definitions.sys_check_available_stack_size, 0xe_91b5);/* call 0x10165d52 */
            ii(0x1007_cb9d, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_cb9e, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_cb9f, 1);  push(esi);                            /* push esi */
            ii(0x1007_cba0, 1);  push(edi);                            /* push edi */
            ii(0x1007_cba1, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_cba2, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_cba4, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1007_cbaa, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_cbad, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_cbb0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_cbb3, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1007_cbb6, 5);  call(0x1007_6408, -0x67b3);           /* call 0x10076408 */
            ii(0x1007_cbbb, 3);  cmp(eax, memd[ss, ebp - 4]);          /* cmp eax, [ebp-0x4] */
            ii(0x1007_cbbe, 2);  if(jnz(0x1007_cbc8, 8)) goto l_0x1007_cbc8;/* jnz 0x1007cbc8 */
            ii(0x1007_cbc0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_cbc3, 5);  call(0x1007_ce58, 0x290);             /* call 0x1007ce58 */
        l_0x1007_cbc8:
            ii(0x1007_cbc8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_cbca, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_cbcb, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_cbcc, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_cbcd, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_cbce, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_cbcf, 1);  ret();                                /* ret */
        }
    }
}
