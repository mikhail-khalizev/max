using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_84cf-9731c752")]
        public void Method_1015_84cf()
        {
            ii(0x1015_84cf, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1015_84d4, 5);  call(Definitions.sys_check_available_stack_size, 0xd879);/* call 0x10165d52 */
            ii(0x1015_84d9, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_84da, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_84db, 1);  push(esi);                            /* push esi */
            ii(0x1015_84dc, 1);  push(edi);                            /* push edi */
            ii(0x1015_84dd, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_84de, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_84e0, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1015_84e6, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_84e9, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_84ec, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_84ef, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1015_84f2, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1015_84f7, 5);  call(0x100f_448c, -0x6_4070);         /* call 0x100f448c */
            ii(0x1015_84fc, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_84ff, 4);  cmp(memb[ds, eax + 86], 0);           /* cmp byte [eax+0x56], 0x0 */
            ii(0x1015_8503, 2);  if(jnz(0x1015_850b, 6)) goto l_0x1015_850b;/* jnz 0x1015850b */
            ii(0x1015_8505, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_8509, 2);  jmp(0x1015_850f, 4); goto l_0x1015_850f;/* jmp 0x1015850f */
        l_0x1015_850b:
            ii(0x1015_850b, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x1015_850f:
            ii(0x1015_850f, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1015_8512, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1015_8515, 3);  mov(memb[ds, edx + 86], al);          /* mov [edx+0x56], al */
            ii(0x1015_8518, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_851b, 4);  mov(memb[ds, eax + 87], 0);           /* mov byte [eax+0x57], 0x0 */
            ii(0x1015_851f, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_8522, 4);  mov(memb[ds, eax + 85], 0);           /* mov byte [eax+0x55], 0x0 */
            ii(0x1015_8526, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_8528, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_8529, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_852a, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_852b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_852c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_852d, 1);  ret();                                /* ret */
        }
    }
}
