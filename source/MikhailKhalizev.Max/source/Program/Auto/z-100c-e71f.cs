using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_e71f-13644425")]
        public void Method_100c_e71f()
        {
            ii(0x100c_e71f, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100c_e724, 5);  call(Definitions.sys_check_available_stack_size, 0x9_7629);/* call 0x10165d52 */
            ii(0x100c_e729, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_e72a, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_e72b, 1);  push(edx);                            /* push edx */
            ii(0x100c_e72c, 1);  push(esi);                            /* push esi */
            ii(0x100c_e72d, 1);  push(edi);                            /* push edi */
            ii(0x100c_e72e, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_e72f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_e731, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100c_e737, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_e73a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_e73d, 4);  cmp(memd[ds, eax + 12], 0);           /* cmp dword [eax+0xc], 0x0 */
            ii(0x100c_e741, 2);  if(jz(0x100c_e74e, 0xb)) goto l_0x100c_e74e;/* jz 0x100ce74e */
            ii(0x100c_e743, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_e746, 3);  mov(eax, memd[ds, eax + 12]);         /* mov eax, [eax+0xc] */
            ii(0x100c_e749, 5);  call(0x100d_811c, 0x99ce);            /* call 0x100d811c */
        l_0x100c_e74e:
            ii(0x100c_e74e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_e751, 4);  cmp(memd[ds, eax + 16], 0);           /* cmp dword [eax+0x10], 0x0 */
            ii(0x100c_e755, 2);  if(jz(0x100c_e762, 0xb)) goto l_0x100c_e762;/* jz 0x100ce762 */
            ii(0x100c_e757, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_e75a, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x100c_e75d, 5);  call(0x100d_811c, 0x99ba);            /* call 0x100d811c */
        l_0x100c_e762:
            ii(0x100c_e762, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_e765, 4);  cmp(memd[ds, eax + 20], 0);           /* cmp dword [eax+0x14], 0x0 */
            ii(0x100c_e769, 2);  if(jz(0x100c_e776, 0xb)) goto l_0x100c_e776;/* jz 0x100ce776 */
            ii(0x100c_e76b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_e76e, 3);  mov(eax, memd[ds, eax + 20]);         /* mov eax, [eax+0x14] */
            ii(0x100c_e771, 5);  call(0x100d_811c, 0x99a6);            /* call 0x100d811c */
        l_0x100c_e776:
            ii(0x100c_e776, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_e779, 4);  cmp(memd[ds, eax + 24], 0);           /* cmp dword [eax+0x18], 0x0 */
            ii(0x100c_e77d, 2);  if(jz(0x100c_e78a, 0xb)) goto l_0x100c_e78a;/* jz 0x100ce78a */
            ii(0x100c_e77f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_e782, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x100c_e785, 5);  call(0x100d_811c, 0x9992);            /* call 0x100d811c */
        l_0x100c_e78a:
            ii(0x100c_e78a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_e78c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_e78d, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_e78e, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_e78f, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_e790, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_e791, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_e792, 1);  ret();                                /* ret */
        }
    }
}
