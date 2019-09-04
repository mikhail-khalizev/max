using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_7489-cd81b558")]
        public void Method_1014_7489()
        {
            ii(0x1014_7489, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1014_748e, 5);  call(Definitions.sys_check_available_stack_size, 0x1_e8bf);/* call 0x10165d52 */
            ii(0x1014_7493, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_7494, 1);  push(esi);                            /* push esi */
            ii(0x1014_7495, 1);  push(edi);                            /* push edi */
            ii(0x1014_7496, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_7497, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_7499, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1014_749f, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_74a2, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1014_74a5, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1014_74a8, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_74ab, 5);  call(0x1014_7395, -0x11b);            /* call 0x10147395 */
            ii(0x1014_74b0, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_74b3, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1014_74b5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_74b8, 5);  call(/* sys */ 0x1018_0f4d, 0x3_9a90);/* call 0x10180f4d */
            ii(0x1014_74bd, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_74c0, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1014_74c2, 5);  mov(eax, StringDefinitions.Control35);/* mov eax, 0x101ad121 */
            ii(0x1014_74c7, 5);  call(/* sys */ 0x1018_0f4d, 0x3_9a81);/* call 0x10180f4d */
            ii(0x1014_74cc, 4);  cmp(memd[ss, ebp - 4], 0);            /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1014_74d0, 2);  if(jz(0x1014_74df, 0xd)) goto l_0x1014_74df;/* jz 0x101474df */
            ii(0x1014_74d2, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_74d5, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1014_74d7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_74da, 5);  call(/* sys */ 0x1018_0f4d, 0x3_9a6e);/* call 0x10180f4d */
        l_0x1014_74df:
            ii(0x1014_74df, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_74e2, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1014_74e4, 5);  mov(eax, StringDefinitions.Control36);/* mov eax, 0x101ad126 */
            ii(0x1014_74e9, 5);  call(/* sys */ 0x1018_0f4d, 0x3_9a5f);/* call 0x10180f4d */
            ii(0x1014_74ee, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_74f0, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_74f1, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_74f2, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_74f3, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_74f4, 1);  ret();                                /* ret */
        }
    }
}
