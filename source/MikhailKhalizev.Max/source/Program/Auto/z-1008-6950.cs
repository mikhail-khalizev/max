using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_6950-d54d3a87")]
        public void Method_1008_6950()
        {
            ii(0x1008_6950, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_6955, 5);  call(Definitions.sys_check_available_stack_size, 0xd_f3f8);/* call 0x10165d52 */
            ii(0x1008_695a, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_695b, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_695c, 1);  push(esi);                            /* push esi */
            ii(0x1008_695d, 1);  push(edi);                            /* push edi */
            ii(0x1008_695e, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_695f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_6961, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1008_6967, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_696a, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_696d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_6970, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_6973, 3);  add(eax, 0x16);                       /* add eax, 0x16 */
            ii(0x1008_6976, 5);  call(0x1008_9ca0, 0x3325);            /* call 0x10089ca0 */
            ii(0x1008_697b, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_697e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_6981, 3);  add(eax, 0x20);                       /* add eax, 0x20 */
            ii(0x1008_6984, 5);  call(0x1008_9ca0, 0x3317);            /* call 0x10089ca0 */
            ii(0x1008_6989, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_698c, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_698f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_6992, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x1008_6995, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_6998, 3);  call_abs(memd[ds, edx + 72]);         /* call dword [edx+0x48] */
            ii(0x1008_699b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_699d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_699e, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_699f, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_69a0, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_69a1, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_69a2, 1);  ret();                                /* ret */
        }
    }
}
