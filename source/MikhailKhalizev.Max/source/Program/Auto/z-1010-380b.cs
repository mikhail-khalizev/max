using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_380b-cb8b6381")]
        public void Method_1010_380b()
        {
            ii(0x1010_380b, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1010_3810, 5);  call(Definitions.sys_check_available_stack_size, 0x6_253d);/* call 0x10165d52 */
            ii(0x1010_3815, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_3816, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_3817, 1);  push(edx);                            /* push edx */
            ii(0x1010_3818, 1);  push(esi);                            /* push esi */
            ii(0x1010_3819, 1);  push(edi);                            /* push edi */
            ii(0x1010_381a, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_381b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_381d, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1010_3823, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_3826, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1010_382d, 2);  jmp(0x1010_3835, 6); goto l_0x1010_3835;/* jmp 0x10103835 */
        l_0x1010_382f:
            ii(0x1010_382f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_3832, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
        l_0x1010_3835:
            ii(0x1010_3835, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_3838, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_383b, 3);  cmp(ax, memw[ds, edx]);               /* cmp ax, [edx] */
            ii(0x1010_383e, 2);  if(jge(0x1010_3856, 0x16)) goto l_0x1010_3856;/* jge 0x10103856 */
            ii(0x1010_3840, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_3844, 3);  imul(edx, eax, 0xa);                  /* imul edx, eax, 0xa */
            ii(0x1010_3847, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_384a, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x1010_384d, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1010_384f, 5);  call(0x1013_a6f4, 0x3_6ea0);          /* call 0x1013a6f4 */
            ii(0x1010_3854, 2);  jmp(0x1010_382f, -0x27); goto l_0x1010_382f;/* jmp 0x1010382f */
        l_0x1010_3856:
            ii(0x1010_3856, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_3858, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_3859, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_385a, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_385b, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_385c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_385d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_385e, 1);  ret();                                /* ret */
        }
    }
}
