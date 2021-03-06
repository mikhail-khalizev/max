using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_4674-d115f8ab")]
        public void Method_1014_4674()
        {
            ii(0x1014_4674, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1014_4679, 5);  call(Definitions.sys_check_available_stack_size, 0x2_16d4);/* call 0x10165d52 */
            ii(0x1014_467e, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_467f, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_4680, 1);  push(esi);                            /* push esi */
            ii(0x1014_4681, 1);  push(edi);                            /* push edi */
            ii(0x1014_4682, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_4683, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_4685, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1014_468b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_468e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_4691, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_4694, 3);  mov(eax, memd[ds, eax + 62]);         /* mov eax, [eax+0x3e] */
            ii(0x1014_4697, 5);  call(0x100c_fbbe, -0x7_4ade);         /* call 0x100cfbbe */
            ii(0x1014_469c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_469f, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_46a2, 7);  add(memw[ds, edx + 342], ax);         /* add [edx+0x156], ax */
            ii(0x1014_46a9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_46ac, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_46af, 7);  sub(memw[ds, edx + 348], ax);         /* sub [edx+0x15c], ax */
            ii(0x1014_46b6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_46b9, 3);  add(eax, 0x4e);                       /* add eax, 0x4e */
            ii(0x1014_46bc, 5);  call(0x1007_6884, -0xc_de3d);         /* call 0x10076884 */
            ii(0x1014_46c1, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_46c3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_46c6, 4);  add(memw[ds, edx + 10], ax);          /* add [edx+0xa], ax */
            ii(0x1014_46ca, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_46cd, 5);  call(0x1014_3d54, -0x97e);            /* call 0x10143d54 */
            ii(0x1014_46d2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_46d4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_46d5, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_46d6, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_46d7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_46d8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_46d9, 1);  ret();                                /* ret */
        }
    }
}
