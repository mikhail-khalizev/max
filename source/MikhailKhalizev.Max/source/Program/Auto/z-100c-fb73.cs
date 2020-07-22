using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_fb73-70c5547e")]
        public void Method_100c_fb73()
        {
            ii(0x100c_fb73, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100c_fb78, 5);  call(Definitions.sys_check_available_stack_size, 0x9_61d5);/* call 0x10165d52 */
            ii(0x100c_fb7d, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_fb7e, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_fb7f, 1);  push(esi);                            /* push esi */
            ii(0x100c_fb80, 1);  push(edi);                            /* push edi */
            ii(0x100c_fb81, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_fb82, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_fb84, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100c_fb8a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_fb8d, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x100c_fb90, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_fb93, 3);  cmp(memd[ds, eax], 0);                /* cmp dword [eax], 0x0 */
            ii(0x100c_fb96, 2);  if(jz(0x100c_fbb6, 0x1e)) goto l_0x100c_fbb6;/* jz 0x100cfbb6 */
            ii(0x100c_fb98, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100c_fb9a, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100c_fb9c, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x100c_fb9f, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_fba2, 2);  mov(ecx, memd[ds, edx]);              /* mov ecx, [edx] */
            ii(0x100c_fba4, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_fba6, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x100c_fba8, 5);  call(/* sys */ 0x1016_98f4, 0x9_9d47);/* call 0x101698f4 */
            ii(0x100c_fbad, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x100c_fbb0, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_fbb3, 3);  mov(memb[ds, edx + 55], al);          /* mov [edx+0x37], al */
        l_0x100c_fbb6:
            ii(0x100c_fbb6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_fbb8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_fbb9, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_fbba, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_fbbb, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_fbbc, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_fbbd, 1);  ret();                                /* ret */
        }
    }
}
