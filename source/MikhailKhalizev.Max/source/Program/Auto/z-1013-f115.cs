using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_f115-cbcaa326")]
        public void Method_1013_f115()
        {
            ii(0x1013_f115, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_f11a, 5);  call(Definitions.sys_check_available_stack_size, 0x2_6c33);/* call 0x10165d52 */
            ii(0x1013_f11f, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_f120, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_f121, 1);  push(edx);                            /* push edx */
            ii(0x1013_f122, 1);  push(esi);                            /* push esi */
            ii(0x1013_f123, 1);  push(edi);                            /* push edi */
            ii(0x1013_f124, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_f125, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_f127, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1013_f12d, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
        l_0x1013_f130:
            ii(0x1013_f130, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_f133, 3);  cmp(memd[ds, eax], 0);                /* cmp dword [eax], 0x0 */
            ii(0x1013_f136, 2);  if(jz(0x1013_f16c, 0x34)) goto l_0x1013_f16c;/* jz 0x1013f16c */
            ii(0x1013_f138, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_f13b, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1013_f13d, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_f140, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_f143, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1013_f145, 3);  mov(eax, memd[ds, eax + 2]);          /* mov eax, [eax+0x2] */
            ii(0x1013_f148, 5);  call(Definitions.sys_delete, 0x2_6e17);/* call 0x10165f64 */
            ii(0x1013_f14d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_f150, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1013_f152, 5);  call(Definitions.sys_delete, 0x2_6e0d);/* call 0x10165f64 */
            ii(0x1013_f157, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_f15a, 3);  mov(edx, memd[ds, eax + 4]);          /* mov edx, [eax+0x4] */
            ii(0x1013_f15d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_f160, 2);  mov(memd[ds, eax], edx);              /* mov [eax], edx */
            ii(0x1013_f162, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_f165, 5);  call(Definitions.sys_delete, 0x2_6dfa);/* call 0x10165f64 */
            ii(0x1013_f16a, 2);  jmp(0x1013_f130, -0x3c); goto l_0x1013_f130;/* jmp 0x1013f130 */
        l_0x1013_f16c:
            ii(0x1013_f16c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_f16f, 7);  mov(memd[ds, eax + 4], 0);            /* mov dword [eax+0x4], 0x0 */
            ii(0x1013_f176, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_f178, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_f179, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_f17a, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_f17b, 1);  pop(edx);                             /* pop edx */
            ii(0x1013_f17c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_f17d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_f17e, 1);  ret();                                /* ret */
        }
    }
}
