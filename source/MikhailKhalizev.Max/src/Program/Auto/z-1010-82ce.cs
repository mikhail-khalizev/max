using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_82ce-eec23fd1")]
        public void Method_1010_82ce()
        {
            ii(0x1010_82ce, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1010_82d3, 5);  call(Definitions.sys_check_available_stack_size, 0x5_da7a);/* call 0x10165d52 */
            ii(0x1010_82d8, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_82d9, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_82da, 1);  push(esi);                            /* push esi */
            ii(0x1010_82db, 1);  push(edi);                            /* push edi */
            ii(0x1010_82dc, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_82dd, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_82df, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1010_82e5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_82e8, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1010_82eb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_82ee, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x1010_82f1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_82f4, 2);  cmp(edx, memd[ds, eax]);              /* cmp edx, [eax] */
            ii(0x1010_82f6, 2);  if(jl(0x1010_8306, 0xe)) goto l_0x1010_8306;/* jl 0x10108306 */
            ii(0x1010_82f8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_82fb, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x1010_82fe, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_8301, 3);  cmp(edx, memd[ds, eax + 8]);          /* cmp edx, [eax+0x8] */
            ii(0x1010_8304, 2);  if(jl(0x1010_8308, 2)) goto l_0x1010_8308;/* jl 0x10108308 */
        l_0x1010_8306:
            ii(0x1010_8306, 2);  jmp(0x1010_8318, 0x10); goto l_0x1010_8318;/* jmp 0x10108318 */
        l_0x1010_8308:
            ii(0x1010_8308, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_830b, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1010_830d, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1010_8310, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_8313, 3);  cmp(edx, memd[ds, eax + 4]);          /* cmp edx, [eax+0x4] */
            ii(0x1010_8316, 2);  if(jge(0x1010_831a, 2)) goto l_0x1010_831a;/* jge 0x1010831a */
        l_0x1010_8318:
            ii(0x1010_8318, 2);  jmp(0x1010_832a, 0x10); goto l_0x1010_832a;/* jmp 0x1010832a */
        l_0x1010_831a:
            ii(0x1010_831a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_831d, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1010_831f, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1010_8322, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_8325, 3);  cmp(edx, memd[ds, eax + 12]);         /* cmp edx, [eax+0xc] */
            ii(0x1010_8328, 2);  if(jl(0x1010_832c, 2)) goto l_0x1010_832c;/* jl 0x1010832c */
        l_0x1010_832a:
            ii(0x1010_832a, 2);  jmp(0x1010_8332, 6); goto l_0x1010_8332;/* jmp 0x10108332 */
        l_0x1010_832c:
            ii(0x1010_832c, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1010_8330, 2);  jmp(0x1010_8336, 4); goto l_0x1010_8336;/* jmp 0x10108336 */
        l_0x1010_8332:
            ii(0x1010_8332, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x1010_8336:
            ii(0x1010_8336, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1010_8339, 3);  mov(memb[ss, ebp - 16], al);          /* mov [ebp-0x10], al */
            ii(0x1010_833c, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x1010_833f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_8341, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_8342, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_8343, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_8344, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_8345, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_8346, 1);  ret();                                /* ret */
        }
    }
}
