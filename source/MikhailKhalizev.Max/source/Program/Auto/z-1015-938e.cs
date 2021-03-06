using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_938e-b3de70da")]
        public void Method_1015_938e()
        {
            ii(0x1015_938e, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1015_9393, 5);  call(Definitions.sys_check_available_stack_size, 0xc9ba);/* call 0x10165d52 */
            ii(0x1015_9398, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_9399, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_939a, 1);  push(edx);                            /* push edx */
            ii(0x1015_939b, 1);  push(esi);                            /* push esi */
            ii(0x1015_939c, 1);  push(edi);                            /* push edi */
            ii(0x1015_939d, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_939e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_93a0, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1015_93a6, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1015_93a9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_93ac, 4);  cmp(memb[ds, eax + 61], 4);           /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1015_93b0, 2);  if(jnz(0x1015_93bb, 9)) goto l_0x1015_93bb;/* jnz 0x101593bb */
            ii(0x1015_93b2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_93b5, 4);  cmp(memb[ds, eax + 62], 0x1f);        /* cmp byte [eax+0x3e], 0x1f */
            ii(0x1015_93b9, 2);  if(jz(0x1015_93bd, 2)) goto l_0x1015_93bd;/* jz 0x101593bd */
        l_0x1015_93bb:
            ii(0x1015_93bb, 2);  jmp(0x1015_93c3, 6); goto l_0x1015_93c3;/* jmp 0x101593c3 */
        l_0x1015_93bd:
            ii(0x1015_93bd, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x1015_93c1, 2);  jmp(0x1015_93ce, 0xb); goto l_0x1015_93ce;/* jmp 0x101593ce */
        l_0x1015_93c3:
            ii(0x1015_93c3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_93c6, 5);  call(0x1015_7c72, -0x1759);           /* call 0x10157c72 */
            ii(0x1015_93cb, 3);  mov(memb[ss, ebp - 8], al);           /* mov [ebp-0x8], al */
        l_0x1015_93ce:
            ii(0x1015_93ce, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1015_93d1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_93d3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_93d4, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_93d5, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_93d6, 1);  pop(edx);                             /* pop edx */
            ii(0x1015_93d7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_93d8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_93d9, 1);  ret();                                /* ret */
        }
    }
}
